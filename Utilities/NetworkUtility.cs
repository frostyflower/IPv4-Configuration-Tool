using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ip_config.Utilities {
    public class NetworkUtility {
        public static void EnableDHCP(string adapterName) {
            if (MessageServices.doQuestion("Do you want to enable DHCP?",
                "Confirm?") == DialogResult.Yes) {
                if (!IsEnabledDHCP(adapterName)) {
                    List<string> cmds = new List<string> {
                        $"interface ip set address \"{adapterName}\" dhcp"
                    };
                    ExecuteNetshCommands(cmds);
                } else {
                    MessageServices.doShowError("DHCP is already enabled.");
                }
            }
        }

        public static void SetSingleIPToSystem(string adapterName, string ipAddress,
            string subMask, string defGateway, string dnsFirst, string dnsSecond) {
            if (!string.IsNullOrEmpty(ipAddress)) {
                if (!IsValidIPAddress(ipAddress)) {
                    MessageServices.doShowError("IP address is invalid!");
                    return;
                }
                if (!IsValidIPAddress(subMask)) {
                    MessageServices.doShowError("Subnet mask is invalid!");
                    return;
                }
                if (!IsValidIPAddress(defGateway)) {
                    MessageServices.doShowError("Default gateway is invalid!");
                    return;
                }
            } else {
                MessageServices.doShowError("Please fill in the required* field!");
                return;
            }

            if (!string.IsNullOrEmpty(dnsFirst) && !IsValidIPAddress(dnsFirst)) {
                MessageServices.doShowError("Primary DNS is invalid!");
                return;
            } else if (!string.IsNullOrEmpty(dnsSecond) && !IsValidIPAddress(dnsSecond)) {
                MessageServices.doShowError("Primary DNS is invalid!");
                return;
            }

            List<string> cmds = new List<string>();
            if (!IsEnabledDHCP(adapterName)) {
                cmds.Add($"interface ip set address \"{adapterName}\" dhcp");
            }
            cmds.Add($"interface ip set address \"{adapterName}\" static {ipAddress} {subMask} {defGateway} 1");

            if (!string.IsNullOrEmpty(dnsFirst)) {
                cmds.Add($"interface ip set dns \"{adapterName}\" static {dnsFirst} primary");
                if (!string.IsNullOrEmpty(dnsSecond)) {
                    cmds.Add($"interface ip add dns \"{adapterName}\" {dnsSecond} index=2");
                }
            }
            ExecuteNetshCommands(cmds);
        }

        public static void SetMultiIPToSystem(string adapterName, DataGridView grdIpList) {
            if (grdIpList == null) {
                return;
            }
            List<string> cmds = new List<string>();
            if (!IsEnabledDHCP(adapterName)) {
                cmds.Add($"interface ip set address \"{adapterName}\" dhcp");
            }
            foreach (DataGridViewRow row in grdIpList.Rows) {
                string ipAddress = row.Cells[0].Value.ToString();
                string subnetMask = row.Cells[1].Value.ToString();
                string gate = row.Cells[2].Value.ToString();
                string metric = row.Cells[3].Value.ToString();

                string cmd = null;
                if (row.Index == 0) {
                    cmd = $"interface ip set address \"{adapterName}\" static {ipAddress} {subnetMask} {gate} {metric}";
                } else {
                    cmd = $"interface ipv4 add address \"{adapterName}\" {ipAddress} {subnetMask} {gate} {metric}";
                }
                cmds.Add(cmd);
                if (cmds == null) {
                    MessageServices.doShowError("Something went wrong!");
                    return;
                }
            }
            ExecuteNetshCommands(cmds);
        }

        protected static void ExecuteNetshCommands(List<string> commands) {
            bool allCommandsSuccessful = true;
            StringBuilder errorMessages = new StringBuilder();

            foreach (string cmd in commands) {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", cmd) {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                try {
                    using (Process process = new Process()) {
                        process.StartInfo = processStartInfo;
                        process.Start();
                        //string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();
                        if (process.ExitCode != 0) {
                            allCommandsSuccessful = false;
                            errorMessages.AppendLine($"Command: {cmd}\nError: Cannot execute command!");
                        }
                    }
                } catch (Exception ex) {
                    allCommandsSuccessful = false;
                    errorMessages.AppendLine($"Command: {cmd}\nException: {ex.Message}");
                }
            }

            if (allCommandsSuccessful) {
                MessageServices.doShowInfo("Action completed successfully.");
            } else {
                MessageServices.doShowError($"Something went wrong!\n{errorMessages}");
            }
        }

        public static List<string> GetNetworkAdapterNames() {
            List<string> adapterNames = new List<string>();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces) {
                if (!(networkInterface.Name.Contains("Local Area") ||
                    networkInterface.Name.Contains("Loopback") ||
                    networkInterface.Name.Contains("VM") ||
                    networkInterface.Name.Contains("vEth"))) {
                    adapterNames.Add(networkInterface.Name);
                }
            }
            return adapterNames;
        }

        public static bool IsEnabledDHCP(string adapterName) {
            NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.Name.Equals(adapterName, StringComparison
                .OrdinalIgnoreCase));
            if (networkInterface == null) {
                return false;
            }
            IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
            IPv4InterfaceProperties ipv4Properties = ipProperties.GetIPv4Properties();
            if (ipv4Properties == null) {
                return false;
            }
            bool isDHCPEnabled = ipv4Properties.IsDhcpEnabled;
            return isDHCPEnabled;
        }

        public static bool IsValidIPAddress(string ipAddress) {
            string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            Match match = Regex.Match(ipAddress, pattern);
            return match.Success;
        }

        public static string CalculateSubnetMaskFromCIDR(string ipAddress, int prefixLength) {
            if (!string.IsNullOrEmpty(ipAddress)) {
                if (IsValidIPAddress(ipAddress)) {
                    if (prefixLength < 0 || prefixLength > 32) {
                        throw new ArgumentException("Invalid prefix!");
                    }

                    uint mask = 0xffffffff << (32 - prefixLength);
                    byte[] maskBytes = BitConverter.GetBytes(mask).Reverse().ToArray();

                    return new IPAddress(maskBytes).ToString();
                }
                MessageServices.doShowError("Invalid IP Address!");
            }
            return null;
        }

        public static string CalculateGateway(string ipAddress, byte i) {
            if (!string.IsNullOrEmpty(ipAddress)) {
                if (IsValidIPAddress(ipAddress)) {
                    try {
                        if (IPAddress.TryParse(ipAddress, out IPAddress ip)) {
                            byte[] ipBytes = ip.GetAddressBytes();
                            ipBytes[3] = i;
                            return new IPAddress(ipBytes).ToString();
                        } else {
                            throw new ArgumentException("Invalid IP Address.");
                        }
                    } catch (Exception ex) {
                        MessageServices.doShowError(ex.Message);
                    }
                }
                MessageServices.doShowError("Invalid IP Address!");
            }
            return null;
        }
    }
}

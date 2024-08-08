using ip_config.Utilities;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ip_config.Forms {
    public partial class AdvIpSetting : Form {

        protected HashSet<string> addedIp = new HashSet<string>();

        public AdvIpSetting() {
            InitializeComponent();
            foreach (DataGridViewColumn column in grdIPList.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            FillComboBox();
        }

        private void FillComboBox() {
            List<string> adapters = NetworkUtility.GetNetworkAdapterNames();
            foreach (string adapter in adapters) {
                adapterCombo.Items.Add(adapter);
            }
            if (adapters.Count > 0) {
                adapterCombo.SelectedIndex = 0;
            }
        }

        private void addBtn_Click(object sender, EventArgs e) {
            string ip = txtIp.Text;
            string mask = txtMask.Text;
            string gate = txtGate.Text;
            string metric = txtMetric.Text;

            if (!(string.IsNullOrEmpty(ip) ||
                string.IsNullOrEmpty(mask) ||
                string.IsNullOrEmpty(gate) ||
                string.IsNullOrEmpty(metric))) {

                if (NetworkUtility.IsValidIPAddress(ip) &&
                    NetworkUtility.IsValidIPAddress(mask) &&
                    NetworkUtility.IsValidIPAddress(gate)) {
                    if (Regex.IsMatch(txtMetric.Text, @"^\d+$")) {
                        if (addedIp.Add(ip)) {
                            grdIPList.Rows.Add(ip, mask, gate, metric);
                            return;
                        }
                        MessageServices.doShowError("IP already exist!");
                        return;
                    }
                    MessageServices.doShowError("Metric was not in a correct format!");
                    txtMetric.Text = "1";
                    return;
                }
                MessageServices.doShowError("One or more of the input field is invalid!");
                return;
            }
            MessageServices.doShowError("Please fill in the required* field!");
        }

        private void txtMask_Enter(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMask.Text)) {
                try {
                    int i = Convert.ToInt32(txtBit.Text);
                    if (!string.IsNullOrEmpty(txtBit.Text) && i > 0 && i <= 32) {
                        txtMask.Text = NetworkUtility.CalculateSubnetMaskFromCIDR(txtIp.Text, i);
                    } else {
                        throw new Exception();
                    }
                } catch {
                    MessageServices.doShowError("Invalid prefix!");
                    txtBit.Text = "24";
                }
            }
        }

        private void txtGate_Enter(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtGate.Text)) {
                try {
                    byte i = Convert.ToByte(txtOctet.Text);
                    txtGate.Text = NetworkUtility.CalculateGateway(txtIp.Text, i);
                } catch {
                    MessageServices.doShowError("Last octet was not in the correct format!");
                    txtOctet.Text = "1";
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e) {
            if (MessageServices.doQuestion("Do you want to delete all IP?",
                "Clear?") == DialogResult.Yes) {
                if (grdIPList.Rows.Count > 0) {
                    addedIp.Clear();
                    grdIPList.Rows.Clear();
                    return;
                }
                MessageServices.doShowError("IP list is empty!");
            }
        }

        private void refListBtn_Click(object sender, EventArgs e) {
            adapterCombo.Items.Clear();
            FillComboBox();
            MessageServices.doShowInfo("Network interfaces list refreshed.");
        }

        private void delBtn_Click(object sender, EventArgs e) {
            if (grdIPList.SelectedRows.Count == 0) {
                MessageServices.doShowError("Unable to delete.");
                return;
            }
            if (MessageServices.doQuestion("Confirm delete?", "Delete") == DialogResult.Yes) {
                for (int i = grdIPList.SelectedRows.Count - 1; i >= 0; i--) {
                    DataGridViewRow row = grdIPList.SelectedRows[i];
                    string ipAddress = row.Cells[0].Value.ToString();
                    if (addedIp.Contains(ipAddress)) {
                        addedIp.Remove(ipAddress);
                    }
                    grdIPList.Rows.Remove(row);
                }
            }
        }

        private void applyBtn_Click(object sender, EventArgs e) {
            if (MessageServices.doQuestion($"Do you want to apply these settings?\nIP addresses: {grdIPList.RowCount}", "Apply") == DialogResult.Yes) {
                if (grdIPList.Rows.Count == 0) {
                    MessageServices.doShowError("IP list is empty!");
                    return;
                }
                NetworkUtility.SetMultiIPToSystem(adapterCombo.Text, grdIPList);
            }
        }

        private void AdvIpSetting_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                if (MessageServices.doQuestion("Do you want to close?\nAll set properties here will be cleared.", "Close?") == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }
    }
}

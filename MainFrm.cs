using ip_config.Forms;
using ip_config.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ip_config {
    public partial class MainFrm : Form {
        public MainFrm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            FillComboBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageServices.doQuestion("Do you want to exit?"
                , "Exit") == DialogResult.Yes) {
                Application.Exit();
            }
        }

        //private void btnSave_Click(object sender, EventArgs e) {

        //}

        private void FillComboBox() {
            List<string> adapters = NetworkUtility.GetNetworkAdapterNames();
            foreach (string adapter in adapters) {
                adapterCombo.Items.Add(adapter);
            }
            if (adapters.Count > 0) {
                adapterCombo.SelectedIndex = 0;
            }
        }

        private void refListBtn_Click(object sender, EventArgs e) {
            adapterCombo.Items.Clear();
            FillComboBox();
            MessageServices.doShowInfo("Network interfaces list refreshed.");
        }

        private void advBtn_Click(object sender, EventArgs e) {
            FormUtility.ShowDiag(new AdvIpSetting());
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
                    txtGate.Text = NetworkUtility.CalculateGateway(txtIp.Text, 1);
                } catch {
                    MessageServices.doShowError("Last octet was not in the correct format!");
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            if (MessageServices.doQuestion("Do you want to apply these settings?"
                , "Apply") == DialogResult.Yes) {
                string adapterName = adapterCombo.Text;
                string ipAddress = txtIp.Text;
                string subnetMask = txtMask.Text;
                string defGateway = txtGate.Text;

                string dnsPri = txtDnsFirst.Text;
                string dnsSec = txtDnsSecond.Text;

                NetworkUtility.SetSingleIPToSystem(adapterName, ipAddress, subnetMask, defGateway, dnsPri, dnsSec);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            FormUtility.ShowDiag(new About());
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                if (MessageServices.doQuestion("Do you want to exit?"
                    , "Exit?") == DialogResult.Yes) {
                    Application.Exit();
                } else {
                    e.Cancel = true;
                }
            }
        }

        private void dhcpBtn_Click(object sender, EventArgs e) {
            NetworkUtility.EnableDHCP(adapterCombo.Text);
        }
    }
}

using System.Diagnostics;
using System.Windows.Forms;

namespace ip_config.Forms {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/arcticfrosty");
        }
    }
}

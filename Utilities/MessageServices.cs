using System.Windows.Forms;

namespace ip_config.Utilities {
    public class MessageServices {
        public static void doShowInfo(string message) {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void doShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult doQuestion(string message, string title) {
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }
    }
}

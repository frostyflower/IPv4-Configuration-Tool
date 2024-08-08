using System.Windows.Forms;

namespace ip_config.Utilities {
    public class FormUtility {
        public static void ShowForm(Form frm, bool resizeForm) {
            if (resizeForm) {
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        public static void ShowDiag(Form frm) {
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}

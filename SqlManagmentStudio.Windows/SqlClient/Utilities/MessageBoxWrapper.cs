using System.Windows.Forms;

namespace SqlManagmentStudio.Windows.SqlClient.Utilities
{
    public class MessageBoxWrapper 
    {
        public static DialogResult ShowErrorBox(string title, string description)
        {
            return MessageBox.Show(description, title,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowWarningBox(string title, string description)
        {
            return MessageBox.Show(description, title,
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

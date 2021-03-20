using System.Windows.Forms;

namespace SqlManagmentStudio.Windows.SqlClient.Utilities
{
    public class MessageBoxWrapper 
    {
        public static DialogResult ShowAnErrorForm(string title, string description)
        {
            return MessageBox.Show(description, title,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

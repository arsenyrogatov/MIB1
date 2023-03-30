using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIB1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            loginpasswords_listBox.Items.Clear();
            foreach(KeyValuePair<string, string> keyvalue in PasswordsLogins.loginpasswords)
            {
                loginpasswords_listBox.Items.Add($"логин: {keyvalue.Key} пароль: {keyvalue.Value}");
            }
        }
    }
}

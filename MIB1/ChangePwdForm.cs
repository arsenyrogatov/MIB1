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
    public partial class ChangePwdForm : Form
    {
        public ChangePwdForm()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            PasswordsLogins.ChangePwd(login_textBox.Text, pwd1_textBox.Text, pwd2_textBox.Text);
        }
    }
}

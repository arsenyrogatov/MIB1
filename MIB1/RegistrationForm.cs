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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (PasswordsLogins.Registration(login_textBox.Text, pwd_textBox.Text))
            {
                ChangePwdForm changePwdForm = new ChangePwdForm();
                Close();
                changePwdForm.ShowDialog();
            }
        }
    }
}

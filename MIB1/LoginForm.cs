namespace MIB1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text == "admin" && pwd_textBox.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            if (PasswordsLogins.Login(login_textBox.Text, pwd_textBox.Text))
            {
                ChangePwdForm changePwdForm = new ChangePwdForm();
                changePwdForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
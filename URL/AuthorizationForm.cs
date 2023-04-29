using System;
using System.IO;
using System.Windows.Forms;

namespace URL
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RegisterForm(this);
            form.Show();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы должны ввести логин и пароль");
                return;
            }
            if (loginTextBox.Text == "admin" || passwordTextBox.Text == "admin")
            {
                this.Hide();
                Form form = new AdminForm();
                form.Show();
                form.Disposed += (object s, EventArgs ev) => { Dispose(); };
                return;
            }
            if (File.Exists("users.txt"))
            {
                foreach (string line in File.ReadAllLines("users.txt"))
                {
                    string[] parts = line.Split(',');
                    string login = parts[0];
                    string password = parts[1];

                    if (loginTextBox.Text == login && passwordTextBox.Text == password)
                    {
                        Logs.Add("Произведен вход в аккаунт " + login);

                        this.Hide();
                        Form form = new MainForm(login);
                        form.Show();
                        form.Disposed += (object s, EventArgs ev) => { Dispose(); };
                        return;
                    }
                }
            }
            
            MessageBox.Show("Логин и/или пароль введены неверно", "Ошибка!");
        }
    }
}

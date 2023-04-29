using System;
using System.IO;
using System.Windows.Forms;

namespace URL
{
    public partial class RegisterForm : Form
    {
        private readonly AuthorizationForm authorizationForm;

        public RegisterForm(AuthorizationForm authorizationForm)
        {
            InitializeComponent();
            this.authorizationForm = authorizationForm;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы должны ввести логин и пароль");
                return;
            }
            if (loginTextBox.Text == "admin")
            {
                MessageBox.Show("Логин не может быть словом admin");
                return;
            }
            if (passwordTextBox.Text != secondPasswordTextBox.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
                return;
            }

            foreach (string line in File.ReadAllLines("users.txt"))
            {
                if (line.Contains(loginTextBox.Text + ","))
                {
                    MessageBox.Show("Такой логин уже есть в системе");
                    this.Dispose();
                    authorizationForm.Show();
                    return;
                }
            }

            string newEntry = $"{loginTextBox.Text},{passwordTextBox.Text}";
            using (StreamWriter file = new StreamWriter("users.txt", true))
            {
                file.WriteLine(newEntry);
            }

            Logs.Add("Зарегистрирован новый аккаунт: " + loginTextBox.Text);

            this.Dispose();
            authorizationForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            authorizationForm.Show();
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace URL
{
    public partial class MainForm : Form
    {
        private string login;

        public MainForm(string login)
        {
            InitializeComponent();
            this.login = login; 
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            string pattern = "(?:([a-zA-Z]+)\\://)?([a-zA-Z0-9\\-\\.]+):?([0-9]*)?/?([a-zA-Z0-9\\-\\._\\?\\,\\'/\\\\\\+&amp;%\\$#\\=~]*)";

            Regex r = new Regex(pattern);
            MatchCollection matches = r.Matches(urlField.Text);
            int matchesCount = matches.Count;

            if (matchesCount == 1 && char.IsLetter(matches[0].Groups[2].Value[0]))
            {
                protocolText.Text = matches[0].Groups[1].Value;
                hostText.Text = matches[0].Groups[2].Value;
                portText.Text = matches[0].Groups[3].Value;
                pathText.Text = matches[0].Groups[4].Value;

                Logs.Add($"Пользователь {login} ввел \"{urlField.Text}\"");
            }
            else
            {
                MessageBox.Show("URL введен некорректно", "Ошибка!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание:\nДля повышения эффективности труда веб-программистов требуется приложение для извлечения из введенной гиперссылки таких элементов, как протокол, доменное имя, порт, адрес на сервере. \nДля справки: формат URL - <протокол>://<хост>:<порт>/<URL‐путь>.", "Справка");
        }
    }
}

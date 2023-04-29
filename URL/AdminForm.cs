using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace URL
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt").Dispose();
            }

            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();

            foreach (string line in File.ReadAllLines("users.txt"))
            {
                string[] parts = line.Split(',');
                string username = parts[0];
                string password = parts[1];

                dataGridView1.Rows.Add(username, password);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
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

            foreach (string line in File.ReadAllLines("users.txt"))
            {
                if (line.Contains(loginTextBox.Text + ","))
                {
                    MessageBox.Show("Такой логин уже есть в системе");
                    return;
                }
            }
            string newEntry = $"{loginTextBox.Text},{passwordTextBox.Text}";
            using (StreamWriter file = new StreamWriter("users.txt", true))
            {
                file.WriteLine(newEntry);
            }

            Logs.Add("Зарегистрирован новый аккаунт: " + loginTextBox.Text);

            UpdateTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите удалить выбранные данные?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                string[] lines = File.ReadAllLines("users.txt");
                List<string> newLines = new List<string>();
                
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Logs.Add($"Аккаунт {(string)row.Cells[0].Value} удален администратором");
                }

                foreach (string line in lines)
                {
                    bool delete = false;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (line.Contains((string)row.Cells[0].Value))
                        {
                            delete = true;
                            break;
                        }
                    }

                    if (!delete)
                    {
                        newLines.Add(line);
                    }
                }

                File.WriteAllLines("users.txt", newLines);

                UpdateTable();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void logiButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("logs.txt"))
            {
                File.Create("logs.txt").Dispose();
            }

            Process.Start("logs.txt");
        }
    }
}

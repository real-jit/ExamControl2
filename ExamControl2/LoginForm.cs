using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;

namespace ExamControl2
{
    public partial class LoginForm : Form
    {

        string connectionString = "Host=localhost; Port=5432; Username=postgres; Password=root; Database=shoestore2exam";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT role_id, fio FROM users WHERE login='{txtLogin.Text}' AND password='{txtPassword.Text}'";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int roleId = Convert.ToInt32(reader["role_id"]);
                        string fio = reader["fio"].ToString();

                        if (roleId == 1)
                        {
                            AdminForm adminForm = new AdminForm(fio);
                            adminForm.Show();
                            this.Hide(); // прячем форму но не закрываем
                        }

                        else if (roleId == 2)
                        {
                            ManagerForm managerForm = new ManagerForm(fio);
                            managerForm.Show();
                            this.Hide();
                        }

                        else
                        {
                            UserForm userForm = new UserForm(fio);
                            userForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
            this.Hide();
        }
    }
}

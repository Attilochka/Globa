using Demo_var_6.Classes;
using Demo_var_6.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_var_6
{
    public partial class AuthorizationWindow : Form
    {
        DataBase dataBase = new DataBase();
        public AuthorizationWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var login = loginTexBox.Text;
            var password = passwordTextBox.Text;
            SqlCommand userSelectCommand = new SqlCommand($"Select ID, ID_роль, Логин, Пароль, ФИО from Пользователь Where Логин = '{login}' and Пароль = '{password}'",dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(userSelectCommand);
            DataTable userTable = new DataTable();
            adapter.Fill(userTable);

            if (userTable.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                ProductWindow productWindow = new ProductWindow(userTable);
                productWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Попробуйте еще раз", "Пользователь не найден");
            }

        }

        private void guestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Вы вошли как гость!");
            ProductWindow productWindow = new ProductWindow(3);
            productWindow.Show();
            this.Hide();
        }
    }
}

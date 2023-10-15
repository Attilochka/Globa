using Demo_var_6.Classes;
using Demo_var_6.UserControl;
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

namespace Demo_var_6.Forms
{
    public partial class ProductWindow : Form
    {
        DataBase dataBase = new DataBase();
        string _filter = "";
        string _search = "";
        string _sortDirection = "asc";
        int idRole;
        public ProductWindow(DataTable table)
        {
            InitializeComponent();
            idRole = Convert.ToInt32(table.Rows[0]["ID_Роль"]);
            StartPosition = FormStartPosition.CenterScreen;
            userNameLabel.Text = $"Добро пожаловать, {table.Rows[0][4].ToString()}";
            adminButton(idRole);
        }
        public ProductWindow(int id)
        {
            InitializeComponent();
            idRole = id;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProductWindow_Load(object sender, EventArgs e)
        {
            updateProduct();
        }
        void adminButton(int idRole)
        {
            if ( idRole == 1)
            {
                Button addButton = new Button();
                addButton.Text = "Добавить";
                addButton.AutoSize = true;
                addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
                addButton.Click += new System.EventHandler(this.addButton_Click);
                addButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                addButton.Location = new System.Drawing.Point(763, 12);
                this.Controls.Add(addButton);

            }
        }
        void updateProduct()
        {
            deleteProduct();

            string sql = $"select * from [Товар]";
            if (!String.IsNullOrEmpty(_filter)) 
            {
                sql += $" where [Производитель] = '{_filter}'";
                if (!string.IsNullOrEmpty(_search))
                {
                    sql += $" and ([Наименование] like '%{_search}%' or [Описание] like '%{_search}%')";
                }
            }
            if (!string.IsNullOrEmpty(_search))
            {
                sql += $" where ([Наименование] like '%{_search}%' or [Описание] like '%{_search}%')";
            }
            sql += $" order by [Стоимость] {_sortDirection}";
            SqlCommand command = new SqlCommand(sql,dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Product product = new Product(100, 100 + i * 200, idRole);
                product.productId = table.Rows[i]["Артикул"].ToString();
                product.ProductClicked += AddWindow_AddWindowClosed;
                product.productStock.Text = table.Rows[i]["Кол-во_на_складе"].ToString();
                product.productDesc.Text = table.Rows[i]["Наименование"].ToString() + "\nОписание товара: " + table.Rows[i]["Описание"].ToString() +
                    "\nПроизводитель: " + table.Rows[i]["Производитель"].ToString() + "\nЦена: " + table.Rows[i]["Стоимость"].ToString();
                product.productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    product.productPicture.Image = Image.FromFile($"C:\\Users\\kigyi\\Desktop\\Домашка\\Globa\\Глоба\\Лаба3-6\\Demo_var_6\\Demo_var_6\\Pictures\\{table.Rows[i]["Изображение"].ToString()}");
                }
                catch {
                    product.productPicture.Image = Image.FromFile(table.Rows[i]["Изображение"].ToString());
                }
                this.Controls.Add(product);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddWindow add = new AddWindow();
            add.AddWindowClosed += AddWindow_AddWindowClosed;
            add.ShowDialog();
        }
        private void deleteProduct()
        {
            List<Product> productsToRemove = new List<Product>();
            foreach (Control control in this.Controls)
            {
                if (control is Product)
                {
                    productsToRemove.Add((Product)control);
                }
            }

            foreach (Product product in productsToRemove)
            {
                this.Controls.Remove(product);
                product.Dispose();
            }
        }
        private void AddWindow_AddWindowClosed(object sender, EventArgs e)
        {
            updateProduct();
        }
        private void manufacComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter = manufacComboBox.Text;
            updateProduct();
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priceComboBox.Text == "По возрастанию")
            {
                _sortDirection = "asc";
            }
            else
            {
                _sortDirection = "desc";
            }
            updateProduct();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            _search = searchTextBox.Text;
            updateProduct();
        }
    }
}

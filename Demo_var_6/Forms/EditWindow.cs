using Demo_var_6.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Demo_var_6.UserControl;

namespace Demo_var_6.Forms
{
    public partial class EditWindow : Form
    {
        DataBase dataBase = new DataBase();
        string imagePath;
        EventHandler EditWindowClosed;
        string productID;
        public EditWindow(Product product)
        {
            InitializeComponent();
            productID = product.productId;
        }
        protected virtual void OnEditWindowClosed()
        {
            EditWindowClosed?.Invoke(this, EventArgs.Empty);
        }
        private void EditWindow_Load(object sender, EventArgs e)
        {
            setProductInformation(productID);
        }
        void setProductInformation(string ID)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select Артикул, Наименование, Единица_измерения, [Кол-во_на_складе], Стоимость, Производитель, Поставщик, Категория_товара, Описание, Изображение from Товар Where Артикул = '{ID}'", dataBase.getConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            vendorCodeTextBox.Text = table.Rows[0]["Артикул"].ToString();
            nameTextBox.Text = table.Rows[0]["Наименование"].ToString();
            priceTextBox.Text = table.Rows[0]["Стоимость"].ToString();
            manufacComboBox.Text = table.Rows[0]["Производитель"].ToString();
            providerComboBox.Text = table.Rows[0]["Поставщик"].ToString();
            categoryComboBox.Text = table.Rows[0]["Категория_товара"].ToString();
            descriptionTextBox.Text = table.Rows[0]["Описание"].ToString();
            unitTextBox.Text = table.Rows[0]["Единица_измерения"].ToString();
            countStockTextBox.Text = table.Rows[0]["Кол-во_на_складе"].ToString();
            pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            try { 
                pictureProduct.Image = Image.FromFile(table.Rows[0]["Изображение"].ToString());
                imagePath = table.Rows[0]["Изображение"].ToString();
            }
            catch { 
                pictureProduct.Image = Image.FromFile($"C:\\Users\\kigyi\\Desktop\\Домашка\\Globa\\Глоба\\Лаба3-6\\Demo_var_6\\Demo_var_6\\Pictures\\{table.Rows[0]["Изображение"].ToString()}");
                imagePath = $"C:\\Users\\kigyi\\Desktop\\Домашка\\Globa\\Глоба\\Лаба3-6\\Demo_var_6\\Demo_var_6\\Pictures\\{table.Rows[0]["Изображение"].ToString()}";
            }
            
        }

        private void setPictureButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureProduct.Image = Image.FromFile(openFileDialog.FileName);
                    imagePath = openFileDialog.FileName;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlCommand sqlCommand = new SqlCommand($"update Товар set Наименование = '{nameTextBox.Text}', Стоимость = {priceTextBox.Text}, Производитель = '{manufacComboBox.Text}', " +
            $"Поставщик = '{providerComboBox.Text}', Категория_товара = '{categoryComboBox.Text}', Описание = '{descriptionTextBox.Text}', " +
            $"Изображение = '{imagePath}', [Кол-во_на_складе] = {countStockTextBox.Text} where Артикул = '{productID}'", dataBase.getConnection());
            sqlCommand.ExecuteNonQuery();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnEditWindowClosed();
        }
    }
}

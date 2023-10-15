using Demo_var_6.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_var_6.Forms
{
    public partial class AddWindow : Form
    {
        DataBase dataBase = new DataBase();
        string imagePath = "C:\\Users\\kigyi\\Desktop\\Домашка\\Globa\\Глоба\\Лаба3-6\\Demo_var_6\\Demo_var_6\\Pictures\\picture.png";
        public EventHandler AddWindowClosed;
        public AddWindow()
        {
            InitializeComponent();
            
        }
        protected virtual void OnAddWindowClosed()
        {
            AddWindowClosed?.Invoke(this, EventArgs.Empty);
        }
        private void setPictureButton_Click(object sender, EventArgs e)
        {
            using(var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureProduct.Image = Image.FromFile(openFileDialog.FileName);
                    imagePath = openFileDialog.FileName;
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var price = priceTextBox.Text;
            var manufac = manufacComboBox.Text;
            var provider = providerComboBox.Text;
            var category = categoryComboBox.Text;
            var description = descriptionTextBox.Text;
            var countStock = countStockTextBox.Text;
            var unit = unitTextBox.Text;
            dataBase.openConnection();
            try
            {
                SqlCommand command = new SqlCommand($"insert into Товар (Артикул, Наименование, [Единица_измерения], Стоимость, Производитель, Поставщик, Категория_товара,[Кол-во_на_складе], Описание, Изображение) " +
                    $"values (N'{generationVendorCode()}', N'{name}', N'{unit}', {price}, N'{manufac}', N'{provider}', N'{category}',{countStock}, N'{description}', N'{imagePath}')", dataBase.getConnection());
                command.ExecuteNonQuery();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Попробуйте ещё раз", "Что-то пошло не так");
            }
            

        }
        string generationVendorCode()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int number1 = random.Next(100, 1000);
            int number2 = random.Next(0, 10);

            char letter1 = letters[random.Next(0, letters.Length)];
            char letter2 = letters[random.Next(0, letters.Length)];

            return $"{letter1}{number1}{letter2}{number2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnAddWindowClosed();
        }
    }
}

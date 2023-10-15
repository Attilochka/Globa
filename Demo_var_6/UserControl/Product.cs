using Demo_var_6.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_var_6.UserControl
{
    public class Product: Panel
    {
        public PictureBox productPicture;
        public Label productStock;
        public RichTextBox productDesc;
        public string productId;
        public event EventHandler ProductClicked;
        public Product(int x, int y, int idRole)
        {
            placePanel(x, y);
            initProduct();
            if(idRole != 3)
            {
                this.MouseDoubleClick += Product_MouseDoubleClick;
            }
        }
        private void Product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditWindow editWindow = new EditWindow(this);
            editWindow.FormClosed += (s, args) =>
            {
                ProductClicked?.Invoke(this, EventArgs.Empty);
            };
            editWindow.ShowDialog();
        }

        void initProduct()
        {
            productPicture = new PictureBox();
            productStock = new Label();
            productDesc = new RichTextBox();

            productPicture.Location = new System.Drawing.Point(0, 0);
            productPicture.Name = "Product Image";
            productPicture.Size = new System.Drawing.Size(150, 150);
            this.Controls.Add(productPicture);

            productDesc.Location = new System.Drawing.Point(170, 0);
            productDesc.Size = new System.Drawing.Size(480, 140);
            productDesc.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productDesc.ReadOnly = true;
            this.Controls.Add(productDesc);

            productStock.Location = new System.Drawing.Point(500, 50);
            productStock.Size = new System.Drawing.Size(100, 100);
            productStock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Controls.Add(productStock);
        }
        void placePanel(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "Product Panel";
            this.Size = new System.Drawing.Size(700, 200);
        }
    }
}

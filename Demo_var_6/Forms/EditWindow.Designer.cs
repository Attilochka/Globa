namespace Demo_var_6.Forms
{
    partial class EditWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.vendorCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.setPictureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.countStockTextBox = new System.Windows.Forms.TextBox();
            this.manufacComboBox = new System.Windows.Forms.ComboBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(13, 60);
            this.pictureProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(245, 268);
            this.pictureProduct.TabIndex = 1;
            this.pictureProduct.TabStop = false;
            // 
            // vendorCodeTextBox
            // 
            this.vendorCodeTextBox.Enabled = false;
            this.vendorCodeTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vendorCodeTextBox.Location = new System.Drawing.Point(326, 56);
            this.vendorCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vendorCodeTextBox.Name = "vendorCodeTextBox";
            this.vendorCodeTextBox.Size = new System.Drawing.Size(168, 34);
            this.vendorCodeTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(326, 96);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 34);
            this.nameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(326, 136);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(168, 34);
            this.priceTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(326, 296);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(168, 34);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // setPictureButton
            // 
            this.setPictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.setPictureButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setPictureButton.Location = new System.Drawing.Point(67, 371);
            this.setPictureButton.Name = "setPictureButton";
            this.setPictureButton.Size = new System.Drawing.Size(126, 73);
            this.setPictureButton.TabIndex = 3;
            this.setPictureButton.Text = "Загрузить фото";
            this.setPictureButton.UseVisualStyleBackColor = false;
            this.setPictureButton.Click += new System.EventHandler(this.setPictureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изображение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(515, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(515, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(515, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(515, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество на складе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(515, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Единица измерения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(515, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Поставщик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(515, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Производитель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(515, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Стоимость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(515, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Описание";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(520, 469);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 34);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(659, 469);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 33);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // unitTextBox
            // 
            this.unitTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitTextBox.Location = new System.Drawing.Point(326, 336);
            this.unitTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(168, 34);
            this.unitTextBox.TabIndex = 2;
            // 
            // countStockTextBox
            // 
            this.countStockTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countStockTextBox.Location = new System.Drawing.Point(326, 376);
            this.countStockTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.countStockTextBox.Name = "countStockTextBox";
            this.countStockTextBox.Size = new System.Drawing.Size(168, 34);
            this.countStockTextBox.TabIndex = 2;
            // 
            // manufacComboBox
            // 
            this.manufacComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacComboBox.FormattingEnabled = true;
            this.manufacComboBox.Items.AddRange(new object[] {
            "Triol",
            "trixie",
            "Cat Chow",
            "Fancy Pets",
            "TitBit",
            "Pro Plan",
            "LIKER",
            "True Touch",
            "ZooM",
            "Nobby",
            "Chappy",
            "Dog Chow",
            "Dreames"});
            this.manufacComboBox.Location = new System.Drawing.Point(326, 176);
            this.manufacComboBox.Name = "manufacComboBox";
            this.manufacComboBox.Size = new System.Drawing.Size(168, 34);
            this.manufacComboBox.TabIndex = 8;
            // 
            // providerComboBox
            // 
            this.providerComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Items.AddRange(new object[] {
            "ZooMir",
            "PetShop"});
            this.providerComboBox.Location = new System.Drawing.Point(326, 216);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(168, 34);
            this.providerComboBox.TabIndex = 8;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Для животных",
            "Товары для собак",
            "Товары для кошек"});
            this.categoryComboBox.Location = new System.Drawing.Point(326, 256);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(168, 34);
            this.categoryComboBox.TabIndex = 8;
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(764, 519);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.manufacComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setPictureButton);
            this.Controls.Add(this.countStockTextBox);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.vendorCodeTextBox);
            this.Controls.Add(this.pictureProduct);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditWindow";
            this.Text = "Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditWindow_FormClosed);
            this.Load += new System.EventHandler(this.EditWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.TextBox vendorCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button setPictureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox countStockTextBox;
        private System.Windows.Forms.ComboBox manufacComboBox;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}
namespace Demo_var_6.Forms
{
    partial class ProductWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductWindow));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.manufacComboBox = new System.Windows.Forms.ComboBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(13, 9);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(244, 26);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Добро пожаловать, Гость";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufacComboBox
            // 
            this.manufacComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacComboBox.FormattingEnabled = true;
            this.manufacComboBox.Items.AddRange(new object[] {
            "",
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
            this.manufacComboBox.Location = new System.Drawing.Point(18, 38);
            this.manufacComboBox.Name = "manufacComboBox";
            this.manufacComboBox.Size = new System.Drawing.Size(153, 34);
            this.manufacComboBox.TabIndex = 1;
            this.manufacComboBox.SelectedIndexChanged += new System.EventHandler(this.manufacComboBox_SelectedIndexChanged);
            // 
            // priceComboBox
            // 
            this.priceComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.priceComboBox.Location = new System.Drawing.Point(177, 38);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(147, 34);
            this.priceComboBox.TabIndex = 2;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(412, 46);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(144, 23);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.manufacComboBox);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductWindow";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.ProductWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ComboBox manufacComboBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}
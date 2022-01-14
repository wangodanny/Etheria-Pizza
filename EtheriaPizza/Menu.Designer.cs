namespace EtheriaPizza
{
    partial class pizzaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaMenu));
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPizzaSizeInfo = new System.Windows.Forms.Label();
            this.lblAddToppingsInfo = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.cmbPizzaSize = new System.Windows.Forms.ComboBox();
            this.cmbAddToppings1 = new System.Windows.Forms.ComboBox();
            this.cmbAddToppings2 = new System.Windows.Forms.ComboBox();
            this.cmbAddToppings3 = new System.Windows.Forms.ComboBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.cmbPizzaType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaType.Location = new System.Drawing.Point(12, 44);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(177, 24);
            this.lblPizzaType.TabIndex = 0;
            this.lblPizzaType.Text = "Select Pizza Type";
            this.lblPizzaType.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPizzaSizeInfo
            // 
            this.lblPizzaSizeInfo.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSizeInfo.Location = new System.Drawing.Point(12, 105);
            this.lblPizzaSizeInfo.Name = "lblPizzaSizeInfo";
            this.lblPizzaSizeInfo.Size = new System.Drawing.Size(177, 32);
            this.lblPizzaSizeInfo.TabIndex = 2;
            this.lblPizzaSizeInfo.Text = "Select Pizza Size: ";
            this.lblPizzaSizeInfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAddToppingsInfo
            // 
            this.lblAddToppingsInfo.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToppingsInfo.Location = new System.Drawing.Point(12, 165);
            this.lblAddToppingsInfo.Name = "lblAddToppingsInfo";
            this.lblAddToppingsInfo.Size = new System.Drawing.Size(304, 23);
            this.lblAddToppingsInfo.TabIndex = 3;
            this.lblAddToppingsInfo.Text = "Additional Toppings (£1 each):";
            this.lblAddToppingsInfo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCost.Font = new System.Drawing.Font("Caviar Dreams", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalCost.Image")));
            this.lblTotalCost.Location = new System.Drawing.Point(163, 313);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(192, 40);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // cmbPizzaSize
            // 
            this.cmbPizzaSize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzaSize.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizzaSize.FormattingEnabled = true;
            this.cmbPizzaSize.Items.AddRange(new object[] {
            "Small - £5",
            "Medium - £7.50",
            "Large - £10",
            "Extra Large - £12.50"});
            this.cmbPizzaSize.Location = new System.Drawing.Point(507, 105);
            this.cmbPizzaSize.Name = "cmbPizzaSize";
            this.cmbPizzaSize.Size = new System.Drawing.Size(308, 23);
            this.cmbPizzaSize.TabIndex = 5;
            // 
            // cmbAddToppings1
            // 
            this.cmbAddToppings1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddToppings1.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddToppings1.FormattingEnabled = true;
            this.cmbAddToppings1.Items.AddRange(new object[] {
            "Tomatoes",
            "Olives",
            "Pepperoni",
            "Mozzarella "});
            this.cmbAddToppings1.Location = new System.Drawing.Point(507, 165);
            this.cmbAddToppings1.Name = "cmbAddToppings1";
            this.cmbAddToppings1.Size = new System.Drawing.Size(308, 23);
            this.cmbAddToppings1.TabIndex = 6;
            this.cmbAddToppings1.SelectedIndexChanged += new System.EventHandler(this.cmbAddToppings1_SelectedIndexChanged);
            // 
            // cmbAddToppings2
            // 
            this.cmbAddToppings2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddToppings2.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddToppings2.FormattingEnabled = true;
            this.cmbAddToppings2.Items.AddRange(new object[] {
            "Tomatoes",
            "Olives",
            "Pepperoni",
            "Mozzarella "});
            this.cmbAddToppings2.Location = new System.Drawing.Point(507, 209);
            this.cmbAddToppings2.Name = "cmbAddToppings2";
            this.cmbAddToppings2.Size = new System.Drawing.Size(308, 23);
            this.cmbAddToppings2.TabIndex = 7;
            this.cmbAddToppings2.SelectedIndexChanged += new System.EventHandler(this.cmbAddToppings2_SelectedIndexChanged);
            // 
            // cmbAddToppings3
            // 
            this.cmbAddToppings3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddToppings3.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddToppings3.FormattingEnabled = true;
            this.cmbAddToppings3.Items.AddRange(new object[] {
            "Tomatoes",
            "Olives",
            "Pepperoni",
            "Mozzarella "});
            this.cmbAddToppings3.Location = new System.Drawing.Point(507, 251);
            this.cmbAddToppings3.Name = "cmbAddToppings3";
            this.cmbAddToppings3.Size = new System.Drawing.Size(308, 23);
            this.cmbAddToppings3.TabIndex = 8;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCost.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(392, 322);
            this.txtTotalCost.Multiline = true;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(275, 21);
            this.txtTotalCost.TabIndex = 9;
            this.txtTotalCost.TextChanged += new System.EventHandler(this.txtTotalCost_TextChanged);
            // 
            // cmbPizzaType
            // 
            this.cmbPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzaType.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizzaType.FormattingEnabled = true;
            this.cmbPizzaType.Items.AddRange(new object[] {
            "Meat Feast",
            "Hawiian",
            "Pepperoni",
            "Margarita"});
            this.cmbPizzaType.Location = new System.Drawing.Point(507, 44);
            this.cmbPizzaType.Name = "cmbPizzaType";
            this.cmbPizzaType.Size = new System.Drawing.Size(308, 23);
            this.cmbPizzaType.TabIndex = 10;
            this.cmbPizzaType.SelectedIndexChanged += new System.EventHandler(this.cmbPizzaType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(554, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(853, 392);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(372, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 209);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(154, 211);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(162, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(322, 211);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(159, 54);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pizzaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 392);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.cmbPizzaType);
            this.Controls.Add(this.cmbAddToppings3);
            this.Controls.Add(this.cmbAddToppings2);
            this.Controls.Add(this.cmbAddToppings1);
            this.Controls.Add(this.cmbPizzaSize);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblAddToppingsInfo);
            this.Controls.Add(this.lblPizzaSizeInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPizzaType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pizzaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etheria Pizza Menu";
            this.Load += new System.EventHandler(this.pizzaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPizzaSizeInfo;
        private System.Windows.Forms.Label lblAddToppingsInfo;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ComboBox cmbPizzaSize;
        private System.Windows.Forms.ComboBox cmbAddToppings1;
        private System.Windows.Forms.ComboBox cmbAddToppings2;
        private System.Windows.Forms.ComboBox cmbAddToppings3;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.ComboBox cmbPizzaType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}
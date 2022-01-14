namespace EtheriaPizza
{
    partial class orderConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderConfirm));
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblOrderedAndDelivered = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCollectClose = new System.Windows.Forms.PictureBox();
            this.btnDeliveryClose = new System.Windows.Forms.PictureBox();
            this.btnEditDetails = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollectClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeliveryClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(28, 86);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(261, 31);
            this.lblDelivery.TabIndex = 0;
            this.lblDelivery.Text = "Your delivery details:";
            this.lblDelivery.Visible = false;
            this.lblDelivery.Click += new System.EventHandler(this.lblDelivery_Click);
            // 
            // lblOrderedAndDelivered
            // 
            this.lblOrderedAndDelivered.AutoSize = true;
            this.lblOrderedAndDelivered.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedAndDelivered.Location = new System.Drawing.Point(28, 214);
            this.lblOrderedAndDelivered.Name = "lblOrderedAndDelivered";
            this.lblOrderedAndDelivered.Size = new System.Drawing.Size(151, 31);
            this.lblOrderedAndDelivered.TabIndex = 2;
            this.lblOrderedAndDelivered.Text = "Your Order:";
            this.lblOrderedAndDelivered.Visible = false;
            this.lblOrderedAndDelivered.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(36, 331);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(143, 31);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // txtDelivery
            // 
            this.txtDelivery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelivery.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivery.Location = new System.Drawing.Point(413, 76);
            this.txtDelivery.Multiline = true;
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(363, 52);
            this.txtDelivery.TabIndex = 4;
            this.txtDelivery.Visible = false;
            this.txtDelivery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCollection
            // 
            this.txtCollection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCollection.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollection.Location = new System.Drawing.Point(413, 178);
            this.txtCollection.Multiline = true;
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(363, 108);
            this.txtCollection.TabIndex = 5;
            this.txtCollection.TextChanged += new System.EventHandler(this.txtCollection_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(481, 336);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // btnCollectClose
            // 
            this.btnCollectClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollectClose.Image = ((System.Drawing.Image)(resources.GetObject("btnCollectClose.Image")));
            this.btnCollectClose.Location = new System.Drawing.Point(341, 409);
            this.btnCollectClose.Name = "btnCollectClose";
            this.btnCollectClose.Size = new System.Drawing.Size(138, 78);
            this.btnCollectClose.TabIndex = 10;
            this.btnCollectClose.TabStop = false;
            this.btnCollectClose.Visible = false;
            this.btnCollectClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDeliveryClose
            // 
            this.btnDeliveryClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliveryClose.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliveryClose.Image")));
            this.btnDeliveryClose.Location = new System.Drawing.Point(452, 409);
            this.btnDeliveryClose.Name = "btnDeliveryClose";
            this.btnDeliveryClose.Size = new System.Drawing.Size(138, 78);
            this.btnDeliveryClose.TabIndex = 11;
            this.btnDeliveryClose.TabStop = false;
            this.btnDeliveryClose.Visible = false;
            this.btnDeliveryClose.Click += new System.EventHandler(this.btnDeliveryClose_Click);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDetails.Image")));
            this.btnEditDetails.Location = new System.Drawing.Point(180, 409);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(209, 78);
            this.btnEditDetails.TabIndex = 12;
            this.btnEditDetails.TabStop = false;
            this.btnEditDetails.Visible = false;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(401, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(401, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(387, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(468, 327);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(252, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(89)))), ((int)(((byte)(246)))));
            this.lblDiscount.Location = new System.Drawing.Point(38, 369);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(281, 21);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "A 10% discount has been applied.";
            this.lblDiscount.Visible = false;
            this.lblDiscount.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(817, 499);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(341, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // orderConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 499);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.btnDeliveryClose);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblOrderedAndDelivered);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.btnCollectClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orderConfirm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etheria Pizza: Order Confirmation";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCollectClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeliveryClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblOrderedAndDelivered;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox btnCollectClose;
        private System.Windows.Forms.PictureBox btnDeliveryClose;
        private System.Windows.Forms.PictureBox btnEditDetails;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
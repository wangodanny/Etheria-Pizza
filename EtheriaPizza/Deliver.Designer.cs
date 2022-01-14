namespace EtheriaPizza
{
    partial class Deliver
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
            this.btnSelectPizza = new System.Windows.Forms.Button();
            this.lblConfirmText = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustPostcode = new System.Windows.Forms.TextBox();
            this.txtCustStreet = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectPizza
            // 
            this.btnSelectPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPizza.Location = new System.Drawing.Point(249, 321);
            this.btnSelectPizza.Name = "btnSelectPizza";
            this.btnSelectPizza.Size = new System.Drawing.Size(262, 98);
            this.btnSelectPizza.TabIndex = 19;
            this.btnSelectPizza.Text = "Confirm Details";
            this.btnSelectPizza.UseVisualStyleBackColor = true;
            this.btnSelectPizza.Click += new System.EventHandler(this.btnSelectPizza_Click_1);
            // 
            // lblConfirmText
            // 
            this.lblConfirmText.AutoSize = true;
            this.lblConfirmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmText.Location = new System.Drawing.Point(185, 31);
            this.lblConfirmText.Name = "lblConfirmText";
            this.lblConfirmText.Size = new System.Drawing.Size(399, 31);
            this.lblConfirmText.TabIndex = 18;
            this.lblConfirmText.Text = "The order will be delivered to:";
            this.lblConfirmText.Click += new System.EventHandler(this.lblConfirmText_Click);
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustPhone.Location = new System.Drawing.Point(387, 248);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(288, 20);
            this.txtCustPhone.TabIndex = 17;
            // 
            // txtCustPostcode
            // 
            this.txtCustPostcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustPostcode.Location = new System.Drawing.Point(387, 206);
            this.txtCustPostcode.Name = "txtCustPostcode";
            this.txtCustPostcode.Size = new System.Drawing.Size(288, 20);
            this.txtCustPostcode.TabIndex = 16;
            // 
            // txtCustStreet
            // 
            this.txtCustStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustStreet.Location = new System.Drawing.Point(387, 158);
            this.txtCustStreet.Name = "txtCustStreet";
            this.txtCustStreet.Size = new System.Drawing.Size(288, 20);
            this.txtCustStreet.TabIndex = 15;
            // 
            // txtCustName
            // 
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.Location = new System.Drawing.Point(387, 115);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(288, 20);
            this.txtCustName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(100, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(100, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(267, 24);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Street Name && House Number";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(100, 201);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(89, 24);
            this.lblPostcode.TabIndex = 22;
            this.lblPostcode.Text = "Postcode";
            this.lblPostcode.Click += new System.EventHandler(this.lblPostcode_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(100, 248);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 24);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // Deliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelectPizza);
            this.Controls.Add(this.lblConfirmText);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustPostcode);
            this.Controls.Add(this.txtCustStreet);
            this.Controls.Add(this.txtCustName);
            this.Name = "Deliver";
            this.Text = "Deliver";
            this.Load += new System.EventHandler(this.Deliver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPizza;
        private System.Windows.Forms.Label lblConfirmText;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustPostcode;
        private System.Windows.Forms.TextBox txtCustStreet;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblPhone;
    }
}
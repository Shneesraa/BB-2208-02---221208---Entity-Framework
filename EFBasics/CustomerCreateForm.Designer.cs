namespace EFBasics
{
    partial class CustomerCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket Adı:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 471);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 41);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Telefon :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Fax :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ülke :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Posta Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Bölge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Şehir :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "İletişim Başlığı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ad Soyad :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 371);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 27);
            this.txtPhone.TabIndex = 35;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(153, 410);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(217, 27);
            this.txtFax.TabIndex = 32;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(153, 326);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(217, 27);
            this.txtCountry.TabIndex = 31;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(153, 287);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(217, 27);
            this.txtPostalCode.TabIndex = 30;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(153, 249);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(217, 27);
            this.txtRegion.TabIndex = 29;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(153, 210);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(217, 27);
            this.txtCity.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(153, 171);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 27);
            this.txtAddress.TabIndex = 27;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(153, 133);
            this.txtContactTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(217, 27);
            this.txtContactTitle.TabIndex = 26;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(153, 94);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(217, 27);
            this.txtContactName.TabIndex = 34;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(153, 59);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(217, 27);
            this.txtCompanyName.TabIndex = 34;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(153, 25);
            this.txtCustomerID.Mask = "00000";
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(217, 27);
            this.txtCustomerID.TabIndex = 70;
            this.txtCustomerID.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Müşteri ID:";
            // 
            // CustomerCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 547);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.label1);
            this.Name = "CustomerCreateForm";
            this.Text = "CustomerCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private MaskedTextBox txtPhone;
        private TextBox txtFax;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtContactTitle;
        private TextBox txtContactName;
        private TextBox txtCompanyName;
        private MaskedTextBox txtCustomerID;
        private Label label2;
    }
}
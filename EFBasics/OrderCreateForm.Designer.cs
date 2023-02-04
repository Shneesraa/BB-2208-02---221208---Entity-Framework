namespace EFBasics
{
    partial class OrderCreateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.dateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dateRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dateShippedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.numFreight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnAddOrderDetail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satıcı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sipariş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Termin Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gönderi Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kargo Şirketi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kargo Bedeli";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(129, 34);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(286, 28);
            this.cmbCustomer.TabIndex = 0;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(129, 73);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(286, 28);
            this.cmbEmployee.TabIndex = 1;
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.Location = new System.Drawing.Point(129, 110);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Size = new System.Drawing.Size(286, 27);
            this.dateOrderDate.TabIndex = 2;
            // 
            // dateRequiredDate
            // 
            this.dateRequiredDate.Location = new System.Drawing.Point(129, 149);
            this.dateRequiredDate.Name = "dateRequiredDate";
            this.dateRequiredDate.Size = new System.Drawing.Size(286, 27);
            this.dateRequiredDate.TabIndex = 3;
            // 
            // dateShippedDate
            // 
            this.dateShippedDate.Location = new System.Drawing.Point(129, 188);
            this.dateShippedDate.Name = "dateShippedDate";
            this.dateShippedDate.Size = new System.Drawing.Size(286, 27);
            this.dateShippedDate.TabIndex = 4;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(129, 229);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(286, 28);
            this.cmbShipVia.TabIndex = 5;
            // 
            // numFreight
            // 
            this.numFreight.Location = new System.Drawing.Point(129, 269);
            this.numFreight.Name = "numFreight";
            this.numFreight.Size = new System.Drawing.Size(286, 27);
            this.numFreight.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şirket Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adresi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ülke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Şehir:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Posta Kodu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Bölgesi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtShipAddress);
            this.groupBox1.Controls.Add(this.txtShipPostalCode);
            this.groupBox1.Controls.Add(this.txtShipCity);
            this.groupBox1.Controls.Add(this.txtShipRegion);
            this.groupBox1.Controls.Add(this.txtShipCountry);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(475, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Bilgileri";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(144, 231);
            this.txtShipAddress.Multiline = true;
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(224, 65);
            this.txtShipAddress.TabIndex = 5;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(144, 192);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(224, 27);
            this.txtShipPostalCode.TabIndex = 4;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(144, 153);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(224, 27);
            this.txtShipCity.TabIndex = 3;
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(144, 114);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(224, 27);
            this.txtShipRegion.TabIndex = 2;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(144, 75);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(224, 27);
            this.txtShipCountry.TabIndex = 1;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(144, 33);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(224, 27);
            this.txtShipName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numFreight);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbShipVia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateShippedDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateRequiredDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateOrderDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbEmployee);
            this.groupBox2.Controls.Add(this.cmbCustomer);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 324);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdOrderDetails);
            this.groupBox3.Controls.Add(this.btnAddOrderDetail);
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 322);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş Detayları";
            // 
            // grdOrderDetails
            // 
            this.grdOrderDetails.AllowUserToAddRows = false;
            this.grdOrderDetails.AllowUserToDeleteRows = false;
            this.grdOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colUnitPrice,
            this.colQuantity,
            this.colDiscount,
            this.colTotalAmount,
            this.colDelete});
            this.grdOrderDetails.Location = new System.Drawing.Point(19, 61);
            this.grdOrderDetails.Name = "grdOrderDetails";
            this.grdOrderDetails.ReadOnly = true;
            this.grdOrderDetails.RowHeadersWidth = 51;
            this.grdOrderDetails.RowTemplate.Height = 29;
            this.grdOrderDetails.Size = new System.Drawing.Size(833, 255);
            this.grdOrderDetails.TabIndex = 1;
            // 
            // btnAddOrderDetail
            // 
            this.btnAddOrderDetail.Location = new System.Drawing.Point(731, 26);
            this.btnAddOrderDetail.Name = "btnAddOrderDetail";
            this.btnAddOrderDetail.Size = new System.Drawing.Size(121, 29);
            this.btnAddOrderDetail.TabIndex = 0;
            this.btnAddOrderDetail.Text = "Ürün Ekle";
            this.btnAddOrderDetail.UseVisualStyleBackColor = true;
            this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(770, 693);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 693);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.Frozen = true;
            this.colProductName.HeaderText = "Ürün";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 125;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Fiyat";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 125;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Miktar";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 125;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "İskonto";
            this.colDiscount.MinimumWidth = 6;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 125;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "Toplam Tutar";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Width = 125;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Ürünü Sil";
            this.colDelete.UseColumnTextForLinkValue = true;
            this.colDelete.Width = 125;
            // 
            // OrderCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 729);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderCreateForm";
            this.Text = "OrderCreateForm";
            this.Load += new System.EventHandler(this.OrderCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbCustomer;
        private ComboBox cmbEmployee;
        private DateTimePicker dateOrderDate;
        private DateTimePicker dateRequiredDate;
        private DateTimePicker dateShippedDate;
        private ComboBox cmbShipVia;
        private NumericUpDown numFreight;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private GroupBox groupBox1;
        private TextBox txtShipRegion;
        private TextBox txtShipCountry;
        private TextBox txtShipName;
        private TextBox txtShipAddress;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCity;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView grdOrderDetails;
        private Button btnAddOrderDetail;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewLinkColumn colDelete;
    }
}
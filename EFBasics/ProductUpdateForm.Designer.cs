namespace EFBasics
{
    partial class ProductUpdateForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.numReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.numUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.numUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Güncelle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(156, 371);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(96, 24);
            this.chkDiscontinued.TabIndex = 24;
            this.chkDiscontinued.Text = "Pasif Ürün";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.Location = new System.Drawing.Point(156, 327);
            this.numReorderLevel.Name = "numReorderLevel";
            this.numReorderLevel.Size = new System.Drawing.Size(235, 27);
            this.numReorderLevel.TabIndex = 23;
            // 
            // numUnitsOnOrder
            // 
            this.numUnitsOnOrder.Location = new System.Drawing.Point(156, 284);
            this.numUnitsOnOrder.Name = "numUnitsOnOrder";
            this.numUnitsOnOrder.Size = new System.Drawing.Size(235, 27);
            this.numUnitsOnOrder.TabIndex = 22;
            // 
            // numUnitsInStock
            // 
            this.numUnitsInStock.Location = new System.Drawing.Point(156, 240);
            this.numUnitsInStock.Name = "numUnitsInStock";
            this.numUnitsInStock.Size = new System.Drawing.Size(235, 27);
            this.numUnitsInStock.TabIndex = 21;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.Location = new System.Drawing.Point(156, 205);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(235, 27);
            this.numUnitPrice.TabIndex = 20;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(156, 122);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(235, 28);
            this.cmbSupplier.TabIndex = 19;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(156, 82);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(235, 28);
            this.cmbCategory.TabIndex = 18;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(156, 165);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(235, 27);
            this.txtQuantityPerUnit.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 27);
            this.txtName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Birim Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ürün Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kritik Stok Eşiği:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gelecek Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stok Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Paket İçeriği:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tedarikçi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kategorisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ürün ID:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(156, 6);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(235, 27);
            this.txtProductID.TabIndex = 16;
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.numReorderLevel);
            this.Controls.Add(this.numUnitsOnOrder);
            this.Controls.Add(this.numUnitsInStock);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "ProductUpdateForm";
            this.Text = "ProductUpdateForm";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private CheckBox chkDiscontinued;
        private NumericUpDown numReorderLevel;
        private NumericUpDown numUnitsOnOrder;
        private NumericUpDown numUnitsInStock;
        private NumericUpDown numUnitPrice;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private TextBox txtQuantityPerUnit;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private TextBox txtProductID;
    }
}
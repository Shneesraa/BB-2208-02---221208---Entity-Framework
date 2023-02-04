namespace EFBasics
{
    partial class ProductCreateForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.numUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.numReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategorisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tedarikçi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paket İçeriği:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stok Miktarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gelecek Stok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kritik Stok Eşiği:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün Durumu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Birim Fiyatı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 27);
            this.txtName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(170, 70);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(235, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(170, 110);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(235, 28);
            this.cmbSupplier.TabIndex = 3;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(170, 153);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(235, 27);
            this.txtQuantityPerUnit.TabIndex = 1;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.Location = new System.Drawing.Point(170, 193);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(235, 27);
            this.numUnitPrice.TabIndex = 4;
            // 
            // numUnitsInStock
            // 
            this.numUnitsInStock.Location = new System.Drawing.Point(170, 228);
            this.numUnitsInStock.Name = "numUnitsInStock";
            this.numUnitsInStock.Size = new System.Drawing.Size(235, 27);
            this.numUnitsInStock.TabIndex = 4;
            // 
            // numUnitsOnOrder
            // 
            this.numUnitsOnOrder.Location = new System.Drawing.Point(170, 272);
            this.numUnitsOnOrder.Name = "numUnitsOnOrder";
            this.numUnitsOnOrder.Size = new System.Drawing.Size(235, 27);
            this.numUnitsOnOrder.TabIndex = 4;
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.Location = new System.Drawing.Point(170, 315);
            this.numReorderLevel.Name = "numReorderLevel";
            this.numReorderLevel.Size = new System.Drawing.Size(235, 27);
            this.numReorderLevel.TabIndex = 4;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(170, 359);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(96, 24);
            this.chkDiscontinued.TabIndex = 5;
            this.chkDiscontinued.Text = "Pasif Ürün";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductCreateForm
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
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductCreateForm";
            this.Text = "ProductCreateForm";
            this.Load += new System.EventHandler(this.ProductCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private TextBox txtQuantityPerUnit;
        private NumericUpDown numUnitPrice;
        private NumericUpDown numUnitsInStock;
        private NumericUpDown numUnitsOnOrder;
        private NumericUpDown numReorderLevel;
        private CheckBox chkDiscontinued;
        private Button btnSave;
    }
}
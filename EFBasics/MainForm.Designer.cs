namespace EFBasics
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuCategoryCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryList = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperList = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.tedarikçiYönetimiToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.personelYönetimiToolStripMenuItem,
            this.nakliyeYönetimiToolStripMenuItem,
            this.siparişYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuCategoryCreate,
            this.menuCategoryList});
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // manuCategoryCreate
            // 
            this.manuCategoryCreate.Name = "manuCategoryCreate";
            this.manuCategoryCreate.Size = new System.Drawing.Size(199, 26);
            this.manuCategoryCreate.Text = "Yeni Kategori";
            this.manuCategoryCreate.Click += new System.EventHandler(this.manuCategoryCreate_Click);
            // 
            // menuCategoryList
            // 
            this.menuCategoryList.Name = "menuCategoryList";
            this.menuCategoryList.Size = new System.Drawing.Size(199, 26);
            this.menuCategoryList.Text = "Tüm Kategoriler";
            this.menuCategoryList.Click += new System.EventHandler(this.menuCategoryList_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateProduct,
            this.menuListForm});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi ";
            // 
            // menuCreateProduct
            // 
            this.menuCreateProduct.Name = "menuCreateProduct";
            this.menuCreateProduct.Size = new System.Drawing.Size(177, 26);
            this.menuCreateProduct.Text = "Yeni Ürün";
            this.menuCreateProduct.Click += new System.EventHandler(this.menuCreateProduct_Click);
            // 
            // menuListForm
            // 
            this.menuListForm.Name = "menuListForm";
            this.menuListForm.Size = new System.Drawing.Size(177, 26);
            this.menuListForm.Text = "Tüm Ürünler ";
            this.menuListForm.Click += new System.EventHandler(this.menuListForm_Click);
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            this.tedarikçiYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSupplierCreate,
            this.menuSupplierList});
            this.tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            this.tedarikçiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi ";
            // 
            // menuSupplierCreate
            // 
            this.menuSupplierCreate.Name = "menuSupplierCreate";
            this.menuSupplierCreate.Size = new System.Drawing.Size(205, 26);
            this.menuSupplierCreate.Text = "Yeni tedarikçi ";
            this.menuSupplierCreate.Click += new System.EventHandler(this.menuSupplierCreate_Click);
            // 
            // menuSupplierList
            // 
            this.menuSupplierList.Name = "menuSupplierList";
            this.menuSupplierList.Size = new System.Drawing.Size(205, 26);
            this.menuSupplierList.Text = "Tüm Tedarikçiler ";
            this.menuSupplierList.Click += new System.EventHandler(this.menuSupplierList_Click);
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustomerCreate,
            this.menuCustomerList});
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi ";
            // 
            // menuCustomerCreate
            // 
            this.menuCustomerCreate.Name = "menuCustomerCreate";
            this.menuCustomerCreate.Size = new System.Drawing.Size(195, 26);
            this.menuCustomerCreate.Text = "Yeni Müşteri ";
            this.menuCustomerCreate.Click += new System.EventHandler(this.menuCustomerCreate_Click);
            // 
            // menuCustomerList
            // 
            this.menuCustomerList.Name = "menuCustomerList";
            this.menuCustomerList.Size = new System.Drawing.Size(195, 26);
            this.menuCustomerList.Text = "Tüm Müşteriler ";
            this.menuCustomerList.Click += new System.EventHandler(this.menuCustomerList_Click);
            // 
            // personelYönetimiToolStripMenuItem
            // 
            this.personelYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployeeCreate,
            this.menuEmployeeList});
            this.personelYönetimiToolStripMenuItem.Name = "personelYönetimiToolStripMenuItem";
            this.personelYönetimiToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.personelYönetimiToolStripMenuItem.Text = "Personel Yönetimi ";
            // 
            // menuEmployeeCreate
            // 
            this.menuEmployeeCreate.Name = "menuEmployeeCreate";
            this.menuEmployeeCreate.Size = new System.Drawing.Size(197, 26);
            this.menuEmployeeCreate.Text = "Yeni Personel ";
            this.menuEmployeeCreate.Click += new System.EventHandler(this.menuEmployeeCreate_Click);
            // 
            // menuEmployeeList
            // 
            this.menuEmployeeList.Name = "menuEmployeeList";
            this.menuEmployeeList.Size = new System.Drawing.Size(197, 26);
            this.menuEmployeeList.Text = "Tüm Personeller";
            this.menuEmployeeList.Click += new System.EventHandler(this.menuEmployeeList_Click);
            // 
            // nakliyeYönetimiToolStripMenuItem
            // 
            this.nakliyeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShipperCreate,
            this.menuShipperList});
            this.nakliyeYönetimiToolStripMenuItem.Name = "nakliyeYönetimiToolStripMenuItem";
            this.nakliyeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.nakliyeYönetimiToolStripMenuItem.Text = "Nakliye Yönetimi ";
            // 
            // menuShipperCreate
            // 
            this.menuShipperCreate.Name = "menuShipperCreate";
            this.menuShipperCreate.Size = new System.Drawing.Size(223, 26);
            this.menuShipperCreate.Text = "Yeni Nakliye Firması";
            this.menuShipperCreate.Click += new System.EventHandler(this.menuShipperCreate_Click);
            // 
            // menuShipperList
            // 
            this.menuShipperList.Name = "menuShipperList";
            this.menuShipperList.Size = new System.Drawing.Size(223, 26);
            this.menuShipperList.Text = "Tüm Nakliyeciler";
            this.menuShipperList.Click += new System.EventHandler(this.menuShipperList_Click);
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrderCreate,
            this.menuOrderList});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi ";
            // 
            // menuOrderCreate
            // 
            this.menuOrderCreate.Name = "menuOrderCreate";
            this.menuOrderCreate.Size = new System.Drawing.Size(224, 26);
            this.menuOrderCreate.Text = "Yeni Sipariş ";
            this.menuOrderCreate.Click += new System.EventHandler(this.menuOrderCreate_Click);
            // 
            // menuOrderList
            // 
            this.menuOrderList.Name = "menuOrderList";
            this.menuOrderList.Size = new System.Drawing.Size(224, 26);
            this.menuOrderList.Text = "Tüm Siparişler ";
            this.menuOrderList.Click += new System.EventHandler(this.menuOrderList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 675);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem manuCategoryCreate;
        private ToolStripMenuItem menuCategoryList;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreateProduct;
        private ToolStripMenuItem menuListForm;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuSupplierCreate;
        private ToolStripMenuItem menuSupplierList;
        private ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCustomerCreate;
        private ToolStripMenuItem menuCustomerList;
        private ToolStripMenuItem personelYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuEmployeeCreate;
        private ToolStripMenuItem menuEmployeeList;
        private ToolStripMenuItem nakliyeYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuShipperCreate;
        private ToolStripMenuItem menuShipperList;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuOrderCreate;
        private ToolStripMenuItem menuOrderList;
    }
}
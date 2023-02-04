namespace EFBasics
{
    partial class ProductListForm
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
            this.components = new System.ComponentModel.Container();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuProductUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.AllowUserToDeleteRows = false;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(0, 0);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.RowHeadersWidth = 51;
            this.grdProducts.RowTemplate.Height = 29;
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(800, 450);
            this.grdProducts.TabIndex = 0;
            this.grdProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdProducts_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductUpdate,
            this.menuProductDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // menuProductUpdate
            // 
            this.menuProductUpdate.Name = "menuProductUpdate";
            this.menuProductUpdate.Size = new System.Drawing.Size(132, 24);
            this.menuProductUpdate.Text = "Düzenle";
            this.menuProductUpdate.Click += new System.EventHandler(this.menuProductUpdate_Click);
            // 
            // menuProductDelete
            // 
            this.menuProductDelete.Name = "menuProductDelete";
            this.menuProductDelete.Size = new System.Drawing.Size(132, 24);
            this.menuProductDelete.Text = "Sil";
            this.menuProductDelete.Click += new System.EventHandler(this.menuProductDelete_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProducts);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdProducts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuProductUpdate;
        private ToolStripMenuItem menuProductDelete;
    }
}
namespace EFBasics
{
    partial class SupplierListForm
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
            this.grdSupplier = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSupplierUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSupplier
            // 
            this.grdSupplier.AllowUserToAddRows = false;
            this.grdSupplier.AllowUserToDeleteRows = false;
            this.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplier.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSupplier.Location = new System.Drawing.Point(0, 0);
            this.grdSupplier.MultiSelect = false;
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.ReadOnly = true;
            this.grdSupplier.RowHeadersWidth = 51;
            this.grdSupplier.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSupplier.RowTemplate.Height = 29;
            this.grdSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSupplier.Size = new System.Drawing.Size(800, 450);
            this.grdSupplier.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSupplierUpdate,
            this.menuSupplierDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 52);
            // 
            // menuSupplierUpdate
            // 
            this.menuSupplierUpdate.Name = "menuSupplierUpdate";
            this.menuSupplierUpdate.Size = new System.Drawing.Size(136, 24);
            this.menuSupplierUpdate.Text = "Düzenle ";
            this.menuSupplierUpdate.Click += new System.EventHandler(this.menuSupplierUpdate_Click);
            // 
            // menuSupplierDelete
            // 
            this.menuSupplierDelete.Name = "menuSupplierDelete";
            this.menuSupplierDelete.Size = new System.Drawing.Size(136, 24);
            this.menuSupplierDelete.Text = "Sil ";
            this.menuSupplierDelete.Click += new System.EventHandler(this.menuSupplierDelete_Click);
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSupplier);
            this.Name = "SupplierListForm";
            this.Text = "SupplierListForm";
            this.Load += new System.EventHandler(this.SupplierListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdSupplier;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuSupplierUpdate;
        private ToolStripMenuItem menuSupplierDelete;
    }
}
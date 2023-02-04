namespace EFBasics
{
    partial class CustomerListForm
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
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCustomerUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCustomer
            // 
            this.grdCustomer.AllowUserToAddRows = false;
            this.grdCustomer.AllowUserToDeleteRows = false;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.ContextMenuStrip = this.contextMenuStrip1;
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.Location = new System.Drawing.Point(0, 0);
            this.grdCustomer.MultiSelect = false;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.ReadOnly = true;
            this.grdCustomer.RowHeadersWidth = 51;
            this.grdCustomer.RowTemplate.Height = 29;
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(800, 450);
            this.grdCustomer.TabIndex = 0;
            this.grdCustomer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdCustomer_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustomerUpdate,
            this.menuCustomerDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // menuCustomerUpdate
            // 
            this.menuCustomerUpdate.Name = "menuCustomerUpdate";
            this.menuCustomerUpdate.Size = new System.Drawing.Size(210, 24);
            this.menuCustomerUpdate.Text = "Düzenle";
            this.menuCustomerUpdate.Click += new System.EventHandler(this.menuCustomerUpdate_Click);
            // 
            // menuCustomerDelete
            // 
            this.menuCustomerDelete.Name = "menuCustomerDelete";
            this.menuCustomerDelete.Size = new System.Drawing.Size(210, 24);
            this.menuCustomerDelete.Text = "Sil ";
            this.menuCustomerDelete.Click += new System.EventHandler(this.menuCustomerDelete_Click);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCustomer);
            this.Name = "CustomerListForm";
            this.Text = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdCustomer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuCustomerUpdate;
        private ToolStripMenuItem menuCustomerDelete;
    }
}
namespace EFBasics
{
    partial class EmployeeListForm
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
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEmployeeUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.AllowUserToAddRows = false;
            this.grdEmployee.AllowUserToDeleteRows = false;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.grdEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmployee.Location = new System.Drawing.Point(0, 0);
            this.grdEmployee.MultiSelect = false;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.ReadOnly = true;
            this.grdEmployee.RowHeadersWidth = 51;
            this.grdEmployee.RowTemplate.Height = 29;
            this.grdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployee.Size = new System.Drawing.Size(1184, 595);
            this.grdEmployee.TabIndex = 0;
            this.grdEmployee.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdEmployee_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployeeUpdate,
            this.menuEmployeeDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // menuEmployeeUpdate
            // 
            this.menuEmployeeUpdate.Name = "menuEmployeeUpdate";
            this.menuEmployeeUpdate.Size = new System.Drawing.Size(210, 24);
            this.menuEmployeeUpdate.Text = "Düzenle";
            this.menuEmployeeUpdate.Click += new System.EventHandler(this.menuEmployeeUpdate_Click);
            // 
            // menuEmployeeDelete
            // 
            this.menuEmployeeDelete.Name = "menuEmployeeDelete";
            this.menuEmployeeDelete.Size = new System.Drawing.Size(210, 24);
            this.menuEmployeeDelete.Text = "Sil";
            this.menuEmployeeDelete.Click += new System.EventHandler(this.menuEmployeeDelete_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 595);
            this.Controls.Add(this.grdEmployee);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdEmployee;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuEmployeeUpdate;
        private ToolStripMenuItem menuEmployeeDelete;
    }
}
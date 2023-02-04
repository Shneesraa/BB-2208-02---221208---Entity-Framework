namespace EFBasics
{
    partial class ShipperListForm
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
            this.grdShipper = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuShipperUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdShipper)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdShipper
            // 
            this.grdShipper.AllowUserToAddRows = false;
            this.grdShipper.AllowUserToDeleteRows = false;
            this.grdShipper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShipper.ContextMenuStrip = this.ContextMenuStrip;
            this.grdShipper.Location = new System.Drawing.Point(3, 37);
            this.grdShipper.MultiSelect = false;
            this.grdShipper.Name = "grdShipper";
            this.grdShipper.ReadOnly = true;
            this.grdShipper.RowHeadersWidth = 51;
            this.grdShipper.RowTemplate.Height = 29;
            this.grdShipper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShipper.Size = new System.Drawing.Size(796, 401);
            this.grdShipper.TabIndex = 0;
            this.grdShipper.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdShipper_CellMouseDown);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShipperUpdate,
            this.menuShipperDelete});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(211, 80);
            // 
            // menuShipperUpdate
            // 
            this.menuShipperUpdate.Name = "menuShipperUpdate";
            this.menuShipperUpdate.Size = new System.Drawing.Size(210, 24);
            this.menuShipperUpdate.Text = "Düzenle";
            this.menuShipperUpdate.Click += new System.EventHandler(this.menuShipperUpdate_Click);
            // 
            // menuShipperDelete
            // 
            this.menuShipperDelete.Name = "menuShipperDelete";
            this.menuShipperDelete.Size = new System.Drawing.Size(210, 24);
            this.menuShipperDelete.Text = "Sil";
            this.menuShipperDelete.Click += new System.EventHandler(this.menuShipperDelete_Click);
            // 
            // ShipperListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdShipper);
            this.Name = "ShipperListForm";
            this.Text = "ShipperListForm";
            this.Load += new System.EventHandler(this.ShipperListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShipper)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdShipper;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem menuShipperDelete;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem menuShipperUpdate;
    }
}
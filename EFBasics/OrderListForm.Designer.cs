namespace EFBasics
{
    partial class OrderListForm
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
            this.grdOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            this.grdOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(12, 12);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowHeadersWidth = 51;
            this.grdOrders.RowTemplate.Height = 29;
            this.grdOrders.Size = new System.Drawing.Size(1003, 571);
            this.grdOrders.TabIndex = 0;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 595);
            this.Controls.Add(this.grdOrders);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdOrders;
    }
}
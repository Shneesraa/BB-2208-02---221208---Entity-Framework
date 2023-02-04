using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFBasics
{
    public partial class ShipperListForm : Form
    {
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var shipper = dbContext.Shippers.ToList();
            grdShipper.DataSource = shipper;

        }

        private void grdShipper_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdShipper.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuShipperUpdate_Click(object sender, EventArgs e)
        {
            if (grdShipper.SelectedRows.Count > 0)
            {
                var selectedProduct = (Shipper)grdShipper.SelectedRows[0].DataBoundItem;
                var productUpdateForm = new ShipperUpdateForm(selectedProduct.ShipperID);

                productUpdateForm.Owner = Owner;
                productUpdateForm.Show();
            }
        }

        private void menuShipperDelete_Click(object sender, EventArgs e)
        {
            if (grdShipper.SelectedRows.Count > 0)
            {
                var shipper = (Shipper)grdShipper.SelectedRows[0].DataBoundItem;
                try
                {
                    var dbContext = new NorthwindDbContext();
                    dbContext.Shippers.Remove(shipper);
                    dbContext.SaveChanges();
                    MessageBox.Show("silme işlemi başarılı");
                    grdShipper.DataSource = dbContext.Shippers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }
            }
        }
    }
}

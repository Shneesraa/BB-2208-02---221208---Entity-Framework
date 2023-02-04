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
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void menuSupplierUpdate_Click(object sender, EventArgs e)
        {
            if (grdSupplier.SelectedRows.Count>0)
            {
                var supplier = (Supplier)grdSupplier.SelectedRows[0].DataBoundItem;

            }

        }

        private void menuSupplierDelete_Click(object sender, EventArgs e)
        {
            if (grdSupplier.SelectedRows.Count>0)
            {
                var supplier = (Supplier)grdSupplier.SelectedRows[0].DataBoundItem;
                try
                {
                    var dbContext = new NorthwindDbContext();
                    dbContext.Suppliers.Remove(supplier);
                    dbContext.SaveChanges();
                    MessageBox.Show("Silme Başarılı");
                    grdSupplier.DataSource = dbContext.Suppliers.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var supplier=dbContext.Suppliers.ToList();
            grdSupplier.DataSource=supplier;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFBasics
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var dbContext=new NorthwindDbContext();
            var products=dbContext.Products.ToList();
            grdProducts.DataSource = products;  
        }

        private void grdProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                grdProducts.Rows[e.RowIndex].Selected = true;
            }
        }


        private void menuProductDelete_Click(object sender, EventArgs e)
        {
            if (grdProducts.SelectedRows.Count > 0)
            {
                var product=(Product)grdProducts.SelectedRows[0].DataBoundItem;
                try
                {
                    var dbContext = new NorthwindDbContext();
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                    MessageBox.Show("silme işlemi başarılı");
                    grdProducts.DataSource = dbContext.Products.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }
            }
        }

        private void menuProductUpdate_Click(object sender, EventArgs e)
        {
            if (grdProducts.SelectedRows.Count>0)
            {
                var selectedProduct = (Product)grdProducts.SelectedRows[0].DataBoundItem;
                var productUpdateForm = new ProductUpdateForm(selectedProduct.ProductID);

                productUpdateForm.Owner = Owner;
                productUpdateForm.Show();
            }
        }
    }
}

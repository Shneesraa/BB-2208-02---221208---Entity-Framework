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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var customer=dbContext.Customers.ToList();

            grdCustomer.DataSource = customer;
        }

        private void grdCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {

                grdCustomer.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (grdCustomer.SelectedRows.Count > 0)
            {
                var selectedCustomer = (Customer)grdCustomer.SelectedRows[0].DataBoundItem;

                var categoryUpdateForm = new CustomerUpdateForm();
                categoryUpdateForm.Owner = Owner;
                categoryUpdateForm.Show();
            }

        }

        private void menuCustomerDelete_Click(object sender, EventArgs e)
        {
           
            if (grdCustomer.SelectedRows.Count > 0)
            {
                var customer = (Customer)grdCustomer.SelectedRows[0].DataBoundItem;

                try
                {

                    var dbContext = new NorthwindDbContext();
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();
                    MessageBox.Show("Başarıyla silinmiştir");

                    grdCustomer.DataSource = dbContext.Customers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }
            }
        }
    }
}

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
    public partial class SupplierCreateForm : Form
    {
        public SupplierCreateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                ContactTitle=txtContactTitle.Text,
                Address=txtAddress.Text,
                City=txtAddress.Text,
                Region=txtRegion.Text,
                PostalCode=txtPostalCode.Text,
                Country=txtCountry.Text,
                Phone=txtPhone.Text,
                Fax=txtFax.Text,
                HomePage=txtHomePage.Text,  
            };

            var dbContext = new NorthwindDbContext();
            dbContext.Suppliers.Add(supplier);
            dbContext.SaveChanges();

            MessageBox.Show("Kaydetme Başarılı");
            
        }
    }
}

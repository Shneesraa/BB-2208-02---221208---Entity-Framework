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
    public partial class CustomerCreateForm : Form
    {
        public CustomerCreateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerID=txtCustomerID.Text,
                CompanyName =txtCompanyName.Text,
                ContactName =txtContactName.Text,
                ContactTitle =txtContactTitle.Text, 
                Address = txtAddress.Text,  
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,

            };

            var dbContext = new NorthwindDbContext();
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();

            MessageBox.Show("Kaydetme Başarılı");
        }
    }
}

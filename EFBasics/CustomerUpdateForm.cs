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
    public partial class CustomerUpdateForm : Form
    {
        
        public CustomerUpdateForm()
        {
            InitializeComponent();
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerID=txtCustomerID.Text,
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                ContactTitle=txtContactTitle.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
            };

            var dbContext=new NorthwindDbContext();
            var customerUpdate=dbContext.Customers.Update(customer);
            dbContext.SaveChanges();

            if (customerUpdate !=null)
            {
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
        }

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext=new NorthwindDbContext();
            var customer = dbContext.Customers.Where(c => c.CustomerID == txtCustomerID.Text).SingleOrDefault();

            if (customer!=null)
            {

                txtCustomerID.Text = customer.CustomerID;   
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtAddress.Text = customer.Address;
                txtCity.Text = customer.City;
                txtRegion.Text = customer.Region;
                txtPostalCode.Text = customer.PostalCode;
                txtCountry.Text = customer.Country;
                txtPhone.Text = customer.Phone;
                txtFax.Text = customer.Fax;
            }
            dbContext.SaveChanges();
        }
    }
}

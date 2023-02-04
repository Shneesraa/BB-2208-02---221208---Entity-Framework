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
    public partial class SupplierUpdateForm : Form
    {
        private readonly int  _supplierId;    

        public SupplierUpdateForm(int id)
        {
            InitializeComponent();
            _supplierId = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                SupplierID = _supplierId,
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                ContactTitle=txtContactTitle.Text,
                Address=txtAddress.Text,
                City=txtCity.Text,
                Region=txtRegion.Text,
                PostalCode=txtPostalCode.Text,
                Country=txtCountry.Text,    
                Phone=txtPhone.Text,
                Fax=txtFax.Text,
                HomePage=txtHomePage.Text
            };

            var dbContext = new NorthwindDbContext();
            var supplierUpdate=dbContext.Suppliers.Update(supplier);

            if (supplierUpdate !=null)
            {
                MessageBox.Show("Güncelleme Başarılı");
                Close();
            }
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext=new NorthwindDbContext();
            var supplier=dbContext.Suppliers.Where(s=> s.SupplierID== _supplierId).SingleOrDefault();

            if (supplier != null)
            {
                txtSupplierID.Text = supplier.SupplierID.ToString();
                txtCompanyName.Text = supplier.CompanyName;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
                txtAddress.Text = supplier.Address;
                txtCity.Text = supplier.City;
                txtRegion.Text = supplier.Region;
                txtPostalCode.Text = supplier.PostalCode;
                txtCountry.Text = supplier.Country;
                txtPhone.Text = supplier.Phone;
                txtFax.Text = supplier.Fax;
                txtHomePage.Text=supplier.HomePage;

            }
            dbContext.SaveChanges();
        }
    }
}

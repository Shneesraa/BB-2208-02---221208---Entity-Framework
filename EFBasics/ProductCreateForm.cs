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
    public partial class ProductCreateForm : Form
    {
        public ProductCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductName = txtName.Text,
                CategoryId = (int)cmbCategory.SelectedValue,
                SupplierId = (int)cmbSupplier.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkDiscontinued.Checked,
                                     
            };

            var dbContext = new NorthwindDbContext();
            dbContext.Products.Add(product);    
            dbContext.SaveChanges();    
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();

            //  Category Combo Box
            var categories = dbContext.Categories.ToList();
            cmbCategory.DataSource=categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            //  Supplier Combo Box
            var suppliers = dbContext.Suppliers.ToList();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";
        }
    }
}

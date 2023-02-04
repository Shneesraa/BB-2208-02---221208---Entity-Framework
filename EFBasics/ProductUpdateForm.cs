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
    public partial class ProductUpdateForm : Form
    {
        private readonly int _productId;

        public ProductUpdateForm(int ıd)
        {
            InitializeComponent();
            _productId = ıd;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductID = _productId,
                ProductName = txtName.Text,
                CategoryId = (int)cmbCategory.SelectedValue,
                SupplierId = (int)cmbCategory.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkDiscontinued.Checked,
            };

            var dbContext = new NorthwindDbContext();
            var productUpdate = dbContext.Products.Update(product);
            dbContext.SaveChanges();

            if (productUpdate != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
                Close();

            }
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var products = dbContext.Products.Where(p => p.ProductID == _productId).SingleOrDefault();
           
            //  Category Combo Box
            var categories = dbContext.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            //  Supplier Combo Box
            var suppliers = dbContext.Suppliers.ToList();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";


            if (products != null)
            {     
                txtProductID.Text = products.ProductID.ToString();
                txtName.Text = products.ProductName;
                txtQuantityPerUnit.Text = products.QuantityPerUnit;
                numUnitPrice.Value = (decimal)products.UnitPrice;
                numUnitsInStock.Value = (short)products.UnitsInStock;
                numUnitsOnOrder.Value = (short)products.UnitsOnOrder;
                numReorderLevel.Value=(short)products.ReorderLevel;
                chkDiscontinued.Checked=products.Discontinued;
            }
            dbContext.SaveChanges();
        }
    }
}

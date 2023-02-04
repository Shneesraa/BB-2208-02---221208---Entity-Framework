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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void manuCategoryCreate_Click(object sender, EventArgs e)
        {
            var categoryCreateForm = new CategoryCreateForm();
            categoryCreateForm.Owner = this;
            categoryCreateForm.Show();
        }

        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm();
            categoryListForm.Owner = this;
            categoryListForm.Show();
        }

        private void menuCreateProduct_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.Owner = this;
            productCreateForm.Show();
        }

        private void menuListForm_Click(object sender, EventArgs e)
        {
            var productListForm=new ProductListForm();  
            productListForm.Owner = this;
            productListForm.Show();
        }

        private void menuSupplierCreate_Click(object sender, EventArgs e)
        {
           var supplierCreateForm = new SupplierCreateForm();
            supplierCreateForm.Owner = this;
            supplierCreateForm.Show();
        }

        private void menuSupplierList_Click(object sender, EventArgs e)
        {
            var supplierListForm = new SupplierListForm();
            supplierListForm.Owner = this;
            supplierListForm.Show();
        }

        private void menuCustomerCreate_Click(object sender, EventArgs e)
        {
            var customerCreateForm = new CustomerCreateForm();
            customerCreateForm.Owner = this;
            customerCreateForm.Show();
        }

        private void menuCustomerList_Click(object sender, EventArgs e)
        {
            var customerListForm=new CustomerListForm();
            customerListForm.Owner = this;
            customerListForm.Show();
        }

        private void menuShipperCreate_Click(object sender, EventArgs e)
        {
            var shipperCreateForm = new ShipperCreateForm();
            shipperCreateForm.Owner = this;
            shipperCreateForm.Show();
        }

        private void menuShipperList_Click(object sender, EventArgs e)
        {
            var shipperListForm=new ShipperListForm();
            shipperListForm.Owner = this;
            shipperListForm.Show();
        }

        private void menuEmployeeList_Click(object sender, EventArgs e)
        {
            var employeeListForm=new EmployeeListForm();
            employeeListForm.Owner = this;
            employeeListForm.Show();
        }

        private void menuEmployeeCreate_Click(object sender, EventArgs e)
        {
            var employeeCreateForm=new EmployeeCreateForm();
            employeeCreateForm.Owner = this;
            employeeCreateForm.Show();
        }

        private void menuOrderCreate_Click(object sender, EventArgs e)
        {
            var orderCreateForm=new OrderCreateForm();
            orderCreateForm.Owner = this;
            orderCreateForm.Show(); 

        }

        private void menuOrderList_Click(object sender, EventArgs e)
        {
            var ordersListForm=new OrderListForm(); 
            ordersListForm.Owner = this;
            ordersListForm.Show();
        }
    }
}

using EFBasics.Entities;
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
    //View 
    // Tab orderdan sıralama yapabiliriz. 
    public partial class OrderCreateForm : Form
    {
        private List<OrderDetailViewModel> _orderDetails = new List<OrderDetailViewModel>();

        public OrderCreateForm()
        {
            InitializeComponent();
            grdOrderDetails.AutoGenerateColumns = false;
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {
            var context = new NorthwindDbContext();

            cmbCustomer.DataSource = context.Customers.ToList();
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DisplayMember = "CompanyName";

            cmbEmployee.DataSource = context.Employees.ToList();
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DisplayMember = "FirstName";

            cmbShipVia.DataSource = context.Shippers.ToList();
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex >= 0)
            {
                var customer = (Customer)cmbCustomer.SelectedItem;

                txtShipName.Text = customer.CompanyName;
                txtShipCountry.Text = customer.Country;
                txtShipRegion.Text = customer.Region;
                txtShipCity.Text = customer.City;
                txtShipPostalCode.Text = customer.PostalCode;
                txtShipAddress.Text = customer.Address;
            }
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            var orderDetailEntryForm = new OrderDetailEntryForm();
            orderDetailEntryForm.OrderDetailCreated += OrderDetailEntryForm_OrderDetailCreated;
            orderDetailEntryForm.MdiParent = MdiParent;
            orderDetailEntryForm.Show();

        }

        private void OrderDetailEntryForm_OrderDetailCreated(OrderDetailViewModel orderDetail)
        {
            _orderDetails.Add(orderDetail);

            grdOrderDetails.DataSource = null;
            grdOrderDetails.DataSource = _orderDetails;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validasyonları yapmamız gerekiyor
            //if (cmbCustomer.SelectedIndex < 0)
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
                return;
            }

            var order = new Order();
            order.CustomerID = (string)cmbCustomer.SelectedValue;
            order.EmployeeID = (int)cmbEmployee.SelectedValue;
            order.OrderDate = dateOrderDate.Value;
            order.RequiredDate = dateRequiredDate.Value;
            order.ShippedDate = dateShippedDate.Value;
            order.Freight = numFreight.Value;
            order.ShipVia = (int)cmbShipVia.SelectedValue;

            order.ShipName = txtShipName.Text;
            order.ShipCountry = txtShipCountry.Text;
            order.ShipCity = txtShipCity.Text;
            order.ShipRegion = txtShipRegion.Text;
            order.ShipAddress = txtShipAddress.Text;
            order.ShipPostalCode = txtShipPostalCode.Text;

            // AutoMapper
            foreach (var detailVM in _orderDetails)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductID = detailVM.ProductId,
                    Quantity = detailVM.Quantity,
                    Discount = detailVM.Discount,
                    UnitPrice = detailVM.UnitPrice
                };

                order.Details.Add(orderDetail);
            }

            try
            {
                var context = new NorthwindDbContext();
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

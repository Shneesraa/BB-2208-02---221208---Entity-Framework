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
    public partial class OrderDetailEntryForm : Form
    {
        public OrderDetailEntryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = (Product)cmbProduct.SelectedItem;

            var orderDetail = new OrderDetailViewModel()
            {
                ProductId = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice.HasValue ? product.UnitPrice.Value : 0,
                Quantity = (short)numQuantity.Value,
                Discount = numDiscount.Value,
            };

            OrderDetailCreated(orderDetail);
            Close();
            // Eğer bildiğimiz, klasik yöntemle Formlar arası (nesneler arası)
            // iletişim ile bu işi çözmeye çalışsaydım, aşağıdaki gibi OrderCreateForm
            // üzerindeki public bir metodu çağırıp OrderDetail nesnesini oraya gönderebilirdim
            //_orderCreateForm.AddOrderDetail(orderDetail);


            //OrderDetailCreated(orderDetail);
        }

        public event OrderDetailCreatedEventHandler OrderDetailCreated;

        private void OrderDetailEntryForm_Load(object sender, EventArgs e)
        {
            var context = new NorthwindDbContext();
            cmbProduct.DataSource = context.Products.ToList();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null)
            {
                var product = (Product)cmbProduct.SelectedItem;
                txtUnitPrice.Text = product.UnitPrice.HasValue
                    ? product.UnitPrice.Value.ToString()
                    : string.Empty;
            }
            else
            {
                txtUnitPrice.Text = string.Empty;
            }
        }
    }
}

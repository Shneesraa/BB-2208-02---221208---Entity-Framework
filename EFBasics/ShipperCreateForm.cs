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
    public partial class ShipperCreateForm : Form
    {
        public ShipperCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone=txtPhone.Text,
            };

            var dbContext = new NorthwindDbContext();
            dbContext.Shippers.Add(shipper);
            dbContext.SaveChanges();    

            MessageBox.Show("Kaydetme Başarılı");
            
        }
    }
}

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
    public partial class ShipperUpdateForm : Form
    {
        private readonly int _shipperID;


        public ShipperUpdateForm(int id)
        {
            InitializeComponent();
            _shipperID = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                ShipperID = _shipperID,
                CompanyName=txtCompanyName.Text,
                Phone=txtPhone.Text,    
            };

            var dbContext = new NorthwindDbContext();
            var shipperUpdate= dbContext.Shippers.Update(shipper);
            if (shipperUpdate!=null)
            {
                MessageBox.Show("Güncelleme işlemi başarılı");
                Close();
            }
        }

        private void ShipperUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();   
            var shipper=dbContext.Shippers.Where(s=> s.ShipperID==_shipperID).SingleOrDefault();

            if (shipper!=null)
            {
                txtShipperID.Text = shipper.ShipperID.ToString();
                txtCompanyName.Text = shipper.CompanyName;
                txtPhone.Text = shipper.Phone;
            }
            dbContext.SaveChanges();

        }
    }
}

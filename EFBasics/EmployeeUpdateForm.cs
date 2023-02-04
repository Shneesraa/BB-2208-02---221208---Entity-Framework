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
    public partial class EmployeeUpdateForm : Form
    {
        private readonly int _employeeId;

        public EmployeeUpdateForm(int id)
        {
            InitializeComponent();
            _employeeId = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employee = new Employee()
            {
                EmployeeID=_employeeId,
                FirstName=txtFistName.Text,
                LastName=txtLastName.Text,
                Title=txtTitle.Text,    
                TitleOfCourtesy=txtTitleOfCourtesy.Text,
                BirthDate=dtpBirthDate.Value,    
                HireDate=dtpHireDate.Value,
                Address=txtAddress.Text,
                City=txtCity.Text,
                Region=txtRegion.Text,
                PostalCode=txtPostalCode.Text,
                Country=txtCountry.Text,
                Extension=txtExtension.Text,
                Notes=txtNotes.Text,
                ReportsTo=(int)cmbReportsTo.SelectedValue,

            };

            var dbContext = new NorthwindDbContext();
            var employeeUpdate=dbContext.Employees.Update(employee);
            dbContext.SaveChanges();


            if (employeeUpdate != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
                Close();

            }
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();

            var employee = dbContext.Employees
                         .Where(e => e.EmployeeID == _employeeId).SingleOrDefault();

            if (employee != null)
            {
                txtEmployeeID.Text = employee.EmployeeID.ToString();
                txtFistName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtTitle.Text = employee.Title;
                txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                dtpBirthDate.Value = employee.BirthDate.HasValue ? employee.BirthDate.Value : default;
                dtpHireDate.Value = employee.HireDate.HasValue ? employee.HireDate.Value : default;
                txtAddress.Text = employee.Address;
                txtCity.Text = employee.City;
                txtCountry.Text = employee.Country;
                txtExtension.Text = employee.Extension;
                txtNotes.Text = employee.Notes;
                txtRegion.Text = employee.Region;
                txtPostalCode.Text = employee.PostalCode;
            

                //Reports to Combobox
                var reportsTo = dbContext
                    .Employees
                    .Select(e => new
                    {
                        FullName = e.FirstName + " " + e.LastName,
                        ReportsTo = e.EmployeeID
                    })
                    .ToList();
                cmbReportsTo.DataSource = reportsTo;
                cmbReportsTo.DisplayMember = "FullName";
                cmbReportsTo.ValueMember = "ReportsTo";
                cmbReportsTo.SelectedValue = employee.ReportsTo.HasValue? employee.ReportsTo.Value:default;

               
            }
            dbContext.SaveChanges();
        }
    }
}

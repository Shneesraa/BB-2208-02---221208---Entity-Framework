using Microsoft.EntityFrameworkCore;
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
    public partial class EmployeeCreateForm : Form
    {
        public EmployeeCreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employee = new Employee()
            {
                FirstName = txtFistName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = dtpBirthDate.Value,
                HireDate= dtpHireDate.Value,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone=txtPhone.Text,
                Extension=txtExtension.Text,
                Notes=txtNotes.Text,
                PhotoPath=txtPhotoPath.Text,
                ReportsTo=(int)cmbReportsTo.SelectedValue,

            };

            var dbContext = new NorthwindDbContext();
            var employeeAdd=dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            if (employeeAdd!= null)
            {
                MessageBox.Show("Başarıyla kaydedilmiştir.");
                Close();
            }
        }

        private void EmployeeCreateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var reportsTo = dbContext
                           .Employees
                           .Select(e => new
                           {
                               FullName = e.FirstName + " " + e.LastName,
                               ReportsTo = e.ReportsTo
                           })
                           .ToList();
            cmbReportsTo.DataSource = reportsTo;
            cmbReportsTo.DisplayMember = "FullName";
            cmbReportsTo.ValueMember = "ReportsTo";
            cmbReportsTo.SelectedValue = -1;






        }
    }
}

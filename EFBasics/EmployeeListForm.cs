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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void grdEmployee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                grdEmployee.Rows[e.RowIndex].Selected = true;
            }
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var employeeList=dbContext.Employees.ToList();

            grdEmployee.DataSource = employeeList;
        }

        private void menuEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (grdEmployee.SelectedRows.Count > 0)
            {
                var selectedEmployee = (Employee)grdEmployee.SelectedRows[0].DataBoundItem;
                var employeeUpdateForm = new EmployeeUpdateForm(selectedEmployee.EmployeeID);

                employeeUpdateForm.Owner = Owner;
                employeeUpdateForm.Show();
            }
        }

        private void menuEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (grdEmployee.SelectedRows.Count > 0)
            {
                var employee = (Employee)grdEmployee.SelectedRows[0].DataBoundItem;
                try
                {
                    var dbContext = new NorthwindDbContext();
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();
                    MessageBox.Show("silme işlemi başarılı");
                    grdEmployee.DataSource = dbContext.Employees.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }
            }
        }
    }
}

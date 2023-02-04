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
    public partial class CategoryCreateForm : Form
    {
        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtDescription.Text;

            var dbContext = new NorthwindDbContext();
            dbContext.Categories.Add(category);
            //dbContext.Employees.Add(employee);
            //dbContext.Products.Add(prod1);
            //dbContext.Products.Add(prod2);

            // dbContext -> Unit Of Work -> İş Birimi
            // dbContext'te biriktirilmiş ne kadar EKLENECEK, GÜNCELLENECEK VE/VEYA
            // SİLİNECEK kayıt varsa, bunlar SaveChanges çağırılana kadar veritabanına
            // gönderilmez. Adı üzerinde, dbContext üzerinde memory (RAM) içinde
            // biriktirilir, bekler..

            dbContext.SaveChanges();  // burada bütün tabloları metodlar için Sql' birkere uğramış olur. 
        }
    }
}

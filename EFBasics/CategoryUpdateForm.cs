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
    public partial class CategoryUpdateForm : Form
    {
        private readonly int _categoryId;

        public CategoryUpdateForm(int id)
        {

            InitializeComponent();
            _categoryId = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryID = _categoryId,
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            var dbContext = new NorthwindDbContext();
            var result=dbContext.Categories.Update(category);
            dbContext.SaveChanges();

            if (result !=null)
            {
                MessageBox.Show("Güncelleme Başarılı");
                Close();
            }
        }


        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();
            var category = dbContext.Categories.Where(c => c.CategoryID == _categoryId).SingleOrDefault();

            if (category != null)
            {
                txtCategoryID.Text = category.CategoryID.ToString();
                txtDescription.Text = category.Description;
                txtCategoryName.Text = category.CategoryName;

            }
            dbContext.SaveChanges();
        }
    }
}

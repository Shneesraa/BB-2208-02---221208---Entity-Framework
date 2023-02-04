namespace EFBasics
{
    public partial class CategoryListForm : Form
    {
        // Entity Framework
        // Nedir? Bir ORM'dir
        // ORM Nedir? Object Relational Mapping demektir
        // Yani o ne demekmiþ? Veritabanýndaki tablolarý ve verileri
        // programlama ortamýnda nesnelere dönüþtüren (map'leyen) yapýlar.

        // Dünyadaki tek ORM EF deðildir
        // Dapper (micro-orm)
        // nHibernate
        // LLBLGen

        // Nereden baþlýyoruz?
        // DbContext adýnda bir sýnýf oluþturarak baþlayacaðýz
        // DbContext sýnýfý, baðlanacaðýmýz veritabanýný temsil eden
        // baðlam sýnýfý
        // Ondan sonra, DbContext sýnýfý içerisinde tablolarý temsil edecek olan
        // DbSet property'lerini ekleyeceðiz
        // Ondan sonra servise hazýr, afiyet olsun

        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();

            // DbSet cinsinden propertylerin (yani Repository'lerin) yanýna
            // ToList() veya ToArray() metodunu yazýp çaðýrmak, bizim AdoNet
            // projesinde yazdýðýmýz GetAll() metodunu çaðýrmakla ayný iþ
            var categories = dbContext.Categories.ToList();

            dataGridView1.DataSource = categories;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchValue = textBox1.Text;

            var dbContext = new NorthwindDbContext();

            var searchedCategories = dbContext
                .Categories
                .Where(c => c.CategoryName.Contains(searchValue))
                .Select(c => new
                {
                    Ýsim = c.CategoryName,
                    Açýklama = c.Description
                })
                .ToList();

            var names = new List<string>() {
                "Tsubasa"
            };

            //var searchedCategories = (from c in dbContext.Categories
            //                          where c.CategoryName.Contains(searchValue)
            //                          select new
            //                          {
            //                              Name = c.CategoryName,
            //                              Açýklama = c.Description
            //                          }).ToList();

            dataGridView1.DataSource = searchedCategories;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var category = (Category)dataGridView1.SelectedRows[0].DataBoundItem;

                try
                {
                    
                    var dbContext = new NorthwindDbContext();
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                    // Baþka UOW uyarlamalarýnda bu metodun adýný
                    // Commit, CommitChanges, Apply, ApplyChanges þeklinde görebilirsiniz
                    MessageBox.Show("Baþarýyla silinmiþtir");

                    dataGridView1.DataSource = dbContext.Categories.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme iþlemi baþarýsýz");
                }
            }
        }

        private void menuUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedCategory = (Category)dataGridView1.SelectedRows[0].DataBoundItem;

                var categoryUpdateForm = new CategoryUpdateForm(selectedCategory.CategoryID);
                categoryUpdateForm.Owner = Owner;
                categoryUpdateForm.Show();
            }
        }


        //  grd'de conetxtmenustrip ekle
        // Multiselect false olacak
        // Fullrowselecet 
        // cellmausodown
        // contextmenu sað týk menüsüdür. 
    }
}
namespace EFBasics
{
    public partial class CategoryListForm : Form
    {
        // Entity Framework
        // Nedir? Bir ORM'dir
        // ORM Nedir? Object Relational Mapping demektir
        // Yani o ne demekmi�? Veritaban�ndaki tablolar� ve verileri
        // programlama ortam�nda nesnelere d�n��t�ren (map'leyen) yap�lar.

        // D�nyadaki tek ORM EF de�ildir
        // Dapper (micro-orm)
        // nHibernate
        // LLBLGen

        // Nereden ba�l�yoruz?
        // DbContext ad�nda bir s�n�f olu�turarak ba�layaca��z
        // DbContext s�n�f�, ba�lanaca��m�z veritaban�n� temsil eden
        // ba�lam s�n�f�
        // Ondan sonra, DbContext s�n�f� i�erisinde tablolar� temsil edecek olan
        // DbSet property'lerini ekleyece�iz
        // Ondan sonra servise haz�r, afiyet olsun

        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthwindDbContext();

            // DbSet cinsinden propertylerin (yani Repository'lerin) yan�na
            // ToList() veya ToArray() metodunu yaz�p �a��rmak, bizim AdoNet
            // projesinde yazd���m�z GetAll() metodunu �a��rmakla ayn� i�
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
                    �sim = c.CategoryName,
                    A��klama = c.Description
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
            //                              A��klama = c.Description
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
                    // Ba�ka UOW uyarlamalar�nda bu metodun ad�n�
                    // Commit, CommitChanges, Apply, ApplyChanges �eklinde g�rebilirsiniz
                    MessageBox.Show("Ba�ar�yla silinmi�tir");

                    dataGridView1.DataSource = dbContext.Categories.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme i�lemi ba�ar�s�z");
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
        // contextmenu sa� t�k men�s�d�r. 
    }
}
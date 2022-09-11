using Book.Bussiness.Concrete;

namespace Book.WinFormUI
{
    public partial class Form1 : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        
        public Form1()
        {
            InitializeComponent();

            comboBoxCategories.DataSource = _categoryManager.GetAll();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember ="CategoryID";
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
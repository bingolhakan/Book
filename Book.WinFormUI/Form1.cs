using Book.Bussiness.Concrete;

namespace Book.WinFormUI
{
    public partial class Form1 : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        AuthorManager _authorManager = new AuthorManager();
        MyBookManager _myBookManager = new MyBookManager();
        PublisherManager _publisherManager = new PublisherManager();    
        
        public Form1()
        {
            InitializeComponent();

            comboBoxCategories.DataSource = _categoryManager.GetAll();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember ="CategoryID";

            comboBoxAuthor.DataSource = _authorManager.GetAll();
            comboBoxAuthor.DisplayMember = "Name";
            comboBoxAuthor.ValueMember = "AuthorID";

            comboBoxPublisher.DataSource = _publisherManager.GetAll();
            comboBoxPublisher.DisplayMember = "Name";
            comboBoxPublisher.ValueMember = "PublisherID";

            dataGridView1.DataSource = _myBookManager.GetAll();
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FCategories _fcategories = new FCategories();
            _fcategories.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            FAuthors _fauthors = new FAuthors();
            _fauthors.ShowDialog();
        }

        private void buttonPublisher_Click(object sender, EventArgs e)
        {
            FPublisher _fpublisher = new FPublisher();
            _fpublisher.ShowDialog();
        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
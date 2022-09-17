using Book.Bussiness.Concrete;
using Book.Entities.Concrete;

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

            comboBoxAuthors.DataSource = _authorManager.GetAll();
            comboBoxAuthors.DisplayMember = "Name";
            comboBoxAuthors.ValueMember = "AuthorID";

            comboBoxPublishers.DataSource = _publisherManager.GetAll();
            comboBoxPublishers.DisplayMember = "Name";
            comboBoxPublishers.ValueMember = "PublisherID";

            
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            MyBook _myBook = new MyBook();
            _myBook.Name = textBoxName.Text;
            _myBook.ISBN = textBoxISBN.Text;
            //_myBook.author = ComboBoxAuthors.Text;
            //_myBook.category = comboBoxCategories.Text;
            //_myBook.publisher = comboBoxPublishers.Text;
            _myBookManager.Add(_myBook);
            dataGridView1.DataSource = _myBookManager.GetAll();
            _myBook.Name = "";
            _myBook.ISBN = "";


        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FCategories _fcategories = new FCategories();
            _fcategories.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _myBookManager.GetAll();
 
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxCategories_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCategories.DataSource = _categoryManager.GetAll();
        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
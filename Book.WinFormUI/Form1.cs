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
            _myBook.CategoryID = Int32.Parse(comboBoxCategories.SelectedValue.ToString());
            _myBook.AuthorID = Int32.Parse(comboBoxAuthors.SelectedValue.ToString());
            _myBook.PublisherID = Int32.Parse(comboBoxPublishers.SelectedValue.ToString());
            _myBookManager.Add(_myBook);
            dataGridView1.DataSource = _myBookManager.GetAll();
            MessageBox.Show("Kayýt iþlemi baþarý ile tamamlandý");
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
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
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
 
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

        private void comboBoxAuthors_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxAuthors.DataSource = _authorManager.GetAll();
        }

        private void comboBoxPublishers_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxPublishers.DataSource = _publisherManager.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MyBook _mybook =new MyBook();
            _mybook.Name = textBoxName.Text;
            _mybook.ISBN = textBoxISBN.Text;
            _mybook.AuthorID = comboBoxAuthors.SelectedIndex;
            _mybook.PublisherID = comboBoxPublishers.SelectedIndex;
            _mybook.CategoryID = comboBoxCategories.SelectedIndex;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxISBN.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int result = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            comboBoxCategories.Text = _categoryManager.GetById(result);

        }
    }
}
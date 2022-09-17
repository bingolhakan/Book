using Book.Bussiness.Concrete;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.WinFormUI
{
    public partial class FAuthors : Form
    {
        AuthorManager _authorManager = new AuthorManager();
        public FAuthors()
        {
            InitializeComponent();
            dataGridViewAut.DataSource = _authorManager.GetAll();
            dataGridViewAut.Columns[2].Visible = false;
            dataGridViewAut.Columns[3].Visible = false;
            buttonAutUpdate.Enabled = false;
            buttonAutDelete.Enabled = false;
            
        }

        private void buttonAutInsert_Click(object sender, EventArgs e)
        {
            if (textBoxAutName.Text!="")
            {
                Author author = new Author();
                author.Name = textBoxAutName.Text;
                _authorManager.Add(author);
                dataGridViewAut.DataSource=_authorManager.GetAll();
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
                textBoxAutID.Clear();
                textBoxAutName.Clear();
                buttonAutUpdate.Enabled = false;
                buttonAutDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Name alanı dolu değil, lütfen doldurduktan sonra tekrar deneyiniz!","Hata",MessageBoxButtons.OK);
            }
        }

        private void groupBoxAut_Enter(object sender, EventArgs e)
        {

        }

        private void FAuthors_Load(object sender, EventArgs e)
        {
            dataGridViewAut.DataSource = _authorManager.GetAll();
            textBoxAutID.Enabled = false;
            //Sütunları gizlemek için aşağıdaki kodlar kullanılabilir.
            //dataGridViewAut.Columns[2].Visible = false;
            //dataGridViewAut.Columns[3].Visible = false;
        }

        private void dataGridViewAut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAutID.Text = dataGridViewAut.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxAutName.Text=dataGridViewAut.Rows[e.RowIndex].Cells[1].Value.ToString();
            buttonAutUpdate.Enabled = true;
            buttonAutDelete.Enabled = true;


        }

        private void dataGridViewAut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void textBoxAutName_TextChanged(object sender, EventArgs e)
        {
            buttonAutDelete.Enabled = false;
        }

        private void buttonAutUpdate_Click(object sender, EventArgs e)
        {
            Author _author = _authorManager.GetById(Int32.Parse(textBoxAutID.Text));
            _author.Name = textBoxAutName.Text;
            _authorManager.Update(_author);
            dataGridViewAut.DataSource = _authorManager.GetAll();
            MessageBox.Show("Güncelleme işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            textBoxAutID.Clear();
            textBoxAutName.Clear();
            buttonAutUpdate.Enabled=false;
            buttonAutDelete.Enabled = false;
        }

        private void buttonAutDelete_Click(object sender, EventArgs e)
        {
            Author _author = _authorManager.GetById(Int32.Parse(textBoxAutID.Text));
            _author.IsDelete = true;
            _authorManager.Update(_author);
            dataGridViewAut.DataSource = _authorManager.GetAll();
            MessageBox.Show("Silme işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            textBoxAutID.Clear();
            textBoxAutName.Clear();
            buttonAutUpdate.Enabled = false;
            buttonAutDelete.Enabled = false;
        }
    }
}

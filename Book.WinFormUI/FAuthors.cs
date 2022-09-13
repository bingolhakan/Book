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
        }

        private void buttonAutInsert_Click(object sender, EventArgs e)
        {
            if (textBoxAutName.Text!="")
            {
                Author author = new Author();
                author.Name = textBoxAutName.Text;
                _authorManager.Add(author);
                dataGridViewAut.DataSource=_authorManager.GetAll();
            }
            else
            {
                MessageBox.Show("Name alanı dolu değil, lütfen doldurduktan sonra tekrar deneyiniz!","Hata",MessageBoxButtons.OK);
            }
        }

        private void groupBoxAut_Enter(object sender, EventArgs e)
        {

        }
    }
}

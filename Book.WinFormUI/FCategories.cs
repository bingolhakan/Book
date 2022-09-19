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
    public partial class FCategories : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        public FCategories()
        {
            InitializeComponent();

        }

        private void buttonCatInsert_Click(object sender, EventArgs e)
        {
            if (textBoxCatName.Text!="")
            {
                Category category = new Category();
                category.Name = textBoxCatName.Text;
                _categoryManager.Add(category);
                dataGridViewCat.DataSource = _categoryManager.GetAll();
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
                buttonCatUpdate.Enabled = false;
                buttonCatDelete.Enabled = false;
                textBoxCatID.Clear();
                textBoxCatName.Clear();
            }
            else
            {
                MessageBox.Show("Name alanı boş, lütfen doldurup tekrar deneyiniz","Hata",MessageBoxButtons.OK);
            }
        }

        private void FCategories_Load(object sender, EventArgs e)
        {
            dataGridViewCat.DataSource = _categoryManager.GetAll();
            dataGridViewCat.Columns[2].Visible = false;
            dataGridViewCat.Columns[3].Visible = false;
            textBoxCatID.Enabled = false;
            //Visible: Görünür mü? Enabled:Etkinleştirilmiş mi?
            buttonCatUpdate.Enabled = false;
            buttonCatDelete.Enabled = false;
        }

        private void dataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCatName_TextChanged(object sender, EventArgs e)
        {
            buttonCatDelete.Enabled=false;
        }

        private void buttonCatUpdate_Click(object sender, EventArgs e)
        {
            
            Category _category = _categoryManager.GetById(Int32.Parse(textBoxCatID.Text));
            _category.Name = textBoxCatName.Text;
            _categoryManager.Update(_category);
            MessageBox.Show("Güncelleme İşlemi Başarı ile Tamamlandı", "Bilgi", MessageBoxButtons.OK);
            textBoxCatID.Clear();
            textBoxCatName.Clear();
            buttonCatUpdate.Enabled=false;
            buttonCatDelete.Enabled = false;
            dataGridViewCat.DataSource = _categoryManager.GetAll();

        }

        private void dataGridViewCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCatID.Text = dataGridViewCat.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCatName.Text = dataGridViewCat.Rows[e.RowIndex].Cells[1].Value.ToString();

            buttonCatUpdate.Enabled = true;
            buttonCatDelete.Enabled = true;

            //}
        }

        private void FCategories_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonCatDelete_Click(object sender, EventArgs e)
        {
            Category _category = _categoryManager.GetById(Int32.Parse(textBoxCatID.Text));
           
            _categoryManager.Delete(_category);
            dataGridViewCat.DataSource = _categoryManager.GetAll();
            MessageBox.Show("Silme işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            textBoxCatID.Clear();
            textBoxCatName.Clear();
            buttonCatUpdate.Enabled = false;
            buttonCatDelete.Enabled = false;
        }
    }
}

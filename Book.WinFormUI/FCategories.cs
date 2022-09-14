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
            dataGridViewCat.DataSource = _categoryManager.GetAll();
        }

        private void buttonCatInsert_Click(object sender, EventArgs e)
        {
            if (textBoxCatName.Text!="")
            {
                Category category = new Category();
                category.Name = textBoxCatName.Text;
                _categoryManager.Add(category);
                dataGridViewCat.DataSource = _categoryManager.GetAll();
            }
            
        }

        private void FCategories_Load(object sender, EventArgs e)
        {
            //Visible: Görünür mü? Enabled:Etkinleştirilmiş mi?
            buttonCatUpdate.Enabled=false;
            buttonCatDelete.Enabled = false;
        }

        private void dataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxCatID.Text = dataGridViewCat.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCat.Rows[e.RowIndex];
                int _id = Int32.Parse(row.Cells[0].Value.ToString());
                Category category = CategoryManager.GetById(_id);
                
                buttonCatUpdate.Enabled = true;
                buttonCatDelete.Enabled = true;
            }

        }
    }
}

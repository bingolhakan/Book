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
    }
}

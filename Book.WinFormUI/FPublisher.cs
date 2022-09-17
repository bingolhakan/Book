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
    public partial class FPublisher : Form
    {
        PublisherManager _publisherManager = new PublisherManager();
        public FPublisher()
        {
            InitializeComponent();
            dataGridViewPub.DataSource = _publisherManager.GetAll();
            dataGridViewPub.Columns[2].Visible = false;
            dataGridViewPub.Columns[3].Visible = false;
            buttonPubUpdate.Enabled = false;
            buttonPubDelete.Enabled = false;
        }

        private void FPublisher_Load(object sender, EventArgs e)
        {
            dataGridViewPub.DataSource = _publisherManager.GetAll();
            textBoxPubID.Enabled = false;
        }

        private void buttonPubInsert_Click(object sender, EventArgs e)
        {
            if (textBoxPubName.Text!="")
            {
                Publisher _publisher = new Publisher();
                _publisher.Name = textBoxPubName.Text;
                _publisherManager.Add(_publisher);
                dataGridViewPub.DataSource = _publisherManager.GetAll();
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
                textBoxPubID.Clear();
                textBoxPubName.Clear();
                buttonPubUpdate.Enabled = false;
                buttonPubDelete.Enabled = false;
            }


        }

        private void dataGridViewPub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPubID.Text = dataGridViewPub.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPubName.Text = dataGridViewPub.Rows[e.RowIndex].Cells[1].Value.ToString();
            buttonPubUpdate.Enabled = true;
            buttonPubDelete.Enabled = true;
        }

        private void textBoxPubName_TextChanged(object sender, EventArgs e)
        {
            buttonPubDelete.Enabled=false;
        }

        private void buttonPubUpdate_Click(object sender, EventArgs e)
        {
            Publisher _publisher = _publisherManager.GetById(Int32.Parse(textBoxPubID.Text));
            _publisher.Name = textBoxPubName.Text;
            _publisherManager.Update(_publisher);
            dataGridViewPub.DataSource = _publisherManager.GetAll();
            MessageBox.Show("Güncelleme işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            textBoxPubID.Clear();
            textBoxPubName.Clear();
            buttonPubUpdate.Enabled = false;
            buttonPubDelete.Enabled = false;
        }

        private void buttonPubDelete_Click(object sender, EventArgs e)
        {
            Publisher _publisher = _publisherManager.GetById(int.Parse(textBoxPubID.Text));
            _publisher.IsDelete = true;
            _publisherManager.Update(_publisher);
            dataGridViewPub.DataSource = _publisherManager.GetAll();
            MessageBox.Show("Kayıt başarı ile silindi");
            textBoxPubID.Clear();
            textBoxPubName.Clear();
            buttonPubUpdate.Enabled=false;
            buttonPubDelete.Enabled = false;
        }

        private void groupBoxPub_Enter(object sender, EventArgs e)
        {

        }
    }
}

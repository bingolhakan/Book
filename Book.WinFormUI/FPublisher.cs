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
        }

        private void FPublisher_Load(object sender, EventArgs e)
        {
            dataGridViewPub.DataSource = _publisherManager.GetAll();
        }

        private void buttonPubInsert_Click(object sender, EventArgs e)
        {
            Publisher _publisher = new Publisher();
            _publisher.Name = textBoxPubName.Text;
            _publisherManager.Add(_publisher);
            dataGridViewPub.DataSource = _publisherManager.GetAll();
            textBoxPubName.Text = "";

        }
    }
}

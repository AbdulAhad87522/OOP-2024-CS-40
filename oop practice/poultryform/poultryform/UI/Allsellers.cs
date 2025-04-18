using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poultryform.DL;

namespace poultryform.UI
{
    public partial class Allsellers : Form
    {
        public Allsellers()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            LoadSellersIntoGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSellersIntoGrid();
        }
        private void LoadSellersIntoGrid()
        {
            var sellers = SellerDL.getsellerlist(); // Fetch from DL

            var displayList = sellers.Select(s => new
            {
                Name = s.getname(),
                Phone = s.getphone(),
                CNIC = s.getcnic(),
                Address = s.getaddress()
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Newseller newseller = new Newseller();
            newseller.ShowDialog();
            this.Show();
        }
    }
}

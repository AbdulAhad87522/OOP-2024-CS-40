using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poultryform.BL;
using poultryform.DL;


namespace poultryform.UI
{
    public partial class Newseller : Form
    {
        public Newseller()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //phone
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //cnic
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //address
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            long phone = long.Parse(textBox2.Text);
            long cnic = long.Parse(textBox4.Text);
            string address = richTextBox1.Text;
            if (textBox1 != null && textBox2 != null && textBox4 != null && richTextBox1 != null)
            {
                Seller seller = new Seller(name, phone, cnic, address);
                SellerDL.adduser(seller);
                MessageBox.Show("Seller added successfully.");
            }
            else
            {
                MessageBox.Show("Fill all the credentials.");
            }
        }

        private void Newseller_Load(object sender, EventArgs e)
        {

        }
    }
}

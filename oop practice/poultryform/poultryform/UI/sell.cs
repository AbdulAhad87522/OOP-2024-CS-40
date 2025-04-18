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
    public partial class sell : Form
    {
        Seller s = new Seller();
        public sell()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //weight
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ppkg
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //date
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //name of buyer
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            //address
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //mobile number of buyer
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //discount
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int total = s.gettotal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(textBox3.Text);
            int ppkg = int.Parse(textBox2.Text);
            DateTime date = DateTime.Now;
            string name = textBox6.Text;
            string address = richTextBox3.Text;
            long number = long.Parse(textBox8.Text);
            bool check = SellerDL.checkseller(name);
            if (check)
            {
                if (textBox2 != null && textBox3 != null && textBox6 != null && textBox8 != null && richTextBox3 != null)
                {
                    Seller s = new Seller(name, number, address, date, ppkg, weight);
                    MessageBox.Show("System updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Seller is not registered . Register the seeler first.");
                this.Hide();
                Newseller s = new Newseller();
                s.ShowDialog();
                this.Show();
            }
        }
    }
}

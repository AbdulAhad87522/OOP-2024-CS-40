using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poultryform.UI
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        public string gettextbox1()
        {
            return textBox1.Text;
        }
        public string gettextbox2()
        {
            return textBox2.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = gettextbox1();
            string password = gettextbox2();
            if (textBox1 == null && textBox2 == null)
            {
                MessageBox.Show("Plz enter all the credentials.");
            }
            else
            {
                bool check = UsersDL.checkuser(name, password);
                if (check)
                {
                    MessageBox.Show("Signed in successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup s= new Signup();
            s.ShowDialog();
            this.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poultryform;

namespace poultryform.UI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public string gettextbox1()
        {
            return textBox1.Text;
        }
        public string gettextBox3()
        {
            return textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = gettextbox1();
            string password = gettextBox3();
            if (textBox1 != null && textBox3 != null)
            {
                Users user = new Users(name, password);
                UsersDL.adduser(user);
                MessageBox.Show("User added suuccessfully");
                this.Hide();
                signin s = new signin();
                s.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Plz enter all the credentials first.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.ShowDialog();
            this.Show();
        }
    }
}

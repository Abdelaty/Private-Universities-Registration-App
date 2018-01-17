using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Register_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin", pass = "kareem";
            if (textBox1.Text== user && textBox2.Text== pass)
            {
                MessageBox.Show("Login Sucess");
                AdminUniv b = new AdminUniv();
                b.Show();
                this.Hide();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Main_Form f = new Main_Form();
            f.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Main_Form f = new Main_Form();
            f.Show();
            this.Hide();
        }
    }
}

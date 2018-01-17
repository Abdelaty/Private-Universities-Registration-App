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
    public partial class AdminMustColl : Form
    {
        public AdminMustColl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminUniv x = new AdminUniv();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMust_Medicine x = new AdminMust_Medicine();
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMust_Dental x = new AdminMust_Dental();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMust_pharmacy x = new AdminMust_pharmacy();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMust_Physical x = new AdminMust_Physical();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminMust_Engineering x = new AdminMust_Engineering();
            x.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminMust_InformationTechnology x = new AdminMust_InformationTechnology();
            x.Show();
            this.Hide();
        }
    }
}

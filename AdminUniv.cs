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
    public partial class AdminUniv : Form
    {
        public AdminUniv()
        {
            InitializeComponent();
        }

        private void AdminUniv_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminMustColl x = new AdminMustColl();
            x.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoginForm y = new LoginForm();
            y.Show();
            this.Hide();
        }
    }
}

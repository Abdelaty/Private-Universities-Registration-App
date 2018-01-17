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
    public partial class faculty_of_medicine_must : Form
    {
        public faculty_of_medicine_must()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Must_colleges f = new Must_colleges();
            f.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Must_reg_medicine f = new Must_reg_medicine();
            f.Show();
            this.Hide();
        }
    }
}

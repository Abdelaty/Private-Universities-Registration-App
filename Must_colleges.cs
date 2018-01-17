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
    public partial class Must_colleges : Form
    {
        public Must_colleges()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faculty_of_medicine_must f = new faculty_of_medicine_must();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faculty_of_dental_must f = new Faculty_of_dental_must();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Faculty_of_pharmacy_must f = new Faculty_of_pharmacy_must();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faculty_of_physichal_must f = new Faculty_of_physichal_must();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Faculty_of_eng_must f = new Faculty_of_eng_must();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Faculty_of_it_must f = new Faculty_of_it_must();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Faculty_of_business_must f = new Faculty_of_business_must();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Faculty_of_mass_must f = new Faculty_of_mass_must();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Faculty_of_language_must f = new Faculty_of_language_must();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Faculty_of_bio_must f = new Faculty_of_bio_must();
            f.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Faculty_of_applied_must f = new Faculty_of_applied_must();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Faculty_of_arch_must f = new Faculty_of_arch_must();
            f.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Faculty_of_education_must f = new Faculty_of_education_must();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Must_colleges_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Register_App
{
    public partial class Faculty_of_mass_must : Form
    {
        public Faculty_of_mass_must()
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
            Must_reg_mass f = new Must_reg_mass();
            f.Show();
            this.Hide();
        }
    }
}

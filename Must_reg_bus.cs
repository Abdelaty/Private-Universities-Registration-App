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
    public partial class Must_reg_bus : Form
    {
        public Must_reg_bus()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                 if (textBox1.TextLength < 2)
            {
                MessageBox.Show("يجب أن تكتب اسمك");
            }

           
                else
                {
                    if (textBox3.TextLength < 2)
                    {
                        MessageBox.Show("يجب أن يكون العمر مكون من رقمين");
                    }

                    else
                    {
                        if (textBox4.TextLength < 2)
                        {
                            MessageBox.Show("يجب أن تكتب جنسيتك");
                        }

                        else
                        {

                            if (textBox5.TextLength < 14)
                            {
                                MessageBox.Show("يجب أن يكون الرقم القومي مكون من 14 رقم");
                            }

                            else
                            {
                                if (textBox6.TextLength < 2)
                                {
                                    MessageBox.Show("يجب أن تكتب عنوانك");
                                }

                                else
                                {
                                    if (textBox7.TextLength < 11)
                                    {
                                        MessageBox.Show("يجب ان يكون رقم الهاتف مكون من 11 رقم");
                                    }

                               

                                        else
                                        {
                                            if (textBox9.TextLength < 2)
                                            {
                                                MessageBox.Show("يجب أن تكتب اسم مدرستك");
                                            }

                                            else
                                            {
                                                if (textBox10.TextLength < 2)
                                                {
                                                    MessageBox.Show("يجب أن تدخل مجموعك");
                                                }

                                                else
                                                {
                                                    if (textBox11.TextLength < 2)
                                                    {
                                                        MessageBox.Show("You should write your first name");
                                                    }

                                                   
                                                        else
                                                        {
                                                            if (textBox13.TextLength < 2)
                                                            {
                                                                MessageBox.Show("Your age should be from 2 numbers");
                                                            }

                                                            else
                                                            {
                                                                if (textBox15.TextLength < 14)
                                                                {
                                                                    MessageBox.Show("Your national ID should be 14 numbers");
                                                                }

                                                                else
                                                                {
                                                                    if (textBox14.TextLength < 2)
                                                                    {
                                                                        MessageBox.Show("You should write your nationality ");
                                                                    }

                                                                    else
                                                                    {
                                                                        if (textBox16.TextLength < 2)
                                                                        {
                                                                            MessageBox.Show("You should write your address");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (textBox17.TextLength < 11)
                                                                            {
                                                                                MessageBox.Show("your phone number should be contains 11 numbers");
                                                                            }
                                                                          
                                                                                else
                                                                                {
                                                                                    if (textBox19.TextLength < 2)
                                                                                    {
                                                                                        MessageBox.Show("You should write your school name");
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        if (textBox20.TextLength < 2)
                                                                                        {
                                                                                            MessageBox.Show("You should enter your total grades ");
                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            if (checkBox1.Checked && checkBox2.Checked)
                                                                                            {
                                                                                                MessageBox.Show("Now you are accpet our rulse  لقد قبلت الشروط و الأحكام");
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show(" You should check the acciption    يجب اختيار جملة الموافقة ");
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                }
               }
              }
             }
            }
           }
          }
         }
        }
       }
      }
  

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| gif files(*.gif)|*.gif| jpeg files(*,jpeg)|*.jpeg| bmp files(*.bmp)|*.bmp| wmf files(*.wmf)|*.wmf";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Faculty_of_business_must f = new Faculty_of_business_must();
            f.Show();
            this.Hide();
        }
    }
}

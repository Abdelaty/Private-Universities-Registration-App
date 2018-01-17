using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Register_App
{
    public partial class AdminMust_Dental : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdel\Desktop\register.mdf;Integrated Security=True;Connect Timeout=30");

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;

        public AdminMust_Dental()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AdminMustColl x = new AdminMustColl();
            x.Show();
            this.Hide();
        }

        private void AdminMust_Dental_Load(object sender, EventArgs e)
        {

        }


        private void MustDental_Grad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dental_student_must";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MustDental_Grad.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from DENTAL_STUDENT_MUST where STUDENTNAME=' " + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Data Deleted Successfuly!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DENTAL_STUDENT_MUST where studentname='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MustDental_Grad.DataSource = dt;
            con.Close();
        }
    }
    }


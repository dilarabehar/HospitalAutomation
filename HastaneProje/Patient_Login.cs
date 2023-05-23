using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneProje
{
    public partial class Patient_Login : Form
    {
        public Patient_Login()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Table_Patient where patient_tc=@p1 and patient_pass=@p2",connect.connection());
            command.Parameters.AddWithValue("@p1", msk_tc.Text);
            command.Parameters.AddWithValue("@p2",txt_pass.Text);

            //if data has or not
            SqlDataReader reader = command.ExecuteReader();  

            if(reader.Read())
            {
                Patient_Detail detail = new Patient_Detail();
                //run before Patient_Detail_Load() 
                detail.tc = msk_tc.Text;
                detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD or USERNAME!");
            }

            connect.connection().Close();

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Signup patient_Signup = new Patient_Signup();

            patient_Signup.Show();

        }
    }
}

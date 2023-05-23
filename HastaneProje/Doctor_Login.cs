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
    public partial class Doctor_Login : Form
    {
        public Doctor_Login()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();

        private void Doctor_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Table_Doctor where doctor_tc=@p1 and doctor_pass=@p2",connect.connection());
            cmd.Parameters.AddWithValue("@p1",msk_tc.Text);
            cmd.Parameters.AddWithValue("@p2",txt_pass.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read()) { 

                Doctor_Detail doctor_Detail = new Doctor_Detail();

                doctor_Detail.TC = msk_tc.Text;

                doctor_Detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG PASS OR TC");
            }
        }
    }
}

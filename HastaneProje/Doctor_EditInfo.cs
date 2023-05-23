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
    public partial class Doctor_EditInfo : Form
    {
        public Doctor_EditInfo()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();
        public string TCNO;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_EditInfo_Load(object sender, EventArgs e)
        {
            msk_tc.Text = TCNO;

            SqlCommand cmd = new SqlCommand("select * from Table_Doctor where doctor_tc=@p1",connect.connection());
            cmd.Parameters.AddWithValue("@p1", msk_tc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_name.Text = dr[1].ToString();
                txt_last.Text = dr[2].ToString();
                cmb_branch.Text = dr[3].ToString();
                txt_pass.Text = dr[5].ToString();

            }
            connect.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_Doctor set doctor_name=@p1,doctor_lastname=@p2,doctor_branch=@p3,doctor_pass=@p4 where doctor_tc=@p5", connect.connection());
            cmd.Parameters.AddWithValue("@p1",txt_name.Text);
            cmd.Parameters.AddWithValue("@p2",txt_last.Text);
            cmd.Parameters.AddWithValue("@p3",cmb_branch.Text);
            cmd.Parameters.AddWithValue("@p4",txt_pass.Text);
            cmd.Parameters.AddWithValue("@p5",msk_tc.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("UPDATED");
        }
    }
}

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
    public partial class Edit_Info : Form
    {
        public Edit_Info()
        {
            InitializeComponent();
        }
        public string TCno;
        Sql_Connect connect = new Sql_Connect();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_Patient set patient_name=@p1,patient_lastname=@p2,patient_num=@p3,patient_pass=@p4,patient_gender=@p5 where patient_tc=@p6",connect.connection());
            cmd.Parameters.AddWithValue("@p1",txt_name.Text);
            cmd.Parameters.AddWithValue("@p2",txt_lastname.Text);
            cmd.Parameters.AddWithValue("@p3",msk_num.Text);
            cmd.Parameters.AddWithValue("@p4", txt_pass.Text);
            cmd.Parameters.AddWithValue("@p5",cmb_gender.SelectedIndex);
            cmd.Parameters.AddWithValue("@p6", msk_tc.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Updated!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Edit_Info_Load(object sender, EventArgs e)
        {
            msk_tc.Text = TCno;
            SqlCommand cmd = new SqlCommand("select * from Table_Patient where patient_tc=@p1",connect.connection());
            cmd.Parameters.AddWithValue("@p1",msk_tc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_name.Text = dr[1].ToString();
                txt_lastname.Text = dr[2].ToString();
                msk_num.Text = dr[4].ToString();   
                txt_pass.Text = dr[5].ToString();
                cmb_gender.Text = dr[6].ToString();
               

            }
            connect.connection().Close();

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

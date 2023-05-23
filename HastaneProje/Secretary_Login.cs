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
    public partial class Secretary_Login : Form
    {
        public Secretary_Login()
        {
            InitializeComponent();
        }

        Sql_Connect connect=new Sql_Connect();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Table_Secretary where secretary_tc=@p1 and secretary_pass=@p2",connect.connection());
            cmd.Parameters.AddWithValue("@p1", msk_tc.Text);
            cmd.Parameters.AddWithValue("@p2",txt_pass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                Secretary_Detail detail = new Secretary_Detail();
                detail.TCnum=msk_tc.Text;
                detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UNCORRECT PASS OR TC");
            }
            connect.connection().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

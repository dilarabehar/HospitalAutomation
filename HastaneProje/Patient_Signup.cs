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
    public partial class Patient_Signup : Form
    {
        public Patient_Signup()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();

        private void Patient_Signup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Table_Patient (patient_name,patient_lastname,patient_tc,patient_num,patient_pass,patient_gender) values(@p1,@p2,@p3,@p4,@p5,@p6)",connect.connection());

            command.Parameters.AddWithValue("@p1",txt_name.Text);
            command.Parameters.AddWithValue("@p2",txt_lastname.Text);
            command.Parameters.AddWithValue("@p3",msk_tc.Text);
            command.Parameters.AddWithValue("@p4",msk_num.Text);
            command.Parameters.AddWithValue("@p5",txt_pass.Text);
            command.Parameters.AddWithValue("@p6",cmb_gender.SelectedIndex);
            command.ExecuteNonQuery();

            connect.connection().Close();
            MessageBox.Show("Your Password : " + txt_pass.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

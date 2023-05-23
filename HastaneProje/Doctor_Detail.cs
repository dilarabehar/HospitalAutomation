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
    public partial class Doctor_Detail : Form
    {
        public Doctor_Detail()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();
        public string TC;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Detail_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = TC;

            //name surname
            SqlCommand cmd = new SqlCommand("select doctor_name,doctor_lastname from Table_Doctor where doctor_tc=@p1",connect.connection());
            cmd.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_name.Text = sqlDataReader[0]+" " + sqlDataReader[1];

            }
            connect.connection().Close();

            //appointments
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Table_Appointments where Appointment_doctor='" + lbl_name.Text + "'", connect.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor_EditInfo doctor_EditInfo = new Doctor_EditInfo();
            doctor_EditInfo.TCNO = TC;
            doctor_EditInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView2.Rows[chosen].Cells[7].Value.ToString(); 


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class Patient_Detail : Form
    {
        public Patient_Detail()
        {
            InitializeComponent();
        }

        public string tc;
        
        Sql_Connect connect = new Sql_Connect();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Detail_Load(object sender, EventArgs e)
        {
            //to do when loading
            lbl_tc.Text = tc;
            
            //get name and surname from database 
            SqlCommand commend = new SqlCommand("select patient_name,patient_lastname from Table_Patient where patient_tc=@p1",connect.connection());
            commend.Parameters.AddWithValue("@p1",tc); 
            SqlDataReader reader = commend.ExecuteReader();

            while (reader.Read())
            {
                lbl_name.Text = reader[0].ToString() + " "+ reader[1];
            }

            connect.connection().Close();

            //appointment history
            DataTable dt = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Table_Appointments where patient_tc="+tc,connect.connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //gets the branch from cmb
            SqlCommand sqlCommand = new SqlCommand("select branch_name from Table_Branch",connect.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {

                cmb_branch.Items.Add(sqlDataReader[0]);
            
            }

            connect.connection().Close();
        }

        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doctor.Items.Clear();
            SqlCommand commend = new SqlCommand("select doctor_name,doctor_lastname from Table_Doctor where doctor_branch=@p1", connect.connection());
            commend.Parameters.AddWithValue("@p1", cmb_branch.Text);
            SqlDataReader reader = commend.ExecuteReader();
            while (reader.Read())
            {
                cmb_doctor.Items.Add(reader[0] + " " + reader[1]);
            }
            connect.connection().Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("select * from Table_Appointments where Appointment_branch='"+cmb_branch.Text+"'"+ " and Appointment_doctor= '"+cmb_doctor.Text+"' and Appointment_state=0",connect.connection());
            dataAdapter1.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit_Info edit_Info = new Edit_Info();
            edit_Info.TCno=lbl_tc.Text;
            edit_Info.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_Appointments set Appointment_state=1, Patient_tc=@p1,Patient_Disease=@p2 where Appointment_id=@p3",connect.connection());
            cmd.Parameters.AddWithValue("@p1",lbl_tc.Text);
            cmd.Parameters.AddWithValue("@p2", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@p3",txt_id.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("APPOINTMENT REGISTRATION IS CREATED!");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

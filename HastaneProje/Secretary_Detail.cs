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
    public partial class Secretary_Detail : Form
    {
        public Secretary_Detail()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();

        public string TCnum;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Appointments (Appointment_date,Appointment_time,Appointment_branch,Appointment_doctor) values (@r1,@r2,@r3,@r4)",connect.connection());
            cmd.Parameters.AddWithValue("@r1", msk_date.Text);
            cmd.Parameters.AddWithValue("@r2",msk_time.Text);
            cmd.Parameters.AddWithValue("@r3",cmb_branch.Text);
            cmd.Parameters.AddWithValue("@r4",cmb_doctor.Text);
            cmd.ExecuteNonQuery();

            connect.connection().Close();

            MessageBox.Show("SAVED!");
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor_Panel doctor_Panel = new Doctor_Panel(); 
            doctor_Panel.Show();

        }

        private void Secretary_Detail_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = TCnum;

            //name and surname
            SqlCommand cmd = new SqlCommand("select secretary_name from Table_Secretary where secretary_tc=@p1",connect.connection());
            cmd.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbl_name.Text = reader[0].ToString();
            }
            connect.connection().Close();

            //gets branches
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select branch_name from Table_Branch", connect.connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource=dataTable;

            //gets doctors list
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter = new SqlDataAdapter("select (doctor_name + ' ' + doctor_lastname)as 'Doctors',doctor_branch from Table_Doctor", connect.connection());
            sqlDataAdapter.Fill(dataTable1);
            dataGridView2.DataSource=dataTable1;

            //gets branches to cmbox
            SqlCommand cmd2 = new SqlCommand("select branch_name from Table_Branch", connect.connection());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {
                cmb_branch.Items.Add(reader2[0].ToString());
            }
            connect.connection().Close();

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doctor.Items.Clear();

            SqlCommand cmd = new SqlCommand("select doctor_name,doctor_lastname from Table_Doctor where doctor_branch=@p1", connect.connection());
            cmd.Parameters.AddWithValue("@p1",cmb_branch.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cmb_doctor.Items.Add(reader[0] +" " + reader[1]);

            }

            connect.connection().Close() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into Table_Announcements (announcement) values (@d1)", connect.connection());
            cmd.Parameters.AddWithValue("@d1", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Announcement has been saved!");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Branch frm_Branch = new Frm_Branch();
            frm_Branch.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_AppointmentList frm_AppointmentList = new Frm_AppointmentList(); 
            frm_AppointmentList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
        }
    }
}

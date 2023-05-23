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
    public partial class Doctor_Panel : Form
    {
        public Doctor_Panel()
        {
            InitializeComponent();
        }
        Sql_Connect connect = new Sql_Connect();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Table_Doctor",connect.connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("select branch_name from Table_Branch", connect.connection());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cmb_branch.Items.Add(reader2[0].ToString());
            }
            connect.connection().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Doctor (doctor_name,doctor_lastname,doctor_branch,doctor_tc,doctor_pass) values (@p1,@p2,@p3,@p4,@p5)",connect.connection());
            cmd.Parameters.AddWithValue("@p1", txt_name.Text);
            cmd.Parameters.AddWithValue("@p2", txt_surname.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_branch.Text);
            cmd.Parameters.AddWithValue("@p4", msk_tc.Text);
            cmd.Parameters.AddWithValue("@p5", txt_pass.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("doctor added");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txt_name.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmb_branch.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txt_pass.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Table_Doctor where doctor_tc=@p1",connect.connection());
            cmd.Parameters.AddWithValue("@p1", msk_tc.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("REGISTRATION DELETED");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Table_Doctor set doctor_name=@d1,doctor_lastname=@d2,doctor_branch=@d3,doctor_pass=@d4 where doctor_tc=@d5", connect.connection());
            sqlCommand.Parameters.AddWithValue("@d1", txt_name.Text);
            sqlCommand.Parameters.AddWithValue("@d2", txt_surname.Text);
            sqlCommand.Parameters.AddWithValue("@d3", cmb_branch.Text);
            sqlCommand.Parameters.AddWithValue("@d4", txt_pass.Text);
            sqlCommand.Parameters.AddWithValue("@d5", msk_tc.Text);

            sqlCommand.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("REGISTRATION UPDATED");

        }
    }
}

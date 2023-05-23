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
    public partial class Frm_Branch : Form
    {
        public Frm_Branch()
        {
            InitializeComponent();
        }

        Sql_Connect connect = new Sql_Connect();

        private void Frm_Branch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Table_Branch",connect.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Branch (branch_name) values (@b1)", connect.connection());
            cmd.Parameters.AddWithValue("b1",txt_branch.Text);
            cmd.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("BRANCH ADDED");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txt_branch.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("delete from Table_Branch where branch_id=@b1", connect.connection());
            sqlCommand.Parameters.AddWithValue("@b1", txt_id.Text);
            sqlCommand.ExecuteNonQuery();
            connect.connection().Close ();
            MessageBox.Show("DELETED");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand2 = new SqlCommand("update Table_Branch set branch_name=@b1 where branch_id=@b2",connect.connection());
            sqlCommand2.Parameters.AddWithValue("@b1", txt_branch.Text);
            sqlCommand2.Parameters.AddWithValue("@b2",txt_id.Text);
            sqlCommand2.ExecuteNonQuery();
            connect.connection().Close ();
            MessageBox.Show("UPDATED");
        }
    }
}

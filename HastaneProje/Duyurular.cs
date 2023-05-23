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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }
        Sql_Connect connect = new Sql_Connect();
        private void Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Table_Announcements",connect.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

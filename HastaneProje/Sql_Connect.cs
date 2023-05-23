using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneProje
{
    internal class Sql_Connect
    {

        public SqlConnection connection()
        {
            //connection addres for connect the data base
            SqlConnection connect = new SqlConnection("Data Source=ACER_DB;Initial Catalog=Hastane_db;Integrated Security=True");
            connect.Open();
            return connect;

        }
    }
}

using Demo.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo.Data.Factory
{
    public class QueryMysql : IConnection
    {
        private static MySqlConnection con;
        public QueryMysql()
        {
            if (con == null)
            {
                con = new MySqlConnection("server=localhost;port=3306;user=root; database=test;");
            }
        }
        public void Closed()
        {
            con.Close();
        }

        public DataTable DataRead(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            DataTable tbl = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            return tbl;
        }

        public int ExecuteQuery(string query)
        {
                MySqlCommand command = new MySqlCommand(query, con);
                return command.ExecuteNonQuery();
            
            
        }

        public void Opened()
        {
            con.Open();
        }
    }
}

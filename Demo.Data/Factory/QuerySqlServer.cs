using Demo.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Factory
{
    public class QuerySqlServer : IConnection
    {
        public void Closed()
        {
            throw new NotImplementedException();
        }

        public DataTable DataRead(string query)
        {
            throw new NotImplementedException();
        }

        public int ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void Opened()
        {
            throw new NotImplementedException();
        }
    }
}

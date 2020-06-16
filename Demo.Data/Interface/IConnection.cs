using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Interface
{
    public interface IConnection
    {
        
        int ExecuteQuery(string query);
        void Opened();
        void Closed();
        DataTable DataRead(string query);

        
    }
}

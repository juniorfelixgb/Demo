using Demo.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Factory
{
    public abstract class FactoryConnection
    {
        public static IConnection GetConnection(string tipoConnectionDataBase)
        {
            if (tipoConnectionDataBase.ToUpper() == "SQL")
            {
                return new QuerySqlServer();
            }
            else if (tipoConnectionDataBase.ToUpper() == "ORACLE")
            {
                return new QueryOracle();
            }
            else if (tipoConnectionDataBase.ToUpper() == "MYSQL")
            {
                return new QueryMysql();
            }
            return new QueryNull();
        }
    }
}

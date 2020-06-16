using Demo.Data.Interface;
using Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Dao
{
    public class DaoRamoTipo : ICrud<RamoTipo>
    {
        private string _tipoConnection;
        public DaoRamoTipo(string tipoConnection)
        {
            _tipoConnection = tipoConnection;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<RamoTipo> Get()
        {
            List<RamoTipo> list = new List<RamoTipo>();

            IConnection con = Factory.FactoryConnection.GetConnection(_tipoConnection);
            con.Opened();

            string query = "select * from parametro";
            var result = con.DataRead(query);
            foreach (DataRow r in result.Rows)
            {
                list.Add(new RamoTipo(
                    Convert.ToInt16(r[2].ToString()),
                    r[1].ToString()
                    ));
            }
            con.Closed();

            return list;
        }

        public List<RamoTipo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(RamoTipo model)
        {
            throw new NotImplementedException();
        }

        public string Update(RamoTipo model)
        {
            throw new NotImplementedException();
        }
    }
}

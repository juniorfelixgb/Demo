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
    public class DaoRamo : ICrud<Ramo>
    {
        private string _tipoConnection, rpt = string.Empty;
        public DaoRamo(string tipoConnection)
        {
            _tipoConnection = tipoConnection;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ramo> Get()
        {
            List<Ramo> list = new List<Ramo>();
            
            IConnection con = Factory.FactoryConnection.GetConnection(_tipoConnection);
            con.Opened();

            string query = @"SELECT id_ramo,nombre_ramo ,p.nombre_parametro
            FROM `ramo` r 
            left join parametro p on r.`codigotiporamo_ramo` = p.valor_parametro 
            order by id_ramo desc";
            
            var result = con.DataRead(query);
            foreach (DataRow r in result.Rows)
            {
                list.Add(new Ramo(
                    Convert.ToInt32(r[0].ToString()),
                    r[1].ToString(),
                    0,
                    r[2].ToString()
                    ));
            }
            con.Closed();

            return list;
        }

        public List<Ramo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(Ramo model)
        {
            IConnection con = Factory.FactoryConnection.GetConnection(_tipoConnection);
            con.Opened();

            string query = @"insert into ramo (nombre_ramo, codigotiporamo_ramo) 
            values ('" + model.Nombre + "','" + model.RamoTipo.Valor + "')";

            rpt = con.ExecuteQuery(query) >= 1 ? "ok" : "error al insertar el registro";
            
            con.Closed();
            return rpt;
        }

        public string Update(Ramo model)
        {
            throw new NotImplementedException();
        }
    }
}

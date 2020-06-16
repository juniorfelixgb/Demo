using Demo.Data.Comun;
using Demo.Data.Dao;
using Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Controller
{
    public class ControllerRamoTipo
    {

        public DataTable Get()
        {
            DaoRamoTipo daoRamoTipo = new DaoRamoTipo(TipoConnection.TipoConnections);
            DataTable tbl = new DataTable();
            tbl.Columns.AddRange(new DataColumn[] {
                new DataColumn("nombre"),
                new DataColumn("valor")
            });
            foreach (var item in daoRamoTipo.Get())
            {
                tbl.Rows.Add(new object[] { 
                    item.Nombre,
                    item.Valor
                });
            }
            return tbl;
        }
        
    }
}

using Demo.Data.Comun;
using Demo.Data.Dao;
using Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Controller
{
    public class ControllerRamo
    {

        public string Insert(string nombre, int codigoTipoRamo)
        {
            DaoRamo daoRamo = new DaoRamo(TipoConnection.TipoConnections);
            Ramo ramo = new Ramo(0,nombre, codigoTipoRamo, string.Empty);
            return daoRamo.Insert(ramo);
        }

        public void Lista(DataGridView dgv)
        {
            DaoRamo daoRamo = new DaoRamo(TipoConnection.TipoConnections);
            dgv.Rows.Clear();
            List<Ramo> list = daoRamo.Get();
            foreach (var item in list)
            {
                dgv.Rows.Add(new object[] {
                item.ID,
                item.Nombre,
                item.RamoTipo.Nombre
                });
            }
        }

    }
}

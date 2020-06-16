using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Ramo
    {
        public Ramo(int id, string nombre, int codigoTipoRamo, string nombreTipoRamo)
        {
            ID = id;
            Nombre = nombre;
            RamoTipo = new RamoTipo(codigoTipoRamo, nombreTipoRamo);
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public RamoTipo RamoTipo { get; set; }
    }
}

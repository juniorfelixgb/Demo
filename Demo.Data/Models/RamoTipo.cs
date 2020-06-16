using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class RamoTipo
    {
        public RamoTipo(int codigotipoRamo, string nombre)
        {
            Nombre = nombre;
            Valor = codigotipoRamo;
        }
        public string Nombre { get; set; }
        public int Valor { get; set; }
    }
}

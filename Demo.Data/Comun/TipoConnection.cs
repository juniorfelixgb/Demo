using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Comun
{
    public abstract class TipoConnection
    {
        public static string TipoConnections = "Mysql";
    }

    public enum TipoRamo
    {
        General = 1,
        Personal = 2
    }
}

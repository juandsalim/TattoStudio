using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEOpcionesMenu
    {
        public int id { get; set; }
        public string detalle { get; set; }
        public bool estado { get; set; }
    }
}

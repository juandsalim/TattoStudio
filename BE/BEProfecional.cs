using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProfecional
    {
        public string  nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public DateTime fecha_de_nacimiento { get; set; }
        public string area { get; set; } //tatuajes, piercing o ambos

        

    }
}

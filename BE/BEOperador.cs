using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public partial class BEOperador
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string clave { get; set; }

        public BE.BETipoOperador tipo { get; set; }

       
    }
    
}

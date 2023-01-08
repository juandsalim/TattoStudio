using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
      
        public string telefono { get; set; }
        public string email { get; set; }

        public bool estado; 

    }
}

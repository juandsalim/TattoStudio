using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETurno
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string tipo { get; set; }
        public float precio { get; set; }
        public float senia { get; set; }

        public BECliente cliente;

        public BEProfecional profesional_asignado;

        
        

    }
}

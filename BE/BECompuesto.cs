using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECompuesto: BEOpcionesMenu
    {
       public List<BE.BEOpcionesMenu> patentes { get; set; }  
    }
}

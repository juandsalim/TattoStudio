using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLOpcionesMenu
    {
        public List<BE.BEOpcionesMenu> TraerTodo()
        {

            try
            {
                MPP.MPPOpcionesMenu map = new MPPOpcionesMenu();
                List<BE.BEOpcionesMenu> entidad = map.TraerTodo(0);
                map = null;
                return entidad;

            }
            catch (Exception ex)
            {

            }
            return null;

        }

        
       
    }
}

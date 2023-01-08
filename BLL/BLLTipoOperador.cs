using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTipoOperador
    {
        public List<BE.BETipoOperador> Listar()
        {
            List<BE.BETipoOperador> lista = new List<BE.BETipoOperador>();

            MPP.MPPTipoOperador mPPTipoOperador = new MPP.MPPTipoOperador();
            lista = mPPTipoOperador.Listar();
            return lista;
        }
    }
}

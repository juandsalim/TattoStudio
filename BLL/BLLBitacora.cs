using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBitacora
    {
        public bool AgregarABitacora(BE.BEBitacora bitacora)
        {
            MPP.MPPBitacora mPPBitacora = new MPP.MPPBitacora();
            return mPPBitacora.AgregarABitacora(bitacora);
        }

        public List<BE.BEBitacora> Listar()
        {
            List<BE.BEBitacora> list = new List<BE.BEBitacora>();

            MPP.MPPBitacora mPPBitacora = new MPP.MPPBitacora();
            list = mPPBitacora.Listar();
            return list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLOperador
    {
        
        public BE.BEOperador TraerOperador(string mail)
        {
            MPP.MPPOperador mPPOperador = new MPP.MPPOperador();
            return mPPOperador.TraerOperador(mail);
           
        }
        
        


    }
}

using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class Login
    {
        BLLBitacora bllBitacora;

        public string usuario { get; set; }
        public bool ValidarOp(string mail , string pass)
        {
            try
            {
                BLL.BLLOperador bLLOperador = new BLL.BLLOperador();
                BE.BEOperador bEOperador = bLLOperador.TraerOperador(mail);
                if (mail == bEOperador.email && pass == bEOperador.clave)
                {
                    usuario = mail;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
                
            }
            
        }
        
    }
}

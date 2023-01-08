using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Funciones
{
    public class Validaciones
    {
      
        public bool ValidarCliente(List<BE.BECliente> listaCliente ,string eMail )
        {
            return listaCliente.Exists(x => x.email == eMail);
        }

        public bool ValidarSoloNumeros(int dato)
        {
            if (Information.IsNumeric(dato))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        

        

        

       
    }
}

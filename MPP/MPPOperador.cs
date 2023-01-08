using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPOperador
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;
        BE.BEOperador operadorLog { get; set; }
        public BE.BEOperador TraerOperador(string mail)
        {
            
            try
            {
                BE.BEOperador op = new BE.BEOperador();
                string query = "TraerOperador";
                Hdatos = new Hashtable();
                Hdatos.Add("email", mail);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BEOperador bEOperador = new BE.BEOperador();
                        bEOperador.ID = Convert.ToInt32(fila[0]);
                        bEOperador.nombre = Convert.ToString(fila[1]);
                        bEOperador.apellido = Convert.ToString(fila[2]);
                        bEOperador.email = Convert.ToString(fila[3]);
                        bEOperador.clave = Convert.ToString(fila[4]);
                        bEOperador.tipo = new BE.BETipoOperador();
                        bEOperador.tipo.detalle = Convert.ToString(fila[5]);

                        op = bEOperador;
                    }
                }
                operadorLog = op;
                return op;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public BE.BEOperador opLogin()
        {
            return operadorLog;
        }

       
        
        
    }
}

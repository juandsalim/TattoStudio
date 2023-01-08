using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPTipoOperador
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;
        public List<BE.BETipoOperador> Listar()
        {
            try
            {
                List<BE.BETipoOperador> Lista = new List<BE.BETipoOperador>();
                string query = "Traer_TipoOP";

                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, null);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                       BE.BETipoOperador tipoOperador = new BE.BETipoOperador();    
                        tipoOperador.id = Convert.ToInt32(fila[0]);
                        tipoOperador.detalle = Convert.ToString(fila[1]);
                        

                        Lista.Add(tipoOperador);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                //capturar errores
                throw;
            }
        }


    }
}

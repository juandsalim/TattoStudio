using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPBitacora
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;
        public bool AgregarABitacora(BE.BEBitacora bitacora)
        {
            try
            {
                string query = "AgregarReporte";
                Hdatos = new Hashtable();


                Hdatos.Add("fecha", bitacora.fecha);
                Hdatos.Add("@detalle", bitacora.detalle);
                Hdatos.Add("@error", bitacora.error);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
               
                throw;

            }
        }

        public List<BE.BEBitacora> Listar()
        {
            try
            {
                List<BE.BEBitacora> lista_reportes = new List<BE.BEBitacora>();
                string query = "TraerReportes";

                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, null);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BEBitacora reporte = new BE.BEBitacora();
                        reporte.id = Convert.ToInt32(fila[0]);
                        reporte.fecha = Convert.ToDateTime(fila[1]);
                        reporte.detalle = Convert.ToString(fila[2]);
                        reporte.error = Convert.ToBoolean(fila[3]); 

                        lista_reportes.Add(reporte);
                    }
                }
                return lista_reportes;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }


    }
}

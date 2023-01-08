using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MPP
{
    
    public class MPPOpcionesMenu
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;
        
        public List<BE.BEOpcionesMenu> TraerTodo(int id)
        {
            try
            {
                
                List<BE.BEOpcionesMenu> Lista = new List<BE.BEOpcionesMenu>();
                string query = "Traer_Menu";
                Hdatos = new Hashtable();

                Hdatos.Add("@id", id);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                Lista = castDstoEnt(tabla);
                
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<BE.BEOpcionesMenu> castDstoEnt(DataTable ds)
        {
            //cambiar el ds por una entidad
            BE.BEOperador operador = new BE.BEOperador();   
            
            List<BE.BEOpcionesMenu> Lista_op = new List<BE.BEOpcionesMenu>();
            MPP.MPPOpcionesMenu map = new MPPOpcionesMenu();
            MPP.MPPOperador mPPOperador = new MPPOperador();
          
            foreach (DataRow fila in ds.Rows)
            {

                List<BE.BEOpcionesMenu> l = new List<BE.BEOpcionesMenu>();
                l = map.TraerTodo(int.Parse(fila["id"].ToString()));
                

                if (l.Count > 0)
                {
                    //genero un componente
                    BE.BECompuesto componente = new BECompuesto();
                  
                    componente.id = int.Parse(fila["id"].ToString());
                    componente.detalle = fila["detalle"].ToString();
                    componente.patentes = l;
                    
                    componente.estado = true;

                    Lista_op.Add(componente);
                }
                else
                {
                    //genero un componente
                    BE.BECompuesto patente = new BECompuesto();
                    patente.id = int.Parse(fila["id"].ToString());
                    patente.detalle = fila["detalle"].ToString();
                    
                    

                    patente.estado = true;
                    Lista_op.Add(patente);
                }
                
            }
            map = null;
            return Lista_op;
        }
        
        public BE.BEOpcionesMenu TraerOPmenu(int tipoID, int compuestoID)
        {
            try
            {
                BE.BECompuesto compuesto = new BECompuesto();   
                string query = "TraerOPmenu";
                Hdatos = new Hashtable();

                Hdatos.Add("@tipoID", tipoID);
                Hdatos.Add("@compuestoID", compuestoID);
                accesoDal = new DAL.sqlServer();
               
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BECompuesto aux = new BECompuesto();
                        aux.id = Convert.ToInt32(fila[0]);
                        aux.detalle = Convert.ToString(fila[1]);
                        aux.estado = Convert.ToBoolean(fila[2]);
                       

                        compuesto = aux;
                    }
                }
                return compuesto;
            }
            catch (Exception)
            {

                throw;
            }
            
        }



    }  


}

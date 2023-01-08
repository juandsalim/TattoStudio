using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MPP
{
    
    
    public class MPPCliente
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;

        public bool Alta_Cliente(BE.BECliente eCliente)
        {
            try
            {
                string query = "AltaCliente";
                Hdatos = new Hashtable();

                
                Hdatos.Add("@nombre", eCliente.nombre);
                Hdatos.Add("@apellido", eCliente.apellido);

                Hdatos.Add("@telefono", eCliente.telefono);
                Hdatos.Add("@email", eCliente.email);
                Hdatos.Add("@estado", eCliente.estado);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
                //capturar errores!!!
                throw;
            }
        }

        public List<BE.BECliente> Buscar(string apellido)
        {
            try
            {
                List<BE.BECliente> Lista_clientes = new List<BE.BECliente>();
                string query = "Buscar";
                Hdatos = new Hashtable();

                Hdatos.Add("@apellido", apellido);
                accesoDal=new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BECliente cliente = new BE.BECliente();
                        cliente.id = Convert.ToInt32(fila[0]);
                        cliente.nombre = Convert.ToString(fila[1]);
                        cliente.apellido = Convert.ToString(fila[2]);
                        cliente.telefono = Convert.ToString(fila[3]);
                        cliente.email = Convert.ToString(fila[4]);

                        Lista_clientes.Add(cliente);
                    }
                }
                return Lista_clientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BE.BECliente Buscar(int id) //revisar
        {
            try
            {
                BE.BECliente eCliente = new BE.BECliente();
                string query = "Buscar";
                Hdatos = new Hashtable();

                Hdatos.Add("@id", id);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BECliente cliente = new BE.BECliente();
                        cliente.id = Convert.ToInt32(fila[0]);
                        cliente.nombre = Convert.ToString(fila[1]);
                        cliente.apellido = Convert.ToString(fila[2]);
                        cliente.telefono = Convert.ToString(fila[3]);
                        cliente.email = Convert.ToString(fila[4]);

                        eCliente = cliente;
                    }
                }
                return eCliente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BE.BECliente>Listar()
        {
            try
            {
                List<BE.BECliente> Lista_clientes = new List<BE.BECliente>();
                string query = "TraerClientes";

                accesoDal=new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, null);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BECliente cliente = new BE.BECliente();
                        cliente.id = Convert.ToInt32(fila[0]);
                        cliente.nombre = Convert.ToString(fila[1]);
                        cliente.apellido = Convert.ToString(fila[2]);
                        cliente.telefono = Convert.ToString(fila[3]);
                        cliente.email = Convert.ToString(fila[4]);
                       
                        Lista_clientes.Add(cliente);
                    }
                }
                return Lista_clientes;
            }
            catch (Exception ex)
            {
                //capturar errores
                throw;
            }
        }

        public bool Eliminar_Cliente(BE.BECliente cliente)
        {
            try
            {
                string query = "Baja_Logica";
                Hdatos = new Hashtable();
                Hdatos.Add("id", cliente.id);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Modificar(BE.BECliente Cliente)
        {
            try
            {
                string query = "Modificar_Cliente";
                Hdatos = new Hashtable();

                Hdatos.Add("id", Cliente.id);
                Hdatos.Add("@nombre", Cliente.nombre);
                Hdatos.Add("@apellido", Cliente.apellido);
                Hdatos.Add("@telefono", Cliente.telefono);
                Hdatos.Add("@email", Cliente.email);
                

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
                //capturar errores!!!
                throw;
            }
        }





    }
}

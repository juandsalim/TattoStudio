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
    public class MPPProfecional
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;


        public bool Alta_Profecional(BE.BEProfecional eProfecional)
        {
            try
            {
                string query = "Alta_Profecional";
                Hdatos = new Hashtable();


                Hdatos.Add("@nombre", eProfecional.nombre);
                Hdatos.Add("@apellido",eProfecional.apellido);

                Hdatos.Add("@dni", eProfecional.dni);
                Hdatos.Add("@fecha_nacimiento", eProfecional.fecha_de_nacimiento);
                Hdatos.Add("@rol", eProfecional.area);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
                //capturar errores!!!
                throw;
            }
        }

        public List<BE.BEProfecional> Listar()
        {
            try
            {
                List<BE.BEProfecional> lista_profecionales = new List<BE.BEProfecional>(); 
                string query = "TraerProfecionales";

                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, null);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BEProfecional profecional = new BE.BEProfecional();  
                        profecional.nombre = Convert.ToString(fila[0]);
                        profecional.apellido = Convert.ToString(fila[1]);
                        profecional.dni = Convert.ToInt32(fila[2]);
                        profecional.fecha_de_nacimiento = Convert.ToDateTime(fila[3]);
                        profecional.area = Convert.ToString(fila[4]);

                        lista_profecionales.Add(profecional);
                    }
                }
                return lista_profecionales;
            }
            catch (Exception ex)
            {
                //capturar errores
                throw;
            }
        }

        public bool Eliminar_Profecional(BE.BEProfecional eProfecional)
        {
            try
            {
                string query = "BajaProfecional";
                Hdatos = new Hashtable();
                Hdatos.Add("dni", eProfecional.dni);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Modificar_Prof(BE.BEProfecional eProfecional)
        {
            try
            {
                string query = "ModificarProf";
                Hdatos = new Hashtable();

                Hdatos.Add("@nombre", eProfecional.nombre);
                Hdatos.Add("@apellido", eProfecional.apellido);

                Hdatos.Add("@dni", eProfecional.dni);
                Hdatos.Add("@fecha_nacimiento", eProfecional.fecha_de_nacimiento);
                Hdatos.Add("@rol", eProfecional.area);


                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
                //capturar errores!!!
                throw;
            }
        }

        public List<BE.BEProfecional>Buscar(string apellido)
        {
            try
            {
                List<BE.BEProfecional> Lista_prof = new List<BE.BEProfecional>();
                string query = "BuscarProf";
                Hdatos = new Hashtable();

                Hdatos.Add("@apellido", apellido);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BEProfecional profecional = new BE.BEProfecional();
                        profecional.nombre = Convert.ToString(fila[0]);
                        profecional.apellido = Convert.ToString(fila[1]);
                        profecional.dni = Convert.ToInt32(fila[2]);
                        profecional.fecha_de_nacimiento = Convert.ToDateTime(fila[3]);
                        profecional.area = Convert.ToString(fila[4]);

                        Lista_prof.Add(profecional);
                    }
                }
                return Lista_prof;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BE.BEProfecional> BuscarPorRol(string tipo)
        {
            try
            {
                List<BE.BEProfecional> Lista_prof = new List<BE.BEProfecional>();
                string query = "BuscarProfRol";
                Hdatos = new Hashtable();

                Hdatos.Add("@rol", tipo);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BEProfecional profecional = new BE.BEProfecional();
                        profecional.nombre = Convert.ToString(fila[0]);
                        profecional.apellido = Convert.ToString(fila[1]);
                        profecional.dni = Convert.ToInt32(fila[2]);
                        profecional.fecha_de_nacimiento = Convert.ToDateTime(fila[3]);
                        profecional.area = Convert.ToString(fila[4]);

                        Lista_prof.Add(profecional);
                    }
                }
                return Lista_prof;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}

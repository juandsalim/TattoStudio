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
    public class MPPTurno
    {
        DAL.sqlServer accesoDal;
        Hashtable Hdatos;

        public bool Alta_Turno(BE.BETurno turno)
        {
            try
            {
                string query = "AltaTurno";
                Hdatos = new Hashtable();


                Hdatos.Add("@fecha", turno.fecha);
                Hdatos.Add("@tipo", turno.tipo);
                Hdatos.Add("@precio", turno.precio);
                Hdatos.Add("@senia", turno.senia);
                Hdatos.Add("@id_cliente", turno.cliente.id);
                Hdatos.Add("@dni_profesional", turno.profesional_asignado.dni);
                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {
                //capturar errores!!!
                throw;
            }
        }

        public List<BE.BETurno> Buscar(DateTime fecha)
        {
            try
            {
                List<BE.BETurno> Lista_turnos = new List<BE.BETurno>();
                string query = "TraerTurnosFecha";
                Hdatos = new Hashtable();

                Hdatos.Add("@fecha", fecha);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BETurno turnos = new BE.BETurno();
                        turnos.id = Convert.ToInt32(fila[0]);
                        turnos.fecha = Convert.ToDateTime(fila[1]);
                        turnos.tipo = Convert.ToString(fila[2]);
                        turnos.precio = Convert.ToInt32(fila[3]);
                        turnos.senia = Convert.ToInt32(fila[4]);
                        turnos.cliente = new BE.BECliente();
                        turnos.cliente.nombre = Convert.ToString(fila[5]);
                        turnos.profesional_asignado = new BE.BEProfecional();
                        turnos.profesional_asignado.apellido = Convert.ToString(fila[6]);

                        Lista_turnos.Add(turnos);
                    }
                }
                return Lista_turnos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BE.BETurno> BuscarTurnoProf(int dni)
        {
            try
            {
                List<BE.BETurno> Lista_turnos = new List<BE.BETurno>();
                string query = "TurnosProfesional";
                Hdatos = new Hashtable();

                Hdatos.Add("dni_profesional", dni);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BETurno turnos = new BE.BETurno();
                        turnos.id = Convert.ToInt32(fila[0]);
                        turnos.fecha = Convert.ToDateTime(fila[1]);
                        turnos.tipo = Convert.ToString(fila[2]);
                        turnos.precio = Convert.ToInt32(fila[3]);
                        turnos.senia = Convert.ToInt32(fila[4]);
                        turnos.cliente = new BE.BECliente();
                        turnos.cliente.nombre = Convert.ToString(fila[5]);
                        turnos.profesional_asignado = new BE.BEProfecional();
                        turnos.profesional_asignado.apellido = Convert.ToString(fila[6]);

                        Lista_turnos.Add(turnos);
                    }
                }
                return Lista_turnos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BE.BETurno BuscarTurno(int id)
        {
            try
            {
                
                BE.BETurno eTurno = new BE.BETurno();
                string query = "TraerTurnoId";
                Hdatos = new Hashtable();

                Hdatos.Add("@id", id);
                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, Hdatos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BETurno turnos = new BE.BETurno();
                        turnos.id = Convert.ToInt32(fila[0]);
                        turnos.fecha = Convert.ToDateTime(fila[1]);
                        turnos.tipo = Convert.ToString(fila[2]);
                        turnos.precio = Convert.ToInt32(fila[3]);
                        turnos.senia = Convert.ToInt32(fila[4]);
                        turnos.cliente = new BE.BECliente();
                        turnos.cliente.nombre = Convert.ToString(fila[5]);
                        turnos.profesional_asignado = new BE.BEProfecional();
                        turnos.profesional_asignado.apellido = Convert.ToString(fila[6]);

                        eTurno = turnos;
                    }
                }
                return eTurno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BE.BETurno> Listar()
        {
            try
            {
                List<BE.BETurno> Lista_turnos = new List<BE.BETurno>();
                string query = "TodosLosTurnos";

                accesoDal = new DAL.sqlServer();
                DataTable tabla = accesoDal.Read(query, null);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        BE.BETurno turnos = new BE.BETurno();
                        turnos.fecha = Convert.ToDateTime(fila[0]);
                        turnos.tipo = Convert.ToString(fila[1]);
                        turnos.precio = Convert.ToInt32(fila[2]);
                        turnos.senia = Convert.ToInt32(fila[3]);
                        turnos.cliente = new BE.BECliente();
                        turnos.cliente.nombre = Convert.ToString(fila[4]);
                        turnos.profesional_asignado = new BE.BEProfecional();
                        turnos.profesional_asignado.apellido = Convert.ToString(fila[5]);

                        Lista_turnos.Add(turnos);
                    }
                }
                return Lista_turnos;
            }
            catch (Exception ex)
            {
                //capturar errores
                throw;
            }

        }
        public bool ModificarTurno(BE.BETurno turno)
        {
            try
            {
                string query = "ModificarTurno";
                Hdatos = new Hashtable();
                Hdatos.Add("@id", turno.id);
                Hdatos.Add("@precio", turno.precio);
                Hdatos.Add("@senia", turno.senia);
                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool Eliminar_Turno(BE.BETurno turno)
        {
            try
            {
                string query = "EliminarTurno";
                Hdatos = new Hashtable();
                Hdatos.Add("id", turno.id);

                accesoDal = new DAL.sqlServer();
                return accesoDal.Write(query, Hdatos);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}

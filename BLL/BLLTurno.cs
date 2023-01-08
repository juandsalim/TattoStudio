using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTurno
    {

        public bool Alta_Turno(BE.BETurno turno)
        {
            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            return mPPTurno.Alta_Turno(turno);
        }
        public List<BE.BETurno> Buscar(DateTime fecha)
        {
            List<BE.BETurno> lista = new List<BE.BETurno>();

            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            lista= mPPTurno.Buscar(fecha);
            return lista;
        }
        public List<BE.BETurno> Listar()
        {
            List<BE.BETurno> lista = new List<BETurno>();

            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            lista = mPPTurno.Listar();
            return lista;
        }
        public BE.BETurno BuscarTurno(int id)
        {
            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            return mPPTurno.BuscarTurno(id);
        }
        public bool Eliminar_Turno(BE.BETurno turno)
        {
            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            return (mPPTurno.Eliminar_Turno(turno));
        }
        public bool ModificarTurno(BE.BETurno turno)
        {
            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            return mPPTurno.ModificarTurno(turno);
        }
        public List<BE.BETurno> BuscarTurnoProf(int dni)
        {
            List<BE.BETurno> lista = new List<BE.BETurno>();    

            MPP.MPPTurno mPPTurno = new MPP.MPPTurno();
            lista = mPPTurno.BuscarTurnoProf(dni);
            return lista;
        }

    }
}

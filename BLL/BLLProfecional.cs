using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProfecional
    {
        public bool Alta_Profecional(BE.BEProfecional eProfecional)
        {
            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            return mPPProfecional.Alta_Profecional(eProfecional);
        }

        public List<BE.BEProfecional> Listar()
        {
            List<BE.BEProfecional> lista = new List<BE.BEProfecional>();

            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            lista = mPPProfecional.Listar();
            return lista;
        }

        public bool Eliminar_Profecional(BE.BEProfecional eProfecional)
        {
            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            return mPPProfecional.Eliminar_Profecional(eProfecional);
        }

        public bool Modificar_Prof(BE.BEProfecional eProfecional)
        {
            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            return mPPProfecional.Modificar_Prof(eProfecional);
        }

        public List<BE.BEProfecional> Buscar(string apellido)
        {
            List<BE.BEProfecional> lista = new List<BEProfecional>();

            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            lista= mPPProfecional.Buscar(apellido);
            return lista;
        }

        public List<BE.BEProfecional> BuscarPorRol(string tipo)
        {
            List<BE.BEProfecional> lista = new List<BEProfecional>();

            MPP.MPPProfecional mPPProfecional = new MPP.MPPProfecional();
            lista = mPPProfecional.BuscarPorRol(tipo);
            return lista;
        }

    } 
}

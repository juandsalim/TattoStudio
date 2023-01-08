using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        public bool Alta_Cliente(BE.BECliente bECliente)
        {
            MPP.MPPCliente mPPCliente = new MPP.MPPCliente();
            return mPPCliente.Alta_Cliente(bECliente);
        }

        public List<BE.BECliente>Listar()
        {
            List<BE.BECliente> lista = new List<BE.BECliente>();

            MPP.MPPCliente cliente = new MPP.MPPCliente();
            lista = cliente.Listar();
            return lista;
        }

        public bool Eliminar_Cliente(BE.BECliente bECliente)
        {
            MPP.MPPCliente mPPCliente = new MPP.MPPCliente();
            return mPPCliente.Eliminar_Cliente(bECliente);
        }

        public bool Modificar(BE.BECliente bECliente)
        {
            MPP.MPPCliente mPPCliente = new MPP.MPPCliente();
            return mPPCliente.Modificar(bECliente);
        }

        public List<BE.BECliente> Buscar(string apellido)
        {
            List<BE.BECliente> lista = new List<BE.BECliente>();

            MPP.MPPCliente mPPCliente = new MPP.MPPCliente();
            lista = mPPCliente.Buscar(apellido);
            return lista;
        }

        public BE.BECliente Buscar(int id)
        {
            MPP.MPPCliente mPPCliente = new MPP.MPPCliente();
            return mPPCliente.Buscar(id);
            
        }


    }
}

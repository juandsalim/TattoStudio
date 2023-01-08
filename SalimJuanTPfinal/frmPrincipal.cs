using SalimJuanTPfinal.formularios_clientes;
using SalimJuanTPfinal.formularios_profesionales;
using SalimJuanTPfinal.formularios_turnos;
using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalimJuanTPfinal
{
    public partial class frmPrincipal : Form
    {

        public string usuario { get; set; }

        

        public BE.BECompuesto Usuario { get; set; }
        Dictionary<string, BE.BEOpcionesMenu> dicMenu = new Dictionary<string, BE.BEOpcionesMenu>();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (this.usuario is null)
            {
                frmLogin frmLogin = new frmLogin();
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    usuario = frmLogin.usuario;
                }
            }
            toolStripStatusLabel.Text = "Conectado" +" " +  usuario;
            
            ArmarMenu();
           
        }

        private void ArmarMenu()
        {
            if (this.usuario.Trim() != "")
            {
                //cargar el menu
                BLL.BLLOperador operador = new BLL.BLLOperador();
                BLL.BLLOpcionesMenu menu = new BLL.BLLOpcionesMenu();
                List<BE.BEOpcionesMenu> l = new List<BE.BEOpcionesMenu>();
                
                l = menu.TraerTodo();
                menu = null;
              
                toDictionary(l);
                foreach (ToolStripMenuItem item in this.menu.Items)
                {
                    item.Enabled = habilitarOpcion(item.Text, l);

                    recorrerItems(item, l);
                }
            }
            else
            {

               
                frmLogin l = new frmLogin();
                l.MdiParent = this;
                l.usuario = usuario;
                l.ShowDialog();
             
            }

        }
        private void recorrerItems(ToolStripMenuItem i, List<BE.BEOpcionesMenu> l)
        {
            foreach (ToolStripMenuItem subitem in i.DropDownItems)
            {
                subitem.Enabled = habilitarOpcion(subitem.Text, l);
                recorrerItems(subitem, l);
            }
        }
        private bool habilitarOpcion(string detalle, List<BE.BEOpcionesMenu> l)
        {
            bool estado = false;

            detalle = detalle.Replace("&", String.Empty);
            if (dicMenu.ContainsKey(detalle))
            {
                estado = dicMenu[detalle].estado;
            }

            return estado;

        }

        private void toDictionary(List<BE.BEOpcionesMenu> l)
        {
            foreach (BE.BEOpcionesMenu op in l)
            {

                dicMenu.Add(op.detalle, op);
                if (op.GetType() == typeof(BE.BECompuesto))
                {
                    toDictionarybuscarHijos(((BE.BECompuesto)op).patentes);

                }
            }
        }
        private void toDictionarybuscarHijos(List<BE.BEOpcionesMenu> l)
        {
            if (l != null)
            {
                foreach (BE.BEOpcionesMenu op in l)
                {

                    dicMenu.Add(op.detalle, op);
                    if (op.GetType() == typeof(BE.BECompuesto))
                    {
                        toDictionarybuscarHijos(((BE.BECompuesto)op).patentes);

                    }
                }
            }
        }

        #region Botones menu

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
                frmAgregarCliente.MdiParent = this;
                frmAgregarCliente.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesAdm frmListadoClientes = new frmListadoClientesAdm();
            frmListadoClientes.MdiParent = this;
            frmListadoClientes.Show();
        }

        private void nuevoProfecionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarProf frmAgregarProfecional = new frmAgregarProf();
                frmAgregarProfecional.MdiParent = this;
                frmAgregarProfecional.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listadoDeProfecionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmListadoProfecionalAdm frmListadoProfecional = new frmListadoProfecionalAdm();
                frmListadoProfecional.MdiParent = this;
                frmListadoProfecional.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void agregaTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTurnos frmTurnos = new frmTurnos();
                frmTurnos.MdiParent = this;
                frmTurnos.Show();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void agengaDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgendaTurnos frmAgendaTurnos = new frmAgendaTurnos();
                frmAgendaTurnos.MdiParent = this;
                frmAgendaTurnos.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void listadoDeProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProfesionales frmListadoProfesionales = new frmListadoProfesionales();
            frmListadoProfesionales.MdiParent = this;
            frmListadoProfesionales.Show();
        }

        private void turnosPorProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurnosProf frmTurnosProfesional = new frmTurnosProf();
            frmTurnosProfesional.MdiParent = this;
            frmTurnosProfesional.Show();

        }

        private void listadoDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.MdiParent = this;
            frmListadoClientes.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.MdiParent = this;
            frmBitacora.Show();
        }

        //private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmPermisos frmPermisos = new frmPermisos();
        //    frmPermisos.MdiParent = this;
        //    frmPermisos.Show();
        //}




        #endregion


    }
}

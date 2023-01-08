using BLL;
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
    public partial class frmLogin : Form
    {
        BLLBitacora bllBitacora;
        Funciones.Validaciones _validar;
        public string usuario { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bllBitacora = new BLLBitacora();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Seguridad.Login login = new Seguridad.Login();
                bool ok = login.ValidarOp(this.txtUser.Text, this.txtPass.Text);
                if (ok)
                {
                    usuario = this.txtUser.Text;
                    //frmPrincipal frmPrincipal = new frmPrincipal();
                    //frmPrincipal.Show();
                    BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                    reporte.fecha = DateTime.Now; 
                    reporte.detalle = "Login" + "///" + $"El usuario  {txtUser.Text } se logueo con exito "; 
                    reporte.error = false;
                    bllBitacora.AgregarABitacora(reporte);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new Exception("Usuario o contraseña invalidos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Login" + "///" + ex.Message; 
                reporte.error = true;
                bllBitacora.AgregarABitacora(reporte);
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

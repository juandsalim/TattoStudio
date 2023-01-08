using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SalimJuanTPfinal
{
    public partial class frmAgregarCliente : Form
    {
        BLLBitacora bllBitacora;
        Funciones.Validaciones _validar;
       
        public BE.BECliente clienteAux; 
        public frmAgregarCliente()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bllBitacora = new BLLBitacora();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.BECliente nuevoCliente = new BE.BECliente();
                if (txtNombre.Text != null) //compruebo que la caja de texto no este vacia
                {
                    nuevoCliente.nombre = txtNombre.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre!");
                }
                if (txtApellido.Text != null) //compruebo que la caja de texto no este vacia
                {
                    nuevoCliente.apellido = txtApellido.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un apellido!");
                }
          
                if (txtTelefono.Text!=null) //compruebo que la caja de texto no este vacia
                {
                    nuevoCliente.telefono = txtTelefono.Text;
                }
                else
                {
                    throw new Exception("Formato de telefono invalido!");
                }
                if (_validar.ValidarEmail(txtEmail.Text)) //valido que sea una direccion de email valida
                {
                    nuevoCliente.email = txtEmail.Text;
                }
                else
                {
                    throw new Exception("Formato de email invalido!");
                }
                nuevoCliente.estado = true;
                BLL.BLLCliente cliente = new BLL.BLLCliente();
                List<BE.BECliente> lista = cliente.Listar();
                if (!_validar.ValidarCliente(lista,nuevoCliente.email)) //valido mediante el email que el cliente no exista
                {
                 
                    clienteAux = nuevoCliente;
                    cliente.Alta_Cliente(nuevoCliente);
                    MessageBox.Show("Cliente Agregado con exito!!");
                    BE.BEBitacora reporte = new BE.BEBitacora(); // capturo el evento para la bitacora
                    reporte.fecha = DateTime.Now;
                    reporte.detalle = "Cliente Agregado con exito!!";
                    reporte.error = false;
                    bllBitacora.AgregarABitacora(reporte);
                }
                else
                {
                    throw new Exception("Este cliente ya existe!");
                }
                
                foreach (Control c in groupBox1.Controls) //limpio los textBox
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Agregar cliente" + "///" + ex.Message;
                reporte.error = true;
                bllBitacora.AgregarABitacora(reporte);

            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        
    }
}

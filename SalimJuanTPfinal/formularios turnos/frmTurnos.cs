
using BE;
using BLL;
using SalimJuanTPfinal.formularios_clientes;
using SalimJuanTPfinal.formularios_profesionales;
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
    public partial class frmTurnos : Form
    {
        Funciones.Validaciones _validar;
        BLL.BLLCliente bLLCliente;
        BLL.BLLProfecional bLLProfecional;
        BLL.BLLBitacora bLLBitacora;
        public BE.BECliente clienteAux { get; set; }
        public BE.BEProfecional profAux { get; set; }

        public frmTurnos()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bLLCliente = new BLL.BLLCliente();
            bLLProfecional = new BLL.BLLProfecional();
            bLLBitacora = new BLL.BLLBitacora();
            
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {



        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                BE.BETurno nuevoTurno = new BE.BETurno();
                if (fechaTurno.Value >=  DateTime.Now) 
                {
                    nuevoTurno.fecha = fechaTurno.Value;
                }
                else
                {
                    throw new Exception("Fecha no valida ");
                }
                if (radioButton1.Checked is true)
                {
                    nuevoTurno.tipo = "Tattoo";
                    
                }
                else if (radioButton2.Checked is true)
                {
                    nuevoTurno.tipo = "Piercing";
                    
                }
                if (_validar.ValidarSoloNumeros(int.Parse(txtPrecio.Text)))
                {
                    nuevoTurno.precio = int.Parse(txtPrecio.Text);
                }
                else
                {
                    throw new Exception("Precio invalido!");
                }
                if (_validar.ValidarSoloNumeros(int.Parse(txtSenia.Text)))
                {
                    nuevoTurno.senia = int.Parse(txtSenia.Text);
                }
                else
                {
                    throw new Exception("Seña invalida!");
                }
                nuevoTurno.cliente = clienteAux;
                nuevoTurno.profesional_asignado = profAux;
                
                BLL.BLLTurno bLLTurno = new BLL.BLLTurno();
                bLLTurno.Alta_Turno(nuevoTurno);
                MessageBox.Show("Nuevo turno agendado");
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar Turno " + " /// " + "Nuevo turno agendado";
                bitacora.error = false;
                bLLBitacora.AgregarABitacora(bitacora);
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar Turno " + " /// " + ex.Message; 
                bitacora.error = true;
                bLLBitacora.AgregarABitacora(bitacora);
            }

        }

        private void txtProf_Click(object sender, EventArgs e)
        {
            try
            {
                frmListadoProfesionales frmListadoProfesionales = new frmListadoProfesionales();
                if (frmListadoProfesionales.ShowDialog() == DialogResult.OK)
                {
                    if (radioButton1.Checked == true && frmListadoProfesionales.ProfSelec.area == "Tattoo" || frmListadoProfesionales.ProfSelec.area == "Tattoo + Piercing")
                    {
                        profAux = frmListadoProfesionales.ProfSelec;
                        txtProf.Text = frmListadoProfesionales.ProfSelec.apellido;
                    }
                    
                    else if (radioButton2.Checked == true && frmListadoProfesionales.ProfSelec.area == "Piercing" || frmListadoProfesionales.ProfSelec.area == "Tattoo + Piercing")
                    {
                        profAux = frmListadoProfesionales.ProfSelec;
                        txtProf.Text = frmListadoProfesionales.ProfSelec.apellido;
                    }
                    else
                    {
                        txtProf.Text = "";
                        throw new Exception("Usted selecciono un profesional no capasitado para el turno");
                    }
                   
                }
                else
                {
                    throw new Exception("No selecciono ningun profesional!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar Turno " + " /// " + ex.Message;
                bitacora.error = true;
                bLLBitacora.AgregarABitacora(bitacora);
            }
        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmListadoClientes listadoClientes = new frmListadoClientes();
                if (listadoClientes.ShowDialog() == DialogResult.OK)
                {
                    clienteAux = listadoClientes.clienteSelect;
                    txtCliente.Text = listadoClientes.clienteSelect.apellido;
                }
                else
                {
                    throw new Exception("No selecciono ningun Cliente!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}

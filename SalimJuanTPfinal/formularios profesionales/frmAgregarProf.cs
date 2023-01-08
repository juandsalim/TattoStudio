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
    public partial class frmAgregarProf : Form

        
    {
        Funciones.Validaciones _validar;
        BLL.BLLBitacora bLLBitacora;
        public frmAgregarProf()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bLLBitacora = new BLL.BLLBitacora();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.BEProfecional nuevoProfecional = new BE.BEProfecional();
                if (txtNombreP.Text != null)
                {
                    nuevoProfecional.nombre = txtNombreP.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre!");
                }
                if (txtApellidoP.Text != null)
                {
                    nuevoProfecional.apellido = txtApellidoP.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un apellido!");
                }

                if (_validar.ValidarSoloNumeros(int.Parse(txtDni.Text)))
                {
                    nuevoProfecional.dni = int.Parse(txtDni.Text);
                }
                else
                {
                    throw new Exception("Formato de dni invalido!");
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) < DateTime.Now)
                {
                    nuevoProfecional.fecha_de_nacimiento = Convert.ToDateTime(dateTimePicker1.Text);
                }
                else
                {
                    throw new Exception("Fecha no valida!");
                }
                if (radioButton1.Checked is true)
                {
                    nuevoProfecional.area = "Tattoo";
                }
                if (radioButton2.Checked is true)
                {
                    nuevoProfecional.area = "Piercing";
                }
                if (radioButton3.Checked is true)
                {
                    nuevoProfecional.area = "Tattoo + Piercing";
                }

                BLL.BLLProfecional bLLProfecional = new BLL.BLLProfecional();
                bLLProfecional.Alta_Profecional(nuevoProfecional);
                
                MessageBox.Show("Profesional Agregado con exito!!");
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Agregar profesional " + " /// " + "Profesional Agregado con exito";
                reporte.error = false;
                bLLBitacora.AgregarABitacora(reporte);
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
                bitacora.detalle = "Agregar profesional " + " /// " + ex.Message;
                bitacora.error = true;
                bLLBitacora.AgregarABitacora(bitacora);
            }

        }

    }
    }



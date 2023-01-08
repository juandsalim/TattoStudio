using BE;
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
    public partial class frmListadoProfecionalAdm : Form
    {
        BLL.BLLProfecional bllProfecional;
        BLL.BLLBitacora bllBitacora;
        Funciones.Validaciones _validar;
        public frmListadoProfecionalAdm()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bllProfecional = new BLL.BLLProfecional();
            bllBitacora = new BLL.BLLBitacora();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Font = new Font("Algerian", 8);
            try
            {
                List<BE.BEProfecional> lista = bllProfecional.Listar(); //lleno el datagrid con la lista completa de profesionales

                CargarDg();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar profesional " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

       

        public void CargarDg() //ojo
        {
            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = bllProfecional.Listar();
        }

        private void btnEliminarProfecional_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BEProfecional aux = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BEProfecional;
                    BLL.BLLProfecional Profecional = new BLL.BLLProfecional();
                    Profecional.Eliminar_Profecional(aux);
                    CargarDg();
                }
                else
                {
                    throw new Exception("No hay un profesional seleccionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now; 
                bitacora.detalle = "Listado de profesionales " + " /// " + ex.Message; 
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BEProfecional aux = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BEProfecional;
                    textNombreP.Text = aux.nombre;
                    textApellidoP.Text = aux.apellido;
                    textDniP.Text = Convert.ToString(aux.dni);
                    dateTimePicker1.Value =  aux.fecha_de_nacimiento;
                    if (aux.area == "Tattoo")
                    {
                        radioButton1.Checked = true;
                    }
                    if (aux.area == "Piercing")
                    {
                        radioButton2.Checked = true;
                    }
                    if (aux.area == "Tattoo + Piercing")
                    {
                        radioButton3.Checked = true;
                    }
                }
                else
                {
                    throw new Exception("No hay un profesional seleccionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now; 
                bitacora.detalle = "Listado de profesionales " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void btnModificarProfecional_Click(object sender, EventArgs e)
        {
            try
            {
                BE.BEProfecional modProfecional = new BE.BEProfecional();
                if (textNombreP.Text != null)
                {
                    modProfecional.nombre = textNombreP.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre!");
                }
                if (textApellidoP.Text != null)
                {
                    modProfecional.apellido = textApellidoP.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un apellido!");
                }

                if (_validar.ValidarSoloNumeros(int.Parse(textDniP.Text)))
                {
                    modProfecional.dni = int.Parse(textDniP.Text);
                }
                else
                {
                    throw new Exception("Formato de dni invalido!");
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) < DateTime.Now)
                {
                    modProfecional.fecha_de_nacimiento = Convert.ToDateTime(dateTimePicker1.Text);
                }
                else
                {
                    throw new Exception("Fecha no valida!");
                }
                if (radioButton1.Checked is true)
                {
                    modProfecional.area = "Tattoo";
                }
                if (radioButton2.Checked is true)
                {
                    modProfecional.area = "Piercing";
                }
                if (radioButton3.Checked is true)
                {
                    modProfecional.area = "Tattoo + Piercing";
                }

                BLL.BLLProfecional bLLProfecional = new BLL.BLLProfecional();
                bLLProfecional.Modificar_Prof(modProfecional);
                CargarDg();
                MessageBox.Show("Profesional Modificado con exito!!");
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de profesionales " + " /// " + "Profesional Modificado con exito"; 
                bitacora.error = false;
                bllBitacora.AgregarABitacora(bitacora);
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
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now; 
                bitacora.detalle = "Listado de profesionales " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string apellido = txtApellidoBuscar.Text;
                BLL.BLLProfecional bLLProfecional = new BLLProfecional();
                dataGridView1.DataSource = bllProfecional.Buscar(apellido);
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show($"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} profesional/s con el apellido solicitado");
                    BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                    bitacora.fecha = DateTime.Now; 
                    bitacora.detalle = "Listado de profesionales " + " /// " + $"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} profesional/s con el apellido solicitado";
                    bitacora.error = false;
                    bllBitacora.AgregarABitacora(bitacora);
                }
                else
                {
                    throw new Exception("No se encontraron profesionales");
                }
                txtApellidoBuscar.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de profesionales " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void button1_Click(object sender, EventArgs e) //carga todos los profesionales
        {
            try
            {
                List<BE.BEProfecional> lista = bllProfecional.Listar();

                CargarDg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de profesionales " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}

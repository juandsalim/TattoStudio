using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalimJuanTPfinal
{
    public partial class frmListadoClientesAdm : Form
    {
        BLL.BLLCliente bLLCliente;
        Funciones.Validaciones _validar;
        BLL.BLLBitacora bLLBitacora;
        public frmListadoClientesAdm()
        {
            InitializeComponent();
            _validar = new Funciones.Validaciones();
            bLLCliente = new BLL.BLLCliente();
            bLLBitacora = new BLL.BLLBitacora();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Font = new Font("Algerian", 8);
            dataGridView1.DataSource = bLLCliente.Listar();

        }
        
        public void CargarDg() //ojo
        {
            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = bLLCliente.Listar();
           
        }


        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE.BECliente> lista = bLLCliente.Listar();

                CargarDg();
            }
            catch (Exception)
            {
                
                throw new Exception();
                 
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BECliente aux = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BECliente;
                    textID.Text = aux.id.ToString();
                    textNombre.Text = aux.nombre.ToString(); 
                    textApellido.Text = aux.apellido.ToString();
                    textTelefono.Text = aux.telefono.ToString();
                    textEmail.Text = aux.email.ToString();

                }
                else
                {
                    throw new Exception("No hay un cliente seleccionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Listado de clientes " + " /// " + ex.Message;
                reporte.error = true;
                bLLBitacora.AgregarABitacora(reporte);  
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BECliente aux = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BECliente;
                    BLL.BLLCliente bLLCliente = new BLL.BLLCliente();
                    bLLCliente.Eliminar_Cliente(aux);
                    MessageBox.Show("Cliente eliminado");
                    BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                    reporte.fecha = DateTime.Now;
                    reporte.detalle = "Listado de clientes " + " /// " + " Cliente eliminado ";
                    reporte.error = false;
                    bLLBitacora.AgregarABitacora(reporte);
                    CargarDg();
                    foreach (Control c in groupBox1.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                }
                else
                {
                    throw new Exception("No hay un cliente seleccionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Listado de clientes " + " /// " + ex.Message;
                reporte.error = true;
                bLLBitacora.AgregarABitacora(reporte);


            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                BE.BECliente modificar = new BE.BECliente();
                modificar.id = int.Parse(textID.Text);
                if (textNombre.Text != null)
                {
                    modificar.nombre = textNombre.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre!");
                }
                if (textApellido.Text != null)
                {
                    modificar.apellido = textApellido.Text;
                }
                else
                {
                    throw new Exception("Debe ingresar un apellido!");
                }

                if (textTelefono.Text != null)
                {
                    modificar.telefono = textTelefono.Text;
                }
                else
                {
                    throw new Exception("Formato de telefono invalido!");
                }
                Funciones.Validaciones _validar = new Funciones.Validaciones();
                if (_validar.ValidarEmail(textEmail.Text))
                {
                    modificar.email = textEmail.Text;
                }
                else
                {
                    throw new Exception("Formato de email invalido!");
                }

                BLL.BLLCliente cliente = new BLL.BLLCliente();
                cliente.Modificar(modificar);
                MessageBox.Show("Cliente Modificado con exito!!");
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                reporte.fecha = DateTime.Now;
                reporte.detalle = "Listado de clientes " + " /// " + " Cliente Modificado con exito "; 
                reporte.error = false;
                bLLBitacora.AgregarABitacora(reporte);
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                CargarDg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                reporte.fecha = DateTime.Now; reporte.detalle = "Listado de clientes " + " /// " + ex.Message ; reporte.error = true;
                bLLBitacora.AgregarABitacora(reporte);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string apellido = txtApellidoBuscar.Text;
                BLL.BLLCliente bLLCliente = new BLL.BLLCliente();
                dataGridView1.DataSource = bLLCliente.Buscar(apellido);
               if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show($"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} cliente/s con el apellido solicitado");
                    BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                    reporte.fecha = DateTime.Now; reporte.detalle = "Listado de clientes " + " /// " + $"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} cliente/s con el apellido solicitado"; reporte.error = false;
                    bLLBitacora.AgregarABitacora(reporte);
                }
               else
                {
                    MessageBox.Show("No se encontraron clientes");
                    BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                    reporte.fecha = DateTime.Now; reporte.detalle = "Listado de clientes " + " /// " + "No se encontraron clientes"; reporte.error = true;
                    bLLBitacora.AgregarABitacora(reporte);

                }
                txtApellidoBuscar.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora reporte = new BE.BEBitacora(); //capturo el evento o error para la bitacora
                reporte.fecha = DateTime.Now; reporte.detalle = "Listado de clientes " + " /// " + ex.Message; reporte.error = true;
                bLLBitacora.AgregarABitacora(reporte);

            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

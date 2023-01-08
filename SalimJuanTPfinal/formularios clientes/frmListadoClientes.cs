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

namespace SalimJuanTPfinal.formularios_clientes
{
    public partial class frmListadoClientes : Form
    {
        BLL.BLLCliente bLLCliente;
        BLL.BLLBitacora bllBitacora;
        public BE.BECliente clienteSelect;
        public frmListadoClientes()
        {
            InitializeComponent();
            

            bLLCliente = new BLL.BLLCliente();  
            bllBitacora = new BLL.BLLBitacora();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Font = new Font("Algerian", 8);
            try
            {

                List<BE.BECliente> lista = bLLCliente.Listar(); //lleno el datagrid con la lista completa de profesionales

                CargarDg();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora(); //capturo errores o eventos para la bitacora
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado clientes " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void CargarDg()
        {
            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = bLLCliente.Listar();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string apellido = txtBuscar.Text;

                dataGridView1.DataSource = bLLCliente.Buscar(apellido); //busco clientes por su apellido
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show($"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} cliente/s con el apellido solicitado");
                    BE.BEBitacora bitacora = new BE.BEBitacora();
                    bitacora.fecha = DateTime.Now;
                    bitacora.detalle = "Agregar Turno " + " /// " + $"Se encontraron {Convert.ToString((dataGridView1.Rows.Count))} cliente/s con el apellido solicitado";
                    bitacora.error = false;
                    bllBitacora.AgregarABitacora(bitacora);
                }
                else
                {
                    throw new Exception("No se encontraron clientes");
                }
                txtBuscar.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar Turno " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {

                frmAgregarCliente frmClienteNuevo = new frmAgregarCliente();
                if (frmClienteNuevo.ShowDialog() == DialogResult.OK)
                {
                    clienteSelect = frmClienteNuevo.clienteAux; //traigo el apellido de la carga del cliente nuevo
                    dataGridView1.DataSource = bLLCliente.Buscar(clienteSelect.apellido); // uso el apellido para actualizar la grilla

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Agregar Turno " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BECliente bECliente = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BECliente;
                    clienteSelect = bECliente;

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

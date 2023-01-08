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

namespace SalimJuanTPfinal.formularios_turnos
{
    public partial class frmAgendaTurnos : Form
    {
        Funciones.Validaciones validaciones;
        BLL.BLLBitacora bllBitacora;
        BLL.BLLTurno bLLTurno = new BLL.BLLTurno();
        public frmAgendaTurnos()
        {
            InitializeComponent();
            bllBitacora = new BLL.BLLBitacora();
            validaciones = new Funciones.Validaciones();
        }

        private void frmAgendaTurnos_Load(object sender, EventArgs e)
        {
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateTimePicker1.Value = DateTime.Now;
            List<BE.BETurno> lista = bLLTurno.Buscar(dateTimePicker1.Value); //leno la grilla con los turnos del dia
            llenarGrilla(lista);
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

      
        private void llenarGrilla(List<BE.BETurno>l)
        {
            try
            {
                
               foreach (BE.BETurno turno in l)
               {
                 int indice = dataGridView1.Rows.Add();
                 dataGridView1.Rows[indice].Cells["Id"].Value = turno.id;
                 dataGridView1.Rows[indice].Cells["Cliente"].Value = turno.cliente.nombre;
                 dataGridView1.Rows[indice].Cells["Fecha"].Value = turno.fecha;
                 dataGridView1.Rows[indice].Cells["Tipo"].Value = turno.tipo;
                 dataGridView1.Rows[indice].Cells["Precio"].Value = turno.precio;
                 dataGridView1.Rows[indice].Cells["Seña"].Value = turno.senia;
                 dataGridView1.Rows[indice].Cells["Profesional"].Value = turno.profesional_asignado.apellido;       
                }     
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de Turno " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
            
        }
        private void ActualizarDg()
        {
            try
            {
                dataGridView1.DataSource = null;
                List<BE.BETurno> lista = bLLTurno.Buscar(dateTimePicker1.Value);
                llenarGrilla(lista);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now; bitacora.detalle = "Listado de Turno " + " /// " + ex.Message; 
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<BE.BETurno> lista = bLLTurno.Buscar(dateTimePicker1.Value);
                if (lista.Count > 0 )
                {
                    llenarGrilla(lista);
                }
                else
                {
                    dataGridView1.Rows.Clear(); 
                    throw new Exception("No se encuentran turnos para la fecha seleccionada!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now; bitacora.detalle = "Listado de Turno " + " /// " + ex.Message; bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells["Id"].Value != null)
                {

                    int id =Convert.ToInt32( this.dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    BE.BETurno aux = bLLTurno.BuscarTurno(id);
                    txtNumero.Text =Convert.ToString(aux.id);
                    txtCliente.Text = aux.cliente.nombre;
                    txtFecha.Text = Convert.ToString(aux.fecha);
                    txtTipo.Text = aux.tipo;
                    txtPrecio.Text = Convert.ToString(aux.precio);
                    txtSen.Text = Convert.ToString(aux.senia);
                    txtProf.Text = aux.profesional_asignado.apellido;

                }
                else
                {
                    foreach (Control c in groupBox2.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    throw new Exception("No hay un cliente seleccionado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de Turno " + " /// " + ex.Message;
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void btnEliminart_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    BE.BETurno aux = bLLTurno.BuscarTurno(id);
                    bLLTurno.Eliminar_Turno(aux);
                    dataGridView1.Rows.Clear();
                    ActualizarDg();
                    MessageBox.Show("Turno Eliminado");
                    BE.BEBitacora bitacora = new BE.BEBitacora();
                    bitacora.fecha = DateTime.Now;
                    bitacora.detalle = $"Se elimino el turno{aux.id}";
                    bitacora.error = false;
                    bllBitacora.AgregarABitacora(bitacora);

                }
                else
                {
                    throw new Exception("No hay Turnos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now; 
                bitacora.detalle = "Listado de Turno " + " /// " + ex.Message; 
                bitacora.error = true;
                bllBitacora.AgregarABitacora(bitacora);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.BETurno turnoMod = new BE.BETurno();
                turnoMod.id = Convert.ToInt32(txtNumero.Text);
                if (validaciones.ValidarSoloNumeros(Convert.ToInt32( txtPrecio.Text)))
                {
                    turnoMod.precio = Convert.ToInt32(txtPrecio.Text);
                }
                else
                {
                    throw new Exception("Importe invalido");
                }
                if (validaciones.ValidarSoloNumeros(Convert.ToInt32(txtSen.Text)))
                {
                    turnoMod.senia = Convert.ToInt32(txtSen.Text);
                }
                else
                {
                    throw new Exception("Importe invalido");
                }

                bLLTurno.ModificarTurno(turnoMod);
                MessageBox.Show("Turno Modificado con exito");
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de Turno " + " /// " + "Turno Modificado con exito";
                bitacora.error = false;
                bllBitacora.AgregarABitacora(bitacora);
                foreach (Control c in groupBox2.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                dataGridView1.Rows.Clear();
                ActualizarDg();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BE.BEBitacora bitacora = new BE.BEBitacora();
                bitacora.fecha = DateTime.Now;
                bitacora.detalle = "Listado de Turno " + " /// " + ex.Message;
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

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

namespace SalimJuanTPfinal.formularios_turnos
{
    public partial class frmTurnosProf : Form
    {
        Funciones.Validaciones validaciones;
        BLL.BLLBitacora bllBitacora;
        BLL.BLLTurno bLLTurno = new BLL.BLLTurno();
        public frmTurnosProf()
        {
            InitializeComponent();
            bllBitacora = new BLL.BLLBitacora();
            validaciones = new Funciones.Validaciones();
        }

        private void frmTurnosProf_Load(object sender, EventArgs e)
        {
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Font = new Font("Algerian", 8);
        }

        private void llenarGrilla(List<BE.BETurno> l)
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

        private void btnSelecProf_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                frmListadoProfesionales frmListadoProfesionales = new frmListadoProfesionales();
                if (frmListadoProfesionales.ShowDialog() == DialogResult.OK)
                {
                    int dniProf = frmListadoProfesionales.ProfSelec.dni;
                    llenarGrilla(bLLTurno.BuscarTurnoProf(dniProf));
                }
            }
            catch (Exception)
            {

                throw;
            }




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }

}

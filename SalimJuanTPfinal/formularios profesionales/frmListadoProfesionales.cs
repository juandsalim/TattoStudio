using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalimJuanTPfinal.formularios_profesionales
{
    public partial class frmListadoProfesionales : Form
    {
        BLL.BLLProfecional bllProfecional;
        BLL.BLLBitacora bllBitacora;
       
      
        public BE.BEProfecional ProfSelec;
        public frmListadoProfesionales()
        {
            InitializeComponent();
           
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
        public void CargarDg() 
        {
            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = bllProfecional.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    BE.BEProfecional bEProfecional = this.dataGridView1.SelectedRows[0].DataBoundItem as BE.BEProfecional;
                    ProfSelec = bEProfecional;

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

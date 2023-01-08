using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalimJuanTPfinal
{
    public partial class frmBitacora : Form
    {
        BLL.BLLBitacora bllBitacora;
        public frmBitacora()
        {
            InitializeComponent();
            bllBitacora = new BLL.BLLBitacora();    
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            
            llenarGrilla(bllBitacora.Listar());
            dataGridView1.ClearSelection();
        }
        private void llenarGrilla(List<BE.BEBitacora> l)
        {
            try
            {

                foreach (BE.BEBitacora reporte in l)
                {
                    int indice = dataGridView1.Rows.Add();
                    dataGridView1.Rows[indice].Cells["Id"].Value = reporte.id;
                    dataGridView1.Rows[indice].Cells["Fecha"].Value = reporte.fecha;
                    dataGridView1.Rows[indice].Cells["Detalle"].Value = reporte.detalle;
                    if (reporte.error == true)
                    {
                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    else
                    {
                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                   
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnGa_Click(object sender, EventArgs e)
        {
            try
            { 
                  
                StreamWriter reporte = new StreamWriter("Reporte.txt", true);
                List<BE.BEBitacora> lista = new List<BE.BEBitacora>();

                lista = bllBitacora.Listar();

             
                foreach (var linea in lista)
                {
                    reporte.WriteLine(" " + linea.id + " " + linea.fecha + " " + linea.detalle);
                }
                MessageBox.Show("Se genero el reporte con exito");
                
                reporte.Close();
            }
            catch (Exception )
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

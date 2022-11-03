using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Presentación.Laboratorio
{
    public partial class VerFicha : Form
    {

        CrudMedicoDominio crudMedicoDominio = new CrudMedicoDominio();
       private string idficha = null;
        private bool Editar = false;
        public VerFicha()
        {
            InitializeComponent();
        }

        private void VerFicha_Load(object sender, EventArgs e)
        {
            MostrarFichaLab();
            alternar(dataGridView1);
        }

        private void MostrarFichaLab()
        {
            CrudMedicoDominio crudMedicoDominio = new CrudMedicoDominio();
            dataGridView1.DataSource = crudMedicoDominio.MostrarFichaLab();
        }


        public void alternar(DataGridView dvg)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                idficha = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                txtresultados.Text = dataGridView1.CurrentRow.Cells["resultados"].Value.ToString();
               
            }
            else 
                MessageBox.Show("Seleccione una fila");
                 }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(Editar == true)
            {
                try
                {
                    crudMedicoDominio.EditarResul(idficha, txtresultados.Text);
                    MessageBox.Show("Se edito correctamente");
                    MostrarFichaLab();
                    Editar = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar: " + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFichaLab();
        }
    }
    }

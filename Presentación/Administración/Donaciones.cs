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

namespace Presentación.Administración
{
    public partial class Donaciones : Form
    {
        CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
        public Donaciones()
        {
            InitializeComponent();
        }

        private void Donaciones_Load(object sender, EventArgs e)
        {
            MostrarDonaciones();
            alternar(dataGridView1);
        }


        private void MostrarDonaciones()
        {
            CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
            dataGridView1.DataSource = crudAdminDominio.MostrarDonaciones();
        }


        public void alternar(DataGridView dvg)
        {
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtcantidad.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                crudAdminDominio.IngresoDonacion(txtnombre.Text, txtcantidad.Text);
                MessageBox.Show("Se ingreso correctamente");
                limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo ingresar los datos");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarDonaciones();
        }
    }
}

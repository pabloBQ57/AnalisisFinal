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
    public partial class Reportes : Form
    {
        CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
        public Reportes()
        {
            InitializeComponent();
        }

        

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarDonaciones();
            MostrarGastos();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            MostrarGastos();
            MostrarDonaciones();
            alternar(dataGridViewGastos);
            alternar(dataGridViewDonaciones);
        }

        private void MostrarGastos()
        {
            CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
            dataGridViewGastos.DataSource = crudAdminDominio.MostrarGastos();
        }


        public void alternar(DataGridView dvg)
        {
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }

        private void MostrarDonaciones()
        {
            CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
            dataGridViewDonaciones.DataSource = crudAdminDominio.MostrarDonaciones();
        }


    }
}

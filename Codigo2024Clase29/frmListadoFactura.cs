using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo2024Clase29
{
    public partial class frmListadoFactura : Form
    {
        public frmListadoFactura()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            NCabecera nCabecera = new NCabecera();
            List<ECabecera> eCabeceras = nCabecera.Listar(txtCliente.Text);
            dgvCabecera.DataSource = eCabeceras;
        }



        private void dgvCabecera_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Obtén la fila seleccionada
            if (dgvCabecera.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCabecera.SelectedRows[0];                
                int idCabecera = Convert.ToInt32( filaSeleccionada.Cells["IdCabecera"].Value);

                NDetalle nDetalle = new NDetalle();
                dgvDetalle.DataSource = nDetalle.Listar(idCabecera);
            

            }
        }

        private void frmListadoFactura_Load(object sender, EventArgs e)
        {
            dgvCabecera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCabecera.MultiSelect = false;
            dgvDetalle.AutoGenerateColumns = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

       
    }
}

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

                // Obtén el valor del ID (supongamos que está en la columna "ID")
                var id = filaSeleccionada.Cells["IdCabecera"].Value;

                if (id != null)
                {
                    MessageBox.Show($"ID seleccionado: {id}");
                }
                else
                {
                    MessageBox.Show("El ID está vacío.");
                }
            }
        }

        private void frmListadoFactura_Load(object sender, EventArgs e)
        {
            dgvCabecera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCabecera.MultiSelect = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

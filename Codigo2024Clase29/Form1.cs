using Negocio;
using Entidad;
using Datos;

namespace Codigo2024Clase29
{
    public partial class Form1 : Form
    {

        List<EDetalle> eDetalles = new List<EDetalle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalle();

        }
        /// <summary>
        /// Agregar elementos al DataGridView
        /// </summary>
        void AgregarDetalle()
        {
            eDetalles.Add(new EDetalle
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Producto = txtProducto.Text
            });

            dgvDetalle.DataSource = null;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            dgvDetalle.DataSource = eDetalles;


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            NCabecera nCabecera = new NCabecera();
            ECabecera eCabecera = new ECabecera
            {
                Cliente = txtCliente.Text,
                Fecha = dtpFecha.Value
            };

            try
            {
                nCabecera.Grabar(eCabecera, eDetalles);
                eDetalles = new List<EDetalle>();
                dgvDetalle.DataSource = null;
                txtCliente.Text = "";
                dtpFecha.Value = DateTime.Today;
                MessageBox.Show("Se registró correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDetalle.AutoGenerateColumns = false;

        }
    }
}

using Negocio;

namespace Codigo2024Clase29
{
    public partial class Form1 : Form
    {
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

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            NCabecera nCabecera = new NCabecera();
            nCabecera.Grabar();

        }

     

      
    }
}

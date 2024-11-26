using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NCabecera
    {
        public void Grabar()
        {
            DCabecera dCabecera = new DCabecera();
            dCabecera.Insertar();

            DDetalle dDetalle = new DDetalle();
            for (int i = 0; i < 5; i++)
            {                                
                dDetalle.Insertar();
            }

            //Logica adicional
        }
    }
}

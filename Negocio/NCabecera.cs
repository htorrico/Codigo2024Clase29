using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class NCabecera
    {
        public void Grabar(string cliente, DateTime fecha,List<EDetalle> detalles)
        {
            DCabecera dCabecera = new DCabecera();
            dCabecera.Insertar(cliente, fecha);

            DDetalle dDetalle = new DDetalle();

            foreach (var item in detalles)
            {
                dDetalle.Insertar(item.IdCabecera, item.Producto,
                    item.Cantidad, item.Precio);
            }
          
     
        }
    }
}

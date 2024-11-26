using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Datos;
using Entidad;

namespace Negocio
{
    public class NCabecera
    {
       
        public void Grabar(ECabecera cabecera,List<EDetalle> detalles)
        {        
         
                DCabecera dCabecera = new DCabecera();

                //Inserta la cabecera 
                //Devuelve el último id insertado
                int idCabecera = dCabecera.Insertar(cabecera);

                DDetalle dDetalle = new DDetalle();

                foreach (var item in detalles)
                {
                    item.IdCabecera = idCabecera;
                    dDetalle.Insertar(item);
                }                        
     
        }
    }
}

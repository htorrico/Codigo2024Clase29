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
        public List<ECabecera> Listar(string cliente)
        {
            DCabecera dCabecera = new DCabecera();
            
            List<ECabecera> eCabeceras = new List<ECabecera>();
            //Capa de datos trae la lista de cabeceras
            eCabeceras = dCabecera.Listar(cliente,null);

            return eCabeceras;
        }
        public List<ECabecera> ListarActivos(string cliente)
        {
            DCabecera dCabecera = new DCabecera();     
            return dCabecera.Listar(cliente,true);
        }
        public List<ECabecera> ListarInactivos(string cliente)
        {
            DCabecera dCabecera = new DCabecera();
            return dCabecera.Listar(cliente, false);
        }

    }
}

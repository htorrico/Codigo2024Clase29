using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetalle
    {
        public List<EDetalle> Listar(int idCabecera)
        {
            DDetalle dDetalle = new DDetalle();
            return dDetalle.Listar(idCabecera);
        }

        public void Insertar(EDetalle eDetalle )
        {
            DDetalle dDetalle = new DDetalle();
            dDetalle.Insertar(eDetalle);

        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class DDetalle
    {
        public void Insertar(EDetalle entidad)
        {
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarDetalle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCabecera", entidad.IdCabecera);
                    command.Parameters.AddWithValue("@Producto", entidad.Producto);
                    command.Parameters.AddWithValue("@Cantidad", entidad.Cantidad);
                    command.Parameters.AddWithValue("@Precio", entidad.Precio);

                    command.ExecuteNonQuery();
                }

            }
        }
        public List<EDetalle> Listar(int idCabecera)
        {

            return null;
        }
    }
}

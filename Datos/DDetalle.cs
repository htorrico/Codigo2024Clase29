using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetalle
    {
        public void Insertar(int idCabecera, string producto, int cantidad, decimal precio)
        {
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarDetalle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCabecera", idCabecera);
                    command.Parameters.AddWithValue("@Producto", producto);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Precio", precio);

                    command.ExecuteNonQuery();
                }

            }
        }
    }
}

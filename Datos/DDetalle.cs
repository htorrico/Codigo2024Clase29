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
            SqlCommand command = null; ;
            SqlParameter sqlParameter = null;
            List<EDetalle> eDetalles = null;

            try
            {
                eDetalles = new List<EDetalle>();

                using (SqlConnection conexion = new SqlConnection(Constantes._connectionString))
                {
                    conexion.Open();

                    command = new SqlCommand("ListarDetalle", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameter = new SqlParameter("@IdCabecera", SqlDbType.Int);
                    sqlParameter.Value = idCabecera;

                    command.Parameters.Add(sqlParameter);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                       
                        eDetalles.Add(new EDetalle
                        {
                            IdDetalle = Convert.ToInt32(reader["IdDetalle"]),
                            IdCabecera = Convert.ToInt32(reader["IdCabecera"]),
                            Producto = Convert.ToString(reader["Producto"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            Precio = Convert.ToDecimal(reader["Precio"])
                        }
                       );
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command = null;
                sqlParameter = null;
            }

            return eDetalles;



        }
    }
}

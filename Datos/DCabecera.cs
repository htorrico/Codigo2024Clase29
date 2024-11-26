using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCabecera
    {

        public void Insertar(string cliente, DateTime fecha)
        {
            //USP_InsertarCabecera(fecha, cliente)
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarCabecera", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Cliente", cliente);

                    SqlParameter idOutput = new SqlParameter("@IdCabecera", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idOutput);

                    command.ExecuteNonQuery();
                   // return (int)idOutput.Value;
                }
            }



        }


    }
}

﻿using Entidad;
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
   
        public int Insertar(ECabecera entidad)
        {
            //USP_InsertarCabecera(fecha, cliente)
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarCabecera", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Fecha", entidad.Fecha);
                    command.Parameters.AddWithValue("@Cliente", entidad.Cliente);
                    

                    SqlParameter idOutput = new SqlParameter("@IdCabecera", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idOutput);
                    command.ExecuteNonQuery();

                    //(int)idOutput.Value: Retorna el valor del parámetro de salida
                    
                    return (int)idOutput.Value;
                }
            }



        }

        //? : Significa que le puedes asignar valores nul
        //Nulleable
        public  List<ECabecera> Listar(string cliente,bool? EsActivo)
        {
            SqlCommand command = null; ;
            SqlParameter sqlParameter = null;
            SqlParameter sqlParameter2 = null;
            List<ECabecera> eCabeceras = null;

            try
            {
                eCabeceras = new List<ECabecera>();

                using (SqlConnection conexion = new SqlConnection(Constantes._connectionString))
                {
                    conexion.Open();

                    command = new SqlCommand("ListarCabecera", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameter = new SqlParameter("@Cliente", SqlDbType.VarChar, 50);
                    sqlParameter.Value = cliente;
                    sqlParameter2 = new SqlParameter("@Activo", SqlDbType.Bit);
                    sqlParameter2.Value = EsActivo;

                    command.Parameters.Add(sqlParameter); 
                    command.Parameters.Add(sqlParameter2);


                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //ECabecera eCabecera = new ECabecera();
                        //eCabecera.IdCabecera = Convert.ToInt32(reader["IdCabecera"]);
                        //eCabecera.Cliente = Convert.ToString(reader["Cliente"]);
                        //eCabecera.Fecha = Convert.ToDateTime(reader["Fecha"]);
                        //eCabeceras.Add(eCabecera);

                        eCabeceras.Add(new ECabecera
                        {
                            IdCabecera = Convert.ToInt32(reader["IdCabecera"]),
                            Cliente = Convert.ToString(reader["Cliente"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
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

            return eCabeceras;



        }

    }
}

using Microsoft.Data.SqlClient;
using System.Data;
using HotelMonolitic.Web.Data;
using System;
using Microsoft.EntityFrameworkCore;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class StoredProcedures
    {
        public static int AddReception(ApplicationDbContext context, int clienteId, int habitacionId, DateTime fechaIngreso, DateTime fechaSalida)
        {
            var command = context.Database.GetDbConnection().CreateCommand();
            command.CommandText = "usp_AddReception";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ClienteId", clienteId));
            command.Parameters.Add(new SqlParameter("@HabitacionId", habitacionId));
            command.Parameters.Add(new SqlParameter("@FechaIngreso", fechaIngreso));
            command.Parameters.Add(new SqlParameter("@FechaSalida", fechaSalida));

            var receptionIdParam = new SqlParameter("@ReceptionId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(receptionIdParam);

            context.Database.OpenConnection();
            try
            {
                command.ExecuteNonQuery();
                return (int)receptionIdParam.Value;
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }
    }
}

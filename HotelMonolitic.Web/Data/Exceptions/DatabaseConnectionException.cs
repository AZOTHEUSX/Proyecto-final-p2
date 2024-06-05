using System;
using System.Data.SqlClient;
public class DBconneection
{
string connectionString = "Server=LAPTOP-VB241VSH;Database=DBHotel;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Otro error: " + ex.Message);
        }

}

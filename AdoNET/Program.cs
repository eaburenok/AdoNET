using System;
using System.Data.SqlClient;

namespace AdoNET
{
    class Program
    {
        static void Main(string[] args)
        {
         

            string connectionString = @"Data Source = LAPTOP-B3D7R5IQ;Initial Catalog = TestERwin; Integrated Security = True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine(connection.State);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}

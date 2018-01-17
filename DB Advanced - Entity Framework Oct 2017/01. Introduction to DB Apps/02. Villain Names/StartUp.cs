namespace _02._Villain_Names
{
    using System;
    using System.Data.SqlClient;

    public class StartUp
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Server = DESKTOP-KLIRQ5H\\SQLEXPRESS; Database = MinionsDB; Integrated Security = true");

            try
            {
                connection.Open();

                string command = "SELECT v.Name, COUNT(*) FROM Villains AS v " +
                                 "JOIN MinionsVillains AS mv " +
                                 "ON mv.VillainId = v.Id " +
                                 "GROUP BY v.Name " +
                                 //"HAVING COUNT(*) > 3 " +
                                 "ORDER BY COUNT(*) DESC ";

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string villainName = (string)reader["Name"];
                    int minionsCount = (int)reader[1];
                    Console.WriteLine($"{villainName} - {minionsCount}");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

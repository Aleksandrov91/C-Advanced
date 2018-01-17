using System;
using System.Data.SqlClient;

namespace _03._Minion_Names
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Server = DESKTOP-KLIRQ5H\\SQLEXPRESS; Database = MinionsDB; Integrated Security = true");

            try
            {
                connection.Open();

                string villainQuery = "SELECT Name FROM Villains WHERE Id = @VillainId";

                SqlCommand villainCommand = new SqlCommand(villainQuery, connection);
                villainCommand.Parameters.AddWithValue("@VillainId", villainId);

                string villainName = (string)villainCommand.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine("No villain with ID " + villainId + " exists in the database.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Villain: {villainName}");
                }

                string minionsQuery = "SELECT m.Name, m.Age FROM Minions AS m " +
                                      "JOIN MinionsVillains AS mv " +
                                      "ON mv.MinionId = m.Id " +
                                      "WHERE mv.VillainId = @VillainId " +
                                      "ORDER BY m.Name";

                SqlCommand minionsCommand = new SqlCommand(minionsQuery, connection);
                minionsCommand.Parameters.AddWithValue("@VillainId", villainId);

                SqlDataReader sqlDataReader = minionsCommand.ExecuteReader();

                if (!sqlDataReader.HasRows)
                {
                    Console.WriteLine("(no minions)");
                    return;
                }

                int position = 1;

                while (sqlDataReader.Read())
                {
                    string minionName = (string)sqlDataReader[0];
                    int minionAge = (int)sqlDataReader[1];

                    Console.WriteLine($"{position++}. {minionName} {minionAge}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

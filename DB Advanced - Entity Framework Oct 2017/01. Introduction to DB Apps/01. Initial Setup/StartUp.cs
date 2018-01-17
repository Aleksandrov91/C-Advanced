namespace _01._Initial_Setup
{
    using System;
    using System.Data.SqlClient;

    public class StartUp
    {
        public static void Main()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ["Server"] = "DESKTOP-KLIRQ5H\\SQLEXPRESS",
                ["Integrated Security"] = true
            };

            SqlConnection connection = new SqlConnection(builder.ToString());

            try
            {
                string createDbCommand = "CREATE DATABASE MinionsDB";
                SqlCommand createCommand = new SqlCommand(createDbCommand, connection);
                connection.Open();
                createCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            builder["Database"] = "MinionsDB";

            connection = new SqlConnection(builder.ToString());

            string createCountries = "CREATE TABLE Countries(" +
                                     "Id INT PRIMARY KEY IDENTITY, " +
                                     "Name VARCHAR(30) NOT NULL)";

            string createTowns = "CREATE TABLE Towns(" +
                                 "Id INT PRIMARY KEY IDENTITY," +
                                 "Name VARCHAR(30) NOT NULL," +
                                 "CountryId INT FOREIGN KEY REFERENCES Countries(Id))";

            string createMinions = "CREATE TABLE Minions(" +
                                   "Id INT PRIMARY KEY IDENTITY," +
                                   "Name VARCHAR(30) NOT NULL," +
                                   "Age INT NOT NULL," +
                                   "TownId INT FOREIGN KEY REFERENCES Towns(Id))";

            string createEvilnessFactors = "CREATE TABLE EvilnessFactors(" +
                                           "Id INT PRIMARY KEY IDENTITY," +
                                           "Name VARCHAR(30) NOT NULL)";

            string createVillains = "CREATE TABLE Villains(" +
                                    "Id INT PRIMARY KEY IDENTITY, " +
                                    "Name VARCHAR(30) NOT NULL, " +
                                    "EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))";

            string createMinionsVilians = "CREATE TABLE MinionsVillains(" +
                                          "MinionId INT FOREIGN KEY REFERENCES Minions(Id), " +
                                          "VillainId INT FOREIGN KEY REFERENCES Villains(Id), " +
                                          "CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId))";

            try
            {
                connection.Open();

                ExecuteCommand(createCountries, connection);
                ExecuteCommand(createTowns, connection);
                ExecuteCommand(createMinions, connection);
                ExecuteCommand(createEvilnessFactors, connection);
                ExecuteCommand(createVillains, connection);
                ExecuteCommand(createMinionsVilians, connection);


                string insertCountriesSQL = "INSERT INTO Countries (Name) VALUES ('Bulgaria'), ('UK'), ('USA'), ('France')";
                string insertTownsSQL = "INSERT INTO Towns (Name, CountryId) VALUES ('Sofia','1'), ('Burgas','1'), ('Varna', '1'), ('London','2'),('Liverpool','2'),('Ocean City','3'),('Paris','4')";
                string insertMinionsSQL = "INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),('kevin',12,2),('steward',9,3), ('rob',22,3), ('michael',5,2),('pep',3,2)";
                string insertEvilnessFactorSQL = "INSERT INTO EvilnessFactors (Name) VALUES ('super evil'),('evil'), ('bad'), ('good'),('super good')";
                string insertVillainsSQL = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru','1'),('Victor','2'),('Simon Cat','4'),('Pusheen','5'),('Mammal','3')";
                string insertMinionsVillainsSQL = "INSERT INTO MinionsVillains VALUES (1,2), (1,3), (3,3), (4,1), (2,2), (1,1), (3,4), (1, 4), (1,5), (5, 1), (3, 1)";

                ExecuteCommand(insertCountriesSQL, connection);
                ExecuteCommand(insertTownsSQL, connection);
                ExecuteCommand(insertMinionsSQL, connection);
                ExecuteCommand(insertEvilnessFactorSQL, connection);
                ExecuteCommand(insertVillainsSQL, connection);
                ExecuteCommand(insertMinionsVillainsSQL, connection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ExecuteCommand(string commandText, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(commandText, connection);
            cmd.ExecuteNonQuery();
        }
    }
}

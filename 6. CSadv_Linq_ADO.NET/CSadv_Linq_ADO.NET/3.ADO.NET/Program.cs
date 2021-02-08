using System;
using System.Configuration;
using System.Data.SqlClient;

namespace _3.ADO.NET
{
    //С помощью ADO.NET создайте в БД таблицу Stories.
    //Заполните ее несколькими значениями.
    //Выведите данные из таблицы. 
    //Строка подключения должна быть указана в app.config.

    class Program
    {
        static void Main(string[] args)
        {
            var createTableQuery = @"CREATE TABLE CSharpAdvanced.dbo.Stories (
                                        Id INT IDENTITY
                                        ,Name VARCHAR(50) NULL
                                        ,Description VARCHAR(255) NULL
                                        ,CONSTRAINT PK_Stories_Id PRIMARY KEY CLUSTERED (Id)
                                        )";
            var fillTableQuery =
                @"INSERT INTO Stories (Name, Description) VALUES ('Little Prince','Story about loneliness and finding beauty'),
                    ('Match Girl', 'Story about hard life and values we have'),
                    ('Fable about swan, cancer and pike','Story about co-working and result-bringing practices')";


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DROP TABLE Stories", connection);
                command.ExecuteNonQuery();

                command.CommandText = createTableQuery;
                command.ExecuteNonQuery();

                command.CommandText = fillTableQuery;
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM Stories";
                var reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Description"]}");
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}

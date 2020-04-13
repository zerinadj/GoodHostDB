using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHostDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            using (DbConnection connection = factory.CreateConnection())
            {
                if(connection == null)
                {
                    Console.WriteLine("Connection Error");
                    Console.ReadLine();
                    return;
                }
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    Console.WriteLine("Command Error");
                    Console.ReadLine();
                    return;
                }
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User]";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["FirstName"]} " + $"{dataReader["LastName"]}");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

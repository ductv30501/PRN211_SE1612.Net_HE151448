using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;
using System.IO;

namespace DemoDataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                              .AddJsonFile("appsettings.json", true, true).Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;

        }
        static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"deo the  ket noi");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();

            DbCommand command = factory.CreateCommand();
            if (command == null )
            {
                Console.WriteLine($"unalbe to connect");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID,ProductName From Product";
            using DbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine($"ProductID: {dataReader["ProductID"]} ," +
                    $" Product Name: {dataReader["ProductName"]}.");
            }
        }
    }
}

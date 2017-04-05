using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			Console.WriteLine(configuration["Data:ConnectionString"]);
        }
    }
}

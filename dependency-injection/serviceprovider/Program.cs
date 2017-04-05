using System;
using Microsoft.Extensions.DependencyInjection;

namespace di
{
	class Program
	{
		static void Main(string[] args)
		{
			var container = new ServiceCollection()
				.AddTransient<IGreeting, GreetingService>()
				.BuildServiceProvider();

			var service = container.GetService<IGreeting>();
			var service2 = container.GetService<IGreeting>();

			Console.WriteLine(service.SayHello());
			Console.WriteLine(service2.SayHello());
			Console.Read();
		}
	}

	interface IGreeting
	{
		string SayHello();
	}

	class GreetingService : IGreeting
	{
		Guid id;
		public GreetingService()
		{
			id = Guid.NewGuid();
		}
		public string SayHello()
		{
			return string.Format("{0} {1}", "Hellp", id);
		}
	}
}

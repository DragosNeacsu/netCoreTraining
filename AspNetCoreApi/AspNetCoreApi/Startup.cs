using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AspNetCoreApi.Services;
using AspNetCoreApi.Data;
using Microsoft.EntityFrameworkCore;
using AspNetCoreApi.Filters;

namespace AspNetCoreApi
{
	public class Startup
	{
		public Startup(ILoggerFactory factory)
		{
			factory.AddConsole();
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services
				.AddEntityFrameworkSqlServer()
				.AddDbContext<ToDoDbContext>(options => options.UseSqlServer("Server=.;database=NetCore; User Id=Dragos;Password=kmgi12345"))
				//.AddScoped(sp => new ToDoDbContext())
				.AddScoped<IToDoService, ToDoService>()
				.AddMvcCore(options=> {
					options.Filters.Add(new ExceptionFilter());
				})
				.AddJsonFormatters();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseMvc();
		}
	}
}

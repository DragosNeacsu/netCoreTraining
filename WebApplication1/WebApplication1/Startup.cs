using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;
using Microsoft.Extensions.Configuration;
using System.IO;
using WebApplication1.Models;
using System.Diagnostics;

namespace WebApplication1
{
	public class Startup
	{
		public Startup()
		{

		}
		public void ConfigureServices(IServiceCollection services)
		{

		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			// registe middleware
			// app.UseMiddleware<ProfilerMiddleware>();
			app.UseMvc();

			app.
		}
	}
}

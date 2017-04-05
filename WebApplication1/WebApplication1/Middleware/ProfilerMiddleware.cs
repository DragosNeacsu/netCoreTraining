using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ProfilerMiddleware
    {
		private readonly RequestDelegate next;
		public ProfilerMiddleware(RequestDelegate next)
		{
			this.next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			var profiler = Stopwatch.StartNew();
			await next(context);

			await Task.Delay(TimeSpan.FromSeconds(1));

			// Stop profiller
			profiler.Stop();
			// Send header to the client x-profiler-ms : 000
			context.Response.Headers.Add("x-profiler-ms", profiler.ElapsedMilliseconds.ToString());
		}
	}
}

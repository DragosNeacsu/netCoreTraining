using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Filters
{
	public class ExceptionFilter : IExceptionFilter
	{
		public ExceptionFilter()
		{

		}
		public void OnException(ExceptionContext context)
		{
			var exception = context.Exception;
		}
	}
}

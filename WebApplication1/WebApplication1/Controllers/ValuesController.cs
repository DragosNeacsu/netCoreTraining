using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		private IValuesService valuesService;
		public ValuesController(IValuesService valuesService)
		{
			this.valuesService = valuesService;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(valuesService.GetMessages());
		}
	}
}

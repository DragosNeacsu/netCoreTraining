using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
	public class ValuesService : IValuesService
	{
		private Messages messages;
		public ValuesService(IOptions<Messages> options)
		{
			messages = options.Value;
		}
		public string GetMessages()
		{
			return messages.Default;
		}
	}
}

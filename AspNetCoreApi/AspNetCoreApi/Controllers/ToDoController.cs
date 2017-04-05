using AspNetCoreApi.Models;
using AspNetCoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Controllers
{
	[Route("api/[controller]")]
	public class ToDoController : ControllerBase
	{
		private IToDoService _toDoService;
		public ToDoController(IToDoService toDoService)
		{
			_toDoService = toDoService;
		}
		[HttpGet]
		[Route("")]
		public async Task<IActionResult> Get()
		{
			var todos = await _toDoService.Get();
			// test exceptions
			throw new Exception("");
			return Ok(todos);
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			var todo = await _toDoService.GetById(id);
			return Ok(todo);
		}

		[HttpDelete]
		[Route("{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _toDoService.Delete(id);
			return Ok();
		}

		[HttpPost]
		[Route("")]
		public async Task<IActionResult> Save([FromBody] ToDoItem todo)
		{
			await _toDoService.Create(todo);
			return Created("", todo);
		}

		[HttpPut]
		[Route("{id:int}")]
		public async Task<IActionResult> Update(int id, [FromBody] ToDoItem todo)
		{
			await _toDoService.Update(id, todo);
			return Ok(todo);
		}
	}
}

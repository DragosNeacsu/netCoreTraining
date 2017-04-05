using AspNetCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Services
{
	public interface IToDoService
	{
		Task<List<ToDoItem>> Get();
		Task<ToDoItem> GetById(int id);
		Task Create(ToDoItem item);
		Task<ToDoItem> Update(int id, ToDoItem todo);
		Task Delete(int id);
	}
}

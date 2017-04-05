using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApi.Models;
using AspNetCoreApi.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApi.Services
{
	public class ToDoService : IToDoService
	{
		private readonly ToDoDbContext _dbContext;
		public ToDoService(ToDoDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<List<ToDoItem>> Get()
		{
			return _dbContext.ToDos.ToListAsync();
		}

		public Task<ToDoItem> GetById(int id)
		{
			return _dbContext.ToDos.SingleOrDefaultAsync(x => x.Id == id);
		}
		public async Task Create(ToDoItem item)
		{
			_dbContext.ToDos.Add(item);
			await _dbContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			var todo = await _dbContext.ToDos.SingleOrDefaultAsync(x => x.Id == id);
			if (todo != null)
			{
				_dbContext.ToDos.Remove(todo);
				await _dbContext.SaveChangesAsync();
			}
		}

		public async Task<ToDoItem> Update(int id, ToDoItem todo)
		{
			var currentToDo = await _dbContext.ToDos.SingleOrDefaultAsync(x => x.Id == id);
			if (currentToDo != null)
			{
				currentToDo.Title = todo.Title;
				currentToDo.Completed = todo.Completed;
				await _dbContext.SaveChangesAsync();
			}

			return currentToDo;
		}
	}
}

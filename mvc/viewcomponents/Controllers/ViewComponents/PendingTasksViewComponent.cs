using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using viewcomponents.Services;

namespace ViewComponents
{
	public class PendingTasksViewComponent : ViewComponent
	{
		private IPendingTasksService _pendingTasksService;
		public PendingTasksViewComponent(IPendingTasksService pendingTasksService)
		{
			_pendingTasksService = pendingTasksService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var pendingTasks = await GetPendingTasks();

			return View(pendingTasks);
		}

		private Task<List<PendingTasks>> GetPendingTasks()
		{
			var pendingTasks = _pendingTasksService.GetAllPendingTasks();
			return Task.FromResult(pendingTasks);
		}

		private Task<PendingTasks> GetPendingTask(int id)
		{
			var pendingTask = _pendingTasksService.GetPendingTask(id);
			return Task.FromResult(pendingTask);
		}
	}
}
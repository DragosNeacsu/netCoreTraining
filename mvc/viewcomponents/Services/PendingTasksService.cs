using Models;
using System.Collections.Generic;
using System.Linq;

namespace viewcomponents.Services
{
	public class PendingTasksService : IPendingTasksService
	{
		public List<PendingTasks> GetAllPendingTasks()
		{
			return new List<PendingTasks>()
			{
				new PendingTasks() { Id = 1, Name = "News 1", Completed=true},
				new PendingTasks() { Id = 2, Name = "News 2", Completed=false}
			};
		}

		public PendingTasks GetPendingTask(int id)
		{
			var pendingTasks = GetAllPendingTasks();
			return pendingTasks.Where(x => x.Id == id).FirstOrDefault();
		}
	}
}

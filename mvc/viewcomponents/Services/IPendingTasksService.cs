using Models;
using System.Collections.Generic;

namespace viewcomponents.Services
{
	public interface IPendingTasksService
    {
		List<PendingTasks> GetAllPendingTasks();
		PendingTasks GetPendingTask(int id);
	}
}

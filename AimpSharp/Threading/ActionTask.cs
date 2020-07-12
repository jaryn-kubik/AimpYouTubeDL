using AimpSharp.Threading.Enums;
using System;

namespace AimpSharp.Threading
{
	public class ActionTask : IAIMPTask, IAIMPTaskPriority
	{
		private readonly Action _action;
		private readonly TaskPriority _priority;

		public ActionTask(Action action, TaskPriority priority = TaskPriority.AIMP_TASK_PRIORITY_NORMAL)
		{
			_action = action;
			_priority = priority;
		}

		public void Execute(IAIMPTaskOwner Owner)
		{
			if (!Owner.IsCanceled())
			{
				_action();
			}
		}

		public TaskPriority GetPriority()
		{
			return _priority;
		}
	}
}
using AIMP.SDK;
using AIMP.SDK.Threading;
using System;

namespace AIMPYoutubeDL
{
	public class ActionAimpTask : IAimpTask
	{
		private readonly Action _action;

		public ActionAimpTask(Action action)
		{
			_action = action;
		}

		public AimpActionResult Execute(IAimpTaskOwner owner)
		{
			if (!owner.IsCanceled && !Utils.TryHandleException(_action))
			{
				return AimpActionResult.Fail;
			}
			return AimpActionResult.OK;
		}
	}
}
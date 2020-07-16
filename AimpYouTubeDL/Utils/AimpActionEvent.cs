using AimpSharp.Actions;
using System;

namespace AimpYouTubeDL.Utils
{
	public sealed class AimpActionEvent : IAIMPActionEvent
	{
		private readonly Action _action;

		public AimpActionEvent(Action action)
		{
			_action = action;
		}

		public void OnExecute(object Data)
		{
			Helpers.TryCatch(_action);
		}
	}
}
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	public class ActionEvent : IAIMPActionEvent
	{
		private readonly Action _action;

		public ActionEvent(Action action)
		{
			_action = action;
		}

		public void OnExecute([MarshalAs(UnmanagedType.IUnknown)] object Data)
		{
			_action();
		}
	}
}
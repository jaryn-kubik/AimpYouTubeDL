using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Threading;
using System;

namespace AimpYouTubeDL.Utils
{
	public sealed class AimpTask : IAIMPTask
	{
		private readonly Action _action;

		public AimpTask(Action action)
		{
			_action = action;
		}

		public HRESULT Execute(IAIMPTaskOwner Owner)
		{
			return (Owner.IsCanceled() || Helpers.TryCatch(_action))
				? HRESULT.S_OK
				: HRESULT.E_FAIL;
		}
	}
}
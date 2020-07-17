using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Threading
{
	[ComImport]
	[Guid("41494D50-5461-736B-3200-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTask
	{
		[PreserveSig] HRESULT Execute(IAIMPTaskOwner Owner);
	}
}
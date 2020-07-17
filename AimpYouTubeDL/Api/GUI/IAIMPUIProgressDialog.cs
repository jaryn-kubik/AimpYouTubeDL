using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIProgressDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIProgressDialog : IAIMPPropertyList
	{
		[PreserveSig] HRESULT Finished();
		[PreserveSig] HRESULT Progress(long Position, long Total, IAIMPString Text);
		[PreserveSig] HRESULT Started();
	}
}
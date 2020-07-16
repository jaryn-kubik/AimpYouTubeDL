using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIMemo_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIMemo : IAIMPUIBaseEdit
	{
		[PreserveSig] HRESULT AddLine(IAIMPString S);
		[PreserveSig] HRESULT Clear();
		[PreserveSig] HRESULT DeleteLine(int Index);
		[PreserveSig] HRESULT InsertLine(int Index, IAIMPString S);
		[PreserveSig] HRESULT GetLine(int Index, IAIMPString S);
		[PreserveSig] int GetLineCount();
		[PreserveSig] HRESULT SetLine(int Index, IAIMPString S);

		[PreserveSig] HRESULT LoadFromFile(IAIMPString FileName);
		[PreserveSig] HRESULT LoadFromStream(IAIMPStream Stream);
		[PreserveSig] HRESULT SaveToFile(IAIMPString FileName);
		[PreserveSig] HRESULT SaveToStream(IAIMPStream Stream);
	}
}
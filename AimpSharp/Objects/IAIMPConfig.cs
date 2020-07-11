using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPConfig_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPConfig
	{
		[PreserveSig] HRESULT Delete(IAIMPString KeyPath);

		[PreserveSig] HRESULT GetValueAsFloat(IAIMPString KeyPath, out double Value);
		[PreserveSig] HRESULT GetValueAsInt32(IAIMPString KeyPath, out int Value);
		[PreserveSig] HRESULT GetValueAsInt64(IAIMPString KeyPath, out long Value);
		[PreserveSig] HRESULT GetValueAsStream(IAIMPString KeyPath, out IAIMPStream Value);
		[PreserveSig] HRESULT GetValueAsString(IAIMPString KeyPath, out IAIMPString Value);

		[PreserveSig] HRESULT SetValueAsFloat(IAIMPString KeyPath, double Value);
		[PreserveSig] HRESULT SetValueAsInt32(IAIMPString KeyPath, int Value);
		[PreserveSig] HRESULT SetValueAsInt64(IAIMPString KeyPath, long Value);
		[PreserveSig] HRESULT SetValueAsStream(IAIMPString KeyPath, IAIMPStream Value);
		[PreserveSig] HRESULT SetValueAsString(IAIMPString KeyPath, IAIMPString Value);
	}
}
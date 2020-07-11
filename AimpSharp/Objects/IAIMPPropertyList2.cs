using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPPropertyList2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPropertyList2 : IAIMPPropertyList
	{
		//[PreserveSig] HRESULT GetValueAsVariant(int PropertyID, VARIANT** Value);
		//[PreserveSig] HRESULT SetValueAsVariant(int PropertyID, VARIANT* Value);
	}
}
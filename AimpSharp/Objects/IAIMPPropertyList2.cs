using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-5072-6F70-4C69-737432000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPropertyList2 : IAIMPPropertyList
	{
		//[PreserveSig] HRESULT GetValueAsVariant(int PropertyID, VARIANT** Value);
		//[PreserveSig] HRESULT SetValueAsVariant(int PropertyID, VARIANT* Value);
	}
}
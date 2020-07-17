using AimpSharp.GUI.Structs;
using AimpSharp.Objects;
using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIControl_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIControl : IAIMPPropertyList
	{
		[PreserveSig] HRESULT GetPlacement(out TAIMPUIControlPlacement Placement);
		[PreserveSig] HRESULT GetPlacementConstraints(out TAIMPUIControlPlacementConstraints Constraints);
		[PreserveSig] HRESULT SetPlacement(TAIMPUIControlPlacement Placement);
		[PreserveSig] HRESULT SetPlacementConstraints(TAIMPUIControlPlacementConstraints Constraints);

		[PreserveSig] HRESULT ClientToScreen(out POINT P);
		[PreserveSig] HRESULT ScreenToClient(out POINT P);

		[PreserveSig] HRESULT PaintTo(IntPtr DC, int X, int Y);
		[PreserveSig] HRESULT Invalidate();
	}
}
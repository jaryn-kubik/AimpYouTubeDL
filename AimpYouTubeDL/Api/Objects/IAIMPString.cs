using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects
{
	[ComImport]
	[Guid("41494D50-5374-7269-6E67-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPString
	{
		[PreserveSig] HRESULT GetChar(int Index, out char Char);
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[PreserveSig] string GetData();
		[PreserveSig] int GetLength();
		[PreserveSig] int GetHashCode();
		[PreserveSig] HRESULT SetChar(int Index, char Char);
		[PreserveSig] HRESULT SetData([MarshalAs(UnmanagedType.LPWStr)] string Chars, int CharsCount = -1);

		[PreserveSig] HRESULT Add(IAIMPString S);
		[PreserveSig] HRESULT Add2([MarshalAs(UnmanagedType.LPWStr)] string Chars, int CharsCount = -1);

		[PreserveSig] HRESULT ChangeCase(int Mode);
		[PreserveSig] HRESULT Clone(out IAIMPString S);

		[PreserveSig] HRESULT Compare(IAIMPString S, out int CompareResult, bool IgnoreCase);
		[PreserveSig] HRESULT Compare2([MarshalAs(UnmanagedType.LPWStr)] string Chars, int CharsCount, out int CompareResult, bool IgnoreCase);

		[PreserveSig] HRESULT Delete(int Index, int Count);

		[PreserveSig] HRESULT Find(IAIMPString S, out int Index, int Flags, int StartFromIndex);
		[PreserveSig] HRESULT Find2([MarshalAs(UnmanagedType.LPWStr)] string Chars, int CharsCount, out int Index, int Flags, int StartFromIndex);

		[PreserveSig] HRESULT Insert(int Index, IAIMPString S);
		[PreserveSig] HRESULT Insert2(int Index, [MarshalAs(UnmanagedType.LPWStr)] string Chars, int CharsCount = -1);

		[PreserveSig] HRESULT Replace(IAIMPString OldPattern, IAIMPString NewPattern, int Flags);
		[PreserveSig] HRESULT Replace2([MarshalAs(UnmanagedType.LPWStr)] string OldPatternChars, int OldPatternCharsCount, [MarshalAs(UnmanagedType.LPWStr)] string NewPatternChars, int NewPatternCharsCount, int Flags);

		[PreserveSig] HRESULT SubString(int Index, int Count, out IAIMPString S);
	}
}
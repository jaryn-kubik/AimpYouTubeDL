using System;

namespace AimpSharp
{
	public static class Extensions
	{
		public static void EnsureSuccess(this HRESULT result)
		{
			if (result != HRESULT.S_OK)
			{
				throw new Exception(result.ToString());
			}
		}
	}
}
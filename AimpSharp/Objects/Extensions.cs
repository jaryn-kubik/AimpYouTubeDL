using AimpSharp.Core;
using System;

namespace AimpSharp.Objects
{
	public static class Extensions
	{
		public static IAIMPString CreateString(this IAIMPCore core, string text)
		{
			var str = core.CreateObject<IAIMPString>(IID.IAIMPString);
			str.SetData(text).EnsureSuccess();
			return str;
		}

		public static void SetValueAsFloat<TEnum>(this IAIMPPropertyList propertyList, TEnum propId, double value) where TEnum : Enum
		{
			propertyList.SetValueAsFloat(Convert.ToInt32(propId), value).EnsureSuccess();
		}

		public static void SetValueAsInt32<TEnum>(this IAIMPPropertyList propertyList, TEnum propId, int value) where TEnum : Enum
		{
			propertyList.SetValueAsInt32(Convert.ToInt32(propId), value).EnsureSuccess();
		}

		public static void SetValueAsInt64<TEnum>(this IAIMPPropertyList propertyList, TEnum propId, long value) where TEnum : Enum
		{
			propertyList.SetValueAsInt64(Convert.ToInt32(propId), value).EnsureSuccess();
		}

		public static void SetValueAsObject<TEnum>(this IAIMPPropertyList propertyList, TEnum propId, object value) where TEnum : Enum
		{
			propertyList.SetValueAsObject(Convert.ToInt32(propId), value).EnsureSuccess();
		}

		public static double GetValueAsFloat<TEnum>(this IAIMPPropertyList propertyList, TEnum propId) where TEnum : Enum
		{
			propertyList.GetValueAsFloat(Convert.ToInt32(propId), out var value).EnsureSuccess();
			return value;
		}

		public static int GetValueAsInt32<TEnum>(this IAIMPPropertyList propertyList, TEnum propId) where TEnum : Enum
		{
			propertyList.GetValueAsInt32(Convert.ToInt32(propId), out var value).EnsureSuccess();
			return value;
		}

		public static long GetValueAsInt64<TEnum>(this IAIMPPropertyList propertyList, TEnum propId) where TEnum : Enum
		{
			propertyList.GetValueAsInt64(Convert.ToInt32(propId), out var value).EnsureSuccess();
			return value;
		}

		public static T GetValueAsObject<T>(this IAIMPPropertyList propertyList, Enum propId, Guid IID)
		{
			propertyList.GetValueAsObject(Convert.ToInt32(propId), IID, out var value).EnsureSuccess();
			return (T)value;
		}
	}
}
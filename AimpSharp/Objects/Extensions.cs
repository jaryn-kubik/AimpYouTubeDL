using AimpSharp.Core;
using AimpSharp.Menu;
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

		public static void SetValueAsFloat(this IAIMPPropertyList propertyList, MenuItemPropId propId, double value) => propertyList.SetValueAsFloat((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt32(this IAIMPPropertyList propertyList, MenuItemPropId propId, int value) => propertyList.SetValueAsInt32((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt64(this IAIMPPropertyList propertyList, MenuItemPropId propId, long value) => propertyList.SetValueAsInt64((int)propId, value).EnsureSuccess();
		public static void SetValueAsObject(this IAIMPPropertyList propertyList, MenuItemPropId propId, object value) => propertyList.SetValueAsObject((int)propId, value).EnsureSuccess();

		public static double GetValueAsFloat(this IAIMPPropertyList propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsFloat((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static int GetValueAsInt32(this IAIMPPropertyList propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsInt32((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static long GetValueAsInt64(this IAIMPPropertyList propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsInt64((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static T GetValueAsObject<T>(this IAIMPPropertyList propertyList, MenuItemPropId propId, Guid IID)
		{
			propertyList.GetValueAsObject((int)propId, IID, out var value).EnsureSuccess();
			return (T)value;
		}
	}
}
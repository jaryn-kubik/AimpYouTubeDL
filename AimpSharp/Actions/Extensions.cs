using AimpSharp.Actions.Enums;
using AimpSharp.Objects;
using System;

namespace AimpSharp.Actions
{
	public static class Extensions
	{
		public static void SetFloat(this IAIMPAction propertyList, ActionPropId propId, double value) => propertyList.SetValueAsFloat(propId, value);
		public static void SetInt(this IAIMPAction propertyList, ActionPropId propId, int value) => propertyList.SetValueAsInt32(propId, value);
		public static void SetLong(this IAIMPAction propertyList, ActionPropId propId, long value) => propertyList.SetValueAsInt64(propId, value);
		public static void SetObject(this IAIMPAction propertyList, ActionPropId propId, object value) => propertyList.SetValueAsObject(propId, value);

		public static double GetFloat(this IAIMPAction propertyList, ActionPropId propId) => propertyList.GetValueAsFloat(propId);
		public static int GetInt(this IAIMPAction propertyList, ActionPropId propId) => propertyList.GetValueAsInt32(propId);
		public static long GetLong(this IAIMPAction propertyList, ActionPropId propId) => propertyList.GetValueAsInt64(propId);
		public static T GetObject<T>(this IAIMPAction propertyList, ActionPropId propId, Guid IID) => propertyList.GetValueAsObject<T>(propId, IID);
	}
}
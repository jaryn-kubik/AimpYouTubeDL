using System;

namespace AimpSharp.Actions
{
	public static class Extensions
	{
		public static void SetValueAsFloat(this IAIMPAction propertyList, ActionPropId propId, double value) => propertyList.SetValueAsFloat((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt32(this IAIMPAction propertyList, ActionPropId propId, int value) => propertyList.SetValueAsInt32((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt64(this IAIMPAction propertyList, ActionPropId propId, long value) => propertyList.SetValueAsInt64((int)propId, value).EnsureSuccess();
		public static void SetValueAsObject(this IAIMPAction propertyList, ActionPropId propId, object value) => propertyList.SetValueAsObject((int)propId, value).EnsureSuccess();

		public static double GetValueAsFloat(this IAIMPAction propertyList, ActionPropId propId)
		{
			propertyList.GetValueAsFloat((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static int GetValueAsInt32(this IAIMPAction propertyList, ActionPropId propId)
		{
			propertyList.GetValueAsInt32((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static long GetValueAsInt64(this IAIMPAction propertyList, ActionPropId propId)
		{
			propertyList.GetValueAsInt64((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static T GetValueAsObject<T>(this IAIMPAction propertyList, ActionPropId propId, Guid IID)
		{
			propertyList.GetValueAsObject((int)propId, IID, out var value).EnsureSuccess();
			return (T)value;
		}
	}
}
using AimpSharp.Objects;
using System;

namespace AimpSharp.Menu
{
	public static class Extensions
	{
		public static IAIMPMenuItem GetBuiltIn(this IAIMPServiceMenuManager manager, MenuId menuId)
		{
			manager.GetBuiltIn(menuId, out var menuItemParent).EnsureSuccess();
			return menuItemParent;
		}

		public static IAIMPMenuItem GetByID(this IAIMPServiceMenuManager manager, IAIMPString str)
		{
			manager.GetByID(str, out var menuItemParent).EnsureSuccess();
			return menuItemParent;
		}

		public static void SetValueAsFloat(this IAIMPMenuItem propertyList, MenuItemPropId propId, double value) => propertyList.SetValueAsFloat((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt32(this IAIMPMenuItem propertyList, MenuItemPropId propId, int value) => propertyList.SetValueAsInt32((int)propId, value).EnsureSuccess();
		public static void SetValueAsInt64(this IAIMPMenuItem propertyList, MenuItemPropId propId, long value) => propertyList.SetValueAsInt64((int)propId, value).EnsureSuccess();
		public static void SetValueAsObject(this IAIMPMenuItem propertyList, MenuItemPropId propId, object value) => propertyList.SetValueAsObject((int)propId, value).EnsureSuccess();

		public static double GetValueAsFloat(this IAIMPMenuItem propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsFloat((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static int GetValueAsInt32(this IAIMPMenuItem propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsInt32((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static long GetValueAsInt64(this IAIMPMenuItem propertyList, MenuItemPropId propId)
		{
			propertyList.GetValueAsInt64((int)propId, out var value).EnsureSuccess();
			return value;
		}

		public static T GetValueAsObject<T>(this IAIMPMenuItem propertyList, MenuItemPropId propId, Guid IID)
		{
			propertyList.GetValueAsObject((int)propId, IID, out var value).EnsureSuccess();
			return (T)value;
		}
	}
}
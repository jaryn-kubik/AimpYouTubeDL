using AimpSharp.Menu.Enums;
using AimpSharp.Objects;
using System;

namespace AimpSharp.Menu
{
	public static class Extensions
	{
		public static IAIMPMenuItem GetBuiltIn(this IAIMPServiceMenuManager manager, MenuId menuId)
		{
			manager.GetBuiltIn(menuId, out var menuItemParent);
			return menuItemParent;
		}

		public static IAIMPMenuItem GetByID(this IAIMPServiceMenuManager manager, IAIMPString str)
		{
			manager.GetByID(str, out var menuItemParent);
			return menuItemParent;
		}

		public static void SetFloat(this IAIMPMenuItem propertyList, MenuItemPropId propId, double value) => propertyList.SetValueAsFloat(propId, value);
		public static void SetInt(this IAIMPMenuItem propertyList, MenuItemPropId propId, int value) => propertyList.SetValueAsInt32(propId, value);
		public static void SetLong(this IAIMPMenuItem propertyList, MenuItemPropId propId, long value) => propertyList.SetValueAsInt64(propId, value);
		public static void SetObject(this IAIMPMenuItem propertyList, MenuItemPropId propId, object value) => propertyList.SetValueAsObject(propId, value);

		public static double GetFloat(this IAIMPMenuItem propertyList, MenuItemPropId propId) => propertyList.GetValueAsFloat(propId);
		public static int GetInt(this IAIMPMenuItem propertyList, MenuItemPropId propId) => propertyList.GetValueAsInt32(propId);
		public static long GetLong(this IAIMPMenuItem propertyList, MenuItemPropId propId) => propertyList.GetValueAsInt64(propId);
		public static T GetObject<T>(this IAIMPMenuItem propertyList, MenuItemPropId propId, Guid IID) => propertyList.GetValueAsObject<T>(propId, IID);
	}
}
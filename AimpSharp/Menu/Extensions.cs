using AimpSharp.Menu.Enums;
using AimpSharp.Objects;

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
	}
}
using AimpYouTubeDL.Api.Menu.Enums;
using AimpYouTubeDL.Api.Objects;

namespace AimpYouTubeDL.Api.Menu
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
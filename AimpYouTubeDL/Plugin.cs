using AimpSharp;
using AimpSharp.Actions;
using AimpSharp.Core;
using AimpSharp.Menu;
using AimpSharp.Menu.Enums;
using AimpSharp.Objects;
using AimpSharp.Threading;
using AimpSharp.Threading.Enums;
using System;
using System.Windows.Forms;

namespace aimp_test
{
	public static class Plugin
	{
		public static void Init(IntPtr ptr)
		{
			PluginWrapper.Init(ptr, "YouTube-DL 2", "cubis12321", "Support for playing audio from sites supported by youtube-dl", Initialize);
		}

		private static bool Initialize()
		{
			var menuItem = Core.CreateObject<IAIMPMenuItem>(AimpSharp.Menu.IID.IAIMPMenuItem);

			var str = Core.CreateString("test");
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_NAME, str);

			var menuItemParent = ((IAIMPServiceMenuManager)Core).GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING);
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_PARENT, menuItemParent);

			var onClick = new ActionEvent(() => MessageBox.Show("OnClick"));
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_EVENT, onClick);

			var task = new ActionTask(() => MessageBox.Show("OnClick"));
			var result = ((IAIMPServiceThreads)Core).ExecuteInMainThread(task, FlagsServiceThreads.AIMP_SERVICE_THREADS_FLAGS_NONE);

			Core.RegisterExtension(AimpSharp.Menu.IID.IAIMPServiceMenuManager, menuItem);
			return true;
		}

		public static IAIMPCore Core => PluginWrapper.Core;
	}
}
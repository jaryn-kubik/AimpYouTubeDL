using AimpSharp;
using AimpSharp.Actions;
using AimpSharp.Core;
using AimpSharp.Menu;
using AimpSharp.Objects;
using NXPorts.Attributes;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace aimp_test
{
	public static class Plugin
	{
		static Plugin()
		{
			AppDomain.CurrentDomain.AssemblyResolve += (_, args) =>
			{
				if (args.Name.StartsWith("AimpSharp"))
				{
					var dir = Path.GetDirectoryName(typeof(Plugin).Assembly.Location);
					var path = Path.Combine(dir, "AimpSharp.dll");
					return Assembly.LoadFrom(path);
				}
				return null;
			};
		}

		[DllExport("AIMPPluginGetHeader", CallingConvention.StdCall)]
		public static int AIMPPluginGetHeader(IntPtr ptr)
		{
			try
			{
				_instance = PluginWrapper.Create(ptr, "YouTube-DL 2", "cubis12321", "Support for playing audio from sites supported by youtube-dl", Initialize);
				return 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Failed to load AimpYouTubeDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return -1;
			}
		}

		private static bool Initialize()
		{
			var menuItem = Core.CreateObject<IAIMPMenuItem>(AimpSharp.Menu.IID.IAIMPMenuItem);

			var str = Core.CreateString("test");
			menuItem.SetValueAsObject(MenuItemPropId.AIMP_MENUITEM_PROPID_NAME, str);

			var menuItemParent = ((IAIMPServiceMenuManager)Core).GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING);
			menuItem.SetValueAsObject(MenuItemPropId.AIMP_MENUITEM_PROPID_PARENT, menuItemParent);

			var onClick = new ActionEvent(() => MessageBox.Show("OnClick"));
			menuItem.SetValueAsObject(MenuItemPropId.AIMP_MENUITEM_PROPID_EVENT, onClick);

			Core.RegisterExtension(AimpSharp.Menu.IID.IAIMPServiceMenuManager, menuItem);
			return true;
		}

		private static PluginWrapper _instance;
		public static IAIMPCore Core => _instance.Core;
	}
}
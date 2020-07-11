using AimpSharp.Core;
using AimpSharp.Plugin;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp
{
	public sealed class PluginWrapper : IAIMPPlugin
	{
		private readonly string _name;
		private readonly string _author;
		private readonly string _description;
		private readonly Func<bool> _onInitialize;

		private PluginWrapper(string name, string author, string description, Func<bool> onInitialize)
		{
			_name = name;
			_author = author;
			_description = description;
			_onInitialize = onInitialize;
		}

		public static PluginWrapper Create(IntPtr ptr, string name, string author, string description, Func<bool> onInitialize)
		{
			var instance = new PluginWrapper(name, author, description, onInitialize);
			var instancePtr = Marshal.GetComInterfaceForObject<PluginWrapper, IAIMPPlugin>(instance);
			Marshal.WriteIntPtr(ptr, instancePtr);
			return instance;
		}

		public IAIMPCore Core { get; private set; }

		public string InfoGet(PluginInfo Index)
		{
			return Index switch
			{
				PluginInfo.AIMP_PLUGIN_INFO_NAME => _name,
				PluginInfo.AIMP_PLUGIN_INFO_AUTHOR => _author,
				PluginInfo.AIMP_PLUGIN_INFO_SHORT_DESCRIPTION => _description,
				_ => null
			};
		}

		public PluginCategory InfoGetCategories()
		{
			return PluginCategory.AIMP_PLUGIN_CATEGORY_ADDONS;
		}

		public HRESULT Initialize(IAIMPCore Core)
		{
			this.Core = Core;
			if (_onInitialize())
			{
				return HRESULT.S_OK;
			}
			return HRESULT.E_FAIL;
		}

		public HRESULT Finalize()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			return HRESULT.S_OK;
		}

		public void SystemNotification(SystemNotification NotifyId, IntPtr Data)
		{
		}
	}
}
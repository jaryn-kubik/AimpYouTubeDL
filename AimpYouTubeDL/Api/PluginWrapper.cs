using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Plugin;
using AimpYouTubeDL.Api.Plugin.Enums;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AimpYouTubeDL.Api
{
	public sealed class PluginWrapper : IAIMPPlugin
	{
		private readonly string _name;
		private readonly string _author;
		private readonly string _description;
		private readonly Func<bool> _onInitialize;
		private readonly Func<bool> _onDispose;

		private PluginWrapper(string name, string author, string description, Func<bool> onInitialize, Func<bool> onDispose)
		{
			_name = name;
			_author = author;
			_description = description;
			_onInitialize = onInitialize;
			_onDispose = onDispose;
		}

		private static PluginWrapper _instance;
		private static int _threadId;
		private static IntPtr _corePtr;
		private static IAIMPCore _core;
		public static IAIMPCore Core => GetCore();

		public static void Init(IntPtr ptr, string name, string author, string description, Func<bool> onInitialize, Func<bool> onDispose)
		{
			_instance = new PluginWrapper(name, author, description, onInitialize, onDispose);
			var instancePtr = Marshal.GetComInterfaceForObject<PluginWrapper, IAIMPPlugin>(_instance);
			Marshal.WriteIntPtr(ptr, instancePtr);
		}

		private static IAIMPCore GetCore()
		{
			var threadId = Thread.CurrentThread.ManagedThreadId;
			if (threadId == _threadId)
			{
				return _core;
			}
			return (IAIMPCore)Marshal.GetUniqueObjectForIUnknown(_corePtr);
		}

		private static void Collect()
		{
			for (var i = 0; i <= GC.MaxGeneration; i++)
			{
				GC.WaitForPendingFinalizers();
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}

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
			_threadId = Thread.CurrentThread.ManagedThreadId;
			_corePtr = Marshal.GetIUnknownForObject(Core);
			_core = Core;

			var result = _onInitialize();
			Collect();
			return result ? HRESULT.S_OK : HRESULT.E_FAIL;
		}

		public HRESULT Finalize()
		{
			var result = _onDispose();
			Marshal.FinalReleaseComObject(_core);
			Collect();
			return result ? HRESULT.S_OK : HRESULT.E_FAIL;
		}

		public void SystemNotification(SystemNotification NotifyId, IntPtr Data)
		{
		}
	}
}
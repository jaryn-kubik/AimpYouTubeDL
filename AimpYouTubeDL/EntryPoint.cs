using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Plugins;
using NXPorts.Attributes;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AimpYouTubeDL
{
	public static class EntryPoint
	{
		static EntryPoint()
		{
			AppDomain.CurrentDomain.AssemblyResolve += (_, args) =>
			{
				var name = new AssemblyName(args.Name).Name;
				var dir = Path.GetDirectoryName(typeof(EntryPoint).Assembly.Location);
				var path = Path.Combine(dir, name + ".dll");
				var exists = File.Exists(path);
				Trace.WriteLine($"AssemblyResolve {exists} - {path}", nameof(EntryPoint));
				return exists ? Assembly.LoadFrom(path) : null;
			};
		}

		[DllExport("AIMPPluginGetHeader", CallingConvention.StdCall)]
		public static HRESULT AIMPPluginGetHeader(IntPtr ptr)
		{
			try
			{
				var plugin = Plugin.Init();
				var pluginPtr = Marshal.GetComInterfaceForObject<Plugin, IAIMPPlugin>(plugin);
				Marshal.WriteIntPtr(ptr, pluginPtr);
				return HRESULT.S_OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Failed to load AimpYouTubeDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return HRESULT.E_FAIL;
			}
		}
	}
}
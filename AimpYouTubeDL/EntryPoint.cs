using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Plugins;
using AimpYouTubeDL.Utils;
using NXPorts.Attributes;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AimpYouTubeDL
{
	public static class EntryPoint
	{
		static EntryPoint()
		{
			AppDomain.CurrentDomain.AssemblyResolve += (_, args) => Helpers.TryCatch(TryGetAssembly, args, out Assembly assembly) ? assembly : null; ;
		}

		private static bool TryGetAssembly(ResolveEventArgs args, out Assembly assembly)
		{
			var name = new AssemblyName(args.Name).Name;
			Trace.WriteLine($"AssemblyResolve - {name}", nameof(EntryPoint));
			if (name == "Python.Runtime")
			{
				var resource = typeof(EntryPoint).Assembly.GetManifestResourceNames().First(x => x.Contains(name));
				using var memoryStream = new MemoryStream();
				using var stream = typeof(EntryPoint).Assembly.GetManifestResourceStream(resource);
				stream.CopyTo(memoryStream);
				assembly = Assembly.Load(memoryStream.ToArray());
				return true;
			}
			assembly = null;
			return false;
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
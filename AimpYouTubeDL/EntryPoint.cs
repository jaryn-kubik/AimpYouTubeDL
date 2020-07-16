using NXPorts.Attributes;
using System;
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
				return File.Exists(path)
					? Assembly.LoadFrom(path)
					: null;
			};
		}

		[DllExport("AIMPPluginGetHeader", CallingConvention.StdCall)]
		public static int AIMPPluginGetHeader(IntPtr ptr)
		{
			try
			{
				Plugin.Init(ptr);
				return 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Failed to load AimpYouTubeDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return -1;
			}
		}
	}
}
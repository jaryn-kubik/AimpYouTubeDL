using aimp_test;
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
				if (args.Name.StartsWith("AimpSharp"))
				{
					var dir = Path.GetDirectoryName(typeof(EntryPoint).Assembly.Location);
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
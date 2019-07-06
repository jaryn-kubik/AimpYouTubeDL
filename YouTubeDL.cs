using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace AIMPYoutubeDL
{
	public class YouTubeDL : IDisposable
	{
		private const string _moduleName = "youtube_dl";
		private const string _fileName = "youtube-dl";
		private const string _updateUrl = "https://yt-dl.org/latest/youtube-dl";
		private const string _updateLatest = "https://yt-dl.org/update/LATEST_VERSION";
		private const string _versionInvalid = "INVALID";

		private readonly string _file;
		private readonly Options _options;

		private IntPtr _python;
		private Lazy<PyObject> _instance = new Lazy<PyObject>(() => Py.Import(_moduleName));

		private dynamic Instance => _instance.Value;

		public YouTubeDL(string dirAppData, Options options)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
			Directory.CreateDirectory(dirAppData);
			_file = Path.Combine(dirAppData, _fileName);
			_options = options;

			var dirPlugin = Path.GetDirectoryName(typeof(YouTubeDL).Assembly.Location);
			var dirPython = Path.Combine(dirPlugin, "python");
			var path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process);
			Environment.SetEnvironmentVariable("PATH", $"{dirPython};{path}", EnvironmentVariableTarget.Process);

			PythonEngine.Initialize();
			_python = PythonEngine.BeginAllowThreads();

			using (Py.GIL())
			{
				dynamic sys = Py.Import("sys");
				sys.path.append(_file);
			}

			Version = GetVersion();
		}

		public void Dispose()
		{
			using (Py.GIL())
			{
				if (_instance?.IsValueCreated == true)
				{
					_instance.Value.Dispose();
					_instance = null;
				}
			}

			PythonEngine.EndAllowThreads(_python);
			_python = IntPtr.Zero;
			PythonEngine.Shutdown();
		}

		public string Version { get; private set; }

		public List<YouTubeDLInfo> GetInfo(string url)
		{
			EnsureModuleExists();

			var result = new List<YouTubeDLInfo>();
			using (Py.GIL())
			{
				var options = new PyDict();
				options["format"] = _options.Format.ToPython();
				options["noplaylist"] = true.ToPython();
				options["no_color"] = true.ToPython();
				options["logger"] = new YouTubeDLLogger().ToPython();

				using (dynamic ydl = Instance.YoutubeDL(options))
				{
					var info = new PyDict(ydl.extract_info(url, false));
					if (info.HasKey("entries"))
					{
						foreach (PyObject item in new PyList(info.GetItem("entries")))
						{
							result.Add(GetInfo(new PyDict(item)));
						}
					}
					else
					{
						result.Add(GetInfo(info));
					}
				}
			}
			return result;
		}

		private YouTubeDLInfo GetInfo(PyDict info)
		{
			return new YouTubeDLInfo
			{
				Uploader = GetKey<string>(info, "uploader"),
				Title = GetKey<string>(info, "title"),
				Url = GetKey<string>(info, "url"),
				Duration = GetKey<double>(info, "duration")
			};
		}

		private T GetKey<T>(PyDict obj, string key)
		{
			if (obj.HasKey(key))
			{
				return obj.GetItem(key).As<T>();
			}
			return default;
		}

		public (string prev, string current) Update()
		{
			var currentVersion = GetVersion();
			using (var http = new HttpClient())
			{
				var newVersion = string.Empty;
				if (currentVersion != _versionInvalid)
				{
					using (var stream = http.GetStreamAsync(_updateLatest).Result)
					using (var reader = new StreamReader(stream))
					{
						newVersion = reader.ReadToEnd()?.Trim();
					}
				}

				if (currentVersion != newVersion)
				{
					using (var stream = http.GetStreamAsync(_updateUrl).Result)
					using (var fileStream = new FileStream(_file, FileMode.Create))
					{
						stream.CopyTo(fileStream);
					}
				}
			}
			Version = GetVersion();
			return (currentVersion, Version);
		}

		private string GetVersion()
		{
			if (File.Exists(_file))
			{
				using (Py.GIL())
				using (dynamic versionModule = Py.Import($"{_moduleName}.version"))
				{
					var version = versionModule.__version__.ToString();
					return version?.Trim();
				}
			}
			return _versionInvalid;
		}

		private void EnsureModuleExists()
		{
			if (!File.Exists(_file))
			{
				Update();
			}
		}
	}
}
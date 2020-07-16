using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;

namespace AimpYouTubeDL.YouTube
{
	public class YouTubeDL : IDisposable
	{
		private const string _moduleName = "youtube_dl";
		private const string _fileName = "youtube-dl";
		private const string _cookieFileName = "cookies.txt";
		private const string _updateUrl = "https://yt-dl.org/latest/youtube-dl";
		private const string _updateLatest = "https://yt-dl.org/update/LATEST_VERSION";
		private const string _versionInvalid = "INVALID";

		private readonly string _file;
		private readonly string _cookieFile;

		private IntPtr _python;
		private Lazy<PyObject> _module = new Lazy<PyObject>(() => Py.Import(_moduleName));
		private readonly Dictionary<string, PyObject> _instances = new Dictionary<string, PyObject>();

		private readonly MemoryCache _cache = new MemoryCache(nameof(YouTubeDL));

		public YouTubeDL(string dirAppData)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
			_file = Path.Combine(dirAppData, _fileName);
			_cookieFile = Path.Combine(dirAppData, _cookieFileName);

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
			Clear();
			using (Py.GIL())
			{
				if (_module?.IsValueCreated == true)
				{
					_module.Value.Dispose();
					_module = null;
				}
			}

			PythonEngine.EndAllowThreads(_python);
			_python = IntPtr.Zero;
			PythonEngine.Shutdown();
		}

		public string Version { get; private set; }

		public void Clear()
		{
			using (Py.GIL())
			{
				foreach (var instance in _instances.Values)
				{
					instance.Dispose();
				}
				_instances.Clear();
			}
		}

		public List<YouTubeDLInfo> GetInfo(string url)
		{
			var newValue = new Lazy<List<YouTubeDLInfo>>(() => GetInfoInternal(url));
			var value = _cache.AddOrGetExisting(url, newValue, DateTime.Now.AddMinutes(1)) as Lazy<List<YouTubeDLInfo>>;
			return (value ?? newValue).Value;
		}

		private List<YouTubeDLInfo> GetInfoInternal(string url)
		{
			var extractor = GetExtractor(url);
			var instance = GetInstance(extractor);

			var result = new List<YouTubeDLInfo>();
			using (Py.GIL())
			{
				var info = new PyDict(instance.InvokeMethod("extract_info", url.ToPython(), false.ToPython()));
				if (info.HasKey("entries"))
				{
					foreach (PyObject item in new PyList(info.GetItem("entries")))
					{
						result.Add(YouTubeDLInfo.FromResult(new PyDict(item), info));
					}
				}
				else
				{
					result.Add(YouTubeDLInfo.FromResult(info, info));
				}
			}
			return result;
		}

		private PyObject GetInstance(string extractor)
		{
			if (!_instances.TryGetValue(extractor, out var instance))
			{
				using (Py.GIL())
				{
					var options = new PyDict();
					options["format"] = Plugin.Options.Format.ToPython();
					options["noplaylist"] = true.ToPython();
					options["extract_flat"] = "in_playlist".ToPython();
					options["no_color"] = true.ToPython();
					options["logger"] = new YouTubeDLLogger().ToPython();
					options["cookiefile"] = _cookieFile.ToPython();
					options["nocheckcertificate"] = true.ToPython();

					var auth = Plugin.Options.Auths.Find(x => x.Extractor == extractor);
					if (auth != null)
					{
						options["username"] = ((string)auth.UserName).ToPython();
						options["password"] = ((string)auth.Password).ToPython();
					}

					instance = _module.Value.InvokeMethod("YoutubeDL", options);
					_instances.Add(extractor, instance);
				}
			}
			return instance;
		}

		private string GetExtractor(string url)
		{
			EnsureModuleExists();

			using (Py.GIL())
			{
				foreach (PyObject extractor in _module.Value.InvokeMethod("gen_extractors"))
				{
					var suitable = extractor.InvokeMethod("suitable", url.ToPython());
					if (suitable.As<bool>())
					{
						var fullName = extractor.GetAttr("IE_NAME").As<string>();
						return fullName.Split(':')[0];
					}
				}
			}
			return null;
		}

		public IEnumerable<string> GetExtractors()
		{
			EnsureModuleExists();

			var result = new HashSet<string>();
			using (Py.GIL())
			{
				foreach (PyObject extractor in _module.Value.InvokeMethod("gen_extractors"))
				{
					if (extractor.HasAttr("_login"))
					{
						var fullName = extractor.GetAttr("IE_NAME").As<string>();
						var name = fullName.Split(':')[0];
						result.Add(name);
					}
				}
			}
			return result.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();
		}

		public (string prev, string current) Update()
		{
			var currentVersion = GetVersion();
			using (var http = new HttpClient())
			{
				var newVersion = string.Empty;
				if (currentVersion != _versionInvalid)
				{
					using var stream = http.GetStreamAsync(_updateLatest).GetAwaiter().GetResult();
					using var reader = new StreamReader(stream);
					newVersion = reader.ReadToEnd()?.Trim();
				}

				if (currentVersion != newVersion)
				{
					using var stream = http.GetStreamAsync(_updateUrl).GetAwaiter().GetResult();
					using var fileStream = new FileStream(_file, FileMode.Create);
					stream.CopyTo(fileStream);
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
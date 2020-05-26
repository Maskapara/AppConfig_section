using System;
using System.Configuration;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var cs = ConfigurationManager.GetSection("myAppSettings") as MyAppSettings;
			var option = cs.TraceOption;

			Console.WriteLine(option.BufferSize);
			Console.WriteLine(option.Enabled);
			Console.WriteLine(option.FilePath);

			Console.ReadLine();

		}
	}

	public class TraceOption : ConfigurationElement
	{
		[ConfigurationProperty("enabled")]
		public bool Enabled
		{
			get { return (bool)this["enabled"]; }
		}

		[ConfigurationProperty("filePath")]
		public string FilePath
		{
			get { return (string)this["filePath"]; }
		}

		[ConfigurationProperty("bufferSize")]
		public int BufferSize
		{
			get { return (int)this["bufferSize"]; }
		}
	}

	public class MyAppSettings : ConfigurationSection
	{
		[ConfigurationProperty("traceOption")]
		public TraceOption TraceOption
		{
			get { return (TraceOption)this["traceOption"]; }
			set { this["traceOption"] = value; }
		}
}
}

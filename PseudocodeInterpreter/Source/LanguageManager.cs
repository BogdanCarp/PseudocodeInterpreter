﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace PseudocodeInterpreter
{
	public class LanguageManager
	{
		private const string LangFilePath = "Config/languages.json";
		
		public LanguageKeywords Keywords { get; private set; }

		public LanguageManager(string languageName)
		{
			if (!File.Exists(LangFilePath))
			{
				throw new Exception(message: GetInstructions());
			}

			var json = JObject.Parse(File.ReadAllText(LangFilePath));

			try
			{
				var lang = json.Children<JProperty>().Single(x => x.Name == languageName);

				var keywordsObj = lang.Value.Children<JProperty>().Single(x => x.Name == "keywords").Value;
				Keywords = new LanguageKeywords(keywordsObj);
			}
			catch (InvalidOperationException)
			{
				var message = "The selected language does not exist or is specified multiple times in the config file." +
				              $"{Environment.NewLine}{Environment.NewLine}" +
				              GetInstructions();

				throw new Exception(message);

			}
			catch (ArgumentNullException)
			{
				var message = $"There are no languages specified in the config file ({LangFilePath})" +
				              $"{Environment.NewLine}{Environment.NewLine}" +
				              GetInstructions();
				
				throw new Exception(message);
			}
		}

		public static string GetInstructions()
		{
			return "Download a verified language configuration from: " +
			       "https://raw.githubusercontent.com/brown121407/" +
			       "PseudocodeInterpreter/master/PseudocodeInterpreter/" +
			       $"Config/languages.json{Environment.NewLine}" +
			       $"Language configuration file must be located at {LangFilePath}";
		}
	}
}
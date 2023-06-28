using System;
using System.Collections.Generic;

namespace Firebase.Platform.Default
{
	internal class AppConfigExtensions : IAppConfigExtensions
	{
		private static readonly Uri DefaultUpdateUrl;

		private static readonly string Default;

		private static readonly object Sync;

		private static AppConfigExtensions _instance;

		private static readonly Dictionary<int, Dictionary<string, string>> SStringState;

		public static IAppConfigExtensions Instance => null;

		protected AppConfigExtensions()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class DiagnosticsExtensions
	{
		private static bool displayFilenames;

		private static readonly Regex typeBeautifyRegex;

		private static readonly Dictionary<Type, string> builtInTypeNames;

		public static string CleanupAsyncStackTrace(this StackTrace stackTrace)
		{
			return null;
		}

		private static bool IsAsync(MethodBase methodInfo)
		{
			return false;
		}

		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType)
		{
			declaringType = null;
			return false;
		}

		private static string BeautifyType(Type t, bool shortName)
		{
			return null;
		}

		private static bool IgnoreLine(MethodBase methodInfo)
		{
			return false;
		}

		private static string AppendHyperLink(string path, string line)
		{
			return null;
		}
	}
}

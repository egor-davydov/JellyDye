using System;
using System.Collections.Generic;
using System.Text;
using Cysharp.Threading.Tasks.Internal;

namespace Cysharp.Threading.Tasks
{
	public static class TaskTracker
	{
		private static List<KeyValuePair<IUniTaskSource, (string, int, DateTime, string)>> listPool;

		private static readonly WeakDictionary<IUniTaskSource, (string, int, DateTime, string)> tracking;

		private static bool dirty;

		public static void TrackActiveTask(IUniTaskSource task, int skipFrame)
		{
		}

		public static void RemoveTracking(IUniTaskSource task)
		{
		}

		public static bool CheckAndResetDirty()
		{
			return false;
		}

		public static void ForEachActiveTask(Action<int, string, UniTaskStatus, DateTime, string> action)
		{
		}

		private static void TypeBeautify(Type type, StringBuilder sb)
		{
		}
	}
}

using System;
using System.Threading.Tasks;

namespace Firebase.Extensions
{
	public static class TaskExtension
	{
		public static Task ContinueWithOnMainThread(this Task task, Action<Task> continuation)
		{
			return null;
		}

		public static Task ContinueWithOnMainThread<T>(this Task<T> task, Action<Task<T>> continuation)
		{
			return null;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal class TaskAsyncOperation : AsyncOperationBase, INotifyCompletion
	{
		internal static TaskScheduler Scheduler;

		private Task m_Task;

		public override bool IsCompleted => false;

		public override AsyncOperationStatus Status => default(AsyncOperationStatus);

		public override Exception Exception => null;

		public override void GetResult()
		{
		}

		public override AsyncOperationBase GetAwaiter()
		{
			return null;
		}

		public TaskAsyncOperation(Task task)
		{
		}

		public static TaskAsyncOperation Run(Action action)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod]
		internal static void SetScheduler()
		{
		}
	}
}

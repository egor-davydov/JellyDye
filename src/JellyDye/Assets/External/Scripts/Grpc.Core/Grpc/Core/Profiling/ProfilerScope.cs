using System;

namespace Grpc.Core.Profiling
{
	internal struct ProfilerScope : IDisposable
	{
		private readonly IProfiler profiler;

		private readonly string tag;

		public ProfilerScope(IProfiler profiler, string tag)
		{
		}

		public void Dispose()
		{
		}
	}
}

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using SRF.Service;
using UnityEngine;
using UnityEngine.Rendering;

namespace SRDebugger.Profiler
{
	public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService
	{
		private const int FrameBufferSize = 400;

		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		private ProfilerLateUpdateListener _lateUpdateListener;

		private double _updateDuration;

		private double _renderStartTime;

		private double _renderDuration;

		private readonly Stopwatch _stopwatch;

		public float AverageFrameTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float LastFrameTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CircularBuffer<ProfilerFrame> FrameBuffer => null;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		private IEnumerator EndOfFrameCoroutine()
		{
			return null;
		}

		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		private void OnLateUpdate()
		{
		}

		private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void EndFrame()
		{
		}

		public SRPProfilerService()
		{
			((SRServiceBase<T>)(object)this)._002Ector();
		}
	}
}

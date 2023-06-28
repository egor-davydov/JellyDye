using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Profiler
{
	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService
	{
		private const int FrameBufferSize = 400;

		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		private ProfilerLateUpdateListener _lateUpdateListener;

		private readonly Stopwatch _stopwatch;

		private double _updateDuration;

		private double _renderStartTime;

		private double _renderDuration;

		private int _camerasThisFrame;

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

		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		private void OnLateUpdate()
		{
		}

		private void OnCameraPreRender(Camera cam)
		{
		}

		private void OnCameraPostRender(Camera cam)
		{
		}

		private void EndFrame()
		{
		}

		public ProfilerServiceImpl()
		{
			((SRServiceBase<T>)(object)this)._002Ector();
		}
	}
}

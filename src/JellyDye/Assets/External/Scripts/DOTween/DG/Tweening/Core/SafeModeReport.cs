using System.Runtime.CompilerServices;

namespace DG.Tweening.Core
{
	internal struct SafeModeReport
	{
		internal enum SafeModeReportType
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}

		public int totMissingTargetOrFieldErrors
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int totCallbackErrors
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int totStartupErrors
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int totUnsetErrors
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Add(SafeModeReportType type)
		{
		}

		public int GetTotErrors()
		{
			return 0;
		}
	}
}

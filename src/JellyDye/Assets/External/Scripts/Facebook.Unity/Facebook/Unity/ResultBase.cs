using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal abstract class ResultBase : IInternalResult, IResult
	{
		public virtual string Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual IDictionary<string, string> ErrorDictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual IDictionary<string, object> ResultDictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual string RawResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual bool Cancelled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual string CallbackId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected long? CanvasErrorCode
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ResultBase(ResultContainer result)
		{
		}

		internal ResultBase(ResultContainer result, string error, bool cancelled)
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected void Init(ResultContainer result, string error, bool cancelled, string callbackId)
		{
		}

		private static string GetErrorValue(IDictionary<string, object> result)
		{
			return null;
		}

		private static bool GetCancelledValue(IDictionary<string, object> result)
		{
			return false;
		}

		private static string GetCallbackId(IDictionary<string, object> result)
		{
			return null;
		}
	}
}

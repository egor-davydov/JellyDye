using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Polly
{
	public abstract class PolicyBase
	{
		protected string policyKeyInternal;

		internal readonly CancellationToken DefaultCancellationToken;

		internal const bool DefaultContinueOnCapturedContext = false;

		public string PolicyKey => null;

		protected internal ExceptionPredicates ExceptionPredicates
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal virtual void SetPolicyContext(Context executionContext, out string priorPolicyWrapKey, out string priorPolicyKey)
		{
			priorPolicyWrapKey = null;
			priorPolicyKey = null;
		}

		internal void RestorePolicyContext(Context executionContext, string priorPolicyWrapKey, string priorPolicyKey)
		{
		}

		internal static ExceptionType GetExceptionType(ExceptionPredicates exceptionPredicates, Exception exception)
		{
			return default(ExceptionType);
		}

		internal PolicyBase(ExceptionPredicates exceptionPredicates)
		{
		}

		protected PolicyBase(PolicyBuilder policyBuilder)
		{
		}
	}
}

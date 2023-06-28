using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class SRDebugUtil
{
	public const int LineBufferCount = 512;

	public static bool IsFixedUpdate
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}
}

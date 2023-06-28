using System.Diagnostics;
using UnityEngine;

namespace GGI.Components
{
	public class GGIMonoBehaviour : MonoBehaviour
	{
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null)
		{
		}

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null)
		{
		}

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, string fieldName = null)
		{
		}

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null)
		{
		}
	}
}

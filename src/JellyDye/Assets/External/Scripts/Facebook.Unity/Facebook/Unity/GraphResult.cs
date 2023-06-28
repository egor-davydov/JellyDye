using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Facebook.Unity
{
	internal class GraphResult : ResultBase, IGraphResult, IResult
	{
		private IList<object> ResultList
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public Texture2D Texture
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

		internal GraphResult(UnityWebRequestAsyncOperation result)
			: base(null)
		{
		}

		private void Init(string rawResult)
		{
		}
	}
}

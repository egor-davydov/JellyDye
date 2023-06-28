using UnityEngine;

namespace Facebook.Unity
{
	public interface IGraphResult : IResult
	{
		Texture2D Texture { get; }
	}
}

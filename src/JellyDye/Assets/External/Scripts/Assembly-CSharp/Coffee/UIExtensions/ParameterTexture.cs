using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coffee.UIExtensions
{
	[Serializable]
	public class ParameterTexture
	{
		private Texture2D _texture;

		private bool _needUpload;

		private int _propertyId;

		private readonly string _propertyName;

		private readonly int _channels;

		private readonly int _instanceLimit;

		private readonly byte[] _data;

		private readonly Stack<int> _stack;

		private static List<Action> updates;

		public ParameterTexture(int channels, int instanceLimit, string propertyName)
		{
		}

		public void Register(IParameterTexture target)
		{
		}

		public void Unregister(IParameterTexture target)
		{
		}

		public void SetData(IParameterTexture target, int channelId, byte value)
		{
		}

		public void SetData(IParameterTexture target, int channelId, float value)
		{
		}

		public void RegisterMaterial(Material mat)
		{
		}

		public float GetNormalizedIndex(IParameterTexture target)
		{
			return 0f;
		}

		private void Initialize()
		{
		}

		private void UpdateParameterTexture()
		{
		}
	}
}

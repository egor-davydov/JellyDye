using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
	[Serializable]
	internal struct SerializableProjectConfiguration
	{
		[JsonRequired]
		[SerializeField]
		internal string[] Keys;

		[JsonRequired]
		[SerializeField]
		internal ConfigurationEntry[] Values;

		public static SerializableProjectConfiguration Empty => default(SerializableProjectConfiguration);
	}
}

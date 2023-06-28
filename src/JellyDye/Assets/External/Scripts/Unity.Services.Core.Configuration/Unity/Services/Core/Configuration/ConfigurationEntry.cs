using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Services.Core.Configuration
{
	[Serializable]
	internal class ConfigurationEntry
	{
		[JsonRequired]
		[SerializeField]
		private string m_Value;

		[JsonRequired]
		[SerializeField]
		private bool m_IsReadOnly;

		[JsonIgnore]
		public string Value => null;

		[JsonIgnore]
		public bool IsReadOnly => false;

		public ConfigurationEntry()
		{
		}

		public ConfigurationEntry(string value, bool isReadOnly = false)
		{
		}

		public bool TrySetValue(string value)
		{
			return false;
		}

		public static implicit operator string(ConfigurationEntry entry)
		{
			return null;
		}

		public static implicit operator ConfigurationEntry(string value)
		{
			return null;
		}
	}
}

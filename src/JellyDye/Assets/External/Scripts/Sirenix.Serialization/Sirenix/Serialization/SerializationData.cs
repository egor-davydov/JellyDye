using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sirenix.Serialization
{
	[Serializable]
	public struct SerializationData
	{
		public const string PrefabModificationsReferencedUnityObjectsFieldName = "PrefabModificationsReferencedUnityObjects";

		public const string PrefabModificationsFieldName = "PrefabModifications";

		public const string PrefabFieldName = "Prefab";

		[SerializeField]
		public DataFormat SerializedFormat;

		[SerializeField]
		public byte[] SerializedBytes;

		[SerializeField]
		public List<UnityEngine.Object> ReferencedUnityObjects;

		[SerializeField]
		public string SerializedBytesString;

		[SerializeField]
		public UnityEngine.Object Prefab;

		[SerializeField]
		public List<UnityEngine.Object> PrefabModificationsReferencedUnityObjects;

		[SerializeField]
		public List<string> PrefabModifications;

		[SerializeField]
		public List<SerializationNode> SerializationNodes;

		[Obsolete]
		public bool HasEditorData => false;

		public bool ContainsData => false;

		public void Reset()
		{
		}
	}
}

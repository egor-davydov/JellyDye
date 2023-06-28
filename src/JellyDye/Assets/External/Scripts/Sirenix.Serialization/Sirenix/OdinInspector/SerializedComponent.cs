using Sirenix.Serialization;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[ShowOdinSerializedPropertiesInInspector]
	public abstract class SerializedComponent : Component, ISerializationCallbackReceiver, ISupportsPrefabSerialization
	{
		[HideInInspector]
		[SerializeField]
		private SerializationData serializationData;

		private SerializationData Sirenix_002ESerialization_002EISupportsPrefabSerialization_002ESerializationData
		{
			get
			{
				return default(SerializationData);
			}
			set
			{
			}
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		protected virtual void OnAfterDeserialize()
		{
		}

		protected virtual void OnBeforeSerialize()
		{
		}
	}
}

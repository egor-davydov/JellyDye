using System.Collections.Generic;
using Sirenix.Serialization.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class UnityReferenceResolver : IExternalIndexReferenceResolver, ICacheNotificationReceiver
	{
		private Dictionary<Object, int> referenceIndexMapping;

		private List<Object> referencedUnityObjects;

		public UnityReferenceResolver()
		{
		}

		public UnityReferenceResolver(List<Object> referencedUnityObjects)
		{
		}

		public List<Object> GetReferencedUnityObjects()
		{
			return null;
		}

		public void SetReferencedUnityObjects(List<Object> referencedUnityObjects)
		{
		}

		public bool CanReference(object value, out int index)
		{
			index = default(int);
			return false;
		}

		public bool TryResolveReference(int index, out object value)
		{
			value = null;
			return false;
		}

		public void Reset()
		{
		}

		private void Sirenix_002ESerialization_002EUtilities_002EICacheNotificationReceiver_002EOnFreed()
		{
		}

		private void Sirenix_002ESerialization_002EUtilities_002EICacheNotificationReceiver_002EOnClaimed()
		{
		}
	}
}

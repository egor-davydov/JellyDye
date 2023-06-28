using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		private int _referenceCount;

		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		public string GetReference(object context, object value)
		{
			return null;
		}

		public void AddReference(object context, string reference, object value)
		{
		}

		public bool IsReferenced(object context, object value)
		{
			return false;
		}
	}
}

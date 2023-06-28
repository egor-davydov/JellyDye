using System.Collections.Generic;

namespace Obi
{
	public class ObiDistanceFieldContainer
	{
		public Dictionary<ObiDistanceField, ObiDistanceFieldHandle> handles;

		public ObiNativeDistanceFieldHeaderList headers;

		public ObiNativeDFNodeList dfNodes;

		public ObiDistanceFieldHandle GetOrCreateDistanceField(ObiDistanceField source)
		{
			return null;
		}

		public void DestroyDistanceField(ObiDistanceFieldHandle handle)
		{
		}

		public void Dispose()
		{
		}
	}
}

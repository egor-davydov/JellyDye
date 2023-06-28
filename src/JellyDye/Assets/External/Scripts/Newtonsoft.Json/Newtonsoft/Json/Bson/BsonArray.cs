using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonArray : BsonToken
	{
		private readonly List<BsonToken> _children;

		public override BsonType Type => default(BsonType);

		public void Add(BsonToken token)
		{
		}
	}
}

using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonRegex : BsonToken
	{
		public BsonString Pattern
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public BsonString Options
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public override BsonType Type => default(BsonType);

		public BsonRegex(string pattern, string options)
		{
		}
	}
}

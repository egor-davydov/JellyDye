using System.Collections.Generic;

namespace Facebook.Unity
{
	public sealed class CustomUpdateContent
	{
		private string _contextTokenId;

		private CustomUpdateLocalizedText _text;

		private CustomUpdateLocalizedText _cta;

		private string _image;

		private CustomUpdateMedia _media;

		private string _data;

		public IDictionary<string, string> toGraphAPIData()
		{
			return null;
		}
	}
}

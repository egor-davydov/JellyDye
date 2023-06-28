namespace Newtonsoft.Json.Linq
{
	public class JsonLoadSettings
	{
		private CommentHandling _commentHandling;

		private LineInfoHandling _lineInfoHandling;

		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

		public CommentHandling CommentHandling => default(CommentHandling);

		public LineInfoHandling LineInfoHandling => default(LineInfoHandling);

		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling => default(DuplicatePropertyNameHandling);
	}
}

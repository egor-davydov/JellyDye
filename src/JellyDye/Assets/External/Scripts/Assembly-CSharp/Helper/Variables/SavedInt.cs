namespace Helper.Variables
{
	public struct SavedInt
	{
		private readonly string _key;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SavedInt(string key)
		{
		}

		public void Delete()
		{
		}

		public static implicit operator int(SavedInt value)
		{
			return 0;
		}

		public static SavedInt operator +(SavedInt a, int b)
		{
			return default(SavedInt);
		}

		public static SavedInt operator ++(SavedInt value)
		{
			return default(SavedInt);
		}
	}
}

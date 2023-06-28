using System.Runtime.CompilerServices;

namespace IdGen
{
	public class MaskConfig
	{
		public byte TimestampBits
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte GeneratorIdBits
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte SequenceBits
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int TotalBits => 0;

		public static MaskConfig Default => null;

		public MaskConfig(byte timestampBits, byte generatorIdBits, byte sequenceBits)
		{
		}
	}
}

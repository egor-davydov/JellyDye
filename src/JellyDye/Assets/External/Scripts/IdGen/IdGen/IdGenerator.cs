using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IdGen
{
	public class IdGenerator : IEnumerable<long>, IEnumerable
	{
		public static readonly DateTime DefaultEpoch;

		private int _sequence;

		private long _lastgen;

		private readonly long _generatorId;

		private readonly long MASK_SEQUENCE;

		private readonly long MASK_TIME;

		private readonly long MASK_GENERATOR;

		private readonly int SHIFT_TIME;

		private readonly int SHIFT_GENERATOR;

		private readonly object _genlock;

		private MaskConfig MaskConfig
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public ITimeSource TimeSource
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IdGenerator(int generatorId)
		{
		}

		public IdGenerator(int generatorId, DateTimeOffset epoch)
		{
		}

		public IdGenerator(int generatorId, DateTimeOffset epoch, MaskConfig maskConfig)
		{
		}

		public IdGenerator(int generatorId, MaskConfig maskConfig, ITimeSource timeSource)
		{
		}

		public long CreateId()
		{
			return 0L;
		}

		[MethodImpl(256)]
		private long GetTicks()
		{
			return 0L;
		}

		[MethodImpl(256)]
		private static long GetMask(byte bits)
		{
			return 0L;
		}

		private IEnumerable<long> IdStream()
		{
			return null;
		}

		public IEnumerator<long> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}

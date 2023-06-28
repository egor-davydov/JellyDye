using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics.Internal
{
	internal class Buffer : IBuffer
	{
		internal enum TokenType
		{
			EventStart = 0,
			EventEnd = 1,
			EventParamsStart = 2,
			EventParamsEnd = 3,
			EventObjectStart = 4,
			EventObjectEnd = 5,
			EventArrayStart = 6,
			EventArrayEnd = 7,
			Boolean = 8,
			Float64 = 9,
			String = 10,
			Int64 = 11,
			Timestamp = 12,
			EventTimestamp = 13,
			StandardEventIds = 14
		}

		internal struct Token
		{
			public string Name;

			public TokenType Type;

			public object Data;
		}

		private readonly List<Token> m_Tokens;

		private readonly string m_CacheFilePath;

		private readonly long m_CacheFileMaximumSize;

		private int m_DiskCacheLastFlushedToken;

		private long m_DiskCacheSize;

		public string UserID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string SessionID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string PlayerID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string InstallID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<Token> CloneTokens()
		{
			return null;
		}

		public void InsertTokens(List<Token> tokens)
		{
		}

		public string Serialize(List<Token> tokens)
		{
			return null;
		}

		public static string SaveDateTime(DateTime dateTime)
		{
			return null;
		}

		private static DateTime ParseDateTime(string dateTime)
		{
			return default(DateTime);
		}

		private bool IsRequestOverSizeLimit(string data)
		{
			return false;
		}

		public void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody = false)
		{
		}

		public void PushEndEvent()
		{
		}

		public void PushObjectStart(string name = null)
		{
		}

		public void PushObjectEnd()
		{
		}

		public void PushArrayStart(string name = null)
		{
		}

		public void PushArrayEnd()
		{
		}

		public void PushDouble(double val, string name = null)
		{
		}

		public void PushString(string val, string name = null)
		{
		}

		public void PushInt64(long val, string name = null)
		{
		}

		public void PushBool(bool val, string name = null)
		{
		}

		public void FlushToDisk()
		{
		}

		public void ClearDiskCache()
		{
		}

		public void ClearBuffer()
		{
		}

		public void LoadFromDisk()
		{
		}

		private void WriteToken(BinaryWriter writer, Token token)
		{
		}

		private Token ReadToken(BinaryReader reader)
		{
			return default(Token);
		}

		private static bool CanUseDiskPersistence()
		{
			return false;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Unity.Services.Analytics.Internal
{
	internal interface IBuffer
	{
		string UserID { set; }

		string InstallID { get; set; }

		string PlayerID { set; }

		string SessionID { set; }

		string Serialize(List<Buffer.Token> tokens);

		void InsertTokens(List<Buffer.Token> tokens);

		void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody = false);

		void PushEndEvent();

		void PushObjectStart(string name = null);

		void PushObjectEnd();

		void PushArrayStart(string name = null);

		void PushArrayEnd();

		void PushDouble(double val, string name = null);

		void PushString(string val, string name = null);

		void PushInt64(long val, string name = null);

		void PushBool(bool val, string name = null);

		void FlushToDisk();

		void ClearDiskCache();

		void ClearBuffer();

		List<Buffer.Token> CloneTokens();
	}
}

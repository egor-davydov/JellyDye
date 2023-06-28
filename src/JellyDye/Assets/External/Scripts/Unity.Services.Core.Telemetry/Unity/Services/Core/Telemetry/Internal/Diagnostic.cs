using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct Diagnostic : ITelemetryEvent
	{
		public IDictionary<string, string> Content;
	}
}

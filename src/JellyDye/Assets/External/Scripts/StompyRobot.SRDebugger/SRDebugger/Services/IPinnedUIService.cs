using System;
using SRDebugger.Internal;
using UnityEngine;

namespace SRDebugger.Services
{
	public interface IPinnedUIService
	{
		bool IsProfilerPinned { get; set; }

		event Action<OptionDefinition, bool> OptionPinStateChanged;

		event Action<RectTransform> OptionsCanvasCreated;

		void Pin(OptionDefinition option, int order = -1);

		void Unpin(OptionDefinition option);

		void UnpinAll();

		bool HasPinned(OptionDefinition option);
	}
}

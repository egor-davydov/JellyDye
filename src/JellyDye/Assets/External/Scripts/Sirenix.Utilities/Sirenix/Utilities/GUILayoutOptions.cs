using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class GUILayoutOptions
	{
		internal enum GUILayoutOptionType
		{
			Width = 0,
			Height = 1,
			MinWidth = 2,
			MaxHeight = 3,
			MaxWidth = 4,
			MinHeight = 5,
			ExpandHeight = 6,
			ExpandWidth = 7
		}

		public sealed class GUILayoutOptionsInstance : IEquatable<GUILayoutOptionsInstance>
		{
			private float value;

			internal GUILayoutOptionsInstance Parent;

			internal GUILayoutOptionType GUILayoutOptionType;

			private GUILayoutOption[] GetCachedOptions()
			{
				return null;
			}

			public static implicit operator GUILayoutOption[](GUILayoutOptionsInstance options)
			{
				return null;
			}

			private GUILayoutOption[] CreateOptionsArary()
			{
				return null;
			}

			private GUILayoutOptionsInstance Clone()
			{
				return null;
			}

			internal GUILayoutOptionsInstance()
			{
			}

			public GUILayoutOptionsInstance Width(float width)
			{
				return null;
			}

			public GUILayoutOptionsInstance Height(float height)
			{
				return null;
			}

			public GUILayoutOptionsInstance MaxHeight(float height)
			{
				return null;
			}

			public GUILayoutOptionsInstance MaxWidth(float width)
			{
				return null;
			}

			public GUILayoutOptionsInstance MinHeight(float height)
			{
				return null;
			}

			public GUILayoutOptionsInstance MinWidth(float width)
			{
				return null;
			}

			public GUILayoutOptionsInstance ExpandHeight(bool expand = true)
			{
				return null;
			}

			public GUILayoutOptionsInstance ExpandWidth(bool expand = true)
			{
				return null;
			}

			internal void SetValue(GUILayoutOptionType type, float value)
			{
			}

			internal void SetValue(GUILayoutOptionType type, bool value)
			{
			}

			public bool Equals(GUILayoutOptionsInstance other)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private static int CurrentCacheIndex;

		private static readonly GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache;

		private static readonly Dictionary<GUILayoutOptionsInstance, GUILayoutOption[]> GUILayoutOptionsCache;

		public static readonly GUILayoutOption[] EmptyGUIOptions;

		static GUILayoutOptions()
		{
		}

		public static GUILayoutOptionsInstance Width(float width)
		{
			return null;
		}

		public static GUILayoutOptionsInstance Height(float height)
		{
			return null;
		}

		public static GUILayoutOptionsInstance MaxHeight(float height)
		{
			return null;
		}

		public static GUILayoutOptionsInstance MaxWidth(float width)
		{
			return null;
		}

		public static GUILayoutOptionsInstance MinWidth(float width)
		{
			return null;
		}

		public static GUILayoutOptionsInstance MinHeight(float height)
		{
			return null;
		}

		public static GUILayoutOptionsInstance ExpandHeight(bool expand = true)
		{
			return null;
		}

		public static GUILayoutOptionsInstance ExpandWidth(bool expand = true)
		{
			return null;
		}
	}
}

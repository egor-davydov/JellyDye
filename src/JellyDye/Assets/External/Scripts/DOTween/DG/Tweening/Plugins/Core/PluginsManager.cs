using System;
using System.Collections.Generic;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins.Core
{
	internal static class PluginsManager
	{
		private static ITweenPlugin _floatPlugin;

		private static ITweenPlugin _doublePlugin;

		private static ITweenPlugin _intPlugin;

		private static ITweenPlugin _uintPlugin;

		private static ITweenPlugin _longPlugin;

		private static ITweenPlugin _ulongPlugin;

		private static ITweenPlugin _vector2Plugin;

		private static ITweenPlugin _vector3Plugin;

		private static ITweenPlugin _vector4Plugin;

		private static ITweenPlugin _quaternionPlugin;

		private static ITweenPlugin _colorPlugin;

		private static ITweenPlugin _rectPlugin;

		private static ITweenPlugin _rectOffsetPlugin;

		private static ITweenPlugin _stringPlugin;

		private static ITweenPlugin _vector3ArrayPlugin;

		private static ITweenPlugin _color2Plugin;

		private const int _MaxCustomPlugins = 20;

		private static Dictionary<Type, ITweenPlugin> _customPlugins;

		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() where TPlugin : ITweenPlugin, new() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		internal static void PurgeAll()
		{
		}
	}
}

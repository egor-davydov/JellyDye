using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class SerializationUtility
	{
		public static IDataWriter CreateWriter(Stream stream, SerializationContext context, DataFormat format)
		{
			return null;
		}

		public static IDataReader CreateReader(Stream stream, DeserializationContext context, DataFormat format)
		{
			return null;
		}

		private static IDataWriter GetCachedWriter(out IDisposable cache, DataFormat format, Stream stream, SerializationContext context)
		{
			cache = null;
			return null;
		}

		private static IDataReader GetCachedReader(out IDisposable cache, DataFormat format, Stream stream, DeserializationContext context)
		{
			cache = null;
			return null;
		}

		public static void SerializeValueWeak(object value, IDataWriter writer)
		{
		}

		public static void SerializeValueWeak(object value, IDataWriter writer, out List<UnityEngine.Object> unityObjects)
		{
			unityObjects = null;
		}

		public static void SerializeValue<T>(T value, IDataWriter writer)
		{
		}

		public static void SerializeValue<T>(T value, IDataWriter writer, out List<UnityEngine.Object> unityObjects)
		{
			unityObjects = null;
		}

		public static void SerializeValueWeak(object value, Stream stream, DataFormat format, SerializationContext context = null)
		{
		}

		public static void SerializeValueWeak(object value, Stream stream, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			unityObjects = null;
		}

		public static void SerializeValue<T>(T value, Stream stream, DataFormat format, SerializationContext context = null)
		{
		}

		public static void SerializeValue<T>(T value, Stream stream, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			unityObjects = null;
		}

		public static byte[] SerializeValueWeak(object value, DataFormat format, SerializationContext context = null)
		{
			return null;
		}

		public static byte[] SerializeValueWeak(object value, DataFormat format, out List<UnityEngine.Object> unityObjects)
		{
			unityObjects = null;
			return null;
		}

		public static byte[] SerializeValue<T>(T value, DataFormat format, SerializationContext context = null)
		{
			return null;
		}

		public static byte[] SerializeValue<T>(T value, DataFormat format, out List<UnityEngine.Object> unityObjects, SerializationContext context = null)
		{
			unityObjects = null;
			return null;
		}

		public static object DeserializeValueWeak(IDataReader reader)
		{
			return null;
		}

		public static object DeserializeValueWeak(IDataReader reader, List<UnityEngine.Object> referencedUnityObjects)
		{
			return null;
		}

		public static T DeserializeValue<T>(IDataReader reader)
		{
			return default(T);
		}

		public static T DeserializeValue<T>(IDataReader reader, List<UnityEngine.Object> referencedUnityObjects)
		{
			return default(T);
		}

		public static object DeserializeValueWeak(Stream stream, DataFormat format, DeserializationContext context = null)
		{
			return null;
		}

		public static object DeserializeValueWeak(Stream stream, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			return null;
		}

		public static T DeserializeValue<T>(Stream stream, DataFormat format, DeserializationContext context = null)
		{
			return default(T);
		}

		public static T DeserializeValue<T>(Stream stream, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			return default(T);
		}

		public static object DeserializeValueWeak(byte[] bytes, DataFormat format, DeserializationContext context = null)
		{
			return null;
		}

		public static object DeserializeValueWeak(byte[] bytes, DataFormat format, List<UnityEngine.Object> referencedUnityObjects)
		{
			return null;
		}

		public static T DeserializeValue<T>(byte[] bytes, DataFormat format, DeserializationContext context = null)
		{
			return default(T);
		}

		public static T DeserializeValue<T>(byte[] bytes, DataFormat format, List<UnityEngine.Object> referencedUnityObjects, DeserializationContext context = null)
		{
			return default(T);
		}

		public static object CreateCopy(object obj)
		{
			return null;
		}
	}
}

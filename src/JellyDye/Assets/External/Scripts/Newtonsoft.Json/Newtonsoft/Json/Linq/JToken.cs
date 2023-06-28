using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;

namespace Newtonsoft.Json.Linq
{
	public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		private class LineInfoAnnotation
		{
			internal readonly int LineNumber;

			internal readonly int LinePosition;

			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}
		}

		private JContainer _parent;

		private JToken _previous;

		private JToken _next;

		private object _annotations;

		private static readonly JTokenType[] BooleanTypes;

		private static readonly JTokenType[] NumberTypes;

		private static readonly JTokenType[] BigIntegerTypes;

		private static readonly JTokenType[] StringTypes;

		private static readonly JTokenType[] GuidTypes;

		private static readonly JTokenType[] TimeSpanTypes;

		private static readonly JTokenType[] UriTypes;

		private static readonly JTokenType[] CharTypes;

		private static readonly JTokenType[] DateTimeTypes;

		private static readonly JTokenType[] BytesTypes;

		public JContainer Parent
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Root => null;

		public abstract JTokenType Type { get; }

		public abstract bool HasValues { get; }

		public JToken Next
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Previous
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Path => null;

		public virtual JToken First => null;

		public virtual JToken Last => null;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber => 0;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition => 0;

		internal abstract JToken CloneToken();

		internal JToken()
		{
		}

		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		public void Remove()
		{
		}

		public void Replace(JToken value)
		{
		}

		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		public override string ToString()
		{
			return null;
		}

		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		private static string GetType(JToken token)
		{
			return null;
		}

		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return false;
		}

		public static explicit operator bool(JToken value)
		{
			return false;
		}

		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		public static explicit operator long(JToken value)
		{
			return 0L;
		}

		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		public static explicit operator double?(JToken value)
		{
			return null;
		}

		public static explicit operator char?(JToken value)
		{
			return null;
		}

		public static explicit operator int(JToken value)
		{
			return 0;
		}

		public static explicit operator short(JToken value)
		{
			return 0;
		}

		public static explicit operator ushort(JToken value)
		{
			return 0;
		}

		public static explicit operator char(JToken value)
		{
			return '\0';
		}

		public static explicit operator byte(JToken value)
		{
			return 0;
		}

		public static explicit operator sbyte(JToken value)
		{
			return 0;
		}

		public static explicit operator int?(JToken value)
		{
			return null;
		}

		public static explicit operator short?(JToken value)
		{
			return null;
		}

		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		public static explicit operator long?(JToken value)
		{
			return null;
		}

		public static explicit operator float?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal(JToken value)
		{
			return default(decimal);
		}

		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		public static explicit operator double(JToken value)
		{
			return 0.0;
		}

		public static explicit operator float(JToken value)
		{
			return 0f;
		}

		public static explicit operator string(JToken value)
		{
			return null;
		}

		public static explicit operator uint(JToken value)
		{
			return 0u;
		}

		public static explicit operator ulong(JToken value)
		{
			return 0uL;
		}

		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		private static BigInteger ToBigInteger(JToken value)
		{
			return default(BigInteger);
		}

		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
		{
			return null;
		}

		public JsonReader CreateReader()
		{
			return null;
		}

		public object ToObject(Type objectType)
		{
			return null;
		}

		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return false;
		}

		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		private DynamicMetaObject System_002EDynamic_002EIDynamicMetaObjectProvider_002EGetMetaObject(Expression parameter)
		{
			return null;
		}

		private object System_002EICloneable_002EClone()
		{
			return null;
		}

		public JToken DeepClone()
		{
			return null;
		}

		public void AddAnnotation(object annotation)
		{
		}

		public T Annotation<T>() where T : class
		{
			return null;
		}

		internal void CopyAnnotations(JToken target, JToken source)
		{
		}
	}
}

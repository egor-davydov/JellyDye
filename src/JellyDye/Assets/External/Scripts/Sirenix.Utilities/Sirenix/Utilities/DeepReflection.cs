using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Utilities
{
	public static class DeepReflection
	{
		private enum PathStepType
		{
			Member = 0,
			WeakListElement = 1,
			StrongListElement = 2,
			ArrayElement = 3
		}

		private struct PathStep
		{
			public readonly PathStepType StepType;

			public readonly MemberInfo Member;

			public readonly int ElementIndex;

			public readonly Type ElementType;

			public readonly MethodInfo StrongListGetItemMethod;

			public PathStep(MemberInfo member)
			{
			}

			public PathStep(int elementIndex)
			{
			}

			public PathStep(int elementIndex, Type strongListElementType, bool isArray)
			{
			}
		}

		private static MethodInfo WeakListGetItem;

		private static MethodInfo WeakListSetItem;

		private static MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo;

		private static MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo;

		private static MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo;

		private static MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo;

		public static Func<object> CreateWeakStaticValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			return null;
		}

		public static Func<object, object> CreateWeakInstanceValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			return null;
		}

		public static Action<object, object> CreateWeakInstanceValueSetter(Type rootType, Type argType, string path, bool allowEmit = true)
		{
			return null;
		}

		public static Func<object, TResult> CreateWeakInstanceValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			return null;
		}

		public static Func<TResult> CreateValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			return null;
		}

		public static Func<TTarget, TResult> CreateValueGetter<TTarget, TResult>(string path, bool allowEmit = true)
		{
			return null;
		}

		private static Func<object, object> CreateWeakAliasForInstanceGetDelegate1<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			return null;
		}

		private static Func<object, TResult> CreateWeakAliasForInstanceGetDelegate2<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			return null;
		}

		private static Func<object> CreateWeakAliasForStaticGetDelegate<TResult>(Func<TResult> func)
		{
			return null;
		}

		private static Action<object, object> CreateWeakAliasForInstanceSetDelegate1<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			return null;
		}

		private static Action<object, TArg1> CreateWeakAliasForInstanceSetDelegate2<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			return null;
		}

		private static Action<object> CreateWeakAliasForStaticSetDelegate<TArg1>(Action<TArg1> func)
		{
			return null;
		}

		private static Delegate CreateEmittedDeepValueGetterDelegate(string path, Type rootType, Type resultType, List<PathStep> memberPath, bool rootIsStatic)
		{
			return null;
		}

		private static Func<object> CreateSlowDeepStaticValueGetterDelegate(List<PathStep> memberPath)
		{
			return null;
		}

		private static Func<object, object> CreateSlowDeepInstanceValueGetterDelegate(List<PathStep> memberPath)
		{
			return null;
		}

		private static Action<object, object> CreateSlowDeepInstanceValueSetterDelegate(List<PathStep> memberPath)
		{
			return null;
		}

		private static object SlowGetMemberValue(PathStep step, object instance)
		{
			return null;
		}

		private static void SlowSetMemberValue(PathStep step, object instance, object value)
		{
		}

		private static List<PathStep> GetMemberPath(Type rootType, ref Type resultType, string path, out bool rootIsStatic, bool isSet)
		{
			rootIsStatic = default(bool);
			return null;
		}

		private static MemberInfo GetStepMember(Type owningType, string name, bool expectMethod)
		{
			return null;
		}
	}
}

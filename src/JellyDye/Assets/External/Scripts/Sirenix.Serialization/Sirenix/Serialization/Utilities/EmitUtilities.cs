using System;
using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal static class EmitUtilities
	{
		public delegate void InstanceRefMethodCaller<InstanceType>(ref InstanceType instance);

		public delegate void InstanceRefMethodCaller<InstanceType, TArg1>(ref InstanceType instance, TArg1 arg1);

		public static bool CanEmit => false;

		public static Func<FieldType> CreateStaticFieldGetter<FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		public static Func<object> CreateWeakStaticFieldGetter(FieldInfo fieldInfo)
		{
			return null;
		}

		public static Action<FieldType> CreateStaticFieldSetter<FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		public static Action<object> CreateWeakStaticFieldSetter(FieldInfo fieldInfo)
		{
			return null;
		}

		public static ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		public static WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		public static WeakValueGetter CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		public static ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(FieldInfo fieldInfo)
		{
			return null;
		}

		public static WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		public static WeakValueSetter CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo)
		{
			return null;
		}

		public static WeakValueGetter CreateWeakInstancePropertyGetter(Type instanceType, PropertyInfo propertyInfo)
		{
			return null;
		}

		public static WeakValueSetter CreateWeakInstancePropertySetter(Type instanceType, PropertyInfo propertyInfo)
		{
			return null;
		}

		public static Action<PropType> CreateStaticPropertySetter<PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static Func<PropType> CreateStaticPropertyGetter<PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Action CreateStaticMethodCaller(MethodInfo methodInfo)
		{
			return null;
		}

		public static Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Action<object> CreateWeakInstanceMethodCaller(MethodInfo methodInfo)
		{
			return null;
		}

		public static Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(MethodInfo methodInfo)
		{
			return null;
		}

		public static Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo)
		{
			return null;
		}

		public static InstanceRefMethodCaller<InstanceType> CreateInstanceRefMethodCaller<InstanceType>(MethodInfo methodInfo)
		{
			return null;
		}

		public static InstanceRefMethodCaller<InstanceType, Arg1> CreateInstanceRefMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo)
		{
			return null;
		}
	}
}

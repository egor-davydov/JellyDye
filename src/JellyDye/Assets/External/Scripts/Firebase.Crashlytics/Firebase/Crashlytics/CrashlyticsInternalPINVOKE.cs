using System;
using System.Runtime.InteropServices;

namespace Firebase.Crashlytics
{
	internal class CrashlyticsInternalPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			internal static extern void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			internal static extern void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			private static void SetPendingApplicationException(string message)
			{
			}

			private static void SetPendingArithmeticException(string message)
			{
			}

			private static void SetPendingDivideByZeroException(string message)
			{
			}

			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			private static void SetPendingInvalidCastException(string message)
			{
			}

			private static void SetPendingInvalidOperationException(string message)
			{
			}

			private static void SetPendingIOException(string message)
			{
			}

			private static void SetPendingNullReferenceException(string message)
			{
			}

			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			private static void SetPendingOverflowException(string message)
			{
			}

			private static void SetPendingSystemException(string message)
			{
			}

			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			static SWIGExceptionHelper()
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}

			static SWIGPendingException()
			{
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			internal static extern void SWIGRegisterStringCallback_CrashlyticsInternal(SWIGStringDelegate stringDelegate);

			private static string CreateString(string cString)
			{
				return null;
			}

			static SWIGStringHelper()
			{
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static CrashlyticsInternalPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern void StackFrames_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern void StackFrames_Add(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint StackFrames_size(HandleRef jarg1);

		[PreserveSig]
		public static extern uint StackFrames_capacity(HandleRef jarg1);

		[PreserveSig]
		public static extern void StackFrames_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_StackFrames__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_StackFrames__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_StackFrames__SWIG_2(int jarg1);

		[PreserveSig]
		public static extern IntPtr StackFrames_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr StackFrames_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void StackFrames_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void StackFrames_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr StackFrames_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void StackFrames_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void StackFrames_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void StackFrames_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void StackFrames_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr StackFrames_Repeat(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void StackFrames_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern void StackFrames_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void StackFrames_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void delete_StackFrames(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsFrame_library_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string FirebaseCrashlyticsFrame_library_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsFrame_symbol_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string FirebaseCrashlyticsFrame_symbol_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsFrame_fileName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string FirebaseCrashlyticsFrame_fileName_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsFrame_lineNumber_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string FirebaseCrashlyticsFrame_lineNumber_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FirebaseCrashlyticsFrame();

		[PreserveSig]
		public static extern void delete_FirebaseCrashlyticsFrame(HandleRef jarg1);

		[PreserveSig]
		internal static extern void delete_FirebaseCrashlyticsInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_0(HandleRef jarg1, out int jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsInternal_Log(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsInternal_SetCustomKey(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsInternal_SetUserId(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsInternal_LogException(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern bool FirebaseCrashlyticsInternal_IsCrashlyticsCollectionEnabled(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseCrashlyticsInternal_SetCrashlyticsCollectionEnabled(HandleRef jarg1, bool jarg2);
	}
}

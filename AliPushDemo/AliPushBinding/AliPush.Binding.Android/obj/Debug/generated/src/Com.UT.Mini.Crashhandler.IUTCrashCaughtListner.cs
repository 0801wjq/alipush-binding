using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Crashhandler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.mini.crashhandler']/interface[@name='IUTCrashCaughtListner']"
	[Register ("com/ut/mini/crashhandler/IUTCrashCaughtListner", "", "Com.UT.Mini.Crashhandler.IUTCrashCaughtListnerInvoker")]
	public partial interface IUTCrashCaughtListner : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.crashhandler']/interface[@name='IUTCrashCaughtListner']/method[@name='onCrashCaught' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onCrashCaught", "(Ljava/lang/Thread;Ljava/lang/Throwable;)Ljava/util/Map;", "GetOnCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_Handler:Com.UT.Mini.Crashhandler.IUTCrashCaughtListnerInvoker, AliPush.Binding.Android")]
		global::System.Collections.Generic.IDictionary<string, string> OnCrashCaught (global::Java.Lang.Thread p0, global::Java.Lang.Throwable p1);

	}

	[global::Android.Runtime.Register ("com/ut/mini/crashhandler/IUTCrashCaughtListner", DoNotGenerateAcw=true)]
	internal class IUTCrashCaughtListnerInvoker : global::Java.Lang.Object, IUTCrashCaughtListner {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/mini/crashhandler/IUTCrashCaughtListner");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTCrashCaughtListnerInvoker); }
		}

		IntPtr class_ref;

		public static IUTCrashCaughtListner GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTCrashCaughtListner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.mini.crashhandler.IUTCrashCaughtListner"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTCrashCaughtListnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static IntPtr n_OnCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.UT.Mini.Crashhandler.IUTCrashCaughtListner __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Crashhandler.IUTCrashCaughtListner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.OnCrashCaught (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> OnCrashCaught (global::Java.Lang.Thread p0, global::Java.Lang.Throwable p1)
		{
			if (id_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCrashCaught", "(Ljava/lang/Thread;Ljava/lang/Throwable;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCrashCaught_Ljava_lang_Thread_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}

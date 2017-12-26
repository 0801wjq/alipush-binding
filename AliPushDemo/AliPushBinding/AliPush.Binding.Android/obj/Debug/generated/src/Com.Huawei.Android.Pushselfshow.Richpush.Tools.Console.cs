using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushselfshow.Richpush.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.tools']/class[@name='Console']"
	[global::Android.Runtime.Register ("com/huawei/android/pushselfshow/richpush/tools/Console", DoNotGenerateAcw=true)]
	public partial class Console : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushselfshow/richpush/tools/Console", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Console); }
		}

		protected Console (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.tools']/class[@name='Console']/constructor[@name='Console' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Console ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Console)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_log_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_lang_String_ == null)
				cb_log_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Log_Ljava_lang_String_);
			return cb_log_Ljava_lang_String_;
		}

		static void n_Log_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Tools.Console __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Tools.Console> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0);
		}
#pragma warning restore 0169

		static IntPtr id_log_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.tools']/class[@name='Console']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "GetLog_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (string p0)
		{
			if (id_log_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logV_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogV_Ljava_lang_String_Handler ()
		{
			if (cb_logV_Ljava_lang_String_ == null)
				cb_logV_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogV_Ljava_lang_String_);
			return cb_logV_Ljava_lang_String_;
		}

		static void n_LogV_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Tools.Console __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Tools.Console> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogV (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logV_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.tools']/class[@name='Console']/method[@name='logV' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logV", "(Ljava/lang/String;)V", "GetLogV_Ljava_lang_String_Handler")]
		public virtual unsafe void LogV (string p0)
		{
			if (id_logV_Ljava_lang_String_ == IntPtr.Zero)
				id_logV_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logV", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logV_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logV", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SharedPreferencesUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/SharedPreferencesUtils", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/SharedPreferencesUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPreferencesUtils); }
		}

		protected SharedPreferencesUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SharedPreferencesUtils']/constructor[@name='SharedPreferencesUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SharedPreferencesUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SharedPreferencesUtils)) {
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

		static IntPtr id_getLong_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SharedPreferencesUtils']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLong", "(Landroid/content/Context;Ljava/lang/String;)J", "")]
		public static unsafe long GetLong (global::Android.Content.Context p0, string p1)
		{
			if (id_getLong_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLong", "(Landroid/content/Context;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLong_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setLong_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SharedPreferencesUtils']/method[@name='setLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setLong", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public static unsafe void SetLong (global::Android.Content.Context p0, string p1, long p2)
		{
			if (id_setLong_Landroid_content_Context_Ljava_lang_String_J == IntPtr.Zero)
				id_setLong_Landroid_content_Context_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "setLong", "(Landroid/content/Context;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLong_Landroid_content_Context_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

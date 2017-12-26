using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='ConnectionException']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/sendrequest/ConnectionException", DoNotGenerateAcw=true)]
	public partial class ConnectionException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='ConnectionException']/field[@name='CONNECTION_TYPE_HTTP']"
		[Register ("CONNECTION_TYPE_HTTP")]
		public const int ConnectionTypeHttp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='ConnectionException']/field[@name='CONNECTION_TYPE_TCP']"
		[Register ("CONNECTION_TYPE_TCP")]
		public const int ConnectionTypeTcp = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/sendrequest/ConnectionException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionException); }
		}

		protected ConnectionException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='ConnectionException']/constructor[@name='ConnectionException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ConnectionException (int p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ConnectionException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getReturnCode;
#pragma warning disable 0169
		static Delegate GetGetReturnCodeHandler ()
		{
			if (cb_getReturnCode == null)
				cb_getReturnCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReturnCode);
			return cb_getReturnCode;
		}

		static IntPtr n_GetReturnCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.ConnectionException __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.ConnectionException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReturnCode);
		}
#pragma warning restore 0169

		static IntPtr id_getReturnCode;
		public virtual unsafe string ReturnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='ConnectionException']/method[@name='getReturnCode' and count(parameter)=0]"
			[Register ("getReturnCode", "()Ljava/lang/String;", "GetGetReturnCodeHandler")]
			get {
				if (id_getReturnCode == IntPtr.Zero)
					id_getReturnCode = JNIEnv.GetMethodID (class_ref, "getReturnCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getReturnCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReturnCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='SignUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/SignUtil", DoNotGenerateAcw=true)]
	public partial class SignUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='SignUtil']/field[@name='SIGN_KEY']"
		[Register ("SIGN_KEY")]
		public const string SignKey = (string) "sign";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='SignUtil']/field[@name='seed_key_name']"
		[Register ("seed_key_name")]
		public const string SeedKeyName = (string) "TMP_SEED_KEY";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/SignUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignUtil); }
		}

		protected SignUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='SignUtil']/constructor[@name='SignUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SignUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SignUtil)) {
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

		static IntPtr id_generateRequestParameters_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='SignUtil']/method[@name='generateRequestParameters' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("generateRequestParameters", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GenerateRequestParameters (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_generateRequestParameters_Ljava_util_Map_ == IntPtr.Zero)
				id_generateRequestParameters_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "generateRequestParameters", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateRequestParameters_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

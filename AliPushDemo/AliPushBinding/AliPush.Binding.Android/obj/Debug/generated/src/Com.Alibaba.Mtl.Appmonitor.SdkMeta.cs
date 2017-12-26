using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/SdkMeta", DoNotGenerateAcw=true)]
	public partial class SdkMeta : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "2.6.0_for_bc";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/SdkMeta", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SdkMeta); }
		}

		protected SdkMeta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']/constructor[@name='SdkMeta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SdkMeta ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SdkMeta)) {
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

		static IntPtr id_getSDKMetaData;
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> SDKMetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']/method[@name='getSDKMetaData' and count(parameter)=0]"
			[Register ("getSDKMetaData", "()Ljava/util/Map;", "GetGetSDKMetaDataHandler")]
			get {
				if (id_getSDKMetaData == IntPtr.Zero)
					id_getSDKMetaData = JNIEnv.GetStaticMethodID (class_ref, "getSDKMetaData", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKMetaData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getString_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Android.Content.Context context, string paramString)
		{
			if (id_getString_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_paramString = JNIEnv.NewString (paramString);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_paramString);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_paramString);
			}
		}

		static IntPtr id_setExtra_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='SdkMeta']/method[@name='setExtra' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setExtra", "(Ljava/util/Map;)V", "")]
		public static unsafe void SetExtra (global::System.Collections.Generic.IDictionary<string, string> extra)
		{
			if (id_setExtra_Ljava_util_Map_ == IntPtr.Zero)
				id_setExtra_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "setExtra", "(Ljava/util/Map;)V");
			IntPtr native_extra = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (extra);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_extra);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setExtra_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_extra);
			}
		}

	}
}

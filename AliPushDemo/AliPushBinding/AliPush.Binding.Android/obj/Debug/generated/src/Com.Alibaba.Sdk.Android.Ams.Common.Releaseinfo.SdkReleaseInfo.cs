using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Releaseinfo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.releaseinfo']/class[@name='SdkReleaseInfo']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/releaseinfo/SdkReleaseInfo", DoNotGenerateAcw=true)]
	public sealed partial class SdkReleaseInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/releaseinfo/SdkReleaseInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SdkReleaseInfo); }
		}

		internal SdkReleaseInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.releaseinfo']/class[@name='SdkReleaseInfo']/constructor[@name='SdkReleaseInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;)V", "")]
		public unsafe SdkReleaseInfo (string p0, global::Java.Util.Date p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (SdkReleaseInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getSdkReleaseInfo_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.releaseinfo']/class[@name='SdkReleaseInfo']/method[@name='getSdkReleaseInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getSdkReleaseInfo", "(Ljava/lang/Class;)Lcom/alibaba/sdk/android/ams/common/releaseinfo/SdkReleaseInfo;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.Releaseinfo.SdkReleaseInfo GetSdkReleaseInfo (global::Java.Lang.Class p0)
		{
			if (id_getSdkReleaseInfo_Ljava_lang_Class_ == IntPtr.Zero)
				id_getSdkReleaseInfo_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getSdkReleaseInfo", "(Ljava/lang/Class;)Lcom/alibaba/sdk/android/ams/common/releaseinfo/SdkReleaseInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alibaba.Sdk.Android.Ams.Common.Releaseinfo.SdkReleaseInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Releaseinfo.SdkReleaseInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdkReleaseInfo_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.releaseinfo']/class[@name='SdkReleaseInfo']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

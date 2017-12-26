using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/AmsPlatform", DoNotGenerateAcw=true)]
	public sealed partial class AmsPlatform : global::Java.Lang.Enum {


		static IntPtr ALIYUN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']/field[@name='ALIYUN']"
		[Register ("ALIYUN")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform Aliyun {
			get {
				if (ALIYUN_jfieldId == IntPtr.Zero)
					ALIYUN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIYUN", "Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIYUN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BAICHUAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']/field[@name='BAICHUAN']"
		[Register ("BAICHUAN")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform Baichuan {
			get {
				if (BAICHUAN_jfieldId == IntPtr.Zero)
					BAICHUAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAICHUAN", "Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAICHUAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/AmsPlatform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsPlatform); }
		}

		internal AmsPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getPlatformCode;
		public unsafe int PlatformCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']/method[@name='getPlatformCode' and count(parameter)=0]"
			[Register ("getPlatformCode", "()I", "GetGetPlatformCodeHandler")]
			get {
				if (id_getPlatformCode == IntPtr.Zero)
					id_getPlatformCode = JNIEnv.GetMethodID (class_ref, "getPlatformCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformCode);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/ams/common/AmsPlatform;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsPlatform']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/ams/common/AmsPlatform;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform));
			} finally {
			}
		}

	}
}

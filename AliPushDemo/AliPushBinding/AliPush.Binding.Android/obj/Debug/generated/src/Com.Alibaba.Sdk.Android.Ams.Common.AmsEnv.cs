using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/AmsEnv", DoNotGenerateAcw=true)]
	public sealed partial class AmsEnv : global::Java.Lang.Enum {


		static IntPtr ONLINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/field[@name='ONLINE']"
		[Register ("ONLINE")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv Online {
			get {
				if (ONLINE_jfieldId == IntPtr.Zero)
					ONLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLINE", "Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLINE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/field[@name='PRE']"
		[Register ("PRE")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv Pre {
			get {
				if (PRE_jfieldId == IntPtr.Zero)
					PRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRE", "Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SANDBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/field[@name='SANDBOX']"
		[Register ("SANDBOX")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv Sandbox {
			get {
				if (SANDBOX_jfieldId == IntPtr.Zero)
					SANDBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SANDBOX", "Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SANDBOX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/field[@name='TEST']"
		[Register ("TEST")]
		public static global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv Test {
			get {
				if (TEST_jfieldId == IntPtr.Zero)
					TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST", "Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/AmsEnv", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsEnv); }
		}

		internal AmsEnv (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/ams/common/AmsEnv;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/class[@name='AmsEnv']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/ams/common/AmsEnv;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv));
			} finally {
			}
		}

	}
}

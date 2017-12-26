using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/SysInfoUtil", DoNotGenerateAcw=true)]
	public partial class SysInfoUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/field[@name='DEFAULT_TIMEZONE']"
		[Register ("DEFAULT_TIMEZONE")]
		public const int DefaultTimezone = (int) 8;

		static IntPtr LOG_TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/field[@name='LOG_TAG']"
		[Register ("LOG_TAG")]
		protected static string LogTag {
			get {
				if (LOG_TAG_jfieldId == IntPtr.Zero)
					LOG_TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/field[@name='UNKNOW']"
		[Register ("UNKNOW")]
		protected const string Unknow = (string) "Unknown";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/SysInfoUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SysInfoUtil); }
		}

		protected SysInfoUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/constructor[@name='SysInfoUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SysInfoUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SysInfoUtil)) {
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

		static IntPtr id_getDeviceInfo_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getDeviceInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getDeviceInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetDeviceInfo (global::Android.Content.Context p0, global::Org.Json.JSONObject p1)
		{
			if (id_getDeviceInfo_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getDeviceInfo_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceInfo_Landroid_content_Context_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLocalInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getLocalInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocalInfo", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetLocalInfo (global::Android.Content.Context p0)
		{
			if (id_getLocalInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocalInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalInfo", "(Landroid/content/Context;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLocalInfo_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getLocalInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getLocalInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetLocalInfo (global::Android.Content.Context p0, global::Org.Json.JSONObject p1)
		{
			if (id_getLocalInfo_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getLocalInfo_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalInfo_Landroid_content_Context_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNetworkAccessMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getNetworkAccessMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetNetworkAccessMode (global::Android.Content.Context p0)
		{
			if (id_getNetworkAccessMode_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkAccessMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkAccessMode_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNetworkInfo_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getNetworkInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getNetworkInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetNetworkInfo (global::Android.Content.Context p0, global::Org.Json.JSONObject p1)
		{
			if (id_getNetworkInfo_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getNetworkInfo_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkInfo", "(Landroid/content/Context;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkInfo_Landroid_content_Context_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getResolution_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getResolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getResolution", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetResolution (global::Android.Content.Context p0)
		{
			if (id_getResolution_Landroid_content_Context_ == IntPtr.Zero)
				id_getResolution_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getResolution", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResolution_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSDKInfo_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getSDKInfo' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getSDKInfo", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetSDKInfo (global::Org.Json.JSONObject p0)
		{
			if (id_getSDKInfo_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getSDKInfo_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getSDKInfo", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKInfo_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSysInfo_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getSysInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getSysInfo", "(Landroid/content/Context;Ljava/util/Map;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetSysInfo (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getSysInfo_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_getSysInfo_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getSysInfo", "(Landroid/content/Context;Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSysInfo_Landroid_content_Context_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getTimeZone_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='getTimeZone' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTimeZone", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetTimeZone (global::Android.Content.Context p0)
		{
			if (id_getTimeZone_Landroid_content_Context_ == IntPtr.Zero)
				id_getTimeZone_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeZone", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getTimeZone_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldInit_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='SysInfoUtil']/method[@name='shouldInit' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("shouldInit", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool ShouldInit (global::Android.Content.Context p0)
		{
			if (id_shouldInit_Landroid_content_Context_ == IntPtr.Zero)
				id_shouldInit_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "shouldInit", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldInit_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}

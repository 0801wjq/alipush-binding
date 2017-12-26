using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HttpConnectionUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/HttpConnectionUtil", DoNotGenerateAcw=true)]
	public partial class HttpConnectionUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/HttpConnectionUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpConnectionUtil); }
		}

		protected HttpConnectionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HttpConnectionUtil']/constructor[@name='HttpConnectionUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpConnectionUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpConnectionUtil)) {
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

		static IntPtr id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HttpConnectionUtil']/method[@name='openConnection' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("openConnection", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection OpenConnection (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2)
		{
			if (id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "openConnection", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HttpConnectionUtil']/method[@name='openConnection' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
		[Register ("openConnection", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Landroid/content/Context;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection OpenConnection (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2, global::Android.Content.Context p3)
		{
			if (id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openConnection", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Landroid/content/Context;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openConnection_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_readContent_Ljava_net_HttpURLConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HttpConnectionUtil']/method[@name='readContent' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("readContent", "(Ljava/net/HttpURLConnection;)Ljava/lang/String;", "")]
		public static unsafe string ReadContent (global::Java.Net.HttpURLConnection p0)
		{
			if (id_readContent_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
				id_readContent_Ljava_net_HttpURLConnection_ = JNIEnv.GetStaticMethodID (class_ref, "readContent", "(Ljava/net/HttpURLConnection;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readContent_Ljava_net_HttpURLConnection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

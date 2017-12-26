using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/JSONUtils", DoNotGenerateAcw=true)]
	public partial class JSONUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/JSONUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSONUtils); }
		}

		protected JSONUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/constructor[@name='JSONUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JSONUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JSONUtils)) {
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

		static IntPtr id_getBoolean_Lorg_json_JSONObject_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Lorg/json/JSONObject;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool GetBoolean (global::Org.Json.JSONObject p0, string p1, bool p2)
		{
			if (id_getBoolean_Lorg_json_JSONObject_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Lorg_json_JSONObject_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getBoolean", "(Lorg/json/JSONObject;Ljava/lang/String;Z)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getBoolean_Lorg_json_JSONObject_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)I", "")]
		public static unsafe int GetInt (global::Org.Json.JSONObject p0, string p1, int p2)
		{
			if (id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getJSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/method[@name='getJSONObject' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("getJSONObject", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetJSONObject (global::Org.Json.JSONObject p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_getJSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getJSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getJSONObject", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getString_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Org.Json.JSONObject p0, string p1, string p2)
		{
			if (id_getString_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_toMap_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='JSONUtils']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toMap", "(Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> ToMap (global::Org.Json.JSONObject p0)
		{
			if (id_toMap_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_toMap_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "toMap", "(Lorg/json/JSONObject;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMap_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyAgent", DoNotGenerateAcw=true)]
	public sealed partial class SpdyAgent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='ACCS_ONLINE_SERVER']"
		[Register ("ACCS_ONLINE_SERVER")]
		public const int AccsOnlineServer = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='ACCS_TEST_SERVER']"
		[Register ("ACCS_TEST_SERVER")]
		public const int AccsTestServer = (int) 0;

		static IntPtr enableDebug_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='enableDebug']"
		[Register ("enableDebug")]
		public static bool EnableDebug {
			get {
				if (enableDebug_jfieldId == IntPtr.Zero)
					enableDebug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableDebug", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, enableDebug_jfieldId);
			}
			set {
				if (enableDebug_jfieldId == IntPtr.Zero)
					enableDebug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableDebug", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, enableDebug_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr enableTimeGaurd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='enableTimeGaurd']"
		[Register ("enableTimeGaurd")]
		public static bool EnableTimeGaurd {
			get {
				if (enableTimeGaurd_jfieldId == IntPtr.Zero)
					enableTimeGaurd_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableTimeGaurd", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, enableTimeGaurd_jfieldId);
			}
			set {
				if (enableTimeGaurd_jfieldId == IntPtr.Zero)
					enableTimeGaurd_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableTimeGaurd", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, enableTimeGaurd_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyAgent); }
		}

		internal SpdyAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAllSession;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Android.Spdy.SpdySession> AllSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='getAllSession' and count(parameter)=0]"
			[Register ("getAllSession", "()Ljava/util/HashMap;", "GetGetAllSessionHandler")]
			get {
				if (id_getAllSession == IntPtr.Zero)
					id_getAllSession = JNIEnv.GetMethodID (class_ref, "getAllSession", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<string, global::Org.Android.Spdy.SpdySession>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllSession), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkLoadSucc;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='checkLoadSucc' and count(parameter)=0]"
		[Register ("checkLoadSucc", "()Z", "")]
		public static unsafe bool CheckLoadSucc ()
		{
			if (id_checkLoadSucc == IntPtr.Zero)
				id_checkLoadSucc = JNIEnv.GetStaticMethodID (class_ref, "checkLoadSucc", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkLoadSucc);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_configIpStackMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='configIpStackMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("configIpStackMode", "(I)I", "")]
		public static unsafe int ConfigIpStackMode (int p0)
		{
			if (id_configIpStackMode_I == IntPtr.Zero)
				id_configIpStackMode_I = JNIEnv.GetStaticMethodID (class_ref, "configIpStackMode", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_configIpStackMode_I, __args);
			} finally {
			}
		}

		static IntPtr id_configLogFile_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='configLogFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("configLogFile", "(Ljava/lang/String;II)I", "")]
		public unsafe int ConfigLogFile (string p0, int p1, int p2)
		{
			if (id_configLogFile_Ljava_lang_String_II == IntPtr.Zero)
				id_configLogFile_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "configLogFile", "(Ljava/lang/String;II)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_configLogFile_Ljava_lang_String_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_configLogFile_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='configLogFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("configLogFile", "(Ljava/lang/String;III)I", "")]
		public unsafe int ConfigLogFile (string p0, int p1, int p2, int p3)
		{
			if (id_configLogFile_Ljava_lang_String_III == IntPtr.Zero)
				id_configLogFile_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "configLogFile", "(Ljava/lang/String;III)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_configLogFile_Ljava_lang_String_III, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SessionCb'] and parameter[4][@type='int']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (string p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.ISessionCb p2, int p3)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SessionCb'] and parameter[4][@type='org.android.spdy.SslCertcb'] and parameter[5][@type='int']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;I)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (string p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.ISessionCb p2, global::Org.Android.Spdy.ISslCertcb p3, int p4)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_I == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_I = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;I)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.android.spdy.SessionCb'] and parameter[5][@type='int']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (string p0, string p1, global::Java.Lang.Object p2, global::Org.Android.Spdy.ISessionCb p3, int p4)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.android.spdy.SessionCb'] and parameter[5][@type='org.android.spdy.SslCertcb'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;II)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (string p0, string p1, global::Java.Lang.Object p2, global::Org.Android.Spdy.ISessionCb p3, global::Org.Android.Spdy.ISslCertcb p4, int p5, int p6)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_II == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_II = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;II)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.android.spdy.SessionCb'] and parameter[5][@type='org.android.spdy.SslCertcb'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;III)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (string p0, string p1, global::Java.Lang.Object p2, global::Org.Android.Spdy.ISessionCb p3, global::Org.Android.Spdy.ISslCertcb p4, int p5, int p6, int p7)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_III == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_III = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;Lorg/android/spdy/SslCertcb;III)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_Lorg_android_spdy_SslCertcb_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createSession_Lorg_android_spdy_SessionInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SessionInfo']]"
		[Register ("createSession", "(Lorg/android/spdy/SessionInfo;)Lorg/android/spdy/SpdySession;", "")]
		public unsafe global::Org.Android.Spdy.SpdySession CreateSession (global::Org.Android.Spdy.SessionInfo p0)
		{
			if (id_createSession_Lorg_android_spdy_SessionInfo_ == IntPtr.Zero)
				id_createSession_Lorg_android_spdy_SessionInfo_ = JNIEnv.GetMethodID (class_ref, "createSession", "(Lorg/android/spdy/SessionInfo;)Lorg/android/spdy/SpdySession;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSession_Lorg_android_spdy_SessionInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.spdy.SpdyVersion'] and parameter[3][@type='org.android.spdy.SpdySessionKind']]"
		[Register ("getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;)Lorg/android/spdy/SpdyAgent;", "")]
		public static unsafe global::Org.Android.Spdy.SpdyAgent GetInstance (global::Android.Content.Context p0, global::Org.Android.Spdy.SpdyVersion p1, global::Org.Android.Spdy.SpdySessionKind p2)
		{
			if (id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;)Lorg/android/spdy/SpdyAgent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Android.Spdy.SpdyAgent __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyAgent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_Lorg_android_spdy_AccsSSLCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='getInstance' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.spdy.SpdyVersion'] and parameter[3][@type='org.android.spdy.SpdySessionKind'] and parameter[4][@type='org.android.spdy.AccsSSLCallback']]"
		[Register ("getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;Lorg/android/spdy/AccsSSLCallback;)Lorg/android/spdy/SpdyAgent;", "")]
		public static unsafe global::Org.Android.Spdy.SpdyAgent GetInstance (global::Android.Content.Context p0, global::Org.Android.Spdy.SpdyVersion p1, global::Org.Android.Spdy.SpdySessionKind p2, global::Org.Android.Spdy.IAccsSSLCallback p3)
		{
			if (id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_Lorg_android_spdy_AccsSSLCallback_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_Lorg_android_spdy_AccsSSLCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;Lorg/android/spdy/AccsSSLCallback;)Lorg/android/spdy/SpdyAgent;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Android.Spdy.SpdyAgent __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyAgent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_Lorg_android_spdy_AccsSSLCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_inspect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='inspect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inspect", "(Ljava/lang/String;)V", "")]
		public static unsafe void Inspect (string p0)
		{
			if (id_inspect_Ljava_lang_String_ == IntPtr.Zero)
				id_inspect_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "inspect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inspect_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_logFileClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='logFileClose' and count(parameter)=0]"
		[Register ("logFileClose", "()V", "")]
		public unsafe void LogFileClose ()
		{
			if (id_logFileClose == IntPtr.Zero)
				id_logFileClose = JNIEnv.GetMethodID (class_ref, "logFileClose", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logFileClose);
			} finally {
			}
		}

		static IntPtr id_logFileFlush;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='logFileFlush' and count(parameter)=0]"
		[Register ("logFileFlush", "()V", "")]
		public unsafe void LogFileFlush ()
		{
			if (id_logFileFlush == IntPtr.Zero)
				id_logFileFlush = JNIEnv.GetMethodID (class_ref, "logFileFlush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logFileFlush);
			} finally {
			}
		}

		static IntPtr id_setAccsSslCallback_Lorg_android_spdy_AccsSSLCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setAccsSslCallback' and count(parameter)=1 and parameter[1][@type='org.android.spdy.AccsSSLCallback']]"
		[Register ("setAccsSslCallback", "(Lorg/android/spdy/AccsSSLCallback;)V", "")]
		public unsafe void SetAccsSslCallback (global::Org.Android.Spdy.IAccsSSLCallback p0)
		{
			if (id_setAccsSslCallback_Lorg_android_spdy_AccsSSLCallback_ == IntPtr.Zero)
				id_setAccsSslCallback_Lorg_android_spdy_AccsSSLCallback_ = JNIEnv.GetMethodID (class_ref, "setAccsSslCallback", "(Lorg/android/spdy/AccsSSLCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccsSslCallback_Lorg_android_spdy_AccsSSLCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_setConnectTimeOut_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setConnectTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnectTimeOut", "(I)I", "")]
		public unsafe int SetConnectTimeOut (int p0)
		{
			if (id_setConnectTimeOut_I == IntPtr.Zero)
				id_setConnectTimeOut_I = JNIEnv.GetMethodID (class_ref, "setConnectTimeOut", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setConnectTimeOut_I, __args);
			} finally {
			}
		}

		static IntPtr id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setProxyUsernamePassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setProxyUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetProxyUsernamePassword (string p0, string p1)
		{
			if (id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProxyUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setSessionKind_Lorg_android_spdy_SpdySessionKind_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setSessionKind' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SpdySessionKind']]"
		[Register ("setSessionKind", "(Lorg/android/spdy/SpdySessionKind;)I", "")]
		public unsafe int SetSessionKind (global::Org.Android.Spdy.SpdySessionKind p0)
		{
			if (id_setSessionKind_Lorg_android_spdy_SpdySessionKind_ == IntPtr.Zero)
				id_setSessionKind_Lorg_android_spdy_SpdySessionKind_ = JNIEnv.GetMethodID (class_ref, "setSessionKind", "(Lorg/android/spdy/SpdySessionKind;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setSessionKind_Lorg_android_spdy_SpdySessionKind_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_switchAccsServer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='switchAccsServer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("switchAccsServer", "(I)V", "")]
		public unsafe void SwitchAccsServer (int p0)
		{
			if (id_switchAccsServer_I == IntPtr.Zero)
				id_switchAccsServer_I = JNIEnv.GetMethodID (class_ref, "switchAccsServer", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchAccsServer_I, __args);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdySessionKind", DoNotGenerateAcw=true)]
	public sealed partial class SpdySessionKind : global::Java.Lang.Enum {


		static IntPtr NONE_SESSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/field[@name='NONE_SESSION']"
		[Register ("NONE_SESSION")]
		public static global::Org.Android.Spdy.SpdySessionKind NoneSession {
			get {
				if (NONE_SESSION_jfieldId == IntPtr.Zero)
					NONE_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE_SESSION", "Lorg/android/spdy/SpdySessionKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_SESSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySessionKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_G_SESSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/field[@name='THREE_G_SESSION']"
		[Register ("THREE_G_SESSION")]
		public static global::Org.Android.Spdy.SpdySessionKind ThreeGSession {
			get {
				if (THREE_G_SESSION_jfieldId == IntPtr.Zero)
					THREE_G_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_G_SESSION", "Lorg/android/spdy/SpdySessionKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_G_SESSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySessionKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_G_SESSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/field[@name='TWO_G_SESSION']"
		[Register ("TWO_G_SESSION")]
		public static global::Org.Android.Spdy.SpdySessionKind TwoGSession {
			get {
				if (TWO_G_SESSION_jfieldId == IntPtr.Zero)
					TWO_G_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_G_SESSION", "Lorg/android/spdy/SpdySessionKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_G_SESSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySessionKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WIFI_SESSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/field[@name='WIFI_SESSION']"
		[Register ("WIFI_SESSION")]
		public static global::Org.Android.Spdy.SpdySessionKind WifiSession {
			get {
				if (WIFI_SESSION_jfieldId == IntPtr.Zero)
					WIFI_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI_SESSION", "Lorg/android/spdy/SpdySessionKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_SESSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySessionKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdySessionKind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdySessionKind); }
		}

		internal SpdySessionKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdySessionKind;", "")]
		public static unsafe global::Org.Android.Spdy.SpdySessionKind ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdySessionKind;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Android.Spdy.SpdySessionKind __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySessionKind> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySessionKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/spdy/SpdySessionKind;", "")]
		public static unsafe global::Org.Android.Spdy.SpdySessionKind[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/spdy/SpdySessionKind;");
			try {
				return (global::Org.Android.Spdy.SpdySessionKind[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SpdySessionKind));
			} finally {
			}
		}

	}
}

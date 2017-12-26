using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyVersion", DoNotGenerateAcw=true)]
	public sealed partial class SpdyVersion : global::Java.Lang.Enum {


		static IntPtr SPDY2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']/field[@name='SPDY2']"
		[Register ("SPDY2")]
		public static global::Org.Android.Spdy.SpdyVersion Spdy2 {
			get {
				if (SPDY2_jfieldId == IntPtr.Zero)
					SPDY2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY2", "Lorg/android/spdy/SpdyVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']/field[@name='SPDY3']"
		[Register ("SPDY3")]
		public static global::Org.Android.Spdy.SpdyVersion Spdy3 {
			get {
				if (SPDY3_jfieldId == IntPtr.Zero)
					SPDY3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY3", "Lorg/android/spdy/SpdyVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY3DOT1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']/field[@name='SPDY3DOT1']"
		[Register ("SPDY3DOT1")]
		public static global::Org.Android.Spdy.SpdyVersion Spdy3dot1 {
			get {
				if (SPDY3DOT1_jfieldId == IntPtr.Zero)
					SPDY3DOT1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY3DOT1", "Lorg/android/spdy/SpdyVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY3DOT1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyVersion); }
		}

		internal SpdyVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdyVersion;", "")]
		public static unsafe global::Org.Android.Spdy.SpdyVersion ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SpdyVersion;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Android.Spdy.SpdyVersion __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyVersion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/spdy/SpdyVersion;", "")]
		public static unsafe global::Org.Android.Spdy.SpdyVersion[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/spdy/SpdyVersion;");
			try {
				return (global::Org.Android.Spdy.SpdyVersion[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SpdyVersion));
			} finally {
			}
		}

	}
}

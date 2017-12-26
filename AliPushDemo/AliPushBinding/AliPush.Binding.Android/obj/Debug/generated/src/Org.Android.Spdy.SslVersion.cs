using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SslVersion']"
	[global::Android.Runtime.Register ("org/android/spdy/SslVersion", DoNotGenerateAcw=true)]
	public sealed partial class SslVersion : global::Java.Lang.Enum {


		static IntPtr SLIGHT_VERSION_V1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslVersion']/field[@name='SLIGHT_VERSION_V1']"
		[Register ("SLIGHT_VERSION_V1")]
		public static global::Org.Android.Spdy.SslVersion SlightVersionV1 {
			get {
				if (SLIGHT_VERSION_V1_jfieldId == IntPtr.Zero)
					SLIGHT_VERSION_V1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SLIGHT_VERSION_V1", "Lorg/android/spdy/SslVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SLIGHT_VERSION_V1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SslVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SslVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SslVersion); }
		}

		internal SslVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SslVersion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SslVersion;", "")]
		public static unsafe global::Org.Android.Spdy.SslVersion ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/spdy/SslVersion;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Android.Spdy.SslVersion __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SslVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SslVersion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/spdy/SslVersion;", "")]
		public static unsafe global::Org.Android.Spdy.SslVersion[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/spdy/SslVersion;");
			try {
				return (global::Org.Android.Spdy.SslVersion[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SslVersion));
			} finally {
			}
		}

	}
}

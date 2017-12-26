using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']"
	[global::Android.Runtime.Register ("org/android/spdy/RequestPriority", DoNotGenerateAcw=true)]
	public sealed partial class RequestPriority : global::Java.Lang.Enum {


		static IntPtr DEFAULT_PRIORITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='DEFAULT_PRIORITY']"
		[Register ("DEFAULT_PRIORITY")]
		public static global::Org.Android.Spdy.RequestPriority DefaultPriority {
			get {
				if (DEFAULT_PRIORITY_jfieldId == IntPtr.Zero)
					DEFAULT_PRIORITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_PRIORITY", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_PRIORITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HIGH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='HIGH']"
		[Register ("HIGH")]
		public static global::Org.Android.Spdy.RequestPriority High {
			get {
				if (HIGH_jfieldId == IntPtr.Zero)
					HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGH", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HIGHEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='HIGHEST']"
		[Register ("HIGHEST")]
		public static global::Org.Android.Spdy.RequestPriority Highest {
			get {
				if (HIGHEST_jfieldId == IntPtr.Zero)
					HIGHEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGHEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IDLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='IDLE']"
		[Register ("IDLE")]
		public static global::Org.Android.Spdy.RequestPriority Idle {
			get {
				if (IDLE_jfieldId == IntPtr.Zero)
					IDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDLE", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='LOW']"
		[Register ("LOW")]
		public static global::Org.Android.Spdy.RequestPriority Low {
			get {
				if (LOW_jfieldId == IntPtr.Zero)
					LOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOWEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='LOWEST']"
		[Register ("LOWEST")]
		public static global::Org.Android.Spdy.RequestPriority Lowest {
			get {
				if (LOWEST_jfieldId == IntPtr.Zero)
					LOWEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MEDIUM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		public static global::Org.Android.Spdy.RequestPriority Medium {
			get {
				if (MEDIUM_jfieldId == IntPtr.Zero)
					MEDIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIUM", "Lorg/android/spdy/RequestPriority;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEDIUM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/RequestPriority", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestPriority); }
		}

		internal RequestPriority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/spdy/RequestPriority;", "")]
		public static unsafe global::Org.Android.Spdy.RequestPriority ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/spdy/RequestPriority;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Android.Spdy.RequestPriority __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.RequestPriority> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='RequestPriority']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/spdy/RequestPriority;", "")]
		public static unsafe global::Org.Android.Spdy.RequestPriority[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/spdy/RequestPriority;");
			try {
				return (global::Org.Android.Spdy.RequestPriority[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.RequestPriority));
			} finally {
			}
		}

	}
}

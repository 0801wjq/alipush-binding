using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyBytePool']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyBytePool", DoNotGenerateAcw=true)]
	public partial class SpdyBytePool : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyBytePool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyBytePool); }
		}

		protected SpdyBytePool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Org.Android.Spdy.SpdyBytePool Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyBytePool']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/android/spdy/SpdyBytePool;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/android/spdy/SpdyBytePool;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyBytePool> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

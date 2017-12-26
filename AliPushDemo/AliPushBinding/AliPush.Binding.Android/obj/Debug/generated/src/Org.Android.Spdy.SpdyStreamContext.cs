using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyStreamContext", DoNotGenerateAcw=true)]
	public partial class SpdyStreamContext : global::Java.Lang.Object {


		static IntPtr streamContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']/field[@name='streamContext']"
		[Register ("streamContext")]
		public global::Java.Lang.Object StreamContext {
			get {
				if (streamContext_jfieldId == IntPtr.Zero)
					streamContext_jfieldId = JNIEnv.GetFieldID (class_ref, "streamContext", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, streamContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (streamContext_jfieldId == IntPtr.Zero)
					streamContext_jfieldId = JNIEnv.GetFieldID (class_ref, "streamContext", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, streamContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr streamId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']/field[@name='streamId']"
		[Register ("streamId")]
		public int StreamId {
			get {
				if (streamId_jfieldId == IntPtr.Zero)
					streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId);
			}
			set {
				if (streamId_jfieldId == IntPtr.Zero)
					streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyStreamContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyStreamContext); }
		}

		protected SpdyStreamContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

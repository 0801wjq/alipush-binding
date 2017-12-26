using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SSLMeta']"
	[global::Android.Runtime.Register ("org/android/spdy/SSLMeta", DoNotGenerateAcw=true)]
	public partial class SSLMeta : global::Java.Lang.Object {


		static IntPtr sslMeta_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SSLMeta']/field[@name='sslMeta']"
		[Register ("sslMeta")]
		public IList<byte> SslMeta {
			get {
				if (sslMeta_jfieldId == IntPtr.Zero)
					sslMeta_jfieldId = JNIEnv.GetFieldID (class_ref, "sslMeta", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sslMeta_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sslMeta_jfieldId == IntPtr.Zero)
					sslMeta_jfieldId = JNIEnv.GetFieldID (class_ref, "sslMeta", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sslMeta_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sslMetaLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SSLMeta']/field[@name='sslMetaLength']"
		[Register ("sslMetaLength")]
		public int SslMetaLength {
			get {
				if (sslMetaLength_jfieldId == IntPtr.Zero)
					sslMetaLength_jfieldId = JNIEnv.GetFieldID (class_ref, "sslMetaLength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sslMetaLength_jfieldId);
			}
			set {
				if (sslMetaLength_jfieldId == IntPtr.Zero)
					sslMetaLength_jfieldId = JNIEnv.GetFieldID (class_ref, "sslMetaLength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sslMetaLength_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SSLMeta", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLMeta); }
		}

		protected SSLMeta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SSLMeta']/constructor[@name='SSLMeta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SSLMeta ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SSLMeta)) {
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

	}
}

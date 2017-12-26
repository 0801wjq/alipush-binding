using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']"
	[global::Android.Runtime.Register ("org/android/spdy/SslPublickey", DoNotGenerateAcw=true)]
	public partial class SslPublickey : global::Java.Lang.Object {


		static IntPtr error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='error']"
		[Register ("error")]
		public int Error {
			get {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, error_jfieldId);
			}
			set {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, error_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr exponent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='exponent']"
		[Register ("exponent")]
		public IList<byte> Exponent {
			get {
				if (exponent_jfieldId == IntPtr.Zero)
					exponent_jfieldId = JNIEnv.GetFieldID (class_ref, "exponent", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, exponent_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (exponent_jfieldId == IntPtr.Zero)
					exponent_jfieldId = JNIEnv.GetFieldID (class_ref, "exponent", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, exponent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr module_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='module']"
		[Register ("module")]
		public IList<byte> Module {
			get {
				if (module_jfieldId == IntPtr.Zero)
					module_jfieldId = JNIEnv.GetFieldID (class_ref, "module", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, module_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (module_jfieldId == IntPtr.Zero)
					module_jfieldId = JNIEnv.GetFieldID (class_ref, "module", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, module_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr seqnum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/field[@name='seqnum']"
		[Register ("seqnum")]
		public int Seqnum {
			get {
				if (seqnum_jfieldId == IntPtr.Zero)
					seqnum_jfieldId = JNIEnv.GetFieldID (class_ref, "seqnum", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, seqnum_jfieldId);
			}
			set {
				if (seqnum_jfieldId == IntPtr.Zero)
					seqnum_jfieldId = JNIEnv.GetFieldID (class_ref, "seqnum", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, seqnum_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SslPublickey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SslPublickey); }
		}

		protected SslPublickey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPublickey']/constructor[@name='SslPublickey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SslPublickey ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SslPublickey)) {
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

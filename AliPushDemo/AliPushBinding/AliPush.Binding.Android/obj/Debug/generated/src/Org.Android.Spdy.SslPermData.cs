using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']"
	[global::Android.Runtime.Register ("org/android/spdy/SslPermData", DoNotGenerateAcw=true)]
	public partial class SslPermData : global::Java.Lang.Object {


		static IntPtr genrequest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/field[@name='genrequest']"
		[Register ("genrequest")]
		public int Genrequest {
			get {
				if (genrequest_jfieldId == IntPtr.Zero)
					genrequest_jfieldId = JNIEnv.GetFieldID (class_ref, "genrequest", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, genrequest_jfieldId);
			}
			set {
				if (genrequest_jfieldId == IntPtr.Zero)
					genrequest_jfieldId = JNIEnv.GetFieldID (class_ref, "genrequest", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, genrequest_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr invalidkey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/field[@name='invalidkey']"
		[Register ("invalidkey")]
		public int Invalidkey {
			get {
				if (invalidkey_jfieldId == IntPtr.Zero)
					invalidkey_jfieldId = JNIEnv.GetFieldID (class_ref, "invalidkey", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, invalidkey_jfieldId);
			}
			set {
				if (invalidkey_jfieldId == IntPtr.Zero)
					invalidkey_jfieldId = JNIEnv.GetFieldID (class_ref, "invalidkey", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, invalidkey_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr keyrequest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/field[@name='keyrequest']"
		[Register ("keyrequest")]
		public int Keyrequest {
			get {
				if (keyrequest_jfieldId == IntPtr.Zero)
					keyrequest_jfieldId = JNIEnv.GetFieldID (class_ref, "keyrequest", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, keyrequest_jfieldId);
			}
			set {
				if (keyrequest_jfieldId == IntPtr.Zero)
					keyrequest_jfieldId = JNIEnv.GetFieldID (class_ref, "keyrequest", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, keyrequest_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr requestnum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/field[@name='requestnum']"
		[Register ("requestnum")]
		public int Requestnum {
			get {
				if (requestnum_jfieldId == IntPtr.Zero)
					requestnum_jfieldId = JNIEnv.GetFieldID (class_ref, "requestnum", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, requestnum_jfieldId);
			}
			set {
				if (requestnum_jfieldId == IntPtr.Zero)
					requestnum_jfieldId = JNIEnv.GetFieldID (class_ref, "requestnum", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestnum_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr requesttime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/field[@name='requesttime']"
		[Register ("requesttime")]
		public int Requesttime {
			get {
				if (requesttime_jfieldId == IntPtr.Zero)
					requesttime_jfieldId = JNIEnv.GetFieldID (class_ref, "requesttime", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, requesttime_jfieldId);
			}
			set {
				if (requesttime_jfieldId == IntPtr.Zero)
					requesttime_jfieldId = JNIEnv.GetFieldID (class_ref, "requesttime", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requesttime_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SslPermData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SslPermData); }
		}

		protected SslPermData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SslPermData']/constructor[@name='SslPermData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SslPermData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SslPermData)) {
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

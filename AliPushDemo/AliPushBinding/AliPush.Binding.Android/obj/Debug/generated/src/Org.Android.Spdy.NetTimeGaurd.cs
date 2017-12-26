using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']"
	[global::Android.Runtime.Register ("org/android/spdy/NetTimeGaurd", DoNotGenerateAcw=true)]
	public partial class NetTimeGaurd : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']/field[@name='CREATE']"
		[Register ("CREATE")]
		public const int Create = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']/field[@name='PING']"
		[Register ("PING")]
		public const int Ping = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']/field[@name='STREAM']"
		[Register ("STREAM")]
		public const int Stream = (int) 3;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/NetTimeGaurd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetTimeGaurd); }
		}

		protected NetTimeGaurd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='NetTimeGaurd']/constructor[@name='NetTimeGaurd' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetTimeGaurd ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NetTimeGaurd)) {
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

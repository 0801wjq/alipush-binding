using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTFields']"
	[global::Android.Runtime.Register ("com/ut/mini/UTFields", DoNotGenerateAcw=true)]
	public partial class UTFields : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTFields']/field[@name='OS']"
		[Register ("OS")]
		public const string Os = (string) "_field_os";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTFields']/field[@name='OS_VERSION']"
		[Register ("OS_VERSION")]
		public const string OsVersion = (string) "_field_os_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTFields']/field[@name='TRACK_ID']"
		[Register ("TRACK_ID")]
		public const string TrackId = (string) "_track_id";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTFields", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTFields); }
		}

		protected UTFields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTFields']/constructor[@name='UTFields' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTFields ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTFields)) {
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

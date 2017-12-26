using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTInterfaceCallDelegate']"
	[global::Android.Runtime.Register ("com/ut/mini/UTInterfaceCallDelegate", DoNotGenerateAcw=true)]
	public partial class UTInterfaceCallDelegate : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTInterfaceCallDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTInterfaceCallDelegate); }
		}

		protected UTInterfaceCallDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTInterfaceCallDelegate']/constructor[@name='UTInterfaceCallDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTInterfaceCallDelegate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTInterfaceCallDelegate)) {
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

		static IntPtr id_pageAppearByAuto_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTInterfaceCallDelegate']/method[@name='pageAppearByAuto' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("pageAppearByAuto", "(Landroid/app/Activity;)V", "")]
		public static unsafe void PageAppearByAuto (global::Android.App.Activity aActivity)
		{
			if (id_pageAppearByAuto_Landroid_app_Activity_ == IntPtr.Zero)
				id_pageAppearByAuto_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "pageAppearByAuto", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aActivity);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pageAppearByAuto_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_pageDisAppearByAuto_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTInterfaceCallDelegate']/method[@name='pageDisAppearByAuto' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("pageDisAppearByAuto", "(Landroid/app/Activity;)V", "")]
		public static unsafe void PageDisAppearByAuto (global::Android.App.Activity aActivity)
		{
			if (id_pageDisAppearByAuto_Landroid_app_Activity_ == IntPtr.Zero)
				id_pageDisAppearByAuto_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "pageDisAppearByAuto", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aActivity);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pageDisAppearByAuto_Landroid_app_Activity_, __args);
			} finally {
			}
		}

	}
}

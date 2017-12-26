using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Core.Appstatus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']"
	[global::Android.Runtime.Register ("com/ut/mini/core/appstatus/UTMCAppStatusRegHelper", DoNotGenerateAcw=true)]
	public partial class UTMCAppStatusRegHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/core/appstatus/UTMCAppStatusRegHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTMCAppStatusRegHelper); }
		}

		protected UTMCAppStatusRegHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']/constructor[@name='UTMCAppStatusRegHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTMCAppStatusRegHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTMCAppStatusRegHelper)) {
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

		static IntPtr id_registeActivityLifecycleCallbacks_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']/method[@name='registeActivityLifecycleCallbacks' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("registeActivityLifecycleCallbacks", "(Landroid/app/Application;)V", "")]
		public static unsafe void RegisteActivityLifecycleCallbacks (global::Android.App.Application aApplicationInstance)
		{
			if (id_registeActivityLifecycleCallbacks_Landroid_app_Application_ == IntPtr.Zero)
				id_registeActivityLifecycleCallbacks_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "registeActivityLifecycleCallbacks", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aApplicationInstance);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registeActivityLifecycleCallbacks_Landroid_app_Application_, __args);
			} finally {
			}
		}

		static IntPtr id_registerAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']/method[@name='registerAppStatusCallbacks' and count(parameter)=1 and parameter[1][@type='com.ut.mini.core.appstatus.UTMCAppStatusCallbacks']]"
		[Register ("registerAppStatusCallbacks", "(Lcom/ut/mini/core/appstatus/UTMCAppStatusCallbacks;)V", "")]
		public static unsafe void RegisterAppStatusCallbacks (global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks aCallbacks)
		{
			if (id_registerAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_ == IntPtr.Zero)
				id_registerAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "registerAppStatusCallbacks", "(Lcom/ut/mini/core/appstatus/UTMCAppStatusCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aCallbacks);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_unRegisterAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']/method[@name='unRegisterAppStatusCallbacks' and count(parameter)=1 and parameter[1][@type='com.ut.mini.core.appstatus.UTMCAppStatusCallbacks']]"
		[Register ("unRegisterAppStatusCallbacks", "(Lcom/ut/mini/core/appstatus/UTMCAppStatusCallbacks;)V", "")]
		public static unsafe void UnRegisterAppStatusCallbacks (global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks aCallbacks)
		{
			if (id_unRegisterAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_ == IntPtr.Zero)
				id_unRegisterAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "unRegisterAppStatusCallbacks", "(Lcom/ut/mini/core/appstatus/UTMCAppStatusCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aCallbacks);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unRegisterAppStatusCallbacks_Lcom_ut_mini_core_appstatus_UTMCAppStatusCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterActivityLifecycleCallbacks_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppStatusRegHelper']/method[@name='unregisterActivityLifecycleCallbacks' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("unregisterActivityLifecycleCallbacks", "(Landroid/app/Application;)V", "")]
		public static unsafe void UnregisterActivityLifecycleCallbacks (global::Android.App.Application aApplicationInstance)
		{
			if (id_unregisterActivityLifecycleCallbacks_Landroid_app_Application_ == IntPtr.Zero)
				id_unregisterActivityLifecycleCallbacks_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterActivityLifecycleCallbacks", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aApplicationInstance);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterActivityLifecycleCallbacks_Landroid_app_Application_, __args);
			} finally {
			}
		}

	}
}

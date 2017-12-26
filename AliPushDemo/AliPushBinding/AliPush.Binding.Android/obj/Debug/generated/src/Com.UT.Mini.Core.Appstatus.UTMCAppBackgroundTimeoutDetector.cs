using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Core.Appstatus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']"
	[global::Android.Runtime.Register ("com/ut/mini/core/appstatus/UTMCAppBackgroundTimeoutDetector", DoNotGenerateAcw=true)]
	public partial class UTMCAppBackgroundTimeoutDetector : global::Java.Lang.Object, global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/core/appstatus/UTMCAppBackgroundTimeoutDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTMCAppBackgroundTimeoutDetector); }
		}

		protected UTMCAppBackgroundTimeoutDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/core/appstatus/UTMCAppBackgroundTimeoutDetector;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/core/appstatus/UTMCAppBackgroundTimeoutDetector;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (activity, savedInstanceState);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivityCreated (global::Android.App.Activity activity, global::Android.OS.Bundle savedInstanceState)
		{
			if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (savedInstanceState);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity activity)
		{
			if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityDestroyed_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPaused (global::Android.App.Activity activity)
		{
			if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityPaused_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityPaused", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityResumed (global::Android.App.Activity activity)
		{
			if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResumed_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResumed", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle outState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_outState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (activity, outState);
		}
#pragma warning restore 0169

		static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity activity, global::Android.OS.Bundle outState)
		{
			if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (outState);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStarted (global::Android.App.Activity activity)
		{
			if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStarted_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStopped (global::Android.App.Activity activity)
		{
			if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStopped_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSwitchBackground;
#pragma warning disable 0169
		static Delegate GetOnSwitchBackgroundHandler ()
		{
			if (cb_onSwitchBackground == null)
				cb_onSwitchBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSwitchBackground);
			return cb_onSwitchBackground;
		}

		static void n_OnSwitchBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onSwitchBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onSwitchBackground' and count(parameter)=0]"
		[Register ("onSwitchBackground", "()V", "GetOnSwitchBackgroundHandler")]
		public virtual unsafe void OnSwitchBackground ()
		{
			if (id_onSwitchBackground == IntPtr.Zero)
				id_onSwitchBackground = JNIEnv.GetMethodID (class_ref, "onSwitchBackground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSwitchBackground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSwitchBackground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSwitchForeground;
#pragma warning disable 0169
		static Delegate GetOnSwitchForegroundHandler ()
		{
			if (cb_onSwitchForeground == null)
				cb_onSwitchForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSwitchForeground);
			return cb_onSwitchForeground;
		}

		static void n_OnSwitchForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.UTMCAppBackgroundTimeoutDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onSwitchForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/class[@name='UTMCAppBackgroundTimeoutDetector']/method[@name='onSwitchForeground' and count(parameter)=0]"
		[Register ("onSwitchForeground", "()V", "GetOnSwitchForegroundHandler")]
		public virtual unsafe void OnSwitchForeground ()
		{
			if (id_onSwitchForeground == IntPtr.Zero)
				id_onSwitchForeground = JNIEnv.GetMethodID (class_ref, "onSwitchForeground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSwitchForeground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSwitchForeground", "()V"));
			} finally {
			}
		}

	}
}

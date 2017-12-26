using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Core.Appstatus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']"
	[Register ("com/ut/mini/core/appstatus/UTMCAppStatusCallbacks", "", "Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker")]
	public partial interface IUTMCAppStatusCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityDestroyed (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityPaused (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityResumed (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityStarted (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnActivityStopped (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onSwitchBackground' and count(parameter)=0]"
		[Register ("onSwitchBackground", "()V", "GetOnSwitchBackgroundHandler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnSwitchBackground ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.appstatus']/interface[@name='UTMCAppStatusCallbacks']/method[@name='onSwitchForeground' and count(parameter)=0]"
		[Register ("onSwitchForeground", "()V", "GetOnSwitchForegroundHandler:Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacksInvoker, AliPush.Binding.Android")]
		void OnSwitchForeground ();

	}

	[global::Android.Runtime.Register ("com/ut/mini/core/appstatus/UTMCAppStatusCallbacks", DoNotGenerateAcw=true)]
	internal class IUTMCAppStatusCallbacksInvoker : global::Java.Lang.Object, IUTMCAppStatusCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/mini/core/appstatus/UTMCAppStatusCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTMCAppStatusCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IUTMCAppStatusCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTMCAppStatusCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.mini.core.appstatus.UTMCAppStatusCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTMCAppStatusCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		public unsafe void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		public unsafe void OnActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityDestroyed_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActivityPaused_Landroid_app_Activity_;
		public unsafe void OnActivityPaused (global::Android.App.Activity p0)
		{
			if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityPaused_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActivityResumed_Landroid_app_Activity_;
		public unsafe void OnActivityResumed (global::Android.App.Activity p0)
		{
			if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResumed_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		public unsafe void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActivityStarted_Landroid_app_Activity_;
		public unsafe void OnActivityStarted (global::Android.App.Activity p0)
		{
			if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStarted_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActivityStopped_Landroid_app_Activity_;
		public unsafe void OnActivityStopped (global::Android.App.Activity p0)
		{
			if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStopped_Landroid_app_Activity_, __args);
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
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchBackground ();
		}
#pragma warning restore 0169

		IntPtr id_onSwitchBackground;
		public unsafe void OnSwitchBackground ()
		{
			if (id_onSwitchBackground == IntPtr.Zero)
				id_onSwitchBackground = JNIEnv.GetMethodID (class_ref, "onSwitchBackground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSwitchBackground);
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
			global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchForeground ();
		}
#pragma warning restore 0169

		IntPtr id_onSwitchForeground;
		public unsafe void OnSwitchForeground ()
		{
			if (id_onSwitchForeground == IntPtr.Zero)
				id_onSwitchForeground = JNIEnv.GetMethodID (class_ref, "onSwitchForeground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSwitchForeground);
		}

	}

}

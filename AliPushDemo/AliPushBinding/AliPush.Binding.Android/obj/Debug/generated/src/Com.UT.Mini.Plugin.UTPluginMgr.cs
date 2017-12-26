using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']"
	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPluginMgr", DoNotGenerateAcw=true)]
	public partial class UTPluginMgr : global::Java.Lang.Object, global::Com.UT.Mini.Core.Appstatus.IUTMCAppStatusCallbacks {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/field[@name='PARTNERPLUGIN_UTPREF']"
		[Register ("PARTNERPLUGIN_UTPREF")]
		public const string PartnerpluginUtpref = (string) "com.ut.mini.perf.UTPerfPlugin";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/plugin/UTPluginMgr", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPluginMgr); }
		}

		protected UTPluginMgr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.Plugin.UTPluginMgr Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/plugin/UTPluginMgr;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/plugin/UTPluginMgr;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dispatchPluginMsg_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDispatchPluginMsg_ILjava_lang_Object_Handler ()
		{
			if (cb_dispatchPluginMsg_ILjava_lang_Object_ == null)
				cb_dispatchPluginMsg_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_DispatchPluginMsg_ILjava_lang_Object_);
			return cb_dispatchPluginMsg_ILjava_lang_Object_;
		}

		static bool n_DispatchPluginMsg_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int aMsgId, IntPtr native_aMsgObj)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aMsgObj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aMsgObj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchPluginMsg (aMsgId, aMsgObj);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPluginMsg_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='dispatchPluginMsg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("dispatchPluginMsg", "(ILjava/lang/Object;)Z", "GetDispatchPluginMsg_ILjava_lang_Object_Handler")]
		public virtual unsafe bool DispatchPluginMsg (int aMsgId, global::Java.Lang.Object aMsgObj)
		{
			if (id_dispatchPluginMsg_ILjava_lang_Object_ == IntPtr.Zero)
				id_dispatchPluginMsg_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "dispatchPluginMsg", "(ILjava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aMsgId);
				__args [1] = new JValue (aMsgObj);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchPluginMsg_ILjava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchPluginMsg", "(ILjava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isPartnerPluginExist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsPartnerPluginExist_Ljava_lang_String_Handler ()
		{
			if (cb_isPartnerPluginExist_Ljava_lang_String_ == null)
				cb_isPartnerPluginExist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPartnerPluginExist_Ljava_lang_String_);
			return cb_isPartnerPluginExist_Ljava_lang_String_;
		}

		static bool n_IsPartnerPluginExist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPluginClassPath)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aPluginClassPath = JNIEnv.GetString (native_aPluginClassPath, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPartnerPluginExist (aPluginClassPath);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isPartnerPluginExist_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='isPartnerPluginExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPartnerPluginExist", "(Ljava/lang/String;)Z", "GetIsPartnerPluginExist_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsPartnerPluginExist (string aPluginClassPath)
		{
			if (id_isPartnerPluginExist_Ljava_lang_String_ == IntPtr.Zero)
				id_isPartnerPluginExist_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isPartnerPluginExist", "(Ljava/lang/String;)Z");
			IntPtr native_aPluginClassPath = JNIEnv.NewString (aPluginClassPath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aPluginClassPath);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPartnerPluginExist_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPartnerPluginExist", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aPluginClassPath);
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (activity, savedInstanceState);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle outState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_outState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (activity, outState);
		}
#pragma warning restore 0169

		static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (activity);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onSwitchBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onSwitchBackground' and count(parameter)=0]"
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
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSwitchForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onSwitchForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='onSwitchForeground' and count(parameter)=0]"
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

		static Delegate cb_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z;
#pragma warning disable 0169
		static Delegate GetRegisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ZHandler ()
		{
			if (cb_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z == null)
				cb_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RegisterPlugin_Lcom_ut_mini_plugin_UTPlugin_Z);
			return cb_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z;
		}

		static void n_RegisterPlugin_Lcom_ut_mini_plugin_UTPlugin_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_aPlugin, bool aAsyncMode)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Plugin.UTPlugin aPlugin = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (native_aPlugin, JniHandleOwnership.DoNotTransfer);
			__this.RegisterPlugin (aPlugin, aAsyncMode);
		}
#pragma warning restore 0169

		static IntPtr id_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='registerPlugin' and count(parameter)=2 and parameter[1][@type='com.ut.mini.plugin.UTPlugin'] and parameter[2][@type='boolean']]"
		[Register ("registerPlugin", "(Lcom/ut/mini/plugin/UTPlugin;Z)V", "GetRegisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ZHandler")]
		public virtual unsafe void RegisterPlugin (global::Com.UT.Mini.Plugin.UTPlugin aPlugin, bool aAsyncMode)
		{
			if (id_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z == IntPtr.Zero)
				id_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z = JNIEnv.GetMethodID (class_ref, "registerPlugin", "(Lcom/ut/mini/plugin/UTPlugin;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPlugin);
				__args [1] = new JValue (aAsyncMode);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerPlugin_Lcom_ut_mini_plugin_UTPlugin_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerPlugin", "(Lcom/ut/mini/plugin/UTPlugin;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runPartnerPlugin;
#pragma warning disable 0169
		static Delegate GetRunPartnerPluginHandler ()
		{
			if (cb_runPartnerPlugin == null)
				cb_runPartnerPlugin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunPartnerPlugin);
			return cb_runPartnerPlugin;
		}

		static void n_RunPartnerPlugin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunPartnerPlugin ();
		}
#pragma warning restore 0169

		static IntPtr id_runPartnerPlugin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='runPartnerPlugin' and count(parameter)=0]"
		[Register ("runPartnerPlugin", "()V", "GetRunPartnerPluginHandler")]
		public virtual unsafe void RunPartnerPlugin ()
		{
			if (id_runPartnerPlugin == IntPtr.Zero)
				id_runPartnerPlugin = JNIEnv.GetMethodID (class_ref, "runPartnerPlugin", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runPartnerPlugin);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runPartnerPlugin", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_;
#pragma warning disable 0169
		static Delegate GetUnregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_Handler ()
		{
			if (cb_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ == null)
				cb_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_);
			return cb_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_;
		}

		static void n_UnregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPlugin)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Plugin.UTPlugin aPlugin = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (native_aPlugin, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterPlugin (aPlugin);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='unregisterPlugin' and count(parameter)=1 and parameter[1][@type='com.ut.mini.plugin.UTPlugin']]"
		[Register ("unregisterPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)V", "GetUnregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_Handler")]
		public virtual unsafe void UnregisterPlugin (global::Com.UT.Mini.Plugin.UTPlugin aPlugin)
		{
			if (id_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ == IntPtr.Zero)
				id_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_ = JNIEnv.GetMethodID (class_ref, "unregisterPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPlugin);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterPlugin_Lcom_ut_mini_plugin_UTPlugin_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updatePluginContextValue_I;
#pragma warning disable 0169
		static Delegate GetUpdatePluginContextValue_IHandler ()
		{
			if (cb_updatePluginContextValue_I == null)
				cb_updatePluginContextValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdatePluginContextValue_I);
			return cb_updatePluginContextValue_I;
		}

		static void n_UpdatePluginContextValue_I (IntPtr jnienv, IntPtr native__this, int aPluginContextKey)
		{
			global::Com.UT.Mini.Plugin.UTPluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePluginContextValue (aPluginContextKey);
		}
#pragma warning restore 0169

		static IntPtr id_updatePluginContextValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMgr']/method[@name='updatePluginContextValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updatePluginContextValue", "(I)V", "GetUpdatePluginContextValue_IHandler")]
		public virtual unsafe void UpdatePluginContextValue (int aPluginContextKey)
		{
			if (id_updatePluginContextValue_I == IntPtr.Zero)
				id_updatePluginContextValue_I = JNIEnv.GetMethodID (class_ref, "updatePluginContextValue", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPluginContextKey);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePluginContextValue_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePluginContextValue", "(I)V"), __args);
			} finally {
			}
		}

	}
}

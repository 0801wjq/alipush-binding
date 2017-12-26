using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']"
	[global::Android.Runtime.Register ("com/ut/mini/UTAnalytics", DoNotGenerateAcw=true)]
	public partial class UTAnalytics : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTAnalytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTAnalytics); }
		}

		protected UTAnalytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDefaultTracker;
#pragma warning disable 0169
		static Delegate GetGetDefaultTrackerHandler ()
		{
			if (cb_getDefaultTracker == null)
				cb_getDefaultTracker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultTracker);
			return cb_getDefaultTracker;
		}

		static IntPtr n_GetDefaultTracker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultTracker);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultTracker;
		public virtual unsafe global::Com.UT.Mini.UTTracker DefaultTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='getDefaultTracker' and count(parameter)=0]"
			[Register ("getDefaultTracker", "()Lcom/ut/mini/UTTracker;", "GetGetDefaultTrackerHandler")]
			get {
				if (id_getDefaultTracker == IntPtr.Zero)
					id_getDefaultTracker = JNIEnv.GetMethodID (class_ref, "getDefaultTracker", "()Lcom/ut/mini/UTTracker;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultTracker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultTracker", "()Lcom/ut/mini/UTTracker;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.UTAnalytics Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/UTAnalytics;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/UTAnalytics;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTracker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTracker_Ljava_lang_String_Handler ()
		{
			if (cb_getTracker_Ljava_lang_String_ == null)
				cb_getTracker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTracker_Ljava_lang_String_);
			return cb_getTracker_Ljava_lang_String_;
		}

		static IntPtr n_GetTracker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTrackId)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aTrackId = JNIEnv.GetString (native_aTrackId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTracker (aTrackId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTracker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='getTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTracker", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;", "GetGetTracker_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.UT.Mini.UTTracker GetTracker (string aTrackId)
		{
			if (id_getTracker_Ljava_lang_String_ == IntPtr.Zero)
				id_getTracker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTracker", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;");
			IntPtr native_aTrackId = JNIEnv.NewString (aTrackId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aTrackId);

				global::Com.UT.Mini.UTTracker __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTracker_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTracker", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aTrackId);
			}
		}

		static Delegate cb_getTrackerByAppkey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrackerByAppkey_Ljava_lang_String_Handler ()
		{
			if (cb_getTrackerByAppkey_Ljava_lang_String_ == null)
				cb_getTrackerByAppkey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrackerByAppkey_Ljava_lang_String_);
			return cb_getTrackerByAppkey_Ljava_lang_String_;
		}

		static IntPtr n_GetTrackerByAppkey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appkey)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string appkey = JNIEnv.GetString (native_appkey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrackerByAppkey (appkey));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackerByAppkey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='getTrackerByAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrackerByAppkey", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;", "GetGetTrackerByAppkey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.UT.Mini.UTTracker GetTrackerByAppkey (string appkey)
		{
			if (id_getTrackerByAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrackerByAppkey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrackerByAppkey", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;");
			IntPtr native_appkey = JNIEnv.NewString (appkey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appkey);

				global::Com.UT.Mini.UTTracker __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackerByAppkey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackerByAppkey", "(Ljava/lang/String;)Lcom/ut/mini/UTTracker;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_appkey);
			}
		}

		static Delegate cb_setAppApplicationInstance_Landroid_app_Application_;
#pragma warning disable 0169
		static Delegate GetSetAppApplicationInstance_Landroid_app_Application_Handler ()
		{
			if (cb_setAppApplicationInstance_Landroid_app_Application_ == null)
				cb_setAppApplicationInstance_Landroid_app_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppApplicationInstance_Landroid_app_Application_);
			return cb_setAppApplicationInstance_Landroid_app_Application_;
		}

		static void n_SetAppApplicationInstance_Landroid_app_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aApplicationInstance)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application aApplicationInstance = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_aApplicationInstance, JniHandleOwnership.DoNotTransfer);
			__this.SetAppApplicationInstance (aApplicationInstance);
		}
#pragma warning restore 0169

		static IntPtr id_setAppApplicationInstance_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setAppApplicationInstance' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Obsolete (@"deprecated")]
		[Register ("setAppApplicationInstance", "(Landroid/app/Application;)V", "GetSetAppApplicationInstance_Landroid_app_Application_Handler")]
		public virtual unsafe void SetAppApplicationInstance (global::Android.App.Application aApplicationInstance)
		{
			if (id_setAppApplicationInstance_Landroid_app_Application_ == IntPtr.Zero)
				id_setAppApplicationInstance_Landroid_app_Application_ = JNIEnv.GetMethodID (class_ref, "setAppApplicationInstance", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aApplicationInstance);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppApplicationInstance_Landroid_app_Application_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppApplicationInstance", "(Landroid/app/Application;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
#pragma warning disable 0169
		static Delegate GetSetAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_Handler ()
		{
			if (cb_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ == null)
				cb_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_);
			return cb_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
		}

		static void n_SetAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application, IntPtr native_utCallback)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application application = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_application, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.IUTApplication utCallback = (global::Com.UT.Mini.IUTApplication)global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (native_utCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetAppApplicationInstance (application, utCallback);
		}
#pragma warning restore 0169

		static IntPtr id_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setAppApplicationInstance' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.ut.mini.IUTApplication']]"
		[Register ("setAppApplicationInstance", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V", "GetSetAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_Handler")]
		public virtual unsafe void SetAppApplicationInstance (global::Android.App.Application application, global::Com.UT.Mini.IUTApplication utCallback)
		{
			if (id_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ == IntPtr.Zero)
				id_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ = JNIEnv.GetMethodID (class_ref, "setAppApplicationInstance", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (application);
				__args [1] = new JValue (utCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppApplicationInstance_Landroid_app_Application_Lcom_ut_mini_IUTApplication_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppApplicationInstance", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
#pragma warning disable 0169
		static Delegate GetSetAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_Handler ()
		{
			if (cb_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ == null)
				cb_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_);
			return cb_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
		}

		static void n_SetAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application, IntPtr native_utCallback)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application application = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_application, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.IUTApplication utCallback = (global::Com.UT.Mini.IUTApplication)global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (native_utCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetAppApplicationInstance4sdk (application, utCallback);
		}
#pragma warning restore 0169

		static IntPtr id_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setAppApplicationInstance4sdk' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.ut.mini.IUTApplication']]"
		[Register ("setAppApplicationInstance4sdk", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V", "GetSetAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_Handler")]
		public virtual unsafe void SetAppApplicationInstance4sdk (global::Android.App.Application application, global::Com.UT.Mini.IUTApplication utCallback)
		{
			if (id_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ == IntPtr.Zero)
				id_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_ = JNIEnv.GetMethodID (class_ref, "setAppApplicationInstance4sdk", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (application);
				__args [1] = new JValue (utCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppApplicationInstance4sdk_Landroid_app_Application_Lcom_ut_mini_IUTApplication_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppApplicationInstance4sdk", "(Landroid/app/Application;Lcom/ut/mini/IUTApplication;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAppVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setAppVersion_Ljava_lang_String_ == null)
				cb_setAppVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppVersion_Ljava_lang_String_);
			return cb_setAppVersion_Ljava_lang_String_;
		}

		static void n_SetAppVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aAppVersion)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aAppVersion = JNIEnv.GetString (native_aAppVersion, JniHandleOwnership.DoNotTransfer);
			__this.SetAppVersion (aAppVersion);
		}
#pragma warning restore 0169

		static IntPtr id_setAppVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setAppVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setAppVersion", "(Ljava/lang/String;)V", "GetSetAppVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppVersion (string aAppVersion)
		{
			if (id_setAppVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppVersion", "(Ljava/lang/String;)V");
			IntPtr native_aAppVersion = JNIEnv.NewString (aAppVersion);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aAppVersion);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aAppVersion);
			}
		}

		static Delegate cb_setChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setChannel_Ljava_lang_String_ == null)
				cb_setChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_lang_String_);
			return cb_setChannel_Ljava_lang_String_;
		}

		static void n_SetChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aChannel)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aChannel = JNIEnv.GetString (native_aChannel, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (aChannel);
		}
#pragma warning restore 0169

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler")]
		public virtual unsafe void SetChannel (string aChannel)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_aChannel = JNIEnv.NewString (aChannel);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aChannel);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannel_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannel", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aChannel);
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aContext)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context aContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_aContext, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (aContext);
		}
#pragma warning restore 0169

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context aContext)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aContext);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_;
#pragma warning disable 0169
		static Delegate GetSetRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_Handler ()
		{
			if (cb_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_ == null)
				cb_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_);
			return cb_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_;
		}

		static void n_SetRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aRequestAuthenticationInstance)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication aRequestAuthenticationInstance = (global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication)global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication> (native_aRequestAuthenticationInstance, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestAuthentication (aRequestAuthenticationInstance);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='setRequestAuthentication' and count(parameter)=1 and parameter[1][@type='com.ut.mini.core.sign.IUTRequestAuthentication']]"
		[Obsolete (@"deprecated")]
		[Register ("setRequestAuthentication", "(Lcom/ut/mini/core/sign/IUTRequestAuthentication;)V", "GetSetRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_Handler")]
		public virtual unsafe void SetRequestAuthentication (global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication aRequestAuthenticationInstance)
		{
			if (id_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_ == IntPtr.Zero)
				id_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_ = JNIEnv.GetMethodID (class_ref, "setRequestAuthentication", "(Lcom/ut/mini/core/sign/IUTRequestAuthentication;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aRequestAuthenticationInstance);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestAuthentication_Lcom_ut_mini_core_sign_IUTRequestAuthentication_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestAuthentication", "(Lcom/ut/mini/core/sign/IUTRequestAuthentication;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_turnOffAutoPageTrack;
#pragma warning disable 0169
		static Delegate GetTurnOffAutoPageTrackHandler ()
		{
			if (cb_turnOffAutoPageTrack == null)
				cb_turnOffAutoPageTrack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOffAutoPageTrack);
			return cb_turnOffAutoPageTrack;
		}

		static void n_TurnOffAutoPageTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffAutoPageTrack ();
		}
#pragma warning restore 0169

		static IntPtr id_turnOffAutoPageTrack;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='turnOffAutoPageTrack' and count(parameter)=0]"
		[Register ("turnOffAutoPageTrack", "()V", "GetTurnOffAutoPageTrackHandler")]
		public virtual unsafe void TurnOffAutoPageTrack ()
		{
			if (id_turnOffAutoPageTrack == IntPtr.Zero)
				id_turnOffAutoPageTrack = JNIEnv.GetMethodID (class_ref, "turnOffAutoPageTrack", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffAutoPageTrack);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOffAutoPageTrack", "()V"));
			} finally {
			}
		}

		static Delegate cb_turnOnDebug;
#pragma warning disable 0169
		static Delegate GetTurnOnDebugHandler ()
		{
			if (cb_turnOnDebug == null)
				cb_turnOnDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOnDebug);
			return cb_turnOnDebug;
		}

		static void n_TurnOnDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_turnOnDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='turnOnDebug' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("turnOnDebug", "()V", "GetTurnOnDebugHandler")]
		public virtual unsafe void TurnOnDebug ()
		{
			if (id_turnOnDebug == IntPtr.Zero)
				id_turnOnDebug = JNIEnv.GetMethodID (class_ref, "turnOnDebug", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOnDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateSessionProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdateSessionProperties_Ljava_util_Map_Handler ()
		{
			if (cb_updateSessionProperties_Ljava_util_Map_ == null)
				cb_updateSessionProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSessionProperties_Ljava_util_Map_);
			return cb_updateSessionProperties_Ljava_util_Map_;
		}

		static void n_UpdateSessionProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aMap)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aMap, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSessionProperties (aMap);
		}
#pragma warning restore 0169

		static IntPtr id_updateSessionProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='updateSessionProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateSessionProperties", "(Ljava/util/Map;)V", "GetUpdateSessionProperties_Ljava_util_Map_Handler")]
		public virtual unsafe void UpdateSessionProperties (global::System.Collections.Generic.IDictionary<string, string> aMap)
		{
			if (id_updateSessionProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_updateSessionProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updateSessionProperties", "(Ljava/util/Map;)V");
			IntPtr native_aMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aMap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSessionProperties_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSessionProperties", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aMap);
			}
		}

		static Delegate cb_updateUserAccount_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateUserAccount_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateUserAccount_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateUserAccount_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateUserAccount_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateUserAccount_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateUserAccount_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aUsernick, IntPtr native_aUserid)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aUsernick = JNIEnv.GetString (native_aUsernick, JniHandleOwnership.DoNotTransfer);
			string aUserid = JNIEnv.GetString (native_aUserid, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserAccount (aUsernick, aUserid);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserAccount_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='updateUserAccount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateUserAccount", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateUserAccount_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateUserAccount (string aUsernick, string aUserid)
		{
			if (id_updateUserAccount_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateUserAccount_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateUserAccount", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_aUsernick = JNIEnv.NewString (aUsernick);
			IntPtr native_aUserid = JNIEnv.NewString (aUserid);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aUsernick);
				__args [1] = new JValue (native_aUserid);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserAccount_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserAccount", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aUsernick);
				JNIEnv.DeleteLocalRef (native_aUserid);
			}
		}

		static Delegate cb_userRegister_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUserRegister_Ljava_lang_String_Handler ()
		{
			if (cb_userRegister_Ljava_lang_String_ == null)
				cb_userRegister_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UserRegister_Ljava_lang_String_);
			return cb_userRegister_Ljava_lang_String_;
		}

		static void n_UserRegister_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aUsernick)
		{
			global::Com.UT.Mini.UTAnalytics __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTAnalytics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aUsernick = JNIEnv.GetString (native_aUsernick, JniHandleOwnership.DoNotTransfer);
			__this.UserRegister (aUsernick);
		}
#pragma warning restore 0169

		static IntPtr id_userRegister_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTAnalytics']/method[@name='userRegister' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userRegister", "(Ljava/lang/String;)V", "GetUserRegister_Ljava_lang_String_Handler")]
		public virtual unsafe void UserRegister (string aUsernick)
		{
			if (id_userRegister_Ljava_lang_String_ == IntPtr.Zero)
				id_userRegister_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "userRegister", "(Ljava/lang/String;)V");
			IntPtr native_aUsernick = JNIEnv.NewString (aUsernick);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aUsernick);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_userRegister_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userRegister", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aUsernick);
			}
		}

	}
}

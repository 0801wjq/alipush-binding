using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']"
	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPluginContext", DoNotGenerateAcw=true)]
	public partial class UTPluginContext : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/field[@name='DEBUG_LOG_SWITCH']"
		[Register ("DEBUG_LOG_SWITCH")]
		public const int DebugLogSwitch = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/plugin/UTPluginContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPluginContext); }
		}

		protected UTPluginContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/constructor[@name='UTPluginContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTPluginContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTPluginContext)) {
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

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

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
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context aContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_aContext, JniHandleOwnership.DoNotTransfer);
			__this.Context = aContext;
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		static IntPtr id_setContext_Landroid_content_Context_;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
					id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDebugLogEnable;
#pragma warning disable 0169
		static Delegate GetIsDebugLogEnableHandler ()
		{
			if (cb_isDebugLogEnable == null)
				cb_isDebugLogEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugLogEnable);
			return cb_isDebugLogEnable;
		}

		static bool n_IsDebugLogEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugLogEnable;
		}
#pragma warning restore 0169

		static IntPtr id_isDebugLogEnable;
		public virtual unsafe bool IsDebugLogEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='isDebugLogEnable' and count(parameter)=0]"
			[Register ("isDebugLogEnable", "()Z", "GetIsDebugLogEnableHandler")]
			get {
				if (id_isDebugLogEnable == IntPtr.Zero)
					id_isDebugLogEnable = JNIEnv.GetMethodID (class_ref, "isDebugLogEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDebugLogEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDebugLogEnable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRealtimeDebugEnable;
#pragma warning disable 0169
		static Delegate GetIsRealtimeDebugEnableHandler ()
		{
			if (cb_isRealtimeDebugEnable == null)
				cb_isRealtimeDebugEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRealtimeDebugEnable);
			return cb_isRealtimeDebugEnable;
		}

		static bool n_IsRealtimeDebugEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRealtimeDebugEnable;
		}
#pragma warning restore 0169

		static IntPtr id_isRealtimeDebugEnable;
		public virtual unsafe bool IsRealtimeDebugEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='isRealtimeDebugEnable' and count(parameter)=0]"
			[Register ("isRealtimeDebugEnable", "()Z", "GetIsRealtimeDebugEnableHandler")]
			get {
				if (id_isRealtimeDebugEnable == IntPtr.Zero)
					id_isRealtimeDebugEnable = JNIEnv.GetMethodID (class_ref, "isRealtimeDebugEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRealtimeDebugEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRealtimeDebugEnable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_enableRealtimeDebug;
#pragma warning disable 0169
		static Delegate GetEnableRealtimeDebugHandler ()
		{
			if (cb_enableRealtimeDebug == null)
				cb_enableRealtimeDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableRealtimeDebug);
			return cb_enableRealtimeDebug;
		}

		static void n_EnableRealtimeDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableRealtimeDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_enableRealtimeDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='enableRealtimeDebug' and count(parameter)=0]"
		[Register ("enableRealtimeDebug", "()V", "GetEnableRealtimeDebugHandler")]
		public virtual unsafe void EnableRealtimeDebug ()
		{
			if (id_enableRealtimeDebug == IntPtr.Zero)
				id_enableRealtimeDebug = JNIEnv.GetMethodID (class_ref, "enableRealtimeDebug", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableRealtimeDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableRealtimeDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDebugLogFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugLogFlag_ZHandler ()
		{
			if (cb_setDebugLogFlag_Z == null)
				cb_setDebugLogFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugLogFlag_Z);
			return cb_setDebugLogFlag_Z;
		}

		static void n_SetDebugLogFlag_Z (IntPtr jnienv, IntPtr native__this, bool aDebugLogFlag)
		{
			global::Com.UT.Mini.Plugin.UTPluginContext __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLogFlag (aDebugLogFlag);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugLogFlag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginContext']/method[@name='setDebugLogFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugLogFlag", "(Z)V", "GetSetDebugLogFlag_ZHandler")]
		public virtual unsafe void SetDebugLogFlag (bool aDebugLogFlag)
		{
			if (id_setDebugLogFlag_Z == IntPtr.Zero)
				id_setDebugLogFlag_Z = JNIEnv.GetMethodID (class_ref, "setDebugLogFlag", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aDebugLogFlag);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebugLogFlag_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugLogFlag", "(Z)V"), __args);
			} finally {
			}
		}

	}
}

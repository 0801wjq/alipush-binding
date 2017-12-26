using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']"
	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPlugin", DoNotGenerateAcw=true)]
	public abstract partial class UTPlugin : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_IN_DISPATCH_AGGREGATION_LOG_MAP']"
		[Register ("MSG_ID_IN_DISPATCH_AGGREGATION_LOG_MAP")]
		public const int MsgIdInDispatchAggregationLogMap = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_IN_DISPATCH_LOG_STRING_4_UTPERF_PLUGIN']"
		[Register ("MSG_ID_IN_DISPATCH_LOG_STRING_4_UTPERF_PLUGIN")]
		public const int MsgIdInDispatchLogString4UtperfPlugin = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_IN_NOMATCH_ONLINE_CONF']"
		[Register ("MSG_ID_IN_NOMATCH_ONLINE_CONF")]
		public const int MsgIdInNomatchOnlineConf = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_IN_SWITCH_BACKGROUND']"
		[Register ("MSG_ID_IN_SWITCH_BACKGROUND")]
		public const int MsgIdInSwitchBackground = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_IN_SWITCH_FOREGROUND']"
		[Register ("MSG_ID_IN_SWITCH_FOREGROUND")]
		public const int MsgIdInSwitchForeground = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/field[@name='MSG_ID_OUT_AGGREGATED_LOG_MAP']"
		[Register ("MSG_ID_OUT_AGGREGATED_LOG_MAP")]
		public const int MsgIdOutAggregatedLogMap = (int) 65536;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/plugin/UTPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPlugin); }
		}

		protected UTPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/constructor[@name='UTPlugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTPlugin ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTPlugin)) {
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

		static IntPtr id_getPluginContext;
		public unsafe global::Com.UT.Mini.Plugin.UTPluginContext PluginContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='getPluginContext' and count(parameter)=0]"
			[Register ("getPluginContext", "()Lcom/ut/mini/plugin/UTPluginContext;", "GetGetPluginContextHandler")]
			get {
				if (id_getPluginContext == IntPtr.Zero)
					id_getPluginContext = JNIEnv.GetMethodID (class_ref, "getPluginContext", "()Lcom/ut/mini/plugin/UTPluginContext;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPluginContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_deliverMsgToSDK_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='deliverMsgToSDK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("deliverMsgToSDK", "(ILjava/lang/Object;)V", "")]
		public unsafe void DeliverMsgToSDK (int aOutPluginMsgId, global::Java.Lang.Object aMsgObject)
		{
			if (id_deliverMsgToSDK_ILjava_lang_Object_ == IntPtr.Zero)
				id_deliverMsgToSDK_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "deliverMsgToSDK", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aOutPluginMsgId);
				__args [1] = new JValue (aMsgObject);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliverMsgToSDK_ILjava_lang_Object_, __args);
			} finally {
			}
		}

		static Delegate cb_onPluginContextValueUpdate_I;
#pragma warning disable 0169
		static Delegate GetOnPluginContextValueUpdate_IHandler ()
		{
			if (cb_onPluginContextValueUpdate_I == null)
				cb_onPluginContextValueUpdate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPluginContextValueUpdate_I);
			return cb_onPluginContextValueUpdate_I;
		}

		static void n_OnPluginContextValueUpdate_I (IntPtr jnienv, IntPtr native__this, int aPluginContextKey)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPluginContextValueUpdate (aPluginContextKey);
		}
#pragma warning restore 0169

		static IntPtr id_onPluginContextValueUpdate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='onPluginContextValueUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPluginContextValueUpdate", "(I)V", "GetOnPluginContextValueUpdate_IHandler")]
		public virtual unsafe void OnPluginContextValueUpdate (int aPluginContextKey)
		{
			if (id_onPluginContextValueUpdate_I == IntPtr.Zero)
				id_onPluginContextValueUpdate_I = JNIEnv.GetMethodID (class_ref, "onPluginContextValueUpdate", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPluginContextKey);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPluginContextValueUpdate_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPluginContextValueUpdate", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPluginMsgArrivedFromSDK_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnPluginMsgArrivedFromSDK_ILjava_lang_Object_Handler ()
		{
			if (cb_onPluginMsgArrivedFromSDK_ILjava_lang_Object_ == null)
				cb_onPluginMsgArrivedFromSDK_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnPluginMsgArrivedFromSDK_ILjava_lang_Object_);
			return cb_onPluginMsgArrivedFromSDK_ILjava_lang_Object_;
		}

		static void n_OnPluginMsgArrivedFromSDK_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPluginMsgArrivedFromSDK (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='onPluginMsgArrivedFromSDK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onPluginMsgArrivedFromSDK", "(ILjava/lang/Object;)V", "GetOnPluginMsgArrivedFromSDK_ILjava_lang_Object_Handler")]
		public abstract void OnPluginMsgArrivedFromSDK (int p0, global::Java.Lang.Object p1);

		static Delegate cb_onRegistered;
#pragma warning disable 0169
		static Delegate GetOnRegisteredHandler ()
		{
			if (cb_onRegistered == null)
				cb_onRegistered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRegistered);
			return cb_onRegistered;
		}

		static void n_OnRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRegistered ();
		}
#pragma warning restore 0169

		static IntPtr id_onRegistered;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='onRegistered' and count(parameter)=0]"
		[Register ("onRegistered", "()V", "GetOnRegisteredHandler")]
		public virtual unsafe void OnRegistered ()
		{
			if (id_onRegistered == IntPtr.Zero)
				id_onRegistered = JNIEnv.GetMethodID (class_ref, "onRegistered", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRegistered);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRegistered", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUnRegistered;
#pragma warning disable 0169
		static Delegate GetOnUnRegisteredHandler ()
		{
			if (cb_onUnRegistered == null)
				cb_onUnRegistered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnRegistered);
			return cb_onUnRegistered;
		}

		static void n_OnUnRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnRegistered ();
		}
#pragma warning restore 0169

		static IntPtr id_onUnRegistered;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='onUnRegistered' and count(parameter)=0]"
		[Register ("onUnRegistered", "()V", "GetOnUnRegisteredHandler")]
		public virtual unsafe void OnUnRegistered ()
		{
			if (id_onUnRegistered == IntPtr.Zero)
				id_onUnRegistered = JNIEnv.GetMethodID (class_ref, "onUnRegistered", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnRegistered);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnRegistered", "()V"));
			} finally {
			}
		}

		static Delegate cb_returnRequiredMsgIds;
#pragma warning disable 0169
		static Delegate GetReturnRequiredMsgIdsHandler ()
		{
			if (cb_returnRequiredMsgIds == null)
				cb_returnRequiredMsgIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReturnRequiredMsgIds);
			return cb_returnRequiredMsgIds;
		}

		static IntPtr n_ReturnRequiredMsgIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReturnRequiredMsgIds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='returnRequiredMsgIds' and count(parameter)=0]"
		[Register ("returnRequiredMsgIds", "()[I", "GetReturnRequiredMsgIdsHandler")]
		public abstract int[] ReturnRequiredMsgIds ();

		static Delegate cb_returnRequiredOnlineConfNames;
#pragma warning disable 0169
		static Delegate GetReturnRequiredOnlineConfNamesHandler ()
		{
			if (cb_returnRequiredOnlineConfNames == null)
				cb_returnRequiredOnlineConfNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReturnRequiredOnlineConfNames);
			return cb_returnRequiredOnlineConfNames;
		}

		static IntPtr n_ReturnRequiredOnlineConfNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Plugin.UTPlugin __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReturnRequiredOnlineConfNames ());
		}
#pragma warning restore 0169

		static IntPtr id_returnRequiredOnlineConfNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='returnRequiredOnlineConfNames' and count(parameter)=0]"
		[Register ("returnRequiredOnlineConfNames", "()[Ljava/lang/String;", "GetReturnRequiredOnlineConfNamesHandler")]
		public virtual unsafe string[] ReturnRequiredOnlineConfNames ()
		{
			if (id_returnRequiredOnlineConfNames == IntPtr.Zero)
				id_returnRequiredOnlineConfNames = JNIEnv.GetMethodID (class_ref, "returnRequiredOnlineConfNames", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_returnRequiredOnlineConfNames), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "returnRequiredOnlineConfNames", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPlugin", DoNotGenerateAcw=true)]
	internal partial class UTPluginInvoker : UTPlugin {

		public UTPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPluginInvoker); }
		}

		static IntPtr id_onPluginMsgArrivedFromSDK_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='onPluginMsgArrivedFromSDK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onPluginMsgArrivedFromSDK", "(ILjava/lang/Object;)V", "GetOnPluginMsgArrivedFromSDK_ILjava_lang_Object_Handler")]
		public override unsafe void OnPluginMsgArrivedFromSDK (int p0, global::Java.Lang.Object p1)
		{
			if (id_onPluginMsgArrivedFromSDK_ILjava_lang_Object_ == IntPtr.Zero)
				id_onPluginMsgArrivedFromSDK_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onPluginMsgArrivedFromSDK", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPluginMsgArrivedFromSDK_ILjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_returnRequiredMsgIds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPlugin']/method[@name='returnRequiredMsgIds' and count(parameter)=0]"
		[Register ("returnRequiredMsgIds", "()[I", "GetReturnRequiredMsgIdsHandler")]
		public override unsafe int[] ReturnRequiredMsgIds ()
		{
			if (id_returnRequiredMsgIds == IntPtr.Zero)
				id_returnRequiredMsgIds = JNIEnv.GetMethodID (class_ref, "returnRequiredMsgIds", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_returnRequiredMsgIds), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}

}

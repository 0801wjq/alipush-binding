using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMsgDispatchDelegate']"
	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPluginMsgDispatchDelegate", DoNotGenerateAcw=true)]
	public abstract partial class UTPluginMsgDispatchDelegate : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/plugin/UTPluginMsgDispatchDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPluginMsgDispatchDelegate); }
		}

		protected UTPluginMsgDispatchDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMsgDispatchDelegate']/constructor[@name='UTPluginMsgDispatchDelegate' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe UTPluginMsgDispatchDelegate (global::Java.Lang.Object aMsgObject)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aMsgObject);
				if (((object) this).GetType () != typeof (UTPluginMsgDispatchDelegate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_getMsgObj;
		public unsafe global::Java.Lang.Object MsgObj {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMsgDispatchDelegate']/method[@name='getMsgObj' and count(parameter)=0]"
			[Register ("getMsgObj", "()Ljava/lang/Object;", "GetGetMsgObjHandler")]
			get {
				if (id_getMsgObj == IntPtr.Zero)
					id_getMsgObj = JNIEnv.GetMethodID (class_ref, "getMsgObj", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsgObj), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_;
#pragma warning disable 0169
		static Delegate GetGetDispatchObject_Lcom_ut_mini_plugin_UTPlugin_Handler ()
		{
			if (cb_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_ == null)
				cb_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDispatchObject_Lcom_ut_mini_plugin_UTPlugin_);
			return cb_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_;
		}

		static IntPtr n_GetDispatchObject_Lcom_ut_mini_plugin_UTPlugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lPlugin)
		{
			global::Com.UT.Mini.Plugin.UTPluginMsgDispatchDelegate __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMsgDispatchDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Plugin.UTPlugin lPlugin = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (native_lPlugin, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDispatchObject (lPlugin));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMsgDispatchDelegate']/method[@name='getDispatchObject' and count(parameter)=1 and parameter[1][@type='com.ut.mini.plugin.UTPlugin']]"
		[Register ("getDispatchObject", "(Lcom/ut/mini/plugin/UTPlugin;)Ljava/lang/Object;", "GetGetDispatchObject_Lcom_ut_mini_plugin_UTPlugin_Handler")]
		public virtual unsafe global::Java.Lang.Object GetDispatchObject (global::Com.UT.Mini.Plugin.UTPlugin lPlugin)
		{
			if (id_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_ == IntPtr.Zero)
				id_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_ = JNIEnv.GetMethodID (class_ref, "getDispatchObject", "(Lcom/ut/mini/plugin/UTPlugin;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lPlugin);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDispatchObject_Lcom_ut_mini_plugin_UTPlugin_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDispatchObject", "(Lcom/ut/mini/plugin/UTPlugin;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_;
#pragma warning disable 0169
		static Delegate GetIsMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_Handler ()
		{
			if (cb_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_ == null)
				cb_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_);
			return cb_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_;
		}

		static bool n_IsMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lPlugin)
		{
			global::Com.UT.Mini.Plugin.UTPluginMsgDispatchDelegate __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginMsgDispatchDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Plugin.UTPlugin lPlugin = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPlugin> (native_lPlugin, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMatchPlugin (lPlugin);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTPluginMsgDispatchDelegate']/method[@name='isMatchPlugin' and count(parameter)=1 and parameter[1][@type='com.ut.mini.plugin.UTPlugin']]"
		[Register ("isMatchPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)Z", "GetIsMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_Handler")]
		public virtual unsafe bool IsMatchPlugin (global::Com.UT.Mini.Plugin.UTPlugin lPlugin)
		{
			if (id_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_ == IntPtr.Zero)
				id_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_ = JNIEnv.GetMethodID (class_ref, "isMatchPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lPlugin);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMatchPlugin_Lcom_ut_mini_plugin_UTPlugin_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMatchPlugin", "(Lcom/ut/mini/plugin/UTPlugin;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPluginMsgDispatchDelegate", DoNotGenerateAcw=true)]
	internal partial class UTPluginMsgDispatchDelegateInvoker : UTPluginMsgDispatchDelegate {

		public UTPluginMsgDispatchDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPluginMsgDispatchDelegateInvoker); }
		}

	}

}

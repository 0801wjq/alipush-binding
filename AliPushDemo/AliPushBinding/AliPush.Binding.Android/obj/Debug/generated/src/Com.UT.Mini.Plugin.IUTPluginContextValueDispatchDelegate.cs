using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.mini.plugin']/interface[@name='UTPluginContextValueDispatchDelegate']"
	[Register ("com/ut/mini/plugin/UTPluginContextValueDispatchDelegate", "", "Com.UT.Mini.Plugin.IUTPluginContextValueDispatchDelegateInvoker")]
	public partial interface IUTPluginContextValueDispatchDelegate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.plugin']/interface[@name='UTPluginContextValueDispatchDelegate']/method[@name='onPluginContextValueChange' and count(parameter)=1 and parameter[1][@type='com.ut.mini.plugin.UTPluginContext']]"
		[Register ("onPluginContextValueChange", "(Lcom/ut/mini/plugin/UTPluginContext;)V", "GetOnPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_Handler:Com.UT.Mini.Plugin.IUTPluginContextValueDispatchDelegateInvoker, AliPush.Binding.Android")]
		void OnPluginContextValueChange (global::Com.UT.Mini.Plugin.UTPluginContext p0);

	}

	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTPluginContextValueDispatchDelegate", DoNotGenerateAcw=true)]
	internal class IUTPluginContextValueDispatchDelegateInvoker : global::Java.Lang.Object, IUTPluginContextValueDispatchDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/mini/plugin/UTPluginContextValueDispatchDelegate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTPluginContextValueDispatchDelegateInvoker); }
		}

		IntPtr class_ref;

		public static IUTPluginContextValueDispatchDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTPluginContextValueDispatchDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.mini.plugin.UTPluginContextValueDispatchDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTPluginContextValueDispatchDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_;
#pragma warning disable 0169
		static Delegate GetOnPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_Handler ()
		{
			if (cb_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_ == null)
				cb_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_);
			return cb_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_;
		}

		static void n_OnPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.Plugin.IUTPluginContextValueDispatchDelegate __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.IUTPluginContextValueDispatchDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Plugin.UTPluginContext p0 = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Plugin.UTPluginContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPluginContextValueChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_;
		public unsafe void OnPluginContextValueChange (global::Com.UT.Mini.Plugin.UTPluginContext p0)
		{
			if (id_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_ == IntPtr.Zero)
				id_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_ = JNIEnv.GetMethodID (class_ref, "onPluginContextValueChange", "(Lcom/ut/mini/plugin/UTPluginContext;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPluginContextValueChange_Lcom_ut_mini_plugin_UTPluginContext_, __args);
		}

	}

}

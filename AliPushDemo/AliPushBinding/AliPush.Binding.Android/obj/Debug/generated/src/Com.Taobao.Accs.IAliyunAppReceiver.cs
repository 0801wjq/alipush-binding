using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAliyunAppReceiver']"
	[Register ("com/taobao/accs/IAliyunAppReceiver", "", "Com.Taobao.Accs.IAliyunAppReceiverInvoker")]
	public partial interface IAliyunAppReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAliyunAppReceiver']/method[@name='onBindApp' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.ErrorCode.INIT_ERROR']]"
		[Register ("onBindApp", "(Lcom/taobao/accs/ErrorCode$INIT_ERROR;)V", "GetOnBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_Handler:Com.Taobao.Accs.IAliyunAppReceiverInvoker, AliPush.Binding.Android")]
		void OnBindApp (global::Com.Taobao.Accs.ErrorCode.INIT_ERROR p0);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IAliyunAppReceiver", DoNotGenerateAcw=true)]
	internal class IAliyunAppReceiverInvoker : global::Java.Lang.Object, IAliyunAppReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/IAliyunAppReceiver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAliyunAppReceiverInvoker); }
		}

		IntPtr class_ref;

		public static IAliyunAppReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAliyunAppReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.IAliyunAppReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAliyunAppReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_;
#pragma warning disable 0169
		static Delegate GetOnBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_Handler ()
		{
			if (cb_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_ == null)
				cb_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_);
			return cb_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_;
		}

		static void n_OnBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.IAliyunAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAliyunAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ErrorCode.INIT_ERROR p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ErrorCode.INIT_ERROR> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_;
		public unsafe void OnBindApp (global::Com.Taobao.Accs.ErrorCode.INIT_ERROR p0)
		{
			if (id_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_ == IntPtr.Zero)
				id_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_ = JNIEnv.GetMethodID (class_ref, "onBindApp", "(Lcom/taobao/accs/ErrorCode$INIT_ERROR;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindApp_Lcom_taobao_accs_ErrorCode_INIT_ERROR_, __args);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Securitybox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='ISecurityBoxServiceFactory']"
	[Register ("com/alibaba/sdk/android/ams/common/securitybox/ISecurityBoxServiceFactory", "", "Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceFactoryInvoker")]
	public partial interface ISecurityBoxServiceFactory : IJavaObject {

		global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService SecurityBoxService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='ISecurityBoxServiceFactory']/method[@name='getSecurityBoxService' and count(parameter)=0]"
			[Register ("getSecurityBoxService", "()Lcom/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService;", "GetGetSecurityBoxServiceHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceFactoryInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/securitybox/ISecurityBoxServiceFactory", DoNotGenerateAcw=true)]
	internal class ISecurityBoxServiceFactoryInvoker : global::Java.Lang.Object, ISecurityBoxServiceFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/securitybox/ISecurityBoxServiceFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISecurityBoxServiceFactoryInvoker); }
		}

		IntPtr class_ref;

		public static ISecurityBoxServiceFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISecurityBoxServiceFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.ams.common.securitybox.ISecurityBoxServiceFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISecurityBoxServiceFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSecurityBoxService;
#pragma warning disable 0169
		static Delegate GetGetSecurityBoxServiceHandler ()
		{
			if (cb_getSecurityBoxService == null)
				cb_getSecurityBoxService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityBoxService);
			return cb_getSecurityBoxService;
		}

		static IntPtr n_GetSecurityBoxService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceFactory __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SecurityBoxService);
		}
#pragma warning restore 0169

		IntPtr id_getSecurityBoxService;
		public unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService SecurityBoxService {
			get {
				if (id_getSecurityBoxService == IntPtr.Zero)
					id_getSecurityBoxService = JNIEnv.GetMethodID (class_ref, "getSecurityBoxService", "()Lcom/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService;");
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityBoxService), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

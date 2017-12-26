using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Securitybox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/class[@name='SecurityBoxServiceFactory']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxServiceFactory", DoNotGenerateAcw=true)]
	public partial class SecurityBoxServiceFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxServiceFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecurityBoxServiceFactory); }
		}

		protected SecurityBoxServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/class[@name='SecurityBoxServiceFactory']/constructor[@name='SecurityBoxServiceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecurityBoxServiceFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SecurityBoxServiceFactory)) {
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

		static IntPtr id_getSecurityBoxService;
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService SecurityBoxService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/class[@name='SecurityBoxServiceFactory']/method[@name='getSecurityBoxService' and count(parameter)=0]"
			[Register ("getSecurityBoxService", "()Lcom/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService;", "GetGetSecurityBoxServiceHandler")]
			get {
				if (id_getSecurityBoxService == IntPtr.Zero)
					id_getSecurityBoxService = JNIEnv.GetStaticMethodID (class_ref, "getSecurityBoxService", "()Lcom/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSecurityBoxService), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

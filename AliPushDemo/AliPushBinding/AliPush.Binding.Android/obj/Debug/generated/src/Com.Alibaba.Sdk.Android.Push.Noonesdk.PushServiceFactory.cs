using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Noonesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.noonesdk']/class[@name='PushServiceFactory']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/noonesdk/PushServiceFactory", DoNotGenerateAcw=true)]
	public partial class PushServiceFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/noonesdk/PushServiceFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushServiceFactory); }
		}

		protected PushServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.noonesdk']/class[@name='PushServiceFactory']/constructor[@name='PushServiceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushServiceFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushServiceFactory)) {
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

		static IntPtr id_getCloudPushService;
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.ICloudPushService CloudPushService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.noonesdk']/class[@name='PushServiceFactory']/method[@name='getCloudPushService' and count(parameter)=0]"
			[Register ("getCloudPushService", "()Lcom/alibaba/sdk/android/push/CloudPushService;", "GetGetCloudPushServiceHandler")]
			get {
				if (id_getCloudPushService == IntPtr.Zero)
					id_getCloudPushService = JNIEnv.GetStaticMethodID (class_ref, "getCloudPushService", "()Lcom/alibaba/sdk/android/push/CloudPushService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCloudPushService), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.noonesdk']/class[@name='PushServiceFactory']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}

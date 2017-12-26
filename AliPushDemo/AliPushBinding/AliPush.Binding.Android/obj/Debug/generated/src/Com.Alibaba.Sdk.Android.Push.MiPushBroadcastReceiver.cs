using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MiPushBroadcastReceiver']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/MiPushBroadcastReceiver", DoNotGenerateAcw=true)]
	public partial class MiPushBroadcastReceiver : global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MiPushBroadcastReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:MiPushRegister";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/MiPushBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiPushBroadcastReceiver); }
		}

		protected MiPushBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MiPushBroadcastReceiver']/constructor[@name='MiPushBroadcastReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiPushBroadcastReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MiPushBroadcastReceiver)) {
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

	}
}

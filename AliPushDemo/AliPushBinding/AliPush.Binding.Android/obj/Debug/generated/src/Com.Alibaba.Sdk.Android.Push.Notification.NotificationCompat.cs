using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='NotificationCompat']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/notification/NotificationCompat", DoNotGenerateAcw=true)]
	public sealed partial class NotificationCompat : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/notification/NotificationCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationCompat); }
		}

		internal NotificationCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

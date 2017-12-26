using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CustomNotificationBuilder']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/notification/CustomNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class CustomNotificationBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/notification/CustomNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomNotificationBuilder); }
		}

		protected CustomNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Notification.CustomNotificationBuilder Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CustomNotificationBuilder']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/alibaba/sdk/android/push/notification/CustomNotificationBuilder;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/alibaba/sdk/android/push/notification/CustomNotificationBuilder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CustomNotificationBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CustomNotificationBuilder']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/alibaba/sdk/android/push/notification/BasicCustomPushNotification;", "")]
		public unsafe global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)Lcom/alibaba/sdk/android/push/notification/BasicCustomPushNotification;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_;
#pragma warning disable 0169
		static Delegate GetSetCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_Handler ()
		{
			if (cb_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_ == null)
				cb_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_);
			return cb_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_;
		}

		static bool n_SetCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.CustomNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CustomNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification p1 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCustomNotification (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CustomNotificationBuilder']/method[@name='setCustomNotification' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.alibaba.sdk.android.push.notification.BasicCustomPushNotification']]"
		[Register ("setCustomNotification", "(ILcom/alibaba/sdk/android/push/notification/BasicCustomPushNotification;)Z", "GetSetCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_Handler")]
		public virtual unsafe bool SetCustomNotification (int p0, global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification p1)
		{
			if (id_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_ == IntPtr.Zero)
				id_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_ = JNIEnv.GetMethodID (class_ref, "setCustomNotification", "(ILcom/alibaba/sdk/android/push/notification/BasicCustomPushNotification;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setCustomNotification_ILcom_alibaba_sdk_android_push_notification_BasicCustomPushNotification_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomNotification", "(ILcom/alibaba/sdk/android/push/notification/BasicCustomPushNotification;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

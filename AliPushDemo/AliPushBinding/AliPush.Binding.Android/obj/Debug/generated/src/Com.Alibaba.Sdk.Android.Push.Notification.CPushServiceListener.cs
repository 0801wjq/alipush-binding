using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/notification/CPushServiceListener", DoNotGenerateAcw=true)]
	public partial class CPushServiceListener : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/field[@name='MESSAGE_TYPE_DELETE']"
		[Register ("MESSAGE_TYPE_DELETE")]
		public const string MessageTypeDelete = (string) "message_delete";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/field[@name='MESSAGE_TYPE_OPEN']"
		[Register ("MESSAGE_TYPE_OPEN")]
		public const string MessageTypeOpen = (string) "message_open";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/field[@name='NOTIFICATION_TYPE_DELETE']"
		[Register ("NOTIFICATION_TYPE_DELETE")]
		public const string NotificationTypeDelete = (string) "notification_delete";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/field[@name='NOTIFICATION_TYPE_OPEN']"
		[Register ("NOTIFICATION_TYPE_OPEN")]
		public const string NotificationTypeOpen = (string) "notification_open";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/notification/CPushServiceListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CPushServiceListener); }
		}

		protected CPushServiceListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/constructor[@name='CPushServiceListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CPushServiceListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CPushServiceListener)) {
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

		static Delegate cb_onStartCommand_Landroid_content_Intent_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnStartCommand_Landroid_content_Intent_Landroid_content_Context_Handler ()
		{
			if (cb_onStartCommand_Landroid_content_Intent_Landroid_content_Context_ == null)
				cb_onStartCommand_Landroid_content_Intent_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnStartCommand_Landroid_content_Intent_Landroid_content_Context_);
			return cb_onStartCommand_Landroid_content_Intent_Landroid_content_Context_;
		}

		static int n_OnStartCommand_Landroid_content_Intent_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.CPushServiceListener __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CPushServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnStartCommand (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onStartCommand_Landroid_content_Intent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='CPushServiceListener']/method[@name='onStartCommand' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.Context']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;Landroid/content/Context;)I", "GetOnStartCommand_Landroid_content_Intent_Landroid_content_Context_Handler")]
		public virtual unsafe int OnStartCommand (global::Android.Content.Intent p0, global::Android.Content.Context p1)
		{
			if (id_onStartCommand_Landroid_content_Intent_Landroid_content_Context_ == IntPtr.Zero)
				id_onStartCommand_Landroid_content_Intent_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onStartCommand", "(Landroid/content/Intent;Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onStartCommand_Landroid_content_Intent_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartCommand", "(Landroid/content/Intent;Landroid/content/Context;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

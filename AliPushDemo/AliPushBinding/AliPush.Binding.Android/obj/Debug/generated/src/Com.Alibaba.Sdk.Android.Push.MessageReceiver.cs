using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/MessageReceiver", DoNotGenerateAcw=true)]
	public partial class MessageReceiver : global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:MessageReceiver";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/MessageReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageReceiver); }
		}

		protected MessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/constructor[@name='MessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageReceiver)) {
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

		static Delegate cb_onConnectionStatusChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionStatusChanged_ZHandler ()
		{
			if (cb_onConnectionStatusChanged_Z == null)
				cb_onConnectionStatusChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionStatusChanged_Z);
			return cb_onConnectionStatusChanged_Z;
		}

		static void n_OnConnectionStatusChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStatusChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionStatusChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionStatusChanged", "(Z)V", "GetOnConnectionStatusChanged_ZHandler")]
		protected override unsafe void OnConnectionStatusChanged (bool p0)
		{
			if (id_onConnectionStatusChanged_Z == IntPtr.Zero)
				id_onConnectionStatusChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionStatusChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionStatusChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionStatusChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onHandleCall_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnHandleCall_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHandleCall_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onHandleCall_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnHandleCall_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleCall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onHandleCall' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnHandleCall_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnHandleCall (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler ()
		{
			if (cb_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == null)
				cb_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_);
			return cb_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		}

		static void n_OnMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.alibaba.sdk.android.push.notification.CPushMessage']]"
		[Register ("onMessage", "(Landroid/content/Context;Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V", "GetOnMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler")]
		protected virtual unsafe void OnMessage (global::Android.Content.Context p0, global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p1)
		{
			if (id_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == IntPtr.Zero)
				id_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Landroid/content/Context;Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Landroid_content_Context_Lcom_alibaba_sdk_android_push_notification_CPushMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Landroid/content/Context;Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_OnNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotification (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onNotification' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetOnNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected virtual unsafe void OnNotification (global::Android.Content.Context p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationClickedWithNoAction (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onNotificationClickedWithNoAction' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationClickedWithNoAction", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected override unsafe void OnNotificationClickedWithNoAction (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNotificationClickedWithNoAction", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationClickedWithNoAction", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationOpened (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onNotificationOpened' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected override unsafe void OnNotificationOpened (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_);
			return cb_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationReceivedInApp (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onNotificationReceivedInApp' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("onNotificationReceivedInApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;ILjava/lang/String;Ljava/lang/String;)V", "GetOnNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void OnNotificationReceivedInApp (global::Android.Content.Context p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3, int p4, string p5, string p6)
		{
			if (id_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNotificationReceivedInApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationReceivedInApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationReceivedInApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationRemoved_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotificationRemoved_Landroid_content_Context_Ljava_lang_String_);
			return cb_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_OnNotificationRemoved_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.MessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.MessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='MessageReceiver']/method[@name='onNotificationRemoved' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onNotificationRemoved", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnNotificationRemoved_Landroid_content_Context_Ljava_lang_String_Handler")]
		protected override unsafe void OnNotificationRemoved (global::Android.Content.Context p0, string p1)
		{
			if (id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNotificationRemoved", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationRemoved", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

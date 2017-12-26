using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/PushMessageReceiver", DoNotGenerateAcw=true)]
	public abstract partial class PushMessageReceiver : global::Android.Content.BroadcastReceiver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/PushMessageReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushMessageReceiver); }
		}

		protected PushMessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/constructor[@name='PushMessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushMessageReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushMessageReceiver)) {
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

		static Delegate cb_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
#pragma warning disable 0169
		static Delegate GetOnCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_Handler ()
		{
			if (cb_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ == null)
				cb_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_);
			return cb_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
		}

		static void n_OnCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCommandResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onCommandResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushCommandMessage']]"
		[Register ("onCommandResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V", "GetOnCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_Handler")]
		public virtual unsafe void OnCommandResult (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage p1)
		{
			if (id_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ == IntPtr.Zero)
				id_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ = JNIEnv.GetMethodID (class_ref, "onCommandResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommandResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCommandResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler ()
		{
			if (cb_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == null)
				cb_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_);
			return cb_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		}

		static void n_OnNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationMessageArrived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onNotificationMessageArrived' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
		[Register ("onNotificationMessageArrived", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "GetOnNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler")]
		public virtual unsafe void OnNotificationMessageArrived (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1)
		{
			if (id_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
				id_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetMethodID (class_ref, "onNotificationMessageArrived", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationMessageArrived_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationMessageArrived", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler ()
		{
			if (cb_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == null)
				cb_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_);
			return cb_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		}

		static void n_OnNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationMessageClicked (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onNotificationMessageClicked' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
		[Register ("onNotificationMessageClicked", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "GetOnNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler")]
		public virtual unsafe void OnNotificationMessageClicked (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1)
		{
			if (id_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
				id_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetMethodID (class_ref, "onNotificationMessageClicked", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotificationMessageClicked", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static Delegate cb_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler ()
		{
			if (cb_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == null)
				cb_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_);
			return cb_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		}

		static void n_OnReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onReceiveMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
		[Register ("onReceiveMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "GetOnReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler")]
		public virtual unsafe void OnReceiveMessage (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1)
		{
			if (id_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
				id_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetMethodID (class_ref, "onReceiveMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceiveMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler ()
		{
			if (cb_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == null)
				cb_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_);
			return cb_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		}

		static void n_OnReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceivePassThroughMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onReceivePassThroughMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
		[Register ("onReceivePassThroughMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "GetOnReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler")]
		public virtual unsafe void OnReceivePassThroughMessage (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1)
		{
			if (id_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
				id_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetMethodID (class_ref, "onReceivePassThroughMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceivePassThroughMessage_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceivePassThroughMessage", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
#pragma warning disable 0169
		static Delegate GetOnReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_Handler ()
		{
			if (cb_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ == null)
				cb_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_);
			return cb_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
		}

		static void n_OnReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveRegisterResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageReceiver']/method[@name='onReceiveRegisterResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushCommandMessage']]"
		[Register ("onReceiveRegisterResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V", "GetOnReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_Handler")]
		public virtual unsafe void OnReceiveRegisterResult (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage p1)
		{
			if (id_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ == IntPtr.Zero)
				id_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ = JNIEnv.GetMethodID (class_ref, "onReceiveRegisterResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveRegisterResult_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceiveRegisterResult", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/PushMessageReceiver", DoNotGenerateAcw=true)]
	internal partial class PushMessageReceiverInvoker : PushMessageReceiver {

		public PushMessageReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushMessageReceiverInvoker); }
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/AgooMessageReceiver", DoNotGenerateAcw=true)]
	public abstract partial class AgooMessageReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='EXTRA_MAP']"
		[Register ("EXTRA_MAP")]
		public const string ExtraMap = (string) "extraMap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='MESSAGE_ID']"
		[Register ("MESSAGE_ID")]
		public const string MessageId = (string) "messageId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='NOTIFICATION_ID']"
		[Register ("NOTIFICATION_ID")]
		public const string NotificationId = (string) "notificationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='NOTIFICATION_OPENED_ACTION']"
		[Register ("NOTIFICATION_OPENED_ACTION")]
		public const string NotificationOpenedAction = (string) "com.alibaba.push2.action.NOTIFICATION_OPENED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='NOTIFICATION_OPEN_TYPE']"
		[Register ("NOTIFICATION_OPEN_TYPE")]
		public const string NotificationOpenType = (string) "notificationOpenType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='NOTIFICATION_REMOVED_ACTION']"
		[Register ("NOTIFICATION_REMOVED_ACTION")]
		public const string NotificationRemovedAction = (string) "com.alibaba.push2.action.NOTIFICATION_REMOVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='SUMMARY']"
		[Register ("SUMMARY")]
		public const string Summary = (string) "summary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:AgooMessageReceiver";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/field[@name='TITLE']"
		[Register ("TITLE")]
		public const string Title = (string) "title";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/AgooMessageReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooMessageReceiver); }
		}

		protected AgooMessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/constructor[@name='AgooMessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AgooMessageReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AgooMessageReceiver)) {
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
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStatusChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionStatusChanged", "(Z)V", "GetOnConnectionStatusChanged_ZHandler")]
		protected abstract void OnConnectionStatusChanged (bool p0);

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
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleCall (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onHandleCall' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnHandleCall_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public abstract void OnHandleCall (global::Android.Content.Context p0, global::Android.Content.Intent p1);

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
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationClickedWithNoAction (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationClickedWithNoAction' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationClickedWithNoAction", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected abstract void OnNotificationClickedWithNoAction (global::Android.Content.Context p0, string p1, string p2, string p3);

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
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationOpened (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationOpened' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected abstract void OnNotificationOpened (global::Android.Content.Context p0, string p1, string p2, string p3);

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
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationRemoved (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationRemoved' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onNotificationRemoved", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnNotificationRemoved_Landroid_content_Context_Ljava_lang_String_Handler")]
		protected abstract void OnNotificationRemoved (global::Android.Content.Context p0, string p1);

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AgooMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/AgooMessageReceiver", DoNotGenerateAcw=true)]
	internal partial class AgooMessageReceiverInvoker : AgooMessageReceiver {

		public AgooMessageReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooMessageReceiverInvoker); }
		}

		static IntPtr id_onConnectionStatusChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onConnectionStatusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionStatusChanged", "(Z)V", "GetOnConnectionStatusChanged_ZHandler")]
		protected override unsafe void OnConnectionStatusChanged (bool p0)
		{
			if (id_onConnectionStatusChanged_Z == IntPtr.Zero)
				id_onConnectionStatusChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionStatusChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionStatusChanged_Z, __args);
			} finally {
			}
		}

		static IntPtr id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onHandleCall' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnHandleCall_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnHandleCall (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onHandleCall", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleCall_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationClickedWithNoAction' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationClickedWithNoAction_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationOpened' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationOpened_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AgooMessageReceiver']/method[@name='onNotificationRemoved' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotificationRemoved_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushagent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']"
	[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver", DoNotGenerateAcw=true)]
	public abstract partial class PushReceiver : global::Android.Content.BroadcastReceiver {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ACTION']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$ACTION", DoNotGenerateAcw=true)]
		public partial class ACTION : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ACTION']/field[@name='ACTION_CLIENT_DEREGISTER']"
			[Register ("ACTION_CLIENT_DEREGISTER")]
			public const string ActionClientDeregister = (string) "com.huawei.android.push.intent.DEREGISTER";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ACTION']/field[@name='ACTION_NOTIFICATION_MSG_CLICK']"
			[Register ("ACTION_NOTIFICATION_MSG_CLICK")]
			public const string ActionNotificationMsgClick = (string) "com.huawei.android.push.intent.CLICK";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ACTION']/field[@name='ACTION_PUSH_MESSAGE']"
			[Register ("ACTION_PUSH_MESSAGE")]
			public const string ActionPushMessage = (string) "com.huawei.android.push.intent.RECEIVE";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$ACTION", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ACTION); }
			}

			protected ACTION (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ACTION']/constructor[@name='PushReceiver.ACTION' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ACTION ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (ACTION)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$BOUND_KEY", DoNotGenerateAcw=true)]
		public partial class BOUND_KEY : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/field[@name='deviceTokenKey']"
			[Register ("deviceTokenKey")]
			public const string DeviceTokenKey = (string) "deviceToken";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/field[@name='pushMsgKey']"
			[Register ("pushMsgKey")]
			public const string PushMsgKey = (string) "pushMsg";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/field[@name='pushNotifyId']"
			[Register ("pushNotifyId")]
			public const string PushNotifyId = (string) "pushNotifyId";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/field[@name='pushStateKey']"
			[Register ("pushStateKey")]
			public const string PushStateKey = (string) "pushState";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/field[@name='receiveTypeKey']"
			[Register ("receiveTypeKey")]
			public const string ReceiveTypeKey = (string) "receiveType";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$BOUND_KEY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BOUND_KEY); }
			}

			protected BOUND_KEY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.BOUND_KEY']/constructor[@name='PushReceiver.BOUND_KEY' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BOUND_KEY ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (BOUND_KEY)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.EventThread']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$EventThread", DoNotGenerateAcw=true)]
		public partial class EventThread : global::Java.Lang.Thread {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$EventThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EventThread); }
			}

			protected EventThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_huawei_android_pushagent_PushReceiver_Landroid_content_Context_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.EventThread']/constructor[@name='PushReceiver.EventThread' and count(parameter)=3 and parameter[1][@type='com.huawei.android.pushagent.PushReceiver'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.os.Bundle']]"
			[Register (".ctor", "(Lcom/huawei/android/pushagent/PushReceiver;Landroid/content/Context;Landroid/os/Bundle;)V", "")]
			public unsafe EventThread (global::Com.Huawei.Android.Pushagent.PushReceiver __self, global::Android.Content.Context p0, global::Android.OS.Bundle p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p0);
					__args [2] = new JValue (p1);
					if (((object) this).GetType () != typeof (EventThread)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/os/Bundle;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/os/Bundle;)V", __args);
						return;
					}

					if (id_ctor_Lcom_huawei_android_pushagent_PushReceiver_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
						id_ctor_Lcom_huawei_android_pushagent_PushReceiver_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/huawei/android/pushagent/PushReceiver;Landroid/content/Context;Landroid/os/Bundle;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_huawei_android_pushagent_PushReceiver_Landroid_content_Context_Landroid_os_Bundle_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_huawei_android_pushagent_PushReceiver_Landroid_content_Context_Landroid_os_Bundle_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.HandlePushTokenThread']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$HandlePushTokenThread", DoNotGenerateAcw=true)]
		public partial class HandlePushTokenThread : global::Java.Lang.Thread {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$HandlePushTokenThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HandlePushTokenThread); }
			}

			protected HandlePushTokenThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.HandlePushTokenThread']/constructor[@name='PushReceiver.HandlePushTokenThread' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
			public unsafe HandlePushTokenThread (global::Android.Content.Context p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (HandlePushTokenThread)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$KEY_TYPE", DoNotGenerateAcw=true)]
		public partial class KEY_TYPE : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PKGNAME']"
			[Register ("PKGNAME")]
			public const string Pkgname = (string) "pkg_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PLUGINREPORTEXTRA']"
			[Register ("PLUGINREPORTEXTRA")]
			public const string Pluginreportextra = (string) "reportExtra";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PLUGINREPORTRESULT']"
			[Register ("PLUGINREPORTRESULT")]
			public const string Pluginreportresult = (string) "isReportSuccess";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PLUGINREPORTTYPE']"
			[Register ("PLUGINREPORTTYPE")]
			public const string Pluginreporttype = (string) "reportType";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSHSTATE']"
			[Register ("PUSHSTATE")]
			public const string Pushstate = (string) "push_state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSH_BROADCAST_MESSAGE']"
			[Register ("PUSH_BROADCAST_MESSAGE")]
			public const string PushBroadcastMessage = (string) "msg_data";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSH_KEY_CLICK']"
			[Register ("PUSH_KEY_CLICK")]
			public const string PushKeyClick = (string) "click";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSH_KEY_CLICK_BTN']"
			[Register ("PUSH_KEY_CLICK_BTN")]
			public const string PushKeyClickBtn = (string) "clickBtn";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSH_KEY_DEVICE_TOKEN']"
			[Register ("PUSH_KEY_DEVICE_TOKEN")]
			public const string PushKeyDeviceToken = (string) "device_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='PUSH_KEY_NOTIFY_ID']"
			[Register ("PUSH_KEY_NOTIFY_ID")]
			public const string PushKeyNotifyId = (string) "notifyId";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/field[@name='USERID']"
			[Register ("USERID")]
			public const string Userid = (string) "userid";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$KEY_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KEY_TYPE); }
			}

			protected KEY_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.KEY_TYPE']/constructor[@name='PushReceiver.KEY_TYPE' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe KEY_TYPE ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (KEY_TYPE)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$ReceiveType", DoNotGenerateAcw=true)]
		public sealed partial class ReceiveType : global::Java.Lang.Enum {


			static IntPtr ReceiveType_ClickBtn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_ClickBtn']"
			[Register ("ReceiveType_ClickBtn")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypeClickBtn {
				get {
					if (ReceiveType_ClickBtn_jfieldId == IntPtr.Zero)
						ReceiveType_ClickBtn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_ClickBtn", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_ClickBtn_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_Init_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_Init']"
			[Register ("ReceiveType_Init")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypeInit {
				get {
					if (ReceiveType_Init_jfieldId == IntPtr.Zero)
						ReceiveType_Init_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_Init", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_Init_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_Msg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_Msg']"
			[Register ("ReceiveType_Msg")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypeMsg {
				get {
					if (ReceiveType_Msg_jfieldId == IntPtr.Zero)
						ReceiveType_Msg_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_Msg", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_Msg_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_NotifyClick_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_NotifyClick']"
			[Register ("ReceiveType_NotifyClick")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypeNotifyClick {
				get {
					if (ReceiveType_NotifyClick_jfieldId == IntPtr.Zero)
						ReceiveType_NotifyClick_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_NotifyClick", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_NotifyClick_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_PluginRsp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_PluginRsp']"
			[Register ("ReceiveType_PluginRsp")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypePluginRsp {
				get {
					if (ReceiveType_PluginRsp_jfieldId == IntPtr.Zero)
						ReceiveType_PluginRsp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_PluginRsp", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_PluginRsp_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_PushState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_PushState']"
			[Register ("ReceiveType_PushState")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypePushState {
				get {
					if (ReceiveType_PushState_jfieldId == IntPtr.Zero)
						ReceiveType_PushState_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_PushState", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_PushState_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ReceiveType_Token_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/field[@name='ReceiveType_Token']"
			[Register ("ReceiveType_Token")]
			public static global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType ReceiveTypeToken {
				get {
					if (ReceiveType_Token_jfieldId == IntPtr.Zero)
						ReceiveType_Token_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReceiveType_Token", "Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReceiveType_Token_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$ReceiveType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReceiveType); }
			}

			internal ReceiveType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Java.Lang.Enum __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.ReceiveType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;", "")]
			public static unsafe global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/huawei/android/pushagent/PushReceiver$ReceiveType;");
				try {
					return (global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Huawei.Android.Pushagent.PushReceiver.ReceiveType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.SERVER']"
		[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver$SERVER", DoNotGenerateAcw=true)]
		public partial class SERVER : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.SERVER']/field[@name='DEVICETOKEN']"
			[Register ("DEVICETOKEN")]
			public const string Devicetoken = (string) "device_token";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver$SERVER", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SERVER); }
			}

			protected SERVER (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver.SERVER']/constructor[@name='PushReceiver.SERVER' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SERVER ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (SERVER)) {
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushagent/PushReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushReceiver); }
		}

		protected PushReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/constructor[@name='PushReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushReceiver)) {
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

		static Delegate cb_canExit;
#pragma warning disable 0169
		static Delegate GetCanExitHandler ()
		{
			if (cb_canExit == null)
				cb_canExit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanExit);
			return cb_canExit;
		}

		static bool n_CanExit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanExit ();
		}
#pragma warning restore 0169

		static IntPtr id_canExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='canExit' and count(parameter)=0]"
		[Register ("canExit", "()Z", "GetCanExitHandler")]
		public virtual unsafe bool CanExit ()
		{
			if (id_canExit == IntPtr.Zero)
				id_canExit = JNIEnv.GetMethodID (class_ref, "canExit", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canExit);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canExit", "()Z"));
			} finally {
			}
		}

		static IntPtr id_enableReceiveNormalMsg_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='enableReceiveNormalMsg' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableReceiveNormalMsg", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableReceiveNormalMsg (global::Android.Content.Context p0, bool p1)
		{
			if (id_enableReceiveNormalMsg_Landroid_content_Context_Z == IntPtr.Zero)
				id_enableReceiveNormalMsg_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "enableReceiveNormalMsg", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableReceiveNormalMsg_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_enableReceiveNotifyMsg_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='enableReceiveNotifyMsg' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableReceiveNotifyMsg", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableReceiveNotifyMsg (global::Android.Content.Context p0, bool p1)
		{
			if (id_enableReceiveNotifyMsg_Landroid_content_Context_Z == IntPtr.Zero)
				id_enableReceiveNotifyMsg_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "enableReceiveNotifyMsg", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableReceiveNotifyMsg_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getPushState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='getPushState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPushState", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetPushState (global::Android.Content.Context p0)
		{
			if (id_getPushState_Landroid_content_Context_ == IntPtr.Zero)
				id_getPushState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPushState", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getPushState_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getToken_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getToken", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetToken (global::Android.Content.Context p0)
		{
			if (id_getToken_Landroid_content_Context_ == IntPtr.Zero)
				id_getToken_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getToken", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getToken_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_isFrameworkPushExist_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='isFrameworkPushExist' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isFrameworkPushExist", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsFrameworkPushExist (global::Android.Content.Context p0)
		{
			if (id_isFrameworkPushExist_Landroid_content_Context_ == IntPtr.Zero)
				id_isFrameworkPushExist_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isFrameworkPushExist", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFrameworkPushExist_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_OnNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotifyBtnClick (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onNotifyBtnClick' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onNotifyBtnClick", "(Landroid/content/Context;ILjava/lang/String;Landroid/os/Bundle;)V", "GetOnNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnNotifyBtnClick (global::Android.Content.Context p0, int p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onNotifyBtnClick", "(Landroid/content/Context;ILjava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotifyBtnClick_Landroid_content_Context_ILjava_lang_String_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotifyBtnClick", "(Landroid/content/Context;ILjava/lang/String;Landroid/os/Bundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_);
			return cb_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_OnNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotifyClickMsg (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onNotifyClickMsg' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onNotifyClickMsg", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void OnNotifyClickMsg (global::Android.Content.Context p0, string p1)
		{
			if (id_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNotifyClickMsg", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotifyClickMsg_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotifyClickMsg", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_Handler ()
		{
			if (cb_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_ == null)
				cb_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_OnPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_);
			return cb_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_;
		}

		static void n_OnPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2, IntPtr native_p3)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnPluginRsp (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onPluginRsp' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onPluginRsp", "(Landroid/content/Context;IZLandroid/os/Bundle;)V", "GetOnPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_Handler")]
		public virtual unsafe void OnPluginRsp (global::Android.Content.Context p0, int p1, bool p2, global::Android.OS.Bundle p3)
		{
			if (id_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_ == IntPtr.Zero)
				id_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onPluginRsp", "(Landroid/content/Context;IZLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPluginRsp_Landroid_content_Context_IZLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPluginRsp", "(Landroid/content/Context;IZLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_Handler ()
		{
			if (cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ == null)
				cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_);
			return cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
		}

		static void n_OnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPushMsg (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onPushMsg' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V", "GetOnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_Handler")]
		public abstract void OnPushMsg (global::Android.Content.Context p0, byte[] p1, string p2);

		static Delegate cb_onPushState_Landroid_content_Context_Z;
#pragma warning disable 0169
		static Delegate GetOnPushState_Landroid_content_Context_ZHandler ()
		{
			if (cb_onPushState_Landroid_content_Context_Z == null)
				cb_onPushState_Landroid_content_Context_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnPushState_Landroid_content_Context_Z);
			return cb_onPushState_Landroid_content_Context_Z;
		}

		static void n_OnPushState_Landroid_content_Context_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPushState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPushState_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onPushState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("onPushState", "(Landroid/content/Context;Z)V", "GetOnPushState_Landroid_content_Context_ZHandler")]
		public virtual unsafe void OnPushState (global::Android.Content.Context p0, bool p1)
		{
			if (id_onPushState_Landroid_content_Context_Z == IntPtr.Zero)
				id_onPushState_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "onPushState", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPushState_Landroid_content_Context_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPushState", "(Landroid/content/Context;Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
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

		static Delegate cb_onToken_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnToken_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_onToken_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_onToken_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnToken_Landroid_content_Context_Ljava_lang_String_);
			return cb_onToken_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_OnToken_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnToken (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onToken", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnToken_Landroid_content_Context_Ljava_lang_String_Handler")]
		public abstract void OnToken (global::Android.Content.Context p0, string p1);

		static Delegate cb_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_OnToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Huawei.Android.Pushagent.PushReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushagent.PushReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onToken", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnToken (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onToken", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onToken", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/android/pushagent/PushReceiver", DoNotGenerateAcw=true)]
	internal partial class PushReceiverInvoker : PushReceiver {

		public PushReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushReceiverInvoker); }
		}

		static IntPtr id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onPushMsg' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V", "GetOnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_Handler")]
		public override unsafe void OnPushMsg (global::Android.Content.Context p0, byte[] p1, string p2)
		{
			if (id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_onToken_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushagent']/class[@name='PushReceiver']/method[@name='onToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onToken", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnToken_Landroid_content_Context_Ljava_lang_String_Handler")]
		public override unsafe void OnToken (global::Android.Content.Context p0, string p1)
		{
			if (id_onToken_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onToken_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onToken", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onToken_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/PushMessageHelper", DoNotGenerateAcw=true)]
	public partial class PushMessageHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='KEY_COMMAND']"
		[Register ("KEY_COMMAND")]
		public const string KeyCommand = (string) "key_command";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='KEY_MESSAGE']"
		[Register ("KEY_MESSAGE")]
		public const string KeyMessage = (string) "key_message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='MESSAGE_COMMAND']"
		[Register ("MESSAGE_COMMAND")]
		public const int MessageCommand = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='MESSAGE_QUIT']"
		[Register ("MESSAGE_QUIT")]
		public const int MessageQuit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='MESSAGE_RAW']"
		[Register ("MESSAGE_RAW")]
		public const int MessageRaw = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='MESSAGE_SENDMESSAGE']"
		[Register ("MESSAGE_SENDMESSAGE")]
		public const int MessageSendmessage = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='MESSAGE_TYPE']"
		[Register ("MESSAGE_TYPE")]
		public const string MessageType = (string) "message_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='PUSH_MODE_BROADCAST']"
		[Register ("PUSH_MODE_BROADCAST")]
		public const int PushModeBroadcast = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/field[@name='PUSH_MODE_CALLBACK']"
		[Register ("PUSH_MODE_CALLBACK")]
		public const int PushModeCallback = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/PushMessageHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushMessageHelper); }
		}

		protected PushMessageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/constructor[@name='PushMessageHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushMessageHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushMessageHelper)) {
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

		static IntPtr id_generateCommandMessage_Ljava_lang_String_Ljava_util_List_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/method[@name='generateCommandMessage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("generateCommandMessage", "(Ljava/lang/String;Ljava/util/List;JLjava/lang/String;Ljava/lang/String;)Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;", "")]
		public static unsafe global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage GenerateCommandMessage (string p0, global::System.Collections.Generic.IList<string> p1, long p2, string p3, string p4)
		{
			if (id_generateCommandMessage_Ljava_lang_String_Ljava_util_List_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateCommandMessage_Ljava_lang_String_Ljava_util_List_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generateCommandMessage", "(Ljava/lang/String;Ljava/util/List;JLjava/lang/String;Ljava/lang/String;)Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateCommandMessage_Ljava_lang_String_Ljava_util_List_JLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getPushMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/method[@name='getPushMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPushMode", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetPushMode (global::Android.Content.Context p0)
		{
			if (id_getPushMode_Landroid_content_Context_ == IntPtr.Zero)
				id_getPushMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPushMode", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPushMode_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isUseCallbackPushMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/method[@name='isUseCallbackPushMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isUseCallbackPushMode", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsUseCallbackPushMode (global::Android.Content.Context p0)
		{
			if (id_isUseCallbackPushMode_Landroid_content_Context_ == IntPtr.Zero)
				id_isUseCallbackPushMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isUseCallbackPushMode", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUseCallbackPushMode_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendCommandMessageBroadcast_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/method[@name='sendCommandMessageBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushCommandMessage']]"
		[Register ("sendCommandMessageBroadcast", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V", "")]
		public static unsafe void SendCommandMessageBroadcast (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage p1)
		{
			if (id_sendCommandMessageBroadcast_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ == IntPtr.Zero)
				id_sendCommandMessageBroadcast_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_ = JNIEnv.GetStaticMethodID (class_ref, "sendCommandMessageBroadcast", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushCommandMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendCommandMessageBroadcast_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushCommandMessage_, __args);
			} finally {
			}
		}

		static IntPtr id_sendQuitMessageBroadcast_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHelper']/method[@name='sendQuitMessageBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendQuitMessageBroadcast", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendQuitMessageBroadcast (global::Android.Content.Context p0)
		{
			if (id_sendQuitMessageBroadcast_Landroid_content_Context_ == IntPtr.Zero)
				id_sendQuitMessageBroadcast_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendQuitMessageBroadcast", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendQuitMessageBroadcast_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushClient", DoNotGenerateAcw=true)]
	public abstract partial class MiPushClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='ACCEPT_TIME_SEPARATOR']"
		[Register ("ACCEPT_TIME_SEPARATOR")]
		public const string AcceptTimeSeparator = (string) ",";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_REGISTER']"
		[Register ("COMMAND_REGISTER")]
		public const string CommandRegister = (string) "register";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_SET_ACCEPT_TIME']"
		[Register ("COMMAND_SET_ACCEPT_TIME")]
		public const string CommandSetAcceptTime = (string) "accept-time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_SET_ACCOUNT']"
		[Register ("COMMAND_SET_ACCOUNT")]
		public const string CommandSetAccount = (string) "set-account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_SET_ALIAS']"
		[Register ("COMMAND_SET_ALIAS")]
		public const string CommandSetAlias = (string) "set-alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_SUBSCRIBE_TOPIC']"
		[Register ("COMMAND_SUBSCRIBE_TOPIC")]
		public const string CommandSubscribeTopic = (string) "subscribe-topic";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_UNSET_ACCOUNT']"
		[Register ("COMMAND_UNSET_ACCOUNT")]
		public const string CommandUnsetAccount = (string) "unset-account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_UNSET_ALIAS']"
		[Register ("COMMAND_UNSET_ALIAS")]
		public const string CommandUnsetAlias = (string) "unset-alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/field[@name='COMMAND_UNSUBSCRIBE_TOPIC']"
		[Register ("COMMAND_UNSUBSCRIBE_TOPIC")]
		public const string CommandUnsubscribeTopic = (string) "unsubscibe-topic";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']"
		[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushClient$MiPushClientCallback", DoNotGenerateAcw=true)]
		public abstract partial class MiPushClientCallback : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/MiPushClient$MiPushClientCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MiPushClientCallback); }
			}

			protected MiPushClientCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/constructor[@name='MiPushClient.MiPushClientCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MiPushClientCallback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (MiPushClientCallback)) {
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

			static Delegate cb_getCategory;
#pragma warning disable 0169
			static Delegate GetGetCategoryHandler ()
			{
				if (cb_getCategory == null)
					cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
				return cb_getCategory;
			}

			static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Category);
			}
#pragma warning restore 0169

			static Delegate cb_setCategory_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCategory_Ljava_lang_String_Handler ()
			{
				if (cb_setCategory_Ljava_lang_String_ == null)
					cb_setCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategory_Ljava_lang_String_);
				return cb_setCategory_Ljava_lang_String_;
			}

			static void n_SetCategory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Category = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getCategory;
			static IntPtr id_setCategory_Ljava_lang_String_;
			protected virtual unsafe string Category {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='getCategory' and count(parameter)=0]"
				[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
				get {
					if (id_getCategory == IntPtr.Zero)
						id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategory", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCategory", "(Ljava/lang/String;)V", "GetSetCategory_Ljava_lang_String_Handler")]
				set {
					if (id_setCategory_Ljava_lang_String_ == IntPtr.Zero)
						id_setCategory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCategory", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategory_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategory", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetOnCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_Handler ()
			{
				if (cb_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_ == null)
					cb_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_);
				return cb_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_;
			}

			static void n_OnCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnCommandResult (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onCommandResult' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("onCommandResult", "(Ljava/lang/String;JLjava/lang/String;Ljava/util/List;)V", "GetOnCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_Handler")]
			public virtual unsafe void OnCommandResult (string p0, long p1, string p2, global::System.Collections.Generic.IList<string> p3)
			{
				if (id_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onCommandResult", "(Ljava/lang/String;JLjava/lang/String;Ljava/util/List;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommandResult_Ljava_lang_String_JLjava_lang_String_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCommandResult", "(Ljava/lang/String;JLjava/lang/String;Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static Delegate cb_onInitializeResult_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnInitializeResult_JLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onInitializeResult_JLjava_lang_String_Ljava_lang_String_ == null)
					cb_onInitializeResult_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnInitializeResult_JLjava_lang_String_Ljava_lang_String_);
				return cb_onInitializeResult_JLjava_lang_String_Ljava_lang_String_;
			}

			static void n_OnInitializeResult_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnInitializeResult (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onInitializeResult_JLjava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onInitializeResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onInitializeResult", "(JLjava/lang/String;Ljava/lang/String;)V", "GetOnInitializeResult_JLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void OnInitializeResult (long p0, string p1, string p2)
			{
				if (id_onInitializeResult_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onInitializeResult_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInitializeResult", "(JLjava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitializeResult_JLjava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInitializeResult", "(JLjava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
#pragma warning disable 0169
			static Delegate GetOnReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler ()
			{
				if (cb_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == null)
					cb_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_);
				return cb_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
			}

			static void n_OnReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReceiveMessage (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onReceiveMessage' and count(parameter)=1 and parameter[1][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
			[Register ("onReceiveMessage", "(Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "GetOnReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_Handler")]
			public virtual unsafe void OnReceiveMessage (global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p0)
			{
				if (id_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
					id_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetMethodID (class_ref, "onReceiveMessage", "(Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveMessage_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceiveMessage", "(Lcom/xiaomi/mipush/sdk/MiPushMessage;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetOnReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
			{
				if (cb_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
					cb_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
				return cb_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
			}

			static void n_OnReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnReceiveMessage (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onReceiveMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
			[Register ("onReceiveMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetOnReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
			public virtual unsafe void OnReceiveMessage (string p0, string p1, string p2, bool p3)
			{
				if (id_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onReceiveMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceiveMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSubscribeResult_JLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_ == null)
					cb_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnSubscribeResult_JLjava_lang_String_Ljava_lang_String_);
				return cb_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_;
			}

			static void n_OnSubscribeResult_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnSubscribeResult (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onSubscribeResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onSubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V", "GetOnSubscribeResult_JLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void OnSubscribeResult (long p0, string p1, string p2)
			{
				if (id_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubscribeResult_JLjava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_ == null)
					cb_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_);
				return cb_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_;
			}

			static void n_OnUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnUnsubscribeResult (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient.MiPushClientCallback']/method[@name='onUnsubscribeResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onUnsubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V", "GetOnUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void OnUnsubscribeResult (long p0, string p1, string p2)
			{
				if (id_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUnsubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnsubscribeResult_JLjava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnsubscribeResult", "(JLjava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushClient$MiPushClientCallback", DoNotGenerateAcw=true)]
		internal partial class MiPushClientCallbackInvoker : MiPushClientCallback {

			public MiPushClientCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (MiPushClientCallbackInvoker); }
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/MiPushClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiPushClient); }
		}

		protected MiPushClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/constructor[@name='MiPushClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiPushClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MiPushClient)) {
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

		static IntPtr id_accountSetTime_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='accountSetTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("accountSetTime", "(Landroid/content/Context;Ljava/lang/String;)J", "")]
		public static unsafe long AccountSetTime (global::Android.Content.Context p0, string p1)
		{
			if (id_accountSetTime_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_accountSetTime_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "accountSetTime", "(Landroid/content/Context;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_accountSetTime_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_aliasSetTime_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='aliasSetTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("aliasSetTime", "(Landroid/content/Context;Ljava/lang/String;)J", "")]
		public static unsafe long AliasSetTime (global::Android.Content.Context p0, string p1)
		{
			if (id_aliasSetTime_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_aliasSetTime_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "aliasSetTime", "(Landroid/content/Context;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_aliasSetTime_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_checkManifest_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='checkManifest' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkManifest", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckManifest (global::Android.Content.Context p0)
		{
			if (id_checkManifest_Landroid_content_Context_ == IntPtr.Zero)
				id_checkManifest_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkManifest", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkManifest_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearExtras_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='clearExtras' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearExtras", "(Landroid/content/Context;)V", "")]
		protected static unsafe void ClearExtras (global::Android.Content.Context p0)
		{
			if (id_clearExtras_Landroid_content_Context_ == IntPtr.Zero)
				id_clearExtras_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearExtras", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearExtras_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearLocalNotificationType_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='clearLocalNotificationType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLocalNotificationType", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearLocalNotificationType (global::Android.Content.Context p0)
		{
			if (id_clearLocalNotificationType_Landroid_content_Context_ == IntPtr.Zero)
				id_clearLocalNotificationType_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearLocalNotificationType", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLocalNotificationType_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearNotification_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='clearNotification' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearNotification", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearNotification (global::Android.Content.Context p0)
		{
			if (id_clearNotification_Landroid_content_Context_ == IntPtr.Zero)
				id_clearNotification_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearNotification", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearNotification_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearNotification_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='clearNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("clearNotification", "(Landroid/content/Context;I)V", "")]
		public static unsafe void ClearNotification (global::Android.Content.Context p0, int p1)
		{
			if (id_clearNotification_Landroid_content_Context_I == IntPtr.Zero)
				id_clearNotification_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "clearNotification", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearNotification_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_generatePacketID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='generatePacketID' and count(parameter)=0]"
		[Register ("generatePacketID", "()Ljava/lang/String;", "")]
		protected static unsafe string GeneratePacketID ()
		{
			if (id_generatePacketID == IntPtr.Zero)
				id_generatePacketID = JNIEnv.GetStaticMethodID (class_ref, "generatePacketID", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generatePacketID), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getAllAlias_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='getAllAlias' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAllAlias", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetAllAlias (global::Android.Content.Context p0)
		{
			if (id_getAllAlias_Landroid_content_Context_ == IntPtr.Zero)
				id_getAllAlias_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAllAlias", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllAlias_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAllTopic_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='getAllTopic' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAllTopic", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetAllTopic (global::Android.Content.Context p0)
		{
			if (id_getAllTopic_Landroid_content_Context_ == IntPtr.Zero)
				id_getAllTopic_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAllTopic", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllTopic_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAllUserAccount_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='getAllUserAccount' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAllUserAccount", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetAllUserAccount (global::Android.Content.Context p0)
		{
			if (id_getAllUserAccount_Landroid_content_Context_ == IntPtr.Zero)
				id_getAllUserAccount_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAllUserAccount", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllUserAccount_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRegId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='getRegId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetRegId (global::Android.Content.Context p0)
		{
			if (id_getRegId_Landroid_content_Context_ == IntPtr.Zero)
				id_getRegId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRegId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRegId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_xiaomi_mipush_sdk_MiPushClient_MiPushClientCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='initialize' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.xiaomi.mipush.sdk.MiPushClient.MiPushClientCallback']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/xiaomi/mipush/sdk/MiPushClient$MiPushClientCallback;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0, string p1, string p2, global::Com.Xiaomi.Mipush.Sdk.MiPushClient.MiPushClientCallback p3)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_xiaomi_mipush_sdk_MiPushClient_MiPushClientCallback_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_xiaomi_mipush_sdk_MiPushClient_MiPushClientCallback_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/xiaomi/mipush/sdk/MiPushClient$MiPushClientCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_xiaomi_mipush_sdk_MiPushClient_MiPushClientCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_pausePush_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='pausePush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("pausePush", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void PausePush (global::Android.Content.Context p0, string p1)
		{
			if (id_pausePush_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_pausePush_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "pausePush", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pausePush_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_registerPush_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='registerPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerPush", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_registerPush_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerPush_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "registerPush", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerPush_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_reportMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='reportMessageClicked' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.mipush.sdk.MiPushMessage']]"
		[Register ("reportMessageClicked", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V", "")]
		public static unsafe void ReportMessageClicked (global::Android.Content.Context p0, global::Com.Xiaomi.Mipush.Sdk.MiPushMessage p1)
		{
			if (id_reportMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ == IntPtr.Zero)
				id_reportMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_ = JNIEnv.GetStaticMethodID (class_ref, "reportMessageClicked", "(Landroid/content/Context;Lcom/xiaomi/mipush/sdk/MiPushMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportMessageClicked_Landroid_content_Context_Lcom_xiaomi_mipush_sdk_MiPushMessage_, __args);
			} finally {
			}
		}

		static IntPtr id_reportMessageClicked_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='reportMessageClicked' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportMessageClicked", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportMessageClicked (global::Android.Content.Context p0, string p1)
		{
			if (id_reportMessageClicked_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_reportMessageClicked_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportMessageClicked", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportMessageClicked_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_resumePush_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='resumePush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("resumePush", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ResumePush (global::Android.Content.Context p0, string p1)
		{
			if (id_resumePush_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_resumePush_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "resumePush", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resumePush_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setAcceptTime_Landroid_content_Context_IIIILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setAcceptTime' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register ("setAcceptTime", "(Landroid/content/Context;IIIILjava/lang/String;)V", "")]
		public static unsafe void SetAcceptTime (global::Android.Content.Context p0, int p1, int p2, int p3, int p4, string p5)
		{
			if (id_setAcceptTime_Landroid_content_Context_IIIILjava_lang_String_ == IntPtr.Zero)
				id_setAcceptTime_Landroid_content_Context_IIIILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAcceptTime", "(Landroid/content/Context;IIIILjava/lang/String;)V");
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAcceptTime_Landroid_content_Context_IIIILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_setAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setAlias' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setAlias", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetAlias (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_setAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAlias", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setCommand' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setCommand", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void SetCommand (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCommand", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setCommand' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register ("setCommand", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;Ljava/lang/String;)V", "")]
		protected static unsafe void SetCommand (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IList<string> p2, string p3)
		{
			if (id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCommand", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCommand_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_setLocalNotificationType_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setLocalNotificationType' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setLocalNotificationType", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetLocalNotificationType (global::Android.Content.Context p0, int p1)
		{
			if (id_setLocalNotificationType_Landroid_content_Context_I == IntPtr.Zero)
				id_setLocalNotificationType_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setLocalNotificationType", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLocalNotificationType_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_setUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='setUserAccount' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUserAccount", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetUserAccount (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_setUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserAccount", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_shouldUseMIUIPush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='shouldUseMIUIPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("shouldUseMIUIPush", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool ShouldUseMIUIPush (global::Android.Content.Context p0)
		{
			if (id_shouldUseMIUIPush_Landroid_content_Context_ == IntPtr.Zero)
				id_shouldUseMIUIPush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "shouldUseMIUIPush", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldUseMIUIPush_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Subscribe (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_topicSubscribedTime_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='topicSubscribedTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("topicSubscribedTime", "(Landroid/content/Context;Ljava/lang/String;)J", "")]
		public static unsafe long TopicSubscribedTime (global::Android.Content.Context p0, string p1)
		{
			if (id_topicSubscribedTime_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_topicSubscribedTime_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "topicSubscribedTime", "(Landroid/content/Context;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_topicSubscribedTime_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_unregisterPush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='unregisterPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unregisterPush", "(Landroid/content/Context;)V", "")]
		public static unsafe void UnregisterPush (global::Android.Content.Context p0)
		{
			if (id_unregisterPush_Landroid_content_Context_ == IntPtr.Zero)
				id_unregisterPush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterPush", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterPush_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_unsetAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='unsetAlias' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("unsetAlias", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void UnsetAlias (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_unsetAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsetAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unsetAlias", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unsetAlias_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_unsetUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='unsetUserAccount' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("unsetUserAccount", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void UnsetUserAccount (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_unsetUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsetUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unsetUserAccount", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unsetUserAccount_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Unsubscribe (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unsubscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushClient", DoNotGenerateAcw=true)]
	internal partial class MiPushClientInvoker : MiPushClient {

		public MiPushClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiPushClientInvoker); }
		}

	}

}

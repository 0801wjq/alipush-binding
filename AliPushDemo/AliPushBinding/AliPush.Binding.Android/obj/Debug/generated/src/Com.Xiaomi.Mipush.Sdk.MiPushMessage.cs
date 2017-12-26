using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushMessage", DoNotGenerateAcw=true)]
	public partial class MiPushMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/field[@name='MESSAGE_TYPE_ACCOUNT']"
		[Register ("MESSAGE_TYPE_ACCOUNT")]
		public const int MessageTypeAccount = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/field[@name='MESSAGE_TYPE_ALIAS']"
		[Register ("MESSAGE_TYPE_ALIAS")]
		public const int MessageTypeAlias = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/field[@name='MESSAGE_TYPE_REG']"
		[Register ("MESSAGE_TYPE_REG")]
		public const int MessageTypeReg = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/field[@name='MESSAGE_TYPE_TOPIC']"
		[Register ("MESSAGE_TYPE_TOPIC")]
		public const int MessageTypeTopic = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/MiPushMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiPushMessage); }
		}

		protected MiPushMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/constructor[@name='MiPushMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiPushMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MiPushMessage)) {
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

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		static Delegate cb_setAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlias_Ljava_lang_String_Handler ()
		{
			if (cb_setAlias_Ljava_lang_String_ == null)
				cb_setAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlias_Ljava_lang_String_);
			return cb_setAlias_Ljava_lang_String_;
		}

		static void n_SetAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Alias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlias;
		static IntPtr id_setAlias_Ljava_lang_String_;
		public virtual unsafe string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlias", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlias", "(Ljava/lang/String;)V", "GetSetAlias_Ljava_lang_String_Handler")]
			set {
				if (id_setAlias_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlias", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlias_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlias", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isArrivedMessage;
#pragma warning disable 0169
		static Delegate GetIsArrivedMessageHandler ()
		{
			if (cb_isArrivedMessage == null)
				cb_isArrivedMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsArrivedMessage);
			return cb_isArrivedMessage;
		}

		static bool n_IsArrivedMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrivedMessage;
		}
#pragma warning restore 0169

		static Delegate cb_setArrivedMessage_Z;
#pragma warning disable 0169
		static Delegate GetSetArrivedMessage_ZHandler ()
		{
			if (cb_setArrivedMessage_Z == null)
				cb_setArrivedMessage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetArrivedMessage_Z);
			return cb_setArrivedMessage_Z;
		}

		static void n_SetArrivedMessage_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArrivedMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isArrivedMessage;
		static IntPtr id_setArrivedMessage_Z;
		public virtual unsafe bool ArrivedMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='isArrivedMessage' and count(parameter)=0]"
			[Register ("isArrivedMessage", "()Z", "GetIsArrivedMessageHandler")]
			get {
				if (id_isArrivedMessage == IntPtr.Zero)
					id_isArrivedMessage = JNIEnv.GetMethodID (class_ref, "isArrivedMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isArrivedMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isArrivedMessage", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setArrivedMessage' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setArrivedMessage", "(Z)V", "GetSetArrivedMessage_ZHandler")]
			set {
				if (id_setArrivedMessage_Z == IntPtr.Zero)
					id_setArrivedMessage_Z = JNIEnv.GetMethodID (class_ref, "setArrivedMessage", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArrivedMessage_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrivedMessage", "(Z)V"), __args);
				} finally {
				}
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
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Category = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCategory;
		static IntPtr id_setCategory_Ljava_lang_String_;
		public virtual unsafe string Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getCategory' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_lang_String_Handler ()
		{
			if (cb_setContent_Ljava_lang_String_ == null)
				cb_setContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_lang_String_);
			return cb_setContent_Ljava_lang_String_;
		}

		static void n_SetContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Content = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		static IntPtr id_setContent_Ljava_lang_String_;
		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContent", "(Ljava/lang/String;)V", "GetSetContent_Ljava_lang_String_Handler")]
			set {
				if (id_setContent_Ljava_lang_String_ == IntPtr.Zero)
					id_setContent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContent", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContent_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContent", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExtra;
#pragma warning disable 0169
		static Delegate GetGetExtraHandler ()
		{
			if (cb_getExtra == null)
				cb_getExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtra);
			return cb_getExtra;
		}

		static IntPtr n_GetExtra (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Extra);
		}
#pragma warning restore 0169

		static Delegate cb_setExtra_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetExtra_Ljava_util_Map_Handler ()
		{
			if (cb_setExtra_Ljava_util_Map_ == null)
				cb_setExtra_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtra_Ljava_util_Map_);
			return cb_setExtra_Ljava_util_Map_;
		}

		static void n_SetExtra_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extra = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtra;
		static IntPtr id_setExtra_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Extra {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getExtra' and count(parameter)=0]"
			[Register ("getExtra", "()Ljava/util/Map;", "GetGetExtraHandler")]
			get {
				if (id_getExtra == IntPtr.Zero)
					id_getExtra = JNIEnv.GetMethodID (class_ref, "getExtra", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtra), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtra", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setExtra' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setExtra", "(Ljava/util/Map;)V", "GetSetExtra_Ljava_util_Map_Handler")]
			set {
				if (id_setExtra_Ljava_util_Map_ == IntPtr.Zero)
					id_setExtra_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setExtra", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtra_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtra", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageId);
			return cb_getMessageId;
		}

		static IntPtr n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageId_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageId_Ljava_lang_String_ == null)
				cb_setMessageId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageId_Ljava_lang_String_);
			return cb_setMessageId_Ljava_lang_String_;
		}

		static void n_SetMessageId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		static IntPtr id_setMessageId_Ljava_lang_String_;
		public virtual unsafe string MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageId", "(Ljava/lang/String;)V", "GetSetMessageId_Ljava_lang_String_Handler")]
			set {
				if (id_setMessageId_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageType);
			return cb_getMessageType;
		}

		static int n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageType;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageType_I;
#pragma warning disable 0169
		static Delegate GetSetMessageType_IHandler ()
		{
			if (cb_setMessageType_I == null)
				cb_setMessageType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageType_I);
			return cb_setMessageType_I;
		}

		static void n_SetMessageType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		static IntPtr id_setMessageType_I;
		public virtual unsafe int MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()I", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setMessageType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageType", "(I)V", "GetSetMessageType_IHandler")]
			set {
				if (id_setMessageType_I == IntPtr.Zero)
					id_setMessageType_I = JNIEnv.GetMethodID (class_ref, "setMessageType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNotified;
#pragma warning disable 0169
		static Delegate GetIsNotifiedHandler ()
		{
			if (cb_isNotified == null)
				cb_isNotified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotified);
			return cb_isNotified;
		}

		static bool n_IsNotified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Notified;
		}
#pragma warning restore 0169

		static Delegate cb_setNotified_Z;
#pragma warning disable 0169
		static Delegate GetSetNotified_ZHandler ()
		{
			if (cb_setNotified_Z == null)
				cb_setNotified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotified_Z);
			return cb_setNotified_Z;
		}

		static void n_SetNotified_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Notified = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNotified;
		static IntPtr id_setNotified_Z;
		public virtual unsafe bool Notified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='isNotified' and count(parameter)=0]"
			[Register ("isNotified", "()Z", "GetIsNotifiedHandler")]
			get {
				if (id_isNotified == IntPtr.Zero)
					id_isNotified = JNIEnv.GetMethodID (class_ref, "isNotified", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotified);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotified", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setNotified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotified", "(Z)V", "GetSetNotified_ZHandler")]
			set {
				if (id_setNotified_Z == IntPtr.Zero)
					id_setNotified_Z = JNIEnv.GetMethodID (class_ref, "setNotified", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotified_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotified", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotifyId;
#pragma warning disable 0169
		static Delegate GetGetNotifyIdHandler ()
		{
			if (cb_getNotifyId == null)
				cb_getNotifyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotifyId);
			return cb_getNotifyId;
		}

		static int n_GetNotifyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotifyId_I;
#pragma warning disable 0169
		static Delegate GetSetNotifyId_IHandler ()
		{
			if (cb_setNotifyId_I == null)
				cb_setNotifyId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotifyId_I);
			return cb_setNotifyId_I;
		}

		static void n_SetNotifyId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotifyId;
		static IntPtr id_setNotifyId_I;
		public virtual unsafe int NotifyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getNotifyId' and count(parameter)=0]"
			[Register ("getNotifyId", "()I", "GetGetNotifyIdHandler")]
			get {
				if (id_getNotifyId == IntPtr.Zero)
					id_getNotifyId = JNIEnv.GetMethodID (class_ref, "getNotifyId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotifyId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotifyId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setNotifyId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotifyId", "(I)V", "GetSetNotifyId_IHandler")]
			set {
				if (id_setNotifyId_I == IntPtr.Zero)
					id_setNotifyId_I = JNIEnv.GetMethodID (class_ref, "setNotifyId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotifyId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotifyId", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotifyType;
#pragma warning disable 0169
		static Delegate GetGetNotifyTypeHandler ()
		{
			if (cb_getNotifyType == null)
				cb_getNotifyType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotifyType);
			return cb_getNotifyType;
		}

		static int n_GetNotifyType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyType;
		}
#pragma warning restore 0169

		static Delegate cb_setNotifyType_I;
#pragma warning disable 0169
		static Delegate GetSetNotifyType_IHandler ()
		{
			if (cb_setNotifyType_I == null)
				cb_setNotifyType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotifyType_I);
			return cb_setNotifyType_I;
		}

		static void n_SetNotifyType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotifyType;
		static IntPtr id_setNotifyType_I;
		public virtual unsafe int NotifyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getNotifyType' and count(parameter)=0]"
			[Register ("getNotifyType", "()I", "GetGetNotifyTypeHandler")]
			get {
				if (id_getNotifyType == IntPtr.Zero)
					id_getNotifyType = JNIEnv.GetMethodID (class_ref, "getNotifyType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotifyType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotifyType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setNotifyType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotifyType", "(I)V", "GetSetNotifyType_IHandler")]
			set {
				if (id_setNotifyType_I == IntPtr.Zero)
					id_setNotifyType_I = JNIEnv.GetMethodID (class_ref, "setNotifyType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotifyType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotifyType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPassThrough;
#pragma warning disable 0169
		static Delegate GetGetPassThroughHandler ()
		{
			if (cb_getPassThrough == null)
				cb_getPassThrough = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPassThrough);
			return cb_getPassThrough;
		}

		static int n_GetPassThrough (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PassThrough;
		}
#pragma warning restore 0169

		static Delegate cb_setPassThrough_I;
#pragma warning disable 0169
		static Delegate GetSetPassThrough_IHandler ()
		{
			if (cb_setPassThrough_I == null)
				cb_setPassThrough_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPassThrough_I);
			return cb_setPassThrough_I;
		}

		static void n_SetPassThrough_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PassThrough = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassThrough;
		static IntPtr id_setPassThrough_I;
		public virtual unsafe int PassThrough {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getPassThrough' and count(parameter)=0]"
			[Register ("getPassThrough", "()I", "GetGetPassThroughHandler")]
			get {
				if (id_getPassThrough == IntPtr.Zero)
					id_getPassThrough = JNIEnv.GetMethodID (class_ref, "getPassThrough", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPassThrough);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassThrough", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setPassThrough' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPassThrough", "(I)V", "GetSetPassThrough_IHandler")]
			set {
				if (id_setPassThrough_I == IntPtr.Zero)
					id_setPassThrough_I = JNIEnv.GetMethodID (class_ref, "setPassThrough", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassThrough_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassThrough", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTopic;
#pragma warning disable 0169
		static Delegate GetGetTopicHandler ()
		{
			if (cb_getTopic == null)
				cb_getTopic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopic);
			return cb_getTopic;
		}

		static IntPtr n_GetTopic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Topic);
		}
#pragma warning restore 0169

		static Delegate cb_setTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_setTopic_Ljava_lang_String_ == null)
				cb_setTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopic_Ljava_lang_String_);
			return cb_setTopic_Ljava_lang_String_;
		}

		static void n_SetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Topic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopic;
		static IntPtr id_setTopic_Ljava_lang_String_;
		public virtual unsafe string Topic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getTopic' and count(parameter)=0]"
			[Register ("getTopic", "()Ljava/lang/String;", "GetGetTopicHandler")]
			get {
				if (id_getTopic == IntPtr.Zero)
					id_getTopic = JNIEnv.GetMethodID (class_ref, "getTopic", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopic), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopic", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopic", "(Ljava/lang/String;)V", "GetSetTopic_Ljava_lang_String_Handler")]
			set {
				if (id_setTopic_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopic", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopic_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopic", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserAccount;
#pragma warning disable 0169
		static Delegate GetGetUserAccountHandler ()
		{
			if (cb_getUserAccount == null)
				cb_getUserAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserAccount);
			return cb_getUserAccount;
		}

		static IntPtr n_GetUserAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserAccount);
		}
#pragma warning restore 0169

		static Delegate cb_setUserAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAccount_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAccount_Ljava_lang_String_ == null)
				cb_setUserAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAccount_Ljava_lang_String_);
			return cb_setUserAccount_Ljava_lang_String_;
		}

		static void n_SetUserAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserAccount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserAccount;
		static IntPtr id_setUserAccount_Ljava_lang_String_;
		public virtual unsafe string UserAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='getUserAccount' and count(parameter)=0]"
			[Register ("getUserAccount", "()Ljava/lang/String;", "GetGetUserAccountHandler")]
			get {
				if (id_getUserAccount == IntPtr.Zero)
					id_getUserAccount = JNIEnv.GetMethodID (class_ref, "getUserAccount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserAccount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserAccount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='setUserAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserAccount", "(Ljava/lang/String;)V", "GetSetUserAccount_Ljava_lang_String_Handler")]
			set {
				if (id_setUserAccount_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserAccount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserAccount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAccount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_fromBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("fromBundle", "(Landroid/os/Bundle;)Lcom/xiaomi/mipush/sdk/MiPushMessage;", "")]
		public static unsafe global::Com.Xiaomi.Mipush.Sdk.MiPushMessage FromBundle (global::Android.OS.Bundle p0)
		{
			if (id_fromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_fromBundle_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "fromBundle", "(Landroid/os/Bundle;)Lcom/xiaomi/mipush/sdk/MiPushMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_toBundle;
#pragma warning disable 0169
		static Delegate GetToBundleHandler ()
		{
			if (cb_toBundle == null)
				cb_toBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBundle);
			return cb_toBundle;
		}

		static IntPtr n_ToBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBundle ());
		}
#pragma warning restore 0169

		static IntPtr id_toBundle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushMessage']/method[@name='toBundle' and count(parameter)=0]"
		[Register ("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler")]
		public virtual unsafe global::Android.OS.Bundle ToBundle ()
		{
			if (id_toBundle == IntPtr.Zero)
				id_toBundle = JNIEnv.GetMethodID (class_ref, "toBundle", "()Landroid/os/Bundle;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBundle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

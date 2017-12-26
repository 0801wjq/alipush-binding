using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/MiPushCommandMessage", DoNotGenerateAcw=true)]
	public partial class MiPushCommandMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/MiPushCommandMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiPushCommandMessage); }
		}

		protected MiPushCommandMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/constructor[@name='MiPushCommandMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiPushCommandMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MiPushCommandMessage)) {
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
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Category = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCategory;
		static IntPtr id_setCategory_Ljava_lang_String_;
		public virtual unsafe string Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='getCategory' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCommand;
#pragma warning disable 0169
		static Delegate GetGetCommandHandler ()
		{
			if (cb_getCommand == null)
				cb_getCommand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommand);
			return cb_getCommand;
		}

		static IntPtr n_GetCommand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Command);
		}
#pragma warning restore 0169

		static Delegate cb_setCommand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCommand_Ljava_lang_String_Handler ()
		{
			if (cb_setCommand_Ljava_lang_String_ == null)
				cb_setCommand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommand_Ljava_lang_String_);
			return cb_setCommand_Ljava_lang_String_;
		}

		static void n_SetCommand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Command = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCommand;
		static IntPtr id_setCommand_Ljava_lang_String_;
		public virtual unsafe string Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()Ljava/lang/String;", "GetGetCommandHandler")]
			get {
				if (id_getCommand == IntPtr.Zero)
					id_getCommand = JNIEnv.GetMethodID (class_ref, "getCommand", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommand), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommand", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='setCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCommand", "(Ljava/lang/String;)V", "GetSetCommand_Ljava_lang_String_Handler")]
			set {
				if (id_setCommand_Ljava_lang_String_ == IntPtr.Zero)
					id_setCommand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCommand", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCommand_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommand", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCommandArguments;
#pragma warning disable 0169
		static Delegate GetGetCommandArgumentsHandler ()
		{
			if (cb_getCommandArguments == null)
				cb_getCommandArguments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommandArguments);
			return cb_getCommandArguments;
		}

		static IntPtr n_GetCommandArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CommandArguments);
		}
#pragma warning restore 0169

		static Delegate cb_setCommandArguments_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCommandArguments_Ljava_util_List_Handler ()
		{
			if (cb_setCommandArguments_Ljava_util_List_ == null)
				cb_setCommandArguments_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommandArguments_Ljava_util_List_);
			return cb_setCommandArguments_Ljava_util_List_;
		}

		static void n_SetCommandArguments_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CommandArguments = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCommandArguments;
		static IntPtr id_setCommandArguments_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> CommandArguments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='getCommandArguments' and count(parameter)=0]"
			[Register ("getCommandArguments", "()Ljava/util/List;", "GetGetCommandArgumentsHandler")]
			get {
				if (id_getCommandArguments == IntPtr.Zero)
					id_getCommandArguments = JNIEnv.GetMethodID (class_ref, "getCommandArguments", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommandArguments), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandArguments", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='setCommandArguments' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setCommandArguments", "(Ljava/util/List;)V", "GetSetCommandArguments_Ljava_util_List_Handler")]
			set {
				if (id_setCommandArguments_Ljava_util_List_ == IntPtr.Zero)
					id_setCommandArguments_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setCommandArguments", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCommandArguments_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommandArguments", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reason);
		}
#pragma warning restore 0169

		static Delegate cb_setReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReason_Ljava_lang_String_ == null)
				cb_setReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReason_Ljava_lang_String_);
			return cb_setReason_Ljava_lang_String_;
		}

		static void n_SetReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reason = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReason;
		static IntPtr id_setReason_Ljava_lang_String_;
		public virtual unsafe string Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()Ljava/lang/String;", "GetGetReasonHandler")]
			get {
				if (id_getReason == IntPtr.Zero)
					id_getReason = JNIEnv.GetMethodID (class_ref, "getReason", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReason), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReason", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='setReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReason", "(Ljava/lang/String;)V", "GetSetReason_Ljava_lang_String_Handler")]
			set {
				if (id_setReason_Ljava_lang_String_ == IntPtr.Zero)
					id_setReason_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReason", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReason_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReason", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetResultCode);
			return cb_getResultCode;
		}

		static long n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultCode;
		}
#pragma warning restore 0169

		static Delegate cb_setResultCode_J;
#pragma warning disable 0169
		static Delegate GetSetResultCode_JHandler ()
		{
			if (cb_setResultCode_J == null)
				cb_setResultCode_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetResultCode_J);
			return cb_setResultCode_J;
		}

		static void n_SetResultCode_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.MiPushCommandMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResultCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		static IntPtr id_setResultCode_J;
		public virtual unsafe long ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()J", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getResultCode);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultCode", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='MiPushCommandMessage']/method[@name='setResultCode' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setResultCode", "(J)V", "GetSetResultCode_JHandler")]
			set {
				if (id_setResultCode_J == IntPtr.Zero)
					id_setResultCode_J = JNIEnv.GetMethodID (class_ref, "setResultCode", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResultCode_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultCode", "(J)V"), __args);
				} finally {
				}
			}
		}

	}
}

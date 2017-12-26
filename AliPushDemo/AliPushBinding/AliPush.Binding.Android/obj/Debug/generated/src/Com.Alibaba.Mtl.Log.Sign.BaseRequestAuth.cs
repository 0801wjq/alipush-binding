using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Log.Sign {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/log/sign/BaseRequestAuth", DoNotGenerateAcw=true)]
	public partial class BaseRequestAuth : global::Java.Lang.Object, global::Com.Alibaba.Mtl.Log.Sign.IRequestAuth {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/log/sign/BaseRequestAuth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRequestAuth); }
		}

		protected BaseRequestAuth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/constructor[@name='BaseRequestAuth' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseRequestAuth (string aAppkey, string aAppSecret)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aAppkey = JNIEnv.NewString (aAppkey);
			IntPtr native_aAppSecret = JNIEnv.NewString (aAppSecret);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aAppkey);
				__args [1] = new JValue (native_aAppSecret);
				if (((object) this).GetType () != typeof (BaseRequestAuth)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aAppkey);
				JNIEnv.DeleteLocalRef (native_aAppSecret);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/constructor[@name='BaseRequestAuth' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe BaseRequestAuth (string aAppkey, string aAppSecret, bool isEncode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aAppkey = JNIEnv.NewString (aAppkey);
			IntPtr native_aAppSecret = JNIEnv.NewString (aAppSecret);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_aAppkey);
				__args [1] = new JValue (native_aAppSecret);
				__args [2] = new JValue (isEncode);
				if (((object) this).GetType () != typeof (BaseRequestAuth)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aAppkey);
				JNIEnv.DeleteLocalRef (native_aAppSecret);
			}
		}

		static Delegate cb_getAppSecret;
#pragma warning disable 0169
		static Delegate GetGetAppSecretHandler ()
		{
			if (cb_getAppSecret == null)
				cb_getAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSecret);
			return cb_getAppSecret;
		}

		static IntPtr n_GetAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getAppSecret;
		public virtual unsafe string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppkey;
#pragma warning disable 0169
		static Delegate GetGetAppkeyHandler ()
		{
			if (cb_getAppkey == null)
				cb_getAppkey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppkey);
			return cb_getAppkey;
		}

		static IntPtr n_GetAppkey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppkey;
		public virtual unsafe string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler")]
			get {
				if (id_getAppkey == IntPtr.Zero)
					id_getAppkey = JNIEnv.GetMethodID (class_ref, "getAppkey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppkey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppkey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEncode;
#pragma warning disable 0169
		static Delegate GetIsEncodeHandler ()
		{
			if (cb_isEncode == null)
				cb_isEncode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEncode);
			return cb_isEncode;
		}

		static bool n_IsEncode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEncode;
		}
#pragma warning restore 0169

		static IntPtr id_isEncode;
		public virtual unsafe bool IsEncode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/method[@name='isEncode' and count(parameter)=0]"
			[Register ("isEncode", "()Z", "GetIsEncodeHandler")]
			get {
				if (id_isEncode == IntPtr.Zero)
					id_isEncode = JNIEnv.GetMethodID (class_ref, "isEncode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncode", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSign_Ljava_lang_String_Handler ()
		{
			if (cb_getSign_Ljava_lang_String_ == null)
				cb_getSign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSign_Ljava_lang_String_);
			return cb_getSign_Ljava_lang_String_;
		}

		static IntPtr n_GetSign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toBeSignedStr)
		{
			global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.BaseRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string toBeSignedStr = JNIEnv.GetString (native_toBeSignedStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSign (toBeSignedStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSign_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/class[@name='BaseRequestAuth']/method[@name='getSign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSign", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSign_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSign (string toBeSignedStr)
		{
			if (id_getSign_Ljava_lang_String_ == IntPtr.Zero)
				id_getSign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_toBeSignedStr = JNIEnv.NewString (toBeSignedStr);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_toBeSignedStr);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSign_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSign", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_toBeSignedStr);
			}
		}

	}
}

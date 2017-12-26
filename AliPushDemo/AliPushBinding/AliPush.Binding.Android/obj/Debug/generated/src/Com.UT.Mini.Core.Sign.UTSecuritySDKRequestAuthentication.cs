using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Core.Sign {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.core.sign']/class[@name='UTSecuritySDKRequestAuthentication']"
	[global::Android.Runtime.Register ("com/ut/mini/core/sign/UTSecuritySDKRequestAuthentication", DoNotGenerateAcw=true)]
	public partial class UTSecuritySDKRequestAuthentication : global::Java.Lang.Object, global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/core/sign/UTSecuritySDKRequestAuthentication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTSecuritySDKRequestAuthentication); }
		}

		protected UTSecuritySDKRequestAuthentication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.core.sign']/class[@name='UTSecuritySDKRequestAuthentication']/constructor[@name='UTSecuritySDKRequestAuthentication' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe UTSecuritySDKRequestAuthentication (string aAppkey, string authCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aAppkey = JNIEnv.NewString (aAppkey);
			IntPtr native_authCode = JNIEnv.NewString (authCode);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aAppkey);
				__args [1] = new JValue (native_authCode);
				if (((object) this).GetType () != typeof (UTSecuritySDKRequestAuthentication)) {
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
				JNIEnv.DeleteLocalRef (native_authCode);
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
			global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppkey;
		public virtual unsafe string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.sign']/class[@name='UTSecuritySDKRequestAuthentication']/method[@name='getAppkey' and count(parameter)=0]"
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

		static Delegate cb_getAuthCode;
#pragma warning disable 0169
		static Delegate GetGetAuthCodeHandler ()
		{
			if (cb_getAuthCode == null)
				cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
			return cb_getAuthCode;
		}

		static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.sign']/class[@name='UTSecuritySDKRequestAuthentication']/method[@name='getAuthCode' and count(parameter)=0]"
			[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
			get {
				if (id_getAuthCode == IntPtr.Zero)
					id_getAuthCode = JNIEnv.GetMethodID (class_ref, "getAuthCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Sign.UTSecuritySDKRequestAuthentication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string toBeSignedStr = JNIEnv.GetString (native_toBeSignedStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSign (toBeSignedStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSign_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.core.sign']/class[@name='UTSecuritySDKRequestAuthentication']/method[@name='getSign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

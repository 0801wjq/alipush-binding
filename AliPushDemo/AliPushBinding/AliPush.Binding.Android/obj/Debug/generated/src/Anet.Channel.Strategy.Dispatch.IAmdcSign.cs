using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Strategy.Dispatch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.strategy.dispatch']/interface[@name='IAmdcSign']"
	[Register ("anet/channel/strategy/dispatch/IAmdcSign", "", "Anet.Channel.Strategy.Dispatch.IAmdcSignInvoker")]
	public partial interface IAmdcSign : IJavaObject {

		string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/interface[@name='IAmdcSign']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler:Anet.Channel.Strategy.Dispatch.IAmdcSignInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/interface[@name='IAmdcSign']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/lang/String;)Ljava/lang/String;", "GetSign_Ljava_lang_String_Handler:Anet.Channel.Strategy.Dispatch.IAmdcSignInvoker, AliPush.Binding.Android")]
		string Sign (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/interface[@name='IAmdcSign']/method[@name='useSecurityGuard' and count(parameter)=0]"
		[Register ("useSecurityGuard", "()Z", "GetUseSecurityGuardHandler:Anet.Channel.Strategy.Dispatch.IAmdcSignInvoker, AliPush.Binding.Android")]
		bool UseSecurityGuard ();

	}

	[global::Android.Runtime.Register ("anet/channel/strategy/dispatch/IAmdcSign", DoNotGenerateAcw=true)]
	internal class IAmdcSignInvoker : global::Java.Lang.Object, IAmdcSign {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/strategy/dispatch/IAmdcSign");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAmdcSignInvoker); }
		}

		IntPtr class_ref;

		public static IAmdcSign GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmdcSign> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.strategy.dispatch.IAmdcSign"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmdcSignInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Anet.Channel.Strategy.Dispatch.IAmdcSign __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Dispatch.IAmdcSign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		IntPtr id_getAppkey;
		public unsafe string Appkey {
			get {
				if (id_getAppkey == IntPtr.Zero)
					id_getAppkey = JNIEnv.GetMethodID (class_ref, "getAppkey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppkey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_sign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Ljava_lang_String_ == null)
				cb_sign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_lang_String_);
			return cb_sign_Ljava_lang_String_;
		}

		static IntPtr n_Sign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Strategy.Dispatch.IAmdcSign __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Dispatch.IAmdcSign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Ljava_lang_String_;
		public unsafe string Sign (string p0)
		{
			if (id_sign_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sign_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_useSecurityGuard;
#pragma warning disable 0169
		static Delegate GetUseSecurityGuardHandler ()
		{
			if (cb_useSecurityGuard == null)
				cb_useSecurityGuard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseSecurityGuard);
			return cb_useSecurityGuard;
		}

		static bool n_UseSecurityGuard (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.Dispatch.IAmdcSign __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Dispatch.IAmdcSign> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSecurityGuard ();
		}
#pragma warning restore 0169

		IntPtr id_useSecurityGuard;
		public unsafe bool UseSecurityGuard ()
		{
			if (id_useSecurityGuard == IntPtr.Zero)
				id_useSecurityGuard = JNIEnv.GetMethodID (class_ref, "useSecurityGuard", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_useSecurityGuard);
		}

	}

}

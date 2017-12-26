using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel']/interface[@name='IAuth.AuthCallback']"
	[Register ("anet/channel/IAuth$AuthCallback", "", "Anet.Channel.IAuthAuthCallbackInvoker")]
	public partial interface IAuthAuthCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/interface[@name='IAuth.AuthCallback']/method[@name='onAuthFail' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAuthFail", "(ILjava/lang/String;)V", "GetOnAuthFail_ILjava_lang_String_Handler:Anet.Channel.IAuthAuthCallbackInvoker, AliPush.Binding.Android")]
		void OnAuthFail (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/interface[@name='IAuth.AuthCallback']/method[@name='onAuthSuccess' and count(parameter)=0]"
		[Register ("onAuthSuccess", "()V", "GetOnAuthSuccessHandler:Anet.Channel.IAuthAuthCallbackInvoker, AliPush.Binding.Android")]
		void OnAuthSuccess ();

	}

	[global::Android.Runtime.Register ("anet/channel/IAuth$AuthCallback", DoNotGenerateAcw=true)]
	internal class IAuthAuthCallbackInvoker : global::Java.Lang.Object, IAuthAuthCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/IAuth$AuthCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAuthAuthCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IAuthAuthCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthAuthCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.IAuth.AuthCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthAuthCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthFail_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthFail_ILjava_lang_String_Handler ()
		{
			if (cb_onAuthFail_ILjava_lang_String_ == null)
				cb_onAuthFail_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAuthFail_ILjava_lang_String_);
			return cb_onAuthFail_ILjava_lang_String_;
		}

		static void n_OnAuthFail_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Anet.Channel.IAuthAuthCallback __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.IAuthAuthCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthFail (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthFail_ILjava_lang_String_;
		public unsafe void OnAuthFail (int p0, string p1)
		{
			if (id_onAuthFail_ILjava_lang_String_ == IntPtr.Zero)
				id_onAuthFail_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthFail", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthFail_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAuthSuccess;
#pragma warning disable 0169
		static Delegate GetOnAuthSuccessHandler ()
		{
			if (cb_onAuthSuccess == null)
				cb_onAuthSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAuthSuccess);
			return cb_onAuthSuccess;
		}

		static void n_OnAuthSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.IAuthAuthCallback __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.IAuthAuthCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onAuthSuccess;
		public unsafe void OnAuthSuccess ()
		{
			if (id_onAuthSuccess == IntPtr.Zero)
				id_onAuthSuccess = JNIEnv.GetMethodID (class_ref, "onAuthSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthSuccess);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel']/interface[@name='IAuth']"
	[Register ("anet/channel/IAuth", "", "Anet.Channel.IAuthInvoker")]
	public partial interface IAuth : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/interface[@name='IAuth']/method[@name='auth' and count(parameter)=2 and parameter[1][@type='anet.channel.Session'] and parameter[2][@type='anet.channel.IAuth.AuthCallback']]"
		[Register ("auth", "(Lanet/channel/Session;Lanet/channel/IAuth$AuthCallback;)V", "GetAuth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_Handler:Anet.Channel.IAuthInvoker, AliPush.Binding.Android")]
		void Auth (global::Anet.Channel.Session p0, global::Anet.Channel.IAuthAuthCallback p1);

	}

	[global::Android.Runtime.Register ("anet/channel/IAuth", DoNotGenerateAcw=true)]
	internal class IAuthInvoker : global::Java.Lang.Object, IAuth {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/IAuth");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAuthInvoker); }
		}

		IntPtr class_ref;

		public static IAuth GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuth> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.IAuth"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_;
#pragma warning disable 0169
		static Delegate GetAuth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_Handler ()
		{
			if (cb_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_ == null)
				cb_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_);
			return cb_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_;
		}

		static void n_Auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anet.Channel.IAuth __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.IAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anet.Channel.Session p0 = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Anet.Channel.IAuthAuthCallback p1 = (global::Anet.Channel.IAuthAuthCallback)global::Java.Lang.Object.GetObject<global::Anet.Channel.IAuthAuthCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Auth (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_;
		public unsafe void Auth (global::Anet.Channel.Session p0, global::Anet.Channel.IAuthAuthCallback p1)
		{
			if (id_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_ == IntPtr.Zero)
				id_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_ = JNIEnv.GetMethodID (class_ref, "auth", "(Lanet/channel/Session;Lanet/channel/IAuth$AuthCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_auth_Lanet_channel_Session_Lanet_channel_IAuth_AuthCallback_, __args);
		}

	}

}

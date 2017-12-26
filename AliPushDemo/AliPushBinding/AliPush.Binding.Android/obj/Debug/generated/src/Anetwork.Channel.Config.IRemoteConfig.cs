using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.config']/interface[@name='IRemoteConfig']"
	[Register ("anetwork/channel/config/IRemoteConfig", "", "Anetwork.Channel.Config.IRemoteConfigInvoker")]
	public partial interface IRemoteConfig : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.config']/interface[@name='IRemoteConfig']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getConfig", "([Ljava/lang/String;)Ljava/lang/String;", "GetGetConfig_arrayLjava_lang_String_Handler:Anetwork.Channel.Config.IRemoteConfigInvoker, AliPush.Binding.Android")]
		string GetConfig (params  string[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.config']/interface[@name='IRemoteConfig']/method[@name='onConfigUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConfigUpdate", "(Ljava/lang/String;)V", "GetOnConfigUpdate_Ljava_lang_String_Handler:Anetwork.Channel.Config.IRemoteConfigInvoker, AliPush.Binding.Android")]
		void OnConfigUpdate (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.config']/interface[@name='IRemoteConfig']/method[@name='register' and count(parameter)=0]"
		[Register ("register", "()V", "GetRegisterHandler:Anetwork.Channel.Config.IRemoteConfigInvoker, AliPush.Binding.Android")]
		void Register ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.config']/interface[@name='IRemoteConfig']/method[@name='unRegister' and count(parameter)=0]"
		[Register ("unRegister", "()V", "GetUnRegisterHandler:Anetwork.Channel.Config.IRemoteConfigInvoker, AliPush.Binding.Android")]
		void UnRegister ();

	}

	[global::Android.Runtime.Register ("anetwork/channel/config/IRemoteConfig", DoNotGenerateAcw=true)]
	internal class IRemoteConfigInvoker : global::Java.Lang.Object, IRemoteConfig {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/config/IRemoteConfig");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRemoteConfigInvoker); }
		}

		IntPtr class_ref;

		public static IRemoteConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteConfig> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.config.IRemoteConfig"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getConfig_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConfig_arrayLjava_lang_String_Handler ()
		{
			if (cb_getConfig_arrayLjava_lang_String_ == null)
				cb_getConfig_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfig_arrayLjava_lang_String_);
			return cb_getConfig_arrayLjava_lang_String_;
		}

		static IntPtr n_GetConfig_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.Config.IRemoteConfig __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Config.IRemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.GetConfig (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConfig_arrayLjava_lang_String_;
		public unsafe string GetConfig (params  string[] p0)
		{
			if (id_getConfig_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getConfig_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConfig", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_onConfigUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConfigUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_onConfigUpdate_Ljava_lang_String_ == null)
				cb_onConfigUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigUpdate_Ljava_lang_String_);
			return cb_onConfigUpdate_Ljava_lang_String_;
		}

		static void n_OnConfigUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.Config.IRemoteConfig __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Config.IRemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConfigUpdate_Ljava_lang_String_;
		public unsafe void OnConfigUpdate (string p0)
		{
			if (id_onConfigUpdate_Ljava_lang_String_ == IntPtr.Zero)
				id_onConfigUpdate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConfigUpdate", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfigUpdate_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_register;
#pragma warning disable 0169
		static Delegate GetRegisterHandler ()
		{
			if (cb_register == null)
				cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
			return cb_register;
		}

		static void n_Register (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Config.IRemoteConfig __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Config.IRemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Register ();
		}
#pragma warning restore 0169

		IntPtr id_register;
		public unsafe void Register ()
		{
			if (id_register == IntPtr.Zero)
				id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register);
		}

		static Delegate cb_unRegister;
#pragma warning disable 0169
		static Delegate GetUnRegisterHandler ()
		{
			if (cb_unRegister == null)
				cb_unRegister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnRegister);
			return cb_unRegister;
		}

		static void n_UnRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Config.IRemoteConfig __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Config.IRemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnRegister ();
		}
#pragma warning restore 0169

		IntPtr id_unRegister;
		public unsafe void UnRegister ()
		{
			if (id_unRegister == IntPtr.Zero)
				id_unRegister = JNIEnv.GetMethodID (class_ref, "unRegister", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegister);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Security {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurityFactory']"
	[Register ("anet/channel/security/ISecurityFactory", "", "Anet.Channel.Security.ISecurityFactoryInvoker")]
	public partial interface ISecurityFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurityFactory']/method[@name='createNonSecurity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createNonSecurity", "(Ljava/lang/String;)Lanet/channel/security/ISecurity;", "GetCreateNonSecurity_Ljava_lang_String_Handler:Anet.Channel.Security.ISecurityFactoryInvoker, AliPush.Binding.Android")]
		global::Anet.Channel.Security.ISecurity CreateNonSecurity (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurityFactory']/method[@name='createSecurity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createSecurity", "(Ljava/lang/String;)Lanet/channel/security/ISecurity;", "GetCreateSecurity_Ljava_lang_String_Handler:Anet.Channel.Security.ISecurityFactoryInvoker, AliPush.Binding.Android")]
		global::Anet.Channel.Security.ISecurity CreateSecurity (string p0);

	}

	[global::Android.Runtime.Register ("anet/channel/security/ISecurityFactory", DoNotGenerateAcw=true)]
	internal class ISecurityFactoryInvoker : global::Java.Lang.Object, ISecurityFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/security/ISecurityFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISecurityFactoryInvoker); }
		}

		IntPtr class_ref;

		public static ISecurityFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISecurityFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.security.ISecurityFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISecurityFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNonSecurity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateNonSecurity_Ljava_lang_String_Handler ()
		{
			if (cb_createNonSecurity_Ljava_lang_String_ == null)
				cb_createNonSecurity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNonSecurity_Ljava_lang_String_);
			return cb_createNonSecurity_Ljava_lang_String_;
		}

		static IntPtr n_CreateNonSecurity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Security.ISecurityFactory __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurityFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateNonSecurity (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createNonSecurity_Ljava_lang_String_;
		public unsafe global::Anet.Channel.Security.ISecurity CreateNonSecurity (string p0)
		{
			if (id_createNonSecurity_Ljava_lang_String_ == IntPtr.Zero)
				id_createNonSecurity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createNonSecurity", "(Ljava/lang/String;)Lanet/channel/security/ISecurity;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Anet.Channel.Security.ISecurity __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createNonSecurity_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_createSecurity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSecurity_Ljava_lang_String_Handler ()
		{
			if (cb_createSecurity_Ljava_lang_String_ == null)
				cb_createSecurity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSecurity_Ljava_lang_String_);
			return cb_createSecurity_Ljava_lang_String_;
		}

		static IntPtr n_CreateSecurity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Security.ISecurityFactory __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurityFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSecurity (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createSecurity_Ljava_lang_String_;
		public unsafe global::Anet.Channel.Security.ISecurity CreateSecurity (string p0)
		{
			if (id_createSecurity_Ljava_lang_String_ == IntPtr.Zero)
				id_createSecurity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createSecurity", "(Ljava/lang/String;)Lanet/channel/security/ISecurity;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Anet.Channel.Security.ISecurity __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSecurity_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}

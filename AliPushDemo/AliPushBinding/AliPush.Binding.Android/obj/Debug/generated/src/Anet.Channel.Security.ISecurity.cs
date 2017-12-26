using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Security {

	[Register ("anet/channel/security/ISecurity", DoNotGenerateAcw=true)]
	public abstract class Security : Java.Lang.Object {

		internal Security ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/field[@name='CIPHER_ALGORITHM_AES128']"
		[Register ("CIPHER_ALGORITHM_AES128")]
		public const string CipherAlgorithmAes128 = (string) "ASE128";

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/field[@name='SIGN_ALGORITHM_HMAC_SHA1']"
		[Register ("SIGN_ALGORITHM_HMAC_SHA1")]
		public const string SignAlgorithmHmacSha1 = (string) "HMAC_SHA1";
	}

	[Register ("anet/channel/security/ISecurity", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Security' type. This type will be removed in a future release.")]
	public abstract class SecurityConsts : Security {

		private SecurityConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']"
	[Register ("anet/channel/security/ISecurity", "", "Anet.Channel.Security.ISecurityInvoker")]
	public partial interface ISecurity : IJavaObject {

		bool IsSecOff {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/method[@name='isSecOff' and count(parameter)=0]"
			[Register ("isSecOff", "()Z", "GetIsSecOffHandler:Anet.Channel.Security.ISecurityInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/method[@name='decrypt' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
		[Register ("decrypt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[B)[B", "GetDecrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Anet.Channel.Security.ISecurityInvoker, AliPush.Binding.Android")]
		byte[] Decrypt (global::Android.Content.Context p0, string p1, string p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/method[@name='getBytes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBytes", "(Landroid/content/Context;Ljava/lang/String;)[B", "GetGetBytes_Landroid_content_Context_Ljava_lang_String_Handler:Anet.Channel.Security.ISecurityInvoker, AliPush.Binding.Android")]
		byte[] GetBytes (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/method[@name='saveBytes' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("saveBytes", "(Landroid/content/Context;Ljava/lang/String;[B)Z", "GetSaveBytes_Landroid_content_Context_Ljava_lang_String_arrayBHandler:Anet.Channel.Security.ISecurityInvoker, AliPush.Binding.Android")]
		bool SaveBytes (global::Android.Content.Context p0, string p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.security']/interface[@name='ISecurity']/method[@name='sign' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sign", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Anet.Channel.Security.ISecurityInvoker, AliPush.Binding.Android")]
		string Sign (global::Android.Content.Context p0, string p1, string p2, string p3);

	}

	[global::Android.Runtime.Register ("anet/channel/security/ISecurity", DoNotGenerateAcw=true)]
	internal class ISecurityInvoker : global::Java.Lang.Object, ISecurity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/security/ISecurity");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISecurityInvoker); }
		}

		IntPtr class_ref;

		public static ISecurity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISecurity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.security.ISecurity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISecurityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isSecOff;
#pragma warning disable 0169
		static Delegate GetIsSecOffHandler ()
		{
			if (cb_isSecOff == null)
				cb_isSecOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSecOff);
			return cb_isSecOff;
		}

		static bool n_IsSecOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Security.ISecurity __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSecOff;
		}
#pragma warning restore 0169

		IntPtr id_isSecOff;
		public unsafe bool IsSecOff {
			get {
				if (id_isSecOff == IntPtr.Zero)
					id_isSecOff = JNIEnv.GetMethodID (class_ref, "isSecOff", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSecOff);
			}
		}

		static Delegate cb_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static IntPtr n_Decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Anet.Channel.Security.ISecurity __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0, p1, p2, p3));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB;
		public unsafe byte[] Decrypt (global::Android.Content.Context p0, string p1, string p2, byte[] p3)
		{
			if (id_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[B)[B");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_getBytes_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBytes_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getBytes_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getBytes_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBytes_Landroid_content_Context_Ljava_lang_String_);
			return cb_getBytes_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetBytes_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anet.Channel.Security.ISecurity __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBytes (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBytes_Landroid_content_Context_Ljava_lang_String_;
		public unsafe byte[] GetBytes (global::Android.Content.Context p0, string p1)
		{
			if (id_getBytes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBytes", "(Landroid/content/Context;Ljava/lang/String;)[B");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveBytes_Landroid_content_Context_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB == null)
				cb_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SaveBytes_Landroid_content_Context_Ljava_lang_String_arrayB);
			return cb_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB;
		}

		static bool n_SaveBytes_Landroid_content_Context_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Anet.Channel.Security.ISecurity __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SaveBytes (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB;
		public unsafe bool SaveBytes (global::Android.Content.Context p0, string p1, byte[] p2)
		{
			if (id_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "saveBytes", "(Landroid/content/Context;Ljava/lang/String;[B)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_saveBytes_Landroid_content_Context_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Anet.Channel.Security.ISecurity __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Security.ISecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string Sign (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sign_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

	}

}

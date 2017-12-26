using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/CipherUtil", DoNotGenerateAcw=true)]
	public partial class CipherUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/CipherUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CipherUtil); }
		}

		protected CipherUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/constructor[@name='CipherUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CipherUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CipherUtil)) {
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

		static IntPtr id_aesDecrypt_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/method[@name='aesDecrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("aesDecrypt", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] AesDecrypt (byte[] p0, string p1)
		{
			if (id_aesDecrypt_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_aesDecrypt_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "aesDecrypt", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_aesDecrypt_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_aesEncrypt_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/method[@name='aesEncrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("aesEncrypt", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] AesEncrypt (byte[] p0, string p1)
		{
			if (id_aesEncrypt_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_aesEncrypt_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "aesEncrypt", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_aesEncrypt_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_decodeDataWithAES_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/method[@name='decodeDataWithAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("decodeDataWithAES", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] DecodeDataWithAES (byte[] p0, string p1)
		{
			if (id_decodeDataWithAES_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_decodeDataWithAES_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeDataWithAES", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeDataWithAES_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encodeDataWithAES_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/method[@name='encodeDataWithAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeDataWithAES", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] EncodeDataWithAES (byte[] p0, string p1)
		{
			if (id_encodeDataWithAES_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_encodeDataWithAES_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeDataWithAES", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeDataWithAES_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_rsaEncrypt_arrayBLjava_security_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='CipherUtil']/method[@name='rsaEncrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.security.Key']]"
		[Register ("rsaEncrypt", "([BLjava/security/Key;)[B", "")]
		public static unsafe byte[] RsaEncrypt (byte[] p0, global::Java.Security.IKey p1)
		{
			if (id_rsaEncrypt_arrayBLjava_security_Key_ == IntPtr.Zero)
				id_rsaEncrypt_arrayBLjava_security_Key_ = JNIEnv.GetStaticMethodID (class_ref, "rsaEncrypt", "([BLjava/security/Key;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_rsaEncrypt_arrayBLjava_security_Key_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}

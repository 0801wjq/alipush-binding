using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HexUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/HexUtil", DoNotGenerateAcw=true)]
	public partial class HexUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/HexUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HexUtil); }
		}

		protected HexUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HexUtil']/constructor[@name='HexUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HexUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HexUtil)) {
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

		static IntPtr id_bytesToHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HexUtil']/method[@name='bytesToHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToHexString", "([B)Ljava/lang/String;", "")]
		public static unsafe string BytesToHexString (byte[] p0)
		{
			if (id_bytesToHexString_arrayB == IntPtr.Zero)
				id_bytesToHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "bytesToHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bytesToHexString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_generateSeedKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HexUtil']/method[@name='generateSeedKey' and count(parameter)=0]"
		[Register ("generateSeedKey", "()[B", "")]
		public static unsafe byte[] GenerateSeedKey ()
		{
			if (id_generateSeedKey == IntPtr.Zero)
				id_generateSeedKey = JNIEnv.GetStaticMethodID (class_ref, "generateSeedKey", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateSeedKey), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_hexStringToByte_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='HexUtil']/method[@name='hexStringToByte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToByte", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexStringToByte (string p0)
		{
			if (id_hexStringToByte_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToByte_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToByte", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToByte_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

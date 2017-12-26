using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/Md5Util", DoNotGenerateAcw=true)]
	public partial class Md5Util : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/Md5Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Md5Util); }
		}

		protected Md5Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/alibaba/sdk/android/ams/common/util/Md5Util;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/alibaba/sdk/android/ams/common/util/Md5Util;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_b2iu_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='b2iu' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("b2iu", "(B)J", "")]
		public static unsafe long B2iu (sbyte p0)
		{
			if (id_b2iu_B == IntPtr.Zero)
				id_b2iu_B = JNIEnv.GetStaticMethodID (class_ref, "b2iu", "(B)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_b2iu_B, __args);
			} finally {
			}
		}

		static IntPtr id_byteHEX_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='byteHEX' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("byteHEX", "(B)Ljava/lang/String;", "")]
		public static unsafe string ByteHEX (sbyte p0)
		{
			if (id_byteHEX_B == IntPtr.Zero)
				id_byteHEX_B = JNIEnv.GetStaticMethodID (class_ref, "byteHEX", "(B)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteHEX_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_bytesToHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='bytesToHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static Delegate cb_md5_16_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMd5_16_Ljava_lang_String_Handler ()
		{
			if (cb_md5_16_Ljava_lang_String_ == null)
				cb_md5_16_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Md5_16_Ljava_lang_String_);
			return cb_md5_16_Ljava_lang_String_;
		}

		static IntPtr n_Md5_16_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Md5_16 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_md5_16_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='md5_16' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5_16", "(Ljava/lang/String;)Ljava/lang/String;", "GetMd5_16_Ljava_lang_String_Handler")]
		public virtual unsafe string Md5_16 (string p0)
		{
			if (id_md5_16_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_16_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "md5_16", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_md5_16_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "md5_16", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_md5_32_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMd5_32_Ljava_lang_String_Handler ()
		{
			if (cb_md5_32_Ljava_lang_String_ == null)
				cb_md5_32_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Md5_32_Ljava_lang_String_);
			return cb_md5_32_Ljava_lang_String_;
		}

		static IntPtr n_Md5_32_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Md5_32 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_md5_32_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='md5_32' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5_32", "(Ljava/lang/String;)Ljava/lang/String;", "GetMd5_32_Ljava_lang_String_Handler")]
		public virtual unsafe string Md5_32 (string p0)
		{
			if (id_md5_32_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_32_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "md5_32", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_md5_32_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "md5_32", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_md5_32_system_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMd5_32_system_Ljava_lang_String_Handler ()
		{
			if (cb_md5_32_system_Ljava_lang_String_ == null)
				cb_md5_32_system_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Md5_32_system_Ljava_lang_String_);
			return cb_md5_32_system_Ljava_lang_String_;
		}

		static IntPtr n_Md5_32_system_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Md5_32_system (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_md5_32_system_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='md5_32_system' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5_32_system", "(Ljava/lang/String;)Ljava/lang/String;", "GetMd5_32_system_Ljava_lang_String_Handler")]
		public virtual unsafe string Md5_32_system (string p0)
		{
			if (id_md5_32_system_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_32_system_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "md5_32_system", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_md5_32_system_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "md5_32_system", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_md5_8_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMd5_8_Ljava_lang_String_Handler ()
		{
			if (cb_md5_8_Ljava_lang_String_ == null)
				cb_md5_8_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Md5_8_Ljava_lang_String_);
			return cb_md5_8_Ljava_lang_String_;
		}

		static IntPtr n_Md5_8_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Util.Md5Util> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Md5_8 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_md5_8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='md5_8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5_8", "(Ljava/lang/String;)Ljava/lang/String;", "GetMd5_8_Ljava_lang_String_Handler")]
		public virtual unsafe string Md5_8 (string p0)
		{
			if (id_md5_8_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_8_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "md5_8", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_md5_8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "md5_8", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='toLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLong", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToLong (string p0)
		{
			if (id_toLong_Ljava_lang_String_ == IntPtr.Zero)
				id_toLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toLong", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLong_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toShort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='toShort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toShort", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToShort (string p0)
		{
			if (id_toShort_Ljava_lang_String_ == IntPtr.Zero)
				id_toShort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toShort", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toShort_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toUltrashort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='Md5Util']/method[@name='toUltrashort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toUltrashort", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToUltrashort (string p0)
		{
			if (id_toUltrashort_Ljava_lang_String_ == IntPtr.Zero)
				id_toUltrashort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toUltrashort", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toUltrashort_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/global/VIPErrorEnum", DoNotGenerateAcw=true)]
	public sealed partial class VIPErrorEnum : global::Java.Lang.Enum {


		static IntPtr ALIAS_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='ALIAS_ERROR']"
		[Register ("ALIAS_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum AliasError {
			get {
				if (ALIAS_ERROR_jfieldId == IntPtr.Zero)
					ALIAS_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIAS_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIAS_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTION_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='CONNECTION_FAIL']"
		[Register ("CONNECTION_FAIL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum ConnectionFail {
			get {
				if (CONNECTION_FAIL_jfieldId == IntPtr.Zero)
					CONNECTION_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_FAIL", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_PARAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='INVALID_PARAM']"
		[Register ("INVALID_PARAM")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum InvalidParam {
			get {
				if (INVALID_PARAM_jfieldId == IntPtr.Zero)
					INVALID_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_PARAM", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_PARAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='IO_ERROR']"
		[Register ("IO_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum IoError {
			get {
				if (IO_ERROR_jfieldId == IntPtr.Zero)
					IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MISSING_PARAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='MISSING_PARAM']"
		[Register ("MISSING_PARAM")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum MissingParam {
			get {
				if (MISSING_PARAM_jfieldId == IntPtr.Zero)
					MISSING_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISSING_PARAM", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MISSING_PARAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='OK']"
		[Register ("OK")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum Ok {
			get {
				if (OK_jfieldId == IntPtr.Zero)
					OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REPONSE_PARSE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='REPONSE_PARSE_ERROR']"
		[Register ("REPONSE_PARSE_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum ReponseParseError {
			get {
				if (REPONSE_PARSE_ERROR_jfieldId == IntPtr.Zero)
					REPONSE_PARSE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPONSE_PARSE_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPONSE_PARSE_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIGN_NOT_MATCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='SIGN_NOT_MATCH']"
		[Register ("SIGN_NOT_MATCH")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum SignNotMatch {
			get {
				if (SIGN_NOT_MATCH_jfieldId == IntPtr.Zero)
					SIGN_NOT_MATCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGN_NOT_MATCH", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGN_NOT_MATCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SYSTEM_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='SYSTEM_ERROR']"
		[Register ("SYSTEM_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum SystemError {
			get {
				if (SYSTEM_ERROR_jfieldId == IntPtr.Zero)
					SYSTEM_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAG_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='TAG_ERROR']"
		[Register ("TAG_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum TagError {
			get {
				if (TAG_ERROR_jfieldId == IntPtr.Zero)
					TAG_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum UnknownError {
			get {
				if (UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
					UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_ERROR", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIP_BIND_AGOO_EXCEPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='VIP_BIND_AGOO_EXCEPTION']"
		[Register ("VIP_BIND_AGOO_EXCEPTION")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum VipBindAgooException {
			get {
				if (VIP_BIND_AGOO_EXCEPTION_jfieldId == IntPtr.Zero)
					VIP_BIND_AGOO_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIP_BIND_AGOO_EXCEPTION", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIP_BIND_AGOO_EXCEPTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIP_UNBIND_AGOO_EXCEPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/field[@name='VIP_UNBIND_AGOO_EXCEPTION']"
		[Register ("VIP_UNBIND_AGOO_EXCEPTION")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum VipUnbindAgooException {
			get {
				if (VIP_UNBIND_AGOO_EXCEPTION_jfieldId == IntPtr.Zero)
					VIP_UNBIND_AGOO_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIP_UNBIND_AGOO_EXCEPTION", "Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIP_UNBIND_AGOO_EXCEPTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/global/VIPErrorEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VIPErrorEnum); }
		}

		internal VIPErrorEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorCode;
		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorMessage;
		public unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='VIPErrorEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/global/VIPErrorEnum;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Global.VIPErrorEnum));
			} finally {
			}
		}

	}
}

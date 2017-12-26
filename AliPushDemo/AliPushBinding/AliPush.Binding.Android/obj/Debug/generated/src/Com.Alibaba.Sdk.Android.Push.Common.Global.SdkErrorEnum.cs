using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/global/SdkErrorEnum", DoNotGenerateAcw=true)]
	public sealed partial class SdkErrorEnum : global::Java.Lang.Enum {


		static IntPtr API_INVAILD_INPUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='API_INVAILD_INPUT']"
		[Register ("API_INVAILD_INPUT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum ApiInvaildInput {
			get {
				if (API_INVAILD_INPUT_jfieldId == IntPtr.Zero)
					API_INVAILD_INPUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_INVAILD_INPUT", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_INVAILD_INPUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr APP_VERSION_INVALID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='APP_VERSION_INVALID']"
		[Register ("APP_VERSION_INVALID")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum AppVersionInvalid {
			get {
				if (APP_VERSION_INVALID_jfieldId == IntPtr.Zero)
					APP_VERSION_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VERSION_INVALID", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_VERSION_INVALID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHANNEL_PROCESS_CONFIG_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='CHANNEL_PROCESS_CONFIG_ERROR']"
		[Register ("CHANNEL_PROCESS_CONFIG_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum ChannelProcessConfigError {
			get {
				if (CHANNEL_PROCESS_CONFIG_ERROR_jfieldId == IntPtr.Zero)
					CHANNEL_PROCESS_CONFIG_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_PROCESS_CONFIG_ERROR", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNEL_PROCESS_CONFIG_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHANNEL_PROCESS_NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='CHANNEL_PROCESS_NULL']"
		[Register ("CHANNEL_PROCESS_NULL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum ChannelProcessNull {
			get {
				if (CHANNEL_PROCESS_NULL_jfieldId == IntPtr.Zero)
					CHANNEL_PROCESS_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_PROCESS_NULL", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNEL_PROCESS_NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTION_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='CONNECTION_FAIL']"
		[Register ("CONNECTION_FAIL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum ConnectionFail {
			get {
				if (CONNECTION_FAIL_jfieldId == IntPtr.Zero)
					CONNECTION_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_FAIL", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REQUIRED_COMPONENT_NOT_EXISTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='REQUIRED_COMPONENT_NOT_EXISTS']"
		[Register ("REQUIRED_COMPONENT_NOT_EXISTS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum RequiredComponentNotExists {
			get {
				if (REQUIRED_COMPONENT_NOT_EXISTS_jfieldId == IntPtr.Zero)
					REQUIRED_COMPONENT_NOT_EXISTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUIRED_COMPONENT_NOT_EXISTS", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUIRED_COMPONENT_NOT_EXISTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/global/SdkErrorEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SdkErrorEnum); }
		}

		internal SdkErrorEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorCode;
		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/method[@name='getErrorCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/method[@name='getErrorMessage' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='SdkErrorEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/global/SdkErrorEnum;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Global.SdkErrorEnum));
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum", DoNotGenerateAcw=true)]
	public sealed partial class AccsErrorCodeEnum : global::Java.Lang.Enum {


		static IntPtr ACCS_APPKEY_NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_APPKEY_NULL']"
		[Register ("ACCS_APPKEY_NULL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsAppkeyNull {
			get {
				if (ACCS_APPKEY_NULL_jfieldId == IntPtr.Zero)
					ACCS_APPKEY_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_APPKEY_NULL", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_APPKEY_NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_APPRECEIVER_NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_APPRECEIVER_NULL']"
		[Register ("ACCS_APPRECEIVER_NULL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsAppreceiverNull {
			get {
				if (ACCS_APPRECEIVER_NULL_jfieldId == IntPtr.Zero)
					ACCS_APPRECEIVER_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_APPRECEIVER_NULL", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_APPRECEIVER_NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_APPSECRET_NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_APPSECRET_NULL']"
		[Register ("ACCS_APPSECRET_NULL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsAppsecretNull {
			get {
				if (ACCS_APPSECRET_NULL_jfieldId == IntPtr.Zero)
					ACCS_APPSECRET_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_APPSECRET_NULL", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_APPSECRET_NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_CHANNEL_INIT_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_CHANNEL_INIT_FAIL']"
		[Register ("ACCS_CHANNEL_INIT_FAIL")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsChannelInitFail {
			get {
				if (ACCS_CHANNEL_INIT_FAIL_jfieldId == IntPtr.Zero)
					ACCS_CHANNEL_INIT_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_CHANNEL_INIT_FAIL", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_CHANNEL_INIT_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_CONN_INVALID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_CONN_INVALID']"
		[Register ("ACCS_CONN_INVALID")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsConnInvalid {
			get {
				if (ACCS_CONN_INVALID_jfieldId == IntPtr.Zero)
					ACCS_CONN_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_CONN_INVALID", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_CONN_INVALID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_INVALID_DEVICEID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_INVALID_DEVICEID']"
		[Register ("ACCS_INVALID_DEVICEID")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsInvalidDeviceid {
			get {
				if (ACCS_INVALID_DEVICEID_jfieldId == IntPtr.Zero)
					ACCS_INVALID_DEVICEID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_INVALID_DEVICEID", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_INVALID_DEVICEID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_INVALID_PACKAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_INVALID_PACKAGE']"
		[Register ("ACCS_INVALID_PACKAGE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsInvalidPackage {
			get {
				if (ACCS_INVALID_PACKAGE_jfieldId == IntPtr.Zero)
					ACCS_INVALID_PACKAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_INVALID_PACKAGE", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_INVALID_PACKAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_NO_CONNECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_NO_CONNECTION']"
		[Register ("ACCS_NO_CONNECTION")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsNoConnection {
			get {
				if (ACCS_NO_CONNECTION_jfieldId == IntPtr.Zero)
					ACCS_NO_CONNECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_NO_CONNECTION", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_NO_CONNECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_NO_NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_NO_NETWORK']"
		[Register ("ACCS_NO_NETWORK")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsNoNetwork {
			get {
				if (ACCS_NO_NETWORK_jfieldId == IntPtr.Zero)
					ACCS_NO_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_NO_NETWORK", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_NO_NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_REG_TIME_OUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_REG_TIME_OUT']"
		[Register ("ACCS_REG_TIME_OUT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsRegTimeOut {
			get {
				if (ACCS_REG_TIME_OUT_jfieldId == IntPtr.Zero)
					ACCS_REG_TIME_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_REG_TIME_OUT", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_REG_TIME_OUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_TAIR_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_TAIR_ERROR']"
		[Register ("ACCS_TAIR_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsTairError {
			get {
				if (ACCS_TAIR_ERROR_jfieldId == IntPtr.Zero)
					ACCS_TAIR_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_TAIR_ERROR", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_TAIR_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCS_UNKNOWN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='ACCS_UNKNOWN_ERROR']"
		[Register ("ACCS_UNKNOWN_ERROR")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum AccsUnknownError {
			get {
				if (ACCS_UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
					ACCS_UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCS_UNKNOWN_ERROR", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCS_UNKNOWN_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REG_SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/field[@name='REG_SUCCESS']"
		[Register ("REG_SUCCESS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum RegSuccess {
			get {
				if (REG_SUCCESS_jfieldId == IntPtr.Zero)
					REG_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REG_SUCCESS", "Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REG_SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccsErrorCodeEnum); }
		}

		internal AccsErrorCodeEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorCode;
		public unsafe string ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorMessage;
		public unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/method[@name='getErrorMessage' and count(parameter)=0]"
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

		static IntPtr id_getState;
		public unsafe bool State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Z", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getState);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='AccsErrorCodeEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/global/AccsErrorCodeEnum;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Global.AccsErrorCodeEnum));
			} finally {
			}
		}

	}
}

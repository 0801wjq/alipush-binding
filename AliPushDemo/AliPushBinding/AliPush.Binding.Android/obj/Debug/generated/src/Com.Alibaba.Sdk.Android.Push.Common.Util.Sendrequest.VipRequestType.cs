using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType", DoNotGenerateAcw=true)]
	public sealed partial class VipRequestType : global::Java.Lang.Enum {


		static IntPtr BIND_ACCOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_ACCOUNT']"
		[Register ("BIND_ACCOUNT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindAccount {
			get {
				if (BIND_ACCOUNT_jfieldId == IntPtr.Zero)
					BIND_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_ACCOUNT", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_ACCOUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIND_ALIAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_ALIAS']"
		[Register ("BIND_ALIAS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindAlias {
			get {
				if (BIND_ALIAS_jfieldId == IntPtr.Zero)
					BIND_ALIAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_ALIAS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_ALIAS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIND_PHONE_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_PHONE_NUMBER']"
		[Register ("BIND_PHONE_NUMBER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindPhoneNumber {
			get {
				if (BIND_PHONE_NUMBER_jfieldId == IntPtr.Zero)
					BIND_PHONE_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_PHONE_NUMBER", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_PHONE_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIND_TAG_TO_ACCOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_TAG_TO_ACCOUNT']"
		[Register ("BIND_TAG_TO_ACCOUNT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindTagToAccount {
			get {
				if (BIND_TAG_TO_ACCOUNT_jfieldId == IntPtr.Zero)
					BIND_TAG_TO_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_TAG_TO_ACCOUNT", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_TAG_TO_ACCOUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIND_TAG_TO_ALIAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_TAG_TO_ALIAS']"
		[Register ("BIND_TAG_TO_ALIAS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindTagToAlias {
			get {
				if (BIND_TAG_TO_ALIAS_jfieldId == IntPtr.Zero)
					BIND_TAG_TO_ALIAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_TAG_TO_ALIAS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_TAG_TO_ALIAS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIND_TAG_TO_DEVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='BIND_TAG_TO_DEVICE']"
		[Register ("BIND_TAG_TO_DEVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType BindTagToDevice {
			get {
				if (BIND_TAG_TO_DEVICE_jfieldId == IntPtr.Zero)
					BIND_TAG_TO_DEVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIND_TAG_TO_DEVICE", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIND_TAG_TO_DEVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHECK_PUSH_STATUS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='CHECK_PUSH_STATUS']"
		[Register ("CHECK_PUSH_STATUS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType CheckPushStatus {
			get {
				if (CHECK_PUSH_STATUS_jfieldId == IntPtr.Zero)
					CHECK_PUSH_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_PUSH_STATUS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECK_PUSH_STATUS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONFIG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='CONFIG']"
		[Register ("CONFIG")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType Config {
			get {
				if (CONFIG_jfieldId == IntPtr.Zero)
					CONFIG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFIG", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFIG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Key_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='Key']"
		[Register ("Key")]
		public static string Key {
			get {
				if (Key_jfieldId == IntPtr.Zero)
					Key_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Key", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Key_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Key_jfieldId == IntPtr.Zero)
					Key_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Key", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, Key_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LIST_ALIASES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='LIST_ALIASES']"
		[Register ("LIST_ALIASES")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType ListAliases {
			get {
				if (LIST_ALIASES_jfieldId == IntPtr.Zero)
					LIST_ALIASES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIST_ALIASES", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIST_ALIASES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LIST_TAGS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='LIST_TAGS']"
		[Register ("LIST_TAGS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType ListTags {
			get {
				if (LIST_TAGS_jfieldId == IntPtr.Zero)
					LIST_TAGS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIST_TAGS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIST_TAGS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ON_APP_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='ON_APP_START']"
		[Register ("ON_APP_START")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType OnAppStart {
			get {
				if (ON_APP_START_jfieldId == IntPtr.Zero)
					ON_APP_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_APP_START", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_APP_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TURN_OFF_PUSH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='TURN_OFF_PUSH']"
		[Register ("TURN_OFF_PUSH")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType TurnOffPush {
			get {
				if (TURN_OFF_PUSH_jfieldId == IntPtr.Zero)
					TURN_OFF_PUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TURN_OFF_PUSH", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TURN_OFF_PUSH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TURN_ON_PUSH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='TURN_ON_PUSH']"
		[Register ("TURN_ON_PUSH")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType TurnOnPush {
			get {
				if (TURN_ON_PUSH_jfieldId == IntPtr.Zero)
					TURN_ON_PUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TURN_ON_PUSH", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TURN_ON_PUSH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_ACCOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_ACCOUNT']"
		[Register ("UNBIND_ACCOUNT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindAccount {
			get {
				if (UNBIND_ACCOUNT_jfieldId == IntPtr.Zero)
					UNBIND_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_ACCOUNT", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_ACCOUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_ALIAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_ALIAS']"
		[Register ("UNBIND_ALIAS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindAlias {
			get {
				if (UNBIND_ALIAS_jfieldId == IntPtr.Zero)
					UNBIND_ALIAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_ALIAS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_ALIAS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_PHONE_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_PHONE_NUMBER']"
		[Register ("UNBIND_PHONE_NUMBER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindPhoneNumber {
			get {
				if (UNBIND_PHONE_NUMBER_jfieldId == IntPtr.Zero)
					UNBIND_PHONE_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_PHONE_NUMBER", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_PHONE_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_TAG_TO_ACCOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_TAG_TO_ACCOUNT']"
		[Register ("UNBIND_TAG_TO_ACCOUNT")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindTagToAccount {
			get {
				if (UNBIND_TAG_TO_ACCOUNT_jfieldId == IntPtr.Zero)
					UNBIND_TAG_TO_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_TAG_TO_ACCOUNT", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_TAG_TO_ACCOUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_TAG_TO_ALIAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_TAG_TO_ALIAS']"
		[Register ("UNBIND_TAG_TO_ALIAS")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindTagToAlias {
			get {
				if (UNBIND_TAG_TO_ALIAS_jfieldId == IntPtr.Zero)
					UNBIND_TAG_TO_ALIAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_TAG_TO_ALIAS", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_TAG_TO_ALIAS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBIND_TAG_TO_DEVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNBIND_TAG_TO_DEVICE']"
		[Register ("UNBIND_TAG_TO_DEVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnbindTagToDevice {
			get {
				if (UNBIND_TAG_TO_DEVICE_jfieldId == IntPtr.Zero)
					UNBIND_TAG_TO_DEVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBIND_TAG_TO_DEVICE", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBIND_TAG_TO_DEVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/field[@name='UNKNOWN_TYPE']"
		[Register ("UNKNOWN_TYPE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType UnknownType {
			get {
				if (UNKNOWN_TYPE_jfieldId == IntPtr.Zero)
					UNKNOWN_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_TYPE", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VipRequestType); }
		}

		internal VipRequestType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBoundaryCode;
		public static unsafe int BoundaryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/method[@name='getBoundaryCode' and count(parameter)=0]"
			[Register ("getBoundaryCode", "()I", "GetGetBoundaryCodeHandler")]
			get {
				if (id_getBoundaryCode == IntPtr.Zero)
					id_getBoundaryCode = JNIEnv.GetStaticMethodID (class_ref, "getBoundaryCode", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getBoundaryCode);
				} finally {
				}
			}
		}

		static IntPtr id_getCode;
		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='VipRequestType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType));
			} finally {
			}
		}

	}
}

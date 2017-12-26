using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/global/ComponentEnum", DoNotGenerateAcw=true)]
	public sealed partial class ComponentEnum : global::Java.Lang.Enum {


		static IntPtr AGOO_COMMAND_RECEIVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='AGOO_COMMAND_RECEIVER']"
		[Register ("AGOO_COMMAND_RECEIVER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum AgooCommandReceiver {
			get {
				if (AGOO_COMMAND_RECEIVER_jfieldId == IntPtr.Zero)
					AGOO_COMMAND_RECEIVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGOO_COMMAND_RECEIVER", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGOO_COMMAND_RECEIVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AGOO_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='AGOO_SERVICE']"
		[Register ("AGOO_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum AgooService {
			get {
				if (AGOO_SERVICE_jfieldId == IntPtr.Zero)
					AGOO_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGOO_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGOO_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ALIYUN_PUSH_INTENT_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='ALIYUN_PUSH_INTENT_SERVICE']"
		[Register ("ALIYUN_PUSH_INTENT_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum AliyunPushIntentService {
			get {
				if (ALIYUN_PUSH_INTENT_SERVICE_jfieldId == IntPtr.Zero)
					ALIYUN_PUSH_INTENT_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIYUN_PUSH_INTENT_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIYUN_PUSH_INTENT_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHANNEL_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='CHANNEL_SERVICE']"
		[Register ("CHANNEL_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum ChannelService {
			get {
				if (CHANNEL_SERVICE_jfieldId == IntPtr.Zero)
					CHANNEL_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNEL_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHECK_CHANNEL_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='CHECK_CHANNEL_SERVICE']"
		[Register ("CHECK_CHANNEL_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum CheckChannelService {
			get {
				if (CHECK_CHANNEL_SERVICE_jfieldId == IntPtr.Zero)
					CHECK_CHANNEL_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_CHANNEL_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECK_CHANNEL_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EVENT_RECEIVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='EVENT_RECEIVER']"
		[Register ("EVENT_RECEIVER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum EventReceiver {
			get {
				if (EVENT_RECEIVER_jfieldId == IntPtr.Zero)
					EVENT_RECEIVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_RECEIVER", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_RECEIVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr KERNEL_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='KERNEL_SERVICE']"
		[Register ("KERNEL_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum KernelService {
			get {
				if (KERNEL_SERVICE_jfieldId == IntPtr.Zero)
					KERNEL_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KERNEL_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KERNEL_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MSG_DISTRIBUTE_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='MSG_DISTRIBUTE_SERVICE']"
		[Register ("MSG_DISTRIBUTE_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum MsgDistributeService {
			get {
				if (MSG_DISTRIBUTE_SERVICE_jfieldId == IntPtr.Zero)
					MSG_DISTRIBUTE_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MSG_DISTRIBUTE_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MSG_DISTRIBUTE_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MSG_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='MSG_SERVICE']"
		[Register ("MSG_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum MsgService {
			get {
				if (MSG_SERVICE_jfieldId == IntPtr.Zero)
					MSG_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MSG_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MSG_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PUSH_EXT_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='PUSH_EXT_ACTIVITY']"
		[Register ("PUSH_EXT_ACTIVITY")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum PushExtActivity {
			get {
				if (PUSH_EXT_ACTIVITY_jfieldId == IntPtr.Zero)
					PUSH_EXT_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSH_EXT_ACTIVITY", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUSH_EXT_ACTIVITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SERVICE_RECEIVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='SERVICE_RECEIVER']"
		[Register ("SERVICE_RECEIVER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum ServiceReceiver {
			get {
				if (SERVICE_RECEIVER_jfieldId == IntPtr.Zero)
					SERVICE_RECEIVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_RECEIVER", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_RECEIVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SYSTEM_EVENT_RECEIVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='SYSTEM_EVENT_RECEIVER']"
		[Register ("SYSTEM_EVENT_RECEIVER")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum SystemEventReceiver {
			get {
				if (SYSTEM_EVENT_RECEIVER_jfieldId == IntPtr.Zero)
					SYSTEM_EVENT_RECEIVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_EVENT_RECEIVER", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_EVENT_RECEIVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAOBAO_RECV_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/field[@name='TAOBAO_RECV_SERVICE']"
		[Register ("TAOBAO_RECV_SERVICE")]
		public static global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum TaobaoRecvService {
			get {
				if (TAOBAO_RECV_SERVICE_jfieldId == IntPtr.Zero)
					TAOBAO_RECV_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAOBAO_RECV_SERVICE", "Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAOBAO_RECV_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/global/ComponentEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComponentEnum); }
		}

		internal ComponentEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isRequired;
		public unsafe bool IsRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/method[@name='isRequired' and count(parameter)=0]"
			[Register ("isRequired", "()Z", "GetIsRequiredHandler")]
			get {
				if (id_isRequired == IntPtr.Zero)
					id_isRequired = JNIEnv.GetMethodID (class_ref, "isRequired", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRequired);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceName;
		public unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler")]
			get {
				if (id_getServiceName == IntPtr.Zero)
					id_getServiceName = JNIEnv.GetMethodID (class_ref, "getServiceName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getType;
		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.global']/class[@name='ComponentEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/global/ComponentEnum;");
			try {
				return (global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Global.ComponentEnum));
			} finally {
			}
		}

	}
}

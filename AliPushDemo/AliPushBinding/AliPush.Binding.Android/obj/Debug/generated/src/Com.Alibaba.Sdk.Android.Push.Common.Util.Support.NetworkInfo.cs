using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util.Support {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo", DoNotGenerateAcw=true)]
	public partial class NetworkInfo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP", DoNotGenerateAcw=true)]
		public sealed partial class NetworkSP : global::Java.Lang.Enum {


			static IntPtr CHINA_MOBILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/field[@name='CHINA_MOBILE']"
			[Register ("CHINA_MOBILE")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP ChinaMobile {
				get {
					if (CHINA_MOBILE_jfieldId == IntPtr.Zero)
						CHINA_MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHINA_MOBILE", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHINA_MOBILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHINA_TELECOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/field[@name='CHINA_TELECOM']"
			[Register ("CHINA_TELECOM")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP ChinaTelecom {
				get {
					if (CHINA_TELECOM_jfieldId == IntPtr.Zero)
						CHINA_TELECOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHINA_TELECOM", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHINA_TELECOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHINA_UNICOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/field[@name='CHINA_UNICOM']"
			[Register ("CHINA_UNICOM")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP ChinaUnicom {
				get {
					if (CHINA_UNICOM_jfieldId == IntPtr.Zero)
						CHINA_UNICOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHINA_UNICOM", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHINA_UNICOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkSP); }
			}

			internal NetworkSP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_code;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/method[@name='code' and count(parameter)=0]"
			[Register ("code", "()I", "")]
			public unsafe int Code ()
			{
				if (id_code == IntPtr.Zero)
					id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_code);
				} finally {
				}
			}

			static IntPtr id_from_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/method[@name='from' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("from", "(I)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP From (int p0)
			{
				if (id_from_I == IntPtr.Zero)
					id_from_I = JNIEnv.GetStaticMethodID (class_ref, "from", "(I)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_from_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkSP']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
				try {
					return (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType", DoNotGenerateAcw=true)]
		public sealed partial class NetworkType : global::Java.Lang.Enum {


			static IntPtr G2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/field[@name='G2']"
			[Register ("G2")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType G2 {
				get {
					if (G2_jfieldId == IntPtr.Zero)
						G2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G2", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/field[@name='G3']"
			[Register ("G3")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType G3 {
				get {
					if (G3_jfieldId == IntPtr.Zero)
						G3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G3", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/field[@name='G4']"
			[Register ("G4")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType G4 {
				get {
					if (G4_jfieldId == IntPtr.Zero)
						G4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G4", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkType); }
			}

			internal NetworkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_code;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/method[@name='code' and count(parameter)=0]"
			[Register ("code", "()I", "")]
			public unsafe int Code ()
			{
				if (id_code == IntPtr.Zero)
					id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_code);
				} finally {
				}
			}

			static IntPtr id_from_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/method[@name='from' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("from", "(I)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType From (int p0)
			{
				if (id_from_I == IntPtr.Zero)
					id_from_I = JNIEnv.GetStaticMethodID (class_ref, "from", "(I)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_from_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo.NetworkType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;", "")]
			public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
				try {
					return (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/support/NetworkInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkInfo); }
		}

		protected NetworkInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkSP_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo']/constructor[@name='NetworkInfo' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.push.common.util.support.NetworkInfo.NetworkSP'] and parameter[2][@type='com.alibaba.sdk.android.push.common.util.support.NetworkInfo.NetworkType']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;)V", "")]
		public unsafe NetworkInfo (global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP p0, global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (NetworkInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkSP_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkType_ == IntPtr.Zero)
					id_ctor_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkSP_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkSP_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkSP_Lcom_alibaba_sdk_android_push_common_util_support_NetworkInfo_NetworkType_, __args);
			} finally {
			}
		}

		static IntPtr id_fromByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo']/method[@name='fromByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("fromByte", "(B)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo FromByte (sbyte p0)
		{
			if (id_fromByte_B == IntPtr.Zero)
				id_fromByte_B = JNIEnv.GetStaticMethodID (class_ref, "fromByte", "(B)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromByte_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_ToByte);
			return cb_toByte;
		}

		static sbyte n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToByte ();
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.support']/class[@name='NetworkInfo']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()B", "GetToByteHandler")]
		public virtual unsafe sbyte ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_toByte);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByte", "()B"));
			} finally {
			}
		}

	}
}

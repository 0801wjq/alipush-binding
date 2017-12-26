using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/NetworkUtils", DoNotGenerateAcw=true)]
	public partial class NetworkUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/NetworkUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkUtils); }
		}

		protected NetworkUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/constructor[@name='NetworkUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NetworkUtils)) {
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

		static IntPtr id_getNetworkSP_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='getNetworkSP' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkSP", "(Landroid/content/Context;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP GetNetworkSP (global::Android.Content.Context p0)
		{
			if (id_getNetworkSP_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkSP_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkSP", "(Landroid/content/Context;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkSP;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkSP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkSP_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNetworkType_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='getNetworkType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkType", "(Landroid/content/Context;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType GetNetworkType (global::Android.Content.Context p0)
		{
			if (id_getNetworkType_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkType_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkType", "(Landroid/content/Context;)Lcom/alibaba/sdk/android/push/common/util/support/NetworkInfo$NetworkType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Support.NetworkInfo.NetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkType_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_is2G_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='is2G' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("is2G", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool Is2G (global::Android.Content.Context p0)
		{
			if (id_is2G_Landroid_content_Context_ == IntPtr.Zero)
				id_is2G_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "is2G", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_is2G_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_is3G_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='is3G' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("is3G", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool Is3G (global::Android.Content.Context p0)
		{
			if (id_is3G_Landroid_content_Context_ == IntPtr.Zero)
				id_is3G_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "is3G", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_is3G_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_is4G_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='is4G' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("is4G", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool Is4G (global::Android.Content.Context p0)
		{
			if (id_is4G_Landroid_content_Context_ == IntPtr.Zero)
				id_is4G_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "is4G", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_is4G_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkAvailabe_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='isNetworkAvailabe' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailabe", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailabe (global::Android.Content.Context p0)
		{
			if (id_isNetworkAvailabe_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkAvailabe_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailabe", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailabe_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isUnknowNetwork_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='isUnknowNetwork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isUnknowNetwork", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsUnknowNetwork (global::Android.Content.Context p0)
		{
			if (id_isUnknowNetwork_Landroid_content_Context_ == IntPtr.Zero)
				id_isUnknowNetwork_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isUnknowNetwork", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUnknowNetwork_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isWifi_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='NetworkUtils']/method[@name='isWifi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isWifi", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsWifi (global::Android.Content.Context p0)
		{
			if (id_isWifi_Landroid_content_Context_ == IntPtr.Zero)
				id_isWifi_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isWifi", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWifi_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/AppInfoUtil", DoNotGenerateAcw=true)]
	public partial class AppInfoUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/field[@name='CHANNEL_SERVICE_PROCESS']"
		[Register ("CHANNEL_SERVICE_PROCESS")]
		public const int ChannelServiceProcess = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/AppInfoUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppInfoUtil); }
		}

		protected AppInfoUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/constructor[@name='AppInfoUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppInfoUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppInfoUtil)) {
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

		static IntPtr id_getAppVersionName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='getAppVersionName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersionName (global::Android.Content.Context p0)
		{
			if (id_getAppVersionName_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersionName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersionName_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getChannelServiceData_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='getChannelServiceData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getChannelServiceData", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetChannelServiceData (global::Android.Content.Context p0, int p1)
		{
			if (id_getChannelServiceData_Landroid_content_Context_I == IntPtr.Zero)
				id_getChannelServiceData_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getChannelServiceData", "(Landroid/content/Context;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannelServiceData_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProcessName_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='getProcessName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getProcessName", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetProcessName (global::Android.Content.Context p0, int p1)
		{
			if (id_getProcessName_Landroid_content_Context_I == IntPtr.Zero)
				id_getProcessName_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getProcessName", "(Landroid/content/Context;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProcessName_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isChannelProcess_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='isChannelProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isChannelProcess", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsChannelProcess (global::Android.Content.Context p0)
		{
			if (id_isChannelProcess_Landroid_content_Context_ == IntPtr.Zero)
				id_isChannelProcess_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isChannelProcess", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isChannelProcess_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isComponentExists_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='isComponentExists' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isComponentExists", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsComponentExists (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_isComponentExists_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isComponentExists_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isComponentExists", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isComponentExists_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_isMainProcess_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='isMainProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isMainProcess", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsMainProcess (global::Android.Content.Context p0)
		{
			if (id_isMainProcess_Landroid_content_Context_ == IntPtr.Zero)
				id_isMainProcess_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isMainProcess", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMainProcess_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isPermissionGranted_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util']/class[@name='AppInfoUtil']/method[@name='isPermissionGranted' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isPermissionGranted", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsPermissionGranted (global::Android.Content.Context p0, string p1)
		{
			if (id_isPermissionGranted_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_isPermissionGranted_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isPermissionGranted", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPermissionGranted_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/global/AmsGlobalSetter", DoNotGenerateAcw=true)]
	public partial class AmsGlobalSetter : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/global/AmsGlobalSetter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsGlobalSetter); }
		}

		protected AmsGlobalSetter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']/constructor[@name='AmsGlobalSetter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmsGlobalSetter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AmsGlobalSetter)) {
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

		static IntPtr id_setAndroidAppContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']/method[@name='setAndroidAppContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setAndroidAppContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetAndroidAppContext (global::Android.Content.Context p0)
		{
			if (id_setAndroidAppContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setAndroidAppContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setAndroidAppContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAndroidAppContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setAndroidApplication_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']/method[@name='setAndroidApplication' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("setAndroidApplication", "(Landroid/app/Application;)V", "")]
		public static unsafe void SetAndroidApplication (global::Android.App.Application p0)
		{
			if (id_setAndroidApplication_Landroid_app_Application_ == IntPtr.Zero)
				id_setAndroidApplication_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "setAndroidApplication", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAndroidApplication_Landroid_app_Application_, __args);
			} finally {
			}
		}

		static IntPtr id_setEnvironment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEnvironment", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetEnvironment (string p0)
		{
			if (id_setEnvironment_Ljava_lang_String_ == IntPtr.Zero)
				id_setEnvironment_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setEnvironment", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnvironment_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setPlatform_Lcom_alibaba_sdk_android_ams_common_AmsPlatform_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalSetter']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.ams.common.AmsPlatform']]"
		[Register ("setPlatform", "(Lcom/alibaba/sdk/android/ams/common/AmsPlatform;)V", "")]
		public static unsafe void SetPlatform (global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform p0)
		{
			if (id_setPlatform_Lcom_alibaba_sdk_android_ams_common_AmsPlatform_ == IntPtr.Zero)
				id_setPlatform_Lcom_alibaba_sdk_android_ams_common_AmsPlatform_ = JNIEnv.GetStaticMethodID (class_ref, "setPlatform", "(Lcom/alibaba/sdk/android/ams/common/AmsPlatform;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPlatform_Lcom_alibaba_sdk_android_ams_common_AmsPlatform_, __args);
			} finally {
			}
		}

	}
}

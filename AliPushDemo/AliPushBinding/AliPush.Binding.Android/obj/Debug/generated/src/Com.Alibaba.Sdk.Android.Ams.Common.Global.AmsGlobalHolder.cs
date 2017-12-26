using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Global {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/global/AmsGlobalHolder", DoNotGenerateAcw=true)]
	public partial class AmsGlobalHolder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/global/AmsGlobalHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsGlobalHolder); }
		}

		protected AmsGlobalHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/constructor[@name='AmsGlobalHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmsGlobalHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AmsGlobalHolder)) {
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

		static IntPtr id_getAndroidAppContext;
		public static unsafe global::Android.Content.Context AndroidAppContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getAndroidAppContext' and count(parameter)=0]"
			[Register ("getAndroidAppContext", "()Landroid/content/Context;", "GetGetAndroidAppContextHandler")]
			get {
				if (id_getAndroidAppContext == IntPtr.Zero)
					id_getAndroidAppContext = JNIEnv.GetStaticMethodID (class_ref, "getAndroidAppContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAndroidAppContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAndroidApplication;
		public static unsafe global::Android.App.Application AndroidApplication {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getAndroidApplication' and count(parameter)=0]"
			[Register ("getAndroidApplication", "()Landroid/app/Application;", "GetGetAndroidApplicationHandler")]
			get {
				if (id_getAndroidApplication == IntPtr.Zero)
					id_getAndroidApplication = JNIEnv.GetStaticMethodID (class_ref, "getAndroidApplication", "()Landroid/app/Application;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.Application> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAndroidApplication), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConfigUrl;
		public static unsafe string ConfigUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getConfigUrl' and count(parameter)=0]"
			[Register ("getConfigUrl", "()Ljava/lang/String;", "GetGetConfigUrlHandler")]
			get {
				if (id_getConfigUrl == IntPtr.Zero)
					id_getConfigUrl = JNIEnv.GetStaticMethodID (class_ref, "getConfigUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConfigUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDefaultSharedPreferences;
		public static unsafe global::Android.Content.ISharedPreferences DefaultSharedPreferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getDefaultSharedPreferences' and count(parameter)=0]"
			[Register ("getDefaultSharedPreferences", "()Landroid/content/SharedPreferences;", "GetGetDefaultSharedPreferencesHandler")]
			get {
				if (id_getDefaultSharedPreferences == IntPtr.Zero)
					id_getDefaultSharedPreferences = JNIEnv.GetStaticMethodID (class_ref, "getDefaultSharedPreferences", "()Landroid/content/SharedPreferences;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultSharedPreferences), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEnvironment;
		static IntPtr id_setEnvironment_Lcom_alibaba_sdk_android_ams_common_AmsEnv_;
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Lcom/alibaba/sdk/android/ams/common/AmsEnv;", "GetGetEnvironmentHandler")]
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetStaticMethodID (class_ref, "getEnvironment", "()Lcom/alibaba/sdk/android/ams/common/AmsEnv;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsEnv> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnvironment), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.ams.common.AmsEnv']]"
			[Register ("setEnvironment", "(Lcom/alibaba/sdk/android/ams/common/AmsEnv;)V", "GetSetEnvironment_Lcom_alibaba_sdk_android_ams_common_AmsEnv_Handler")]
			set {
				if (id_setEnvironment_Lcom_alibaba_sdk_android_ams_common_AmsEnv_ == IntPtr.Zero)
					id_setEnvironment_Lcom_alibaba_sdk_android_ams_common_AmsEnv_ = JNIEnv.GetStaticMethodID (class_ref, "setEnvironment", "(Lcom/alibaba/sdk/android/ams/common/AmsEnv;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnvironment_Lcom_alibaba_sdk_android_ams_common_AmsEnv_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPackageName;
		public static unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPlatform;
		public static unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lcom/alibaba/sdk/android/ams/common/AmsPlatform;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetStaticMethodID (class_ref, "getPlatform", "()Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPlatform), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVipHost;
		public static unsafe string VipHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getVipHost' and count(parameter)=0]"
			[Register ("getVipHost", "()Ljava/lang/String;", "GetGetVipHostHandler")]
			get {
				if (id_getVipHost == IntPtr.Zero)
					id_getVipHost = JNIEnv.GetStaticMethodID (class_ref, "getVipHost", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVipHost), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppMetaData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.global']/class[@name='AmsGlobalHolder']/method[@name='getAppMetaData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAppMetaData", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAppMetaData (string p0)
		{
			if (id_getAppMetaData_Ljava_lang_String_ == IntPtr.Zero)
				id_getAppMetaData_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAppMetaData", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppMetaData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/util/FileUtil", DoNotGenerateAcw=true)]
	public partial class FileUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/field[@name='SDK_CACHE_PATH']"
		[Register ("SDK_CACHE_PATH")]
		public const string SdkCachePath = (string) "aliCloud";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/util/FileUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtil); }
		}

		protected FileUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/constructor[@name='FileUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FileUtil)) {
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

		static IntPtr id_isCanUseSDCard;
		public static unsafe bool IsCanUseSDCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='isCanUseSDCard' and count(parameter)=0]"
			[Register ("isCanUseSDCard", "()Z", "GetIsCanUseSDCardHandler")]
			get {
				if (id_isCanUseSDCard == IntPtr.Zero)
					id_isCanUseSDCard = JNIEnv.GetStaticMethodID (class_ref, "isCanUseSDCard", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCanUseSDCard);
				} finally {
				}
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='copyStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static unsafe void CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='copyStream' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='boolean']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Z)V", "")]
		public static unsafe void CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1, bool p2)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Z = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Z)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_generate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generate", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Generate (string p0)
		{
			if (id_generate_Ljava_lang_String_ == IntPtr.Zero)
				id_generate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCacheDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='getCacheDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCacheDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetCacheDir (global::Android.Content.Context p0)
		{
			if (id_getCacheDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getCacheDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCacheDir", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCacheDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCachePath_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='getCachePath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCachePath", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetCachePath (global::Android.Content.Context p0)
		{
			if (id_getCachePath_Landroid_content_Context_ == IntPtr.Zero)
				id_getCachePath_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCachePath", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCachePath_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getExternalCacheDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='getExternalCacheDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getExternalCacheDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetExternalCacheDir (global::Android.Content.Context p0)
		{
			if (id_getExternalCacheDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getExternalCacheDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getExternalCacheDir", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExternalCacheDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getExternalStorageDirectory_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='getExternalStorageDirectory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getExternalStorageDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetExternalStorageDirectory (global::Android.Content.Context p0, string p1)
		{
			if (id_getExternalStorageDirectory_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getExternalStorageDirectory_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getExternalStorageDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExternalStorageDirectory_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getExternalStoragePublicDirectory_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.util']/class[@name='FileUtil']/method[@name='getExternalStoragePublicDirectory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getExternalStoragePublicDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetExternalStoragePublicDirectory (global::Android.Content.Context p0, string p1)
		{
			if (id_getExternalStoragePublicDirectory_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getExternalStoragePublicDirectory_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getExternalStoragePublicDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExternalStoragePublicDirectory_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

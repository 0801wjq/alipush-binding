using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceLoaderUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/spi/ServiceLoaderUtils", DoNotGenerateAcw=true)]
	public partial class ServiceLoaderUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/spi/ServiceLoaderUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceLoaderUtils); }
		}

		protected ServiceLoaderUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceLoaderUtils']/constructor[@name='ServiceLoaderUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceLoaderUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ServiceLoaderUtils)) {
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

		static IntPtr id_getServices_Ljava_lang_Class_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceLoaderUtils']/method[@name='getServices' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register ("getServices", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList GetServices (global::Java.Lang.Class p0, global::Java.Lang.ClassLoader p1)
		{
			if (id_getServices_Ljava_lang_Class_Ljava_lang_ClassLoader_ == IntPtr.Zero)
				id_getServices_Ljava_lang_Class_Ljava_lang_ClassLoader_ = JNIEnv.GetStaticMethodID (class_ref, "getServices", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getServices_Ljava_lang_Class_Ljava_lang_ClassLoader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

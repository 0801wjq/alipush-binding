using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceFactoryFactory']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/spi/ServiceFactoryFactory", DoNotGenerateAcw=true)]
	public sealed partial class ServiceFactoryFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/spi/ServiceFactoryFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceFactoryFactory); }
		}

		internal ServiceFactoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceFactoryFactory']/constructor[@name='ServiceFactoryFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceFactoryFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ServiceFactoryFactory)) {
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

		static IntPtr id_getFactory_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/class[@name='ServiceFactoryFactory']/method[@name='getFactory' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getFactory", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetFactory (global::Java.Lang.Class p0)
		{
			if (id_getFactory_Ljava_lang_Class_ == IntPtr.Zero)
				id_getFactory_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getFactory", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFactory_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

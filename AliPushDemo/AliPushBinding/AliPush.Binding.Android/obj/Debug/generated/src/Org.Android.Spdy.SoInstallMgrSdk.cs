using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']"
	[global::Android.Runtime.Register ("org/android/spdy/SoInstallMgrSdk", DoNotGenerateAcw=true)]
	public partial class SoInstallMgrSdk : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SoInstallMgrSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SoInstallMgrSdk); }
		}

		protected SoInstallMgrSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/constructor[@name='SoInstallMgrSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoInstallMgrSdk ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SoInstallMgrSdk)) {
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

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_initSo_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='initSo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("initSo", "(Ljava/lang/String;I)Z", "")]
		public static unsafe bool InitSo (string p0, int p1)
		{
			if (id_initSo_Ljava_lang_String_I == IntPtr.Zero)
				id_initSo_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "initSo", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initSo_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='initSo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.ClassLoader']]"
		[Register ("initSo", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Z", "")]
		public static unsafe bool InitSo (string p0, int p1, global::Java.Lang.ClassLoader p2)
		{
			if (id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_ == IntPtr.Zero)
				id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_ = JNIEnv.GetStaticMethodID (class_ref, "initSo", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

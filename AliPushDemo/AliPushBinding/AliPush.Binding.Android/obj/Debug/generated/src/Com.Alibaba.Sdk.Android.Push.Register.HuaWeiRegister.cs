using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Register {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='HuaWeiRegister']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/register/HuaWeiRegister", DoNotGenerateAcw=true)]
	public partial class HuaWeiRegister : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='HuaWeiRegister']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:HuaWeiRegister";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/register/HuaWeiRegister", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HuaWeiRegister); }
		}

		protected HuaWeiRegister (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='HuaWeiRegister']/constructor[@name='HuaWeiRegister' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaWeiRegister ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HuaWeiRegister)) {
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

		static IntPtr id_checkDevice_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='HuaWeiRegister']/method[@name='checkDevice' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkDevice", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool CheckDevice (global::Android.Content.Context context)
		{
			if (id_checkDevice_Landroid_content_Context_ == IntPtr.Zero)
				id_checkDevice_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkDevice", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkDevice_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_register_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='HuaWeiRegister']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "")]
		public static unsafe void Register (global::Android.Content.Context appContext)
		{
			if (id_register_Landroid_content_Context_ == IntPtr.Zero)
				id_register_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (appContext);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}

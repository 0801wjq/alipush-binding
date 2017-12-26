using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Register {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='GcmRegister']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/register/GcmRegister", DoNotGenerateAcw=true)]
	public partial class GcmRegister : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='GcmRegister']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:GcmRegister";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/register/GcmRegister", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GcmRegister); }
		}

		protected GcmRegister (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='GcmRegister']/constructor[@name='GcmRegister' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GcmRegister ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GcmRegister)) {
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

		static IntPtr id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.register']/class[@name='GcmRegister']/method[@name='register' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Register (global::Android.Content.Context context, string sendId, string applicationId)
		{
			if (id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_sendId = JNIEnv.NewString (sendId);
			IntPtr native_applicationId = JNIEnv.NewString (applicationId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_sendId);
				__args [2] = new JValue (native_applicationId);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sendId);
				JNIEnv.DeleteLocalRef (native_applicationId);
			}
		}

	}
}

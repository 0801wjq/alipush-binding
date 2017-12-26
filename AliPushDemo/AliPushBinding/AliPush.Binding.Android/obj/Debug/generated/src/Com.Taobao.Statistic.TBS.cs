using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Statistic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.statistic']/class[@name='TBS']"
	[global::Android.Runtime.Register ("com/taobao/statistic/TBS", DoNotGenerateAcw=true)]
	public partial class TBS : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/statistic/TBS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TBS); }
		}

		protected TBS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.statistic']/class[@name='TBS']/constructor[@name='TBS' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TBS ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TBS)) {
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

		static IntPtr id_h5UT_Ljava_lang_String_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.statistic']/class[@name='TBS']/method[@name='h5UT' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.webkit.WebView']]"
		[Register ("h5UT", "(Ljava/lang/String;Landroid/webkit/WebView;)V", "")]
		public static unsafe void H5UT (string jsonStr, global::Android.Webkit.WebView view)
		{
			if (id_h5UT_Ljava_lang_String_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_h5UT_Ljava_lang_String_Landroid_webkit_WebView_ = JNIEnv.GetStaticMethodID (class_ref, "h5UT", "(Ljava/lang/String;Landroid/webkit/WebView;)V");
			IntPtr native_jsonStr = JNIEnv.NewString (jsonStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_jsonStr);
				__args [1] = new JValue (view);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_h5UT_Ljava_lang_String_Landroid_webkit_WebView_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonStr);
			}
		}

	}
}

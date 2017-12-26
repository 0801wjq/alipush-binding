using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushselfshow.Richpush.Html.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='NativeToJsMessageQueue']"
	[global::Android.Runtime.Register ("com/huawei/android/pushselfshow/richpush/html/api/NativeToJsMessageQueue", DoNotGenerateAcw=true)]
	public partial class NativeToJsMessageQueue : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushselfshow/richpush/html/api/NativeToJsMessageQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeToJsMessageQueue); }
		}

		protected NativeToJsMessageQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='NativeToJsMessageQueue']/constructor[@name='NativeToJsMessageQueue' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.webkit.WebView'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;)V", "")]
		public unsafe NativeToJsMessageQueue (global::Android.App.Activity p0, global::Android.Webkit.WebView p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (NativeToJsMessageQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='NativeToJsMessageQueue']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='NativeToJsMessageQueue']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='NativeToJsMessageQueue']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "GetCHandler")]
		public virtual unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

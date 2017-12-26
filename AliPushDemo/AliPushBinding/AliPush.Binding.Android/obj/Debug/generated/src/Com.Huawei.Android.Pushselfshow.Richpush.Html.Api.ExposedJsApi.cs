using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushselfshow.Richpush.Html.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']"
	[global::Android.Runtime.Register ("com/huawei/android/pushselfshow/richpush/html/api/ExposedJsApi", DoNotGenerateAcw=true)]
	public partial class ExposedJsApi : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushselfshow/richpush/html/api/ExposedJsApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExposedJsApi); }
		}

		protected ExposedJsApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/constructor[@name='ExposedJsApi' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.webkit.WebView'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;Z)V", "")]
		public unsafe ExposedJsApi (global::Android.App.Activity p0, global::Android.Webkit.WebView p1, string p2, bool p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ExposedJsApi)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/webkit/WebView;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_exec_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExec_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_exec_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_exec_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Exec_Ljava_lang_String_Ljava_lang_String_);
			return cb_exec_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Exec_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Exec (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_exec_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='exec' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("exec", "(Ljava/lang/String;Ljava/lang/String;)V", "GetExec_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Exec (string p0, string p1)
		{
			if (id_exec_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_exec_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exec", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exec_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exec", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_retrieveJsMessages;
#pragma warning disable 0169
		static Delegate GetRetrieveJsMessagesHandler ()
		{
			if (cb_retrieveJsMessages == null)
				cb_retrieveJsMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RetrieveJsMessages);
			return cb_retrieveJsMessages;
		}

		static IntPtr n_RetrieveJsMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RetrieveJsMessages ());
		}
#pragma warning restore 0169

		static IntPtr id_retrieveJsMessages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='retrieveJsMessages' and count(parameter)=0]"
		[Register ("retrieveJsMessages", "()Ljava/lang/String;", "GetRetrieveJsMessagesHandler")]
		public virtual unsafe string RetrieveJsMessages ()
		{
			if (id_retrieveJsMessages == IntPtr.Zero)
				id_retrieveJsMessages = JNIEnv.GetMethodID (class_ref, "retrieveJsMessages", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retrieveJsMessages), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieveJsMessages", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_synExec_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSynExec_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_synExec_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_synExec_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SynExec_Ljava_lang_String_Ljava_lang_String_);
			return cb_synExec_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SynExec_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.Api.ExposedJsApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SynExec (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_synExec_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html.api']/class[@name='ExposedJsApi']/method[@name='synExec' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("synExec", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSynExec_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string SynExec (string p0, string p1)
		{
			if (id_synExec_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_synExec_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "synExec", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_synExec_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "synExec", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushselfshow.Richpush.Html {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']"
	[global::Android.Runtime.Register ("com/huawei/android/pushselfshow/richpush/html/HtmlViewer", DoNotGenerateAcw=true)]
	public partial class HtmlViewer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "PushSelfShowLog";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushselfshow/richpush/html/HtmlViewer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlViewer); }
		}

		protected HtmlViewer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/constructor[@name='HtmlViewer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HtmlViewer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HtmlViewer)) {
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

		static Delegate cb_downLoadFailed;
#pragma warning disable 0169
		static Delegate GetDownLoadFailedHandler ()
		{
			if (cb_downLoadFailed == null)
				cb_downLoadFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DownLoadFailed);
			return cb_downLoadFailed;
		}

		static void n_DownLoadFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DownLoadFailed ();
		}
#pragma warning restore 0169

		static IntPtr id_downLoadFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='downLoadFailed' and count(parameter)=0]"
		[Register ("downLoadFailed", "()V", "GetDownLoadFailedHandler")]
		public virtual unsafe void DownLoadFailed ()
		{
			if (id_downLoadFailed == IntPtr.Zero)
				id_downLoadFailed = JNIEnv.GetMethodID (class_ref, "downLoadFailed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downLoadFailed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downLoadFailed", "()V"));
			} finally {
			}
		}

		static Delegate cb_downLoadSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownLoadSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_downLoadSuccess_Ljava_lang_String_ == null)
				cb_downLoadSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DownLoadSuccess_Ljava_lang_String_);
			return cb_downLoadSuccess_Ljava_lang_String_;
		}

		static void n_DownLoadSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownLoadSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_downLoadSuccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='downLoadSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("downLoadSuccess", "(Ljava/lang/String;)V", "GetDownLoadSuccess_Ljava_lang_String_Handler")]
		public virtual unsafe void DownLoadSuccess (string p0)
		{
			if (id_downLoadSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_downLoadSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "downLoadSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downLoadSuccess_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downLoadSuccess", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_enableJavaJS_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableJavaJS_Ljava_lang_String_Handler ()
		{
			if (cb_enableJavaJS_Ljava_lang_String_ == null)
				cb_enableJavaJS_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnableJavaJS_Ljava_lang_String_);
			return cb_enableJavaJS_Ljava_lang_String_;
		}

		static void n_EnableJavaJS_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableJavaJS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableJavaJS_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='enableJavaJS' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("enableJavaJS", "(Ljava/lang/String;)V", "GetEnableJavaJS_Ljava_lang_String_Handler")]
		public virtual unsafe void EnableJavaJS (string p0)
		{
			if (id_enableJavaJS_Ljava_lang_String_ == IntPtr.Zero)
				id_enableJavaJS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enableJavaJS", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableJavaJS_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableJavaJS", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static void n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)V", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe void HandleMessage (global::Android.OS.Message p0)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadLocalZip_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadLocalZip_Ljava_lang_String_Handler ()
		{
			if (cb_loadLocalZip_Ljava_lang_String_ == null)
				cb_loadLocalZip_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadLocalZip_Ljava_lang_String_);
			return cb_loadLocalZip_Ljava_lang_String_;
		}

		static void n_LoadLocalZip_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadLocalZip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadLocalZip_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='loadLocalZip' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLocalZip", "(Ljava/lang/String;)V", "GetLoadLocalZip_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadLocalZip (string p0)
		{
			if (id_loadLocalZip_Ljava_lang_String_ == IntPtr.Zero)
				id_loadLocalZip_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadLocalZip", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadLocalZip_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadLocalZip", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
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

		static Delegate cb_onCreate_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_content_Intent_Handler ()
		{
			if (cb_onCreate_Landroid_content_Intent_ == null)
				cb_onCreate_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_content_Intent_);
			return cb_onCreate_Landroid_content_Intent_;
		}

		static void n_OnCreate_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onCreate", "(Landroid/content/Intent;)V", "GetOnCreate_Landroid_content_Intent_Handler")]
		public virtual unsafe void OnCreate (global::Android.Content.Intent p0)
		{
			if (id_onCreate_Landroid_content_Intent_ == IntPtr.Zero)
				id_onCreate_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_onCreateOptionsMenu_Landroid_view_Menu_ == null)
				cb_onCreateOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnCreateOptionsMenu_Landroid_view_Menu_);
			return cb_onCreateOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_OnCreateOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetOnCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public virtual unsafe bool OnCreateOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCreateOptionsMenu_Landroid_view_Menu_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z"), __args);
				return __ret;
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
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onDestroy' and count(parameter)=0]"
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

		static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
				cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyDown_ILandroid_view_KeyEvent_);
			return cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyDown_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyDown (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyDown_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyDown", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyDown (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyDown_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyDown_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onKeyDown_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler ()
		{
			if (cb_onOptionsItemSelected_Landroid_view_MenuItem_ == null)
				cb_onOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOptionsItemSelected_Landroid_view_MenuItem_);
			return cb_onOptionsItemSelected_Landroid_view_MenuItem_;
		}

		static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p0 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public virtual unsafe bool OnOptionsItemSelected (global::Android.Views.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z"), __args);
				return __ret;
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
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onPause' and count(parameter)=0]"
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

		static Delegate cb_onPrepareOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPrepareOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_onPrepareOptionsMenu_Landroid_view_Menu_ == null)
				cb_onPrepareOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareOptionsMenu_Landroid_view_Menu_);
			return cb_onPrepareOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_OnPrepareOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "GetOnPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public virtual unsafe bool OnPrepareOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
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
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onResume' and count(parameter)=0]"
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

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
			}
		}

		static Delegate cb_prepareJS_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrepareJS_Ljava_lang_String_Handler ()
		{
			if (cb_prepareJS_Ljava_lang_String_ == null)
				cb_prepareJS_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareJS_Ljava_lang_String_);
			return cb_prepareJS_Ljava_lang_String_;
		}

		static IntPtr n_PrepareJS_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PrepareJS (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareJS_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='prepareJS' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prepareJS", "(Ljava/lang/String;)Ljava/lang/String;", "GetPrepareJS_Ljava_lang_String_Handler")]
		public virtual unsafe string PrepareJS (string p0)
		{
			if (id_prepareJS_Ljava_lang_String_ == IntPtr.Zero)
				id_prepareJS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prepareJS", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareJS_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareJS", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setActivity_Landroid_app_Activity_ == null)
				cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
			return cb_setActivity_Landroid_app_Activity_;
		}

		static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void SetActivity (global::Android.App.Activity p0)
		{
			if (id_setActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivity_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivity", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public virtual unsafe void SetProgress (int p0)
		{
			if (id_setProgress_I == IntPtr.Zero)
				id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProgress_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgress", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showErrorHtmlURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowErrorHtmlURI_Ljava_lang_String_Handler ()
		{
			if (cb_showErrorHtmlURI_Ljava_lang_String_ == null)
				cb_showErrorHtmlURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowErrorHtmlURI_Ljava_lang_String_);
			return cb_showErrorHtmlURI_Ljava_lang_String_;
		}

		static void n_ShowErrorHtmlURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Richpush.Html.HtmlViewer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowErrorHtmlURI (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showErrorHtmlURI_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.richpush.html']/class[@name='HtmlViewer']/method[@name='showErrorHtmlURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showErrorHtmlURI", "(Ljava/lang/String;)V", "GetShowErrorHtmlURI_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowErrorHtmlURI (string p0)
		{
			if (id_showErrorHtmlURI_Ljava_lang_String_ == IntPtr.Zero)
				id_showErrorHtmlURI_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showErrorHtmlURI", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showErrorHtmlURI_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showErrorHtmlURI", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

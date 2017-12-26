using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Agoo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.agoo']/class[@name='BaseNotifyClickActivity']"
	[global::Android.Runtime.Register ("com/taobao/agoo/BaseNotifyClickActivity", DoNotGenerateAcw=true)]
	public partial class BaseNotifyClickActivity : global::Android.App.Activity {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='BaseNotifyClickActivity.INotifyListener']"
		[Register ("com/taobao/agoo/BaseNotifyClickActivity$INotifyListener", "", "Com.Taobao.Agoo.BaseNotifyClickActivity/INotifyListenerInvoker")]
		public partial interface INotifyListener : IJavaObject {

			string MsgSource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='BaseNotifyClickActivity.INotifyListener']/method[@name='getMsgSource' and count(parameter)=0]"
				[Register ("getMsgSource", "()Ljava/lang/String;", "GetGetMsgSourceHandler:Com.Taobao.Agoo.BaseNotifyClickActivity/INotifyListenerInvoker, AliPush.Binding.Android")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='BaseNotifyClickActivity.INotifyListener']/method[@name='parseMsgFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("parseMsgFromIntent", "(Landroid/content/Intent;)Ljava/lang/String;", "GetParseMsgFromIntent_Landroid_content_Intent_Handler:Com.Taobao.Agoo.BaseNotifyClickActivity/INotifyListenerInvoker, AliPush.Binding.Android")]
			string ParseMsgFromIntent (global::Android.Content.Intent p0);

		}

		[global::Android.Runtime.Register ("com/taobao/agoo/BaseNotifyClickActivity$INotifyListener", DoNotGenerateAcw=true)]
		internal class INotifyListenerInvoker : global::Java.Lang.Object, INotifyListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/agoo/BaseNotifyClickActivity$INotifyListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INotifyListenerInvoker); }
			}

			IntPtr class_ref;

			public static INotifyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INotifyListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.taobao.agoo.BaseNotifyClickActivity.INotifyListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INotifyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getMsgSource;
#pragma warning disable 0169
			static Delegate GetGetMsgSourceHandler ()
			{
				if (cb_getMsgSource == null)
					cb_getMsgSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsgSource);
				return cb_getMsgSource;
			}

			static IntPtr n_GetMsgSource (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MsgSource);
			}
#pragma warning restore 0169

			IntPtr id_getMsgSource;
			public unsafe string MsgSource {
				get {
					if (id_getMsgSource == IntPtr.Zero)
						id_getMsgSource = JNIEnv.GetMethodID (class_ref, "getMsgSource", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsgSource), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_parseMsgFromIntent_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetParseMsgFromIntent_Landroid_content_Intent_Handler ()
			{
				if (cb_parseMsgFromIntent_Landroid_content_Intent_ == null)
					cb_parseMsgFromIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseMsgFromIntent_Landroid_content_Intent_);
				return cb_parseMsgFromIntent_Landroid_content_Intent_;
			}

			static IntPtr n_ParseMsgFromIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.ParseMsgFromIntent (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_parseMsgFromIntent_Landroid_content_Intent_;
			public unsafe string ParseMsgFromIntent (global::Android.Content.Intent p0)
			{
				if (id_parseMsgFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
					id_parseMsgFromIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "parseMsgFromIntent", "(Landroid/content/Intent;)Ljava/lang/String;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseMsgFromIntent_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/agoo/BaseNotifyClickActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNotifyClickActivity); }
		}

		protected BaseNotifyClickActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.agoo']/class[@name='BaseNotifyClickActivity']/constructor[@name='BaseNotifyClickActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseNotifyClickActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseNotifyClickActivity)) {
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

		static IntPtr id_addNotifyListener_Lcom_taobao_agoo_BaseNotifyClickActivity_INotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.agoo']/class[@name='BaseNotifyClickActivity']/method[@name='addNotifyListener' and count(parameter)=1 and parameter[1][@type='com.taobao.agoo.BaseNotifyClickActivity.INotifyListener']]"
		[Register ("addNotifyListener", "(Lcom/taobao/agoo/BaseNotifyClickActivity$INotifyListener;)V", "")]
		public static unsafe void AddNotifyListener (global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener p0)
		{
			if (id_addNotifyListener_Lcom_taobao_agoo_BaseNotifyClickActivity_INotifyListener_ == IntPtr.Zero)
				id_addNotifyListener_Lcom_taobao_agoo_BaseNotifyClickActivity_INotifyListener_ = JNIEnv.GetStaticMethodID (class_ref, "addNotifyListener", "(Lcom/taobao/agoo/BaseNotifyClickActivity$INotifyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addNotifyListener_Lcom_taobao_agoo_BaseNotifyClickActivity_INotifyListener_, __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Landroid_content_Intent_Handler ()
		{
			if (cb_onMessage_Landroid_content_Intent_ == null)
				cb_onMessage_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Landroid_content_Intent_);
			return cb_onMessage_Landroid_content_Intent_;
		}

		static void n_OnMessage_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Agoo.BaseNotifyClickActivity __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Agoo.BaseNotifyClickActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.agoo']/class[@name='BaseNotifyClickActivity']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onMessage", "(Landroid/content/Intent;)V", "GetOnMessage_Landroid_content_Intent_Handler")]
		public virtual unsafe void OnMessage (global::Android.Content.Intent p0)
		{
			if (id_onMessage_Landroid_content_Intent_ == IntPtr.Zero)
				id_onMessage_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}
}

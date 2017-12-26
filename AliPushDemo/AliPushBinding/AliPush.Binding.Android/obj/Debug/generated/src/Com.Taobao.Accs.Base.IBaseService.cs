using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']"
	[Register ("com/taobao/accs/base/IBaseService", "", "Com.Taobao.Accs.Base.IBaseServiceInvoker")]
	public partial interface IBaseService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler:Com.Taobao.Accs.Base.IBaseServiceInvoker, AliPush.Binding.Android")]
		global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler:Com.Taobao.Accs.Base.IBaseServiceInvoker, AliPush.Binding.Android")]
		void OnCreate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Com.Taobao.Accs.Base.IBaseServiceInvoker, AliPush.Binding.Android")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']/method[@name='onStartCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;II)I", "GetOnStartCommand_Landroid_content_Intent_IIHandler:Com.Taobao.Accs.Base.IBaseServiceInvoker, AliPush.Binding.Android")]
		int OnStartCommand (global::Android.Content.Intent p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='IBaseService']/method[@name='onUnbind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onUnbind", "(Landroid/content/Intent;)Z", "GetOnUnbind_Landroid_content_Intent_Handler:Com.Taobao.Accs.Base.IBaseServiceInvoker, AliPush.Binding.Android")]
		bool OnUnbind (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/base/IBaseService", DoNotGenerateAcw=true)]
	internal class IBaseServiceInvoker : global::Java.Lang.Object, IBaseService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/base/IBaseService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBaseServiceInvoker); }
		}

		IntPtr class_ref;

		public static IBaseService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.base.IBaseService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.IBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onBind_Landroid_content_Intent_;
		public unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Base.IBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		IntPtr id_onCreate;
		public unsafe void OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate);
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
			global::Com.Taobao.Accs.Base.IBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
		}

		static Delegate cb_onStartCommand_Landroid_content_Intent_II;
#pragma warning disable 0169
		static Delegate GetOnStartCommand_Landroid_content_Intent_IIHandler ()
		{
			if (cb_onStartCommand_Landroid_content_Intent_II == null)
				cb_onStartCommand_Landroid_content_Intent_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnStartCommand_Landroid_content_Intent_II);
			return cb_onStartCommand_Landroid_content_Intent_II;
		}

		static int n_OnStartCommand_Landroid_content_Intent_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Taobao.Accs.Base.IBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnStartCommand (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onStartCommand_Landroid_content_Intent_II;
		public unsafe int OnStartCommand (global::Android.Content.Intent p0, int p1, int p2)
		{
			if (id_onStartCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_onStartCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "onStartCommand", "(Landroid/content/Intent;II)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onStartCommand_Landroid_content_Intent_II, __args);
			return __ret;
		}

		static Delegate cb_onUnbind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnUnbind_Landroid_content_Intent_Handler ()
		{
			if (cb_onUnbind_Landroid_content_Intent_ == null)
				cb_onUnbind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnUnbind_Landroid_content_Intent_);
			return cb_onUnbind_Landroid_content_Intent_;
		}

		static bool n_OnUnbind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.IBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnUnbind (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onUnbind_Landroid_content_Intent_;
		public unsafe bool OnUnbind (global::Android.Content.Intent p0)
		{
			if (id_onUnbind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUnbind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Landroid/content/Intent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Landroid_content_Intent_, __args);
			return __ret;
		}

	}

}

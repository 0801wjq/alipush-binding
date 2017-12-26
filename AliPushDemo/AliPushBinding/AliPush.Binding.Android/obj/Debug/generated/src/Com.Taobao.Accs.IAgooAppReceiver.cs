using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']"
	[global::Android.Runtime.Register ("com/taobao/accs/IAgooAppReceiver", DoNotGenerateAcw=true)]
	public abstract partial class IAgooAppReceiver : global::Com.Taobao.Accs.IAppReceiverV1 {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/IAgooAppReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAgooAppReceiver); }
		}

		protected IAgooAppReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/constructor[@name='IAgooAppReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IAgooAppReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IAgooAppReceiver)) {
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

		static Delegate cb_getAllServices;
#pragma warning disable 0169
		static Delegate GetGetAllServicesHandler ()
		{
			if (cb_getAllServices == null)
				cb_getAllServices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllServices);
			return cb_getAllServices;
		}

		static IntPtr n_GetAllServices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllServices);
		}
#pragma warning restore 0169

		static IntPtr id_getAllServices;
		public override unsafe global::System.Collections.Generic.IDictionary<string, string> AllServices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='getAllServices' and count(parameter)=0]"
			[Register ("getAllServices", "()Ljava/util/Map;", "GetGetAllServicesHandler")]
			get {
				if (id_getAllServices == IntPtr.Zero)
					id_getAllServices = JNIEnv.GetMethodID (class_ref, "getAllServices", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllServices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllServices", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppkey;
#pragma warning disable 0169
		static Delegate GetGetAppkeyHandler ()
		{
			if (cb_getAppkey == null)
				cb_getAppkey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppkey);
			return cb_getAppkey;
		}

		static IntPtr n_GetAppkey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		public abstract string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler")] get;
		}

		static Delegate cb_getService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetService_Ljava_lang_String_Handler ()
		{
			if (cb_getService_Ljava_lang_String_ == null)
				cb_getService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetService_Ljava_lang_String_);
			return cb_getService_Ljava_lang_String_;
		}

		static IntPtr n_GetService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetService (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetService_Ljava_lang_String_Handler")]
		public override unsafe string GetService (string p0)
		{
			if (id_getService_Ljava_lang_String_ == IntPtr.Zero)
				id_getService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getService", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onBindUser_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnBindUser_Ljava_lang_String_IHandler ()
		{
			if (cb_onBindUser_Ljava_lang_String_I == null)
				cb_onBindUser_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindUser_Ljava_lang_String_I);
			return cb_onBindUser_Ljava_lang_String_I;
		}

		static void n_OnBindUser_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindUser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindUser_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='onBindUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onBindUser", "(Ljava/lang/String;I)V", "GetOnBindUser_Ljava_lang_String_IHandler")]
		public override unsafe void OnBindUser (string p0, int p1)
		{
			if (id_onBindUser_Ljava_lang_String_I == IntPtr.Zero)
				id_onBindUser_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onBindUser", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindUser_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindUser", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onUnbindApp_I;
#pragma warning disable 0169
		static Delegate GetOnUnbindApp_IHandler ()
		{
			if (cb_onUnbindApp_I == null)
				cb_onUnbindApp_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnUnbindApp_I);
			return cb_onUnbindApp_I;
		}

		static void n_OnUnbindApp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindApp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUnbindApp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='onUnbindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindApp", "(I)V", "GetOnUnbindApp_IHandler")]
		public override unsafe void OnUnbindApp (int p0)
		{
			if (id_onUnbindApp_I == IntPtr.Zero)
				id_onUnbindApp_I = JNIEnv.GetMethodID (class_ref, "onUnbindApp", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindApp_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnbindApp", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUnbindUser_I;
#pragma warning disable 0169
		static Delegate GetOnUnbindUser_IHandler ()
		{
			if (cb_onUnbindUser_I == null)
				cb_onUnbindUser_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnUnbindUser_I);
			return cb_onUnbindUser_I;
		}

		static void n_OnUnbindUser_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Taobao.Accs.IAgooAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUnbindUser_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='onUnbindUser' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindUser", "(I)V", "GetOnUnbindUser_IHandler")]
		public override unsafe void OnUnbindUser (int p0)
		{
			if (id_onUnbindUser_I == IntPtr.Zero)
				id_onUnbindUser_I = JNIEnv.GetMethodID (class_ref, "onUnbindUser", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindUser_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnbindUser", "(I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IAgooAppReceiver", DoNotGenerateAcw=true)]
	internal partial class IAgooAppReceiverInvoker : IAgooAppReceiver {

		public IAgooAppReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAgooAppReceiverInvoker); }
		}

		static IntPtr id_getAppkey;
		public override unsafe string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAgooAppReceiver']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler")]
			get {
				if (id_getAppkey == IntPtr.Zero)
					id_getAppkey = JNIEnv.GetMethodID (class_ref, "getAppkey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppkey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_onBindApp_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onBindApp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onBindApp", "(ILjava/lang/String;)V", "GetOnBindApp_ILjava_lang_String_Handler")]
		public override unsafe void OnBindApp (int p0, string p1)
		{
			if (id_onBindApp_ILjava_lang_String_ == IntPtr.Zero)
				id_onBindApp_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBindApp", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindApp_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

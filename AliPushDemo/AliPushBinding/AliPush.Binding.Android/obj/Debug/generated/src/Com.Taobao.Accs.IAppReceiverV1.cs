using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']"
	[global::Android.Runtime.Register ("com/taobao/accs/IAppReceiverV1", DoNotGenerateAcw=true)]
	public abstract partial class IAppReceiverV1 : global::Java.Lang.Object, global::Com.Taobao.Accs.IAppReceiver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/IAppReceiverV1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppReceiverV1); }
		}

		protected IAppReceiverV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/constructor[@name='IAppReceiverV1' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IAppReceiverV1 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IAppReceiverV1)) {
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
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllServices);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<string, string> AllServices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='getAllServices' and count(parameter)=0]"
			[Register ("getAllServices", "()Ljava/util/Map;", "GetGetAllServicesHandler")] get;
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
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetService (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetService_Ljava_lang_String_Handler")]
		public abstract string GetService (string p0);

		static Delegate cb_onBindApp_I;
#pragma warning disable 0169
		static Delegate GetOnBindApp_IHandler ()
		{
			if (cb_onBindApp_I == null)
				cb_onBindApp_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnBindApp_I);
			return cb_onBindApp_I;
		}

		static void n_OnBindApp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBindApp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBindApp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onBindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBindApp", "(I)V", "GetOnBindApp_IHandler")]
		public virtual unsafe void OnBindApp (int p0)
		{
			if (id_onBindApp_I == IntPtr.Zero)
				id_onBindApp_I = JNIEnv.GetMethodID (class_ref, "onBindApp", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindApp_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindApp", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBindApp_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBindApp_ILjava_lang_String_Handler ()
		{
			if (cb_onBindApp_ILjava_lang_String_ == null)
				cb_onBindApp_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnBindApp_ILjava_lang_String_);
			return cb_onBindApp_ILjava_lang_String_;
		}

		static void n_OnBindApp_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBindApp (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onBindApp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onBindApp", "(ILjava/lang/String;)V", "GetOnBindApp_ILjava_lang_String_Handler")]
		public abstract void OnBindApp (int p0, string p1);

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
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindUser (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onBindUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onBindUser", "(Ljava/lang/String;I)V", "GetOnBindUser_Ljava_lang_String_IHandler")]
		public abstract void OnBindUser (string p0, int p1);

		static Delegate cb_onData_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onData_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_onData_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_onData_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_OnData_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnData (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void OnData (string p0, string p1, byte[] p2)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onData", "(Ljava/lang/String;Ljava/lang/String;[B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onSendData_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnSendData_Ljava_lang_String_IHandler ()
		{
			if (cb_onSendData_Ljava_lang_String_I == null)
				cb_onSendData_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnSendData_Ljava_lang_String_I);
			return cb_onSendData_Ljava_lang_String_I;
		}

		static void n_OnSendData_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSendData_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onSendData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onSendData", "(Ljava/lang/String;I)V", "GetOnSendData_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnSendData (string p0, int p1)
		{
			if (id_onSendData_Ljava_lang_String_I == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSendData", "(Ljava/lang/String;I)V"), __args);
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
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindApp (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onUnbindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindApp", "(I)V", "GetOnUnbindApp_IHandler")]
		public abstract void OnUnbindApp (int p0);

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
			global::Com.Taobao.Accs.IAppReceiverV1 __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiverV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindUser (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onUnbindUser' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindUser", "(I)V", "GetOnUnbindUser_IHandler")]
		public abstract void OnUnbindUser (int p0);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IAppReceiverV1", DoNotGenerateAcw=true)]
	internal partial class IAppReceiverV1Invoker : IAppReceiverV1 {

		public IAppReceiverV1Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppReceiverV1Invoker); }
		}

		static IntPtr id_getAllServices;
		public override unsafe global::System.Collections.Generic.IDictionary<string, string> AllServices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='getAllServices' and count(parameter)=0]"
			[Register ("getAllServices", "()Ljava/util/Map;", "GetGetAllServicesHandler")]
			get {
				if (id_getAllServices == IntPtr.Zero)
					id_getAllServices = JNIEnv.GetMethodID (class_ref, "getAllServices", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllServices), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetService_Ljava_lang_String_Handler")]
		public override unsafe string GetService (string p0)
		{
			if (id_getService_Ljava_lang_String_ == IntPtr.Zero)
				id_getService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getService", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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

		static IntPtr id_onBindUser_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onBindUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindUser_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onUnbindApp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onUnbindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindApp", "(I)V", "GetOnUnbindApp_IHandler")]
		public override unsafe void OnUnbindApp (int p0)
		{
			if (id_onUnbindApp_I == IntPtr.Zero)
				id_onUnbindApp_I = JNIEnv.GetMethodID (class_ref, "onUnbindApp", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindApp_I, __args);
			} finally {
			}
		}

		static IntPtr id_onUnbindUser_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='IAppReceiverV1']/method[@name='onUnbindUser' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindUser", "(I)V", "GetOnUnbindUser_IHandler")]
		public override unsafe void OnUnbindUser (int p0)
		{
			if (id_onUnbindUser_I == IntPtr.Zero)
				id_onUnbindUser_I = JNIEnv.GetMethodID (class_ref, "onUnbindUser", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindUser_I, __args);
			} finally {
			}
		}

	}

}

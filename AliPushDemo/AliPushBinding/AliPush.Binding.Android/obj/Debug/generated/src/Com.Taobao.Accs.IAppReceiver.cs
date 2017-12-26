using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']"
	[Register ("com/taobao/accs/IAppReceiver", "", "Com.Taobao.Accs.IAppReceiverInvoker")]
	public partial interface IAppReceiver : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> AllServices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='getAllServices' and count(parameter)=0]"
			[Register ("getAllServices", "()Ljava/util/Map;", "GetGetAllServicesHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetService_Ljava_lang_String_Handler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		string GetService (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onBindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBindApp", "(I)V", "GetOnBindApp_IHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnBindApp (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onBindUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onBindUser", "(Ljava/lang/String;I)V", "GetOnBindUser_Ljava_lang_String_IHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnBindUser (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnData (string p0, string p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onSendData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onSendData", "(Ljava/lang/String;I)V", "GetOnSendData_Ljava_lang_String_IHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnSendData (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onUnbindApp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindApp", "(I)V", "GetOnUnbindApp_IHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnUnbindApp (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IAppReceiver']/method[@name='onUnbindUser' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUnbindUser", "(I)V", "GetOnUnbindUser_IHandler:Com.Taobao.Accs.IAppReceiverInvoker, AliPush.Binding.Android")]
		void OnUnbindUser (int p0);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IAppReceiver", DoNotGenerateAcw=true)]
	internal class IAppReceiverInvoker : global::Java.Lang.Object, IAppReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/IAppReceiver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppReceiverInvoker); }
		}

		IntPtr class_ref;

		public static IAppReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.IAppReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllServices);
		}
#pragma warning restore 0169

		IntPtr id_getAllServices;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> AllServices {
			get {
				if (id_getAllServices == IntPtr.Zero)
					id_getAllServices = JNIEnv.GetMethodID (class_ref, "getAllServices", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllServices), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetService (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getService_Ljava_lang_String_;
		public unsafe string GetService (string p0)
		{
			if (id_getService_Ljava_lang_String_ == IntPtr.Zero)
				id_getService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getService", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBindApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBindApp_I;
		public unsafe void OnBindApp (int p0)
		{
			if (id_onBindApp_I == IntPtr.Zero)
				id_onBindApp_I = JNIEnv.GetMethodID (class_ref, "onBindApp", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindApp_I, __args);
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindUser (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBindUser_Ljava_lang_String_I;
		public unsafe void OnBindUser (string p0, int p1)
		{
			if (id_onBindUser_Ljava_lang_String_I == IntPtr.Zero)
				id_onBindUser_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onBindUser", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindUser_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnData (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_arrayB;
		public unsafe void OnData (string p0, string p1, byte[] p2)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSendData_Ljava_lang_String_I;
		public unsafe void OnSendData (string p0, int p1)
		{
			if (id_onSendData_Ljava_lang_String_I == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUnbindApp_I;
		public unsafe void OnUnbindApp (int p0)
		{
			if (id_onUnbindApp_I == IntPtr.Zero)
				id_onUnbindApp_I = JNIEnv.GetMethodID (class_ref, "onUnbindApp", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindApp_I, __args);
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
			global::Com.Taobao.Accs.IAppReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbindUser (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUnbindUser_I;
		public unsafe void OnUnbindUser (int p0)
		{
			if (id_onUnbindUser_I == IntPtr.Zero)
				id_onUnbindUser_I = JNIEnv.GetMethodID (class_ref, "onUnbindUser", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbindUser_I, __args);
		}

	}

}

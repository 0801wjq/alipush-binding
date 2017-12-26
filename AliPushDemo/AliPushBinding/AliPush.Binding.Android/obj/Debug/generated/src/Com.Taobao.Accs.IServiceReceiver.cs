using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']"
	[Register ("com/taobao/accs/IServiceReceiver", "", "Com.Taobao.Accs.IServiceReceiverInvoker")]
	public partial interface IServiceReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']/method[@name='onBind' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onBind", "(Ljava/lang/String;I)V", "GetOnBind_Ljava_lang_String_IHandler:Com.Taobao.Accs.IServiceReceiverInvoker, AliPush.Binding.Android")]
		void OnBind (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']/method[@name='onData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Com.Taobao.Accs.IServiceReceiverInvoker, AliPush.Binding.Android")]
		void OnData (string p0, string p1, string p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']/method[@name='onResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[B)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBHandler:Com.Taobao.Accs.IServiceReceiverInvoker, AliPush.Binding.Android")]
		void OnResponse (string p0, string p1, int p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']/method[@name='onSendData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Taobao.Accs.IServiceReceiverInvoker, AliPush.Binding.Android")]
		void OnSendData (string p0, string p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IServiceReceiver']/method[@name='onUnbind' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onUnbind", "(Ljava/lang/String;I)V", "GetOnUnbind_Ljava_lang_String_IHandler:Com.Taobao.Accs.IServiceReceiverInvoker, AliPush.Binding.Android")]
		void OnUnbind (string p0, int p1);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IServiceReceiver", DoNotGenerateAcw=true)]
	internal class IServiceReceiverInvoker : global::Java.Lang.Object, IServiceReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/IServiceReceiver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IServiceReceiverInvoker); }
		}

		IntPtr class_ref;

		public static IServiceReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServiceReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.IServiceReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServiceReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBind_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnBind_Ljava_lang_String_IHandler ()
		{
			if (cb_onBind_Ljava_lang_String_I == null)
				cb_onBind_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBind_Ljava_lang_String_I);
			return cb_onBind_Ljava_lang_String_I;
		}

		static void n_OnBind_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Taobao.Accs.IServiceReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IServiceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBind_Ljava_lang_String_I;
		public unsafe void OnBind (string p0, int p1)
		{
			if (id_onBind_Ljava_lang_String_I == IntPtr.Zero)
				id_onBind_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onBind", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.IServiceReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IServiceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnData (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		public unsafe void OnData (string p0, string p1, string p2, byte[] p3)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBHandler ()
		{
			if (cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB == null)
				cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayB);
			return cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB;
		}

		static void n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.IServiceReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IServiceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnResponse (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB;
		public unsafe void OnResponse (string p0, string p1, int p2, byte[] p3)
		{
			if (id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB == IntPtr.Zero)
				id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/String;Ljava/lang/String;I[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onSendData_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnSendData_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_onSendData_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_onSendData_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnSendData_Ljava_lang_String_Ljava_lang_String_I);
			return cb_onSendData_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_OnSendData_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Taobao.Accs.IServiceReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IServiceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSendData_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void OnSendData (string p0, string p1, int p2)
		{
			if (id_onSendData_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onUnbind_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnUnbind_Ljava_lang_String_IHandler ()
		{
			if (cb_onUnbind_Ljava_lang_String_I == null)
				cb_onUnbind_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnUnbind_Ljava_lang_String_I);
			return cb_onUnbind_Ljava_lang_String_I;
		}

		static void n_OnUnbind_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Taobao.Accs.IServiceReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IServiceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUnbind_Ljava_lang_String_I;
		public unsafe void OnUnbind (string p0, int p1)
		{
			if (id_onUnbind_Ljava_lang_String_I == IntPtr.Zero)
				id_onUnbind_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

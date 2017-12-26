using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']"
	[Register ("com/taobao/accs/base/AccsDataListener", "", "Com.Taobao.Accs.Base.IAccsDataListenerInvoker")]
	public partial interface IAccsDataListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onAntiBrush' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnAntiBrush (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnConnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnDisconnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler:Com.Taobao.Accs.Base.IAccsDataListenerInvoker, AliPush.Binding.Android")]
		void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/base/AccsDataListener", DoNotGenerateAcw=true)]
	internal class IAccsDataListenerInvoker : global::Java.Lang.Object, IAccsDataListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/base/AccsDataListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAccsDataListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAccsDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccsDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.base.AccsDataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccsDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAntiBrush (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnAntiBrush (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			if (id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
		}

		static Delegate cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler ()
		{
			if (cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == null)
				cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_);
			return cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		}

		static void n_OnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		public unsafe void OnConnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
		}

		static Delegate cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler ()
		{
			if (cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == null)
				cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_);
			return cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		}

		static void n_OnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		public unsafe void OnDisconnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
		}

		static Delegate cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3)
		{
			if (id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Base.IAccsDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.IAccsDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		public unsafe void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AntiBrushEventArgs : global::System.EventArgs {

		public AntiBrushEventArgs (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P1 {
			get { return p1; }
		}
	}

	public partial class BindEventArgs : global::System.EventArgs {

		public BindEventArgs (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P2 {
			get { return p2; }
		}
	}

	public partial class ConnectedEventArgs : global::System.EventArgs {

		public ConnectedEventArgs (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo P0 {
			get { return p0; }
		}
	}

	public partial class DataEventArgs : global::System.EventArgs {

		public DataEventArgs (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		byte[] p3;
		public byte[] P3 {
			get { return p3; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P4 {
			get { return p4; }
		}
	}

	public partial class DisconnectedEventArgs : global::System.EventArgs {

		public DisconnectedEventArgs (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			this.p0 = p0;
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo P0 {
			get { return p0; }
		}
	}

	public partial class ResponseEventArgs : global::System.EventArgs {

		public ResponseEventArgs (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		byte[] p3;
		public byte[] P3 {
			get { return p3; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P4 {
			get { return p4; }
		}
	}

	public partial class SendDataEventArgs : global::System.EventArgs {

		public SendDataEventArgs (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P3 {
			get { return p3; }
		}
	}

	public partial class UnbindEventArgs : global::System.EventArgs {

		public UnbindEventArgs (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2;
		public global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/taobao/accs/base/AccsDataListenerImplementor")]
	internal sealed partial class IAccsDataListenerImplementor : global::Java.Lang.Object, IAccsDataListener {

		object sender;

		public IAccsDataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/taobao/accs/base/AccsDataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AntiBrushEventArgs> OnAntiBrushHandler;
#pragma warning restore 0649

		public void OnAntiBrush (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			var __h = OnAntiBrushHandler;
			if (__h != null)
				__h (sender, new AntiBrushEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<BindEventArgs> OnBindHandler;
#pragma warning restore 0649

		public void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			var __h = OnBindHandler;
			if (__h != null)
				__h (sender, new BindEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ConnectedEventArgs> OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new ConnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DataEventArgs> OnDataHandler;
#pragma warning restore 0649

		public void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			var __h = OnDataHandler;
			if (__h != null)
				__h (sender, new DataEventArgs (p0, p1, p2, p3, p4));
		}
#pragma warning disable 0649
		public EventHandler<DisconnectedEventArgs> OnDisconnectedHandler;
#pragma warning restore 0649

		public void OnDisconnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			var __h = OnDisconnectedHandler;
			if (__h != null)
				__h (sender, new DisconnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ResponseEventArgs> OnResponseHandler;
#pragma warning restore 0649

		public void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			var __h = OnResponseHandler;
			if (__h != null)
				__h (sender, new ResponseEventArgs (p0, p1, p2, p3, p4));
		}
#pragma warning disable 0649
		public EventHandler<SendDataEventArgs> OnSendDataHandler;
#pragma warning restore 0649

		public void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3)
		{
			var __h = OnSendDataHandler;
			if (__h != null)
				__h (sender, new SendDataEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<UnbindEventArgs> OnUnbindHandler;
#pragma warning restore 0649

		public void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			var __h = OnUnbindHandler;
			if (__h != null)
				__h (sender, new UnbindEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IAccsDataListenerImplementor value)
		{
			return value.OnAntiBrushHandler == null && value.OnBindHandler == null && value.OnConnectedHandler == null && value.OnDataHandler == null && value.OnDisconnectedHandler == null && value.OnResponseHandler == null && value.OnSendDataHandler == null && value.OnUnbindHandler == null;
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']"
	[global::Android.Runtime.Register ("com/taobao/accs/base/AccsAbstractDataListener", DoNotGenerateAcw=true)]
	public abstract partial class AccsAbstractDataListener : global::Java.Lang.Object, global::Com.Taobao.Accs.Base.IAccsDataListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/base/AccsAbstractDataListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccsAbstractDataListener); }
		}

		protected AccsAbstractDataListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']/constructor[@name='AccsAbstractDataListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccsAbstractDataListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AccsAbstractDataListener)) {
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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAntiBrush (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']/method[@name='onAntiBrush' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public virtual unsafe void OnAntiBrush (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			if (id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
			}
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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler")]
		public virtual unsafe void OnConnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V"), __args);
			} finally {
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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler")]
		public virtual unsafe void OnDisconnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onReceiveData_Landroid_content_Context_Landroid_content_Intent_Lcom_taobao_accs_base_AccsDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='AccsAbstractDataListener']/method[@name='onReceiveData' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='com.taobao.accs.base.AccsDataListener']]"
		[Register ("onReceiveData", "(Landroid/content/Context;Landroid/content/Intent;Lcom/taobao/accs/base/AccsDataListener;)I", "")]
		public static unsafe int OnReceiveData (global::Android.Content.Context p0, global::Android.Content.Intent p1, global::Com.Taobao.Accs.Base.IAccsDataListener p2)
		{
			if (id_onReceiveData_Landroid_content_Context_Landroid_content_Intent_Lcom_taobao_accs_base_AccsDataListener_ == IntPtr.Zero)
				id_onReceiveData_Landroid_content_Context_Landroid_content_Intent_Lcom_taobao_accs_base_AccsDataListener_ = JNIEnv.GetStaticMethodID (class_ref, "onReceiveData", "(Landroid/content/Context;Landroid/content/Intent;Lcom/taobao/accs/base/AccsDataListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_onReceiveData_Landroid_content_Context_Landroid_content_Intent_Lcom_taobao_accs_base_AccsDataListener_, __args);
				return __ret;
			} finally {
			}
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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3);

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
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/base/AccsAbstractDataListener", DoNotGenerateAcw=true)]
	internal partial class AccsAbstractDataListenerInvoker : AccsAbstractDataListener {

		public AccsAbstractDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccsAbstractDataListenerInvoker); }
		}

		static IntPtr id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3)
		{
			if (id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

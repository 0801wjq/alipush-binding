using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Control {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']"
	[global::Android.Runtime.Register ("org/android/agoo/control/AgooFactory", DoNotGenerateAcw=true)]
	public partial class AgooFactory : global::Java.Lang.Object {


		static IntPtr notifyManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/field[@name='notifyManager']"
		[Register ("notifyManager")]
		protected global::Org.Android.Agoo.Control.NotifManager NotifyManager {
			get {
				if (notifyManager_jfieldId == IntPtr.Zero)
					notifyManager_jfieldId = JNIEnv.GetFieldID (class_ref, "notifyManager", "Lorg/android/agoo/control/NotifManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, notifyManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (notifyManager_jfieldId == IntPtr.Zero)
					notifyManager_jfieldId = JNIEnv.GetFieldID (class_ref, "notifyManager", "Lorg/android/agoo/control/NotifManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, notifyManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/control/AgooFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooFactory); }
		}

		protected AgooFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/constructor[@name='AgooFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AgooFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AgooFactory)) {
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

		static Delegate cb_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_ == null)
				cb_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_);
			return cb_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_;
		}

		static void n_Init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Control.NotifManager p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Message.MessageService p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Message.MessageService> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.control.NotifManager'] and parameter[3][@type='org.android.agoo.message.MessageService']]"
		[Register ("init", "(Landroid/content/Context;Lorg/android/agoo/control/NotifManager;Lorg/android/agoo/message/MessageService;)V", "GetInit_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Org.Android.Agoo.Control.NotifManager p1, global::Org.Android.Agoo.Message.MessageService p2)
		{
			if (id_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lorg/android/agoo/control/NotifManager;Lorg/android/agoo/message/MessageService;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lorg_android_agoo_control_NotifManager_Lorg_android_agoo_message_MessageService_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Lorg/android/agoo/control/NotifManager;Lorg/android/agoo/message/MessageService;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z;
#pragma warning disable 0169
		static Delegate GetMsgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ZHandler ()
		{
			if (cb_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z == null)
				cb_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_MsgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z);
			return cb_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z;
		}

		static IntPtr n_MsgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MsgReceiverPreHandler (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='msgReceiverPreHandler' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo'] and parameter[4][@type='boolean']]"
		[Register ("msgReceiverPreHandler", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;Z)Landroid/os/Bundle;", "GetMsgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ZHandler")]
		public virtual unsafe global::Android.OS.Bundle MsgReceiverPreHandler (byte[] p0, string p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2, bool p3)
		{
			if (id_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z == IntPtr.Zero)
				id_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z = JNIEnv.GetMethodID (class_ref, "msgReceiverPreHandler", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;Z)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_msgReceiverPreHandler_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "msgReceiverPreHandler", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;Z)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_msgRecevie_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMsgRecevie_arrayBLjava_lang_String_Handler ()
		{
			if (cb_msgRecevie_arrayBLjava_lang_String_ == null)
				cb_msgRecevie_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MsgRecevie_arrayBLjava_lang_String_);
			return cb_msgRecevie_arrayBLjava_lang_String_;
		}

		static void n_MsgRecevie_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MsgRecevie (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_msgRecevie_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='msgRecevie' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("msgRecevie", "([BLjava/lang/String;)V", "GetMsgRecevie_arrayBLjava_lang_String_Handler")]
		public virtual unsafe void MsgRecevie (byte[] p0, string p1)
		{
			if (id_msgRecevie_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_msgRecevie_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "msgRecevie", "([BLjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_msgRecevie_arrayBLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "msgRecevie", "([BLjava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetMsgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MsgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_MsgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MsgRecevie (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='msgRecevie' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("msgRecevie", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetMsgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public virtual unsafe void MsgRecevie (byte[] p0, string p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "msgRecevie", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_msgRecevie_arrayBLjava_lang_String_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "msgRecevie", "([BLjava/lang/String;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_parseEncryptedMsg_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='parseEncryptedMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseEncryptedMsg", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ParseEncryptedMsg (string p0)
		{
			if (id_parseEncryptedMsg_Ljava_lang_String_ == IntPtr.Zero)
				id_parseEncryptedMsg_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseEncryptedMsg", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseEncryptedMsg_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reportCacheMsg;
#pragma warning disable 0169
		static Delegate GetReportCacheMsgHandler ()
		{
			if (cb_reportCacheMsg == null)
				cb_reportCacheMsg = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReportCacheMsg);
			return cb_reportCacheMsg;
		}

		static void n_ReportCacheMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportCacheMsg ();
		}
#pragma warning restore 0169

		static IntPtr id_reportCacheMsg;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='reportCacheMsg' and count(parameter)=0]"
		[Register ("reportCacheMsg", "()V", "GetReportCacheMsgHandler")]
		public virtual unsafe void ReportCacheMsg ()
		{
			if (id_reportCacheMsg == IntPtr.Zero)
				id_reportCacheMsg = JNIEnv.GetMethodID (class_ref, "reportCacheMsg", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportCacheMsg);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportCacheMsg", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveMsg_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveMsg_arrayBHandler ()
		{
			if (cb_saveMsg_arrayB == null)
				cb_saveMsg_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveMsg_arrayB);
			return cb_saveMsg_arrayB;
		}

		static void n_SaveMsg_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SaveMsg (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveMsg_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='saveMsg' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveMsg", "([B)V", "GetSaveMsg_arrayBHandler")]
		public virtual unsafe void SaveMsg (byte[] p0)
		{
			if (id_saveMsg_arrayB == IntPtr.Zero)
				id_saveMsg_arrayB = JNIEnv.GetMethodID (class_ref, "saveMsg", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveMsg_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveMsg", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_saveMsg_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveMsg_arrayBLjava_lang_String_Handler ()
		{
			if (cb_saveMsg_arrayBLjava_lang_String_ == null)
				cb_saveMsg_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveMsg_arrayBLjava_lang_String_);
			return cb_saveMsg_arrayBLjava_lang_String_;
		}

		static void n_SaveMsg_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveMsg (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveMsg_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='saveMsg' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveMsg", "([BLjava/lang/String;)V", "GetSaveMsg_arrayBLjava_lang_String_Handler")]
		public virtual unsafe void SaveMsg (byte[] p0, string p1)
		{
			if (id_saveMsg_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_saveMsg_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveMsg", "([BLjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveMsg_arrayBLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveMsg", "([BLjava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMsg_arrayBZ;
#pragma warning disable 0169
		static Delegate GetUpdateMsg_arrayBZHandler ()
		{
			if (cb_updateMsg_arrayBZ == null)
				cb_updateMsg_arrayBZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateMsg_arrayBZ);
			return cb_updateMsg_arrayBZ;
		}

		static void n_UpdateMsg_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.UpdateMsg (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateMsg_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='updateMsg' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("updateMsg", "([BZ)V", "GetUpdateMsg_arrayBZHandler")]
		public virtual unsafe void UpdateMsg (byte[] p0, bool p1)
		{
			if (id_updateMsg_arrayBZ == IntPtr.Zero)
				id_updateMsg_arrayBZ = JNIEnv.GetMethodID (class_ref, "updateMsg", "([BZ)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMsg_arrayBZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMsg", "([BZ)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateMsgStatus_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMsgStatus_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateMsgStatus_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMsgStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='updateMsgStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateMsgStatus", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateMsgStatus_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateMsgStatus (string p0, string p1)
		{
			if (id_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateMsgStatus", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMsgStatus_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMsgStatus", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateNotifyMsg_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateNotifyMsg_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateNotifyMsg_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Control.AgooFactory __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.AgooFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNotifyMsg (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='AgooFactory']/method[@name='updateNotifyMsg' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateNotifyMsg", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateNotifyMsg_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateNotifyMsg (string p0, string p1)
		{
			if (id_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateNotifyMsg", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNotifyMsg_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNotifyMsg", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

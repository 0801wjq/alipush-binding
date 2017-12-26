using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']"
	[global::Android.Runtime.Register ("org/android/agoo/accs/AgooService", DoNotGenerateAcw=true)]
	public partial class AgooService : global::Com.Taobao.Accs.Base.TaoBaseService {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/field[@name='a']"
		[Register ("a")]
		public static global::Org.Android.Agoo.Common.ICallBack A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/common/CallBack;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Common.ICallBack> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/common/CallBack;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/field[@name='b']"
		[Register ("b")]
		public static global::Org.Android.Agoo.Common.ICallBack B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/common/CallBack;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Common.ICallBack> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/common/CallBack;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/accs/AgooService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooService); }
		}

		protected AgooService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/constructor[@name='AgooService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AgooService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AgooService)) {
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
			global::Org.Android.Agoo.Accs.AgooService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Accs.AgooService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Org.Android.Agoo.Accs.AgooService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Accs.AgooService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
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
			global::Org.Android.Agoo.Accs.AgooService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Accs.AgooService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
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
			global::Org.Android.Agoo.Accs.AgooService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Accs.AgooService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Org.Android.Agoo.Accs.AgooService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Accs.AgooService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.accs']/class[@name='AgooService']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

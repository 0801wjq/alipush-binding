using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']"
	[global::Android.Runtime.Register ("com/taobao/accs/internal/ACCSManagerImpl", DoNotGenerateAcw=true)]
	public partial class ACCSManagerImpl : global::Java.Lang.Object, global::Com.Taobao.Accs.IACCSManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/internal/ACCSManagerImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ACCSManagerImpl); }
		}

		protected ACCSManagerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/constructor[@name='ACCSManagerImpl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe ACCSManagerImpl (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ACCSManagerImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getChannelState;
#pragma warning disable 0169
		static Delegate GetGetChannelStateHandler ()
		{
			if (cb_getChannelState == null)
				cb_getChannelState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelState);
			return cb_getChannelState;
		}

		static IntPtr n_GetChannelState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.ChannelState);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelState;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> ChannelState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='getChannelState' and count(parameter)=0]"
			[Register ("getChannelState", "()Ljava/util/Map;", "GetGetChannelStateHandler")]
			get {
				if (id_getChannelState == IntPtr.Zero)
					id_getChannelState = JNIEnv.GetMethodID (class_ref, "getChannelState", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelState", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserUnit;
#pragma warning disable 0169
		static Delegate GetGetUserUnitHandler ()
		{
			if (cb_getUserUnit == null)
				cb_getUserUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserUnit);
			return cb_getUserUnit;
		}

		static IntPtr n_GetUserUnit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserUnit);
		}
#pragma warning restore 0169

		static IntPtr id_getUserUnit;
		public virtual unsafe string UserUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='getUserUnit' and count(parameter)=0]"
			[Register ("getUserUnit", "()Ljava/lang/String;", "GetGetUserUnitHandler")]
			get {
				if (id_getUserUnit == IntPtr.Zero)
					id_getUserUnit = JNIEnv.GetMethodID (class_ref, "getUserUnit", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserUnit), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserUnit", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetBindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_BindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p3 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.BindApp (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='bindApp' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetBindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void BindApp (global::Android.Content.Context p0, string p1, string p2, global::Com.Taobao.Accs.IAppReceiver p3)
		{
			if (id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetBindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_BindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p4 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.BindApp (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='bindApp' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetBindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void BindApp (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Taobao.Accs.IAppReceiver p4)
		{
			if (id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_bindService_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBindService_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_bindService_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_bindService_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindService_Landroid_content_Context_Ljava_lang_String_);
			return cb_bindService_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_BindService_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindService_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='bindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindService", "(Landroid/content/Context;Ljava/lang/String;)V", "GetBindService_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void BindService (global::Android.Content.Context p0, string p1)
		{
			if (id_bindService_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_bindService_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bindService", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindService_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindService", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_bindUser_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBindUser_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_bindUser_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_bindUser_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindUser_Landroid_content_Context_Ljava_lang_String_);
			return cb_bindUser_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_BindUser_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindUser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindUser_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='bindUser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindUser", "(Landroid/content/Context;Ljava/lang/String;)V", "GetBindUser_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void BindUser (global::Android.Content.Context p0, string p1)
		{
			if (id_bindUser_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_bindUser_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bindUser", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindUser_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindUser", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_bindUser_Landroid_content_Context_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetBindUser_Landroid_content_Context_Ljava_lang_String_ZHandler ()
		{
			if (cb_bindUser_Landroid_content_Context_Ljava_lang_String_Z == null)
				cb_bindUser_Landroid_content_Context_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_BindUser_Landroid_content_Context_Ljava_lang_String_Z);
			return cb_bindUser_Landroid_content_Context_Ljava_lang_String_Z;
		}

		static void n_BindUser_Landroid_content_Context_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindUser (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_bindUser_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='bindUser' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("bindUser", "(Landroid/content/Context;Ljava/lang/String;Z)V", "GetBindUser_Landroid_content_Context_Ljava_lang_String_ZHandler")]
		public virtual unsafe void BindUser (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_bindUser_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_bindUser_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "bindUser", "(Landroid/content/Context;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindUser_Landroid_content_Context_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindUser", "(Landroid/content/Context;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_cancel_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCancel_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_cancel_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_cancel_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Cancel_Landroid_content_Context_Ljava_lang_String_);
			return cb_cancel_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_Cancel_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Cancel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='cancel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("cancel", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetCancel_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool Cancel (global::Android.Content.Context p0, string p1)
		{
			if (id_cancel_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_cancel_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Landroid/content/Context;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_clearLoginInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetClearLoginInfo_Landroid_content_Context_Handler ()
		{
			if (cb_clearLoginInfo_Landroid_content_Context_ == null)
				cb_clearLoginInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearLoginInfo_Landroid_content_Context_);
			return cb_clearLoginInfo_Landroid_content_Context_;
		}

		static void n_ClearLoginInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearLoginInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearLoginInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='clearLoginInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLoginInfo", "(Landroid/content/Context;)V", "GetClearLoginInfo_Landroid_content_Context_Handler")]
		public virtual unsafe void ClearLoginInfo (global::Android.Content.Context p0)
		{
			if (id_clearLoginInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_clearLoginInfo_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "clearLoginInfo", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearLoginInfo_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearLoginInfo", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_forceDisableService_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetForceDisableService_Landroid_content_Context_Handler ()
		{
			if (cb_forceDisableService_Landroid_content_Context_ == null)
				cb_forceDisableService_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ForceDisableService_Landroid_content_Context_);
			return cb_forceDisableService_Landroid_content_Context_;
		}

		static void n_ForceDisableService_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ForceDisableService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_forceDisableService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='forceDisableService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("forceDisableService", "(Landroid/content/Context;)V", "GetForceDisableService_Landroid_content_Context_Handler")]
		public virtual unsafe void ForceDisableService (global::Android.Content.Context p0)
		{
			if (id_forceDisableService_Landroid_content_Context_ == IntPtr.Zero)
				id_forceDisableService_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "forceDisableService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceDisableService_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceDisableService", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_forceEnableService_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetForceEnableService_Landroid_content_Context_Handler ()
		{
			if (cb_forceEnableService_Landroid_content_Context_ == null)
				cb_forceEnableService_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ForceEnableService_Landroid_content_Context_);
			return cb_forceEnableService_Landroid_content_Context_;
		}

		static void n_ForceEnableService_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ForceEnableService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_forceEnableService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='forceEnableService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("forceEnableService", "(Landroid/content/Context;)V", "GetForceEnableService_Landroid_content_Context_Handler")]
		public virtual unsafe void ForceEnableService (global::Android.Content.Context p0)
		{
			if (id_forceEnableService_Landroid_content_Context_ == IntPtr.Zero)
				id_forceEnableService_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "forceEnableService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceEnableService_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceEnableService", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_forceReConnectChannel;
#pragma warning disable 0169
		static Delegate GetForceReConnectChannelHandler ()
		{
			if (cb_forceReConnectChannel == null)
				cb_forceReConnectChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForceReConnectChannel);
			return cb_forceReConnectChannel;
		}

		static IntPtr n_ForceReConnectChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.ForceReConnectChannel ());
		}
#pragma warning restore 0169

		static IntPtr id_forceReConnectChannel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='forceReConnectChannel' and count(parameter)=0]"
		[Register ("forceReConnectChannel", "()Ljava/util/Map;", "GetForceReConnectChannelHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> ForceReConnectChannel ()
		{
			if (id_forceReConnectChannel == IntPtr.Zero)
				id_forceReConnectChannel = JNIEnv.GetMethodID (class_ref, "forceReConnectChannel", "()Ljava/util/Map;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forceReConnectChannel), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceReConnectChannel", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isChannelError_I;
#pragma warning disable 0169
		static Delegate GetIsChannelError_IHandler ()
		{
			if (cb_isChannelError_I == null)
				cb_isChannelError_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsChannelError_I);
			return cb_isChannelError_I;
		}

		static bool n_IsChannelError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChannelError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isChannelError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='isChannelError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isChannelError", "(I)Z", "GetIsChannelError_IHandler")]
		public virtual unsafe bool IsChannelError (int p0)
		{
			if (id_isChannelError_I == IntPtr.Zero)
				id_isChannelError_I = JNIEnv.GetMethodID (class_ref, "isChannelError", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelError_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelError", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_isNetworkReachable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsNetworkReachable_Landroid_content_Context_Handler ()
		{
			if (cb_isNetworkReachable_Landroid_content_Context_ == null)
				cb_isNetworkReachable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsNetworkReachable_Landroid_content_Context_);
			return cb_isNetworkReachable_Landroid_content_Context_;
		}

		static bool n_IsNetworkReachable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNetworkReachable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isNetworkReachable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='isNetworkReachable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkReachable", "(Landroid/content/Context;)Z", "GetIsNetworkReachable_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsNetworkReachable (global::Android.Content.Context p0)
		{
			if (id_isNetworkReachable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkReachable_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isNetworkReachable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNetworkReachable_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNetworkReachable", "(Landroid/content/Context;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
#pragma warning disable 0169
		static Delegate GetRegisterDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler ()
		{
			if (cb_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == null)
				cb_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_);
			return cb_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		}

		static void n_RegisterDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataListener (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='registerDataListener' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.base.AccsAbstractDataListener']]"
		[Register ("registerDataListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V", "GetRegisterDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler")]
		public virtual unsafe void RegisterDataListener (global::Android.Content.Context p0, string p1, global::Com.Taobao.Accs.Base.AccsAbstractDataListener p2)
		{
			if (id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == IntPtr.Zero)
				id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNIEnv.GetMethodID (class_ref, "registerDataListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerDataListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSerivce (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='registerSerivce' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerSerivce", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterSerivce (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerSerivce", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSerivce", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_ == null)
				cb_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, short, IntPtr, IntPtr>) n_SendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_);
			return cb_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_;
		}

		static void n_SendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, short p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SendBusinessAck (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendBusinessAck' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='short'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map&lt;com.taobao.accs.base.TaoBaseService.ExtHeaderType, java.lang.String&gt;']]"
		[Register ("sendBusinessAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;SLjava/lang/String;Ljava/util/Map;)V", "GetSendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void SendBusinessAck (string p0, string p1, string p2, short p3, string p4, global::System.Collections.Generic.IDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string> p5)
		{
			if (id_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendBusinessAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;SLjava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBusinessAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;SLjava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
#pragma warning disable 0169
		static Delegate GetSendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler ()
		{
			if (cb_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == null)
				cb_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_);
			return cb_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		}

		static IntPtr n_SendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendData", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "GetSendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler")]
		public virtual unsafe string SendData (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1)
		{
			if (id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetMethodID (class_ref, "sendData", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendData", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Handler ()
		{
			if (cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ == null)
				cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_);
			return cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
		}

		static IntPtr n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendData (p0, p1, p2, p3, p4));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendData' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;", "GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Handler")]
		public virtual unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == null)
				cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_);
			return cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendData (p0, p1, p2, p3, p4, p5));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendData' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Handler ()
		{
			if (cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == null)
				cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_);
			return cb_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		}

		static IntPtr n_SendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p6 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendData (p0, p1, p2, p3, p4, p5, p6));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendData' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.net.URL']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;", "GetSendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Handler")]
		public virtual unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5, global::Java.Net.URL p6)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetSendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static IntPtr n_SendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendPushResponse (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendPushResponse' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("sendPushResponse", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;", "GetSendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public virtual unsafe string SendPushResponse (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "sendPushResponse", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPushResponse", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler ()
		{
			if (cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == null)
				cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_);
			return cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		}

		static IntPtr n_SendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "GetSendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler")]
		public virtual unsafe string SendRequest (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1)
		{
			if (id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_ZHandler ()
		{
			if (cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z == null)
				cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_SendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z);
			return cb_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z;
		}

		static IntPtr n_SendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendRequest (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendRequest' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Ljava/lang/String;Z)Ljava/lang/String;", "GetSendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_ZHandler")]
		public virtual unsafe string SendRequest (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1, string p2, bool p3)
		{
			if (id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == null)
				cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_);
			return cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendRequest (p0, p1, p2, p3, p4, p5));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendRequest' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string SendRequest (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5)
		{
			if (id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Handler ()
		{
			if (cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == null)
				cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_);
			return cb_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		}

		static IntPtr n_SendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p6 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendRequest (p0, p1, p2, p3, p4, p5, p6));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='sendRequest' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.net.URL']]"
		[Register ("sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;", "GetSendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Handler")]
		public virtual unsafe string SendRequest (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5, global::Java.Net.URL p6)
		{
			if (id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_;
#pragma warning disable 0169
		static Delegate GetSetLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_Handler ()
		{
			if (cb_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ == null)
				cb_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_);
			return cb_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_;
		}

		static void n_SetLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ILoginInfo p1 = (global::Com.Taobao.Accs.ILoginInfo)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLoginInfo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='setLoginInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ILoginInfo']]"
		[Register ("setLoginInfo", "(Landroid/content/Context;Lcom/taobao/accs/ILoginInfo;)V", "GetSetLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_Handler")]
		public virtual unsafe void SetLoginInfo (global::Android.Content.Context p0, global::Com.Taobao.Accs.ILoginInfo p1)
		{
			if (id_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ == IntPtr.Zero)
				id_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ = JNIEnv.GetMethodID (class_ref, "setLoginInfo", "(Landroid/content/Context;Lcom/taobao/accs/ILoginInfo;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoginInfo_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoginInfo", "(Landroid/content/Context;Lcom/taobao/accs/ILoginInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMode_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetMode_Landroid_content_Context_IHandler ()
		{
			if (cb_setMode_Landroid_content_Context_I == null)
				cb_setMode_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetMode_Landroid_content_Context_I);
			return cb_setMode_Landroid_content_Context_I;
		}

		static void n_SetMode_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='setMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setMode", "(Landroid/content/Context;I)V", "GetSetMode_Landroid_content_Context_IHandler")]
		public virtual unsafe void SetMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setMode_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setMode", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setProxy_Landroid_content_Context_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetProxy_Landroid_content_Context_Ljava_lang_String_IHandler ()
		{
			if (cb_setProxy_Landroid_content_Context_Ljava_lang_String_I == null)
				cb_setProxy_Landroid_content_Context_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetProxy_Landroid_content_Context_Ljava_lang_String_I);
			return cb_setProxy_Landroid_content_Context_Ljava_lang_String_I;
		}

		static void n_SetProxy_Landroid_content_Context_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetProxy (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setProxy_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='setProxy' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setProxy", "(Landroid/content/Context;Ljava/lang/String;I)V", "GetSetProxy_Landroid_content_Context_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetProxy (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_setProxy_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_setProxy_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setProxy", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProxy_Landroid_content_Context_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProxy", "(Landroid/content/Context;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetStartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_StartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p3 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.StartInAppConnection (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='startInAppConnection' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetStartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void StartInAppConnection (global::Android.Content.Context p0, string p1, string p2, global::Com.Taobao.Accs.IAppReceiver p3)
		{
			if (id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetStartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_StartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p4 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.StartInAppConnection (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='startInAppConnection' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetStartInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void StartInAppConnection (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Taobao.Accs.IAppReceiver p4)
		{
			if (id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterDataListener_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnRegisterDataListener_Landroid_content_Context_Ljava_lang_String_);
			return cb_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_UnRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterDataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='unRegisterDataListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unRegisterDataListener", "(Landroid/content/Context;Ljava/lang/String;)V", "GetUnRegisterDataListener_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterDataListener (global::Android.Content.Context p0, string p1)
		{
			if (id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unRegisterDataListener", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisterDataListener", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterSerivce_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnRegisterSerivce_Landroid_content_Context_Ljava_lang_String_);
			return cb_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_UnRegisterSerivce_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterSerivce (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='unRegisterSerivce' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unRegisterSerivce", "(Landroid/content/Context;Ljava/lang/String;)V", "GetUnRegisterSerivce_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterSerivce (global::Android.Content.Context p0, string p1)
		{
			if (id_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unRegisterSerivce", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterSerivce_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisterSerivce", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_unbindApp_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUnbindApp_Landroid_content_Context_Handler ()
		{
			if (cb_unbindApp_Landroid_content_Context_ == null)
				cb_unbindApp_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindApp_Landroid_content_Context_);
			return cb_unbindApp_Landroid_content_Context_;
		}

		static void n_UnbindApp_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindApp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unbindApp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='unbindApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unbindApp", "(Landroid/content/Context;)V", "GetUnbindApp_Landroid_content_Context_Handler")]
		public virtual unsafe void UnbindApp (global::Android.Content.Context p0)
		{
			if (id_unbindApp_Landroid_content_Context_ == IntPtr.Zero)
				id_unbindApp_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unbindApp", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindApp_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbindApp", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unbindService_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnbindService_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_unbindService_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_unbindService_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnbindService_Landroid_content_Context_Ljava_lang_String_);
			return cb_unbindService_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_UnbindService_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnbindService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unbindService_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='unbindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unbindService", "(Landroid/content/Context;Ljava/lang/String;)V", "GetUnbindService_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void UnbindService (global::Android.Content.Context p0, string p1)
		{
			if (id_unbindService_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unbindService_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unbindService", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindService_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbindService", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_unbindUser_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUnbindUser_Landroid_content_Context_Handler ()
		{
			if (cb_unbindUser_Landroid_content_Context_ == null)
				cb_unbindUser_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindUser_Landroid_content_Context_);
			return cb_unbindUser_Landroid_content_Context_;
		}

		static void n_UnbindUser_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unbindUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='unbindUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unbindUser", "(Landroid/content/Context;)V", "GetUnbindUser_Landroid_content_Context_Handler")]
		public virtual unsafe void UnbindUser (global::Android.Content.Context p0)
		{
			if (id_unbindUser_Landroid_content_Context_ == IntPtr.Zero)
				id_unbindUser_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unbindUser", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindUser_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbindUser", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateConfig_Lcom_taobao_accs_AccsClientConfig_;
#pragma warning disable 0169
		static Delegate GetUpdateConfig_Lcom_taobao_accs_AccsClientConfig_Handler ()
		{
			if (cb_updateConfig_Lcom_taobao_accs_AccsClientConfig_ == null)
				cb_updateConfig_Lcom_taobao_accs_AccsClientConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateConfig_Lcom_taobao_accs_AccsClientConfig_);
			return cb_updateConfig_Lcom_taobao_accs_AccsClientConfig_;
		}

		static void n_UpdateConfig_Lcom_taobao_accs_AccsClientConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Internal.ACCSManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Internal.ACCSManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.AccsClientConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateConfig_Lcom_taobao_accs_AccsClientConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.internal']/class[@name='ACCSManagerImpl']/method[@name='updateConfig' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.AccsClientConfig']]"
		[Register ("updateConfig", "(Lcom/taobao/accs/AccsClientConfig;)V", "GetUpdateConfig_Lcom_taobao_accs_AccsClientConfig_Handler")]
		public virtual unsafe void UpdateConfig (global::Com.Taobao.Accs.AccsClientConfig p0)
		{
			if (id_updateConfig_Lcom_taobao_accs_AccsClientConfig_ == IntPtr.Zero)
				id_updateConfig_Lcom_taobao_accs_AccsClientConfig_ = JNIEnv.GetMethodID (class_ref, "updateConfig", "(Lcom/taobao/accs/AccsClientConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConfig_Lcom_taobao_accs_AccsClientConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConfig", "(Lcom/taobao/accs/AccsClientConfig;)V"), __args);
			} finally {
			}
		}

	}
}

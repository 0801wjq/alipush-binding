using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']"
	[global::Android.Runtime.Register ("com/taobao/accs/ACCSClient", DoNotGenerateAcw=true)]
	public partial class ACCSClient : global::Java.Lang.Object {


		static IntPtr mACCSClients_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/field[@name='mACCSClients']"
		[Register ("mACCSClients")]
		public static global::System.Collections.IDictionary MACCSClients {
			get {
				if (mACCSClients_jfieldId == IntPtr.Zero)
					mACCSClients_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mACCSClients", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mACCSClients_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mACCSClients_jfieldId == IntPtr.Zero)
					mACCSClients_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mACCSClients", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mACCSClients_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccsManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/field[@name='mAccsManager']"
		[Register ("mAccsManager")]
		protected global::Com.Taobao.Accs.IACCSManager MAccsManager {
			get {
				if (mAccsManager_jfieldId == IntPtr.Zero)
					mAccsManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccsManager", "Lcom/taobao/accs/IACCSManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccsManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IACCSManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccsManager_jfieldId == IntPtr.Zero)
					mAccsManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccsManager", "Lcom/taobao/accs/IACCSManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccsManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/ACCSClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ACCSClient); }
		}

		protected ACCSClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/constructor[@name='ACCSClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.AccsClientConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)V", "")]
		public unsafe ACCSClient (global::Android.Content.Context p0, global::Com.Taobao.Accs.AccsClientConfig p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ACCSClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_, __args);
			} finally {
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
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.ChannelState);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelState;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> ChannelState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='getChannelState' and count(parameter)=0]"
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

		static Delegate cb_isNetworkReachable;
#pragma warning disable 0169
		static Delegate GetIsNetworkReachableHandler ()
		{
			if (cb_isNetworkReachable == null)
				cb_isNetworkReachable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNetworkReachable);
			return cb_isNetworkReachable;
		}

		static bool n_IsNetworkReachable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNetworkReachable;
		}
#pragma warning restore 0169

		static IntPtr id_isNetworkReachable;
		public virtual unsafe bool IsNetworkReachable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='isNetworkReachable' and count(parameter)=0]"
			[Register ("isNetworkReachable", "()Z", "GetIsNetworkReachableHandler")]
			get {
				if (id_isNetworkReachable == IntPtr.Zero)
					id_isNetworkReachable = JNIEnv.GetMethodID (class_ref, "isNetworkReachable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNetworkReachable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNetworkReachable", "()Z"));
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
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserUnit);
		}
#pragma warning restore 0169

		static IntPtr id_getUserUnit;
		public virtual unsafe string UserUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='getUserUnit' and count(parameter)=0]"
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

		static Delegate cb_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetBindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_BindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p1 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindApp (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='bindApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("bindApp", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetBindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void BindApp (string p0, global::Com.Taobao.Accs.IAppReceiver p1)
		{
			if (id_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "bindApp", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindApp_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindApp", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_bindService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBindService_Ljava_lang_String_Handler ()
		{
			if (cb_bindService_Ljava_lang_String_ == null)
				cb_bindService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindService_Ljava_lang_String_);
			return cb_bindService_Ljava_lang_String_;
		}

		static void n_BindService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bindService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='bindService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bindService", "(Ljava/lang/String;)V", "GetBindService_Ljava_lang_String_Handler")]
		public virtual unsafe void BindService (string p0)
		{
			if (id_bindService_Ljava_lang_String_ == IntPtr.Zero)
				id_bindService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bindService", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindService_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindService", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_bindUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBindUser_Ljava_lang_String_Handler ()
		{
			if (cb_bindUser_Ljava_lang_String_ == null)
				cb_bindUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindUser_Ljava_lang_String_);
			return cb_bindUser_Ljava_lang_String_;
		}

		static void n_BindUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bindUser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='bindUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bindUser", "(Ljava/lang/String;)V", "GetBindUser_Ljava_lang_String_Handler")]
		public virtual unsafe void BindUser (string p0)
		{
			if (id_bindUser_Ljava_lang_String_ == IntPtr.Zero)
				id_bindUser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bindUser", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindUser_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindUser", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_bindUser_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetBindUser_Ljava_lang_String_ZHandler ()
		{
			if (cb_bindUser_Ljava_lang_String_Z == null)
				cb_bindUser_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_BindUser_Ljava_lang_String_Z);
			return cb_bindUser_Ljava_lang_String_Z;
		}

		static void n_BindUser_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindUser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindUser_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='bindUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("bindUser", "(Ljava/lang/String;Z)V", "GetBindUser_Ljava_lang_String_ZHandler")]
		public virtual unsafe void BindUser (string p0, bool p1)
		{
			if (id_bindUser_Ljava_lang_String_Z == IntPtr.Zero)
				id_bindUser_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "bindUser", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindUser_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindUser", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cancel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCancel_Ljava_lang_String_Handler ()
		{
			if (cb_cancel_Ljava_lang_String_ == null)
				cb_cancel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Cancel_Ljava_lang_String_);
			return cb_cancel_Ljava_lang_String_;
		}

		static bool n_Cancel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Cancel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cancel", "(Ljava/lang/String;)Z", "GetCancel_Ljava_lang_String_Handler")]
		public virtual unsafe bool Cancel (string p0)
		{
			if (id_cancel_Ljava_lang_String_ == IntPtr.Zero)
				id_cancel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clearLoginInfo;
#pragma warning disable 0169
		static Delegate GetClearLoginInfoHandler ()
		{
			if (cb_clearLoginInfo == null)
				cb_clearLoginInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearLoginInfo);
			return cb_clearLoginInfo;
		}

		static void n_ClearLoginInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearLoginInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_clearLoginInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='clearLoginInfo' and count(parameter)=0]"
		[Register ("clearLoginInfo", "()V", "GetClearLoginInfoHandler")]
		public virtual unsafe void ClearLoginInfo ()
		{
			if (id_clearLoginInfo == IntPtr.Zero)
				id_clearLoginInfo = JNIEnv.GetMethodID (class_ref, "clearLoginInfo", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearLoginInfo);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearLoginInfo", "()V"));
			} finally {
			}
		}

		static Delegate cb_forceDisableService;
#pragma warning disable 0169
		static Delegate GetForceDisableServiceHandler ()
		{
			if (cb_forceDisableService == null)
				cb_forceDisableService = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceDisableService);
			return cb_forceDisableService;
		}

		static void n_ForceDisableService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceDisableService ();
		}
#pragma warning restore 0169

		static IntPtr id_forceDisableService;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='forceDisableService' and count(parameter)=0]"
		[Register ("forceDisableService", "()V", "GetForceDisableServiceHandler")]
		public virtual unsafe void ForceDisableService ()
		{
			if (id_forceDisableService == IntPtr.Zero)
				id_forceDisableService = JNIEnv.GetMethodID (class_ref, "forceDisableService", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceDisableService);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceDisableService", "()V"));
			} finally {
			}
		}

		static Delegate cb_forceEnableService;
#pragma warning disable 0169
		static Delegate GetForceEnableServiceHandler ()
		{
			if (cb_forceEnableService == null)
				cb_forceEnableService = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceEnableService);
			return cb_forceEnableService;
		}

		static void n_ForceEnableService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceEnableService ();
		}
#pragma warning restore 0169

		static IntPtr id_forceEnableService;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='forceEnableService' and count(parameter)=0]"
		[Register ("forceEnableService", "()V", "GetForceEnableServiceHandler")]
		public virtual unsafe void ForceEnableService ()
		{
			if (id_forceEnableService == IntPtr.Zero)
				id_forceEnableService = JNIEnv.GetMethodID (class_ref, "forceEnableService", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceEnableService);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceEnableService", "()V"));
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
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.ForceReConnectChannel ());
		}
#pragma warning restore 0169

		static IntPtr id_forceReConnectChannel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='forceReConnectChannel' and count(parameter)=0]"
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

		static IntPtr id_getAccsClient_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='getAccsClient' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccsClient", "(Ljava/lang/String;)Lcom/taobao/accs/ACCSClient;", "")]
		public static unsafe global::Com.Taobao.Accs.ACCSClient GetAccsClient (string p0)
		{
			if (id_getAccsClient_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccsClient_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAccsClient", "(Ljava/lang/String;)Lcom/taobao/accs/ACCSClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Taobao.Accs.ACCSClient __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccsClient_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_init_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.AccsClientConfig']]"
		[Register ("init", "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)Ljava/lang/String;", "")]
		public static unsafe string Init (global::Android.Content.Context p0, global::Com.Taobao.Accs.AccsClientConfig p1)
		{
			if (id_init_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/taobao/accs/AccsClientConfig;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_init_Landroid_content_Context_Lcom_taobao_accs_AccsClientConfig_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Init (global::Android.Content.Context p0, string p1)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChannelError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isChannelError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='isChannelError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
#pragma warning disable 0169
		static Delegate GetRegisterDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler ()
		{
			if (cb_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == null)
				cb_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_);
			return cb_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		}

		static void n_RegisterDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='registerDataListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.base.AccsAbstractDataListener']]"
		[Register ("registerDataListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V", "GetRegisterDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler")]
		public virtual unsafe void RegisterDataListener (string p0, global::Com.Taobao.Accs.Base.AccsAbstractDataListener p1)
		{
			if (id_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == IntPtr.Zero)
				id_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNIEnv.GetMethodID (class_ref, "registerDataListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDataListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerDataListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerSerivce_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterSerivce_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerSerivce_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerSerivce_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSerivce_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerSerivce_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterSerivce_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSerivce (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerSerivce_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='registerSerivce' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerSerivce", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterSerivce_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterSerivce (string p0, string p1)
		{
			if (id_registerSerivce_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerSerivce_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerSerivce", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerSerivce_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSerivce", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SendBusinessAck (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_sendBusinessAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SLjava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='sendBusinessAck' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='short'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map&lt;com.taobao.accs.base.TaoBaseService.ExtHeaderType, java.lang.String&gt;']]"
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

		static Delegate cb_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_;
#pragma warning disable 0169
		static Delegate GetSendData_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler ()
		{
			if (cb_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_ == null)
				cb_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendData_Lcom_taobao_accs_ACCSManager_AccsRequest_);
			return cb_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		}

		static IntPtr n_SendData_Lcom_taobao_accs_ACCSManager_AccsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='sendData' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendData", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "GetSendData_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler")]
		public virtual unsafe string SendData (global::Com.Taobao.Accs.ACCSManager.AccsRequest p0)
		{
			if (id_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetMethodID (class_ref, "sendData", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendData_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendData", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetSendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static IntPtr n_SendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendPushResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='sendPushResponse' and count(parameter)=2 and parameter[1][@type='com.taobao.accs.ACCSManager.AccsRequest'] and parameter[2][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("sendPushResponse", "(Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;", "GetSendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public virtual unsafe string SendPushResponse (global::Com.Taobao.Accs.ACCSManager.AccsRequest p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			if (id_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "sendPushResponse", "(Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendPushResponse_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPushResponse", "(Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler ()
		{
			if (cb_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_ == null)
				cb_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_);
			return cb_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		}

		static IntPtr n_SendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ACCSManager.AccsRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='sendRequest' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendRequest", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "GetSendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_Handler")]
		public virtual unsafe string SendRequest (global::Com.Taobao.Accs.ACCSManager.AccsRequest p0)
		{
			if (id_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setEnvironment_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='setEnvironment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setEnvironment", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetEnvironment (global::Android.Content.Context p0, int p1)
		{
			if (id_setEnvironment_Landroid_content_Context_I == IntPtr.Zero)
				id_setEnvironment_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setEnvironment", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnvironment_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static Delegate cb_setLoginInfo_Lcom_taobao_accs_ILoginInfo_;
#pragma warning disable 0169
		static Delegate GetSetLoginInfo_Lcom_taobao_accs_ILoginInfo_Handler ()
		{
			if (cb_setLoginInfo_Lcom_taobao_accs_ILoginInfo_ == null)
				cb_setLoginInfo_Lcom_taobao_accs_ILoginInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoginInfo_Lcom_taobao_accs_ILoginInfo_);
			return cb_setLoginInfo_Lcom_taobao_accs_ILoginInfo_;
		}

		static void n_SetLoginInfo_Lcom_taobao_accs_ILoginInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ILoginInfo p0 = (global::Com.Taobao.Accs.ILoginInfo)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLoginInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoginInfo_Lcom_taobao_accs_ILoginInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='setLoginInfo' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.ILoginInfo']]"
		[Register ("setLoginInfo", "(Lcom/taobao/accs/ILoginInfo;)V", "GetSetLoginInfo_Lcom_taobao_accs_ILoginInfo_Handler")]
		public virtual unsafe void SetLoginInfo (global::Com.Taobao.Accs.ILoginInfo p0)
		{
			if (id_setLoginInfo_Lcom_taobao_accs_ILoginInfo_ == IntPtr.Zero)
				id_setLoginInfo_Lcom_taobao_accs_ILoginInfo_ = JNIEnv.GetMethodID (class_ref, "setLoginInfo", "(Lcom/taobao/accs/ILoginInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoginInfo_Lcom_taobao_accs_ILoginInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoginInfo", "(Lcom/taobao/accs/ILoginInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetStartInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_StartInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p1 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartInAppConnection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='startInAppConnection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("startInAppConnection", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetStartInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void StartInAppConnection (string p0, global::Com.Taobao.Accs.IAppReceiver p1)
		{
			if (id_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "startInAppConnection", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startInAppConnection_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startInAppConnection", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unRegisterDataListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterDataListener_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterDataListener_Ljava_lang_String_ == null)
				cb_unRegisterDataListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterDataListener_Ljava_lang_String_);
			return cb_unRegisterDataListener_Ljava_lang_String_;
		}

		static void n_UnRegisterDataListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterDataListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unRegisterDataListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='unRegisterDataListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterDataListener", "(Ljava/lang/String;)V", "GetUnRegisterDataListener_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterDataListener (string p0)
		{
			if (id_unRegisterDataListener_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterDataListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unRegisterDataListener", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterDataListener_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisterDataListener", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unRegisterSerivce_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterSerivce_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterSerivce_Ljava_lang_String_ == null)
				cb_unRegisterSerivce_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterSerivce_Ljava_lang_String_);
			return cb_unRegisterSerivce_Ljava_lang_String_;
		}

		static void n_UnRegisterSerivce_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterSerivce (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unRegisterSerivce_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='unRegisterSerivce' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterSerivce", "(Ljava/lang/String;)V", "GetUnRegisterSerivce_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterSerivce (string p0)
		{
			if (id_unRegisterSerivce_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterSerivce_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unRegisterSerivce", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterSerivce_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisterSerivce", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unbindService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnbindService_Ljava_lang_String_Handler ()
		{
			if (cb_unbindService_Ljava_lang_String_ == null)
				cb_unbindService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindService_Ljava_lang_String_);
			return cb_unbindService_Ljava_lang_String_;
		}

		static void n_UnbindService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unbindService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='unbindService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unbindService", "(Ljava/lang/String;)V", "GetUnbindService_Ljava_lang_String_Handler")]
		public virtual unsafe void UnbindService (string p0)
		{
			if (id_unbindService_Ljava_lang_String_ == IntPtr.Zero)
				id_unbindService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unbindService", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindService_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbindService", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unbindUser;
#pragma warning disable 0169
		static Delegate GetUnbindUserHandler ()
		{
			if (cb_unbindUser == null)
				cb_unbindUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnbindUser);
			return cb_unbindUser;
		}

		static void n_UnbindUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ACCSClient __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnbindUser ();
		}
#pragma warning restore 0169

		static IntPtr id_unbindUser;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSClient']/method[@name='unbindUser' and count(parameter)=0]"
		[Register ("unbindUser", "()V", "GetUnbindUserHandler")]
		public virtual unsafe void UnbindUser ()
		{
			if (id_unbindUser == IntPtr.Zero)
				id_unbindUser = JNIEnv.GetMethodID (class_ref, "unbindUser", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindUser);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbindUser", "()V"));
			} finally {
			}
		}

	}
}

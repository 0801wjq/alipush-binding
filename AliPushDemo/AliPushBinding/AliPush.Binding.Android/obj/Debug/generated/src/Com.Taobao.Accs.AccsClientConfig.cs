using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']"
	[global::Android.Runtime.Register ("com/taobao/accs/AccsClientConfig", DoNotGenerateAcw=true)]
	public partial class AccsClientConfig : global::Java.Lang.Object {


		static IntPtr DEFAULT_CENTER_HOSTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='DEFAULT_CENTER_HOSTS']"
		[Register ("DEFAULT_CENTER_HOSTS")]
		public static IList<string> DefaultCenterHosts {
			get {
				if (DEFAULT_CENTER_HOSTS_jfieldId == IntPtr.Zero)
					DEFAULT_CENTER_HOSTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CENTER_HOSTS", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, DEFAULT_CENTER_HOSTS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='DEFAULT_CONFIGTAG']"
		[Register ("DEFAULT_CONFIGTAG")]
		public const string DefaultConfigtag = (string) "default";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='SECURITY_OFF']"
		[Register ("SECURITY_OFF")]
		public const int SecurityOff = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='SECURITY_OPEN']"
		[Register ("SECURITY_OPEN")]
		public const int SecurityOpen = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='SECURITY_TAOBAO']"
		[Register ("SECURITY_TAOBAO")]
		public const int SecurityTaobao = (int) 0;

		static IntPtr mEnv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/field[@name='mEnv']"
		[Register ("mEnv")]
		public static int MEnv {
			get {
				if (mEnv_jfieldId == IntPtr.Zero)
					mEnv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mEnv", "I");
				return JNIEnv.GetStaticIntField (class_ref, mEnv_jfieldId);
			}
			set {
				if (mEnv_jfieldId == IntPtr.Zero)
					mEnv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mEnv", "I");
				try {
					JNIEnv.SetStaticField (class_ref, mEnv_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']"
		[global::Android.Runtime.Register ("com/taobao/accs/AccsClientConfig$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/AccsClientConfig$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/constructor[@name='AccsClientConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/taobao/accs/AccsClientConfig;", "GetBuildHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/taobao/accs/AccsClientConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/taobao/accs/AccsClientConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAppKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAppKey_Ljava_lang_String_Handler ()
			{
				if (cb_setAppKey_Ljava_lang_String_ == null)
					cb_setAppKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppKey_Ljava_lang_String_);
				return cb_setAppKey_Ljava_lang_String_;
			}

			static IntPtr n_SetAppKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppKey (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAppKey_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppKey", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetAppKey_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetAppKey (string p0)
			{
				if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAppKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppKey", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setAppSecret_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAppSecret_Ljava_lang_String_Handler ()
			{
				if (cb_setAppSecret_Ljava_lang_String_ == null)
					cb_setAppSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppSecret_Ljava_lang_String_);
				return cb_setAppSecret_Ljava_lang_String_;
			}

			static IntPtr n_SetAppSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppSecret (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAppSecret_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppSecret", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetAppSecret_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetAppSecret (string p0)
			{
				if (id_setAppSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSecret", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAppSecret_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppSecret", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setAutoCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAutoCode_Ljava_lang_String_Handler ()
			{
				if (cb_setAutoCode_Ljava_lang_String_ == null)
					cb_setAutoCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAutoCode_Ljava_lang_String_);
				return cb_setAutoCode_Ljava_lang_String_;
			}

			static IntPtr n_SetAutoCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAutoCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAutoCode_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setAutoCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAutoCode", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetAutoCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetAutoCode (string p0)
			{
				if (id_setAutoCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setAutoCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAutoCode", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAutoCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoCode", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setAutoUnit_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoUnit_ZHandler ()
			{
				if (cb_setAutoUnit_Z == null)
					cb_setAutoUnit_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAutoUnit_Z);
				return cb_setAutoUnit_Z;
			}

			static IntPtr n_SetAutoUnit_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAutoUnit (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setAutoUnit_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setAutoUnit' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoUnit", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetAutoUnit_ZHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetAutoUnit (bool p0)
			{
				if (id_setAutoUnit_Z == IntPtr.Zero)
					id_setAutoUnit_Z = JNIEnv.GetMethodID (class_ref, "setAutoUnit", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAutoUnit_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoUnit", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setChannelHost_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetChannelHost_Ljava_lang_String_Handler ()
			{
				if (cb_setChannelHost_Ljava_lang_String_ == null)
					cb_setChannelHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetChannelHost_Ljava_lang_String_);
				return cb_setChannelHost_Ljava_lang_String_;
			}

			static IntPtr n_SetChannelHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetChannelHost (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setChannelHost_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setChannelHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChannelHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetChannelHost_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetChannelHost (string p0)
			{
				if (id_setChannelHost_Ljava_lang_String_ == IntPtr.Zero)
					id_setChannelHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannelHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChannelHost_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setChannelPubKey_I;
#pragma warning disable 0169
			static Delegate GetSetChannelPubKey_IHandler ()
			{
				if (cb_setChannelPubKey_I == null)
					cb_setChannelPubKey_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetChannelPubKey_I);
				return cb_setChannelPubKey_I;
			}

			static IntPtr n_SetChannelPubKey_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetChannelPubKey (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setChannelPubKey_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setChannelPubKey' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setChannelPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetChannelPubKey_IHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetChannelPubKey (int p0)
			{
				if (id_setChannelPubKey_I == IntPtr.Zero)
					id_setChannelPubKey_I = JNIEnv.GetMethodID (class_ref, "setChannelPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChannelPubKey_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setConfigEnv_I;
#pragma warning disable 0169
			static Delegate GetSetConfigEnv_IHandler ()
			{
				if (cb_setConfigEnv_I == null)
					cb_setConfigEnv_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetConfigEnv_I);
				return cb_setConfigEnv_I;
			}

			static IntPtr n_SetConfigEnv_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetConfigEnv (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setConfigEnv_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setConfigEnv' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConfigEnv", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetConfigEnv_IHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetConfigEnv (int p0)
			{
				if (id_setConfigEnv_I == IntPtr.Zero)
					id_setConfigEnv_I = JNIEnv.GetMethodID (class_ref, "setConfigEnv", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConfigEnv_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfigEnv", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDisableChannel_Z;
#pragma warning disable 0169
			static Delegate GetSetDisableChannel_ZHandler ()
			{
				if (cb_setDisableChannel_Z == null)
					cb_setDisableChannel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableChannel_Z);
				return cb_setDisableChannel_Z;
			}

			static IntPtr n_SetDisableChannel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDisableChannel (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setDisableChannel_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setDisableChannel' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisableChannel", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetDisableChannel_ZHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetDisableChannel (bool p0)
			{
				if (id_setDisableChannel_Z == IntPtr.Zero)
					id_setDisableChannel_Z = JNIEnv.GetMethodID (class_ref, "setDisableChannel", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableChannel_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisableChannel", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInappHost_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetInappHost_Ljava_lang_String_Handler ()
			{
				if (cb_setInappHost_Ljava_lang_String_ == null)
					cb_setInappHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInappHost_Ljava_lang_String_);
				return cb_setInappHost_Ljava_lang_String_;
			}

			static IntPtr n_SetInappHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInappHost (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInappHost_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setInappHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInappHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetInappHost_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetInappHost (string p0)
			{
				if (id_setInappHost_Ljava_lang_String_ == IntPtr.Zero)
					id_setInappHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInappHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInappHost_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInappHost", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setInappPubKey_I;
#pragma warning disable 0169
			static Delegate GetSetInappPubKey_IHandler ()
			{
				if (cb_setInappPubKey_I == null)
					cb_setInappPubKey_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetInappPubKey_I);
				return cb_setInappPubKey_I;
			}

			static IntPtr n_SetInappPubKey_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetInappPubKey (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setInappPubKey_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setInappPubKey' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInappPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetInappPubKey_IHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetInappPubKey (int p0)
			{
				if (id_setInappPubKey_I == IntPtr.Zero)
					id_setInappPubKey_I = JNIEnv.GetMethodID (class_ref, "setInappPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInappPubKey_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInappPubKey", "(I)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setKeepAlive_Z;
#pragma warning disable 0169
			static Delegate GetSetKeepAlive_ZHandler ()
			{
				if (cb_setKeepAlive_Z == null)
					cb_setKeepAlive_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetKeepAlive_Z);
				return cb_setKeepAlive_Z;
			}

			static IntPtr n_SetKeepAlive_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetKeepAlive (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setKeepAlive_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setKeepAlive' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setKeepAlive", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetKeepAlive_ZHandler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetKeepAlive (bool p0)
			{
				if (id_setKeepAlive_Z == IntPtr.Zero)
					id_setKeepAlive_Z = JNIEnv.GetMethodID (class_ref, "setKeepAlive", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKeepAlive_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAlive", "(Z)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTag_Ljava_lang_String_Handler ()
			{
				if (cb_setTag_Ljava_lang_String_ == null)
					cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_String_);
				return cb_setTag_Ljava_lang_String_;
			}

			static IntPtr n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.AccsClientConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTag_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig.Builder']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTag", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;", "GetSetTag_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.AccsClientConfig.Builder SetTag (string p0)
			{
				if (id_setTag_Ljava_lang_String_ == IntPtr.Zero)
					id_setTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Taobao.Accs.AccsClientConfig.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTag", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='AccsClientConfig.ENV']"
		[Register ("com/taobao/accs/AccsClientConfig$ENV", "", "Com.Taobao.Accs.AccsClientConfig/IENVInvoker")]
		public partial interface IENV : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/taobao/accs/AccsClientConfig$ENV", DoNotGenerateAcw=true)]
		internal class IENVInvoker : global::Java.Lang.Object, IENV {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/AccsClientConfig$ENV");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IENVInvoker); }
			}

			IntPtr class_ref;

			public static IENV GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IENV> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.AccsClientConfig.ENV"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IENVInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.IENV __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.IENV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Taobao.Accs.AccsClientConfig.IENV __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.IENV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.IENV __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.IENV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.IENV __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.IENV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='AccsClientConfig.SECURITY_TYPE']"
		[Register ("com/taobao/accs/AccsClientConfig$SECURITY_TYPE", "", "Com.Taobao.Accs.AccsClientConfig/ISECURITY_TYPEInvoker")]
		public partial interface ISECURITY_TYPE : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/taobao/accs/AccsClientConfig$SECURITY_TYPE", DoNotGenerateAcw=true)]
		internal class ISECURITY_TYPEInvoker : global::Java.Lang.Object, ISECURITY_TYPE {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/AccsClientConfig$SECURITY_TYPE");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISECURITY_TYPEInvoker); }
			}

			IntPtr class_ref;

			public static ISECURITY_TYPE GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISECURITY_TYPE> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.AccsClientConfig.SECURITY_TYPE"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISECURITY_TYPEInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.ISECURITY_TYPE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/AccsClientConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccsClientConfig); }
		}

		protected AccsClientConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/constructor[@name='AccsClientConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AccsClientConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AccsClientConfig)) {
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

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		public virtual unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppSecret;
#pragma warning disable 0169
		static Delegate GetGetAppSecretHandler ()
		{
			if (cb_getAppSecret == null)
				cb_getAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSecret);
			return cb_getAppSecret;
		}

		static IntPtr n_GetAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getAppSecret;
		public virtual unsafe string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthCode;
#pragma warning disable 0169
		static Delegate GetGetAuthCodeHandler ()
		{
			if (cb_getAuthCode == null)
				cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
			return cb_getAuthCode;
		}

		static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getAuthCode' and count(parameter)=0]"
			[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
			get {
				if (id_getAuthCode == IntPtr.Zero)
					id_getAuthCode = JNIEnv.GetMethodID (class_ref, "getAuthCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelHost;
#pragma warning disable 0169
		static Delegate GetGetChannelHostHandler ()
		{
			if (cb_getChannelHost == null)
				cb_getChannelHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelHost);
			return cb_getChannelHost;
		}

		static IntPtr n_GetChannelHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelHost);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelHost;
		public virtual unsafe string ChannelHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getChannelHost' and count(parameter)=0]"
			[Register ("getChannelHost", "()Ljava/lang/String;", "GetGetChannelHostHandler")]
			get {
				if (id_getChannelHost == IntPtr.Zero)
					id_getChannelHost = JNIEnv.GetMethodID (class_ref, "getChannelHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelPubKey;
#pragma warning disable 0169
		static Delegate GetGetChannelPubKeyHandler ()
		{
			if (cb_getChannelPubKey == null)
				cb_getChannelPubKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelPubKey);
			return cb_getChannelPubKey;
		}

		static int n_GetChannelPubKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelPubKey;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelPubKey;
		public virtual unsafe int ChannelPubKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getChannelPubKey' and count(parameter)=0]"
			[Register ("getChannelPubKey", "()I", "GetGetChannelPubKeyHandler")]
			get {
				if (id_getChannelPubKey == IntPtr.Zero)
					id_getChannelPubKey = JNIEnv.GetMethodID (class_ref, "getChannelPubKey", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelPubKey);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelPubKey", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getConfigEnv;
#pragma warning disable 0169
		static Delegate GetGetConfigEnvHandler ()
		{
			if (cb_getConfigEnv == null)
				cb_getConfigEnv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConfigEnv);
			return cb_getConfigEnv;
		}

		static int n_GetConfigEnv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConfigEnv;
		}
#pragma warning restore 0169

		static IntPtr id_getConfigEnv;
		public virtual unsafe int ConfigEnv {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getConfigEnv' and count(parameter)=0]"
			[Register ("getConfigEnv", "()I", "GetGetConfigEnvHandler")]
			get {
				if (id_getConfigEnv == IntPtr.Zero)
					id_getConfigEnv = JNIEnv.GetMethodID (class_ref, "getConfigEnv", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConfigEnv);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfigEnv", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisableChannel;
#pragma warning disable 0169
		static Delegate GetGetDisableChannelHandler ()
		{
			if (cb_getDisableChannel == null)
				cb_getDisableChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetDisableChannel);
			return cb_getDisableChannel;
		}

		static bool n_GetDisableChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableChannel;
		}
#pragma warning restore 0169

		static IntPtr id_getDisableChannel;
		public virtual unsafe bool DisableChannel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getDisableChannel' and count(parameter)=0]"
			[Register ("getDisableChannel", "()Z", "GetGetDisableChannelHandler")]
			get {
				if (id_getDisableChannel == IntPtr.Zero)
					id_getDisableChannel = JNIEnv.GetMethodID (class_ref, "getDisableChannel", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDisableChannel);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisableChannel", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getInappHost;
#pragma warning disable 0169
		static Delegate GetGetInappHostHandler ()
		{
			if (cb_getInappHost == null)
				cb_getInappHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInappHost);
			return cb_getInappHost;
		}

		static IntPtr n_GetInappHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InappHost);
		}
#pragma warning restore 0169

		static IntPtr id_getInappHost;
		public virtual unsafe string InappHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getInappHost' and count(parameter)=0]"
			[Register ("getInappHost", "()Ljava/lang/String;", "GetGetInappHostHandler")]
			get {
				if (id_getInappHost == IntPtr.Zero)
					id_getInappHost = JNIEnv.GetMethodID (class_ref, "getInappHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInappHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInappHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInappPubKey;
#pragma warning disable 0169
		static Delegate GetGetInappPubKeyHandler ()
		{
			if (cb_getInappPubKey == null)
				cb_getInappPubKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInappPubKey);
			return cb_getInappPubKey;
		}

		static int n_GetInappPubKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InappPubKey;
		}
#pragma warning restore 0169

		static IntPtr id_getInappPubKey;
		public virtual unsafe int InappPubKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getInappPubKey' and count(parameter)=0]"
			[Register ("getInappPubKey", "()I", "GetGetInappPubKeyHandler")]
			get {
				if (id_getInappPubKey == IntPtr.Zero)
					id_getInappPubKey = JNIEnv.GetMethodID (class_ref, "getInappPubKey", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInappPubKey);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInappPubKey", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isAutoUnit;
#pragma warning disable 0169
		static Delegate GetIsAutoUnitHandler ()
		{
			if (cb_isAutoUnit == null)
				cb_isAutoUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoUnit);
			return cb_isAutoUnit;
		}

		static bool n_IsAutoUnit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoUnit;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoUnit;
		public virtual unsafe bool IsAutoUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='isAutoUnit' and count(parameter)=0]"
			[Register ("isAutoUnit", "()Z", "GetIsAutoUnitHandler")]
			get {
				if (id_isAutoUnit == IntPtr.Zero)
					id_isAutoUnit = JNIEnv.GetMethodID (class_ref, "isAutoUnit", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoUnit);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoUnit", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isKeepalive;
#pragma warning disable 0169
		static Delegate GetIsKeepaliveHandler ()
		{
			if (cb_isKeepalive == null)
				cb_isKeepalive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKeepalive);
			return cb_isKeepalive;
		}

		static bool n_IsKeepalive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKeepalive;
		}
#pragma warning restore 0169

		static IntPtr id_isKeepalive;
		public virtual unsafe bool IsKeepalive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='isKeepalive' and count(parameter)=0]"
			[Register ("isKeepalive", "()Z", "GetIsKeepaliveHandler")]
			get {
				if (id_isKeepalive == IntPtr.Zero)
					id_isKeepalive = JNIEnv.GetMethodID (class_ref, "isKeepalive", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKeepalive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKeepalive", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSecurity;
#pragma warning disable 0169
		static Delegate GetGetSecurityHandler ()
		{
			if (cb_getSecurity == null)
				cb_getSecurity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSecurity);
			return cb_getSecurity;
		}

		static int n_GetSecurity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Security;
		}
#pragma warning restore 0169

		static IntPtr id_getSecurity;
		public virtual unsafe int Security {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getSecurity' and count(parameter)=0]"
			[Register ("getSecurity", "()I", "GetGetSecurityHandler")]
			get {
				if (id_getSecurity == IntPtr.Zero)
					id_getSecurity = JNIEnv.GetMethodID (class_ref, "getSecurity", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSecurity);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecurity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.AccsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfig", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig;", "")]
		public static unsafe global::Com.Taobao.Accs.AccsClientConfig GetConfig (string p0)
		{
			if (id_getConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfig_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConfig", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Taobao.Accs.AccsClientConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConfig_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getConfigByTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='AccsClientConfig']/method[@name='getConfigByTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfigByTag", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig;", "")]
		public static unsafe global::Com.Taobao.Accs.AccsClientConfig GetConfigByTag (string p0)
		{
			if (id_getConfigByTag_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfigByTag_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConfigByTag", "(Ljava/lang/String;)Lcom/taobao/accs/AccsClientConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Taobao.Accs.AccsClientConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConfigByTag_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

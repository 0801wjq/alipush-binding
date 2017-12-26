using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']"
	[global::Android.Runtime.Register ("com/taobao/accs/client/AccsConfig", DoNotGenerateAcw=true)]
	public partial class AccsConfig : global::Java.Lang.Object {


		static IntPtr mBuilder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/field[@name='mBuilder']"
		[Register ("mBuilder")]
		public static global::Com.Taobao.Accs.AccsClientConfig.Builder MBuilder {
			get {
				if (mBuilder_jfieldId == IntPtr.Zero)
					mBuilder_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mBuilder", "Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mBuilder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.AccsClientConfig.Builder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBuilder_jfieldId == IntPtr.Zero)
					mBuilder_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mBuilder", "Lcom/taobao/accs/AccsClientConfig$Builder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mBuilder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']"
		[global::Android.Runtime.Register ("com/taobao/accs/client/AccsConfig$ACCS_GROUP", DoNotGenerateAcw=true)]
		public sealed partial class ACCS_GROUP : global::Java.Lang.Enum {


			static IntPtr ALIYUN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']/field[@name='ALIYUN']"
			[Register ("ALIYUN")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP Aliyun {
				get {
					if (ALIYUN_jfieldId == IntPtr.Zero)
						ALIYUN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIYUN", "Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIYUN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP Open {
				get {
					if (OPEN_jfieldId == IntPtr.Zero)
						OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TAOBAO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']/field[@name='TAOBAO']"
			[Register ("TAOBAO")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP Taobao {
				get {
					if (TAOBAO_jfieldId == IntPtr.Zero)
						TAOBAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAOBAO", "Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAOBAO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/client/AccsConfig$ACCS_GROUP", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ACCS_GROUP); }
			}

			internal ACCS_GROUP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;", "")]
			public static unsafe global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.ACCS_GROUP']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;", "")]
			public static unsafe global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/taobao/accs/client/AccsConfig$ACCS_GROUP;");
				try {
					return (global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']"
		[global::Android.Runtime.Register ("com/taobao/accs/client/AccsConfig$SECURITY_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class SECURITY_TYPE : global::Java.Lang.Enum {


			static IntPtr SECURITY_OFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']/field[@name='SECURITY_OFF']"
			[Register ("SECURITY_OFF")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE SecurityOff {
				get {
					if (SECURITY_OFF_jfieldId == IntPtr.Zero)
						SECURITY_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY_OFF", "Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_OFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SECURITY_OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']/field[@name='SECURITY_OPEN']"
			[Register ("SECURITY_OPEN")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE SecurityOpen {
				get {
					if (SECURITY_OPEN_jfieldId == IntPtr.Zero)
						SECURITY_OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY_OPEN", "Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SECURITY_TAOBAO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']/field[@name='SECURITY_TAOBAO']"
			[Register ("SECURITY_TAOBAO")]
			public static global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE SecurityTaobao {
				get {
					if (SECURITY_TAOBAO_jfieldId == IntPtr.Zero)
						SECURITY_TAOBAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY_TAOBAO", "Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_TAOBAO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/client/AccsConfig$SECURITY_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SECURITY_TYPE); }
			}

			internal SECURITY_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;", "")]
			public static unsafe global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig.SECURITY_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;", "")]
			public static unsafe global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;");
				try {
					return (global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/client/AccsConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccsConfig); }
		}

		protected AccsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/constructor[@name='AccsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccsConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AccsConfig)) {
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

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()V", "")]
		public static unsafe void Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetStaticMethodID (class_ref, "build", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_build);
			} finally {
			}
		}

		static IntPtr id_disableInappKeepAlive;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='disableInappKeepAlive' and count(parameter)=0]"
		[Register ("disableInappKeepAlive", "()V", "")]
		public static unsafe void DisableInappKeepAlive ()
		{
			if (id_disableInappKeepAlive == IntPtr.Zero)
				id_disableInappKeepAlive = JNIEnv.GetStaticMethodID (class_ref, "disableInappKeepAlive", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableInappKeepAlive);
			} finally {
			}
		}

		static IntPtr id_setAccsCenterHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setAccsCenterHosts' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setAccsCenterHosts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetAccsCenterHosts (string p0, string p1, string p2)
		{
			if (id_setAccsCenterHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccsCenterHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAccsCenterHosts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAccsCenterHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setAccsCenterIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setAccsCenterIps' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("setAccsCenterIps", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public static unsafe void SetAccsCenterIps (string[] p0, string[] p1, string[] p2)
		{
			if (id_setAccsCenterIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setAccsCenterIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAccsCenterIps", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAccsCenterIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_setAuthCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuthCode", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAuthCode (string p0)
		{
			if (id_setAuthCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setAuthCode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAuthCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAuthCode_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setChannelHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setChannelHosts' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setChannelHosts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetChannelHosts (string p0, string p1, string p2)
		{
			if (id_setChannelHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannelHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setChannelHosts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChannelHosts_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setChannelIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setChannelIps' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("setChannelIps", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public static unsafe void SetChannelIps (string[] p0, string[] p1, string[] p2)
		{
			if (id_setChannelIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setChannelIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setChannelIps", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChannelIps_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_setChannelProcessName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setChannelProcessName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannelProcessName", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetChannelProcessName (string p0)
		{
			if (id_setChannelProcessName_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannelProcessName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setChannelProcessName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChannelProcessName_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setChannelReuse_ZLcom_taobao_accs_client_AccsConfig_ACCS_GROUP_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setChannelReuse' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.taobao.accs.client.AccsConfig.ACCS_GROUP']]"
		[Register ("setChannelReuse", "(ZLcom/taobao/accs/client/AccsConfig$ACCS_GROUP;)V", "")]
		public static unsafe void SetChannelReuse (bool p0, global::Com.Taobao.Accs.Client.AccsConfig.ACCS_GROUP p1)
		{
			if (id_setChannelReuse_ZLcom_taobao_accs_client_AccsConfig_ACCS_GROUP_ == IntPtr.Zero)
				id_setChannelReuse_ZLcom_taobao_accs_client_AccsConfig_ACCS_GROUP_ = JNIEnv.GetStaticMethodID (class_ref, "setChannelReuse", "(ZLcom/taobao/accs/client/AccsConfig$ACCS_GROUP;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChannelReuse_ZLcom_taobao_accs_client_AccsConfig_ACCS_GROUP_, __args);
			} finally {
			}
		}

		static IntPtr id_setControlFrameMaxRetry_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setControlFrameMaxRetry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setControlFrameMaxRetry", "(I)V", "")]
		public static unsafe void SetControlFrameMaxRetry (int p0)
		{
			if (id_setControlFrameMaxRetry_I == IntPtr.Zero)
				id_setControlFrameMaxRetry_I = JNIEnv.GetStaticMethodID (class_ref, "setControlFrameMaxRetry", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setControlFrameMaxRetry_I, __args);
			} finally {
			}
		}

		static IntPtr id_setCurrProcessNameImpl_Lcom_taobao_accs_IProcessName_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setCurrProcessNameImpl' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.IProcessName']]"
		[Register ("setCurrProcessNameImpl", "(Lcom/taobao/accs/IProcessName;)V", "")]
		public static unsafe void SetCurrProcessNameImpl (global::Com.Taobao.Accs.IProcessName p0)
		{
			if (id_setCurrProcessNameImpl_Lcom_taobao_accs_IProcessName_ == IntPtr.Zero)
				id_setCurrProcessNameImpl_Lcom_taobao_accs_IProcessName_ = JNIEnv.GetStaticMethodID (class_ref, "setCurrProcessNameImpl", "(Lcom/taobao/accs/IProcessName;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrProcessNameImpl_Lcom_taobao_accs_IProcessName_, __args);
			} finally {
			}
		}

		static IntPtr id_setEnableForground_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setEnableForground' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setEnableForground", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetEnableForground (global::Android.Content.Context p0, bool p1)
		{
			if (id_setEnableForground_Landroid_content_Context_Z == IntPtr.Zero)
				id_setEnableForground_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableForground", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableForground_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setMainProcessName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setMainProcessName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMainProcessName", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetMainProcessName (string p0)
		{
			if (id_setMainProcessName_Ljava_lang_String_ == IntPtr.Zero)
				id_setMainProcessName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setMainProcessName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMainProcessName_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setSecurityGuardOff_Lcom_taobao_accs_client_AccsConfig_SECURITY_TYPE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setSecurityGuardOff' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.client.AccsConfig.SECURITY_TYPE']]"
		[Register ("setSecurityGuardOff", "(Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;)V", "")]
		public static unsafe void SetSecurityGuardOff (global::Com.Taobao.Accs.Client.AccsConfig.SECURITY_TYPE p0)
		{
			if (id_setSecurityGuardOff_Lcom_taobao_accs_client_AccsConfig_SECURITY_TYPE_ == IntPtr.Zero)
				id_setSecurityGuardOff_Lcom_taobao_accs_client_AccsConfig_SECURITY_TYPE_ = JNIEnv.GetStaticMethodID (class_ref, "setSecurityGuardOff", "(Lcom/taobao/accs/client/AccsConfig$SECURITY_TYPE;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSecurityGuardOff_Lcom_taobao_accs_client_AccsConfig_SECURITY_TYPE_, __args);
			} finally {
			}
		}

		static IntPtr id_setTnetPubkey_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='AccsConfig']/method[@name='setTnetPubkey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setTnetPubkey", "(II)V", "")]
		public static unsafe void SetTnetPubkey (int p0, int p1)
		{
			if (id_setTnetPubkey_II == IntPtr.Zero)
				id_setTnetPubkey_II = JNIEnv.GetStaticMethodID (class_ref, "setTnetPubkey", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTnetPubkey_II, __args);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']"
	[global::Android.Runtime.Register ("anet/channel/entity/ENV", DoNotGenerateAcw=true)]
	public sealed partial class ENV : global::Java.Lang.Enum {


		static IntPtr ONLINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/field[@name='ONLINE']"
		[Register ("ONLINE")]
		public static global::Anet.Channel.Entity.ENV Online {
			get {
				if (ONLINE_jfieldId == IntPtr.Zero)
					ONLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLINE", "Lanet/channel/entity/ENV;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLINE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ENV> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREPARE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/field[@name='PREPARE']"
		[Register ("PREPARE")]
		public static global::Anet.Channel.Entity.ENV Prepare {
			get {
				if (PREPARE_jfieldId == IntPtr.Zero)
					PREPARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREPARE", "Lanet/channel/entity/ENV;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREPARE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ENV> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/field[@name='TEST']"
		[Register ("TEST")]
		public static global::Anet.Channel.Entity.ENV Test {
			get {
				if (TEST_jfieldId == IntPtr.Zero)
					TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST", "Lanet/channel/entity/ENV;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ENV> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/entity/ENV", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ENV); }
		}

		internal ENV (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEnvMode;
		static IntPtr id_setEnvMode_I;
		public unsafe int EnvMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/method[@name='getEnvMode' and count(parameter)=0]"
			[Register ("getEnvMode", "()I", "GetGetEnvModeHandler")]
			get {
				if (id_getEnvMode == IntPtr.Zero)
					id_getEnvMode = JNIEnv.GetMethodID (class_ref, "getEnvMode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEnvMode);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/method[@name='setEnvMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEnvMode", "(I)V", "GetSetEnvMode_IHandler")]
			set {
				if (id_setEnvMode_I == IntPtr.Zero)
					id_setEnvMode_I = JNIEnv.GetMethodID (class_ref, "setEnvMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnvMode_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lanet/channel/entity/ENV;", "")]
		public static unsafe global::Anet.Channel.Entity.ENV ValueOf (int p0)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lanet/channel/entity/ENV;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ENV> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/entity/ENV;", "")]
		public static unsafe global::Anet.Channel.Entity.ENV ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/entity/ENV;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Anet.Channel.Entity.ENV __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ENV> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ENV']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lanet/channel/entity/ENV;", "")]
		public static unsafe global::Anet.Channel.Entity.ENV[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/entity/ENV;");
			try {
				return (global::Anet.Channel.Entity.ENV[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Entity.ENV));
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Monitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']"
	[global::Android.Runtime.Register ("anet/channel/monitor/NetworkSpeed", DoNotGenerateAcw=true)]
	public sealed partial class NetworkSpeed : global::Java.Lang.Enum {


		static IntPtr Fast_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/field[@name='Fast']"
		[Register ("Fast")]
		public static global::Anet.Channel.Monitor.NetworkSpeed Fast {
			get {
				if (Fast_jfieldId == IntPtr.Zero)
					Fast_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Fast", "Lanet/channel/monitor/NetworkSpeed;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Fast_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.NetworkSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Slow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/field[@name='Slow']"
		[Register ("Slow")]
		public static global::Anet.Channel.Monitor.NetworkSpeed Slow {
			get {
				if (Slow_jfieldId == IntPtr.Zero)
					Slow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Slow", "Lanet/channel/monitor/NetworkSpeed;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Slow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.NetworkSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/monitor/NetworkSpeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkSpeed); }
		}

		internal NetworkSpeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCode;
		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
				} finally {
				}
			}
		}

		static IntPtr id_getDesc;
		public unsafe string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/monitor/NetworkSpeed;", "")]
		public static unsafe global::Anet.Channel.Monitor.NetworkSpeed ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/monitor/NetworkSpeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Anet.Channel.Monitor.NetworkSpeed __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.NetworkSpeed> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOfCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/method[@name='valueOfCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOfCode", "(I)Lanet/channel/monitor/NetworkSpeed;", "")]
		public static unsafe global::Anet.Channel.Monitor.NetworkSpeed ValueOfCode (int p0)
		{
			if (id_valueOfCode_I == IntPtr.Zero)
				id_valueOfCode_I = JNIEnv.GetStaticMethodID (class_ref, "valueOfCode", "(I)Lanet/channel/monitor/NetworkSpeed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.NetworkSpeed> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOfCode_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/class[@name='NetworkSpeed']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lanet/channel/monitor/NetworkSpeed;", "")]
		public static unsafe global::Anet.Channel.Monitor.NetworkSpeed[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/monitor/NetworkSpeed;");
			try {
				return (global::Anet.Channel.Monitor.NetworkSpeed[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Monitor.NetworkSpeed));
			} finally {
			}
		}

	}
}

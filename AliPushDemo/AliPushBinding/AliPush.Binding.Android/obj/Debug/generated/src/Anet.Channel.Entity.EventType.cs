using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']"
	[global::Android.Runtime.Register ("anet/channel/entity/EventType", DoNotGenerateAcw=true)]
	public sealed partial class EventType : global::Java.Lang.Enum {


		static IntPtr ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Anet.Channel.Entity.EventType All {
			get {
				if (ALL_jfieldId == IntPtr.Zero)
					ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AUTH_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='AUTH_FAIL']"
		[Register ("AUTH_FAIL")]
		public static global::Anet.Channel.Entity.EventType AuthFail {
			get {
				if (AUTH_FAIL_jfieldId == IntPtr.Zero)
					AUTH_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_FAIL", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AUTH_SUCC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='AUTH_SUCC']"
		[Register ("AUTH_SUCC")]
		public static global::Anet.Channel.Entity.EventType AuthSucc {
			get {
				if (AUTH_SUCC_jfieldId == IntPtr.Zero)
					AUTH_SUCC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_SUCC", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_SUCC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public static global::Anet.Channel.Entity.EventType Connected {
			get {
				if (CONNECTED_jfieldId == IntPtr.Zero)
					CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECT_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='CONNECT_FAIL']"
		[Register ("CONNECT_FAIL")]
		public static global::Anet.Channel.Entity.EventType ConnectFail {
			get {
				if (CONNECT_FAIL_jfieldId == IntPtr.Zero)
					CONNECT_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECT_FAIL", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECT_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_RECEIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='DATA_RECEIVE']"
		[Register ("DATA_RECEIVE")]
		public static global::Anet.Channel.Entity.EventType DataReceive {
			get {
				if (DATA_RECEIVE_jfieldId == IntPtr.Zero)
					DATA_RECEIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_RECEIVE", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_RECEIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_SEND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='DATA_SEND']"
		[Register ("DATA_SEND")]
		public static global::Anet.Channel.Entity.EventType DataSend {
			get {
				if (DATA_SEND_jfieldId == IntPtr.Zero)
					DATA_SEND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_SEND", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_SEND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='DATA_TIMEOUT']"
		[Register ("DATA_TIMEOUT")]
		public static global::Anet.Channel.Entity.EventType DataTimeout {
			get {
				if (DATA_TIMEOUT_jfieldId == IntPtr.Zero)
					DATA_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_TIMEOUT", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DISCONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='DISCONNECTED']"
		[Register ("DISCONNECTED")]
		public static global::Anet.Channel.Entity.EventType Disconnected {
			get {
				if (DISCONNECTED_jfieldId == IntPtr.Zero)
					DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HEADER_RECEIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='HEADER_RECEIVE']"
		[Register ("HEADER_RECEIVE")]
		public static global::Anet.Channel.Entity.EventType HeaderReceive {
			get {
				if (HEADER_RECEIVE_jfieldId == IntPtr.Zero)
					HEADER_RECEIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEADER_RECEIVE", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEADER_RECEIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HEADER_SEND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='HEADER_SEND']"
		[Register ("HEADER_SEND")]
		public static global::Anet.Channel.Entity.EventType HeaderSend {
			get {
				if (HEADER_SEND_jfieldId == IntPtr.Zero)
					HEADER_SEND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEADER_SEND", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEADER_SEND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HORSE_RIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='HORSE_RIDE']"
		[Register ("HORSE_RIDE")]
		public static global::Anet.Channel.Entity.EventType HorseRide {
			get {
				if (HORSE_RIDE_jfieldId == IntPtr.Zero)
					HORSE_RIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORSE_RIDE", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HORSE_RIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PIND_RECEIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='PIND_RECEIVE']"
		[Register ("PIND_RECEIVE")]
		public static global::Anet.Channel.Entity.EventType PindReceive {
			get {
				if (PIND_RECEIVE_jfieldId == IntPtr.Zero)
					PIND_RECEIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PIND_RECEIVE", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PIND_RECEIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PING_SEND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/field[@name='PING_SEND']"
		[Register ("PING_SEND")]
		public static global::Anet.Channel.Entity.EventType PingSend {
			get {
				if (PING_SEND_jfieldId == IntPtr.Zero)
					PING_SEND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PING_SEND", "Lanet/channel/entity/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PING_SEND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/entity/EventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventType); }
		}

		internal EventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getType;
		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/entity/EventType;", "")]
		public static unsafe global::Anet.Channel.Entity.EventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/entity/EventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Anet.Channel.Entity.EventType __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.EventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='EventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lanet/channel/entity/EventType;", "")]
		public static unsafe global::Anet.Channel.Entity.EventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/entity/EventType;");
			try {
				return (global::Anet.Channel.Entity.EventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Entity.EventType));
			} finally {
			}
		}

	}
}

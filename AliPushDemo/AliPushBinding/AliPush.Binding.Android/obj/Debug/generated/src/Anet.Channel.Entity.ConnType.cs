using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']"
	[global::Android.Runtime.Register ("anet/channel/entity/ConnType", DoNotGenerateAcw=true)]
	public sealed partial class ConnType : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType.TypeLevel']"
		[global::Android.Runtime.Register ("anet/channel/entity/ConnType$TypeLevel", DoNotGenerateAcw=true)]
		public sealed partial class TypeLevel : global::Java.Lang.Enum {


			static IntPtr HTTP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType.TypeLevel']/field[@name='HTTP']"
			[Register ("HTTP")]
			public static global::Anet.Channel.Entity.ConnType.TypeLevel Http {
				get {
					if (HTTP_jfieldId == IntPtr.Zero)
						HTTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP", "Lanet/channel/entity/ConnType$TypeLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType.TypeLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SPDY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType.TypeLevel']/field[@name='SPDY']"
			[Register ("SPDY")]
			public static global::Anet.Channel.Entity.ConnType.TypeLevel Spdy {
				get {
					if (SPDY_jfieldId == IntPtr.Zero)
						SPDY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY", "Lanet/channel/entity/ConnType$TypeLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType.TypeLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("anet/channel/entity/ConnType$TypeLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TypeLevel); }
			}

			internal TypeLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType.TypeLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/entity/ConnType$TypeLevel;", "")]
			public static unsafe global::Anet.Channel.Entity.ConnType.TypeLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/entity/ConnType$TypeLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Anet.Channel.Entity.ConnType.TypeLevel __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType.TypeLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType.TypeLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lanet/channel/entity/ConnType$TypeLevel;", "")]
			public static unsafe global::Anet.Channel.Entity.ConnType.TypeLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/entity/ConnType$TypeLevel;");
				try {
					return (global::Anet.Channel.Entity.ConnType.TypeLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Entity.ConnType.TypeLevel));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/entity/ConnType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnType); }
		}

		internal ConnType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public unsafe int A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_a);
			} finally {
			}
		}

		static IntPtr id_a_Lanet_channel_entity_ConnType_Lanet_channel_entity_ConnType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='a' and count(parameter)=2 and parameter[1][@type='anet.channel.entity.ConnType'] and parameter[2][@type='anet.channel.entity.ConnType']]"
		[Register ("a", "(Lanet/channel/entity/ConnType;Lanet/channel/entity/ConnType;)I", "")]
		public static unsafe int A (global::Anet.Channel.Entity.ConnType p0, global::Anet.Channel.Entity.ConnType p1)
		{
			if (id_a_Lanet_channel_entity_ConnType_Lanet_channel_entity_ConnType_ == IntPtr.Zero)
				id_a_Lanet_channel_entity_ConnType_Lanet_channel_entity_ConnType_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lanet/channel/entity/ConnType;Lanet/channel/entity/ConnType;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Lanet_channel_entity_ConnType_Lanet_channel_entity_ConnType_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Lanet_channel_strategy_ConnProtocol_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='a' and count(parameter)=1 and parameter[1][@type='anet.channel.strategy.ConnProtocol']]"
		[Register ("a", "(Lanet/channel/strategy/ConnProtocol;)Lanet/channel/entity/ConnType;", "")]
		public static unsafe global::Anet.Channel.Entity.ConnType A (global::Anet.Channel.Strategy.ConnProtocol p0)
		{
			if (id_a_Lanet_channel_strategy_ConnProtocol_ == IntPtr.Zero)
				id_a_Lanet_channel_strategy_ConnProtocol_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lanet/channel/strategy/ConnProtocol;)Lanet/channel/entity/ConnType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Anet.Channel.Entity.ConnType __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lanet_channel_strategy_ConnProtocol_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)I", "")]
		public unsafe int A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public unsafe bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public unsafe bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_c);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lanet/channel/entity/ConnType$TypeLevel;", "")]
		public unsafe global::Anet.Channel.Entity.ConnType.TypeLevel D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lanet/channel/entity/ConnType$TypeLevel;");
			try {
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType.TypeLevel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.entity']/class[@name='ConnType']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

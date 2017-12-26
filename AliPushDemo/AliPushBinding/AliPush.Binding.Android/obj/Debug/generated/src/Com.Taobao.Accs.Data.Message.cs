using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/taobao/accs/data/Message", DoNotGenerateAcw=true)]
	public partial class Message : global::Java.Lang.Object {


		static IntPtr M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='M']"
		[Register ("M")]
		public string M {
			get {
				if (M_jfieldId == IntPtr.Zero)
					M_jfieldId = JNIEnv.GetFieldID (class_ref, "M", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, M_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (M_jfieldId == IntPtr.Zero)
					M_jfieldId = JNIEnv.GetFieldID (class_ref, "M", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, M_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr O_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='O']"
		[Register ("O")]
		public long O {
			get {
				if (O_jfieldId == IntPtr.Zero)
					O_jfieldId = JNIEnv.GetFieldID (class_ref, "O", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, O_jfieldId);
			}
			set {
				if (O_jfieldId == IntPtr.Zero)
					O_jfieldId = JNIEnv.GetFieldID (class_ref, "O", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, O_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr P_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='P']"
		[Register ("P")]
		public int P {
			get {
				if (P_jfieldId == IntPtr.Zero)
					P_jfieldId = JNIEnv.GetFieldID (class_ref, "P", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, P_jfieldId);
			}
			set {
				if (P_jfieldId == IntPtr.Zero)
					P_jfieldId = JNIEnv.GetFieldID (class_ref, "P", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, P_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='Q']"
		[Register ("Q")]
		public int Q {
			get {
				if (Q_jfieldId == IntPtr.Zero)
					Q_jfieldId = JNIEnv.GetFieldID (class_ref, "Q", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, Q_jfieldId);
			}
			set {
				if (Q_jfieldId == IntPtr.Zero)
					Q_jfieldId = JNIEnv.GetFieldID (class_ref, "Q", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Q_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr R_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='R']"
		[Register ("R")]
		public long R {
			get {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, R_jfieldId);
			}
			set {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, R_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr T_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='T']"
		[Register ("T")]
		public string T {
			get {
				if (T_jfieldId == IntPtr.Zero)
					T_jfieldId = JNIEnv.GetFieldID (class_ref, "T", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, T_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (T_jfieldId == IntPtr.Zero)
					T_jfieldId = JNIEnv.GetFieldID (class_ref, "T", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, T_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/field[@name='w']"
		[Register ("w")]
		public string W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, w_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, w_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']"
		[global::Android.Runtime.Register ("com/taobao/accs/data/Message$ReqType", DoNotGenerateAcw=true)]
		public sealed partial class ReqType : global::Java.Lang.Enum {


			static IntPtr ACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/field[@name='ACK']"
			[Register ("ACK")]
			public static global::Com.Taobao.Accs.Data.Message.ReqType Ack {
				get {
					if (ACK_jfieldId == IntPtr.Zero)
						ACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACK", "Lcom/taobao/accs/data/Message$ReqType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/field[@name='DATA']"
			[Register ("DATA")]
			public static global::Com.Taobao.Accs.Data.Message.ReqType Data {
				get {
					if (DATA_jfieldId == IntPtr.Zero)
						DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA", "Lcom/taobao/accs/data/Message$ReqType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/field[@name='REQ']"
			[Register ("REQ")]
			public static global::Com.Taobao.Accs.Data.Message.ReqType Req {
				get {
					if (REQ_jfieldId == IntPtr.Zero)
						REQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQ", "Lcom/taobao/accs/data/Message$ReqType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/field[@name='RES']"
			[Register ("RES")]
			public static global::Com.Taobao.Accs.Data.Message.ReqType Res {
				get {
					if (RES_jfieldId == IntPtr.Zero)
						RES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RES", "Lcom/taobao/accs/data/Message$ReqType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/data/Message$ReqType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReqType); }
			}

			internal ReqType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/taobao/accs/data/Message$ReqType;", "")]
			public static unsafe global::Com.Taobao.Accs.Data.Message.ReqType ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/taobao/accs/data/Message$ReqType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/data/Message$ReqType;", "")]
			public static unsafe global::Com.Taobao.Accs.Data.Message.ReqType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/data/Message$ReqType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Taobao.Accs.Data.Message.ReqType __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message.ReqType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message.ReqType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/taobao/accs/data/Message$ReqType;", "")]
			public static unsafe global::Com.Taobao.Accs.Data.Message.ReqType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/taobao/accs/data/Message$ReqType;");
				try {
					return (global::Com.Taobao.Accs.Data.Message.ReqType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Taobao.Accs.Data.Message.ReqType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/data/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=0]"
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

		static IntPtr id_a_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)[B", "")]
		public unsafe byte[] A (global::Android.Content.Context p0, int p1)
		{
			if (id_a_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;I)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (global::Android.Content.Context p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_a_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("a", "(ZI)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (bool p0, int p1)
		{
			if (id_a_ZI == IntPtr.Zero)
				id_a_ZI = JNIEnv.GetStaticMethodID (class_ref, "a", "(ZI)Lcom/taobao/accs/data/Message;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_ZI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("a", "(Ljava/lang/String;I)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (string p0, int p1)
		{
			if (id_a_Ljava_lang_String_I == IntPtr.Zero)
				id_a_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;I)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("a", "(Ljava/lang/String;Ljava/util/Map;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message A (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> p1)
		{
			if (id_a_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/Map;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "")]
		public unsafe void A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_J, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='b' and count(parameter)=0]"
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

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message B (string p0, string p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()I", "")]
		public unsafe int C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_c);
			} finally {
			}
		}

		static IntPtr id_c_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;", "")]
		public static unsafe global::Com.Taobao.Accs.Data.Message C (string p0, string p1)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/data/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Taobao.Accs.Data.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Data.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/taobao/accs/ut/monitor/NetPerformanceMonitor;", "")]
		public unsafe global::Com.Taobao.Accs.UT.Monitor.NetPerformanceMonitor D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/taobao/accs/ut/monitor/NetPerformanceMonitor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.UT.Monitor.NetPerformanceMonitor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "")]
		public unsafe string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.data']/class[@name='Message']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public unsafe bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_f);
			} finally {
			}
		}

	}
}

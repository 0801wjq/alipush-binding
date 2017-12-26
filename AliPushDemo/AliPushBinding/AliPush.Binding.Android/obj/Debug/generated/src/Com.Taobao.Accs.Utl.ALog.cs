using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Utl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']"
	[global::Android.Runtime.Register ("com/taobao/accs/utl/ALog", DoNotGenerateAcw=true)]
	public partial class ALog : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']"
		[global::Android.Runtime.Register ("com/taobao/accs/utl/ALog$Level", DoNotGenerateAcw=true)]
		public sealed partial class Level : global::Java.Lang.Enum {


			static IntPtr D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='D']"
			[Register ("D")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level D {
				get {
					if (D_jfieldId == IntPtr.Zero)
						D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "D", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr E_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='E']"
			[Register ("E")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level E {
				get {
					if (E_jfieldId == IntPtr.Zero)
						E_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "E", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, E_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr I_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='I']"
			[Register ("I")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level I {
				get {
					if (I_jfieldId == IntPtr.Zero)
						I_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "I", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, I_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr L_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='L']"
			[Register ("L")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level L {
				get {
					if (L_jfieldId == IntPtr.Zero)
						L_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "L", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, L_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr V_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='V']"
			[Register ("V")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level V {
				get {
					if (V_jfieldId == IntPtr.Zero)
						V_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "V", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, V_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr W_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/field[@name='W']"
			[Register ("W")]
			public static global::Com.Taobao.Accs.Utl.ALog.Level W {
				get {
					if (W_jfieldId == IntPtr.Zero)
						W_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W", "Lcom/taobao/accs/utl/ALog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, W_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/utl/ALog$Level", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Level); }
			}

			internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/utl/ALog$Level;", "")]
			public static unsafe global::Com.Taobao.Accs.Utl.ALog.Level ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/utl/ALog$Level;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Taobao.Accs.Utl.ALog.Level __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.ALog.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog.Level']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/taobao/accs/utl/ALog$Level;", "")]
			public static unsafe global::Com.Taobao.Accs.Utl.ALog.Level[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/taobao/accs/utl/ALog$Level;");
				try {
					return (global::Com.Taobao.Accs.Utl.ALog.Level[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Taobao.Accs.Utl.ALog.Level));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/utl/ALog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ALog); }
		}

		protected ALog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/constructor[@name='ALog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ALog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ALog)) {
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

		static IntPtr id_isPrintLog;
		static IntPtr id_setPrintLog_Z;
		public static unsafe bool PrintLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='isPrintLog' and count(parameter)=0]"
			[Register ("isPrintLog", "()Z", "GetIsPrintLogHandler")]
			get {
				if (id_isPrintLog == IntPtr.Zero)
					id_isPrintLog = JNIEnv.GetStaticMethodID (class_ref, "isPrintLog", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrintLog);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='setPrintLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrintLog", "(Z)V", "GetSetPrintLog_ZHandler")]
			set {
				if (id_setPrintLog_Z == IntPtr.Zero)
					id_setPrintLog_Z = JNIEnv.GetStaticMethodID (class_ref, "setPrintLog", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setPrintLog_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_d1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='d1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("d1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D1 (string p0, string p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_d1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
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

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='e' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, string p1, global::Java.Lang.Throwable p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='e1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("e1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E1 (string p0, string p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
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

		static IntPtr id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='e1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("e1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "")]
		public static unsafe void E1 (string p0, string p1, string p2, global::Java.Lang.Throwable p3, params global:: Java.Lang.Object[] p4)
		{
			if (id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_i1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='i1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("i1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I1 (string p0, string p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_i1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
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

		static IntPtr id_initALog_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='initALog' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("initALog", "(Ljava/lang/String;I)V", "")]
		public static unsafe void InitALog (string p0, int p1)
		{
			if (id_initALog_Ljava_lang_String_I == IntPtr.Zero)
				id_initALog_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "initALog", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initALog_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isPrintLog_Lcom_taobao_accs_utl_ALog_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='isPrintLog' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.utl.ALog.Level']]"
		[Register ("isPrintLog", "(Lcom/taobao/accs/utl/ALog$Level;)Z", "")]
		public static unsafe bool IsPrintLog (global::Com.Taobao.Accs.Utl.ALog.Level p0)
		{
			if (id_isPrintLog_Lcom_taobao_accs_utl_ALog_Level_ == IntPtr.Zero)
				id_isPrintLog_Lcom_taobao_accs_utl_ALog_Level_ = JNIEnv.GetStaticMethodID (class_ref, "isPrintLog", "(Lcom/taobao/accs/utl/ALog$Level;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrintLog_Lcom_taobao_accs_utl_ALog_Level_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setEnableTLog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='setEnableTLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableTLog", "(Z)V", "")]
		public static unsafe void SetEnableTLog (bool p0)
		{
			if (id_setEnableTLog_Z == IntPtr.Zero)
				id_setEnableTLog_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableTLog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableTLog_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setUseTlog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='setUseTlog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseTlog", "(Z)V", "")]
		public static unsafe void SetUseTlog (bool p0)
		{
			if (id_setUseTlog_Z == IntPtr.Zero)
				id_setUseTlog_Z = JNIEnv.GetStaticMethodID (class_ref, "setUseTlog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUseTlog_Z, __args);
			} finally {
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='w' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, string p1, global::Java.Lang.Throwable p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='w1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("w1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W1 (string p0, string p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
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

		static IntPtr id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='ALog']/method[@name='w1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("w1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V", "")]
		public static unsafe void W1 (string p0, string p1, string p2, global::Java.Lang.Throwable p3, params global:: Java.Lang.Object[] p4)
		{
			if (id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

	}
}

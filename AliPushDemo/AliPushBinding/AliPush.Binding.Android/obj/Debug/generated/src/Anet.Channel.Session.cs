using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel']/class[@name='Session']"
	[global::Android.Runtime.Register ("anet/channel/Session", DoNotGenerateAcw=true)]
	public abstract partial class Session : global::Java.Lang.Object, global::Java.Lang.IComparable {


		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session']/field[@name='n']"
		[Register ("n")]
		public global::Anet.Channel.Statist.SessionStatistic N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "Lanet/channel/statist/SessionStatistic;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, n_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Statist.SessionStatistic> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "Lanet/channel/statist/SessionStatistic;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, n_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session']/field[@name='o']"
		[Register ("o")]
		protected int O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, o_jfieldId);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, o_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session']/field[@name='p']"
		[Register ("p")]
		protected int P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, p_jfieldId);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session']/field[@name='q']"
		[Register ("q")]
		protected bool Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, q_jfieldId);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, q_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session']/field[@name='r']"
		[Register ("r")]
		protected bool R {
			get {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, r_jfieldId);
			}
			set {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, r_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']"
		[global::Android.Runtime.Register ("anet/channel/Session$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr AUTHING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='AUTHING']"
			[Register ("AUTHING")]
			public static global::Anet.Channel.Session.Status Authing {
				get {
					if (AUTHING_jfieldId == IntPtr.Zero)
						AUTHING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHING", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTH_FAIL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='AUTH_FAIL']"
			[Register ("AUTH_FAIL")]
			public static global::Anet.Channel.Session.Status AuthFail {
				get {
					if (AUTH_FAIL_jfieldId == IntPtr.Zero)
						AUTH_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_FAIL", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_FAIL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTH_SUCC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='AUTH_SUCC']"
			[Register ("AUTH_SUCC")]
			public static global::Anet.Channel.Session.Status AuthSucc {
				get {
					if (AUTH_SUCC_jfieldId == IntPtr.Zero)
						AUTH_SUCC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_SUCC", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_SUCC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Anet.Channel.Session.Status Connected {
				get {
					if (CONNECTED_jfieldId == IntPtr.Zero)
						CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNECTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Anet.Channel.Session.Status Connecting {
				get {
					if (CONNECTING_jfieldId == IntPtr.Zero)
						CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNETFAIL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='CONNETFAIL']"
			[Register ("CONNETFAIL")]
			public static global::Anet.Channel.Session.Status Connetfail {
				get {
					if (CONNETFAIL_jfieldId == IntPtr.Zero)
						CONNETFAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNETFAIL", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNETFAIL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Anet.Channel.Session.Status Disconnected {
				get {
					if (DISCONNECTED_jfieldId == IntPtr.Zero)
						DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISCONNECTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/field[@name='DISCONNECTING']"
			[Register ("DISCONNECTING")]
			public static global::Anet.Channel.Session.Status Disconnecting {
				get {
					if (DISCONNECTING_jfieldId == IntPtr.Zero)
						DISCONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTING", "Lanet/channel/Session$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("anet/channel/Session$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/Session$Status;", "")]
			public static unsafe global::Anet.Channel.Session.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/Session$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Anet.Channel.Session.Status __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lanet/channel/Session$Status;", "")]
			public static unsafe global::Anet.Channel.Session.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/Session$Status;");
				try {
					return (global::Anet.Channel.Session.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Session.Status));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_a_Z;
#pragma warning disable 0169
		static Delegate GetA_ZHandler ()
		{
			if (cb_a_Z == null)
				cb_a_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_A_Z);
			return cb_a_Z;
		}

		static void n_A_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "GetA_ZHandler")]
		public virtual unsafe void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_a_IarrayB;
#pragma warning disable 0169
		static Delegate GetA_IarrayBHandler ()
		{
			if (cb_a_IarrayB == null)
				cb_a_IarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_A_IarrayB);
			return cb_a_IarrayB;
		}

		static void n_A_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.A (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("a", "(I[B)V", "GetA_IarrayBHandler")]
		public virtual unsafe void A (int p0, byte[] p1)
		{
			if (id_a_IarrayB == IntPtr.Zero)
				id_a_IarrayB = JNIEnv.GetMethodID (class_ref, "a", "(I[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_IarrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(I[B)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public abstract void B ();

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Runnable;", "GetCHandler")]
		protected abstract global::Java.Lang.IRunnable C ();

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static void n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.D ();
		}
#pragma warning restore 0169

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "GetDHandler")]
		public virtual unsafe void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "()V"));
			} finally {
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_E);
			return cb_e;
		}

		static bool n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.E ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "GetEHandler")]
		public abstract bool E ();

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public unsafe string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()I", "")]
		public unsafe int G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_g);
			} finally {
			}
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Lanet/channel/entity/ConnType;", "")]
		public unsafe global::Anet.Channel.Entity.ConnType H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Lanet/channel/entity/ConnType;");
			try {
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Entity.ConnType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_h), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "")]
		public unsafe string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_i), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/String;", "")]
		public unsafe string J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_j), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lanet/channel/strategy/IConnStrategy;", "")]
		public unsafe global::Anet.Channel.Strategy.IConnStrategy K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lanet/channel/strategy/IConnStrategy;");
			try {
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_k), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_l;
#pragma warning disable 0169
		static Delegate GetLHandler ()
		{
			if (cb_l == null)
				cb_l = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_L);
			return cb_l;
		}

		static void n_L (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.L ();
		}
#pragma warning restore 0169

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()V", "GetLHandler")]
		protected virtual unsafe void L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_l);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "l", "()V"));
			} finally {
			}
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()V", "")]
		protected unsafe void M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_m);
			} finally {
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::Anet.Channel.Session __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object o);

	}

	[global::Android.Runtime.Register ("anet/channel/Session", DoNotGenerateAcw=true)]
	internal partial class SessionInvoker : Session {

		public SessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionInvoker); }
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public override unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Runnable;", "GetCHandler")]
		protected override unsafe global::Java.Lang.IRunnable C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Runnable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel']/class[@name='Session']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "GetEHandler")]
		public override unsafe bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_e);
			} finally {
			}
		}

		static IntPtr id_compareTo_Ljava_lang_Object_;
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object o)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Statist {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']"
	[global::Android.Runtime.Register ("anet/channel/statist/RequestStatistic", DoNotGenerateAcw=true)]
	public partial class RequestStatistic : global::Anet.Channel.Statist.StatObject {


		static IntPtr B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='B']"
		[Register ("B")]
		public long B {
			get {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetFieldID (class_ref, "B", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, B_jfieldId);
			}
			set {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetFieldID (class_ref, "B", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, B_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr C_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='C']"
		[Register ("C")]
		public long C {
			get {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetFieldID (class_ref, "C", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, C_jfieldId);
			}
			set {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetFieldID (class_ref, "C", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, C_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='d']"
		[Register ("d")]
		public bool D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, d_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='e']"
		[Register ("e")]
		public bool E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='f']"
		[Register ("f")]
		public string F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, f_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, f_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='g']"
		[Register ("g")]
		public string G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='h']"
		[Register ("h")]
		public string H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, h_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, h_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='i']"
		[Register ("i")]
		public bool I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, i_jfieldId);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, i_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='j']"
		[Register ("j")]
		public int J {
			get {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetFieldID (class_ref, "j", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, j_jfieldId);
			}
			set {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetFieldID (class_ref, "j", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, j_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr k_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='k']"
		[Register ("k")]
		public string K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetFieldID (class_ref, "k", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, k_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetFieldID (class_ref, "k", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, k_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='l']"
		[Register ("l")]
		public bool L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, l_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='m']"
		[Register ("m")]
		public int M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetFieldID (class_ref, "m", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetFieldID (class_ref, "m", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='n']"
		[Register ("n")]
		public string N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, n_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, n_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='o']"
		[Register ("o")]
		public string O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, o_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, o_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='p']"
		[Register ("p")]
		public string P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, p_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='q']"
		[Register ("q")]
		public string Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, q_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, q_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='r']"
		[Register ("r")]
		public long R {
			get {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, r_jfieldId);
			}
			set {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, r_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr s_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='s']"
		[Register ("s")]
		public long S {
			get {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetFieldID (class_ref, "s", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, s_jfieldId);
			}
			set {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetFieldID (class_ref, "s", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, s_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr t_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='t']"
		[Register ("t")]
		public long T {
			get {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetFieldID (class_ref, "t", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, t_jfieldId);
			}
			set {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetFieldID (class_ref, "t", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, t_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr u_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='u']"
		[Register ("u")]
		public long U {
			get {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetFieldID (class_ref, "u", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, u_jfieldId);
			}
			set {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetFieldID (class_ref, "u", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, u_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr v_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='v']"
		[Register ("v")]
		public long V {
			get {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetFieldID (class_ref, "v", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, v_jfieldId);
			}
			set {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetFieldID (class_ref, "v", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, v_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='w']"
		[Register ("w")]
		public long W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, w_jfieldId);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, w_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='x']"
		[Register ("x")]
		public long X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, x_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='y']"
		[Register ("y")]
		public long Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, y_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/field[@name='z']"
		[Register ("z")]
		public long Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, z_jfieldId);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, z_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/statist/RequestStatistic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestStatistic); }
		}

		protected RequestStatistic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/constructor[@name='RequestStatistic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RequestStatistic (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (RequestStatistic)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Lanet_channel_entity_ConnType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/method[@name='a' and count(parameter)=1 and parameter[1][@type='anet.channel.entity.ConnType']]"
		[Register ("a", "(Lanet/channel/entity/ConnType;)V", "")]
		public unsafe void A (global::Anet.Channel.Entity.ConnType p0)
		{
			if (id_a_Lanet_channel_entity_ConnType_ == IntPtr.Zero)
				id_a_Lanet_channel_entity_ConnType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lanet/channel/entity/ConnType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lanet_channel_entity_ConnType_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.statist']/class[@name='RequestStatistic']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("a", "(Ljava/lang/String;I)V", "")]
		public unsafe void A (string p0, int p1)
		{
			if (id_a_Ljava_lang_String_I == IntPtr.Zero)
				id_a_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

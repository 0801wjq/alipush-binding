using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Statist {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']"
	[global::Android.Runtime.Register ("anetwork/channel/statist/StatisticData", DoNotGenerateAcw=true)]
	public partial class StatisticData : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.ICloneable {


		static IntPtr B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='B']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='C']"
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

		static IntPtr D_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='D']"
		[Register ("D")]
		public string D {
			get {
				if (D_jfieldId == IntPtr.Zero)
					D_jfieldId = JNIEnv.GetFieldID (class_ref, "D", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, D_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (D_jfieldId == IntPtr.Zero)
					D_jfieldId = JNIEnv.GetFieldID (class_ref, "D", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, D_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr E_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='E']"
		[Register ("E")]
		public int E {
			get {
				if (E_jfieldId == IntPtr.Zero)
					E_jfieldId = JNIEnv.GetFieldID (class_ref, "E", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, E_jfieldId);
			}
			set {
				if (E_jfieldId == IntPtr.Zero)
					E_jfieldId = JNIEnv.GetFieldID (class_ref, "E", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, E_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr F_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='F']"
		[Register ("F")]
		public string F {
			get {
				if (F_jfieldId == IntPtr.Zero)
					F_jfieldId = JNIEnv.GetFieldID (class_ref, "F", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, F_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (F_jfieldId == IntPtr.Zero)
					F_jfieldId = JNIEnv.GetFieldID (class_ref, "F", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, F_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='g']"
		[Register ("g")]
		public bool G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='h']"
		[Register ("h")]
		public bool H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, h_jfieldId);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, h_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='i']"
		[Register ("i")]
		public int I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, i_jfieldId);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, i_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='j']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='k']"
		[Register ("k")]
		public long K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetFieldID (class_ref, "k", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, k_jfieldId);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetFieldID (class_ref, "k", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, k_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='l']"
		[Register ("l")]
		public long L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, l_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='m']"
		[Register ("m")]
		public long M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetFieldID (class_ref, "m", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetFieldID (class_ref, "m", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='n']"
		[Register ("n")]
		public long N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, n_jfieldId);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetFieldID (class_ref, "n", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, n_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='o']"
		[Register ("o")]
		public long O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, o_jfieldId);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, o_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='p']"
		[Register ("p")]
		public long P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, p_jfieldId);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='q']"
		[Register ("q")]
		public long Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, q_jfieldId);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, q_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='r']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='s']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='t']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='u']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='v']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='w']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='x']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='y']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/field[@name='z']"
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
				return JNIEnv.FindClass ("anetwork/channel/statist/StatisticData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatisticData); }
		}

		protected StatisticData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/constructor[@name='StatisticData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatisticData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StatisticData)) {
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

		static IntPtr id_a_Lanet_channel_statist_RequestStatistic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.statist']/class[@name='StatisticData']/method[@name='a' and count(parameter)=1 and parameter[1][@type='anet.channel.statist.RequestStatistic']]"
		[Register ("a", "(Lanet/channel/statist/RequestStatistic;)V", "")]
		public unsafe void A (global::Anet.Channel.Statist.RequestStatistic p0)
		{
			if (id_a_Lanet_channel_statist_RequestStatistic_ == IntPtr.Zero)
				id_a_Lanet_channel_statist_RequestStatistic_ = JNIEnv.GetMethodID (class_ref, "a", "(Lanet/channel/statist/RequestStatistic;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lanet_channel_statist_RequestStatistic_, __args);
			} finally {
			}
		}

	}
}

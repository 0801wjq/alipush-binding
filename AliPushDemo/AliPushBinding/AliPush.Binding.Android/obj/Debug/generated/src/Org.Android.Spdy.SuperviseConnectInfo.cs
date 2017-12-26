using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']"
	[global::Android.Runtime.Register ("org/android/spdy/SuperviseConnectInfo", DoNotGenerateAcw=true)]
	public partial class SuperviseConnectInfo : global::Java.Lang.Object {


		static IntPtr connectTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='connectTime']"
		[Register ("connectTime")]
		public int ConnectTime {
			get {
				if (connectTime_jfieldId == IntPtr.Zero)
					connectTime_jfieldId = JNIEnv.GetFieldID (class_ref, "connectTime", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, connectTime_jfieldId);
			}
			set {
				if (connectTime_jfieldId == IntPtr.Zero)
					connectTime_jfieldId = JNIEnv.GetFieldID (class_ref, "connectTime", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr doHandshakeTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='doHandshakeTime']"
		[Register ("doHandshakeTime")]
		public int DoHandshakeTime {
			get {
				if (doHandshakeTime_jfieldId == IntPtr.Zero)
					doHandshakeTime_jfieldId = JNIEnv.GetFieldID (class_ref, "doHandshakeTime", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, doHandshakeTime_jfieldId);
			}
			set {
				if (doHandshakeTime_jfieldId == IntPtr.Zero)
					doHandshakeTime_jfieldId = JNIEnv.GetFieldID (class_ref, "doHandshakeTime", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, doHandshakeTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr handshakeTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='handshakeTime']"
		[Register ("handshakeTime")]
		public int HandshakeTime {
			get {
				if (handshakeTime_jfieldId == IntPtr.Zero)
					handshakeTime_jfieldId = JNIEnv.GetFieldID (class_ref, "handshakeTime", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, handshakeTime_jfieldId);
			}
			set {
				if (handshakeTime_jfieldId == IntPtr.Zero)
					handshakeTime_jfieldId = JNIEnv.GetFieldID (class_ref, "handshakeTime", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handshakeTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr keepalive_period_second_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='keepalive_period_second']"
		[Register ("keepalive_period_second")]
		public int KeepalivePeriodSecond {
			get {
				if (keepalive_period_second_jfieldId == IntPtr.Zero)
					keepalive_period_second_jfieldId = JNIEnv.GetFieldID (class_ref, "keepalive_period_second", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, keepalive_period_second_jfieldId);
			}
			set {
				if (keepalive_period_second_jfieldId == IntPtr.Zero)
					keepalive_period_second_jfieldId = JNIEnv.GetFieldID (class_ref, "keepalive_period_second", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, keepalive_period_second_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr retryTimes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='retryTimes']"
		[Register ("retryTimes")]
		public int RetryTimes {
			get {
				if (retryTimes_jfieldId == IntPtr.Zero)
					retryTimes_jfieldId = JNIEnv.GetFieldID (class_ref, "retryTimes", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, retryTimes_jfieldId);
			}
			set {
				if (retryTimes_jfieldId == IntPtr.Zero)
					retryTimes_jfieldId = JNIEnv.GetFieldID (class_ref, "retryTimes", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, retryTimes_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr reused_counter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='reused_counter']"
		[Register ("reused_counter")]
		public int ReusedCounter {
			get {
				if (reused_counter_jfieldId == IntPtr.Zero)
					reused_counter_jfieldId = JNIEnv.GetFieldID (class_ref, "reused_counter", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, reused_counter_jfieldId);
			}
			set {
				if (reused_counter_jfieldId == IntPtr.Zero)
					reused_counter_jfieldId = JNIEnv.GetFieldID (class_ref, "reused_counter", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reused_counter_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sessionTicketReused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='sessionTicketReused']"
		[Register ("sessionTicketReused")]
		public int SessionTicketReused {
			get {
				if (sessionTicketReused_jfieldId == IntPtr.Zero)
					sessionTicketReused_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionTicketReused", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sessionTicketReused_jfieldId);
			}
			set {
				if (sessionTicketReused_jfieldId == IntPtr.Zero)
					sessionTicketReused_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionTicketReused", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sessionTicketReused_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseConnectInfo']/field[@name='timeout']"
		[Register ("timeout")]
		public int Timeout {
			get {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId);
			}
			set {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SuperviseConnectInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuperviseConnectInfo); }
		}

		protected SuperviseConnectInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

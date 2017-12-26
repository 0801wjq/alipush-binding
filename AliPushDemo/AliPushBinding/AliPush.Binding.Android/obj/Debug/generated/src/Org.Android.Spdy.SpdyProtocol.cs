using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyProtocol", DoNotGenerateAcw=true)]
	public partial class SpdyProtocol : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='ACCS']"
		[Register ("ACCS")]
		public const int Accs = (int) 130;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='ACCS_0RTT']"
		[Register ("ACCS_0RTT")]
		public const int Accs0rtt = (int) 4226;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='ACCS_1RTT']"
		[Register ("ACCS_1RTT")]
		public const int Accs1rtt = (int) 8322;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='CDN']"
		[Register ("CDN")]
		public const int Cdn = (int) 130;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='CDN_0RTT']"
		[Register ("CDN_0RTT")]
		public const int Cdn0rtt = (int) 4226;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='CDN_1RTT']"
		[Register ("CDN_1RTT")]
		public const int Cdn1rtt = (int) 8322;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public const int Custom = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='HTTP']"
		[Register ("HTTP")]
		public const int Http = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='HTTP2']"
		[Register ("HTTP2")]
		public const int Http2 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='L7E_SSSL_0RTT_HTTP2']"
		[Register ("L7E_SSSL_0RTT_HTTP2")]
		public const int L7eSssl0rttHttp2 = (int) 20616;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='L7E_SSSL_1RTT_HTTP2']"
		[Register ("L7E_SSSL_1RTT_HTTP2")]
		public const int L7eSssl1rttHttp2 = (int) 24712;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_PSEQ_ACCS']"
		[Register ("PUBKEY_PSEQ_ACCS")]
		public const int PubkeyPseqAccs = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_PSEQ_ADASH']"
		[Register ("PUBKEY_PSEQ_ADASH")]
		public const int PubkeyPseqAdash = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_PSEQ_ARUP']"
		[Register ("PUBKEY_PSEQ_ARUP")]
		public const int PubkeyPseqArup = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_PSEQ_CDN']"
		[Register ("PUBKEY_PSEQ_CDN")]
		public const int PubkeyPseqCdn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_PSEQ_OPEN']"
		[Register ("PUBKEY_PSEQ_OPEN")]
		public const int PubkeyPseqOpen = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_ACCS']"
		[Register ("PUBKEY_SEQ_ACCS")]
		public const int PubkeySeqAccs = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_ADASH']"
		[Register ("PUBKEY_SEQ_ADASH")]
		public const int PubkeySeqAdash = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_AE']"
		[Register ("PUBKEY_SEQ_AE")]
		public const int PubkeySeqAe = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_ARUP']"
		[Register ("PUBKEY_SEQ_ARUP")]
		public const int PubkeySeqArup = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_CDN']"
		[Register ("PUBKEY_SEQ_CDN")]
		public const int PubkeySeqCdn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_OPEN']"
		[Register ("PUBKEY_SEQ_OPEN")]
		public const int PubkeySeqOpen = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='PUBKEY_SEQ_TEST']"
		[Register ("PUBKEY_SEQ_TEST")]
		public const int PubkeySeqTest = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='QUIC']"
		[Register ("QUIC")]
		public const int Quic = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SLIGHTSSLV2']"
		[Register ("SLIGHTSSLV2")]
		public const int Slightsslv2 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SLIGHTSSL_0_RTT_MODE']"
		[Register ("SLIGHTSSL_0_RTT_MODE")]
		public const int Slightssl0RttMode = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SLIGHTSSL_1_RTT_MODE']"
		[Register ("SLIGHTSSL_1_RTT_MODE")]
		public const int Slightssl1RttMode = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SLIGHTSSL_L7E']"
		[Register ("SLIGHTSSL_L7E")]
		public const int SlightsslL7e = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SPDY']"
		[Register ("SPDY")]
		public const int Spdy = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_0RTT_CUSTOM']"
		[Register ("SSSL_0RTT_CUSTOM")]
		public const int Sssl0rttCustom = (int) 4240;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_0RTT_HTTP2']"
		[Register ("SSSL_0RTT_HTTP2")]
		public const int Sssl0rttHttp2 = (int) 4232;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_0RTT_SPDY']"
		[Register ("SSSL_0RTT_SPDY")]
		public const int Sssl0rttSpdy = (int) 4226;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_1RTT_CUSTOM']"
		[Register ("SSSL_1RTT_CUSTOM")]
		public const int Sssl1rttCustom = (int) 8336;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_1RTT_HTTP2']"
		[Register ("SSSL_1RTT_HTTP2")]
		public const int Sssl1rttHttp2 = (int) 8328;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='SSSL_1RTT_SPDY']"
		[Register ("SSSL_1RTT_SPDY")]
		public const int Sssl1rttSpdy = (int) 8322;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='TNET_IPV4_TO_IPV6_AUTO']"
		[Register ("TNET_IPV4_TO_IPV6_AUTO")]
		public const int TnetIpv4ToIpv6Auto = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='TNET_IPV4_TO_IPV6_OFF']"
		[Register ("TNET_IPV4_TO_IPV6_OFF")]
		public const int TnetIpv4ToIpv6Off = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='TNET_IPV4_TO_IPV6_ON']"
		[Register ("TNET_IPV4_TO_IPV6_ON")]
		public const int TnetIpv4ToIpv6On = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/field[@name='TNET_PUBKEY_SG_KEY']"
		[Register ("TNET_PUBKEY_SG_KEY")]
		public const string TnetPubkeySgKey = (string) "tnet_pksg_key";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyProtocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyProtocol); }
		}

		protected SpdyProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyProtocol']/constructor[@name='SpdyProtocol' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpdyProtocol ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SpdyProtocol)) {
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

	}
}

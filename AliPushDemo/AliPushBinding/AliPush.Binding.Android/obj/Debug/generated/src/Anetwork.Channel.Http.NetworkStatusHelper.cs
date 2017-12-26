using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper']"
	[global::Android.Runtime.Register ("anetwork/channel/http/NetworkStatusHelper", DoNotGenerateAcw=true)]
	public sealed partial class NetworkStatusHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']"
		[global::Android.Runtime.Register ("anetwork/channel/http/NetworkStatusHelper$NetworkStatus", DoNotGenerateAcw=true)]
		public sealed partial class NetworkStatus : global::Java.Lang.Enum {


			static IntPtr CDMA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='CDMA']"
			[Register ("CDMA")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus Cdma {
				get {
					if (CDMA_jfieldId == IntPtr.Zero)
						CDMA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDMA", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CDMA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EDGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='EDGE']"
			[Register ("EDGE")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus Edge {
				get {
					if (EDGE_jfieldId == IntPtr.Zero)
						EDGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EDGE", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EDGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='G3']"
			[Register ("G3")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus G3 {
				get {
					if (G3_jfieldId == IntPtr.Zero)
						G3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G3", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='G4']"
			[Register ("G4")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus G4 {
				get {
					if (G4_jfieldId == IntPtr.Zero)
						G4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G4", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GPRS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='GPRS']"
			[Register ("GPRS")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus Gprs {
				get {
					if (GPRS_jfieldId == IntPtr.Zero)
						GPRS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GPRS", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GPRS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='NO']"
			[Register ("NO")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus No {
				get {
					if (NO_jfieldId == IntPtr.Zero)
						NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("anetwork/channel/http/NetworkStatusHelper$NetworkStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkStatus); }
			}

			internal NetworkStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;", "")]
			public static unsafe global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.http']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;", "")]
			public static unsafe global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanetwork/channel/http/NetworkStatusHelper$NetworkStatus;");
				try {
					return (global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anetwork.Channel.Http.NetworkStatusHelper.NetworkStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/http/NetworkStatusHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkStatusHelper); }
		}

		internal NetworkStatusHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

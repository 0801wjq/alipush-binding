using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyRequest", DoNotGenerateAcw=true)]
	public sealed partial class SpdyRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/field[@name='GET_METHOD']"
		[Register ("GET_METHOD")]
		public const string GetMethod = (string) "GET";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/field[@name='POST_METHOD']"
		[Register ("POST_METHOD")]
		public const string PostMethod = (string) "POST";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyRequest); }
		}

		internal SpdyRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=10 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='org.android.spdy.RequestPriority'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, int p2, string p3, int p4, string p5, global::Org.Android.Spdy.RequestPriority p6, int p7, int p8, int p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, int p2, string p3, global::Org.Android.Spdy.RequestPriority p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=11 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='org.android.spdy.RequestPriority'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, string p2, int p3, string p4, int p5, string p6, global::Org.Android.Spdy.RequestPriority p7, int p8, int p9, int p10)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=6 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, string p2, int p3, string p4, global::Org.Android.Spdy.RequestPriority p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=4 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, string p2, global::Org.Android.Spdy.RequestPriority p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=6 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.android.spdy.RequestPriority'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, string p2, global::Org.Android.Spdy.RequestPriority p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, global::Org.Android.Spdy.RequestPriority p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.android.spdy.RequestPriority'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", "")]
		public unsafe SpdyRequest (global::Java.Net.URL p0, string p1, global::Org.Android.Spdy.RequestPriority p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (SpdyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAuthority;
		public unsafe string Authority {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getAuthority' and count(parameter)=0]"
			[Register ("getAuthority", "()Ljava/lang/String;", "GetGetAuthorityHandler")]
			get {
				if (id_getAuthority == IntPtr.Zero)
					id_getAuthority = JNIEnv.GetMethodID (class_ref, "getAuthority", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthority), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConnectionTimeoutMs;
		public unsafe int ConnectionTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getConnectionTimeoutMs' and count(parameter)=0]"
			[Register ("getConnectionTimeoutMs", "()I", "GetGetConnectionTimeoutMsHandler")]
			get {
				if (id_getConnectionTimeoutMs == IntPtr.Zero)
					id_getConnectionTimeoutMs = JNIEnv.GetMethodID (class_ref, "getConnectionTimeoutMs", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionTimeoutMs);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestTimeoutMs;
		public unsafe int RequestTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getRequestTimeoutMs' and count(parameter)=0]"
			[Register ("getRequestTimeoutMs", "()I", "GetGetRequestTimeoutMsHandler")]
			get {
				if (id_getRequestTimeoutMs == IntPtr.Zero)
					id_getRequestTimeoutMs = JNIEnv.GetMethodID (class_ref, "getRequestTimeoutMs", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRequestTimeoutMs);
				} finally {
				}
			}
		}

		static IntPtr id_getRetryTimes;
		public unsafe int RetryTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getRetryTimes' and count(parameter)=0]"
			[Register ("getRetryTimes", "()I", "GetGetRetryTimesHandler")]
			get {
				if (id_getRetryTimes == IntPtr.Zero)
					id_getRetryTimes = JNIEnv.GetMethodID (class_ref, "getRetryTimes", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryTimes);
				} finally {
				}
			}
		}

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addHeaders_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='addHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("addHeaders", "(Ljava/util/Map;)V", "")]
		public unsafe void AddHeaders (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_addHeaders_Ljava_util_Map_ == IntPtr.Zero)
				id_addHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addHeaders", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeaders_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDomain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDomain", "(Ljava/lang/String;)V", "")]
		public unsafe void SetDomain (string p0)
		{
			if (id_setDomain_Ljava_lang_String_ == IntPtr.Zero)
				id_setDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDomain", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDomain_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

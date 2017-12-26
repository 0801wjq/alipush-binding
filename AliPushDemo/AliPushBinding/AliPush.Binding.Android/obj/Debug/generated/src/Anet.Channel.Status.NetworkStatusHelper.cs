using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Status {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']"
	[global::Android.Runtime.Register ("anet/channel/status/NetworkStatusHelper", DoNotGenerateAcw=true)]
	public sealed partial class NetworkStatusHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.status']/interface[@name='NetworkStatusHelper.INetworkStatusChangeListener']"
		[Register ("anet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener", "", "Anet.Channel.Status.NetworkStatusHelper/INetworkStatusChangeListenerInvoker")]
		public partial interface INetworkStatusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/interface[@name='NetworkStatusHelper.INetworkStatusChangeListener']/method[@name='onNetworkStatusChanged' and count(parameter)=1 and parameter[1][@type='anet.channel.status.NetworkStatusHelper.NetworkStatus']]"
			[Register ("onNetworkStatusChanged", "(Lanet/channel/status/NetworkStatusHelper$NetworkStatus;)V", "GetOnNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_Handler:Anet.Channel.Status.NetworkStatusHelper/INetworkStatusChangeListenerInvoker, AliPush.Binding.Android")]
			void OnNetworkStatusChanged (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0);

		}

		[global::Android.Runtime.Register ("anet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener", DoNotGenerateAcw=true)]
		internal class INetworkStatusChangeListenerInvoker : global::Java.Lang.Object, INetworkStatusChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INetworkStatusChangeListenerInvoker); }
			}

			IntPtr class_ref;

			public static INetworkStatusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INetworkStatusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anet.channel.status.NetworkStatusHelper.INetworkStatusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INetworkStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_;
#pragma warning disable 0169
			static Delegate GetOnNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_Handler ()
			{
				if (cb_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_ == null)
					cb_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_);
				return cb_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_;
			}

			static void n_OnNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Anet.Channel.Status.NetworkStatusHelper.INetworkStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.INetworkStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0 = global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_;
			public unsafe void OnNetworkStatusChanged (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0)
			{
				if (id_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_ == IntPtr.Zero)
					id_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_ = JNIEnv.GetMethodID (class_ref, "onNetworkStatusChanged", "(Lanet/channel/status/NetworkStatusHelper$NetworkStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkStatusChanged_Lanet_channel_status_NetworkStatusHelper_NetworkStatus_, __args);
			}

		}

		public partial class NetworkStatusChangeEventArgs : global::System.EventArgs {

			public NetworkStatusChangeEventArgs (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0)
			{
				this.p0 = p0;
			}

			global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0;
			public global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/anet/channel/status/NetworkStatusHelper_INetworkStatusChangeListenerImplementor")]
		internal sealed partial class INetworkStatusChangeListenerImplementor : global::Java.Lang.Object, INetworkStatusChangeListener {

			object sender;

			public INetworkStatusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anet/channel/status/NetworkStatusHelper_INetworkStatusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NetworkStatusChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnNetworkStatusChanged (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new NetworkStatusChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (INetworkStatusChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']"
		[global::Android.Runtime.Register ("anet/channel/status/NetworkStatusHelper$NetworkStatus", DoNotGenerateAcw=true)]
		public sealed partial class NetworkStatus : global::Java.Lang.Enum {


			static IntPtr G2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='G2']"
			[Register ("G2")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus G2 {
				get {
					if (G2_jfieldId == IntPtr.Zero)
						G2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G2", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='G3']"
			[Register ("G3")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus G3 {
				get {
					if (G3_jfieldId == IntPtr.Zero)
						G3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G3", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr G4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='G4']"
			[Register ("G4")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus G4 {
				get {
					if (G4_jfieldId == IntPtr.Zero)
						G4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G4", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='NO']"
			[Register ("NO")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus No {
				get {
					if (NO_jfieldId == IntPtr.Zero)
						NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("anet/channel/status/NetworkStatusHelper$NetworkStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkStatus); }
			}

			internal NetworkStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_isMobile;
			public unsafe bool IsMobile {
				// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='isMobile' and count(parameter)=0]"
				[Register ("isMobile", "()Z", "GetIsMobileHandler")]
				get {
					if (id_isMobile == IntPtr.Zero)
						id_isMobile = JNIEnv.GetMethodID (class_ref, "isMobile", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMobile);
					} finally {
					}
				}
			}

			static IntPtr id_isWifi;
			public unsafe bool IsWifi {
				// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='isWifi' and count(parameter)=0]"
				[Register ("isWifi", "()Z", "GetIsWifiHandler")]
				get {
					if (id_isWifi == IntPtr.Zero)
						id_isWifi = JNIEnv.GetMethodID (class_ref, "isWifi", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWifi);
					} finally {
					}
				}
			}

			static IntPtr id_getType;
			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lanet/channel/status/NetworkStatusHelper$NetworkStatus;", "")]
			public static unsafe global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper.NetworkStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lanet/channel/status/NetworkStatusHelper$NetworkStatus;", "")]
			public static unsafe global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
				try {
					return (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/status/NetworkStatusHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkStatusHelper); }
		}

		internal NetworkStatusHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lanet/channel/status/NetworkStatusHelper$NetworkStatus;", "")]
		public static unsafe global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lanet/channel/status/NetworkStatusHelper$NetworkStatus;");
			try {
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Status.NetworkStatusHelper.NetworkStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='anet.channel.status.NetworkStatusHelper.INetworkStatusChangeListener']]"
		[Register ("a", "(Lanet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener;)V", "")]
		public static unsafe void A (global::Anet.Channel.Status.NetworkStatusHelper.INetworkStatusChangeListener p0)
		{
			if (id_a_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_ == IntPtr.Zero)
				id_a_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lanet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "")]
		public static unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetStaticMethodID (class_ref, "b", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='b' and count(parameter)=1 and parameter[1][@type='anet.channel.status.NetworkStatusHelper.INetworkStatusChangeListener']]"
		[Register ("b", "(Lanet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener;)V", "")]
		public static unsafe void B (global::Anet.Channel.Status.NetworkStatusHelper.INetworkStatusChangeListener p0)
		{
			if (id_b_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_ == IntPtr.Zero)
				id_b_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lanet/channel/status/NetworkStatusHelper$INetworkStatusChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Lanet_channel_status_NetworkStatusHelper_INetworkStatusChangeListener_, __args);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public static unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "")]
		public static unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetStaticMethodID (class_ref, "d", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "")]
		public static unsafe string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetStaticMethodID (class_ref, "e", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_e), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public static unsafe string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetStaticMethodID (class_ref, "f", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public static unsafe bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetStaticMethodID (class_ref, "g", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_g);
			} finally {
			}
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Z", "")]
		public static unsafe bool H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetStaticMethodID (class_ref, "h", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_h);
			} finally {
			}
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "")]
		public static unsafe string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetStaticMethodID (class_ref, "i", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_i), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetStaticMethodID (class_ref, "j", "()Landroid/util/Pair;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_j), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.status']/class[@name='NetworkStatusHelper']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()V", "")]
		public static unsafe void K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetStaticMethodID (class_ref, "k", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_k);
			} finally {
			}
		}

	}
}

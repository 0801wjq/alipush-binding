using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel']/class[@name='NetworkInfo']"
	[global::Android.Runtime.Register ("anetwork/channel/NetworkInfo", DoNotGenerateAcw=true)]
	public partial class NetworkInfo : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkInfo.NetworkInfoListener']"
		[Register ("anetwork/channel/NetworkInfo$NetworkInfoListener", "", "Anetwork.Channel.NetworkInfo/INetworkInfoListenerInvoker")]
		public partial interface INetworkInfoListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkInfo.NetworkInfoListener']/method[@name='onFinished' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onFinished", "(Ljava/lang/String;)V", "GetOnFinished_Ljava_lang_String_Handler:Anetwork.Channel.NetworkInfo/INetworkInfoListenerInvoker, AliPush.Binding.Android")]
			void OnFinished (string p0);

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkInfo$NetworkInfoListener", DoNotGenerateAcw=true)]
		internal class INetworkInfoListenerInvoker : global::Java.Lang.Object, INetworkInfoListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkInfo$NetworkInfoListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INetworkInfoListenerInvoker); }
			}

			IntPtr class_ref;

			public static INetworkInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INetworkInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkInfo.NetworkInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INetworkInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFinished_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFinished_Ljava_lang_String_Handler ()
			{
				if (cb_onFinished_Ljava_lang_String_ == null)
					cb_onFinished_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFinished_Ljava_lang_String_);
				return cb_onFinished_Ljava_lang_String_;
			}

			static void n_OnFinished_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Anetwork.Channel.NetworkInfo.INetworkInfoListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkInfo.INetworkInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFinished_Ljava_lang_String_;
			public unsafe void OnFinished (string p0)
			{
				if (id_onFinished_Ljava_lang_String_ == IntPtr.Zero)
					id_onFinished_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFinished", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinished_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class NetworkInfoEventArgs : global::System.EventArgs {

			public NetworkInfoEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/anetwork/channel/NetworkInfo_NetworkInfoListenerImplementor")]
		internal sealed partial class INetworkInfoListenerImplementor : global::Java.Lang.Object, INetworkInfoListener {

			object sender;

			public INetworkInfoListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anetwork/channel/NetworkInfo_NetworkInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NetworkInfoEventArgs> Handler;
#pragma warning restore 0649

			public void OnFinished (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new NetworkInfoEventArgs (p0));
			}

			internal static bool __IsEmpty (INetworkInfoListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/NetworkInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkInfo); }
		}

		protected NetworkInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

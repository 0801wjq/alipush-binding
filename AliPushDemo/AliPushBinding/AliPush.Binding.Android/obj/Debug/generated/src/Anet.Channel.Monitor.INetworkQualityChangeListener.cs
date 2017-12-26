using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Monitor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.monitor']/interface[@name='INetworkQualityChangeListener']"
	[Register ("anet/channel/monitor/INetworkQualityChangeListener", "", "Anet.Channel.Monitor.INetworkQualityChangeListenerInvoker")]
	public partial interface INetworkQualityChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.monitor']/interface[@name='INetworkQualityChangeListener']/method[@name='onNetworkQualityChanged' and count(parameter)=1 and parameter[1][@type='anet.channel.monitor.NetworkSpeed']]"
		[Register ("onNetworkQualityChanged", "(Lanet/channel/monitor/NetworkSpeed;)V", "GetOnNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_Handler:Anet.Channel.Monitor.INetworkQualityChangeListenerInvoker, AliPush.Binding.Android")]
		void OnNetworkQualityChanged (global::Anet.Channel.Monitor.NetworkSpeed p0);

	}

	[global::Android.Runtime.Register ("anet/channel/monitor/INetworkQualityChangeListener", DoNotGenerateAcw=true)]
	internal class INetworkQualityChangeListenerInvoker : global::Java.Lang.Object, INetworkQualityChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/monitor/INetworkQualityChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkQualityChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static INetworkQualityChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkQualityChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.monitor.INetworkQualityChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkQualityChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_;
#pragma warning disable 0169
		static Delegate GetOnNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_Handler ()
		{
			if (cb_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_ == null)
				cb_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_);
			return cb_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_;
		}

		static void n_OnNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Monitor.INetworkQualityChangeListener __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.INetworkQualityChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anet.Channel.Monitor.NetworkSpeed p0 = global::Java.Lang.Object.GetObject<global::Anet.Channel.Monitor.NetworkSpeed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkQualityChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_;
		public unsafe void OnNetworkQualityChanged (global::Anet.Channel.Monitor.NetworkSpeed p0)
		{
			if (id_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_ == IntPtr.Zero)
				id_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_ = JNIEnv.GetMethodID (class_ref, "onNetworkQualityChanged", "(Lanet/channel/monitor/NetworkSpeed;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkQualityChanged_Lanet_channel_monitor_NetworkSpeed_, __args);
		}

	}

	public partial class NetworkQualityChangeEventArgs : global::System.EventArgs {

		public NetworkQualityChangeEventArgs (global::Anet.Channel.Monitor.NetworkSpeed p0)
		{
			this.p0 = p0;
		}

		global::Anet.Channel.Monitor.NetworkSpeed p0;
		public global::Anet.Channel.Monitor.NetworkSpeed P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/anet/channel/monitor/INetworkQualityChangeListenerImplementor")]
	internal sealed partial class INetworkQualityChangeListenerImplementor : global::Java.Lang.Object, INetworkQualityChangeListener {

		object sender;

		public INetworkQualityChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anet/channel/monitor/INetworkQualityChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<NetworkQualityChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnNetworkQualityChanged (global::Anet.Channel.Monitor.NetworkSpeed p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new NetworkQualityChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (INetworkQualityChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

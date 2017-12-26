using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkListener']"
	[Register ("anetwork/channel/NetworkListener", "", "Anetwork.Channel.INetworkListenerInvoker")]
	public partial interface INetworkListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("anetwork/channel/NetworkListener", DoNotGenerateAcw=true)]
	internal class INetworkListenerInvoker : global::Java.Lang.Object, INetworkListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkListenerInvoker); }
		}

		IntPtr class_ref;

		public static INetworkListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/anetwork/channel/NetworkListenerImplementor")]
	internal sealed partial class INetworkListenerImplementor : global::Java.Lang.Object, INetworkListener {

		public INetworkListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anetwork/channel/NetworkListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (INetworkListenerImplementor value)
		{
			return true;
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Heartbeat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeatFactory']"
	[Register ("anet/channel/heartbeat/IHeartbeatFactory", "", "Anet.Channel.Heartbeat.IHeartbeatFactoryInvoker")]
	public partial interface IHeartbeatFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeatFactory']/method[@name='createHeartbeat' and count(parameter)=1 and parameter[1][@type='anet.channel.Session']]"
		[Register ("createHeartbeat", "(Lanet/channel/Session;)Lanet/channel/heartbeat/IHeartbeat;", "GetCreateHeartbeat_Lanet_channel_Session_Handler:Anet.Channel.Heartbeat.IHeartbeatFactoryInvoker, AliPush.Binding.Android")]
		global::Anet.Channel.Heartbeat.IHeartbeat CreateHeartbeat (global::Anet.Channel.Session p0);

	}

	[global::Android.Runtime.Register ("anet/channel/heartbeat/IHeartbeatFactory", DoNotGenerateAcw=true)]
	internal class IHeartbeatFactoryInvoker : global::Java.Lang.Object, IHeartbeatFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/heartbeat/IHeartbeatFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHeartbeatFactoryInvoker); }
		}

		IntPtr class_ref;

		public static IHeartbeatFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHeartbeatFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.heartbeat.IHeartbeatFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHeartbeatFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createHeartbeat_Lanet_channel_Session_;
#pragma warning disable 0169
		static Delegate GetCreateHeartbeat_Lanet_channel_Session_Handler ()
		{
			if (cb_createHeartbeat_Lanet_channel_Session_ == null)
				cb_createHeartbeat_Lanet_channel_Session_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHeartbeat_Lanet_channel_Session_);
			return cb_createHeartbeat_Lanet_channel_Session_;
		}

		static IntPtr n_CreateHeartbeat_Lanet_channel_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Heartbeat.IHeartbeatFactory __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeatFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anet.Channel.Session p0 = global::Java.Lang.Object.GetObject<global::Anet.Channel.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHeartbeat (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createHeartbeat_Lanet_channel_Session_;
		public unsafe global::Anet.Channel.Heartbeat.IHeartbeat CreateHeartbeat (global::Anet.Channel.Session p0)
		{
			if (id_createHeartbeat_Lanet_channel_Session_ == IntPtr.Zero)
				id_createHeartbeat_Lanet_channel_Session_ = JNIEnv.GetMethodID (class_ref, "createHeartbeat", "(Lanet/channel/Session;)Lanet/channel/heartbeat/IHeartbeat;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Anet.Channel.Heartbeat.IHeartbeat __ret = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createHeartbeat_Lanet_channel_Session_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Strategy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']"
	[Register ("anet/channel/strategy/IConnStrategy", "", "Anet.Channel.Strategy.IConnStrategyInvoker")]
	public partial interface IConnStrategy : IJavaObject {

		int ConnectionTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getConnectionTimeout' and count(parameter)=0]"
			[Register ("getConnectionTimeout", "()I", "GetGetConnectionTimeoutHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		int Heartbeat {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getHeartbeat' and count(parameter)=0]"
			[Register ("getHeartbeat", "()I", "GetGetHeartbeatHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		string Ip {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getIp' and count(parameter)=0]"
			[Register ("getIp", "()Ljava/lang/String;", "GetGetIpHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		int IpType {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getIpType' and count(parameter)=0]"
			[Register ("getIpType", "()I", "GetGetIpTypeHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		global::Anet.Channel.Strategy.ConnProtocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getProtocol' and count(parameter)=0]"
			[Register ("getProtocol", "()Lanet/channel/strategy/ConnProtocol;", "GetGetProtocolHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "GetGetReadTimeoutHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

		int RetryTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy']/interface[@name='IConnStrategy']/method[@name='getRetryTimes' and count(parameter)=0]"
			[Register ("getRetryTimes", "()I", "GetGetRetryTimesHandler:Anet.Channel.Strategy.IConnStrategyInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("anet/channel/strategy/IConnStrategy", DoNotGenerateAcw=true)]
	internal class IConnStrategyInvoker : global::Java.Lang.Object, IConnStrategy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/strategy/IConnStrategy");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnStrategyInvoker); }
		}

		IntPtr class_ref;

		public static IConnStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.strategy.IConnStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getConnectionTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectionTimeoutHandler ()
		{
			if (cb_getConnectionTimeout == null)
				cb_getConnectionTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionTimeout);
			return cb_getConnectionTimeout;
		}

		static int n_GetConnectionTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionTimeout;
		}
#pragma warning restore 0169

		IntPtr id_getConnectionTimeout;
		public unsafe int ConnectionTimeout {
			get {
				if (id_getConnectionTimeout == IntPtr.Zero)
					id_getConnectionTimeout = JNIEnv.GetMethodID (class_ref, "getConnectionTimeout", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionTimeout);
			}
		}

		static Delegate cb_getHeartbeat;
#pragma warning disable 0169
		static Delegate GetGetHeartbeatHandler ()
		{
			if (cb_getHeartbeat == null)
				cb_getHeartbeat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeartbeat);
			return cb_getHeartbeat;
		}

		static int n_GetHeartbeat (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Heartbeat;
		}
#pragma warning restore 0169

		IntPtr id_getHeartbeat;
		public unsafe int Heartbeat {
			get {
				if (id_getHeartbeat == IntPtr.Zero)
					id_getHeartbeat = JNIEnv.GetMethodID (class_ref, "getHeartbeat", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeartbeat);
			}
		}

		static Delegate cb_getIp;
#pragma warning disable 0169
		static Delegate GetGetIpHandler ()
		{
			if (cb_getIp == null)
				cb_getIp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIp);
			return cb_getIp;
		}

		static IntPtr n_GetIp (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ip);
		}
#pragma warning restore 0169

		IntPtr id_getIp;
		public unsafe string Ip {
			get {
				if (id_getIp == IntPtr.Zero)
					id_getIp = JNIEnv.GetMethodID (class_ref, "getIp", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIpType;
#pragma warning disable 0169
		static Delegate GetGetIpTypeHandler ()
		{
			if (cb_getIpType == null)
				cb_getIpType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIpType);
			return cb_getIpType;
		}

		static int n_GetIpType (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IpType;
		}
#pragma warning restore 0169

		IntPtr id_getIpType;
		public unsafe int IpType {
			get {
				if (id_getIpType == IntPtr.Zero)
					id_getIpType = JNIEnv.GetMethodID (class_ref, "getIpType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIpType);
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		IntPtr id_getPort;
		public unsafe int Port {
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPort);
			}
		}

		static Delegate cb_getProtocol;
#pragma warning disable 0169
		static Delegate GetGetProtocolHandler ()
		{
			if (cb_getProtocol == null)
				cb_getProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProtocol);
			return cb_getProtocol;
		}

		static IntPtr n_GetProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Protocol);
		}
#pragma warning restore 0169

		IntPtr id_getProtocol;
		public unsafe global::Anet.Channel.Strategy.ConnProtocol Protocol {
			get {
				if (id_getProtocol == IntPtr.Zero)
					id_getProtocol = JNIEnv.GetMethodID (class_ref, "getProtocol", "()Lanet/channel/strategy/ConnProtocol;");
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.ConnProtocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProtocol), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReadTimeout;
#pragma warning disable 0169
		static Delegate GetGetReadTimeoutHandler ()
		{
			if (cb_getReadTimeout == null)
				cb_getReadTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadTimeout);
			return cb_getReadTimeout;
		}

		static int n_GetReadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeout;
		}
#pragma warning restore 0169

		IntPtr id_getReadTimeout;
		public unsafe int ReadTimeout {
			get {
				if (id_getReadTimeout == IntPtr.Zero)
					id_getReadTimeout = JNIEnv.GetMethodID (class_ref, "getReadTimeout", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReadTimeout);
			}
		}

		static Delegate cb_getRetryTimes;
#pragma warning disable 0169
		static Delegate GetGetRetryTimesHandler ()
		{
			if (cb_getRetryTimes == null)
				cb_getRetryTimes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryTimes);
			return cb_getRetryTimes;
		}

		static int n_GetRetryTimes (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Strategy.IConnStrategy __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.IConnStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryTimes;
		}
#pragma warning restore 0169

		IntPtr id_getRetryTimes;
		public unsafe int RetryTimes {
			get {
				if (id_getRetryTimes == IntPtr.Zero)
					id_getRetryTimes = JNIEnv.GetMethodID (class_ref, "getRetryTimes", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryTimes);
			}
		}

	}

}

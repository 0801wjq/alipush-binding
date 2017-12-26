using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Heartbeat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']"
	[Register ("anet/channel/heartbeat/IHeartbeat", "", "Anet.Channel.Heartbeat.IHeartbeatInvoker")]
	public partial interface IHeartbeat : IJavaObject {

		long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler:Anet.Channel.Heartbeat.IHeartbeatInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']/method[@name='heartbeat' and count(parameter)=0]"
		[Register ("heartbeat", "()V", "GetHeartbeatHandler:Anet.Channel.Heartbeat.IHeartbeatInvoker, AliPush.Binding.Android")]
		void Heartbeat ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']/method[@name='reSchedule' and count(parameter)=0]"
		[Register ("reSchedule", "()V", "GetReScheduleHandler:Anet.Channel.Heartbeat.IHeartbeatInvoker, AliPush.Binding.Android")]
		void ReSchedule ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Anet.Channel.Heartbeat.IHeartbeatInvoker, AliPush.Binding.Android")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.heartbeat']/interface[@name='IHeartbeat']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Anet.Channel.Heartbeat.IHeartbeatInvoker, AliPush.Binding.Android")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("anet/channel/heartbeat/IHeartbeat", DoNotGenerateAcw=true)]
	internal class IHeartbeatInvoker : global::Java.Lang.Object, IHeartbeat {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/heartbeat/IHeartbeat");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHeartbeatInvoker); }
		}

		IntPtr class_ref;

		public static IHeartbeat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHeartbeat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.heartbeat.IHeartbeat"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHeartbeatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInterval);
			return cb_getInterval;
		}

		static long n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Heartbeat.IHeartbeat __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		IntPtr id_getInterval;
		public unsafe long Interval {
			get {
				if (id_getInterval == IntPtr.Zero)
					id_getInterval = JNIEnv.GetMethodID (class_ref, "getInterval", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getInterval);
			}
		}

		static Delegate cb_heartbeat;
#pragma warning disable 0169
		static Delegate GetHeartbeatHandler ()
		{
			if (cb_heartbeat == null)
				cb_heartbeat = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Heartbeat);
			return cb_heartbeat;
		}

		static void n_Heartbeat (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Heartbeat.IHeartbeat __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Heartbeat ();
		}
#pragma warning restore 0169

		IntPtr id_heartbeat;
		public unsafe void Heartbeat ()
		{
			if (id_heartbeat == IntPtr.Zero)
				id_heartbeat = JNIEnv.GetMethodID (class_ref, "heartbeat", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_heartbeat);
		}

		static Delegate cb_reSchedule;
#pragma warning disable 0169
		static Delegate GetReScheduleHandler ()
		{
			if (cb_reSchedule == null)
				cb_reSchedule = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReSchedule);
			return cb_reSchedule;
		}

		static void n_ReSchedule (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Heartbeat.IHeartbeat __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReSchedule ();
		}
#pragma warning restore 0169

		IntPtr id_reSchedule;
		public unsafe void ReSchedule ()
		{
			if (id_reSchedule == IntPtr.Zero)
				id_reSchedule = JNIEnv.GetMethodID (class_ref, "reSchedule", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reSchedule);
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Heartbeat.IHeartbeat __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Anet.Channel.Heartbeat.IHeartbeat __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Heartbeat.IHeartbeat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}

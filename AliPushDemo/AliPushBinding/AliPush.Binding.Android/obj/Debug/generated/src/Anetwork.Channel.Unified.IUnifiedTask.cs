using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Unified {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.unified']/interface[@name='IUnifiedTask']"
	[Register ("anetwork/channel/unified/IUnifiedTask", "", "Anetwork.Channel.Unified.IUnifiedTaskInvoker")]
	public partial interface IUnifiedTask : global::Anet.Channel.Request.ICancelable, global::Java.Lang.IRunnable {

	}

	[global::Android.Runtime.Register ("anetwork/channel/unified/IUnifiedTask", DoNotGenerateAcw=true)]
	internal class IUnifiedTaskInvoker : global::Java.Lang.Object, IUnifiedTask {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/unified/IUnifiedTask");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUnifiedTaskInvoker); }
		}

		IntPtr class_ref;

		public static IUnifiedTask GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnifiedTask> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.unified.IUnifiedTask"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnifiedTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Unified.IUnifiedTask __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Unified.IUnifiedTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Unified.IUnifiedTask __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Unified.IUnifiedTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		IntPtr id_run;
		public unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
		}

	}

}

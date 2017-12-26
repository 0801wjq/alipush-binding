using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Request {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.request']/interface[@name='Cancelable']"
	[Register ("anet/channel/request/Cancelable", "", "Anet.Channel.Request.ICancelableInvoker")]
	public partial interface ICancelable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.request']/interface[@name='Cancelable']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Anet.Channel.Request.ICancelableInvoker, AliPush.Binding.Android")]
		void Cancel ();

	}

	[global::Android.Runtime.Register ("anet/channel/request/Cancelable", DoNotGenerateAcw=true)]
	internal class ICancelableInvoker : global::Java.Lang.Object, ICancelable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/request/Cancelable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICancelableInvoker); }
		}

		IntPtr class_ref;

		public static ICancelable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancelable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anet.channel.request.Cancelable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancelableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Anet.Channel.Request.ICancelable __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Request.ICancelable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}

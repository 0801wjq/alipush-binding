using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='AccsSSLCallback']"
	[Register ("org/android/spdy/AccsSSLCallback", "", "Org.Android.Spdy.IAccsSSLCallbackInvoker")]
	public partial interface IAccsSSLCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='AccsSSLCallback']/method[@name='getSSLPublicKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getSSLPublicKey", "(I[B)[B", "GetGetSSLPublicKey_IarrayBHandler:Org.Android.Spdy.IAccsSSLCallbackInvoker, AliPush.Binding.Android")]
		byte[] GetSSLPublicKey (int p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("org/android/spdy/AccsSSLCallback", DoNotGenerateAcw=true)]
	internal class IAccsSSLCallbackInvoker : global::Java.Lang.Object, IAccsSSLCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/AccsSSLCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAccsSSLCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IAccsSSLCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccsSSLCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.AccsSSLCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccsSSLCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSSLPublicKey_IarrayB;
#pragma warning disable 0169
		static Delegate GetGetSSLPublicKey_IarrayBHandler ()
		{
			if (cb_getSSLPublicKey_IarrayB == null)
				cb_getSSLPublicKey_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetSSLPublicKey_IarrayB);
			return cb_getSSLPublicKey_IarrayB;
		}

		static IntPtr n_GetSSLPublicKey_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.IAccsSSLCallback __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IAccsSSLCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetSSLPublicKey (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSSLPublicKey_IarrayB;
		public unsafe byte[] GetSSLPublicKey (int p0, byte[] p1)
		{
			if (id_getSSLPublicKey_IarrayB == IntPtr.Zero)
				id_getSSLPublicKey_IarrayB = JNIEnv.GetMethodID (class_ref, "getSSLPublicKey", "(I[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSSLPublicKey_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}

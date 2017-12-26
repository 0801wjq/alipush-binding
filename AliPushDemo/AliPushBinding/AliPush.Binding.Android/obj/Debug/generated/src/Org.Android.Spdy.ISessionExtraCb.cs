using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionExtraCb']"
	[Register ("org/android/spdy/SessionExtraCb", "", "Org.Android.Spdy.ISessionExtraCbInvoker")]
	public partial interface ISessionExtraCb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionExtraCb']/method[@name='spdySessionOnWritable' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("spdySessionOnWritable", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;I)V", "GetSpdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IHandler:Org.Android.Spdy.ISessionExtraCbInvoker, AliPush.Binding.Android")]
		void SpdySessionOnWritable (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2);

	}

	[global::Android.Runtime.Register ("org/android/spdy/SessionExtraCb", DoNotGenerateAcw=true)]
	internal class ISessionExtraCbInvoker : global::Java.Lang.Object, ISessionExtraCb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/SessionExtraCb");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISessionExtraCbInvoker); }
		}

		IntPtr class_ref;

		public static ISessionExtraCb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessionExtraCb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.SessionExtraCb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionExtraCbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetSpdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IHandler ()
		{
			if (cb_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I == null)
				cb_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SpdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I);
			return cb_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I;
		}

		static void n_SpdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Android.Spdy.ISessionExtraCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionExtraCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionOnWritable (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I;
		public unsafe void SpdySessionOnWritable (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2)
		{
			if (id_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I == IntPtr.Zero)
				id_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "spdySessionOnWritable", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdySessionOnWritable_Lorg_android_spdy_SpdySession_Ljava_lang_Object_I, __args);
		}

	}

}

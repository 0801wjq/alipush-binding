using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='SslCertcb']"
	[Register ("org/android/spdy/SslCertcb", "", "Org.Android.Spdy.ISslCertcbInvoker")]
	public partial interface ISslCertcb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SslCertcb']/method[@name='getPerformance' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='org.android.spdy.SslPermData']]"
		[Register ("getPerformance", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SslPermData;)V", "GetGetPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_Handler:Org.Android.Spdy.ISslCertcbInvoker, AliPush.Binding.Android")]
		void GetPerformance (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SslPermData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SslCertcb']/method[@name='getPublicKey' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SpdySession']]"
		[Register ("getPublicKey", "(Lorg/android/spdy/SpdySession;)Lorg/android/spdy/SslPublickey;", "GetGetPublicKey_Lorg_android_spdy_SpdySession_Handler:Org.Android.Spdy.ISslCertcbInvoker, AliPush.Binding.Android")]
		global::Org.Android.Spdy.SslPublickey GetPublicKey (global::Org.Android.Spdy.SpdySession p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SslCertcb']/method[@name='putCertificate' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("putCertificate", "(Lorg/android/spdy/SpdySession;[BI)I", "GetPutCertificate_Lorg_android_spdy_SpdySession_arrayBIHandler:Org.Android.Spdy.ISslCertcbInvoker, AliPush.Binding.Android")]
		int PutCertificate (global::Org.Android.Spdy.SpdySession p0, byte[] p1, int p2);

	}

	[global::Android.Runtime.Register ("org/android/spdy/SslCertcb", DoNotGenerateAcw=true)]
	internal class ISslCertcbInvoker : global::Java.Lang.Object, ISslCertcb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/SslCertcb");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISslCertcbInvoker); }
		}

		IntPtr class_ref;

		public static ISslCertcb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISslCertcb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.SslCertcb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISslCertcbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_;
#pragma warning disable 0169
		static Delegate GetGetPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_Handler ()
		{
			if (cb_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_ == null)
				cb_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_);
			return cb_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_;
		}

		static void n_GetPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.ISslCertcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISslCertcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SslPermData p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SslPermData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPerformance (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_;
		public unsafe void GetPerformance (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SslPermData p1)
		{
			if (id_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_ == IntPtr.Zero)
				id_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_ = JNIEnv.GetMethodID (class_ref, "getPerformance", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SslPermData;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPerformance_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SslPermData_, __args);
		}

		static Delegate cb_getPublicKey_Lorg_android_spdy_SpdySession_;
#pragma warning disable 0169
		static Delegate GetGetPublicKey_Lorg_android_spdy_SpdySession_Handler ()
		{
			if (cb_getPublicKey_Lorg_android_spdy_SpdySession_ == null)
				cb_getPublicKey_Lorg_android_spdy_SpdySession_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPublicKey_Lorg_android_spdy_SpdySession_);
			return cb_getPublicKey_Lorg_android_spdy_SpdySession_;
		}

		static IntPtr n_GetPublicKey_Lorg_android_spdy_SpdySession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Spdy.ISslCertcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISslCertcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPublicKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPublicKey_Lorg_android_spdy_SpdySession_;
		public unsafe global::Org.Android.Spdy.SslPublickey GetPublicKey (global::Org.Android.Spdy.SpdySession p0)
		{
			if (id_getPublicKey_Lorg_android_spdy_SpdySession_ == IntPtr.Zero)
				id_getPublicKey_Lorg_android_spdy_SpdySession_ = JNIEnv.GetMethodID (class_ref, "getPublicKey", "(Lorg/android/spdy/SpdySession;)Lorg/android/spdy/SslPublickey;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Org.Android.Spdy.SslPublickey __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SslPublickey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKey_Lorg_android_spdy_SpdySession_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_putCertificate_Lorg_android_spdy_SpdySession_arrayBI;
#pragma warning disable 0169
		static Delegate GetPutCertificate_Lorg_android_spdy_SpdySession_arrayBIHandler ()
		{
			if (cb_putCertificate_Lorg_android_spdy_SpdySession_arrayBI == null)
				cb_putCertificate_Lorg_android_spdy_SpdySession_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_PutCertificate_Lorg_android_spdy_SpdySession_arrayBI);
			return cb_putCertificate_Lorg_android_spdy_SpdySession_arrayBI;
		}

		static int n_PutCertificate_Lorg_android_spdy_SpdySession_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Android.Spdy.ISslCertcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISslCertcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PutCertificate (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putCertificate_Lorg_android_spdy_SpdySession_arrayBI;
		public unsafe int PutCertificate (global::Org.Android.Spdy.SpdySession p0, byte[] p1, int p2)
		{
			if (id_putCertificate_Lorg_android_spdy_SpdySession_arrayBI == IntPtr.Zero)
				id_putCertificate_Lorg_android_spdy_SpdySession_arrayBI = JNIEnv.GetMethodID (class_ref, "putCertificate", "(Lorg/android/spdy/SpdySession;[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_putCertificate_Lorg_android_spdy_SpdySession_arrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}

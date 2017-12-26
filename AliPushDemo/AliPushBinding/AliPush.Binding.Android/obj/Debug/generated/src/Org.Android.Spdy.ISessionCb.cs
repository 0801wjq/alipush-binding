using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']"
	[Register ("org/android/spdy/SessionCb", "", "Org.Android.Spdy.ISessionCbInvoker")]
	public partial interface ISessionCb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='bioPingRecvCallback' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='int']]"
		[Register ("bioPingRecvCallback", "(Lorg/android/spdy/SpdySession;I)V", "GetBioPingRecvCallback_Lorg_android_spdy_SpdySession_IHandler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void BioPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='getSSLMeta' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SpdySession']]"
		[Register ("getSSLMeta", "(Lorg/android/spdy/SpdySession;)[B", "GetGetSSLMeta_Lorg_android_spdy_SpdySession_Handler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		byte[] GetSSLMeta (global::Org.Android.Spdy.SpdySession p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='putSSLMeta' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='byte[]']]"
		[Register ("putSSLMeta", "(Lorg/android/spdy/SpdySession;[B)I", "GetPutSSLMeta_Lorg_android_spdy_SpdySession_arrayBHandler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		int PutSSLMeta (global::Org.Android.Spdy.SpdySession p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdyCustomControlFrameFailCallback' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("spdyCustomControlFrameFailCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;II)V", "GetSpdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIHandler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdyCustomControlFrameFailCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdyCustomControlFrameRecvCallback' and count(parameter)=7 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register ("spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V", "GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdyPingRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V", "GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionCloseCallback' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SuperviseConnectInfo'] and parameter[4][@type='int']]"
		[Register ("spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V", "GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionConnectCB' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='org.android.spdy.SuperviseConnectInfo']]"
		[Register ("spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V", "GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionFailedError' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V", "GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler:Org.Android.Spdy.ISessionCbInvoker, AliPush.Binding.Android")]
		void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("org/android/spdy/SessionCb", DoNotGenerateAcw=true)]
	internal class ISessionCbInvoker : global::Java.Lang.Object, ISessionCb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/SessionCb");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISessionCbInvoker); }
		}

		IntPtr class_ref;

		public static ISessionCb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessionCb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.SessionCb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionCbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I;
#pragma warning disable 0169
		static Delegate GetBioPingRecvCallback_Lorg_android_spdy_SpdySession_IHandler ()
		{
			if (cb_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I == null)
				cb_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_BioPingRecvCallback_Lorg_android_spdy_SpdySession_I);
			return cb_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I;
		}

		static void n_BioPingRecvCallback_Lorg_android_spdy_SpdySession_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BioPingRecvCallback (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I;
		public unsafe void BioPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, int p1)
		{
			if (id_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I == IntPtr.Zero)
				id_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I = JNIEnv.GetMethodID (class_ref, "bioPingRecvCallback", "(Lorg/android/spdy/SpdySession;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bioPingRecvCallback_Lorg_android_spdy_SpdySession_I, __args);
		}

		static Delegate cb_getSSLMeta_Lorg_android_spdy_SpdySession_;
#pragma warning disable 0169
		static Delegate GetGetSSLMeta_Lorg_android_spdy_SpdySession_Handler ()
		{
			if (cb_getSSLMeta_Lorg_android_spdy_SpdySession_ == null)
				cb_getSSLMeta_Lorg_android_spdy_SpdySession_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSSLMeta_Lorg_android_spdy_SpdySession_);
			return cb_getSSLMeta_Lorg_android_spdy_SpdySession_;
		}

		static IntPtr n_GetSSLMeta_Lorg_android_spdy_SpdySession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetSSLMeta (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSSLMeta_Lorg_android_spdy_SpdySession_;
		public unsafe byte[] GetSSLMeta (global::Org.Android.Spdy.SpdySession p0)
		{
			if (id_getSSLMeta_Lorg_android_spdy_SpdySession_ == IntPtr.Zero)
				id_getSSLMeta_Lorg_android_spdy_SpdySession_ = JNIEnv.GetMethodID (class_ref, "getSSLMeta", "(Lorg/android/spdy/SpdySession;)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSSLMeta_Lorg_android_spdy_SpdySession_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			return __ret;
		}

		static Delegate cb_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB;
#pragma warning disable 0169
		static Delegate GetPutSSLMeta_Lorg_android_spdy_SpdySession_arrayBHandler ()
		{
			if (cb_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB == null)
				cb_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PutSSLMeta_Lorg_android_spdy_SpdySession_arrayB);
			return cb_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB;
		}

		static int n_PutSSLMeta_Lorg_android_spdy_SpdySession_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PutSSLMeta (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB;
		public unsafe int PutSSLMeta (global::Org.Android.Spdy.SpdySession p0, byte[] p1)
		{
			if (id_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB == IntPtr.Zero)
				id_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB = JNIEnv.GetMethodID (class_ref, "putSSLMeta", "(Lorg/android/spdy/SpdySession;[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_putSSLMeta_Lorg_android_spdy_SpdySession_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetSpdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIHandler ()
		{
			if (cb_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II == null)
				cb_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_SpdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II);
			return cb_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II;
		}

		static void n_SpdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpdyCustomControlFrameFailCallback (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II;
		public unsafe void SpdyCustomControlFrameFailCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3)
		{
			if (id_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II == IntPtr.Zero)
				id_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "spdyCustomControlFrameFailCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;II)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdyCustomControlFrameFailCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_II, __args);
		}

		static Delegate cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
#pragma warning disable 0169
		static Delegate GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler ()
		{
			if (cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == null)
				cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB);
			return cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		}

		static void n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p6 = (byte[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SpdyCustomControlFrameRecvCallback (p0, p1, p2, p3, p4, p5, p6);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
		}
#pragma warning restore 0169

		IntPtr id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		public unsafe void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6)
		{
			if (id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == IntPtr.Zero)
				id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V");
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB, __args);
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler ()
		{
			if (cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == null)
				cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_);
			return cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		}

		static void n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdyPingRecvCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		public unsafe void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == IntPtr.Zero)
				id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_, __args);
		}

		static Delegate cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
#pragma warning disable 0169
		static Delegate GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler ()
		{
			if (cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == null)
				cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I);
			return cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		}

		static void n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionCloseCallback (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		public unsafe void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3)
		{
			if (id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == IntPtr.Zero)
				id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNIEnv.GetMethodID (class_ref, "spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I, __args);
		}

		static Delegate cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
#pragma warning disable 0169
		static Delegate GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler ()
		{
			if (cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == null)
				cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_);
			return cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		}

		static void n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionConnectCB (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		public unsafe void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1)
		{
			if (id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == IntPtr.Zero)
				id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNIEnv.GetMethodID (class_ref, "spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_, __args);
		}

		static Delegate cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler ()
		{
			if (cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == null)
				cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_);
			return cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		}

		static void n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionFailedError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		public unsafe void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == IntPtr.Zero)
				id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_, __args);
		}

	}

}

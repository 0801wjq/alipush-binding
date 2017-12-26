using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SessionInfo']"
	[global::Android.Runtime.Register ("org/android/spdy/SessionInfo", DoNotGenerateAcw=true)]
	public partial class SessionInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SessionInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionInfo); }
		}

		protected SessionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ILjava_lang_Object_Lorg_android_spdy_SessionCb_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SessionInfo']/constructor[@name='SessionInfo' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='org.android.spdy.SessionCb'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;ILjava/lang/Object;Lorg/android/spdy/SessionCb;I)V", "")]
		public unsafe SessionInfo (string p0, int p1, string p2, string p3, int p4, global::Java.Lang.Object p5, global::Org.Android.Spdy.ISessionCb p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (SessionInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;ILjava/lang/Object;Lorg/android/spdy/SessionCb;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;ILjava/lang/Object;Lorg/android/spdy/SessionCb;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ILjava_lang_Object_Lorg_android_spdy_SessionCb_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ILjava_lang_Object_Lorg_android_spdy_SessionCb_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;ILjava/lang/Object;Lorg/android/spdy/SessionCb;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ILjava_lang_Object_Lorg_android_spdy_SessionCb_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ILjava_lang_Object_Lorg_android_spdy_SessionCb_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setConnectionTimeoutMs_I;
#pragma warning disable 0169
		static Delegate GetSetConnectionTimeoutMs_IHandler ()
		{
			if (cb_setConnectionTimeoutMs_I == null)
				cb_setConnectionTimeoutMs_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectionTimeoutMs_I);
			return cb_setConnectionTimeoutMs_I;
		}

		static void n_SetConnectionTimeoutMs_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.SessionInfo __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SessionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionTimeoutMs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectionTimeoutMs_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SessionInfo']/method[@name='setConnectionTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnectionTimeoutMs", "(I)V", "GetSetConnectionTimeoutMs_IHandler")]
		public virtual unsafe void SetConnectionTimeoutMs (int p0)
		{
			if (id_setConnectionTimeoutMs_I == IntPtr.Zero)
				id_setConnectionTimeoutMs_I = JNIEnv.GetMethodID (class_ref, "setConnectionTimeoutMs", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectionTimeoutMs_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionTimeoutMs", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPubKeySeqNum_I;
#pragma warning disable 0169
		static Delegate GetSetPubKeySeqNum_IHandler ()
		{
			if (cb_setPubKeySeqNum_I == null)
				cb_setPubKeySeqNum_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPubKeySeqNum_I);
			return cb_setPubKeySeqNum_I;
		}

		static void n_SetPubKeySeqNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.SessionInfo __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SessionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPubKeySeqNum (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPubKeySeqNum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SessionInfo']/method[@name='setPubKeySeqNum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPubKeySeqNum", "(I)V", "GetSetPubKeySeqNum_IHandler")]
		public virtual unsafe void SetPubKeySeqNum (int p0)
		{
			if (id_setPubKeySeqNum_I == IntPtr.Zero)
				id_setPubKeySeqNum_I = JNIEnv.GetMethodID (class_ref, "setPubKeySeqNum", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPubKeySeqNum_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPubKeySeqNum", "(I)V"), __args);
			} finally {
			}
		}

	}
}

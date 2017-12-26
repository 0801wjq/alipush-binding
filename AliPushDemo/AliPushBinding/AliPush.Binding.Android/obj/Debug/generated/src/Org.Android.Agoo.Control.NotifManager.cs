using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Control {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']"
	[global::Android.Runtime.Register ("org/android/agoo/control/NotifManager", DoNotGenerateAcw=true)]
	public partial class NotifManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/control/NotifManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotifManager); }
		}

		protected NotifManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/constructor[@name='NotifManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NotifManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NotifManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_doUninstall_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetDoUninstall_Ljava_lang_String_ZHandler ()
		{
			if (cb_doUninstall_Ljava_lang_String_Z == null)
				cb_doUninstall_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_DoUninstall_Ljava_lang_String_Z);
			return cb_doUninstall_Ljava_lang_String_Z;
		}

		static void n_DoUninstall_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Android.Agoo.Control.NotifManager __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoUninstall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doUninstall_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/method[@name='doUninstall' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("doUninstall", "(Ljava/lang/String;Z)V", "GetDoUninstall_Ljava_lang_String_ZHandler")]
		public virtual unsafe void DoUninstall (string p0, bool p1)
		{
			if (id_doUninstall_Ljava_lang_String_Z == IntPtr.Zero)
				id_doUninstall_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "doUninstall", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doUninstall_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doUninstall", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Control.NotifManager __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_PingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Agoo.Control.NotifManager __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PingApp (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/method[@name='pingApp' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("pingApp", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetPingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void PingApp (string p0, string p1, string p2, int p3)
		{
			if (id_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "pingApp", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pingApp_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pingApp", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Control.NotifManager __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportThirdPushToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/method[@name='reportThirdPushToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ReportThirdPushToken (string p0, string p1)
		{
			if (id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_ReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Org.Android.Agoo.Control.NotifManager __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Control.NotifManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportThirdPushToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.control']/class[@name='NotifManager']/method[@name='reportThirdPushToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetReportThirdPushToken_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void ReportThirdPushToken (string p0, string p1, bool p2)
		{
			if (id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportThirdPushToken_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportThirdPushToken", "(Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

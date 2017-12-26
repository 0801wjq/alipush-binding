using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Logger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.logger']/interface[@name='LoggerListener']"
	[Register ("com/alibaba/sdk/android/ams/common/logger/LoggerListener", "", "Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListenerInvoker")]
	public partial interface ILoggerListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.logger']/interface[@name='LoggerListener']/method[@name='d' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='int']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V", "GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler:Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListenerInvoker, AliPush.Binding.Android")]
		void D (string p0, string p1, global::Java.Lang.Throwable p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.logger']/interface[@name='LoggerListener']/method[@name='e' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='int']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V", "GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler:Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListenerInvoker, AliPush.Binding.Android")]
		void E (string p0, string p1, global::Java.Lang.Throwable p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.logger']/interface[@name='LoggerListener']/method[@name='i' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='int']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V", "GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler:Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListenerInvoker, AliPush.Binding.Android")]
		void I (string p0, string p1, global::Java.Lang.Throwable p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.logger']/interface[@name='LoggerListener']/method[@name='w' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='int']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V", "GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler:Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListenerInvoker, AliPush.Binding.Android")]
		void W (string p0, string p1, global::Java.Lang.Throwable p2, int p3);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/logger/LoggerListener", DoNotGenerateAcw=true)]
	internal class ILoggerListenerInvoker : global::Java.Lang.Object, ILoggerListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/logger/LoggerListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoggerListenerInvoker); }
		}

		IntPtr class_ref;

		public static ILoggerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.ams.common.logger.LoggerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I);
			return cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		public unsafe void D (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I);
			return cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		public unsafe void E (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I);
			return cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		public unsafe void I (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_IHandler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I);
			return cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Logger.ILoggerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I;
		public unsafe void W (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class DEventArgs : global::System.EventArgs {

		public DEventArgs (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	public partial class EEventArgs : global::System.EventArgs {

		public EEventArgs (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	public partial class IEventArgs : global::System.EventArgs {

		public IEventArgs (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	public partial class WEventArgs : global::System.EventArgs {

		public WEventArgs (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/alibaba/sdk/android/ams/common/logger/LoggerListenerImplementor")]
	internal sealed partial class ILoggerListenerImplementor : global::Java.Lang.Object, ILoggerListener {

		object sender;

		public ILoggerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/alibaba/sdk/android/ams/common/logger/LoggerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DEventArgs> DHandler;
#pragma warning restore 0649

		public void D (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			var __h = DHandler;
			if (__h != null)
				__h (sender, new DEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<EEventArgs> EHandler;
#pragma warning restore 0649

		public void E (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			var __h = EHandler;
			if (__h != null)
				__h (sender, new EEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<IEventArgs> IHandler;
#pragma warning restore 0649

		public void I (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			var __h = IHandler;
			if (__h != null)
				__h (sender, new IEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<WEventArgs> WHandler;
#pragma warning restore 0649

		public void W (string p0, string p1, global::Java.Lang.Throwable p2, int p3)
		{
			var __h = WHandler;
			if (__h != null)
				__h (sender, new WEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (ILoggerListenerImplementor value)
		{
			return value.DHandler == null && value.EHandler == null && value.IHandler == null && value.WHandler == null;
		}
	}

}

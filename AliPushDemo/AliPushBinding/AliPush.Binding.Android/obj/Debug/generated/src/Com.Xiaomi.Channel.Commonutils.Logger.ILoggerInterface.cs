using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Channel.Commonutils.Logger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.xiaomi.channel.commonutils.logger']/interface[@name='LoggerInterface']"
	[Register ("com/xiaomi/channel/commonutils/logger/LoggerInterface", "", "Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterfaceInvoker")]
	public partial interface ILoggerInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.channel.commonutils.logger']/interface[@name='LoggerInterface']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "GetLog_Ljava_lang_String_Handler:Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterfaceInvoker, AliPush.Binding.Android")]
		void Log (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.channel.commonutils.logger']/interface[@name='LoggerInterface']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterfaceInvoker, AliPush.Binding.Android")]
		void Log (string p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.channel.commonutils.logger']/interface[@name='LoggerInterface']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTag", "(Ljava/lang/String;)V", "GetSetTag_Ljava_lang_String_Handler:Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterfaceInvoker, AliPush.Binding.Android")]
		void SetTag (string p0);

	}

	[global::Android.Runtime.Register ("com/xiaomi/channel/commonutils/logger/LoggerInterface", DoNotGenerateAcw=true)]
	internal class ILoggerInterfaceInvoker : global::Java.Lang.Object, ILoggerInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/xiaomi/channel/commonutils/logger/LoggerInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoggerInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static ILoggerInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.xiaomi.channel.commonutils.logger.LoggerInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_lang_String_ == null)
				cb_log_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Log_Ljava_lang_String_);
			return cb_log_Ljava_lang_String_;
		}

		static void n_Log_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_String_;
		public unsafe void Log (string p0)
		{
			if (id_log_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_log_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_log_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Log_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_log_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Log_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Log (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_log_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_Handler ()
		{
			if (cb_setTag_Ljava_lang_String_ == null)
				cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_String_);
			return cb_setTag_Ljava_lang_String_;
		}

		static void n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTag (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTag_Ljava_lang_String_;
		public unsafe void SetTag (string p0)
		{
			if (id_setTag_Ljava_lang_String_ == IntPtr.Zero)
				id_setTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

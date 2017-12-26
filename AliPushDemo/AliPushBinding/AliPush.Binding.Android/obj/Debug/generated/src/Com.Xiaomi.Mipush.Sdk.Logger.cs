using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/Logger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logger); }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Logger)) {
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

		static IntPtr id_disablePushFileLog_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='Logger']/method[@name='disablePushFileLog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disablePushFileLog", "(Landroid/content/Context;)V", "")]
		public static unsafe void DisablePushFileLog (global::Android.Content.Context p0)
		{
			if (id_disablePushFileLog_Landroid_content_Context_ == IntPtr.Zero)
				id_disablePushFileLog_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "disablePushFileLog", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disablePushFileLog_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_enablePushFileLog_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='Logger']/method[@name='enablePushFileLog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("enablePushFileLog", "(Landroid/content/Context;)V", "")]
		public static unsafe void EnablePushFileLog (global::Android.Content.Context p0)
		{
			if (id_enablePushFileLog_Landroid_content_Context_ == IntPtr.Zero)
				id_enablePushFileLog_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "enablePushFileLog", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enablePushFileLog_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogger_Landroid_content_Context_Lcom_xiaomi_channel_commonutils_logger_LoggerInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='Logger']/method[@name='setLogger' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.xiaomi.channel.commonutils.logger.LoggerInterface']]"
		[Register ("setLogger", "(Landroid/content/Context;Lcom/xiaomi/channel/commonutils/logger/LoggerInterface;)V", "")]
		public static unsafe void SetLogger (global::Android.Content.Context p0, global::Com.Xiaomi.Channel.Commonutils.Logger.ILoggerInterface p1)
		{
			if (id_setLogger_Landroid_content_Context_Lcom_xiaomi_channel_commonutils_logger_LoggerInterface_ == IntPtr.Zero)
				id_setLogger_Landroid_content_Context_Lcom_xiaomi_channel_commonutils_logger_LoggerInterface_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Landroid/content/Context;Lcom/xiaomi/channel/commonutils/logger/LoggerInterface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Landroid_content_Context_Lcom_xiaomi_channel_commonutils_logger_LoggerInterface_, __args);
			} finally {
			}
		}

	}
}

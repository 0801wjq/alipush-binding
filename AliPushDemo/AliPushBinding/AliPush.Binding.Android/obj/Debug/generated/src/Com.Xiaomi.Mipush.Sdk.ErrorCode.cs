using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Xiaomi.Mipush.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/xiaomi/mipush/sdk/ErrorCode", DoNotGenerateAcw=true)]
	public partial class ErrorCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/field[@name='ERROR_AUTHERICATION_ERROR']"
		[Register ("ERROR_AUTHERICATION_ERROR")]
		public const int ErrorAuthericationError = (int) 70000002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/field[@name='ERROR_INTERNAL_ERROR']"
		[Register ("ERROR_INTERNAL_ERROR")]
		public const int ErrorInternalError = (int) 70000004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/field[@name='ERROR_INVALID_PAYLOAD']"
		[Register ("ERROR_INVALID_PAYLOAD")]
		public const int ErrorInvalidPayload = (int) 70000003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/field[@name='ERROR_SERVICE_UNAVAILABLE']"
		[Register ("ERROR_SERVICE_UNAVAILABLE")]
		public const int ErrorServiceUnavailable = (int) 70000001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/xiaomi/mipush/sdk/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		protected ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='ErrorCode']/constructor[@name='ErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ErrorCode)) {
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

	}
}

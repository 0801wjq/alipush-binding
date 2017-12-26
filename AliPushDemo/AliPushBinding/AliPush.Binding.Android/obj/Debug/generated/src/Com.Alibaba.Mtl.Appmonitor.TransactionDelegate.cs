using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='TransactionDelegate']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/TransactionDelegate", DoNotGenerateAcw=true)]
	public partial class TransactionDelegate : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/TransactionDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransactionDelegate); }
		}

		protected TransactionDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='TransactionDelegate']/constructor[@name='TransactionDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransactionDelegate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TransactionDelegate)) {
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

		static IntPtr id_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='TransactionDelegate']/method[@name='begin' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "")]
		public static unsafe void Begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction, string measureName)
		{
			if (id_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (transaction);
				__args [1] = new JValue (native_measureName);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
			}
		}

		static IntPtr id_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='TransactionDelegate']/method[@name='end' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "")]
		public static unsafe void End (global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction, string measureName)
		{
			if (id_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (transaction);
				__args [1] = new JValue (native_measureName);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
			}
		}

	}
}

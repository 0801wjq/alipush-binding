using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='ConfigMetric']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/ConfigMetric", DoNotGenerateAcw=true)]
	public partial class ConfigMetric : global::Com.Alibaba.Mtl.Appmonitor.Model.Metric {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/ConfigMetric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigMetric); }
		}

		protected ConfigMetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='ConfigMetric']/constructor[@name='ConfigMetric' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "")]
		public unsafe ConfigMetric (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measureSet)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measureSet);
				if (((object) this).GetType () != typeof (ConfigMetric)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/MetricRepo", DoNotGenerateAcw=true)]
	public partial class MetricRepo : global::Java.Lang.Object {


		static IntPtr metrics_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/field[@name='metrics']"
		[Register ("metrics")]
		public global::System.Collections.IList Metrics {
			get {
				if (metrics_jfieldId == IntPtr.Zero)
					metrics_jfieldId = JNIEnv.GetFieldID (class_ref, "metrics", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, metrics_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (metrics_jfieldId == IntPtr.Zero)
					metrics_jfieldId = JNIEnv.GetFieldID (class_ref, "metrics", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, metrics_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/MetricRepo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetricRepo); }
		}

		protected MetricRepo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getRepo;
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo Repo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/method[@name='getRepo' and count(parameter)=0]"
			[Register ("getRepo", "()Lcom/alibaba/mtl/appmonitor/model/MetricRepo;", "GetGetRepoHandler")]
			get {
				if (id_getRepo == IntPtr.Zero)
					id_getRepo = JNIEnv.GetStaticMethodID (class_ref, "getRepo", "()Lcom/alibaba/mtl/appmonitor/model/MetricRepo;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRepo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_alibaba_mtl_appmonitor_model_Metric_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_alibaba_mtl_appmonitor_model_Metric_Handler ()
		{
			if (cb_add_Lcom_alibaba_mtl_appmonitor_model_Metric_ == null)
				cb_add_Lcom_alibaba_mtl_appmonitor_model_Metric_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_alibaba_mtl_appmonitor_model_Metric_);
			return cb_add_Lcom_alibaba_mtl_appmonitor_model_Metric_;
		}

		static void n_Add_Lcom_alibaba_mtl_appmonitor_model_Metric_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metric)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric metric = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (native_metric, JniHandleOwnership.DoNotTransfer);
			__this.Add (metric);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_alibaba_mtl_appmonitor_model_Metric_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.Metric']]"
		[Register ("add", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)V", "GetAdd_Lcom_alibaba_mtl_appmonitor_model_Metric_Handler")]
		public virtual unsafe void Add (global::Com.Alibaba.Mtl.Appmonitor.Model.Metric metric)
		{
			if (id_add_Lcom_alibaba_mtl_appmonitor_model_Metric_ == IntPtr.Zero)
				id_add_Lcom_alibaba_mtl_appmonitor_model_Metric_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (metric);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_alibaba_mtl_appmonitor_model_Metric_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getMetric_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMetric_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMetric_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMetric_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMetric_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMetric_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMetric_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMetric (module, monitorPoint));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMetric_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/method[@name='getMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMetric", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Metric;", "GetGetMetric_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.Metric GetMetric (string module, string monitorPoint)
		{
			if (id_getMetric_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetric_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMetric", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Metric;");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetric_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetric", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Metric;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_getRepo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/method[@name='getRepo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRepo", "(I)Lcom/alibaba/mtl/appmonitor/model/MetricRepo;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo GetRepo (int capacity)
		{
			if (id_getRepo_I == IntPtr.Zero)
				id_getRepo_I = JNIEnv.GetStaticMethodID (class_ref, "getRepo", "(I)Lcom/alibaba/mtl/appmonitor/model/MetricRepo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRepo_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_alibaba_mtl_appmonitor_model_Metric_Handler ()
		{
			if (cb_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_ == null)
				cb_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Lcom_alibaba_mtl_appmonitor_model_Metric_);
			return cb_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_;
		}

		static bool n_Remove_Lcom_alibaba_mtl_appmonitor_model_Metric_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metric)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric metric = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (native_metric, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (metric);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricRepo']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.Metric']]"
		[Register ("remove", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)Z", "GetRemove_Lcom_alibaba_mtl_appmonitor_model_Metric_Handler")]
		public virtual unsafe bool Remove (global::Com.Alibaba.Mtl.Appmonitor.Model.Metric metric)
		{
			if (id_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_ == IntPtr.Zero)
				id_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (metric);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_alibaba_mtl_appmonitor_model_Metric_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/alibaba/mtl/appmonitor/model/Metric;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

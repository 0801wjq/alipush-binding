using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitorStatTable']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitorStatTable", DoNotGenerateAcw=true)]
	public partial class AppMonitorStatTable : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitorStatTable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppMonitorStatTable); }
		}

		protected AppMonitorStatTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitorStatTable']/constructor[@name='AppMonitorStatTable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AppMonitorStatTable (string module, string monitorPoint)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				if (((object) this).GetType () != typeof (AppMonitorStatTable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
#pragma warning disable 0169
		static Delegate GetRegisterRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler ()
		{
			if (cb_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == null)
				cb_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_RegisterRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z);
			return cb_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		}

		static IntPtr n_RegisterRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_rows, IntPtr native_columns, bool isDetail)
		{
			global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet rows = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_rows, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet columns = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_columns, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterRowAndColumn (rows, columns, isDetail));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitorStatTable']/method[@name='registerRowAndColumn' and count(parameter)=3 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[2][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[3][@type='boolean']]"
		[Register ("registerRowAndColumn", "(Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;", "GetRegisterRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable RegisterRowAndColumn (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet rows, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet columns, bool isDetail)
		{
			if (id_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == IntPtr.Zero)
				id_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNIEnv.GetMethodID (class_ref, "registerRowAndColumn", "(Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (rows);
				__args [1] = new JValue (columns);
				__args [2] = new JValue (isDetail);

				global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerRowAndColumn_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerRowAndColumn", "(Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler ()
		{
			if (cb_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == null)
				cb_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_);
			return cb_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		}

		static IntPtr n_Update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rowValues, IntPtr native_columnValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet rowValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_rowValues, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet columnValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_columnValues, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Update (rowValues, columnValues));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitorStatTable']/method[@name='update' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[2][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
		[Register ("update", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;", "GetUpdate_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable Update (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet rowValues, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet columnValues)
		{
			if (id_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
				id_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (rowValues);
				__args [1] = new JValue (columnValues);

				global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.AppMonitorStatTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Lcom/alibaba/mtl/appmonitor/AppMonitorStatTable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

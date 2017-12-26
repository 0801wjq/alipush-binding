using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/Metric", DoNotGenerateAcw=true)]
	public partial class Metric : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/Metric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metric); }
		}

		protected Metric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/constructor[@name='Metric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Metric ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Metric)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/constructor[@name='Metric' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "")]
		public unsafe Metric (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measureSet, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensionSet, bool isCommitDetail)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measureSet);
				__args [3] = new JValue (dimensionSet);
				__args [4] = new JValue (isCommitDetail);
				if (((object) this).GetType () != typeof (Metric)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_getDimensionSet;
#pragma warning disable 0169
		static Delegate GetGetDimensionSetHandler ()
		{
			if (cb_getDimensionSet == null)
				cb_getDimensionSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDimensionSet);
			return cb_getDimensionSet;
		}

		static IntPtr n_GetDimensionSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DimensionSet);
		}
#pragma warning restore 0169

		static IntPtr id_getDimensionSet;
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet DimensionSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='getDimensionSet' and count(parameter)=0]"
			[Register ("getDimensionSet", "()Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "GetGetDimensionSetHandler")]
			get {
				if (id_getDimensionSet == IntPtr.Zero)
					id_getDimensionSet = JNIEnv.GetMethodID (class_ref, "getDimensionSet", "()Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDimensionSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensionSet", "()Lcom/alibaba/mtl/appmonitor/model/DimensionSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCommitDetail;
#pragma warning disable 0169
		static Delegate GetIsCommitDetailHandler ()
		{
			if (cb_isCommitDetail == null)
				cb_isCommitDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCommitDetail);
			return cb_isCommitDetail;
		}

		static bool n_IsCommitDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCommitDetail;
		}
#pragma warning restore 0169

		static IntPtr id_isCommitDetail;
		public virtual unsafe bool IsCommitDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='isCommitDetail' and count(parameter)=0]"
			[Register ("isCommitDetail", "()Z", "GetIsCommitDetailHandler")]
			get {
				if (id_isCommitDetail == IntPtr.Zero)
					id_isCommitDetail = JNIEnv.GetMethodID (class_ref, "isCommitDetail", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCommitDetail);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCommitDetail", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMeasureSet;
#pragma warning disable 0169
		static Delegate GetGetMeasureSetHandler ()
		{
			if (cb_getMeasureSet == null)
				cb_getMeasureSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeasureSet);
			return cb_getMeasureSet;
		}

		static IntPtr n_GetMeasureSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeasureSet);
		}
#pragma warning restore 0169

		static IntPtr id_getMeasureSet;
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet MeasureSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='getMeasureSet' and count(parameter)=0]"
			[Register ("getMeasureSet", "()Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "GetGetMeasureSetHandler")]
			get {
				if (id_getMeasureSet == IntPtr.Zero)
					id_getMeasureSet = JNIEnv.GetMethodID (class_ref, "getMeasureSet", "()Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasureSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeasureSet", "()Lcom/alibaba/mtl/appmonitor/model/MeasureSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModule;
#pragma warning disable 0169
		static Delegate GetGetModuleHandler ()
		{
			if (cb_getModule == null)
				cb_getModule = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModule);
			return cb_getModule;
		}

		static IntPtr n_GetModule (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Module);
		}
#pragma warning restore 0169

		static IntPtr id_getModule;
		public virtual unsafe string Module {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='getModule' and count(parameter)=0]"
			[Register ("getModule", "()Ljava/lang/String;", "GetGetModuleHandler")]
			get {
				if (id_getModule == IntPtr.Zero)
					id_getModule = JNIEnv.GetMethodID (class_ref, "getModule", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModule), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModule", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMonitorPoint;
#pragma warning disable 0169
		static Delegate GetGetMonitorPointHandler ()
		{
			if (cb_getMonitorPoint == null)
				cb_getMonitorPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMonitorPoint);
			return cb_getMonitorPoint;
		}

		static IntPtr n_GetMonitorPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MonitorPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getMonitorPoint;
		public virtual unsafe string MonitorPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='getMonitorPoint' and count(parameter)=0]"
			[Register ("getMonitorPoint", "()Ljava/lang/String;", "GetGetMonitorPointHandler")]
			get {
				if (id_getMonitorPoint == IntPtr.Zero)
					id_getMonitorPoint = JNIEnv.GetMethodID (class_ref, "getMonitorPoint", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitorPoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonitorPoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clean;
#pragma warning disable 0169
		static Delegate GetCleanHandler ()
		{
			if (cb_clean == null)
				cb_clean = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clean);
			return cb_clean;
		}

		static void n_Clean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clean ();
		}
#pragma warning restore 0169

		static IntPtr id_clean;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='clean' and count(parameter)=0]"
		[Register ("clean", "()V", "GetCleanHandler")]
		public virtual unsafe void Clean ()
		{
			if (id_clean == IntPtr.Zero)
				id_clean = JNIEnv.GetMethodID (class_ref, "clean", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clean);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clean", "()V"));
			} finally {
			}
		}

		static Delegate cb_fill_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFill_arrayLjava_lang_Object_Handler ()
		{
			if (cb_fill_arrayLjava_lang_Object_ == null)
				cb_fill_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fill_arrayLjava_lang_Object_);
			return cb_fill_arrayLjava_lang_Object_;
		}

		static void n_Fill_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] @params = (global::Java.Lang.Object[]) JNIEnv.GetArray (native__params, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fill (@params);
			if (@params != null)
				JNIEnv.CopyArray (@params, native__params);
		}
#pragma warning restore 0169

		static IntPtr id_fill_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("fill", "([Ljava/lang/Object;)V", "GetFill_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Fill (params global:: Java.Lang.Object[] @params)
		{
			if (id_fill_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_fill_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "fill", "([Ljava/lang/Object;)V");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fill_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fill", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		static Delegate cb_resetTransactionId;
#pragma warning disable 0169
		static Delegate GetResetTransactionIdHandler ()
		{
			if (cb_resetTransactionId == null)
				cb_resetTransactionId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetTransactionId);
			return cb_resetTransactionId;
		}

		static void n_ResetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetTransactionId ();
		}
#pragma warning restore 0169

		static IntPtr id_resetTransactionId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='resetTransactionId' and count(parameter)=0]"
		[Register ("resetTransactionId", "()V", "GetResetTransactionIdHandler")]
		public virtual unsafe void ResetTransactionId ()
		{
			if (id_resetTransactionId == IntPtr.Zero)
				id_resetTransactionId = JNIEnv.GetMethodID (class_ref, "resetTransactionId", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetTransactionId);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetTransactionId", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCommitDetailFromConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCommitDetailFromConfig_Ljava_lang_String_Handler ()
		{
			if (cb_setCommitDetailFromConfig_Ljava_lang_String_ == null)
				cb_setCommitDetailFromConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommitDetailFromConfig_Ljava_lang_String_);
			return cb_setCommitDetailFromConfig_Ljava_lang_String_;
		}

		static void n_SetCommitDetailFromConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isCommitDetailFromConfig)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string isCommitDetailFromConfig = JNIEnv.GetString (native_isCommitDetailFromConfig, JniHandleOwnership.DoNotTransfer);
			__this.SetCommitDetailFromConfig (isCommitDetailFromConfig);
		}
#pragma warning restore 0169

		static IntPtr id_setCommitDetailFromConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='setCommitDetailFromConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCommitDetailFromConfig", "(Ljava/lang/String;)V", "GetSetCommitDetailFromConfig_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCommitDetailFromConfig (string isCommitDetailFromConfig)
		{
			if (id_setCommitDetailFromConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_setCommitDetailFromConfig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCommitDetailFromConfig", "(Ljava/lang/String;)V");
			IntPtr native_isCommitDetailFromConfig = JNIEnv.NewString (isCommitDetailFromConfig);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_isCommitDetailFromConfig);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCommitDetailFromConfig_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommitDetailFromConfig", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_isCommitDetailFromConfig);
			}
		}

		static Delegate cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
#pragma warning disable 0169
		static Delegate GetValid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler ()
		{
			if (cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == null)
				cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_);
			return cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		}

		static bool n_Valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionValues, IntPtr native_measureValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Metric __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_measureValues, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Valid (dimensionValues, measureValues);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Metric']/method[@name='valid' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[2][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
		[Register ("valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z", "GetValid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler")]
		public virtual unsafe bool Valid (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues)
		{
			if (id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
				id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetMethodID (class_ref, "valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dimensionValues);
				__args [1] = new JValue (measureValues);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

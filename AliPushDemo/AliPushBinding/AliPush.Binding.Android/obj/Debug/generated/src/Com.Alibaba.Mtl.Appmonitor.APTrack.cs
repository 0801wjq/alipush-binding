using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/APTrack", DoNotGenerateAcw=true)]
	public partial class APTrack : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/APTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (APTrack); }
		}

		protected APTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/constructor[@name='APTrack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe APTrack (string appkey)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_appkey = JNIEnv.NewString (appkey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appkey);
				if (((object) this).GetType () != typeof (APTrack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appkey);
			}
		}

		static Delegate cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
#pragma warning disable 0169
		static Delegate GetCommit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler ()
		{
			if (cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == null)
				cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_);
			return cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		}

		static void n_Commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_dimensionValues, IntPtr native_measureValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_measureValues, JniHandleOwnership.DoNotTransfer);
			__this.Commit (module, monitorPoint, dimensionValues, measureValues);
		}
#pragma warning restore 0169

		static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
		[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V", "GetCommit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler")]
		public virtual unsafe void Commit (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues)
		{
			if (id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
				id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (dimensionValues);
				__args [3] = new JValue (measureValues);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D;
#pragma warning disable 0169
		static Delegate GetCommit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DHandler ()
		{
			if (cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D == null)
				cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D);
			return cb_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D;
		}

		static void n_Commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_dimensionValues, double value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			__this.Commit (module, monitorPoint, dimensionValues, value);
		}
#pragma warning restore 0169

		static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double']]"
		[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;D)V", "GetCommit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DHandler")]
		public virtual unsafe void Commit (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, double value)
		{
			if (id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D == IntPtr.Zero)
				id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D = JNIEnv.GetMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;D)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (dimensionValues);
				__args [3] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_commit_Ljava_lang_String_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetCommit_Ljava_lang_String_Ljava_lang_String_DHandler ()
		{
			if (cb_commit_Ljava_lang_String_Ljava_lang_String_D == null)
				cb_commit_Ljava_lang_String_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Commit_Ljava_lang_String_Ljava_lang_String_D);
			return cb_commit_Ljava_lang_String_Ljava_lang_String_D;
		}

		static void n_Commit_Ljava_lang_String_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, double value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			__this.Commit (module, monitorPoint, value);
		}
#pragma warning restore 0169

		static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "GetCommit_Ljava_lang_String_Ljava_lang_String_DHandler")]
		public virtual unsafe void Commit (string module, string monitorPoint, double value)
		{
			if (id_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
				id_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "(Ljava/lang/String;Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetCommit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DHandler ()
		{
			if (cb_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D == null)
				cb_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D);
			return cb_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D;
		}

		static void n_Commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg, double value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Commit (module, monitorPoint, arg, value);
		}
#pragma warning restore 0169

		static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double']]"
		[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)V", "GetCommit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DHandler")]
		public virtual unsafe void Commit (string module, string monitorPoint, string arg, double value)
		{
			if (id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
				id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);
				__args [3] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
			}
		}

		static Delegate cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_errorCode, IntPtr native_errorMsg)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			string errorMsg = JNIEnv.GetString (native_errorMsg, JniHandleOwnership.DoNotTransfer);
			__this.CommitFail (module, monitorPoint, errorCode, errorMsg);
		}
#pragma warning restore 0169

		static IntPtr id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commitFail' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CommitFail (string module, string monitorPoint, string errorCode, string errorMsg)
		{
			if (id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_errorCode);
				__args [3] = new JValue (native_errorMsg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMsg);
			}
		}

		static Delegate cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg, IntPtr native_errorCode, IntPtr native_errorMsg)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			string errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			string errorMsg = JNIEnv.GetString (native_errorMsg, JniHandleOwnership.DoNotTransfer);
			__this.CommitFail (module, monitorPoint, arg, errorCode, errorMsg);
		}
#pragma warning restore 0169

		static IntPtr id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commitFail' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCommitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CommitFail (string module, string monitorPoint, string arg, string errorCode, string errorMsg)
		{
			if (id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);
				__args [3] = new JValue (native_errorCode);
				__args [4] = new JValue (native_errorMsg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMsg);
			}
		}

		static Delegate cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitSuccess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitSuccess_Ljava_lang_String_Ljava_lang_String_);
			return cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CommitSuccess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			__this.CommitSuccess (module, monitorPoint);
		}
#pragma warning restore 0169

		static IntPtr id_commitSuccess_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commitSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("commitSuccess", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCommitSuccess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CommitSuccess (string module, string monitorPoint)
		{
			if (id_commitSuccess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitSuccess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitSuccess_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CommitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg)
		{
			global::Com.Alibaba.Mtl.Appmonitor.APTrack __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.CommitSuccess (module, monitorPoint, arg);
		}
#pragma warning restore 0169

		static IntPtr id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='APTrack']/method[@name='commitSuccess' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("commitSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCommitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CommitSuccess (string module, string monitorPoint, string arg)
		{
			if (id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
			}
		}

	}
}

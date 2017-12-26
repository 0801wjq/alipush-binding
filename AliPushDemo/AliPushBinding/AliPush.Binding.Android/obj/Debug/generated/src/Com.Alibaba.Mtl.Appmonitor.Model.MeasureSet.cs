using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/MeasureSet", DoNotGenerateAcw=true)]
	public partial class MeasureSet : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/MeasureSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MeasureSet); }
		}

		protected MeasureSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMeasures;
#pragma warning disable 0169
		static Delegate GetGetMeasuresHandler ()
		{
			if (cb_getMeasures == null)
				cb_getMeasures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeasures);
			return cb_getMeasures;
		}

		static IntPtr n_GetMeasures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure>.ToLocalJniHandle (__this.Measures);
		}
#pragma warning restore 0169

		static IntPtr id_getMeasures;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> Measures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='getMeasures' and count(parameter)=0]"
			[Register ("getMeasures", "()Ljava/util/List;", "GetGetMeasuresHandler")]
			get {
				if (id_getMeasures == IntPtr.Zero)
					id_getMeasures = JNIEnv.GetMethodID (class_ref, "getMeasures", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasures), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeasures", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
#pragma warning disable 0169
		static Delegate GetAddMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_Handler ()
		{
			if (cb_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ == null)
				cb_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_);
			return cb_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
		}

		static IntPtr n_AddMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measure)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure measure = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (native_measure, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMeasure (measure));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='addMeasure' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.Measure']]"
		[Register ("addMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "GetAddMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet AddMeasure (global::Com.Alibaba.Mtl.Appmonitor.Model.Measure measure)
		{
			if (id_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ == IntPtr.Zero)
				id_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ = JNIEnv.GetMethodID (class_ref, "addMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (measure);

				global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addMeasure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMeasure_Ljava_lang_String_Handler ()
		{
			if (cb_addMeasure_Ljava_lang_String_ == null)
				cb_addMeasure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMeasure_Ljava_lang_String_);
			return cb_addMeasure_Ljava_lang_String_;
		}

		static IntPtr n_AddMeasure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMeasure (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMeasure_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='addMeasure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "GetAddMeasure_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet AddMeasure (string name)
		{
			if (id_addMeasure_Ljava_lang_String_ == IntPtr.Zero)
				id_addMeasure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMeasure_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("create", "([Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet Create (string[] measures)
		{
			if (id_create_arrayLjava_lang_String_ == IntPtr.Zero)
				id_create_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "([Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
			IntPtr native_measures = JNIEnv.NewArray (measures);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_measures);
				global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (measures != null) {
					JNIEnv.CopyArray (native_measures, measures);
					JNIEnv.DeleteLocalRef (native_measures);
				}
			}
		}

		static IntPtr id_create_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("create", "(Ljava/util/Collection;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet Create (global::System.Collections.Generic.ICollection<string> measures)
		{
			if (id_create_Ljava_util_Collection_ == IntPtr.Zero)
				id_create_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/Collection;)Lcom/alibaba/mtl/appmonitor/model/MeasureSet;");
			IntPtr native_measures = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (measures);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_measures);
				global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_measures);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getMeasure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMeasure_Ljava_lang_String_Handler ()
		{
			if (cb_getMeasure_Ljava_lang_String_ == null)
				cb_getMeasure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMeasure_Ljava_lang_String_);
			return cb_getMeasure_Ljava_lang_String_;
		}

		static IntPtr n_GetMeasure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMeasure (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMeasure_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='getMeasure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Measure;", "GetGetMeasure_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.Measure GetMeasure (string name)
		{
			if (id_getMeasure_Ljava_lang_String_ == IntPtr.Zero)
				id_getMeasure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Measure;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasure_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeasure", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Measure;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
#pragma warning disable 0169
		static Delegate GetSetConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler ()
		{
			if (cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == null)
				cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_);
			return cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		}

		static void n_SetConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measureValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_measureValues, JniHandleOwnership.DoNotTransfer);
			__this.SetConstantValue (measureValues);
		}
#pragma warning restore 0169

		static IntPtr id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='setConstantValue' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
		[Register ("setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V", "GetSetConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler")]
		public virtual unsafe void SetConstantValue (global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues)
		{
			if (id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
				id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetMethodID (class_ref, "setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (measureValues);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
#pragma warning disable 0169
		static Delegate GetUpateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_Handler ()
		{
			if (cb_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ == null)
				cb_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_);
			return cb_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
		}

		static void n_UpateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newMeasure)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure newMeasure = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (native_newMeasure, JniHandleOwnership.DoNotTransfer);
			__this.UpateMeasure (newMeasure);
		}
#pragma warning restore 0169

		static IntPtr id_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='upateMeasure' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.Measure']]"
		[Register ("upateMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)V", "GetUpateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_Handler")]
		public virtual unsafe void UpateMeasure (global::Com.Alibaba.Mtl.Appmonitor.Model.Measure newMeasure)
		{
			if (id_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ == IntPtr.Zero)
				id_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_ = JNIEnv.GetMethodID (class_ref, "upateMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (newMeasure);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upateMeasure_Lcom_alibaba_mtl_appmonitor_model_Measure_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "upateMeasure", "(Lcom/alibaba/mtl/appmonitor/model/Measure;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_upateMeasures_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetUpateMeasures_Ljava_util_List_Handler ()
		{
			if (cb_upateMeasures_Ljava_util_List_ == null)
				cb_upateMeasures_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpateMeasures_Ljava_util_List_);
			return cb_upateMeasures_Ljava_util_List_;
		}

		static void n_UpateMeasures_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configMeasures)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var configMeasures = global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure>.FromJniHandle (native_configMeasures, JniHandleOwnership.DoNotTransfer);
			__this.UpateMeasures (configMeasures);
		}
#pragma warning restore 0169

		static IntPtr id_upateMeasures_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='upateMeasures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.alibaba.mtl.appmonitor.model.Measure&gt;']]"
		[Register ("upateMeasures", "(Ljava/util/List;)V", "GetUpateMeasures_Ljava_util_List_Handler")]
		public virtual unsafe void UpateMeasures (global::System.Collections.Generic.IList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> configMeasures)
		{
			if (id_upateMeasures_Ljava_util_List_ == IntPtr.Zero)
				id_upateMeasures_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "upateMeasures", "(Ljava/util/List;)V");
			IntPtr native_configMeasures = global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure>.ToLocalJniHandle (configMeasures);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_configMeasures);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upateMeasures_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "upateMeasures", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_configMeasures);
			}
		}

		static Delegate cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
#pragma warning disable 0169
		static Delegate GetValid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler ()
		{
			if (cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == null)
				cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_);
			return cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		}

		static bool n_Valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measureValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_measureValues, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Valid (measureValues);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='valid' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
		[Register ("valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z", "GetValid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Handler")]
		public virtual unsafe bool Valid (global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues)
		{
			if (id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
				id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetMethodID (class_ref, "valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (measureValues);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureSet']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}

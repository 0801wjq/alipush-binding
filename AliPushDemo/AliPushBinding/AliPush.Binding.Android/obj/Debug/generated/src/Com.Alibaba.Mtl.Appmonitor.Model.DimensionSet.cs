using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/DimensionSet", DoNotGenerateAcw=true)]
	public partial class DimensionSet : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/DimensionSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DimensionSet); }
		}

		protected DimensionSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDimensions);
			return cb_getDimensions;
		}

		static IntPtr n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension>.ToLocalJniHandle (__this.Dimensions);
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension> Dimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='getDimensions' and count(parameter)=0]"
			[Register ("getDimensions", "()Ljava/util/List;", "GetGetDimensionsHandler")]
			get {
				if (id_getDimensions == IntPtr.Zero)
					id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDimensions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_;
#pragma warning disable 0169
		static Delegate GetAddDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_Handler ()
		{
			if (cb_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_ == null)
				cb_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_);
			return cb_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_;
		}

		static IntPtr n_AddDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimension)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension dimension = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension> (native_dimension, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimension (dimension));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='addDimension' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.Dimension']]"
		[Register ("addDimension", "(Lcom/alibaba/mtl/appmonitor/model/Dimension;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "GetAddDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet AddDimension (global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension dimension)
		{
			if (id_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_ == IntPtr.Zero)
				id_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_ = JNIEnv.GetMethodID (class_ref, "addDimension", "(Lcom/alibaba/mtl/appmonitor/model/Dimension;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dimension);

				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDimension_Lcom_alibaba_mtl_appmonitor_model_Dimension_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDimension", "(Lcom/alibaba/mtl/appmonitor/model/Dimension;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addDimension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDimension_Ljava_lang_String_Handler ()
		{
			if (cb_addDimension_Ljava_lang_String_ == null)
				cb_addDimension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimension_Ljava_lang_String_);
			return cb_addDimension_Ljava_lang_String_;
		}

		static IntPtr n_AddDimension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimension (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='addDimension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "GetAddDimension_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet AddDimension (string name)
		{
			if (id_addDimension_Ljava_lang_String_ == IntPtr.Zero)
				id_addDimension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDimension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addDimension_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDimension_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDimension_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addDimension_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimension_Ljava_lang_String_Ljava_lang_String_);
			return cb_addDimension_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddDimension_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_constantValue)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string constantValue = JNIEnv.GetString (native_constantValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimension (name, constantValue));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimension_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='addDimension' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addDimension", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "GetAddDimension_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet AddDimension (string name, string constantValue)
		{
			if (id_addDimension_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDimension_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDimension", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_constantValue = JNIEnv.NewString (constantValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_constantValue);

				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDimension_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDimension", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_constantValue);
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("create", "([Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet Create (string[] dimensions)
		{
			if (id_create_arrayLjava_lang_String_ == IntPtr.Zero)
				id_create_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "([Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			IntPtr native_dimensions = JNIEnv.NewArray (dimensions);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dimensions);
				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (dimensions != null) {
					JNIEnv.CopyArray (native_dimensions, dimensions);
					JNIEnv.DeleteLocalRef (native_dimensions);
				}
			}
		}

		static IntPtr id_create_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("create", "(Ljava/util/Collection;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet Create (global::System.Collections.Generic.ICollection<string> dimensions)
		{
			if (id_create_Ljava_util_Collection_ == IntPtr.Zero)
				id_create_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/Collection;)Lcom/alibaba/mtl/appmonitor/model/DimensionSet;");
			IntPtr native_dimensions = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (dimensions);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dimensions);
				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dimensions);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getDimension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDimension_Ljava_lang_String_Handler ()
		{
			if (cb_getDimension_Ljava_lang_String_ == null)
				cb_getDimension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDimension_Ljava_lang_String_);
			return cb_getDimension_Ljava_lang_String_;
		}

		static IntPtr n_GetDimension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDimension (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDimension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Dimension;", "GetGetDimension_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension GetDimension (string name)
		{
			if (id_getDimension_Ljava_lang_String_ == IntPtr.Zero)
				id_getDimension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Dimension;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDimension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Dimension> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimension", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/Dimension;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
#pragma warning disable 0169
		static Delegate GetSetConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler ()
		{
			if (cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == null)
				cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_);
			return cb_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		}

		static void n_SetConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			__this.SetConstantValue (dimensionValues);
		}
#pragma warning restore 0169

		static IntPtr id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='setConstantValue' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet']]"
		[Register ("setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V", "GetSetConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler")]
		public virtual unsafe void SetConstantValue (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues)
		{
			if (id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == IntPtr.Zero)
				id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNIEnv.GetMethodID (class_ref, "setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dimensionValues);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConstantValue_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConstantValue", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
#pragma warning disable 0169
		static Delegate GetValid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler ()
		{
			if (cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == null)
				cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_);
			return cb_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		}

		static bool n_Valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Valid (dimensionValues);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='valid' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet']]"
		[Register ("valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Z", "GetValid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler")]
		public virtual unsafe bool Valid (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues)
		{
			if (id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == IntPtr.Zero)
				id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNIEnv.GetMethodID (class_ref, "valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dimensionValues);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_valid_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "valid", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Z"), __args);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionSet']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

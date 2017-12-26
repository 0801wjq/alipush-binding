using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/Transaction", DoNotGenerateAcw=true)]
	public partial class Transaction : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='a']"
		[Register ("a")]
		protected global::Java.Lang.Integer A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='b']"
		[Register ("b")]
		protected global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='e']"
		[Register ("e")]
		protected global::System.Collections.IDictionary E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='o']"
		[Register ("o")]
		protected string O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, o_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, o_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='p']"
		[Register ("p")]
		protected string P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, p_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetFieldID (class_ref, "p", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/field[@name='r']"
		[Register ("r")]
		protected string R {
			get {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, r_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, r_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/Transaction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Transaction); }
		}

		protected Transaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/constructor[@name='Transaction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Transaction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Transaction)) {
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

		static Delegate cb_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
#pragma warning disable 0169
		static Delegate GetAddDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler ()
		{
			if (cb_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == null)
				cb_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_);
			return cb_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		}

		static void n_AddDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			__this.AddDimensionValues (dimensionValues);
		}
#pragma warning restore 0169

		static IntPtr id_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='addDimensionValues' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet']]"
		[Register ("addDimensionValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V", "GetAddDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler")]
		public virtual unsafe void AddDimensionValues (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues)
		{
			if (id_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == IntPtr.Zero)
				id_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNIEnv.GetMethodID (class_ref, "addDimensionValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dimensionValues);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDimensionValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDimensionValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addDimensionValues_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDimensionValues_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDimensionValues_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addDimensionValues_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimensionValues_Ljava_lang_String_Ljava_lang_String_);
			return cb_addDimensionValues_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddDimensionValues_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionName, IntPtr native_dimensionValue)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string dimensionName = JNIEnv.GetString (native_dimensionName, JniHandleOwnership.DoNotTransfer);
			string dimensionValue = JNIEnv.GetString (native_dimensionValue, JniHandleOwnership.DoNotTransfer);
			__this.AddDimensionValues (dimensionName, dimensionValue);
		}
#pragma warning restore 0169

		static IntPtr id_addDimensionValues_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='addDimensionValues' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addDimensionValues", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddDimensionValues_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddDimensionValues (string dimensionName, string dimensionValue)
		{
			if (id_addDimensionValues_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDimensionValues_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDimensionValues", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_dimensionName = JNIEnv.NewString (dimensionName);
			IntPtr native_dimensionValue = JNIEnv.NewString (dimensionValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dimensionName);
				__args [1] = new JValue (native_dimensionValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDimensionValues_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDimensionValues", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dimensionName);
				JNIEnv.DeleteLocalRef (native_dimensionValue);
			}
		}

		static Delegate cb_begin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBegin_Ljava_lang_String_Handler ()
		{
			if (cb_begin_Ljava_lang_String_ == null)
				cb_begin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Begin_Ljava_lang_String_);
			return cb_begin_Ljava_lang_String_;
		}

		static void n_Begin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.Begin (measureName);
		}
#pragma warning restore 0169

		static IntPtr id_begin_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='begin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("begin", "(Ljava/lang/String;)V", "GetBegin_Ljava_lang_String_Handler")]
		public virtual unsafe void Begin (string measureName)
		{
			if (id_begin_Ljava_lang_String_ == IntPtr.Zero)
				id_begin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "begin", "(Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_begin_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "begin", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
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
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_end_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnd_Ljava_lang_String_Handler ()
		{
			if (cb_end_Ljava_lang_String_ == null)
				cb_end_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_End_Ljava_lang_String_);
			return cb_end_Ljava_lang_String_;
		}

		static void n_End_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.End (measureName);
		}
#pragma warning restore 0169

		static IntPtr id_end_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='end' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("end", "(Ljava/lang/String;)V", "GetEnd_Ljava_lang_String_Handler")]
		public virtual unsafe void End (string measureName)
		{
			if (id_end_Ljava_lang_String_ == IntPtr.Zero)
				id_end_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "end", "(Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_end_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "end", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
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
			global::Com.Alibaba.Mtl.Appmonitor.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Transaction']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

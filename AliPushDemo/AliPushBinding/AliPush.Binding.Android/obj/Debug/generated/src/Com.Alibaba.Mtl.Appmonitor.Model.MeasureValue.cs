using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/MeasureValue", DoNotGenerateAcw=true)]
	public partial class MeasureValue : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/MeasureValue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MeasureValue); }
		}

		protected MeasureValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/constructor[@name='MeasureValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MeasureValue ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MeasureValue)) {
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

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/constructor[@name='MeasureValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe MeasureValue (double value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MeasureValue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/constructor[@name='MeasureValue' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe MeasureValue (double value, double offset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (offset);
				if (((object) this).GetType () != typeof (MeasureValue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

		static Delegate cb_isFinish;
#pragma warning disable 0169
		static Delegate GetIsFinishHandler ()
		{
			if (cb_isFinish == null)
				cb_isFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFinish);
			return cb_isFinish;
		}

		static bool n_IsFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Finish;
		}
#pragma warning restore 0169

		static Delegate cb_setFinish_Z;
#pragma warning disable 0169
		static Delegate GetSetFinish_ZHandler ()
		{
			if (cb_setFinish_Z == null)
				cb_setFinish_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFinish_Z);
			return cb_setFinish_Z;
		}

		static void n_SetFinish_Z (IntPtr jnienv, IntPtr native__this, bool finish)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish = finish;
		}
#pragma warning restore 0169

		static IntPtr id_isFinish;
		static IntPtr id_setFinish_Z;
		public virtual unsafe bool Finish {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='isFinish' and count(parameter)=0]"
			[Register ("isFinish", "()Z", "GetIsFinishHandler")]
			get {
				if (id_isFinish == IntPtr.Zero)
					id_isFinish = JNIEnv.GetMethodID (class_ref, "isFinish", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFinish);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFinish", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='setFinish' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFinish", "(Z)V", "GetSetFinish_ZHandler")]
			set {
				if (id_setFinish_Z == IntPtr.Zero)
					id_setFinish_Z = JNIEnv.GetMethodID (class_ref, "setFinish", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFinish_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFinish", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		public virtual unsafe global::Java.Lang.Double Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Ljava/lang/Double;", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetValue);
			return cb_getValue;
		}

		static double n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static Delegate cb_setValue_D;
#pragma warning disable 0169
		static Delegate GetSetValue_DHandler ()
		{
			if (cb_setValue_D == null)
				cb_setValue_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetValue_D);
			return cb_setValue_D;
		}

		static void n_SetValue_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Value = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_D;
		public virtual unsafe double Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()D", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setValue", "(D)V", "GetSetValue_DHandler")]
			set {
				if (id_setValue_D == IntPtr.Zero)
					id_setValue_D = JNIEnv.GetMethodID (class_ref, "setValue", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(D)V"), __args);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clean ();
		}
#pragma warning restore 0169

		static IntPtr id_clean;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='clean' and count(parameter)=0]"
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

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/alibaba/mtl/appmonitor/model/MeasureValue;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/alibaba/mtl/appmonitor/model/MeasureValue;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("create", "(D)Lcom/alibaba/mtl/appmonitor/model/MeasureValue;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue Create (double value)
		{
			if (id_create_D == IntPtr.Zero)
				id_create_D = JNIEnv.GetStaticMethodID (class_ref, "create", "(D)Lcom/alibaba/mtl/appmonitor/model/MeasureValue;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='create' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("create", "(DD)Lcom/alibaba/mtl/appmonitor/model/MeasureValue;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue Create (double value, double offset)
		{
			if (id_create_DD == IntPtr.Zero)
				id_create_DD = JNIEnv.GetStaticMethodID (class_ref, "create", "(DD)Lcom/alibaba/mtl/appmonitor/model/MeasureValue;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (value);
				__args [1] = new JValue (offset);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_DD, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] @params = (global::Java.Lang.Object[]) JNIEnv.GetArray (native__params, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fill (@params);
			if (@params != null)
				JNIEnv.CopyArray (@params, native__params);
		}
#pragma warning restore 0169

		static IntPtr id_fill_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
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

		static Delegate cb_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
#pragma warning disable 0169
		static Delegate GetMerge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_Handler ()
		{
			if (cb_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ == null)
				cb_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_);
			return cb_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
		}

		static void n_Merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue t = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Merge (t);
		}
#pragma warning restore 0169

		static IntPtr id_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.MeasureValue']]"
		[Register ("merge", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)V", "GetMerge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_Handler")]
		public virtual unsafe void Merge (global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue t)
		{
			if (id_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ == IntPtr.Zero)
				id_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_merge_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "merge", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOffset_D;
#pragma warning disable 0169
		static Delegate GetSetOffset_DHandler ()
		{
			if (cb_setOffset_D == null)
				cb_setOffset_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetOffset_D);
			return cb_setOffset_D;
		}

		static void n_SetOffset_D (IntPtr jnienv, IntPtr native__this, double offset)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffset (offset);
		}
#pragma warning restore 0169

		static IntPtr id_setOffset_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setOffset", "(D)V", "GetSetOffset_DHandler")]
		public virtual unsafe void SetOffset (double offset)
		{
			if (id_setOffset_D == IntPtr.Zero)
				id_setOffset_D = JNIEnv.GetMethodID (class_ref, "setOffset", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffset_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(D)V"), __args);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MeasureValue']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

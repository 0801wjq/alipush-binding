using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/Measure", DoNotGenerateAcw=true)]
	public partial class Measure : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/field[@name='a']"
		[Register ("a")]
		protected global::Java.Lang.Double A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Double;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/field[@name='b']"
		[Register ("b")]
		protected global::Java.Lang.Double B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/Double;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/field[@name='c']"
		[Register ("c")]
		protected global::Java.Lang.Double C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/Double;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/Measure", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Measure); }
		}

		protected Measure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/constructor[@name='Measure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Measure (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				if (((object) this).GetType () != typeof (Measure)) {
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
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Double_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/constructor[@name='Measure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Double;)V", "")]
		public unsafe Measure (string name, global::Java.Lang.Double constantValue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (constantValue);
				if (((object) this).GetType () != typeof (Measure)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Double;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Double;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Double_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Double;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Double_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Double_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_Double_Ljava_lang_Double_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/constructor[@name='Measure' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double'] and parameter[3][@type='java.lang.Double'] and parameter[4][@type='java.lang.Double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;)V", "")]
		public unsafe Measure (string name, global::Java.Lang.Double constantValue, global::Java.Lang.Double min, global::Java.Lang.Double max)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (constantValue);
				__args [2] = new JValue (min);
				__args [3] = new JValue (max);
				if (((object) this).GetType () != typeof (Measure)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_Double_Ljava_lang_Double_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_Double_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_Double_Ljava_lang_Double_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_Double_Ljava_lang_Double_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getConstantValue;
#pragma warning disable 0169
		static Delegate GetGetConstantValueHandler ()
		{
			if (cb_getConstantValue == null)
				cb_getConstantValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstantValue);
			return cb_getConstantValue;
		}

		static IntPtr n_GetConstantValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConstantValue);
		}
#pragma warning restore 0169

		static Delegate cb_setConstantValue_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetConstantValue_Ljava_lang_Double_Handler ()
		{
			if (cb_setConstantValue_Ljava_lang_Double_ == null)
				cb_setConstantValue_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConstantValue_Ljava_lang_Double_);
			return cb_setConstantValue_Ljava_lang_Double_;
		}

		static void n_SetConstantValue_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_constantValue)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double constantValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_constantValue, JniHandleOwnership.DoNotTransfer);
			__this.ConstantValue = constantValue;
		}
#pragma warning restore 0169

		static IntPtr id_getConstantValue;
		static IntPtr id_setConstantValue_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ConstantValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='getConstantValue' and count(parameter)=0]"
			[Register ("getConstantValue", "()Ljava/lang/Double;", "GetGetConstantValueHandler")]
			get {
				if (id_getConstantValue == IntPtr.Zero)
					id_getConstantValue = JNIEnv.GetMethodID (class_ref, "getConstantValue", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConstantValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConstantValue", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='setConstantValue' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setConstantValue", "(Ljava/lang/Double;)V", "GetSetConstantValue_Ljava_lang_Double_Handler")]
			set {
				if (id_setConstantValue_Ljava_lang_Double_ == IntPtr.Zero)
					id_setConstantValue_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setConstantValue", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConstantValue_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConstantValue", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax;
#pragma warning disable 0169
		static Delegate GetGetMaxHandler ()
		{
			if (cb_getMax == null)
				cb_getMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMax);
			return cb_getMax;
		}

		static IntPtr n_GetMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Max);
		}
#pragma warning restore 0169

		static Delegate cb_setMax_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetMax_Ljava_lang_Double_Handler ()
		{
			if (cb_setMax_Ljava_lang_Double_ == null)
				cb_setMax_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMax_Ljava_lang_Double_);
			return cb_setMax_Ljava_lang_Double_;
		}

		static void n_SetMax_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_max)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double max = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_max, JniHandleOwnership.DoNotTransfer);
			__this.Max = max;
		}
#pragma warning restore 0169

		static IntPtr id_getMax;
		static IntPtr id_setMax_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Max {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='getMax' and count(parameter)=0]"
			[Register ("getMax", "()Ljava/lang/Double;", "GetGetMaxHandler")]
			get {
				if (id_getMax == IntPtr.Zero)
					id_getMax = JNIEnv.GetMethodID (class_ref, "getMax", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMax), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMax", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='setMax' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setMax", "(Ljava/lang/Double;)V", "GetSetMax_Ljava_lang_Double_Handler")]
			set {
				if (id_setMax_Ljava_lang_Double_ == IntPtr.Zero)
					id_setMax_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setMax", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMax_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMax", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_getMin == null)
				cb_getMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMin);
			return cb_getMin;
		}

		static IntPtr n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Min);
		}
#pragma warning restore 0169

		static Delegate cb_setMin_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetMin_Ljava_lang_Double_Handler ()
		{
			if (cb_setMin_Ljava_lang_Double_ == null)
				cb_setMin_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMin_Ljava_lang_Double_);
			return cb_setMin_Ljava_lang_Double_;
		}

		static void n_SetMin_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_min)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double min = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_min, JniHandleOwnership.DoNotTransfer);
			__this.Min = min;
		}
#pragma warning restore 0169

		static IntPtr id_getMin;
		static IntPtr id_setMin_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Min {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='getMin' and count(parameter)=0]"
			[Register ("getMin", "()Ljava/lang/Double;", "GetGetMinHandler")]
			get {
				if (id_getMin == IntPtr.Zero)
					id_getMin = JNIEnv.GetMethodID (class_ref, "getMin", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMin), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMin", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='setMin' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setMin", "(Ljava/lang/Double;)V", "GetSetMin_Ljava_lang_Double_Handler")]
			set {
				if (id_setMin_Ljava_lang_Double_ == IntPtr.Zero)
					id_setMin_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setMin", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMin_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMin", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_setRange_Ljava_lang_Double_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetRange_Ljava_lang_Double_Ljava_lang_Double_Handler ()
		{
			if (cb_setRange_Ljava_lang_Double_Ljava_lang_Double_ == null)
				cb_setRange_Ljava_lang_Double_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRange_Ljava_lang_Double_Ljava_lang_Double_);
			return cb_setRange_Ljava_lang_Double_Ljava_lang_Double_;
		}

		static void n_SetRange_Ljava_lang_Double_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_min, IntPtr native_max)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double min = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_min, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double max = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_max, JniHandleOwnership.DoNotTransfer);
			__this.SetRange (min, max);
		}
#pragma warning restore 0169

		static IntPtr id_setRange_Ljava_lang_Double_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='setRange' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='java.lang.Double']]"
		[Register ("setRange", "(Ljava/lang/Double;Ljava/lang/Double;)V", "GetSetRange_Ljava_lang_Double_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetRange (global::Java.Lang.Double min, global::Java.Lang.Double max)
		{
			if (id_setRange_Ljava_lang_Double_Ljava_lang_Double_ == IntPtr.Zero)
				id_setRange_Ljava_lang_Double_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setRange", "(Ljava/lang/Double;Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (min);
				__args [1] = new JValue (max);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRange_Ljava_lang_Double_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRange", "(Ljava/lang/Double;Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
#pragma warning disable 0169
		static Delegate GetValid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_Handler ()
		{
			if (cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ == null)
				cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_);
			return cb_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
		}

		static bool n_Valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_measureValue)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue measureValue = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue> (native_measureValue, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Valid (measureValue);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='valid' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.MeasureValue']]"
		[Register ("valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)Z", "GetValid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_Handler")]
		public virtual unsafe bool Valid (global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValue measureValue)
		{
			if (id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ == IntPtr.Zero)
				id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_ = JNIEnv.GetMethodID (class_ref, "valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (measureValue);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_valid_Lcom_alibaba_mtl_appmonitor_model_MeasureValue_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "valid", "(Lcom/alibaba/mtl/appmonitor/model/MeasureValue;)Z"), __args);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.Measure __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.Measure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='Measure']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

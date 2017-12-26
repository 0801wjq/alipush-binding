using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/DimensionValueSet", DoNotGenerateAcw=true)]
	public partial class DimensionValueSet : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/DimensionValueSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DimensionValueSet); }
		}

		protected DimensionValueSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/constructor[@name='DimensionValueSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DimensionValueSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DimensionValueSet)) {
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

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		static Delegate cb_setMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMap_Ljava_util_Map_Handler ()
		{
			if (cb_setMap_Ljava_util_Map_ == null)
				cb_setMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMap_Ljava_util_Map_);
			return cb_setMap_Ljava_util_Map_;
		}

		static void n_SetMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_map)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var map = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_map, JniHandleOwnership.DoNotTransfer);
			__this.Map = map;
		}
#pragma warning restore 0169

		static IntPtr id_getMap;
		static IntPtr id_setMap_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Ljava/util/Map;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='setMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMap", "(Ljava/util/Map;)V", "GetSetMap_Ljava_util_Map_Handler")]
			set {
				if (id_setMap_Ljava_util_Map_ == IntPtr.Zero)
					id_setMap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMap", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMap_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMap", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
#pragma warning disable 0169
		static Delegate GetAddValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler ()
		{
			if (cb_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == null)
				cb_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_);
			return cb_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		}

		static IntPtr n_AddValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dimensionValues)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddValues (dimensionValues));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='addValues' and count(parameter)=1 and parameter[1][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet']]"
		[Register ("addValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;", "GetAddValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet AddValues (global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues)
		{
			if (id_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == IntPtr.Zero)
				id_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNIEnv.GetMethodID (class_ref, "addValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dimensionValues);

				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addValues_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addValues", "(Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clean ();
		}
#pragma warning restore 0169

		static IntPtr id_clean;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='clean' and count(parameter)=0]"
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

		static Delegate cb_containValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainValue_Ljava_lang_String_Handler ()
		{
			if (cb_containValue_Ljava_lang_String_ == null)
				cb_containValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainValue_Ljava_lang_String_);
			return cb_containValue_Ljava_lang_String_;
		}

		static bool n_ContainValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainValue (name);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='containValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containValue", "(Ljava/lang/String;)Z", "GetContainValue_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainValue (string name)
		{
			if (id_containValue_Ljava_lang_String_ == IntPtr.Zero)
				id_containValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containValue", "(Ljava/lang/String;)Z");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containValue_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containValue", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("create", "(I)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet Create (int initialCapacity)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initialCapacity);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] @params = (global::Java.Lang.Object[]) JNIEnv.GetArray (native__params, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fill (@params);
			if (@params != null)
				JNIEnv.CopyArray (@params, native__params);
		}
#pragma warning restore 0169

		static IntPtr id_fill_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
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

		static IntPtr id_fromStringMap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='fromStringMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("fromStringMap", "(Ljava/util/Map;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet FromStringMap (global::System.Collections.Generic.IDictionary<string, string> values)
		{
			if (id_fromStringMap_Ljava_util_Map_ == IntPtr.Zero)
				id_fromStringMap_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "fromStringMap", "(Ljava/util/Map;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromStringMap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_getValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetValue_Ljava_lang_String_Handler ()
		{
			if (cb_getValue_Ljava_lang_String_ == null)
				cb_getValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValue_Ljava_lang_String_);
			return cb_getValue_Ljava_lang_String_;
		}

		static IntPtr n_GetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetValue (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetValue (string name)
		{
			if (id_getValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setValue_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetValue_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValue (name, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setValue", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;", "GetSetValue_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet SetValue (string name, string value)
		{
			if (id_setValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_value);

				global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='DimensionValueSet']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

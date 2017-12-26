using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricValueSet']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/MetricValueSet", DoNotGenerateAcw=true)]
	public partial class MetricValueSet : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/MetricValueSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetricValueSet); }
		}

		protected MetricValueSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricValueSet']/constructor[@name='MetricValueSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MetricValueSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MetricValueSet)) {
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MetricValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clean ();
		}
#pragma warning restore 0169

		static IntPtr id_clean;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricValueSet']/method[@name='clean' and count(parameter)=0]"
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
			global::Com.Alibaba.Mtl.Appmonitor.Model.MetricValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MetricValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] @params = (global::Java.Lang.Object[]) JNIEnv.GetArray (native__params, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fill (@params);
			if (@params != null)
				JNIEnv.CopyArray (@params, native__params);
		}
#pragma warning restore 0169

		static IntPtr id_fill_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='MetricValueSet']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
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

	}
}

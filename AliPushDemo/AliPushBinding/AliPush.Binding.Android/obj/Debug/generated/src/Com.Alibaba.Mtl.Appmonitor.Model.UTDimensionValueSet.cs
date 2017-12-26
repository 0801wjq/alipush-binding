using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='UTDimensionValueSet']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/model/UTDimensionValueSet", DoNotGenerateAcw=true)]
	public partial class UTDimensionValueSet : global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/model/UTDimensionValueSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTDimensionValueSet); }
		}

		protected UTDimensionValueSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='UTDimensionValueSet']/constructor[@name='UTDimensionValueSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTDimensionValueSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTDimensionValueSet)) {
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

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Model.UTDimensionValueSet __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.UTDimensionValueSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe global::Java.Lang.Integer EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='UTDimensionValueSet']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/Integer;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor.model']/class[@name='UTDimensionValueSet']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("create", "(Ljava/util/Map;)Lcom/alibaba/mtl/appmonitor/model/UTDimensionValueSet;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Model.UTDimensionValueSet Create (global::System.Collections.Generic.IDictionary<string, string> rawMsg)
		{
			if (id_create_Ljava_util_Map_ == IntPtr.Zero)
				id_create_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/Map;)Lcom/alibaba/mtl/appmonitor/model/UTDimensionValueSet;");
			IntPtr native_rawMsg = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (rawMsg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_rawMsg);
				global::Com.Alibaba.Mtl.Appmonitor.Model.UTDimensionValueSet __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.UTDimensionValueSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_rawMsg);
			}
		}

	}
}

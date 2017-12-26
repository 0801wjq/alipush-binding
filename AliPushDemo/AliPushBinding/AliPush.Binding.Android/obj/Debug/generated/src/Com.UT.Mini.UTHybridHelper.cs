using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHybridHelper']"
	[global::Android.Runtime.Register ("com/ut/mini/UTHybridHelper", DoNotGenerateAcw=true)]
	public partial class UTHybridHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTHybridHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTHybridHelper); }
		}

		protected UTHybridHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHybridHelper']/constructor[@name='UTHybridHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTHybridHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTHybridHelper)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.UTHybridHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHybridHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/UTHybridHelper;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/UTHybridHelper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHybridHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_h5UT_Ljava_util_Map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetH5UT_Ljava_util_Map_Ljava_lang_Object_Handler ()
		{
			if (cb_h5UT_Ljava_util_Map_Ljava_lang_Object_ == null)
				cb_h5UT_Ljava_util_Map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_H5UT_Ljava_util_Map_Ljava_lang_Object_);
			return cb_h5UT_Ljava_util_Map_Ljava_lang_Object_;
		}

		static void n_H5UT_Ljava_util_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataMap, IntPtr native_view)
		{
			global::Com.UT.Mini.UTHybridHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHybridHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_dataMap, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object view = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.H5UT (dataMap, view);
		}
#pragma warning restore 0169

		static IntPtr id_h5UT_Ljava_util_Map_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHybridHelper']/method[@name='h5UT' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("h5UT", "(Ljava/util/Map;Ljava/lang/Object;)V", "GetH5UT_Ljava_util_Map_Ljava_lang_Object_Handler")]
		public virtual unsafe void H5UT (global::System.Collections.Generic.IDictionary<string, string> dataMap, global::Java.Lang.Object view)
		{
			if (id_h5UT_Ljava_util_Map_Ljava_lang_Object_ == IntPtr.Zero)
				id_h5UT_Ljava_util_Map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "h5UT", "(Ljava/util/Map;Ljava/lang/Object;)V");
			IntPtr native_dataMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (dataMap);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dataMap);
				__args [1] = new JValue (view);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_h5UT_Ljava_util_Map_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h5UT", "(Ljava/util/Map;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dataMap);
			}
		}

		static Delegate cb_setH5Url_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetH5Url_Ljava_lang_String_Handler ()
		{
			if (cb_setH5Url_Ljava_lang_String_ == null)
				cb_setH5Url_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetH5Url_Ljava_lang_String_);
			return cb_setH5Url_Ljava_lang_String_;
		}

		static void n_SetH5Url_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.UT.Mini.UTHybridHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHybridHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetH5Url (url);
		}
#pragma warning restore 0169

		static IntPtr id_setH5Url_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHybridHelper']/method[@name='setH5Url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setH5Url", "(Ljava/lang/String;)V", "GetSetH5Url_Ljava_lang_String_Handler")]
		public virtual unsafe void SetH5Url (string url)
		{
			if (id_setH5Url_Ljava_lang_String_ == IntPtr.Zero)
				id_setH5Url_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setH5Url", "(Ljava/lang/String;)V");
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setH5Url_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH5Url", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

	}
}

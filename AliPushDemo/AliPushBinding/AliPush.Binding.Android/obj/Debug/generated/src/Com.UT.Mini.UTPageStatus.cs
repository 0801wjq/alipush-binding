using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageStatus']"
	[global::Android.Runtime.Register ("com/ut/mini/UTPageStatus", DoNotGenerateAcw=true)]
	public sealed partial class UTPageStatus : global::Java.Lang.Enum {


		static IntPtr UT_H5_IN_WebView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageStatus']/field[@name='UT_H5_IN_WebView']"
		[Register ("UT_H5_IN_WebView")]
		public static global::Com.UT.Mini.UTPageStatus UTH5INWebView {
			get {
				if (UT_H5_IN_WebView_jfieldId == IntPtr.Zero)
					UT_H5_IN_WebView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UT_H5_IN_WebView", "Lcom/ut/mini/UTPageStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UT_H5_IN_WebView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTPageStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPageStatus); }
		}

		internal UTPageStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/ut/mini/UTPageStatus;", "")]
		public static unsafe global::Com.UT.Mini.UTPageStatus ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ut/mini/UTPageStatus;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.UT.Mini.UTPageStatus __ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/ut/mini/UTPageStatus;", "")]
		public static unsafe global::Com.UT.Mini.UTPageStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ut/mini/UTPageStatus;");
			try {
				return (global::Com.UT.Mini.UTPageStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.UT.Mini.UTPageStatus));
			} finally {
			}
		}

	}
}

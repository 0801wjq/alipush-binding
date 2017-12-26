using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTOriginalCustomHitBuilder']"
	[global::Android.Runtime.Register ("com/ut/mini/internal/UTOriginalCustomHitBuilder", DoNotGenerateAcw=true)]
	public partial class UTOriginalCustomHitBuilder : global::Com.UT.Mini.UTHitBuilders.UTHitBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/internal/UTOriginalCustomHitBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTOriginalCustomHitBuilder); }
		}

		protected UTOriginalCustomHitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTOriginalCustomHitBuilder']/constructor[@name='UTOriginalCustomHitBuilder' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe UTOriginalCustomHitBuilder (string aPage, int aEventId, string aArg1, string aArg2, string aArg3, global::System.Collections.Generic.IDictionary<string, string> aHitMap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aPage = JNIEnv.NewString (aPage);
			IntPtr native_aArg1 = JNIEnv.NewString (aArg1);
			IntPtr native_aArg2 = JNIEnv.NewString (aArg2);
			IntPtr native_aArg3 = JNIEnv.NewString (aArg3);
			IntPtr native_aHitMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aHitMap);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_aPage);
				__args [1] = new JValue (aEventId);
				__args [2] = new JValue (native_aArg1);
				__args [3] = new JValue (native_aArg2);
				__args [4] = new JValue (native_aArg3);
				__args [5] = new JValue (native_aHitMap);
				if (((object) this).GetType () != typeof (UTOriginalCustomHitBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aPage);
				JNIEnv.DeleteLocalRef (native_aArg1);
				JNIEnv.DeleteLocalRef (native_aArg2);
				JNIEnv.DeleteLocalRef (native_aArg3);
				JNIEnv.DeleteLocalRef (native_aHitMap);
			}
		}

	}
}

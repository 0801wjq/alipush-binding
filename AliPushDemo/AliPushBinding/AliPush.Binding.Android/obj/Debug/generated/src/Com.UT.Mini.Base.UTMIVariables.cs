using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']"
	[global::Android.Runtime.Register ("com/ut/mini/base/UTMIVariables", DoNotGenerateAcw=true)]
	public partial class UTMIVariables : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/base/UTMIVariables", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTMIVariables); }
		}

		protected UTMIVariables (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/constructor[@name='UTMIVariables' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTMIVariables ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTMIVariables)) {
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

		static Delegate cb_getH5RefPage;
#pragma warning disable 0169
		static Delegate GetGetH5RefPageHandler ()
		{
			if (cb_getH5RefPage == null)
				cb_getH5RefPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetH5RefPage);
			return cb_getH5RefPage;
		}

		static IntPtr n_GetH5RefPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H5RefPage);
		}
#pragma warning restore 0169

		static Delegate cb_setH5RefPage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetH5RefPage_Ljava_lang_String_Handler ()
		{
			if (cb_setH5RefPage_Ljava_lang_String_ == null)
				cb_setH5RefPage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetH5RefPage_Ljava_lang_String_);
			return cb_setH5RefPage_Ljava_lang_String_;
		}

		static void n_SetH5RefPage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aH5PrePage)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aH5PrePage = JNIEnv.GetString (native_aH5PrePage, JniHandleOwnership.DoNotTransfer);
			__this.H5RefPage = aH5PrePage;
		}
#pragma warning restore 0169

		static IntPtr id_getH5RefPage;
		static IntPtr id_setH5RefPage_Ljava_lang_String_;
		public virtual unsafe string H5RefPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='getH5RefPage' and count(parameter)=0]"
			[Register ("getH5RefPage", "()Ljava/lang/String;", "GetGetH5RefPageHandler")]
			get {
				if (id_getH5RefPage == IntPtr.Zero)
					id_getH5RefPage = JNIEnv.GetMethodID (class_ref, "getH5RefPage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getH5RefPage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getH5RefPage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='setH5RefPage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setH5RefPage", "(Ljava/lang/String;)V", "GetSetH5RefPage_Ljava_lang_String_Handler")]
			set {
				if (id_setH5RefPage_Ljava_lang_String_ == IntPtr.Zero)
					id_setH5RefPage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setH5RefPage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setH5RefPage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH5RefPage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getH5Url;
#pragma warning disable 0169
		static Delegate GetGetH5UrlHandler ()
		{
			if (cb_getH5Url == null)
				cb_getH5Url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetH5Url);
			return cb_getH5Url;
		}

		static IntPtr n_GetH5Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H5Url);
		}
#pragma warning restore 0169

		static Delegate cb_setH5Url_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetH5Url_Ljava_lang_String_Handler ()
		{
			if (cb_setH5Url_Ljava_lang_String_ == null)
				cb_setH5Url_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetH5Url_Ljava_lang_String_);
			return cb_setH5Url_Ljava_lang_String_;
		}

		static void n_SetH5Url_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aH5Url)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aH5Url = JNIEnv.GetString (native_aH5Url, JniHandleOwnership.DoNotTransfer);
			__this.H5Url = aH5Url;
		}
#pragma warning restore 0169

		static IntPtr id_getH5Url;
		static IntPtr id_setH5Url_Ljava_lang_String_;
		public virtual unsafe string H5Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='getH5Url' and count(parameter)=0]"
			[Register ("getH5Url", "()Ljava/lang/String;", "GetGetH5UrlHandler")]
			get {
				if (id_getH5Url == IntPtr.Zero)
					id_getH5Url = JNIEnv.GetMethodID (class_ref, "getH5Url", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getH5Url), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getH5Url", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='setH5Url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setH5Url", "(Ljava/lang/String;)V", "GetSetH5Url_Ljava_lang_String_Handler")]
			set {
				if (id_setH5Url_Ljava_lang_String_ == IntPtr.Zero)
					id_setH5Url_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setH5Url", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setH5Url_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH5Url", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.Base.UTMIVariables Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/base/UTMIVariables;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/base/UTMIVariables;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAliyunOSPlatform;
#pragma warning disable 0169
		static Delegate GetIsAliyunOSPlatformHandler ()
		{
			if (cb_isAliyunOSPlatform == null)
				cb_isAliyunOSPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAliyunOSPlatform);
			return cb_isAliyunOSPlatform;
		}

		static bool n_IsAliyunOSPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAliyunOSPlatform;
		}
#pragma warning restore 0169

		static IntPtr id_isAliyunOSPlatform;
		public virtual unsafe bool IsAliyunOSPlatform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='isAliyunOSPlatform' and count(parameter)=0]"
			[Register ("isAliyunOSPlatform", "()Z", "GetIsAliyunOSPlatformHandler")]
			get {
				if (id_isAliyunOSPlatform == IntPtr.Zero)
					id_isAliyunOSPlatform = JNIEnv.GetMethodID (class_ref, "isAliyunOSPlatform", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAliyunOSPlatform);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAliyunOSPlatform", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRefPage;
#pragma warning disable 0169
		static Delegate GetGetRefPageHandler ()
		{
			if (cb_getRefPage == null)
				cb_getRefPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefPage);
			return cb_getRefPage;
		}

		static IntPtr n_GetRefPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefPage);
		}
#pragma warning restore 0169

		static Delegate cb_setRefPage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefPage_Ljava_lang_String_Handler ()
		{
			if (cb_setRefPage_Ljava_lang_String_ == null)
				cb_setRefPage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefPage_Ljava_lang_String_);
			return cb_setRefPage_Ljava_lang_String_;
		}

		static void n_SetRefPage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aRefPage)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aRefPage = JNIEnv.GetString (native_aRefPage, JniHandleOwnership.DoNotTransfer);
			__this.RefPage = aRefPage;
		}
#pragma warning restore 0169

		static IntPtr id_getRefPage;
		static IntPtr id_setRefPage_Ljava_lang_String_;
		public virtual unsafe string RefPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='getRefPage' and count(parameter)=0]"
			[Register ("getRefPage", "()Ljava/lang/String;", "GetGetRefPageHandler")]
			get {
				if (id_getRefPage == IntPtr.Zero)
					id_getRefPage = JNIEnv.GetMethodID (class_ref, "getRefPage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefPage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefPage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='setRefPage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefPage", "(Ljava/lang/String;)V", "GetSetRefPage_Ljava_lang_String_Handler")]
			set {
				if (id_setRefPage_Ljava_lang_String_ == IntPtr.Zero)
					id_setRefPage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRefPage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefPage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefPage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUTMI1010_2001EventInstance;
#pragma warning disable 0169
		static Delegate GetGetUTMI1010_2001EventInstanceHandler ()
		{
			if (cb_getUTMI1010_2001EventInstance == null)
				cb_getUTMI1010_2001EventInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTMI1010_2001EventInstance);
			return cb_getUTMI1010_2001EventInstance;
		}

		static IntPtr n_GetUTMI1010_2001EventInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UTMI1010_2001EventInstance);
		}
#pragma warning restore 0169

		static Delegate cb_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_;
#pragma warning disable 0169
		static Delegate GetSetUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_Handler ()
		{
			if (cb_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_ == null)
				cb_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_);
			return cb_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_;
		}

		static void n_SetUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aInstance)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.Sdkevents.UTMI1010_2001Event aInstance = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Sdkevents.UTMI1010_2001Event> (native_aInstance, JniHandleOwnership.DoNotTransfer);
			__this.UTMI1010_2001EventInstance = aInstance;
		}
#pragma warning restore 0169

		static IntPtr id_getUTMI1010_2001EventInstance;
		static IntPtr id_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_;
		public virtual unsafe global::Com.UT.Mini.Sdkevents.UTMI1010_2001Event UTMI1010_2001EventInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='getUTMI1010_2001EventInstance' and count(parameter)=0]"
			[Register ("getUTMI1010_2001EventInstance", "()Lcom/ut/mini/sdkevents/UTMI1010_2001Event;", "GetGetUTMI1010_2001EventInstanceHandler")]
			get {
				if (id_getUTMI1010_2001EventInstance == IntPtr.Zero)
					id_getUTMI1010_2001EventInstance = JNIEnv.GetMethodID (class_ref, "getUTMI1010_2001EventInstance", "()Lcom/ut/mini/sdkevents/UTMI1010_2001Event;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Sdkevents.UTMI1010_2001Event> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTMI1010_2001EventInstance), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Sdkevents.UTMI1010_2001Event> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUTMI1010_2001EventInstance", "()Lcom/ut/mini/sdkevents/UTMI1010_2001Event;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='setUTMI1010_2001EventInstance' and count(parameter)=1 and parameter[1][@type='com.ut.mini.sdkevents.UTMI1010_2001Event']]"
			[Register ("setUTMI1010_2001EventInstance", "(Lcom/ut/mini/sdkevents/UTMI1010_2001Event;)V", "GetSetUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_Handler")]
			set {
				if (id_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_ == IntPtr.Zero)
					id_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_ = JNIEnv.GetMethodID (class_ref, "setUTMI1010_2001EventInstance", "(Lcom/ut/mini/sdkevents/UTMI1010_2001Event;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUTMI1010_2001EventInstance_Lcom_ut_mini_sdkevents_UTMI1010_2001Event_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUTMI1010_2001EventInstance", "(Lcom/ut/mini/sdkevents/UTMI1010_2001Event;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setToAliyunOSPlatform;
#pragma warning disable 0169
		static Delegate GetSetToAliyunOSPlatformHandler ()
		{
			if (cb_setToAliyunOSPlatform == null)
				cb_setToAliyunOSPlatform = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetToAliyunOSPlatform);
			return cb_setToAliyunOSPlatform;
		}

		static void n_SetToAliyunOSPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Base.UTMIVariables __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Base.UTMIVariables> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetToAliyunOSPlatform ();
		}
#pragma warning restore 0169

		static IntPtr id_setToAliyunOSPlatform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.base']/class[@name='UTMIVariables']/method[@name='setToAliyunOSPlatform' and count(parameter)=0]"
		[Register ("setToAliyunOSPlatform", "()V", "GetSetToAliyunOSPlatformHandler")]
		public virtual unsafe void SetToAliyunOSPlatform ()
		{
			if (id_setToAliyunOSPlatform == IntPtr.Zero)
				id_setToAliyunOSPlatform = JNIEnv.GetMethodID (class_ref, "setToAliyunOSPlatform", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToAliyunOSPlatform);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToAliyunOSPlatform", "()V"));
			} finally {
			}
		}

	}
}

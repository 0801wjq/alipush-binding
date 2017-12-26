using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']"
	[global::Android.Runtime.Register ("com/ut/mini/UTPageHitHelper", DoNotGenerateAcw=true)]
	public partial class UTPageHitHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']"
		[global::Android.Runtime.Register ("com/ut/mini/UTPageHitHelper$UTPageEventObject", DoNotGenerateAcw=true)]
		public partial class UTPageEventObject : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ut/mini/UTPageHitHelper$UTPageEventObject", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UTPageEventObject); }
			}

			protected UTPageEventObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/constructor[@name='UTPageHitHelper.UTPageEventObject' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UTPageEventObject ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (UTPageEventObject)) {
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

			static Delegate cb_getCacheKey;
#pragma warning disable 0169
			static Delegate GetGetCacheKeyHandler ()
			{
				if (cb_getCacheKey == null)
					cb_getCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheKey);
				return cb_getCacheKey;
			}

			static IntPtr n_GetCacheKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CacheKey);
			}
#pragma warning restore 0169

			static Delegate cb_setCacheKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCacheKey_Ljava_lang_String_Handler ()
			{
				if (cb_setCacheKey_Ljava_lang_String_ == null)
					cb_setCacheKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCacheKey_Ljava_lang_String_);
				return cb_setCacheKey_Ljava_lang_String_;
			}

			static void n_SetCacheKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aCacheKey)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aCacheKey = JNIEnv.GetString (native_aCacheKey, JniHandleOwnership.DoNotTransfer);
				__this.CacheKey = aCacheKey;
			}
#pragma warning restore 0169

			static IntPtr id_getCacheKey;
			static IntPtr id_setCacheKey_Ljava_lang_String_;
			public virtual unsafe string CacheKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getCacheKey' and count(parameter)=0]"
				[Register ("getCacheKey", "()Ljava/lang/String;", "GetGetCacheKeyHandler")]
				get {
					if (id_getCacheKey == IntPtr.Zero)
						id_getCacheKey = JNIEnv.GetMethodID (class_ref, "getCacheKey", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheKey), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setCacheKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCacheKey", "(Ljava/lang/String;)V", "GetSetCacheKey_Ljava_lang_String_Handler")]
				set {
					if (id_setCacheKey_Ljava_lang_String_ == IntPtr.Zero)
						id_setCacheKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCacheKey", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCacheKey_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCacheKey", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_isH5Called;
#pragma warning disable 0169
			static Delegate GetIsH5CalledHandler ()
			{
				if (cb_isH5Called == null)
					cb_isH5Called = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsH5Called);
				return cb_isH5Called;
			}

			static bool n_IsH5Called (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsH5Called;
			}
#pragma warning restore 0169

			static IntPtr id_isH5Called;
			public virtual unsafe bool IsH5Called {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='isH5Called' and count(parameter)=0]"
				[Register ("isH5Called", "()Z", "GetIsH5CalledHandler")]
				get {
					if (id_isH5Called == IntPtr.Zero)
						id_isH5Called = JNIEnv.GetMethodID (class_ref, "isH5Called", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isH5Called);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isH5Called", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isPageAppearCalled;
#pragma warning disable 0169
			static Delegate GetIsPageAppearCalledHandler ()
			{
				if (cb_isPageAppearCalled == null)
					cb_isPageAppearCalled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPageAppearCalled);
				return cb_isPageAppearCalled;
			}

			static bool n_IsPageAppearCalled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPageAppearCalled;
			}
#pragma warning restore 0169

			static IntPtr id_isPageAppearCalled;
			public virtual unsafe bool IsPageAppearCalled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='isPageAppearCalled' and count(parameter)=0]"
				[Register ("isPageAppearCalled", "()Z", "GetIsPageAppearCalledHandler")]
				get {
					if (id_isPageAppearCalled == IntPtr.Zero)
						id_isPageAppearCalled = JNIEnv.GetMethodID (class_ref, "isPageAppearCalled", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPageAppearCalled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPageAppearCalled", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isSkipPage;
#pragma warning disable 0169
			static Delegate GetIsSkipPageHandler ()
			{
				if (cb_isSkipPage == null)
					cb_isSkipPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSkipPage);
				return cb_isSkipPage;
			}

			static bool n_IsSkipPage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSkipPage;
			}
#pragma warning restore 0169

			static IntPtr id_isSkipPage;
			public virtual unsafe bool IsSkipPage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='isSkipPage' and count(parameter)=0]"
				[Register ("isSkipPage", "()Z", "GetIsSkipPageHandler")]
				get {
					if (id_isSkipPage == IntPtr.Zero)
						id_isSkipPage = JNIEnv.GetMethodID (class_ref, "isSkipPage", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSkipPage);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSkipPage", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getPageName;
#pragma warning disable 0169
			static Delegate GetGetPageNameHandler ()
			{
				if (cb_getPageName == null)
					cb_getPageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageName);
				return cb_getPageName;
			}

			static IntPtr n_GetPageName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PageName);
			}
#pragma warning restore 0169

			static Delegate cb_setPageName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPageName_Ljava_lang_String_Handler ()
			{
				if (cb_setPageName_Ljava_lang_String_ == null)
					cb_setPageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPageName_Ljava_lang_String_);
				return cb_setPageName_Ljava_lang_String_;
			}

			static void n_SetPageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageName)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aPageName = JNIEnv.GetString (native_aPageName, JniHandleOwnership.DoNotTransfer);
				__this.PageName = aPageName;
			}
#pragma warning restore 0169

			static IntPtr id_getPageName;
			static IntPtr id_setPageName_Ljava_lang_String_;
			public virtual unsafe string PageName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getPageName' and count(parameter)=0]"
				[Register ("getPageName", "()Ljava/lang/String;", "GetGetPageNameHandler")]
				get {
					if (id_getPageName == IntPtr.Zero)
						id_getPageName = JNIEnv.GetMethodID (class_ref, "getPageName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPageName", "(Ljava/lang/String;)V", "GetSetPageName_Ljava_lang_String_Handler")]
				set {
					if (id_setPageName_Ljava_lang_String_ == IntPtr.Zero)
						id_setPageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPageName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageName_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageName", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPageProperties;
#pragma warning disable 0169
			static Delegate GetGetPagePropertiesHandler ()
			{
				if (cb_getPageProperties == null)
					cb_getPageProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageProperties);
				return cb_getPageProperties;
			}

			static IntPtr n_GetPageProperties (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PageProperties);
			}
#pragma warning restore 0169

			static Delegate cb_setPageProperties_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetPageProperties_Ljava_util_Map_Handler ()
			{
				if (cb_setPageProperties_Ljava_util_Map_ == null)
					cb_setPageProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPageProperties_Ljava_util_Map_);
				return cb_setPageProperties_Ljava_util_Map_;
			}

			static void n_SetPageProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageProperties)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var aPageProperties = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aPageProperties, JniHandleOwnership.DoNotTransfer);
				__this.PageProperties = aPageProperties;
			}
#pragma warning restore 0169

			static IntPtr id_getPageProperties;
			static IntPtr id_setPageProperties_Ljava_util_Map_;
			public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> PageProperties {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getPageProperties' and count(parameter)=0]"
				[Register ("getPageProperties", "()Ljava/util/Map;", "GetGetPagePropertiesHandler")]
				get {
					if (id_getPageProperties == IntPtr.Zero)
						id_getPageProperties = JNIEnv.GetMethodID (class_ref, "getPageProperties", "()Ljava/util/Map;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageProperties), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageProperties", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
				[Register ("setPageProperties", "(Ljava/util/Map;)V", "GetSetPageProperties_Ljava_util_Map_Handler")]
				set {
					if (id_setPageProperties_Ljava_util_Map_ == IntPtr.Zero)
						id_setPageProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setPageProperties", "(Ljava/util/Map;)V");
					IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageProperties_Ljava_util_Map_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageProperties", "(Ljava/util/Map;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPageStatus;
#pragma warning disable 0169
			static Delegate GetGetPageStatusHandler ()
			{
				if (cb_getPageStatus == null)
					cb_getPageStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageStatus);
				return cb_getPageStatus;
			}

			static IntPtr n_GetPageStatus (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PageStatus);
			}
#pragma warning restore 0169

			static Delegate cb_setPageStatus_Lcom_ut_mini_UTPageStatus_;
#pragma warning disable 0169
			static Delegate GetSetPageStatus_Lcom_ut_mini_UTPageStatus_Handler ()
			{
				if (cb_setPageStatus_Lcom_ut_mini_UTPageStatus_ == null)
					cb_setPageStatus_Lcom_ut_mini_UTPageStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPageStatus_Lcom_ut_mini_UTPageStatus_);
				return cb_setPageStatus_Lcom_ut_mini_UTPageStatus_;
			}

			static void n_SetPageStatus_Lcom_ut_mini_UTPageStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageStatus)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.UT.Mini.UTPageStatus aPageStatus = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (native_aPageStatus, JniHandleOwnership.DoNotTransfer);
				__this.PageStatus = aPageStatus;
			}
#pragma warning restore 0169

			static IntPtr id_getPageStatus;
			static IntPtr id_setPageStatus_Lcom_ut_mini_UTPageStatus_;
			public virtual unsafe global::Com.UT.Mini.UTPageStatus PageStatus {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getPageStatus' and count(parameter)=0]"
				[Register ("getPageStatus", "()Lcom/ut/mini/UTPageStatus;", "GetGetPageStatusHandler")]
				get {
					if (id_getPageStatus == IntPtr.Zero)
						id_getPageStatus = JNIEnv.GetMethodID (class_ref, "getPageStatus", "()Lcom/ut/mini/UTPageStatus;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageStatus), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageStatus", "()Lcom/ut/mini/UTPageStatus;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageStatus' and count(parameter)=1 and parameter[1][@type='com.ut.mini.UTPageStatus']]"
				[Register ("setPageStatus", "(Lcom/ut/mini/UTPageStatus;)V", "GetSetPageStatus_Lcom_ut_mini_UTPageStatus_Handler")]
				set {
					if (id_setPageStatus_Lcom_ut_mini_UTPageStatus_ == IntPtr.Zero)
						id_setPageStatus_Lcom_ut_mini_UTPageStatus_ = JNIEnv.GetMethodID (class_ref, "setPageStatus", "(Lcom/ut/mini/UTPageStatus;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageStatus_Lcom_ut_mini_UTPageStatus_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageStatus", "(Lcom/ut/mini/UTPageStatus;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getPageStayTimstamp;
#pragma warning disable 0169
			static Delegate GetGetPageStayTimstampHandler ()
			{
				if (cb_getPageStayTimstamp == null)
					cb_getPageStayTimstamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPageStayTimstamp);
				return cb_getPageStayTimstamp;
			}

			static long n_GetPageStayTimstamp (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PageStayTimstamp;
			}
#pragma warning restore 0169

			static Delegate cb_setPageStayTimstamp_J;
#pragma warning disable 0169
			static Delegate GetSetPageStayTimstamp_JHandler ()
			{
				if (cb_setPageStayTimstamp_J == null)
					cb_setPageStayTimstamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPageStayTimstamp_J);
				return cb_setPageStayTimstamp_J;
			}

			static void n_SetPageStayTimstamp_J (IntPtr jnienv, IntPtr native__this, long aPageStayTimstamp)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PageStayTimstamp = aPageStayTimstamp;
			}
#pragma warning restore 0169

			static IntPtr id_getPageStayTimstamp;
			static IntPtr id_setPageStayTimstamp_J;
			public virtual unsafe long PageStayTimstamp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getPageStayTimstamp' and count(parameter)=0]"
				[Register ("getPageStayTimstamp", "()J", "GetGetPageStayTimstampHandler")]
				get {
					if (id_getPageStayTimstamp == IntPtr.Zero)
						id_getPageStayTimstamp = JNIEnv.GetMethodID (class_ref, "getPageStayTimstamp", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPageStayTimstamp);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageStayTimstamp", "()J"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageStayTimstamp' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setPageStayTimstamp", "(J)V", "GetSetPageStayTimstamp_JHandler")]
				set {
					if (id_setPageStayTimstamp_J == IntPtr.Zero)
						id_setPageStayTimstamp_J = JNIEnv.GetMethodID (class_ref, "setPageStayTimstamp", "(J)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageStayTimstamp_J, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageStayTimstamp", "(J)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getPageUrl;
#pragma warning disable 0169
			static Delegate GetGetPageUrlHandler ()
			{
				if (cb_getPageUrl == null)
					cb_getPageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageUrl);
				return cb_getPageUrl;
			}

			static IntPtr n_GetPageUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PageUrl);
			}
#pragma warning restore 0169

			static Delegate cb_setPageUrl_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetSetPageUrl_Landroid_net_Uri_Handler ()
			{
				if (cb_setPageUrl_Landroid_net_Uri_ == null)
					cb_setPageUrl_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPageUrl_Landroid_net_Uri_);
				return cb_setPageUrl_Landroid_net_Uri_;
			}

			static void n_SetPageUrl_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageUrl)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri aPageUrl = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_aPageUrl, JniHandleOwnership.DoNotTransfer);
				__this.PageUrl = aPageUrl;
			}
#pragma warning restore 0169

			static IntPtr id_getPageUrl;
			static IntPtr id_setPageUrl_Landroid_net_Uri_;
			public virtual unsafe global::Android.Net.Uri PageUrl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getPageUrl' and count(parameter)=0]"
				[Register ("getPageUrl", "()Landroid/net/Uri;", "GetGetPageUrlHandler")]
				get {
					if (id_getPageUrl == IntPtr.Zero)
						id_getPageUrl = JNIEnv.GetMethodID (class_ref, "getPageUrl", "()Landroid/net/Uri;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageUrl), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageUrl", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageUrl' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
				[Register ("setPageUrl", "(Landroid/net/Uri;)V", "GetSetPageUrl_Landroid_net_Uri_Handler")]
				set {
					if (id_setPageUrl_Landroid_net_Uri_ == IntPtr.Zero)
						id_setPageUrl_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setPageUrl", "(Landroid/net/Uri;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageUrl_Landroid_net_Uri_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageUrl", "(Landroid/net/Uri;)V"), __args);
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
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aRefPage = JNIEnv.GetString (native_aRefPage, JniHandleOwnership.DoNotTransfer);
				__this.RefPage = aRefPage;
			}
#pragma warning restore 0169

			static IntPtr id_getRefPage;
			static IntPtr id_setRefPage_Ljava_lang_String_;
			public virtual unsafe string RefPage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='getRefPage' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setRefPage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_resetPropertiesWithoutSkipFlagAndH5Flag;
#pragma warning disable 0169
			static Delegate GetResetPropertiesWithoutSkipFlagAndH5FlagHandler ()
			{
				if (cb_resetPropertiesWithoutSkipFlagAndH5Flag == null)
					cb_resetPropertiesWithoutSkipFlagAndH5Flag = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetPropertiesWithoutSkipFlagAndH5Flag);
				return cb_resetPropertiesWithoutSkipFlagAndH5Flag;
			}

			static void n_ResetPropertiesWithoutSkipFlagAndH5Flag (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResetPropertiesWithoutSkipFlagAndH5Flag ();
			}
#pragma warning restore 0169

			static IntPtr id_resetPropertiesWithoutSkipFlagAndH5Flag;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='resetPropertiesWithoutSkipFlagAndH5Flag' and count(parameter)=0]"
			[Register ("resetPropertiesWithoutSkipFlagAndH5Flag", "()V", "GetResetPropertiesWithoutSkipFlagAndH5FlagHandler")]
			public virtual unsafe void ResetPropertiesWithoutSkipFlagAndH5Flag ()
			{
				if (id_resetPropertiesWithoutSkipFlagAndH5Flag == IntPtr.Zero)
					id_resetPropertiesWithoutSkipFlagAndH5Flag = JNIEnv.GetMethodID (class_ref, "resetPropertiesWithoutSkipFlagAndH5Flag", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPropertiesWithoutSkipFlagAndH5Flag);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetPropertiesWithoutSkipFlagAndH5Flag", "()V"));
				} finally {
				}
			}

			static Delegate cb_setH5Called;
#pragma warning disable 0169
			static Delegate GetSetH5CalledHandler ()
			{
				if (cb_setH5Called == null)
					cb_setH5Called = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetH5Called);
				return cb_setH5Called;
			}

			static void n_SetH5Called (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetH5Called ();
			}
#pragma warning restore 0169

			static IntPtr id_setH5Called;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setH5Called' and count(parameter)=0]"
			[Register ("setH5Called", "()V", "GetSetH5CalledHandler")]
			public virtual unsafe void SetH5Called ()
			{
				if (id_setH5Called == IntPtr.Zero)
					id_setH5Called = JNIEnv.GetMethodID (class_ref, "setH5Called", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setH5Called);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH5Called", "()V"));
				} finally {
				}
			}

			static Delegate cb_setPageAppearCalled;
#pragma warning disable 0169
			static Delegate GetSetPageAppearCalledHandler ()
			{
				if (cb_setPageAppearCalled == null)
					cb_setPageAppearCalled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetPageAppearCalled);
				return cb_setPageAppearCalled;
			}

			static void n_SetPageAppearCalled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetPageAppearCalled ();
			}
#pragma warning restore 0169

			static IntPtr id_setPageAppearCalled;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setPageAppearCalled' and count(parameter)=0]"
			[Register ("setPageAppearCalled", "()V", "GetSetPageAppearCalledHandler")]
			public virtual unsafe void SetPageAppearCalled ()
			{
				if (id_setPageAppearCalled == IntPtr.Zero)
					id_setPageAppearCalled = JNIEnv.GetMethodID (class_ref, "setPageAppearCalled", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageAppearCalled);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageAppearCalled", "()V"));
				} finally {
				}
			}

			static Delegate cb_setToSkipPage;
#pragma warning disable 0169
			static Delegate GetSetToSkipPageHandler ()
			{
				if (cb_setToSkipPage == null)
					cb_setToSkipPage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetToSkipPage);
				return cb_setToSkipPage;
			}

			static void n_SetToSkipPage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper.UTPageEventObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetToSkipPage ();
			}
#pragma warning restore 0169

			static IntPtr id_setToSkipPage;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper.UTPageEventObject']/method[@name='setToSkipPage' and count(parameter)=0]"
			[Register ("setToSkipPage", "()V", "GetSetToSkipPageHandler")]
			public virtual unsafe void SetToSkipPage ()
			{
				if (id_setToSkipPage == IntPtr.Zero)
					id_setToSkipPage = JNIEnv.GetMethodID (class_ref, "setToSkipPage", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToSkipPage);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToSkipPage", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTPageHitHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTPageHitHelper); }
		}

		protected UTPageHitHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/constructor[@name='UTPageHitHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTPageHitHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTPageHitHelper)) {
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

		static Delegate cb_getCurrentPageName;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageNameHandler ()
		{
			if (cb_getCurrentPageName == null)
				cb_getCurrentPageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentPageName);
			return cb_getCurrentPageName;
		}

		static IntPtr n_GetCurrentPageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.UTPageHitHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentPageName);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPageName;
		public virtual unsafe string CurrentPageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='getCurrentPageName' and count(parameter)=0]"
			[Register ("getCurrentPageName", "()Ljava/lang/String;", "GetGetCurrentPageNameHandler")]
			get {
				if (id_getCurrentPageName == IntPtr.Zero)
					id_getCurrentPageName = JNIEnv.GetMethodID (class_ref, "getCurrentPageName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPageName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.UT.Mini.UTPageHitHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/UTPageHitHelper;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/UTPageHitHelper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_pageAppear_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPageAppear_Ljava_lang_Object_Handler ()
		{
			if (cb_pageAppear_Ljava_lang_Object_ == null)
				cb_pageAppear_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PageAppear_Ljava_lang_Object_);
			return cb_pageAppear_Ljava_lang_Object_;
		}

		static void n_PageAppear_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject)
		{
			global::Com.UT.Mini.UTPageHitHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.PageAppear (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_pageAppear_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='pageAppear' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("pageAppear", "(Ljava/lang/Object;)V", "GetPageAppear_Ljava_lang_Object_Handler")]
		public virtual unsafe void PageAppear (global::Java.Lang.Object aPageObject)
		{
			if (id_pageAppear_Ljava_lang_Object_ == IntPtr.Zero)
				id_pageAppear_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pageAppear", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPageObject);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageAppear_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageAppear", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pageDisAppear_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPageDisAppear_Ljava_lang_Object_Handler ()
		{
			if (cb_pageDisAppear_Ljava_lang_Object_ == null)
				cb_pageDisAppear_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PageDisAppear_Ljava_lang_Object_);
			return cb_pageDisAppear_Ljava_lang_Object_;
		}

		static void n_PageDisAppear_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject)
		{
			global::Com.UT.Mini.UTPageHitHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.PageDisAppear (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_pageDisAppear_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='pageDisAppear' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("pageDisAppear", "(Ljava/lang/Object;)V", "GetPageDisAppear_Ljava_lang_Object_Handler")]
		public virtual unsafe void PageDisAppear (global::Java.Lang.Object aPageObject)
		{
			if (id_pageDisAppear_Ljava_lang_Object_ == IntPtr.Zero)
				id_pageDisAppear_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pageDisAppear", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPageObject);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageDisAppear_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageDisAppear", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_turnOffAutoPageTrack;
#pragma warning disable 0169
		static Delegate GetTurnOffAutoPageTrackHandler ()
		{
			if (cb_turnOffAutoPageTrack == null)
				cb_turnOffAutoPageTrack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOffAutoPageTrack);
			return cb_turnOffAutoPageTrack;
		}

		static void n_TurnOffAutoPageTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.UTPageHitHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffAutoPageTrack ();
		}
#pragma warning restore 0169

		static IntPtr id_turnOffAutoPageTrack;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='turnOffAutoPageTrack' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("turnOffAutoPageTrack", "()V", "GetTurnOffAutoPageTrackHandler")]
		public virtual unsafe void TurnOffAutoPageTrack ()
		{
			if (id_turnOffAutoPageTrack == IntPtr.Zero)
				id_turnOffAutoPageTrack = JNIEnv.GetMethodID (class_ref, "turnOffAutoPageTrack", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffAutoPageTrack);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOffAutoPageTrack", "()V"));
			} finally {
			}
		}

		static Delegate cb_updatePageProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdatePageProperties_Ljava_util_Map_Handler ()
		{
			if (cb_updatePageProperties_Ljava_util_Map_ == null)
				cb_updatePageProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdatePageProperties_Ljava_util_Map_);
			return cb_updatePageProperties_Ljava_util_Map_;
		}

		static void n_UpdatePageProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aProperties)
		{
			global::Com.UT.Mini.UTPageHitHelper __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageHitHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aProperties = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aProperties, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePageProperties (aProperties);
		}
#pragma warning restore 0169

		static IntPtr id_updatePageProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTPageHitHelper']/method[@name='updatePageProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("updatePageProperties", "(Ljava/util/Map;)V", "GetUpdatePageProperties_Ljava_util_Map_Handler")]
		public virtual unsafe void UpdatePageProperties (global::System.Collections.Generic.IDictionary<string, string> aProperties)
		{
			if (id_updatePageProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_updatePageProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updatePageProperties", "(Ljava/util/Map;)V");
			IntPtr native_aProperties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aProperties);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aProperties);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePageProperties_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePageProperties", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aProperties);
			}
		}

	}
}

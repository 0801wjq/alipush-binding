using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders']"
	[global::Android.Runtime.Register ("com/ut/mini/UTHitBuilders", DoNotGenerateAcw=true)]
	public partial class UTHitBuilders : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTControlHitBuilder']"
		[global::Android.Runtime.Register ("com/ut/mini/UTHitBuilders$UTControlHitBuilder", DoNotGenerateAcw=true)]
		public partial class UTControlHitBuilder : global::Com.UT.Mini.UTHitBuilders.UTHitBuilder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ut/mini/UTHitBuilders$UTControlHitBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UTControlHitBuilder); }
			}

			protected UTControlHitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTControlHitBuilder']/constructor[@name='UTHitBuilders.UTControlHitBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UTControlHitBuilder (string aControlName)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_aControlName = JNIEnv.NewString (aControlName);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aControlName);
					if (((object) this).GetType () != typeof (UTControlHitBuilder)) {
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
					JNIEnv.DeleteLocalRef (native_aControlName);
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTControlHitBuilder']/constructor[@name='UTHitBuilders.UTControlHitBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe UTControlHitBuilder (string aPageName, string aControlName)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_aPageName = JNIEnv.NewString (aPageName);
				IntPtr native_aControlName = JNIEnv.NewString (aControlName);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_aPageName);
					__args [1] = new JValue (native_aControlName);
					if (((object) this).GetType () != typeof (UTControlHitBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_aPageName);
					JNIEnv.DeleteLocalRef (native_aControlName);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTCustomHitBuilder']"
		[global::Android.Runtime.Register ("com/ut/mini/UTHitBuilders$UTCustomHitBuilder", DoNotGenerateAcw=true)]
		public partial class UTCustomHitBuilder : global::Com.UT.Mini.UTHitBuilders.UTHitBuilder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ut/mini/UTHitBuilders$UTCustomHitBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UTCustomHitBuilder); }
			}

			protected UTCustomHitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTCustomHitBuilder']/constructor[@name='UTHitBuilders.UTCustomHitBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UTCustomHitBuilder (string aEventLabel)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_aEventLabel = JNIEnv.NewString (aEventLabel);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aEventLabel);
					if (((object) this).GetType () != typeof (UTCustomHitBuilder)) {
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
					JNIEnv.DeleteLocalRef (native_aEventLabel);
				}
			}

			static Delegate cb_setDurationOnEvent_J;
#pragma warning disable 0169
			static Delegate GetSetDurationOnEvent_JHandler ()
			{
				if (cb_setDurationOnEvent_J == null)
					cb_setDurationOnEvent_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDurationOnEvent_J);
				return cb_setDurationOnEvent_J;
			}

			static IntPtr n_SetDurationOnEvent_J (IntPtr jnienv, IntPtr native__this, long aDuration)
			{
				global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDurationOnEvent (aDuration));
			}
#pragma warning restore 0169

			static IntPtr id_setDurationOnEvent_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTCustomHitBuilder']/method[@name='setDurationOnEvent' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDurationOnEvent", "(J)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;", "GetSetDurationOnEvent_JHandler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder SetDurationOnEvent (long aDuration)
			{
				if (id_setDurationOnEvent_J == IntPtr.Zero)
					id_setDurationOnEvent_J = JNIEnv.GetMethodID (class_ref, "setDurationOnEvent", "(J)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (aDuration);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDurationOnEvent_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDurationOnEvent", "(J)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEventPage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetEventPage_Ljava_lang_String_Handler ()
			{
				if (cb_setEventPage_Ljava_lang_String_ == null)
					cb_setEventPage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEventPage_Ljava_lang_String_);
				return cb_setEventPage_Ljava_lang_String_;
			}

			static IntPtr n_SetEventPage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPage)
			{
				global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aPage = JNIEnv.GetString (native_aPage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEventPage (aPage));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setEventPage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTCustomHitBuilder']/method[@name='setEventPage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;", "GetSetEventPage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder SetEventPage (string aPage)
			{
				if (id_setEventPage_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventPage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;");
				IntPtr native_aPage = JNIEnv.NewString (aPage);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aPage);

					global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEventPage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTCustomHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTCustomHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_aPage);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']"
		[global::Android.Runtime.Register ("com/ut/mini/UTHitBuilders$UTHitBuilder", DoNotGenerateAcw=true)]
		public partial class UTHitBuilder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_ARG1']"
			[Register ("FIELD_ARG1")]
			public const string FieldArg1 = (string) "_field_arg1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_ARG2']"
			[Register ("FIELD_ARG2")]
			public const string FieldArg2 = (string) "_field_arg2";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_ARG3']"
			[Register ("FIELD_ARG3")]
			public const string FieldArg3 = (string) "_field_arg3";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_ARGS']"
			[Register ("FIELD_ARGS")]
			public const string FieldArgs = (string) "_field_args";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_EVENT_ID']"
			[Register ("FIELD_EVENT_ID")]
			public const string FieldEventId = (string) "_field_event_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/field[@name='FIELD_PAGE']"
			[Register ("FIELD_PAGE")]
			public const string FieldPage = (string) "_field_page";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ut/mini/UTHitBuilders$UTHitBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UTHitBuilder); }
			}

			protected UTHitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/constructor[@name='UTHitBuilders.UTHitBuilder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UTHitBuilder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (UTHitBuilder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Ljava/util/Map;", "GetBuildHandler")]
			public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetProperty_Ljava_lang_String_Handler ()
			{
				if (cb_getProperty_Ljava_lang_String_ == null)
					cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_);
				return cb_getProperty_Ljava_lang_String_;
			}

			static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aKey)
			{
				global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aKey = JNIEnv.GetString (native_aKey, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetProperty (aKey));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getProperty_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetProperty_Ljava_lang_String_Handler")]
			public virtual unsafe string GetProperty (string aKey)
			{
				if (id_getProperty_Ljava_lang_String_ == IntPtr.Zero)
					id_getProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_aKey = JNIEnv.NewString (aKey);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aKey);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_aKey);
				}
			}

			static Delegate cb_setProperties_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetProperties_Ljava_util_Map_Handler ()
			{
				if (cb_setProperties_Ljava_util_Map_ == null)
					cb_setProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProperties_Ljava_util_Map_);
				return cb_setProperties_Ljava_util_Map_;
			}

			static IntPtr n_SetProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aProperties)
			{
				global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var aProperties = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aProperties, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProperties (aProperties));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setProperties_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/method[@name='setProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setProperties", "(Ljava/util/Map;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;", "GetSetProperties_Ljava_util_Map_Handler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTHitBuilder SetProperties (global::System.Collections.Generic.IDictionary<string, string> aProperties)
			{
				if (id_setProperties_Ljava_util_Map_ == IntPtr.Zero)
					id_setProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setProperties", "(Ljava/util/Map;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;");
				IntPtr native_aProperties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aProperties);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aProperties);

					global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setProperties_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperties", "(Ljava/util/Map;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_aProperties);
				}
			}

			static Delegate cb_setProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setProperty_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProperty_Ljava_lang_String_Ljava_lang_String_);
				return cb_setProperty_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_SetProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aKey, IntPtr native_aValue)
			{
				global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aKey = JNIEnv.GetString (native_aKey, JniHandleOwnership.DoNotTransfer);
				string aValue = JNIEnv.GetString (native_aValue, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProperty (aKey, aValue));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setProperty_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTHitBuilder']/method[@name='setProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;", "GetSetProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTHitBuilder SetProperty (string aKey, string aValue)
			{
				if (id_setProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;");
				IntPtr native_aKey = JNIEnv.NewString (aKey);
				IntPtr native_aValue = JNIEnv.NewString (aValue);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_aKey);
					__args [1] = new JValue (native_aValue);

					global::Com.UT.Mini.UTHitBuilders.UTHitBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_aKey);
					JNIEnv.DeleteLocalRef (native_aValue);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTPageHitBuilder']"
		[global::Android.Runtime.Register ("com/ut/mini/UTHitBuilders$UTPageHitBuilder", DoNotGenerateAcw=true)]
		public partial class UTPageHitBuilder : global::Com.UT.Mini.UTHitBuilders.UTHitBuilder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ut/mini/UTHitBuilders$UTPageHitBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UTPageHitBuilder); }
			}

			protected UTPageHitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTPageHitBuilder']/constructor[@name='UTHitBuilders.UTPageHitBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UTPageHitBuilder (string aPageName)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_aPageName = JNIEnv.NewString (aPageName);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aPageName);
					if (((object) this).GetType () != typeof (UTPageHitBuilder)) {
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
					JNIEnv.DeleteLocalRef (native_aPageName);
				}
			}

			static Delegate cb_setDurationOnPage_J;
#pragma warning disable 0169
			static Delegate GetSetDurationOnPage_JHandler ()
			{
				if (cb_setDurationOnPage_J == null)
					cb_setDurationOnPage_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDurationOnPage_J);
				return cb_setDurationOnPage_J;
			}

			static IntPtr n_SetDurationOnPage_J (IntPtr jnienv, IntPtr native__this, long aDuration)
			{
				global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDurationOnPage (aDuration));
			}
#pragma warning restore 0169

			static IntPtr id_setDurationOnPage_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTPageHitBuilder']/method[@name='setDurationOnPage' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDurationOnPage", "(J)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;", "GetSetDurationOnPage_JHandler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder SetDurationOnPage (long aDuration)
			{
				if (id_setDurationOnPage_J == IntPtr.Zero)
					id_setDurationOnPage_J = JNIEnv.GetMethodID (class_ref, "setDurationOnPage", "(J)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (aDuration);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDurationOnPage_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDurationOnPage", "(J)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setReferPage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetReferPage_Ljava_lang_String_Handler ()
			{
				if (cb_setReferPage_Ljava_lang_String_ == null)
					cb_setReferPage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReferPage_Ljava_lang_String_);
				return cb_setReferPage_Ljava_lang_String_;
			}

			static IntPtr n_SetReferPage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aReferPage)
			{
				global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string aReferPage = JNIEnv.GetString (native_aReferPage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReferPage (aReferPage));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setReferPage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders.UTPageHitBuilder']/method[@name='setReferPage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReferPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;", "GetSetReferPage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder SetReferPage (string aReferPage)
			{
				if (id_setReferPage_Ljava_lang_String_ == IntPtr.Zero)
					id_setReferPage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;");
				IntPtr native_aReferPage = JNIEnv.NewString (aReferPage);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_aReferPage);

					global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReferPage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTHitBuilders.UTPageHitBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferPage", "(Ljava/lang/String;)Lcom/ut/mini/UTHitBuilders$UTPageHitBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_aReferPage);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTHitBuilders", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTHitBuilders); }
		}

		protected UTHitBuilders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTHitBuilders']/constructor[@name='UTHitBuilders' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTHitBuilders ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTHitBuilders)) {
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

	}
}

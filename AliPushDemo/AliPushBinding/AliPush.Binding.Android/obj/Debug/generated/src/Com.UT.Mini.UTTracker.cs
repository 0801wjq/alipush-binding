using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']"
	[global::Android.Runtime.Register ("com/ut/mini/UTTracker", DoNotGenerateAcw=true)]
	public partial class UTTracker : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/UTTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTTracker); }
		}

		protected UTTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/constructor[@name='UTTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTTracker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTTracker)) {
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

		static Delegate cb_getGlobalProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetGlobalProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getGlobalProperty_Ljava_lang_String_ == null)
				cb_getGlobalProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGlobalProperty_Ljava_lang_String_);
			return cb_getGlobalProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetGlobalProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aKey)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aKey = JNIEnv.GetString (native_aKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGlobalProperty (aKey));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='getGlobalProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getGlobalProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetGlobalProperty_Ljava_lang_String_Handler")]
		public virtual unsafe string GetGlobalProperty (string aKey)
		{
			if (id_getGlobalProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getGlobalProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getGlobalProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_aKey = JNIEnv.NewString (aKey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aKey);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGlobalProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGlobalProperty", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aKey);
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
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.PageAppear (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_pageAppear_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='pageAppear' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_pageAppear_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPageAppear_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_pageAppear_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_pageAppear_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PageAppear_Ljava_lang_Object_Ljava_lang_String_);
			return cb_pageAppear_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_PageAppear_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aCustomPageName)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			string aCustomPageName = JNIEnv.GetString (native_aCustomPageName, JniHandleOwnership.DoNotTransfer);
			__this.PageAppear (aPageObject, aCustomPageName);
		}
#pragma warning restore 0169

		static IntPtr id_pageAppear_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='pageAppear' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("pageAppear", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetPageAppear_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void PageAppear (global::Java.Lang.Object aPageObject, string aCustomPageName)
		{
			if (id_pageAppear_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_pageAppear_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "pageAppear", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_aCustomPageName = JNIEnv.NewString (aCustomPageName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (native_aCustomPageName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageAppear_Ljava_lang_Object_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageAppear", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aCustomPageName);
			}
		}

		static Delegate cb_pageAppearDonotSkip_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPageAppearDonotSkip_Ljava_lang_Object_Handler ()
		{
			if (cb_pageAppearDonotSkip_Ljava_lang_Object_ == null)
				cb_pageAppearDonotSkip_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PageAppearDonotSkip_Ljava_lang_Object_);
			return cb_pageAppearDonotSkip_Ljava_lang_Object_;
		}

		static void n_PageAppearDonotSkip_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.PageAppearDonotSkip (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_pageAppearDonotSkip_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='pageAppearDonotSkip' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("pageAppearDonotSkip", "(Ljava/lang/Object;)V", "GetPageAppearDonotSkip_Ljava_lang_Object_Handler")]
		public virtual unsafe void PageAppearDonotSkip (global::Java.Lang.Object aPageObject)
		{
			if (id_pageAppearDonotSkip_Ljava_lang_Object_ == IntPtr.Zero)
				id_pageAppearDonotSkip_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pageAppearDonotSkip", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPageObject);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageAppearDonotSkip_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageAppearDonotSkip", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_);
			return cb_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_PageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aCustomPageName)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			string aCustomPageName = JNIEnv.GetString (native_aCustomPageName, JniHandleOwnership.DoNotTransfer);
			__this.PageAppearDonotSkip (aPageObject, aCustomPageName);
		}
#pragma warning restore 0169

		static IntPtr id_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='pageAppearDonotSkip' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("pageAppearDonotSkip", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetPageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void PageAppearDonotSkip (global::Java.Lang.Object aPageObject, string aCustomPageName)
		{
			if (id_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "pageAppearDonotSkip", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_aCustomPageName = JNIEnv.NewString (aCustomPageName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (native_aCustomPageName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pageAppearDonotSkip_Ljava_lang_Object_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageAppearDonotSkip", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aCustomPageName);
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
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.PageDisAppear (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_pageDisAppear_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='pageDisAppear' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_q_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQ_Ljava_lang_String_Handler ()
		{
			if (cb_q_Ljava_lang_String_ == null)
				cb_q_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Q_Ljava_lang_String_);
			return cb_q_Ljava_lang_String_;
		}

		static void n_Q_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Q (p0);
		}
#pragma warning restore 0169

		static IntPtr id_q_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='q' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("q", "(Ljava/lang/String;)V", "GetQ_Ljava_lang_String_Handler")]
		protected virtual unsafe void Q (string p0)
		{
			if (id_q_Ljava_lang_String_ == IntPtr.Zero)
				id_q_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "q", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_q_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "q", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeGlobalProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGlobalProperty_Ljava_lang_String_Handler ()
		{
			if (cb_removeGlobalProperty_Ljava_lang_String_ == null)
				cb_removeGlobalProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveGlobalProperty_Ljava_lang_String_);
			return cb_removeGlobalProperty_Ljava_lang_String_;
		}

		static void n_RemoveGlobalProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aKey)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aKey = JNIEnv.GetString (native_aKey, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalProperty (aKey);
		}
#pragma warning restore 0169

		static IntPtr id_removeGlobalProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='removeGlobalProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeGlobalProperty", "(Ljava/lang/String;)V", "GetRemoveGlobalProperty_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveGlobalProperty (string aKey)
		{
			if (id_removeGlobalProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalProperty", "(Ljava/lang/String;)V");
			IntPtr native_aKey = JNIEnv.NewString (aKey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aKey);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeGlobalProperty_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeGlobalProperty", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aKey);
			}
		}

		static Delegate cb_send_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_util_Map_Handler ()
		{
			if (cb_send_Ljava_util_Map_ == null)
				cb_send_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_util_Map_);
			return cb_send_Ljava_util_Map_;
		}

		static void n_Send_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aLogMap)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aLogMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aLogMap, JniHandleOwnership.DoNotTransfer);
			__this.Send (aLogMap);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("send", "(Ljava/util/Map;)V", "GetSend_Ljava_util_Map_Handler")]
		public virtual unsafe void Send (global::System.Collections.Generic.IDictionary<string, string> aLogMap)
		{
			if (id_send_Ljava_util_Map_ == IntPtr.Zero)
				id_send_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/util/Map;)V");
			IntPtr native_aLogMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aLogMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aLogMap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aLogMap);
			}
		}

		static Delegate cb_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGlobalProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGlobalProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetGlobalProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aKey, IntPtr native_aValue)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aKey = JNIEnv.GetString (native_aKey, JniHandleOwnership.DoNotTransfer);
			string aValue = JNIEnv.GetString (native_aValue, JniHandleOwnership.DoNotTransfer);
			__this.SetGlobalProperty (aKey, aValue);
		}
#pragma warning restore 0169

		static IntPtr id_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='setGlobalProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGlobalProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetGlobalProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetGlobalProperty (string aKey, string aValue)
		{
			if (id_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGlobalProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_aKey = JNIEnv.NewString (aKey);
			IntPtr native_aValue = JNIEnv.NewString (aValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aKey);
				__args [1] = new JValue (native_aValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGlobalProperty_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGlobalProperty", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aKey);
				JNIEnv.DeleteLocalRef (native_aValue);
			}
		}

		static Delegate cb_skipPage_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSkipPage_Ljava_lang_Object_Handler ()
		{
			if (cb_skipPage_Ljava_lang_Object_ == null)
				cb_skipPage_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SkipPage_Ljava_lang_Object_);
			return cb_skipPage_Ljava_lang_Object_;
		}

		static void n_SkipPage_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			__this.SkipPage (aPageObject);
		}
#pragma warning restore 0169

		static IntPtr id_skipPage_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='skipPage' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("skipPage", "(Ljava/lang/Object;)V", "GetSkipPage_Ljava_lang_Object_Handler")]
		public virtual unsafe void SkipPage (global::Java.Lang.Object aPageObject)
		{
			if (id_skipPage_Ljava_lang_Object_ == IntPtr.Zero)
				id_skipPage_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "skipPage", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aPageObject);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipPage_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipPage", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateNextPageProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdateNextPageProperties_Ljava_util_Map_Handler ()
		{
			if (cb_updateNextPageProperties_Ljava_util_Map_ == null)
				cb_updateNextPageProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNextPageProperties_Ljava_util_Map_);
			return cb_updateNextPageProperties_Ljava_util_Map_;
		}

		static void n_UpdateNextPageProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aProperties)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aProperties = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aProperties, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNextPageProperties (aProperties);
		}
#pragma warning restore 0169

		static IntPtr id_updateNextPageProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='updateNextPageProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateNextPageProperties", "(Ljava/util/Map;)V", "GetUpdateNextPageProperties_Ljava_util_Map_Handler")]
		public virtual unsafe void UpdateNextPageProperties (global::System.Collections.Generic.IDictionary<string, string> aProperties)
		{
			if (id_updateNextPageProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_updateNextPageProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updateNextPageProperties", "(Ljava/util/Map;)V");
			IntPtr native_aProperties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aProperties);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aProperties);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNextPageProperties_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNextPageProperties", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aProperties);
			}
		}

		static Delegate cb_updatePageName_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePageName_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_updatePageName_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_updatePageName_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePageName_Ljava_lang_Object_Ljava_lang_String_);
			return cb_updatePageName_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_UpdatePageName_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aPageName)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			string aPageName = JNIEnv.GetString (native_aPageName, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePageName (aPageObject, aPageName);
		}
#pragma warning restore 0169

		static IntPtr id_updatePageName_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='updatePageName' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("updatePageName", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetUpdatePageName_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdatePageName (global::Java.Lang.Object aPageObject, string aPageName)
		{
			if (id_updatePageName_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_updatePageName_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updatePageName", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_aPageName = JNIEnv.NewString (aPageName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (native_aPageName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePageName_Ljava_lang_Object_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePageName", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aPageName);
			}
		}

		static Delegate cb_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetUpdatePageProperties_Ljava_lang_Object_Ljava_util_Map_Handler ()
		{
			if (cb_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_ == null)
				cb_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePageProperties_Ljava_lang_Object_Ljava_util_Map_);
			return cb_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_;
		}

		static void n_UpdatePageProperties_Ljava_lang_Object_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aProperties)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			var aProperties = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aProperties, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePageProperties (aPageObject, aProperties);
		}
#pragma warning restore 0169

		static IntPtr id_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='updatePageProperties' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updatePageProperties", "(Ljava/lang/Object;Ljava/util/Map;)V", "GetUpdatePageProperties_Ljava_lang_Object_Ljava_util_Map_Handler")]
		public virtual unsafe void UpdatePageProperties (global::Java.Lang.Object aPageObject, global::System.Collections.Generic.IDictionary<string, string> aProperties)
		{
			if (id_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_ == IntPtr.Zero)
				id_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "updatePageProperties", "(Ljava/lang/Object;Ljava/util/Map;)V");
			IntPtr native_aProperties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aProperties);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (native_aProperties);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePageProperties_Ljava_lang_Object_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePageProperties", "(Ljava/lang/Object;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aProperties);
			}
		}

		static Delegate cb_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_;
#pragma warning disable 0169
		static Delegate GetUpdatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_Handler ()
		{
			if (cb_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_ == null)
				cb_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_);
			return cb_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_;
		}

		static void n_UpdatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aPageStatus)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Mini.UTPageStatus aPageStatus = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTPageStatus> (native_aPageStatus, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePageStatus (aPageObject, aPageStatus);
		}
#pragma warning restore 0169

		static IntPtr id_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='updatePageStatus' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ut.mini.UTPageStatus']]"
		[Register ("updatePageStatus", "(Ljava/lang/Object;Lcom/ut/mini/UTPageStatus;)V", "GetUpdatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_Handler")]
		public virtual unsafe void UpdatePageStatus (global::Java.Lang.Object aPageObject, global::Com.UT.Mini.UTPageStatus aPageStatus)
		{
			if (id_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_ == IntPtr.Zero)
				id_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_ = JNIEnv.GetMethodID (class_ref, "updatePageStatus", "(Ljava/lang/Object;Lcom/ut/mini/UTPageStatus;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (aPageStatus);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePageStatus_Ljava_lang_Object_Lcom_ut_mini_UTPageStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePageStatus", "(Ljava/lang/Object;Lcom/ut/mini/UTPageStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetUpdatePageUrl_Ljava_lang_Object_Landroid_net_Uri_Handler ()
		{
			if (cb_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_ == null)
				cb_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePageUrl_Ljava_lang_Object_Landroid_net_Uri_);
			return cb_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_;
		}

		static void n_UpdatePageUrl_Ljava_lang_Object_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPageObject, IntPtr native_aUri)
		{
			global::Com.UT.Mini.UTTracker __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.UTTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object aPageObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_aPageObject, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri aUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_aUri, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePageUrl (aPageObject, aUri);
		}
#pragma warning restore 0169

		static IntPtr id_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/class[@name='UTTracker']/method[@name='updatePageUrl' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.net.Uri']]"
		[Register ("updatePageUrl", "(Ljava/lang/Object;Landroid/net/Uri;)V", "GetUpdatePageUrl_Ljava_lang_Object_Landroid_net_Uri_Handler")]
		public virtual unsafe void UpdatePageUrl (global::Java.Lang.Object aPageObject, global::Android.Net.Uri aUri)
		{
			if (id_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_ == IntPtr.Zero)
				id_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "updatePageUrl", "(Ljava/lang/Object;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aPageObject);
				__args [1] = new JValue (aUri);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePageUrl_Ljava_lang_Object_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePageUrl", "(Ljava/lang/Object;Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

	}
}

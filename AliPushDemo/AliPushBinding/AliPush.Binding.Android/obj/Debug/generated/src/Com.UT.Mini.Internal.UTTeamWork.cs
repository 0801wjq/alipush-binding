using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']"
	[global::Android.Runtime.Register ("com/ut/mini/internal/UTTeamWork", DoNotGenerateAcw=true)]
	public partial class UTTeamWork : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/internal/UTTeamWork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTTeamWork); }
		}

		protected UTTeamWork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/constructor[@name='UTTeamWork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTTeamWork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTTeamWork)) {
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
		public static unsafe global::Com.UT.Mini.Internal.UTTeamWork Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ut/mini/internal/UTTeamWork;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ut/mini/internal/UTTeamWork;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUtsid;
#pragma warning disable 0169
		static Delegate GetGetUtsidHandler ()
		{
			if (cb_getUtsid == null)
				cb_getUtsid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUtsid);
			return cb_getUtsid;
		}

		static IntPtr n_GetUtsid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Utsid);
		}
#pragma warning restore 0169

		static IntPtr id_getUtsid;
		public virtual unsafe string Utsid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='getUtsid' and count(parameter)=0]"
			[Register ("getUtsid", "()Ljava/lang/String;", "GetGetUtsidHandler")]
			get {
				if (id_getUtsid == IntPtr.Zero)
					id_getUtsid = JNIEnv.GetMethodID (class_ref, "getUtsid", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUtsid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUtsid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_closeAuto1010Track;
#pragma warning disable 0169
		static Delegate GetCloseAuto1010TrackHandler ()
		{
			if (cb_closeAuto1010Track == null)
				cb_closeAuto1010Track = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseAuto1010Track);
			return cb_closeAuto1010Track;
		}

		static void n_CloseAuto1010Track (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAuto1010Track ();
		}
#pragma warning restore 0169

		static IntPtr id_closeAuto1010Track;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='closeAuto1010Track' and count(parameter)=0]"
		[Register ("closeAuto1010Track", "()V", "GetCloseAuto1010TrackHandler")]
		public virtual unsafe void CloseAuto1010Track ()
		{
			if (id_closeAuto1010Track == IntPtr.Zero)
				id_closeAuto1010Track = JNIEnv.GetMethodID (class_ref, "closeAuto1010Track", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeAuto1010Track);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeAuto1010Track", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableNetworkStatusChecker;
#pragma warning disable 0169
		static Delegate GetDisableNetworkStatusCheckerHandler ()
		{
			if (cb_disableNetworkStatusChecker == null)
				cb_disableNetworkStatusChecker = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableNetworkStatusChecker);
			return cb_disableNetworkStatusChecker;
		}

		static void n_DisableNetworkStatusChecker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableNetworkStatusChecker ();
		}
#pragma warning restore 0169

		static IntPtr id_disableNetworkStatusChecker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='disableNetworkStatusChecker' and count(parameter)=0]"
		[Register ("disableNetworkStatusChecker", "()V", "GetDisableNetworkStatusCheckerHandler")]
		public virtual unsafe void DisableNetworkStatusChecker ()
		{
			if (id_disableNetworkStatusChecker == IntPtr.Zero)
				id_disableNetworkStatusChecker = JNIEnv.GetMethodID (class_ref, "disableNetworkStatusChecker", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableNetworkStatusChecker);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableNetworkStatusChecker", "()V"));
			} finally {
			}
		}

		static Delegate cb_dispatchLocalHits;
#pragma warning disable 0169
		static Delegate GetDispatchLocalHitsHandler ()
		{
			if (cb_dispatchLocalHits == null)
				cb_dispatchLocalHits = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchLocalHits);
			return cb_dispatchLocalHits;
		}

		static void n_DispatchLocalHits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchLocalHits ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchLocalHits;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='dispatchLocalHits' and count(parameter)=0]"
		[Register ("dispatchLocalHits", "()V", "GetDispatchLocalHitsHandler")]
		public virtual unsafe void DispatchLocalHits ()
		{
			if (id_dispatchLocalHits == IntPtr.Zero)
				id_dispatchLocalHits = JNIEnv.GetMethodID (class_ref, "dispatchLocalHits", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchLocalHits);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchLocalHits", "()V"));
			} finally {
			}
		}

		static Delegate cb_initialized;
#pragma warning disable 0169
		static Delegate GetInitializedHandler ()
		{
			if (cb_initialized == null)
				cb_initialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialized);
			return cb_initialized;
		}

		static void n_Initialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialized ();
		}
#pragma warning restore 0169

		static IntPtr id_initialized;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='initialized' and count(parameter)=0]"
		[Register ("initialized", "()V", "GetInitializedHandler")]
		public virtual unsafe void Initialized ()
		{
			if (id_initialized == IntPtr.Zero)
				id_initialized = JNIEnv.GetMethodID (class_ref, "initialized", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialized);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialized", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveCacheDataToLocal;
#pragma warning disable 0169
		static Delegate GetSaveCacheDataToLocalHandler ()
		{
			if (cb_saveCacheDataToLocal == null)
				cb_saveCacheDataToLocal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SaveCacheDataToLocal);
			return cb_saveCacheDataToLocal;
		}

		static void n_SaveCacheDataToLocal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SaveCacheDataToLocal ();
		}
#pragma warning restore 0169

		static IntPtr id_saveCacheDataToLocal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='saveCacheDataToLocal' and count(parameter)=0]"
		[Register ("saveCacheDataToLocal", "()V", "GetSaveCacheDataToLocalHandler")]
		public virtual unsafe void SaveCacheDataToLocal ()
		{
			if (id_saveCacheDataToLocal == IntPtr.Zero)
				id_saveCacheDataToLocal = JNIEnv.GetMethodID (class_ref, "saveCacheDataToLocal", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveCacheDataToLocal);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveCacheDataToLocal", "()V"));
			} finally {
			}
		}

		static Delegate cb_setToAliyunOsPlatform;
#pragma warning disable 0169
		static Delegate GetSetToAliyunOsPlatformHandler ()
		{
			if (cb_setToAliyunOsPlatform == null)
				cb_setToAliyunOsPlatform = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetToAliyunOsPlatform);
			return cb_setToAliyunOsPlatform;
		}

		static void n_SetToAliyunOsPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetToAliyunOsPlatform ();
		}
#pragma warning restore 0169

		static IntPtr id_setToAliyunOsPlatform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='setToAliyunOsPlatform' and count(parameter)=0]"
		[Register ("setToAliyunOsPlatform", "()V", "GetSetToAliyunOsPlatformHandler")]
		public virtual unsafe void SetToAliyunOsPlatform ()
		{
			if (id_setToAliyunOsPlatform == IntPtr.Zero)
				id_setToAliyunOsPlatform = JNIEnv.GetMethodID (class_ref, "setToAliyunOsPlatform", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToAliyunOsPlatform);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToAliyunOsPlatform", "()V"));
			} finally {
			}
		}

		static Delegate cb_turnOffRealTimeDebug;
#pragma warning disable 0169
		static Delegate GetTurnOffRealTimeDebugHandler ()
		{
			if (cb_turnOffRealTimeDebug == null)
				cb_turnOffRealTimeDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOffRealTimeDebug);
			return cb_turnOffRealTimeDebug;
		}

		static void n_TurnOffRealTimeDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffRealTimeDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_turnOffRealTimeDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "GetTurnOffRealTimeDebugHandler")]
		public virtual unsafe void TurnOffRealTimeDebug ()
		{
			if (id_turnOffRealTimeDebug == IntPtr.Zero)
				id_turnOffRealTimeDebug = JNIEnv.GetMethodID (class_ref, "turnOffRealTimeDebug", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffRealTimeDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOffRealTimeDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_turnOnRealTimeDebug_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTurnOnRealTimeDebug_Ljava_util_Map_Handler ()
		{
			if (cb_turnOnRealTimeDebug_Ljava_util_Map_ == null)
				cb_turnOnRealTimeDebug_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOnRealTimeDebug_Ljava_util_Map_);
			return cb_turnOnRealTimeDebug_Ljava_util_Map_;
		}

		static void n_TurnOnRealTimeDebug_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aMap)
		{
			global::Com.UT.Mini.Internal.UTTeamWork __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Internal.UTTeamWork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_aMap, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnRealTimeDebug (aMap);
		}
#pragma warning restore 0169

		static IntPtr id_turnOnRealTimeDebug_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini.internal']/class[@name='UTTeamWork']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "GetTurnOnRealTimeDebug_Ljava_util_Map_Handler")]
		public virtual unsafe void TurnOnRealTimeDebug (global::System.Collections.Generic.IDictionary<string, string> aMap)
		{
			if (id_turnOnRealTimeDebug_Ljava_util_Map_ == IntPtr.Zero)
				id_turnOnRealTimeDebug_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "turnOnRealTimeDebug", "(Ljava/util/Map;)V");
			IntPtr native_aMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (aMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aMap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnRealTimeDebug_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOnRealTimeDebug", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aMap);
			}
		}

	}
}

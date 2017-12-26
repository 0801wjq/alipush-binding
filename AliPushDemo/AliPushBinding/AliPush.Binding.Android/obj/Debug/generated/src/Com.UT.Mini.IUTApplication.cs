using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']"
	[Register ("com/ut/mini/IUTApplication", "", "Com.UT.Mini.IUTApplicationInvoker")]
	public partial interface IUTApplication : IJavaObject {

		bool IsAliyunOsSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='isAliyunOsSystem' and count(parameter)=0]"
			[Register ("isAliyunOsSystem", "()Z", "GetIsAliyunOsSystemHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		bool IsUTCrashHandlerDisable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='isUTCrashHandlerDisable' and count(parameter)=0]"
			[Register ("isUTCrashHandlerDisable", "()Z", "GetIsUTCrashHandlerDisableHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		bool IsUTLogEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='isUTLogEnable' and count(parameter)=0]"
			[Register ("isUTLogEnable", "()Z", "GetIsUTLogEnableHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		string UTAppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='getUTAppVersion' and count(parameter)=0]"
			[Register ("getUTAppVersion", "()Ljava/lang/String;", "GetGetUTAppVersionHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		string UTChannel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='getUTChannel' and count(parameter)=0]"
			[Register ("getUTChannel", "()Ljava/lang/String;", "GetGetUTChannelHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		global::Com.UT.Mini.Crashhandler.IUTCrashCaughtListner UTCrashCraughtListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='getUTCrashCraughtListener' and count(parameter)=0]"
			[Register ("getUTCrashCraughtListener", "()Lcom/ut/mini/crashhandler/IUTCrashCaughtListner;", "GetGetUTCrashCraughtListenerHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

		global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication UTRequestAuthInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTApplication']/method[@name='getUTRequestAuthInstance' and count(parameter)=0]"
			[Register ("getUTRequestAuthInstance", "()Lcom/ut/mini/core/sign/IUTRequestAuthentication;", "GetGetUTRequestAuthInstanceHandler:Com.UT.Mini.IUTApplicationInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ut/mini/IUTApplication", DoNotGenerateAcw=true)]
	internal class IUTApplicationInvoker : global::Java.Lang.Object, IUTApplication {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/mini/IUTApplication");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTApplicationInvoker); }
		}

		IntPtr class_ref;

		public static IUTApplication GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTApplication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.mini.IUTApplication"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTApplicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAliyunOsSystem;
#pragma warning disable 0169
		static Delegate GetIsAliyunOsSystemHandler ()
		{
			if (cb_isAliyunOsSystem == null)
				cb_isAliyunOsSystem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAliyunOsSystem);
			return cb_isAliyunOsSystem;
		}

		static bool n_IsAliyunOsSystem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAliyunOsSystem;
		}
#pragma warning restore 0169

		IntPtr id_isAliyunOsSystem;
		public unsafe bool IsAliyunOsSystem {
			get {
				if (id_isAliyunOsSystem == IntPtr.Zero)
					id_isAliyunOsSystem = JNIEnv.GetMethodID (class_ref, "isAliyunOsSystem", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAliyunOsSystem);
			}
		}

		static Delegate cb_isUTCrashHandlerDisable;
#pragma warning disable 0169
		static Delegate GetIsUTCrashHandlerDisableHandler ()
		{
			if (cb_isUTCrashHandlerDisable == null)
				cb_isUTCrashHandlerDisable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUTCrashHandlerDisable);
			return cb_isUTCrashHandlerDisable;
		}

		static bool n_IsUTCrashHandlerDisable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUTCrashHandlerDisable;
		}
#pragma warning restore 0169

		IntPtr id_isUTCrashHandlerDisable;
		public unsafe bool IsUTCrashHandlerDisable {
			get {
				if (id_isUTCrashHandlerDisable == IntPtr.Zero)
					id_isUTCrashHandlerDisable = JNIEnv.GetMethodID (class_ref, "isUTCrashHandlerDisable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUTCrashHandlerDisable);
			}
		}

		static Delegate cb_isUTLogEnable;
#pragma warning disable 0169
		static Delegate GetIsUTLogEnableHandler ()
		{
			if (cb_isUTLogEnable == null)
				cb_isUTLogEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUTLogEnable);
			return cb_isUTLogEnable;
		}

		static bool n_IsUTLogEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUTLogEnable;
		}
#pragma warning restore 0169

		IntPtr id_isUTLogEnable;
		public unsafe bool IsUTLogEnable {
			get {
				if (id_isUTLogEnable == IntPtr.Zero)
					id_isUTLogEnable = JNIEnv.GetMethodID (class_ref, "isUTLogEnable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUTLogEnable);
			}
		}

		static Delegate cb_getUTAppVersion;
#pragma warning disable 0169
		static Delegate GetGetUTAppVersionHandler ()
		{
			if (cb_getUTAppVersion == null)
				cb_getUTAppVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTAppVersion);
			return cb_getUTAppVersion;
		}

		static IntPtr n_GetUTAppVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UTAppVersion);
		}
#pragma warning restore 0169

		IntPtr id_getUTAppVersion;
		public unsafe string UTAppVersion {
			get {
				if (id_getUTAppVersion == IntPtr.Zero)
					id_getUTAppVersion = JNIEnv.GetMethodID (class_ref, "getUTAppVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTAppVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUTChannel;
#pragma warning disable 0169
		static Delegate GetGetUTChannelHandler ()
		{
			if (cb_getUTChannel == null)
				cb_getUTChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTChannel);
			return cb_getUTChannel;
		}

		static IntPtr n_GetUTChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UTChannel);
		}
#pragma warning restore 0169

		IntPtr id_getUTChannel;
		public unsafe string UTChannel {
			get {
				if (id_getUTChannel == IntPtr.Zero)
					id_getUTChannel = JNIEnv.GetMethodID (class_ref, "getUTChannel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTChannel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUTCrashCraughtListener;
#pragma warning disable 0169
		static Delegate GetGetUTCrashCraughtListenerHandler ()
		{
			if (cb_getUTCrashCraughtListener == null)
				cb_getUTCrashCraughtListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTCrashCraughtListener);
			return cb_getUTCrashCraughtListener;
		}

		static IntPtr n_GetUTCrashCraughtListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UTCrashCraughtListener);
		}
#pragma warning restore 0169

		IntPtr id_getUTCrashCraughtListener;
		public unsafe global::Com.UT.Mini.Crashhandler.IUTCrashCaughtListner UTCrashCraughtListener {
			get {
				if (id_getUTCrashCraughtListener == IntPtr.Zero)
					id_getUTCrashCraughtListener = JNIEnv.GetMethodID (class_ref, "getUTCrashCraughtListener", "()Lcom/ut/mini/crashhandler/IUTCrashCaughtListner;");
				return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Crashhandler.IUTCrashCaughtListner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTCrashCraughtListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUTRequestAuthInstance;
#pragma warning disable 0169
		static Delegate GetGetUTRequestAuthInstanceHandler ()
		{
			if (cb_getUTRequestAuthInstance == null)
				cb_getUTRequestAuthInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTRequestAuthInstance);
			return cb_getUTRequestAuthInstance;
		}

		static IntPtr n_GetUTRequestAuthInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTApplication __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UTRequestAuthInstance);
		}
#pragma warning restore 0169

		IntPtr id_getUTRequestAuthInstance;
		public unsafe global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication UTRequestAuthInstance {
			get {
				if (id_getUTRequestAuthInstance == IntPtr.Zero)
					id_getUTRequestAuthInstance = JNIEnv.GetMethodID (class_ref, "getUTRequestAuthInstance", "()Lcom/ut/mini/core/sign/IUTRequestAuthentication;");
				return global::Java.Lang.Object.GetObject<global::Com.UT.Mini.Core.Sign.IUTRequestAuthentication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTRequestAuthInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

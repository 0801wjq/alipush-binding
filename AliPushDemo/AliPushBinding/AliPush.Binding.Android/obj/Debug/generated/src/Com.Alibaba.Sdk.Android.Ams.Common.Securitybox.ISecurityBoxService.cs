using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Securitybox {

	[Register ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService", DoNotGenerateAcw=true)]
	public abstract class SecurityBoxService : Java.Lang.Object {

		internal SecurityBoxService ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/field[@name='MPS_DEVICE_ID_STORE_KEY']"
		[Register ("MPS_DEVICE_ID_STORE_KEY")]
		public const string MpsDeviceIdStoreKey = (string) "mps_deviceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/field[@name='MPS_UTDID_STORE_KEY']"
		[Register ("MPS_UTDID_STORE_KEY")]
		public const string MpsUtdidStoreKey = (string) "mps_utdid";
	}

	[Register ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'SecurityBoxService' type. This type will be removed in a future release.")]
	public abstract class SecurityBoxServiceConsts : SecurityBoxService {

		private SecurityBoxServiceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']"
	[Register ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService", "", "Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker")]
	public partial interface ISecurityBoxService : IJavaObject {

		string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppKey", "(Ljava/lang/String;)V", "GetSetAppKey_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] set;
		}

		string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='setAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppSecret", "(Ljava/lang/String;)V", "GetSetAppSecret_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] set;
		}

		string AppVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getAppVersionName' and count(parameter)=0]"
			[Register ("getAppVersionName", "()Ljava/lang/String;", "GetGetAppVersionNameHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
		}

		string MpsDeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getMpsDeviceId' and count(parameter)=0]"
			[Register ("getMpsDeviceId", "()Ljava/lang/String;", "GetGetMpsDeviceIdHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
		}

		global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lcom/alibaba/sdk/android/ams/common/AmsPlatform;", "GetGetPlatformHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
		}

		string UtDId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='getUtDId' and count(parameter)=0]"
			[Register ("getUtDId", "()Ljava/lang/String;", "GetGetUtDIdHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='generateSign' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("generateSign", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;", "GetGenerateSign_Ljava_util_Map_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		string GenerateSign (global::System.Collections.Generic.IDictionary<string, string> p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='generateTempSeedKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateTempSeedKey", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateTempSeedKey_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		string GenerateTempSeedKey (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='readKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readKey", "(Ljava/lang/String;)Ljava/lang/String;", "GetReadKey_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		string ReadKey (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='sendSdkInfo' and count(parameter)=0]"
		[Register ("sendSdkInfo", "()V", "GetSendSdkInfoHandler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		void SendSdkInfo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='storeMpsDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("storeMpsDeviceId", "(Ljava/lang/String;)V", "GetStoreMpsDeviceId_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		void StoreMpsDeviceId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='storeUtDId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("storeUtDId", "(Ljava/lang/String;)V", "GetStoreUtDId_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		void StoreUtDId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.securitybox']/interface[@name='SecurityBoxService']/method[@name='writeKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWriteKey_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxServiceInvoker, AliPush.Binding.Android")]
		void WriteKey (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService", DoNotGenerateAcw=true)]
	internal class ISecurityBoxServiceInvoker : global::Java.Lang.Object, ISecurityBoxService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/securitybox/SecurityBoxService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISecurityBoxServiceInvoker); }
		}

		IntPtr class_ref;

		public static ISecurityBoxService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISecurityBoxService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.ams.common.securitybox.SecurityBoxService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISecurityBoxServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static Delegate cb_setAppKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAppKey_Ljava_lang_String_ == null)
				cb_setAppKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppKey_Ljava_lang_String_);
			return cb_setAppKey_Ljava_lang_String_;
		}

		static void n_SetAppKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppKey = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAppKey;
		IntPtr id_setAppKey_Ljava_lang_String_;
		public unsafe string AppKey {
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppKey_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppSecret;
#pragma warning disable 0169
		static Delegate GetGetAppSecretHandler ()
		{
			if (cb_getAppSecret == null)
				cb_getAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSecret);
			return cb_getAppSecret;
		}

		static IntPtr n_GetAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setAppSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setAppSecret_Ljava_lang_String_ == null)
				cb_setAppSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppSecret_Ljava_lang_String_);
			return cb_setAppSecret_Ljava_lang_String_;
		}

		static void n_SetAppSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppSecret = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAppSecret;
		IntPtr id_setAppSecret_Ljava_lang_String_;
		public unsafe string AppSecret {
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAppSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppSecret_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppVersionName;
#pragma warning disable 0169
		static Delegate GetGetAppVersionNameHandler ()
		{
			if (cb_getAppVersionName == null)
				cb_getAppVersionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersionName);
			return cb_getAppVersionName;
		}

		static IntPtr n_GetAppVersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersionName);
		}
#pragma warning restore 0169

		IntPtr id_getAppVersionName;
		public unsafe string AppVersionName {
			get {
				if (id_getAppVersionName == IntPtr.Zero)
					id_getAppVersionName = JNIEnv.GetMethodID (class_ref, "getAppVersionName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppVersionName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMpsDeviceId;
#pragma warning disable 0169
		static Delegate GetGetMpsDeviceIdHandler ()
		{
			if (cb_getMpsDeviceId == null)
				cb_getMpsDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMpsDeviceId);
			return cb_getMpsDeviceId;
		}

		static IntPtr n_GetMpsDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MpsDeviceId);
		}
#pragma warning restore 0169

		IntPtr id_getMpsDeviceId;
		public unsafe string MpsDeviceId {
			get {
				if (id_getMpsDeviceId == IntPtr.Zero)
					id_getMpsDeviceId = JNIEnv.GetMethodID (class_ref, "getMpsDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMpsDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlatform;
#pragma warning disable 0169
		static Delegate GetGetPlatformHandler ()
		{
			if (cb_getPlatform == null)
				cb_getPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatform);
			return cb_getPlatform;
		}

		static IntPtr n_GetPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		IntPtr id_getPlatform;
		public unsafe global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform Platform {
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lcom/alibaba/sdk/android/ams/common/AmsPlatform;");
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.AmsPlatform> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUtDId;
#pragma warning disable 0169
		static Delegate GetGetUtDIdHandler ()
		{
			if (cb_getUtDId == null)
				cb_getUtDId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUtDId);
			return cb_getUtDId;
		}

		static IntPtr n_GetUtDId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UtDId);
		}
#pragma warning restore 0169

		IntPtr id_getUtDId;
		public unsafe string UtDId {
			get {
				if (id_getUtDId == IntPtr.Zero)
					id_getUtDId = JNIEnv.GetMethodID (class_ref, "getUtDId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUtDId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_generateSign_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateSign_Ljava_util_Map_Ljava_lang_String_Handler ()
		{
			if (cb_generateSign_Ljava_util_Map_Ljava_lang_String_ == null)
				cb_generateSign_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateSign_Ljava_util_Map_Ljava_lang_String_);
			return cb_generateSign_Ljava_util_Map_Ljava_lang_String_;
		}

		static IntPtr n_GenerateSign_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSign (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateSign_Ljava_util_Map_Ljava_lang_String_;
		public unsafe string GenerateSign (global::System.Collections.Generic.IDictionary<string, string> p0, string p1)
		{
			if (id_generateSign_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_generateSign_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateSign", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateSign_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_generateTempSeedKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateTempSeedKey_Ljava_lang_String_Handler ()
		{
			if (cb_generateTempSeedKey_Ljava_lang_String_ == null)
				cb_generateTempSeedKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateTempSeedKey_Ljava_lang_String_);
			return cb_generateTempSeedKey_Ljava_lang_String_;
		}

		static IntPtr n_GenerateTempSeedKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateTempSeedKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateTempSeedKey_Ljava_lang_String_;
		public unsafe string GenerateTempSeedKey (string p0)
		{
			if (id_generateTempSeedKey_Ljava_lang_String_ == IntPtr.Zero)
				id_generateTempSeedKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateTempSeedKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateTempSeedKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadKey_Ljava_lang_String_Handler ()
		{
			if (cb_readKey_Ljava_lang_String_ == null)
				cb_readKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadKey_Ljava_lang_String_);
			return cb_readKey_Ljava_lang_String_;
		}

		static IntPtr n_ReadKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readKey_Ljava_lang_String_;
		public unsafe string ReadKey (string p0)
		{
			if (id_readKey_Ljava_lang_String_ == IntPtr.Zero)
				id_readKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_sendSdkInfo;
#pragma warning disable 0169
		static Delegate GetSendSdkInfoHandler ()
		{
			if (cb_sendSdkInfo == null)
				cb_sendSdkInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendSdkInfo);
			return cb_sendSdkInfo;
		}

		static void n_SendSdkInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendSdkInfo ();
		}
#pragma warning restore 0169

		IntPtr id_sendSdkInfo;
		public unsafe void SendSdkInfo ()
		{
			if (id_sendSdkInfo == IntPtr.Zero)
				id_sendSdkInfo = JNIEnv.GetMethodID (class_ref, "sendSdkInfo", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSdkInfo);
		}

		static Delegate cb_storeMpsDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStoreMpsDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_storeMpsDeviceId_Ljava_lang_String_ == null)
				cb_storeMpsDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StoreMpsDeviceId_Ljava_lang_String_);
			return cb_storeMpsDeviceId_Ljava_lang_String_;
		}

		static void n_StoreMpsDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StoreMpsDeviceId (p0);
		}
#pragma warning restore 0169

		IntPtr id_storeMpsDeviceId_Ljava_lang_String_;
		public unsafe void StoreMpsDeviceId (string p0)
		{
			if (id_storeMpsDeviceId_Ljava_lang_String_ == IntPtr.Zero)
				id_storeMpsDeviceId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storeMpsDeviceId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeMpsDeviceId_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_storeUtDId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStoreUtDId_Ljava_lang_String_Handler ()
		{
			if (cb_storeUtDId_Ljava_lang_String_ == null)
				cb_storeUtDId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StoreUtDId_Ljava_lang_String_);
			return cb_storeUtDId_Ljava_lang_String_;
		}

		static void n_StoreUtDId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StoreUtDId (p0);
		}
#pragma warning restore 0169

		IntPtr id_storeUtDId_Ljava_lang_String_;
		public unsafe void StoreUtDId (string p0)
		{
			if (id_storeUtDId_Ljava_lang_String_ == IntPtr.Zero)
				id_storeUtDId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storeUtDId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeUtDId_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writeKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writeKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writeKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_writeKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_WriteKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Securitybox.ISecurityBoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteKey (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_writeKey_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void WriteKey (string p0, string p1)
		{
			if (id_writeKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeKey_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	[Register ("com/alibaba/sdk/android/push/CloudPushService", DoNotGenerateAcw=true)]
	public abstract class CloudPushService : Java.Lang.Object {

		internal CloudPushService ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='ACCOUNT_TARGET']"
		[Register ("ACCOUNT_TARGET")]
		public const int AccountTarget = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='ALIAS_TARGET']"
		[Register ("ALIAS_TARGET")]
		public const int AliasTarget = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='DEVICE_TARGET']"
		[Register ("DEVICE_TARGET")]
		public const int DeviceTarget = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='LOG_DEBUG']"
		[Register ("LOG_DEBUG")]
		public const int LogDebug = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='LOG_ERROR']"
		[Register ("LOG_ERROR")]
		public const int LogError = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='LOG_INFO']"
		[Register ("LOG_INFO")]
		public const int LogInfo = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='LOG_OFF']"
		[Register ("LOG_OFF")]
		public const int LogOff = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='NOTIFICATION_ID']"
		[Register ("NOTIFICATION_ID")]
		public const string NotificationId = (string) "_ALIYUN_NOTIFICATION_ID_";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/field[@name='NOTIFICATION_PRIORITY']"
		[Register ("NOTIFICATION_PRIORITY")]
		public const string NotificationPriority = (string) "_ALIYUN_NOTIFICATION_PRIORITY_";
	}

	[Register ("com/alibaba/sdk/android/push/CloudPushService", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CloudPushService' type. This type will be removed in a future release.")]
	public abstract class CloudPushServiceConsts : CloudPushService {

		private CloudPushServiceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']"
	[Register ("com/alibaba/sdk/android/push/CloudPushService", "", "Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker")]
	public partial interface ICloudPushService : IJavaObject {

		string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")] get;
		}

		string UTDeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='getUTDeviceId' and count(parameter)=0]"
			[Register ("getUTDeviceId", "()Ljava/lang/String;", "GetGetUTDeviceIdHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='addAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("addAlias", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetAddAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void AddAlias (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='bindAccount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("bindAccount", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetBindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void BindAccount (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='bindPhoneNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("bindPhoneNumber", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetBindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void BindPhoneNumber (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='bindTag' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("bindTag", "(I[Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetBindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void BindTag (int p0, string[] p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='checkPushChannelStatus' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("checkPushChannelStatus", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetCheckPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void CheckPushChannelStatus (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='clearNotifications' and count(parameter)=0]"
		[Register ("clearNotifications", "()V", "GetClearNotificationsHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void ClearNotifications ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='clickMessage' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.notification.CPushMessage']]"
		[Register ("clickMessage", "(Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V", "GetClickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void ClickMessage (global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='closeDoNotDisturbMode' and count(parameter)=0]"
		[Register ("closeDoNotDisturbMode", "()V", "GetCloseDoNotDisturbModeHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void CloseDoNotDisturbMode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='dismissMessage' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.notification.CPushMessage']]"
		[Register ("dismissMessage", "(Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V", "GetDismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void DismissMessage (global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='listAliases' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("listAliases", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetListAliases_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void ListAliases (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='listTags' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("listTags", "(ILcom/alibaba/sdk/android/push/CommonCallback;)V", "GetListTags_ILcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void ListTags (int p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='onAppStart' and count(parameter)=0]"
		[Register ("onAppStart", "()V", "GetOnAppStartHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void OnAppStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='register' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("register", "(Landroid/content/Context;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetRegister_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void Register (global::Android.Content.Context p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='register' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void Register (global::Android.Content.Context p0, string p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='removeAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("removeAlias", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetRemoveAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void RemoveAlias (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppSecret", "(Ljava/lang/String;)V", "GetSetAppSecret_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetAppSecret (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppkey", "(Ljava/lang/String;)V", "GetSetAppkey_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetAppkey (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setDoNotDisturb' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("setDoNotDisturb", "(IIIILcom/alibaba/sdk/android/push/CommonCallback;)V", "GetSetDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetDoNotDisturb (int p0, int p1, int p2, int p3, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevel", "(I)V", "GetSetLogLevel_IHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetLogLevel (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setNotificationLargeIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setNotificationLargeIcon", "(Landroid/graphics/Bitmap;)V", "GetSetNotificationLargeIcon_Landroid_graphics_Bitmap_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetNotificationLargeIcon (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setNotificationSmallIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNotificationSmallIcon", "(I)V", "GetSetNotificationSmallIcon_IHandler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetNotificationSmallIcon (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setNotificationSoundFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNotificationSoundFilePath", "(Ljava/lang/String;)V", "GetSetNotificationSoundFilePath_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetNotificationSoundFilePath (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='setPushIntentService' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("setPushIntentService", "(Ljava/lang/Class;)V", "GetSetPushIntentService_Ljava_lang_Class_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void SetPushIntentService (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='turnOffPushChannel' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("turnOffPushChannel", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetTurnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void TurnOffPushChannel (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='turnOnPushChannel' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("turnOnPushChannel", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetTurnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void TurnOnPushChannel (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='unbindAccount' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("unbindAccount", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetUnbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void UnbindAccount (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='unbindPhoneNumber' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("unbindPhoneNumber", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetUnbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void UnbindPhoneNumber (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CloudPushService']/method[@name='unbindTag' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("unbindTag", "(I[Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V", "GetUnbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler:Com.Alibaba.Sdk.Android.Push.ICloudPushServiceInvoker, AliPush.Binding.Android")]
		void UnbindTag (int p0, string[] p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/CloudPushService", DoNotGenerateAcw=true)]
	internal class ICloudPushServiceInvoker : global::Java.Lang.Object, ICloudPushService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/push/CloudPushService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICloudPushServiceInvoker); }
		}

		IntPtr class_ref;

		public static ICloudPushService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudPushService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.push.CloudPushService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudPushServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceId;
		public unsafe string DeviceId {
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUTDeviceId;
#pragma warning disable 0169
		static Delegate GetGetUTDeviceIdHandler ()
		{
			if (cb_getUTDeviceId == null)
				cb_getUTDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTDeviceId);
			return cb_getUTDeviceId;
		}

		static IntPtr n_GetUTDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UTDeviceId);
		}
#pragma warning restore 0169

		IntPtr id_getUTDeviceId;
		public unsafe string UTDeviceId {
			get {
				if (id_getUTDeviceId == IntPtr.Zero)
					id_getUTDeviceId = JNIEnv.GetMethodID (class_ref, "getUTDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetAddAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_AddAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAlias (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void AddAlias (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "addAlias", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetBindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_BindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindAccount (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void BindAccount (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "bindAccount", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindAccount_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetBindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_BindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindPhoneNumber (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void BindPhoneNumber (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "bindPhoneNumber", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindPhoneNumber_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetBindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_BindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_BindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.BindTag (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void BindTag (int p0, string[] p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3)
		{
			if (id_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "bindTag", "(I[Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetCheckPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_CheckPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckPushChannelStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void CheckPushChannelStatus (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "checkPushChannelStatus", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkPushChannelStatus_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_clearNotifications;
#pragma warning disable 0169
		static Delegate GetClearNotificationsHandler ()
		{
			if (cb_clearNotifications == null)
				cb_clearNotifications = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearNotifications);
			return cb_clearNotifications;
		}

		static void n_ClearNotifications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearNotifications ();
		}
#pragma warning restore 0169

		IntPtr id_clearNotifications;
		public unsafe void ClearNotifications ()
		{
			if (id_clearNotifications == IntPtr.Zero)
				id_clearNotifications = JNIEnv.GetMethodID (class_ref, "clearNotifications", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearNotifications);
		}

		static Delegate cb_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
#pragma warning disable 0169
		static Delegate GetClickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler ()
		{
			if (cb_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == null)
				cb_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_);
			return cb_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		}

		static void n_ClickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClickMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		public unsafe void ClickMessage (global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0)
		{
			if (id_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == IntPtr.Zero)
				id_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNIEnv.GetMethodID (class_ref, "clickMessage", "(Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clickMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_, __args);
		}

		static Delegate cb_closeDoNotDisturbMode;
#pragma warning disable 0169
		static Delegate GetCloseDoNotDisturbModeHandler ()
		{
			if (cb_closeDoNotDisturbMode == null)
				cb_closeDoNotDisturbMode = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseDoNotDisturbMode);
			return cb_closeDoNotDisturbMode;
		}

		static void n_CloseDoNotDisturbMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseDoNotDisturbMode ();
		}
#pragma warning restore 0169

		IntPtr id_closeDoNotDisturbMode;
		public unsafe void CloseDoNotDisturbMode ()
		{
			if (id_closeDoNotDisturbMode == IntPtr.Zero)
				id_closeDoNotDisturbMode = JNIEnv.GetMethodID (class_ref, "closeDoNotDisturbMode", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeDoNotDisturbMode);
		}

		static Delegate cb_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
#pragma warning disable 0169
		static Delegate GetDismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_Handler ()
		{
			if (cb_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == null)
				cb_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_);
			return cb_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		}

		static void n_DismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DismissMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_;
		public unsafe void DismissMessage (global::Com.Alibaba.Sdk.Android.Push.Notification.CPushMessage p0)
		{
			if (id_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ == IntPtr.Zero)
				id_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_ = JNIEnv.GetMethodID (class_ref, "dismissMessage", "(Lcom/alibaba/sdk/android/push/notification/CPushMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismissMessage_Lcom_alibaba_sdk_android_push_notification_CPushMessage_, __args);
		}

		static Delegate cb_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetListAliases_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ListAliases_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_ListAliases_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ListAliases (p0);
		}
#pragma warning restore 0169

		IntPtr id_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void ListAliases (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "listAliases", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_listAliases_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetListTags_ILcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ListTags_ILcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_ListTags_ILcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ListTags (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void ListTags (int p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "listTags", "(ILcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_listTags_ILcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_onAppStart;
#pragma warning disable 0169
		static Delegate GetOnAppStartHandler ()
		{
			if (cb_onAppStart == null)
				cb_onAppStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAppStart);
			return cb_onAppStart;
		}

		static void n_OnAppStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAppStart ();
		}
#pragma warning restore 0169

		IntPtr id_onAppStart;
		public unsafe void OnAppStart ()
		{
			if (id_onAppStart == IntPtr.Zero)
				id_onAppStart = JNIEnv.GetMethodID (class_ref, "onAppStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAppStart);
		}

		static Delegate cb_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_Register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void Register (global::Android.Content.Context p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_Register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void Register (global::Android.Content.Context p0, string p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3)
		{
			if (id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_RemoveAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAlias (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void RemoveAlias (string p0, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p1)
		{
			if (id_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "removeAlias", "(Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAlias_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

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
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppSecret (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAppSecret_Ljava_lang_String_;
		public unsafe void SetAppSecret (string p0)
		{
			if (id_setAppSecret_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSecret", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppSecret_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setAppkey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppkey_Ljava_lang_String_Handler ()
		{
			if (cb_setAppkey_Ljava_lang_String_ == null)
				cb_setAppkey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppkey_Ljava_lang_String_);
			return cb_setAppkey_Ljava_lang_String_;
		}

		static void n_SetAppkey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppkey (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAppkey_Ljava_lang_String_;
		public unsafe void SetAppkey (string p0)
		{
			if (id_setAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppkey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppkey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppkey_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetSetDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SetDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_SetDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p4 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SetDoNotDisturb (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void SetDoNotDisturb (int p0, int p1, int p2, int p3, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p4)
		{
			if (id_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "setDoNotDisturb", "(IIIILcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDoNotDisturb_IIIILcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_setLogLevel_I;
#pragma warning disable 0169
		static Delegate GetSetLogLevel_IHandler ()
		{
			if (cb_setLogLevel_I == null)
				cb_setLogLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogLevel_I);
			return cb_setLogLevel_I;
		}

		static void n_SetLogLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogLevel (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLogLevel_I;
		public unsafe void SetLogLevel (int p0)
		{
			if (id_setLogLevel_I == IntPtr.Zero)
				id_setLogLevel_I = JNIEnv.GetMethodID (class_ref, "setLogLevel", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogLevel_I, __args);
		}

		static Delegate cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetNotificationLargeIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_ == null)
				cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationLargeIcon_Landroid_graphics_Bitmap_);
			return cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
		}

		static void n_SetNotificationLargeIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationLargeIcon (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
		public unsafe void SetNotificationLargeIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_setNotificationLargeIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setNotificationLargeIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setNotificationLargeIcon", "(Landroid/graphics/Bitmap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationLargeIcon_Landroid_graphics_Bitmap_, __args);
		}

		static Delegate cb_setNotificationSmallIcon_I;
#pragma warning disable 0169
		static Delegate GetSetNotificationSmallIcon_IHandler ()
		{
			if (cb_setNotificationSmallIcon_I == null)
				cb_setNotificationSmallIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotificationSmallIcon_I);
			return cb_setNotificationSmallIcon_I;
		}

		static void n_SetNotificationSmallIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationSmallIcon (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNotificationSmallIcon_I;
		public unsafe void SetNotificationSmallIcon (int p0)
		{
			if (id_setNotificationSmallIcon_I == IntPtr.Zero)
				id_setNotificationSmallIcon_I = JNIEnv.GetMethodID (class_ref, "setNotificationSmallIcon", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSmallIcon_I, __args);
		}

		static Delegate cb_setNotificationSoundFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotificationSoundFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setNotificationSoundFilePath_Ljava_lang_String_ == null)
				cb_setNotificationSoundFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationSoundFilePath_Ljava_lang_String_);
			return cb_setNotificationSoundFilePath_Ljava_lang_String_;
		}

		static void n_SetNotificationSoundFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationSoundFilePath (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNotificationSoundFilePath_Ljava_lang_String_;
		public unsafe void SetNotificationSoundFilePath (string p0)
		{
			if (id_setNotificationSoundFilePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setNotificationSoundFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationSoundFilePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSoundFilePath_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPushIntentService_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetPushIntentService_Ljava_lang_Class_Handler ()
		{
			if (cb_setPushIntentService_Ljava_lang_Class_ == null)
				cb_setPushIntentService_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushIntentService_Ljava_lang_Class_);
			return cb_setPushIntentService_Ljava_lang_Class_;
		}

		static void n_SetPushIntentService_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPushIntentService (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPushIntentService_Ljava_lang_Class_;
		public unsafe void SetPushIntentService (global::Java.Lang.Class p0)
		{
			if (id_setPushIntentService_Ljava_lang_Class_ == IntPtr.Zero)
				id_setPushIntentService_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setPushIntentService", "(Ljava/lang/Class;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPushIntentService_Ljava_lang_Class_, __args);
		}

		static Delegate cb_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetTurnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_TurnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffPushChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void TurnOffPushChannel (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "turnOffPushChannel", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetTurnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_TurnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnPushChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void TurnOnPushChannel (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "turnOnPushChannel", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnPushChannel_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetUnbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_UnbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindAccount (p0);
		}
#pragma warning restore 0169

		IntPtr id_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void UnbindAccount (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "unbindAccount", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindAccount_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetUnbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_UnbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindPhoneNumber (p0);
		}
#pragma warning restore 0169

		IntPtr id_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void UnbindPhoneNumber (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "unbindPhoneNumber", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindPhoneNumber_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
		}

		static Delegate cb_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
#pragma warning disable 0169
		static Delegate GetUnbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_Handler ()
		{
			if (cb_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == null)
				cb_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_UnbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_);
			return cb_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		}

		static void n_UnbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICloudPushService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICloudPushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3 = (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback)global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UnbindTag (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_;
		public unsafe void UnbindTag (int p0, string[] p1, string p2, global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p3)
		{
			if (id_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "unbindTag", "(I[Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unbindTag_IarrayLjava_lang_String_Ljava_lang_String_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}

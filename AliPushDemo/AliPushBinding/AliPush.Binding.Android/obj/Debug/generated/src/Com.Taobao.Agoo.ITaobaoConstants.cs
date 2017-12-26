using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Agoo {

	[Register ("com/taobao/agoo/TaobaoConstants", DoNotGenerateAcw=true)]
	public abstract class TaobaoConstants : Java.Lang.Object {

		internal TaobaoConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='ALIAS_ERROR']"
		[Register ("ALIAS_ERROR")]
		public const string AliasError = (string) "504.1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='APPKEY_OR_TTID_ERROR']"
		[Register ("APPKEY_OR_TTID_ERROR")]
		public const string AppkeyOrTtidError = (string) "504.3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='APPSECRET_ERROR']"
		[Register ("APPSECRET_ERROR")]
		public const string AppsecretError = (string) "504.4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='BINDAGOO_ERROR']"
		[Register ("BINDAGOO_ERROR")]
		public const string BindagooError = (string) "503.2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='CMNS_DEVICE_TOKEN']"
		[Register ("CMNS_DEVICE_TOKEN")]
		public const string CmnsDeviceToken = (string) "cmns_device_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='DEFAULT_INTENT_SERVICE_CLASS_NAME']"
		[Register ("DEFAULT_INTENT_SERVICE_CLASS_NAME")]
		public const string DefaultIntentServiceClassName = (string) ".TaobaoIntentService";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='DEVICETOKEN_ERROR']"
		[Register ("DEVICETOKEN_ERROR")]
		public const string DevicetokenError = (string) "504";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_CONTENT_ERROR']"
		[Register ("MESSAGE_CONTENT_ERROR")]
		public const string MessageContentError = (string) "504.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_IDS_ERROR']"
		[Register ("MESSAGE_IDS_ERROR")]
		public const string MessageIdsError = (string) "504.6";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_NOTIFY_CLICK']"
		[Register ("MESSAGE_NOTIFY_CLICK")]
		public const string MessageNotifyClick = (string) "8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_NOTIFY_DISMISS']"
		[Register ("MESSAGE_NOTIFY_DISMISS")]
		public const string MessageNotifyDismiss = (string) "9";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_SYSTEM_SOURCE_CMNS']"
		[Register ("MESSAGE_SYSTEM_SOURCE_CMNS")]
		public const string MessageSystemSourceCmns = (string) "cmns";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_SYSTEM_SOURCE_GCM']"
		[Register ("MESSAGE_SYSTEM_SOURCE_GCM")]
		public const string MessageSystemSourceGcm = (string) "gcm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_SYSTEM_SOURCE_XIAOMI']"
		[Register ("MESSAGE_SYSTEM_SOURCE_XIAOMI")]
		public const string MessageSystemSourceXiaomi = (string) "xiaomi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='MESSAGE_URL']"
		[Register ("MESSAGE_URL")]
		public const string MessageUrl = (string) "message_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='PREF_CMNS']"
		[Register ("PREF_CMNS")]
		public const string PrefCmns = (string) "pref_cmns";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='PREF_XIAOMI']"
		[Register ("PREF_XIAOMI")]
		public const string PrefXiaomi = (string) "pref_xiaomi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='PROPERTY_APP_NOTIFICATION_ICON']"
		[Register ("PROPERTY_APP_NOTIFICATION_ICON")]
		public const string PropertyAppNotificationIcon = (string) "app_notification_icon";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='PROPERTY_APP_NOTIFICATION_SOUND']"
		[Register ("PROPERTY_APP_NOTIFICATION_SOUND")]
		public const string PropertyAppNotificationSound = (string) "app_notification_sound";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='PROPERTY_APP_NOTIFICATION_VIBRATE']"
		[Register ("PROPERTY_APP_NOTIFICATION_VIBRATE")]
		public const string PropertyAppNotificationVibrate = (string) "app_notification_vibrate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='REGISTER_ERROR']"
		[Register ("REGISTER_ERROR")]
		public const string RegisterError = (string) "503.1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='SERVICE_ID_DEVICECMD']"
		[Register ("SERVICE_ID_DEVICECMD")]
		public const string ServiceIdDevicecmd = (string) "AgooDeviceCmd";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='SUBSCRIBE_ERROR']"
		[Register ("SUBSCRIBE_ERROR")]
		public const string SubscribeError = (string) "504.2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='UNBINDAGOO_ERROR']"
		[Register ("UNBINDAGOO_ERROR")]
		public const string UnbindagooError = (string) "503.3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.agoo']/interface[@name='TaobaoConstants']/field[@name='XIAOMI_REGID']"
		[Register ("XIAOMI_REGID")]
		public const string XiaomiRegid = (string) "xiaomi_regid";

		// The following are fields from: org.android.agoo.common.AgooConstants

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_BODY_NULL']"
		[Register ("ACK_BODY_NULL")]
		public const string AckBodyNull = (string) "11";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_FLAG_NULL']"
		[Register ("ACK_FLAG_NULL")]
		public const string AckFlagNull = (string) "13";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_PACK_ERROR']"
		[Register ("ACK_PACK_ERROR")]
		public const string AckPackError = (string) "15";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_PACK_NOBIND']"
		[Register ("ACK_PACK_NOBIND")]
		public const string AckPackNobind = (string) "14";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_PACK_NULL']"
		[Register ("ACK_PACK_NULL")]
		public const string AckPackNull = (string) "12";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ACK_REMOVE_PACKAGE']"
		[Register ("ACK_REMOVE_PACKAGE")]
		public const string AckRemovePackage = (string) "10";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND']"
		[Register ("AGOO_COMMAND")]
		public const string AgooCommand = (string) "command";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_BINDSERVICE']"
		[Register ("AGOO_COMMAND_BINDSERVICE")]
		public const string AgooCommandBindservice = (string) "agoo_bindservice";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_GCMIPUSHID_REPORT']"
		[Register ("AGOO_COMMAND_GCMIPUSHID_REPORT")]
		public const string AgooCommandGcmipushidReport = (string) "gcmpushId_report";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_HUAWEIPUSHID_REPORT']"
		[Register ("AGOO_COMMAND_HUAWEIPUSHID_REPORT")]
		public const string AgooCommandHuaweipushidReport = (string) "huaweipushId_report";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_MESSAGE_DELETED']"
		[Register ("AGOO_COMMAND_MESSAGE_DELETED")]
		public const string AgooCommandMessageDeleted = (string) "message_deleted";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_MESSAGE_READED']"
		[Register ("AGOO_COMMAND_MESSAGE_READED")]
		public const string AgooCommandMessageReaded = (string) "message_readed";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_MIPUSHID_REPORT']"
		[Register ("AGOO_COMMAND_MIPUSHID_REPORT")]
		public const string AgooCommandMipushidReport = (string) "mipushId_report";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_START_ACTIVITY']"
		[Register ("AGOO_COMMAND_START_ACTIVITY")]
		public const string AgooCommandStartActivity = (string) "message_startActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_COMMAND_UNBINDSERVICE']"
		[Register ("AGOO_COMMAND_UNBINDSERVICE")]
		public const string AgooCommandUnbindservice = (string) "agoo_unbindservice";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_ENCRYPTED_MESSAGE_FLAG']"
		[Register ("AGOO_ENCRYPTED_MESSAGE_FLAG")]
		public const int AgooEncryptedMessageFlag = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_EVENT_ID']"
		[Register ("AGOO_EVENT_ID")]
		public const int AgooEventId = (int) 66002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='AGOO_SERVICE_AGOOACK']"
		[Register ("AGOO_SERVICE_AGOOACK")]
		public const string AgooServiceAgooack = (string) "agooAck";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='BINDER_MSGRECEIVER_ACTION']"
		[Register ("BINDER_MSGRECEIVER_ACTION")]
		public const string BinderMsgreceiverAction = (string) "org.android.agoo.client.MessageReceiverService";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ERROR_APPKEY_NULL']"
		[Register ("ERROR_APPKEY_NULL")]
		public const string ErrorAppkeyNull = (string) "ERROR_APPKEY_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ERROR_APP_SECRET_NULL']"
		[Register ("ERROR_APP_SECRET_NULL")]
		public const string ErrorAppSecretNull = (string) "ERROR_APPSECRET_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ERROR_DEVICETOKEN_NULL']"
		[Register ("ERROR_DEVICETOKEN_NULL")]
		public const string ErrorDevicetokenNull = (string) "ERROR_DEVICETOKEN_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ERROR_NEED_ELECTION']"
		[Register ("ERROR_NEED_ELECTION")]
		public const string ErrorNeedElection = (string) "ERROR_NEED_ELECTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='ERROR_TTID_NULL']"
		[Register ("ERROR_TTID_NULL")]
		public const string ErrorTtidNull = (string) "ERROR_TTID_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='INTENT_FROM_AGOO_MESSAGE']"
		[Register ("INTENT_FROM_AGOO_MESSAGE")]
		public const string IntentFromAgooMessage = (string) "org.agoo.android.intent.action.RECEIVE";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='INTENT_FROM_AGOO_PING']"
		[Register ("INTENT_FROM_AGOO_PING")]
		public const string IntentFromAgooPing = (string) "org.agoo.android.intent.action.PING_V4";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='INTENT_FROM_AGOO_REPORT']"
		[Register ("INTENT_FROM_AGOO_REPORT")]
		public const string IntentFromAgooReport = (string) "org.agoo.android.intent.action.REPORT";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_ACCS_EXTRA']"
		[Register ("MESSAGE_ACCS_EXTRA")]
		public const string MessageAccsExtra = (string) "accs_extra";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_AGOO_BUNDLE']"
		[Register ("MESSAGE_AGOO_BUNDLE")]
		public const string MessageAgooBundle = (string) "msg_agoo_bundle";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_BODY']"
		[Register ("MESSAGE_BODY")]
		public const string MessageBody = (string) "body";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_DUPLICATE']"
		[Register ("MESSAGE_DUPLICATE")]
		public const string MessageDuplicate = (string) "duplicate";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_ENCRYPTED']"
		[Register ("MESSAGE_ENCRYPTED")]
		public const string MessageEncrypted = (string) "encrypted";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_EXT']"
		[Register ("MESSAGE_EXT")]
		public const string MessageExt = (string) "extData";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_FLAG']"
		[Register ("MESSAGE_FLAG")]
		public const string MessageFlag = (string) "flag";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_FROM_APPKEY']"
		[Register ("MESSAGE_FROM_APPKEY")]
		public const string MessageFromAppkey = (string) "fromAppkey";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_FROM_PKG']"
		[Register ("MESSAGE_FROM_PKG")]
		public const string MessageFromPkg = (string) "source";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_HAS_DECRYPTED']"
		[Register ("MESSAGE_HAS_DECRYPTED")]
		public const string MessageHasDecrypted = (string) "has_decrypted";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_HAS_TEST']"
		[Register ("MESSAGE_HAS_TEST")]
		public const string MessageHasTest = (string) "has_test";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_ID']"
		[Register ("MESSAGE_ID")]
		public const string MessageId = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_LOCAL']"
		[Register ("MESSAGE_LOCAL")]
		public const string MessageLocal = (string) "local";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_NOTIFICATION']"
		[Register ("MESSAGE_NOTIFICATION")]
		public const string MessageNotification = (string) "notify";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_OPPO_PAYLOAD']"
		[Register ("MESSAGE_OPPO_PAYLOAD")]
		public const string MessageOppoPayload = (string) "oppo_payload";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_ORI']"
		[Register ("MESSAGE_ORI")]
		public const string MessageOri = (string) "oriData";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_POPUP']"
		[Register ("MESSAGE_POPUP")]
		public const string MessagePopup = (string) "popup";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_REPORT']"
		[Register ("MESSAGE_REPORT")]
		public const string MessageReport = (string) "report";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_SOURCE']"
		[Register ("MESSAGE_SOURCE")]
		public const string MessageSource = (string) "message_source";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_SOURCE_ACCS']"
		[Register ("MESSAGE_SOURCE_ACCS")]
		public const string MessageSourceAccs = (string) "accs";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_SYSTEM_SOURCE_HUAWEI']"
		[Register ("MESSAGE_SYSTEM_SOURCE_HUAWEI")]
		public const string MessageSystemSourceHuawei = (string) "huawei";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_SYSTEM_SOURCE_OPPO']"
		[Register ("MESSAGE_SYSTEM_SOURCE_OPPO")]
		public const string MessageSystemSourceOppo = (string) "oppo";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_TASK_ID']"
		[Register ("MESSAGE_TASK_ID")]
		public const string MessageTaskId = (string) "task_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_TIME']"
		[Register ("MESSAGE_TIME")]
		public const string MessageTime = (string) "time";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_TRACE']"
		[Register ("MESSAGE_TRACE")]
		public const string MessageTrace = (string) "trace";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MESSAGE_TYPE']"
		[Register ("MESSAGE_TYPE")]
		public const string MessageType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='MTOP_ERRCODE_AUTH_REJECT']"
		[Register ("MTOP_ERRCODE_AUTH_REJECT")]
		public const string MtopErrcodeAuthReject = (string) "ERRCODE_AUTH_REJECT";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='REPORT_DUPLICATE_FAIL']"
		[Register ("REPORT_DUPLICATE_FAIL")]
		public const string ReportDuplicateFail = (string) "23";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='REPORT_ENCRYPT_FAIL']"
		[Register ("REPORT_ENCRYPT_FAIL")]
		public const string ReportEncryptFail = (string) "22";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='REPORT_MESSAGE_NULL']"
		[Register ("REPORT_MESSAGE_NULL")]
		public const string ReportMessageNull = (string) "21";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='TAOBAO_PACKAGE']"
		[Register ("TAOBAO_PACKAGE")]
		public const string TaobaoPackage = (string) "com.taobao.taobao";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='AgooConstants']/field[@name='THIRD_PUSH_ID']"
		[Register ("THIRD_PUSH_ID")]
		public const string ThirdPushId = (string) "thirdPushId";
	}

	[Register ("com/taobao/agoo/TaobaoConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TaobaoConstants' type. This type will be removed in a future release.")]
	public abstract class TaobaoConstantsConsts : TaobaoConstants {

		private TaobaoConstantsConsts ()
		{
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common {

	[Register ("com/alibaba/sdk/android/push/common/MpsConstants", DoNotGenerateAcw=true)]
	public abstract class MpsConstants : Java.Lang.Object {

		internal MpsConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='APP_ID']"
		[Register ("APP_ID")]
		public const string AppId = (string) "appId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='CONNECTION_CHANGE_ACTION']"
		[Register ("CONNECTION_CHANGE_ACTION")]
		public const string ConnectionChangeAction = (string) "com.taobao.accs.intent.action.CONNECTINFO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='EXTRA_MAP']"
		[Register ("EXTRA_MAP")]
		public const string ExtraMap = (string) "extraMap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_ACCOUNT']"
		[Register ("KEY_ACCOUNT")]
		public const string KeyAccount = (string) "account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_ALIAS']"
		[Register ("KEY_ALIAS")]
		public const string KeyAlias = (string) "alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_APPKEY']"
		[Register ("KEY_APPKEY")]
		public const string KeyAppkey = (string) "appKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_APPSECRET']"
		[Register ("KEY_APPSECRET")]
		public const string KeyAppsecret = (string) "appSecret";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_DEVICEID']"
		[Register ("KEY_DEVICEID")]
		public const string KeyDeviceid = (string) "deviceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_ENV_OF_STORE']"
		[Register ("KEY_ENV_OF_STORE")]
		public const string KeyEnvOfStore = (string) "MPS_ENV";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_MESSAGE_INTENT_SERVICE']"
		[Register ("KEY_MESSAGE_INTENT_SERVICE")]
		public const string KeyMessageIntentService = (string) "message_intent_service";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_OS']"
		[Register ("KEY_OS")]
		public const string KeyOs = (string) "os";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_PACKAGE']"
		[Register ("KEY_PACKAGE")]
		public const string KeyPackage = (string) "package";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_PHONE_NUMBER']"
		[Register ("KEY_PHONE_NUMBER")]
		public const string KeyPhoneNumber = (string) "mob";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_SEEDKEY']"
		[Register ("KEY_SEEDKEY")]
		public const string KeySeedkey = (string) "seedKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_SIGN']"
		[Register ("KEY_SIGN")]
		public const string KeySign = (string) "sign";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_TAGS']"
		[Register ("KEY_TAGS")]
		public const string KeyTags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_TARGET']"
		[Register ("KEY_TARGET")]
		public const string KeyTarget = (string) "target";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_UTDID']"
		[Register ("KEY_UTDID")]
		public const string KeyUtdid = (string) "utdid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='KEY_VERSION']"
		[Register ("KEY_VERSION")]
		public const string KeyVersion = (string) "version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='MESSAGE_ID']"
		[Register ("MESSAGE_ID")]
		public const string MessageId = (string) "messageId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='NOTIFICATION_ID']"
		[Register ("NOTIFICATION_ID")]
		public const string NotificationId = (string) "notificationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='NOTIFICATION_OPENED_ACTION']"
		[Register ("NOTIFICATION_OPENED_ACTION")]
		public const string NotificationOpenedAction = (string) "com.alibaba.push2.action.NOTIFICATION_OPENED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='NOTIFICATION_OPEN_TYPE']"
		[Register ("NOTIFICATION_OPEN_TYPE")]
		public const string NotificationOpenType = (string) "notificationOpenType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='NOTIFICATION_REMOVED_ACTION']"
		[Register ("NOTIFICATION_REMOVED_ACTION")]
		public const string NotificationRemovedAction = (string) "com.alibaba.push2.action.NOTIFICATION_REMOVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='RECEIVE_ACTION']"
		[Register ("RECEIVE_ACTION")]
		public const string ReceiveAction = (string) "com.alibaba.sdk.android.push.RECEIVE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='SDK_OS']"
		[Register ("SDK_OS")]
		public const string SdkOs = (string) "2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "3.0.12";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='SERVICE_CONTAINER_ACTION']"
		[Register ("SERVICE_CONTAINER_ACTION")]
		public const string ServiceContainerAction = (string) "com.alibaba.sdk.android.push.NOTIFY_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='SUMMARY']"
		[Register ("SUMMARY")]
		public const string Summary = (string) "summary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='TITLE']"
		[Register ("TITLE")]
		public const string Title = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_ADD_ALIAS']"
		[Register ("VIP_API_ADD_ALIAS")]
		public const string VipApiAddAlias = (string) "/add-alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_BIND_ACCOUNT']"
		[Register ("VIP_API_BIND_ACCOUNT")]
		public const string VipApiBindAccount = (string) "/bind-account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_BIND_PHONE_NUMBER']"
		[Register ("VIP_API_BIND_PHONE_NUMBER")]
		public const string VipApiBindPhoneNumber = (string) "/set-phone";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_BIND_TAG']"
		[Register ("VIP_API_BIND_TAG")]
		public const string VipApiBindTag = (string) "/bind-tag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_LIST_ALIAS']"
		[Register ("VIP_API_LIST_ALIAS")]
		public const string VipApiListAlias = (string) "/list-alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_LIST_TAG']"
		[Register ("VIP_API_LIST_TAG")]
		public const string VipApiListTag = (string) "/list-tag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_REMOVE_ALIAS']"
		[Register ("VIP_API_REMOVE_ALIAS")]
		public const string VipApiRemoveAlias = (string) "/remove-alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_UNBIND_ACCOUNT']"
		[Register ("VIP_API_UNBIND_ACCOUNT")]
		public const string VipApiUnbindAccount = (string) "/unbind-account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_UNBIND_PHONE_NUMBER']"
		[Register ("VIP_API_UNBIND_PHONE_NUMBER")]
		public const string VipApiUnbindPhoneNumber = (string) "/unset-phone";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_API_UNBIND_TAG']"
		[Register ("VIP_API_UNBIND_TAG")]
		public const string VipApiUnbindTag = (string) "/unbind-tag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_ON_APP_START']"
		[Register ("VIP_ON_APP_START")]
		public const string VipOnAppStart = (string) "/activeapp.html";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_PUSH_STATUS']"
		[Register ("VIP_PUSH_STATUS")]
		public const string VipPushStatus = (string) "/push-status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_PUSH_SWITCH']"
		[Register ("VIP_PUSH_SWITCH")]
		public const string VipPushSwitch = (string) "/push-switch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common']/interface[@name='MpsConstants']/field[@name='VIP_SCHEME']"
		[Register ("VIP_SCHEME")]
		public const string VipScheme = (string) "http://";
	}

	[Register ("com/alibaba/sdk/android/push/common/MpsConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MpsConstants' type. This type will be removed in a future release.")]
	public abstract class MpsConstantsConsts : MpsConstants {

		private MpsConstantsConsts ()
		{
		}
	}

}

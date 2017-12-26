using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common {

	[Register ("com/alibaba/sdk/android/ams/common/AmsConstants", DoNotGenerateAcw=true)]
	public abstract class AmsConstants : Java.Lang.Object {

		internal AmsConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/interface[@name='AmsConstants']/field[@name='APP_VERSION_MAX_LENGTH']"
		[Register ("APP_VERSION_MAX_LENGTH")]
		public const int AppVersionMaxLength = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common']/interface[@name='AmsConstants']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AMS";
	}

	[Register ("com/alibaba/sdk/android/ams/common/AmsConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AmsConstants' type. This type will be removed in a future release.")]
	public abstract class AmsConstantsConsts : AmsConstants {

		private AmsConstantsConsts ()
		{
		}
	}

}

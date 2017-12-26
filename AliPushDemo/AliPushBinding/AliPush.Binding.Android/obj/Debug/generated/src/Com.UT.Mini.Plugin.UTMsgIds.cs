using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']"
	[global::Android.Runtime.Register ("com/ut/mini/plugin/UTMsgIds", DoNotGenerateAcw=true)]
	public partial class UTMsgIds : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_CRASH_OCCOUR']"
		[Register ("IN_CRASH_OCCOUR")]
		public const int InCrashOccour = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_DISPATCH_AGGREGATION_LOG_MAP']"
		[Register ("IN_DISPATCH_AGGREGATION_LOG_MAP")]
		public const int InDispatchAggregationLogMap = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_DISPATCH_LOG_STRING_4_UTPERF_PLUGIN']"
		[Register ("IN_DISPATCH_LOG_STRING_4_UTPERF_PLUGIN")]
		public const int InDispatchLogString4UtperfPlugin = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_DISPATCH_SIMPLE_LOG_MAP']"
		[Register ("IN_DISPATCH_SIMPLE_LOG_MAP")]
		public const int InDispatchSimpleLogMap = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_LOG_CACHED_4_TEST_MODE']"
		[Register ("IN_LOG_CACHED_4_TEST_MODE")]
		public const int InLogCached4TestMode = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_NOMATCH_ONLINE_CONF']"
		[Register ("IN_NOMATCH_ONLINE_CONF")]
		public const int InNomatchOnlineConf = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_SWITCH_BACKGROUND']"
		[Register ("IN_SWITCH_BACKGROUND")]
		public const int InSwitchBackground = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='IN_SWITCH_FOREGROUND']"
		[Register ("IN_SWITCH_FOREGROUND")]
		public const int InSwitchForeground = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/field[@name='OUT_AGGREGATED_LOG_MAP']"
		[Register ("OUT_AGGREGATED_LOG_MAP")]
		public const int OutAggregatedLogMap = (int) 65536;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/mini/plugin/UTMsgIds", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTMsgIds); }
		}

		protected UTMsgIds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.mini.plugin']/class[@name='UTMsgIds']/constructor[@name='UTMsgIds' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTMsgIds ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTMsgIds)) {
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

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"anetwork/channel/aidl",
						"anetwork/channel/cache",
						"com/alibaba/mtl/appmonitor",
						"com/alibaba/sdk/android/push/channel",
						"org/android/agoo/service",
					},
					new Converter<string, Type>[]{
						lookup_anetwork_channel_aidl_package,
						lookup_anetwork_channel_cache_package,
						lookup_com_alibaba_mtl_appmonitor_package,
						lookup_com_alibaba_sdk_android_push_channel_package,
						lookup_org_android_agoo_service_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_anetwork_channel_aidl_mappings;
		static Type lookup_anetwork_channel_aidl_package (string klass)
		{
			if (package_anetwork_channel_aidl_mappings == null) {
				package_anetwork_channel_aidl_mappings = new string[]{
					"anetwork/channel/aidl/Connection$Stub:Anetwork.Channel.Aidl.ConnectionStub",
					"anetwork/channel/aidl/ParcelableBodyHandler$Stub:Anetwork.Channel.Aidl.ParcelableBodyHandlerStub",
					"anetwork/channel/aidl/ParcelableInputStream$Stub:Anetwork.Channel.Aidl.ParcelableInputStreamStub",
				};
			}

			return Lookup (package_anetwork_channel_aidl_mappings, klass);
		}

		static string[] package_anetwork_channel_cache_mappings;
		static Type lookup_anetwork_channel_cache_package (string klass)
		{
			if (package_anetwork_channel_cache_mappings == null) {
				package_anetwork_channel_cache_mappings = new string[]{
					"anetwork/channel/cache/Cache$Entry:Anetwork.Channel.Cache.CacheEntry",
				};
			}

			return Lookup (package_anetwork_channel_cache_mappings, klass);
		}

		static string[] package_com_alibaba_mtl_appmonitor_mappings;
		static Type lookup_com_alibaba_mtl_appmonitor_package (string klass)
		{
			if (package_com_alibaba_mtl_appmonitor_mappings == null) {
				package_com_alibaba_mtl_appmonitor_mappings = new string[]{
					"com/alibaba/mtl/appmonitor/IMonitor$Stub:Com.Alibaba.Mtl.Appmonitor.MonitorStub",
				};
			}

			return Lookup (package_com_alibaba_mtl_appmonitor_mappings, klass);
		}

		static string[] package_com_alibaba_sdk_android_push_channel_mappings;
		static Type lookup_com_alibaba_sdk_android_push_channel_package (string klass)
		{
			if (package_com_alibaba_sdk_android_push_channel_mappings == null) {
				package_com_alibaba_sdk_android_push_channel_mappings = new string[]{
					"com/alibaba/sdk/android/push/channel/SendMessage$Stub:Com.Alibaba.Sdk.Android.Push.Channel.SendMessageStub",
				};
			}

			return Lookup (package_com_alibaba_sdk_android_push_channel_mappings, klass);
		}

		static string[] package_org_android_agoo_service_mappings;
		static Type lookup_org_android_agoo_service_package (string klass)
		{
			if (package_org_android_agoo_service_mappings == null) {
				package_org_android_agoo_service_mappings = new string[]{
					"org/android/agoo/service/IMessageService$Stub:Org.Android.Agoo.Service.MessageServiceStub",
					"org/android/agoo/service/SendMessage$Stub:Org.Android.Agoo.Service.SendMessageStub",
				};
			}

			return Lookup (package_org_android_agoo_service_mappings, klass);
		}
	}
}

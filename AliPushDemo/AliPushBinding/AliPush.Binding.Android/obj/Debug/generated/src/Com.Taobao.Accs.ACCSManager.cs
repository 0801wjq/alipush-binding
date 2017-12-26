using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']"
	[global::Android.Runtime.Register ("com/taobao/accs/ACCSManager", DoNotGenerateAcw=true)]
	public sealed partial class ACCSManager : global::Java.Lang.Object {


		static IntPtr mAccsInstances_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/field[@name='mAccsInstances']"
		[Register ("mAccsInstances")]
		public static global::System.Collections.IDictionary MAccsInstances {
			get {
				if (mAccsInstances_jfieldId == IntPtr.Zero)
					mAccsInstances_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mAccsInstances", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mAccsInstances_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccsInstances_jfieldId == IntPtr.Zero)
					mAccsInstances_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mAccsInstances", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mAccsInstances_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/field[@name='mContext']"
		[Register ("mContext")]
		public static global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDefaultAppkey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/field[@name='mDefaultAppkey']"
		[Register ("mDefaultAppkey")]
		public static string MDefaultAppkey {
			get {
				if (mDefaultAppkey_jfieldId == IntPtr.Zero)
					mDefaultAppkey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultAppkey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mDefaultAppkey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDefaultAppkey_jfieldId == IntPtr.Zero)
					mDefaultAppkey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultAppkey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, mDefaultAppkey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDefaultConfigTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/field[@name='mDefaultConfigTag']"
		[Register ("mDefaultConfigTag")]
		public static string MDefaultConfigTag {
			get {
				if (mDefaultConfigTag_jfieldId == IntPtr.Zero)
					mDefaultConfigTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultConfigTag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mDefaultConfigTag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDefaultConfigTag_jfieldId == IntPtr.Zero)
					mDefaultConfigTag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultConfigTag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, mDefaultConfigTag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEnv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/field[@name='mEnv']"
		[Register ("mEnv")]
		public static int MEnv {
			get {
				if (mEnv_jfieldId == IntPtr.Zero)
					mEnv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mEnv", "I");
				return JNIEnv.GetStaticIntField (class_ref, mEnv_jfieldId);
			}
			set {
				if (mEnv_jfieldId == IntPtr.Zero)
					mEnv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mEnv", "I");
				try {
					JNIEnv.SetStaticField (class_ref, mEnv_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']"
		[global::Android.Runtime.Register ("com/taobao/accs/ACCSManager$AccsRequest", DoNotGenerateAcw=true)]
		public partial class AccsRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {


			static IntPtr businessId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='businessId']"
			[Register ("businessId")]
			public string BusinessId {
				get {
					if (businessId_jfieldId == IntPtr.Zero)
						businessId_jfieldId = JNIEnv.GetFieldID (class_ref, "businessId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, businessId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (businessId_jfieldId == IntPtr.Zero)
						businessId_jfieldId = JNIEnv.GetFieldID (class_ref, "businessId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, businessId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='data']"
			[Register ("data")]
			public IList<byte> Data {
				get {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr dataId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='dataId']"
			[Register ("dataId")]
			public string DataId {
				get {
					if (dataId_jfieldId == IntPtr.Zero)
						dataId_jfieldId = JNIEnv.GetFieldID (class_ref, "dataId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dataId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (dataId_jfieldId == IntPtr.Zero)
						dataId_jfieldId = JNIEnv.GetFieldID (class_ref, "dataId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr host_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='host']"
			[Register ("host")]
			public global::Java.Net.URL Host {
				get {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/net/URL;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, host_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/net/URL;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, host_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr isUnitBusiness_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='isUnitBusiness']"
			[Register ("isUnitBusiness")]
			public bool IsUnitBusiness {
				get {
					if (isUnitBusiness_jfieldId == IntPtr.Zero)
						isUnitBusiness_jfieldId = JNIEnv.GetFieldID (class_ref, "isUnitBusiness", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isUnitBusiness_jfieldId);
				}
				set {
					if (isUnitBusiness_jfieldId == IntPtr.Zero)
						isUnitBusiness_jfieldId = JNIEnv.GetFieldID (class_ref, "isUnitBusiness", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isUnitBusiness_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr serviceId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='serviceId']"
			[Register ("serviceId")]
			public string ServiceId {
				get {
					if (serviceId_jfieldId == IntPtr.Zero)
						serviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, serviceId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (serviceId_jfieldId == IntPtr.Zero)
						serviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serviceId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr tag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='tag']"
			[Register ("tag")]
			public string Tag {
				get {
					if (tag_jfieldId == IntPtr.Zero)
						tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tag_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tag_jfieldId == IntPtr.Zero)
						tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tag_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr target_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='target']"
			[Register ("target")]
			public string Target {
				get {
					if (target_jfieldId == IntPtr.Zero)
						target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, target_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (target_jfieldId == IntPtr.Zero)
						target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, target_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr targetServiceName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='targetServiceName']"
			[Register ("targetServiceName")]
			public string TargetServiceName {
				get {
					if (targetServiceName_jfieldId == IntPtr.Zero)
						targetServiceName_jfieldId = JNIEnv.GetFieldID (class_ref, "targetServiceName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, targetServiceName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (targetServiceName_jfieldId == IntPtr.Zero)
						targetServiceName_jfieldId = JNIEnv.GetFieldID (class_ref, "targetServiceName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetServiceName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timeout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='timeout']"
			[Register ("timeout")]
			public int Timeout {
				get {
					if (timeout_jfieldId == IntPtr.Zero)
						timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId);
				}
				set {
					if (timeout_jfieldId == IntPtr.Zero)
						timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr userId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/field[@name='userId']"
			[Register ("userId")]
			public string UserId {
				get {
					if (userId_jfieldId == IntPtr.Zero)
						userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (userId_jfieldId == IntPtr.Zero)
						userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/ACCSManager$AccsRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AccsRequest); }
			}

			protected AccsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/constructor[@name='ACCSManager.AccsRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)V", "")]
			public unsafe AccsRequest (string p0, string p1, byte[] p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (AccsRequest)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/constructor[@name='ACCSManager.AccsRequest' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.net.URL'] and parameter[7][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V", "")]
			public unsafe AccsRequest (string p0, string p1, byte[] p2, string p3, string p4, global::Java.Net.URL p5, string p6)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				IntPtr native_p4 = JNIEnv.NewString (p4);
				IntPtr native_p6 = JNIEnv.NewString (p6);
				try {
					JValue* __args = stackalloc JValue [7];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (native_p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (native_p6);
					if (((object) this).GetType () != typeof (AccsRequest)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}

			static Delegate cb_setBusinessId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBusinessId_Ljava_lang_String_Handler ()
			{
				if (cb_setBusinessId_Ljava_lang_String_ == null)
					cb_setBusinessId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBusinessId_Ljava_lang_String_);
				return cb_setBusinessId_Ljava_lang_String_;
			}

			static void n_SetBusinessId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetBusinessId (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setBusinessId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setBusinessId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBusinessId", "(Ljava/lang/String;)V", "GetSetBusinessId_Ljava_lang_String_Handler")]
			public virtual unsafe void SetBusinessId (string p0)
			{
				if (id_setBusinessId_Ljava_lang_String_ == IntPtr.Zero)
					id_setBusinessId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBusinessId", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBusinessId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBusinessId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setHost_Ljava_net_URL_;
#pragma warning disable 0169
			static Delegate GetSetHost_Ljava_net_URL_Handler ()
			{
				if (cb_setHost_Ljava_net_URL_ == null)
					cb_setHost_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_net_URL_);
				return cb_setHost_Ljava_net_URL_;
			}

			static void n_SetHost_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetHost (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setHost_Ljava_net_URL_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("setHost", "(Ljava/net/URL;)V", "GetSetHost_Ljava_net_URL_Handler")]
			public virtual unsafe void SetHost (global::Java.Net.URL p0)
			{
				if (id_setHost_Ljava_net_URL_ == IntPtr.Zero)
					id_setHost_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/net/URL;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHost_Ljava_net_URL_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/net/URL;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setIsUnitBusiness_Z;
#pragma warning disable 0169
			static Delegate GetSetIsUnitBusiness_ZHandler ()
			{
				if (cb_setIsUnitBusiness_Z == null)
					cb_setIsUnitBusiness_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsUnitBusiness_Z);
				return cb_setIsUnitBusiness_Z;
			}

			static void n_SetIsUnitBusiness_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetIsUnitBusiness (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setIsUnitBusiness_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setIsUnitBusiness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsUnitBusiness", "(Z)V", "GetSetIsUnitBusiness_ZHandler")]
			public virtual unsafe void SetIsUnitBusiness (bool p0)
			{
				if (id_setIsUnitBusiness_Z == IntPtr.Zero)
					id_setIsUnitBusiness_Z = JNIEnv.GetMethodID (class_ref, "setIsUnitBusiness", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsUnitBusiness_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsUnitBusiness", "(Z)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTag_Ljava_lang_String_Handler ()
			{
				if (cb_setTag_Ljava_lang_String_ == null)
					cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_String_);
				return cb_setTag_Ljava_lang_String_;
			}

			static void n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTag (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setTag_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTag", "(Ljava/lang/String;)V", "GetSetTag_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTag (string p0)
			{
				if (id_setTag_Ljava_lang_String_ == IntPtr.Zero)
					id_setTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTag", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setTarget_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTarget_Ljava_lang_String_Handler ()
			{
				if (cb_setTarget_Ljava_lang_String_ == null)
					cb_setTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTarget_Ljava_lang_String_);
				return cb_setTarget_Ljava_lang_String_;
			}

			static void n_SetTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTarget (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setTarget_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTarget", "(Ljava/lang/String;)V", "GetSetTarget_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTarget (string p0)
			{
				if (id_setTarget_Ljava_lang_String_ == IntPtr.Zero)
					id_setTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTarget", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTarget_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTarget", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setTargetServiceName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTargetServiceName_Ljava_lang_String_Handler ()
			{
				if (cb_setTargetServiceName_Ljava_lang_String_ == null)
					cb_setTargetServiceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTargetServiceName_Ljava_lang_String_);
				return cb_setTargetServiceName_Ljava_lang_String_;
			}

			static void n_SetTargetServiceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetTargetServiceName (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setTargetServiceName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setTargetServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTargetServiceName", "(Ljava/lang/String;)V", "GetSetTargetServiceName_Ljava_lang_String_Handler")]
			public virtual unsafe void SetTargetServiceName (string p0)
			{
				if (id_setTargetServiceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setTargetServiceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTargetServiceName", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTargetServiceName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTargetServiceName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setTimeOut_I;
#pragma warning disable 0169
			static Delegate GetSetTimeOut_IHandler ()
			{
				if (cb_setTimeOut_I == null)
					cb_setTimeOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeOut_I);
				return cb_setTimeOut_I;
			}

			static void n_SetTimeOut_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Taobao.Accs.ACCSManager.AccsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ACCSManager.AccsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetTimeOut (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setTimeOut_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager.AccsRequest']/method[@name='setTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeOut", "(I)V", "GetSetTimeOut_IHandler")]
			public virtual unsafe void SetTimeOut (int p0)
			{
				if (id_setTimeOut_I == IntPtr.Zero)
					id_setTimeOut_I = JNIEnv.GetMethodID (class_ref, "setTimeOut", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOut_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeOut", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/ACCSManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ACCSManager); }
		}

		internal ACCSManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='bindApp' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "")]
		public static unsafe void BindApp (global::Android.Content.Context p0, string p1, string p2, global::Com.Taobao.Accs.IAppReceiver p3)
		{
			if (id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='bindApp' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "")]
		public static unsafe void BindApp (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Taobao.Accs.IAppReceiver p4)
		{
			if (id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "bindApp", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindApp_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_bindService_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='bindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindService", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void BindService (global::Android.Content.Context p0, string p1)
		{
			if (id_bindService_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_bindService_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "bindService", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindService_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_bindUser_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='bindUser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindUser", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void BindUser (global::Android.Content.Context p0, string p1)
		{
			if (id_bindUser_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_bindUser_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "bindUser", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindUser_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_bindUser_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='bindUser' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("bindUser", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public static unsafe void BindUser (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_bindUser_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_bindUser_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "bindUser", "(Landroid/content/Context;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindUser_Landroid_content_Context_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_clearLoginInfoImpl_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='clearLoginInfoImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLoginInfoImpl", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearLoginInfoImpl (global::Android.Content.Context p0)
		{
			if (id_clearLoginInfoImpl_Landroid_content_Context_ == IntPtr.Zero)
				id_clearLoginInfoImpl_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearLoginInfoImpl", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLoginInfoImpl_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_createInner_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='createInner' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createInner", "(Landroid/content/Context;Ljava/lang/String;)Lcom/taobao/accs/IACCSManager;", "")]
		protected static unsafe global::Com.Taobao.Accs.IACCSManager CreateInner (global::Android.Content.Context p0, string p1)
		{
			if (id_createInner_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createInner_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createInner", "(Landroid/content/Context;Ljava/lang/String;)Lcom/taobao/accs/IACCSManager;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Taobao.Accs.IACCSManager __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IACCSManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInner_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_forceDisableService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='forceDisableService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("forceDisableService", "(Landroid/content/Context;)V", "")]
		public static unsafe void ForceDisableService (global::Android.Content.Context p0)
		{
			if (id_forceDisableService_Landroid_content_Context_ == IntPtr.Zero)
				id_forceDisableService_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "forceDisableService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_forceDisableService_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_forceEnableService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='forceEnableService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("forceEnableService", "(Landroid/content/Context;)V", "")]
		public static unsafe void ForceEnableService (global::Android.Content.Context p0)
		{
			if (id_forceEnableService_Landroid_content_Context_ == IntPtr.Zero)
				id_forceEnableService_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "forceEnableService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_forceEnableService_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_forceReConnectChannel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='forceReConnectChannel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("forceReConnectChannel", "(Landroid/content/Context;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> ForceReConnectChannel (global::Android.Content.Context p0)
		{
			if (id_forceReConnectChannel_Landroid_content_Context_ == IntPtr.Zero)
				id_forceReConnectChannel_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "forceReConnectChannel", "(Landroid/content/Context;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_forceReConnectChannel_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAccsInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getAccsInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAccsInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/IACCSManager;", "")]
		public static unsafe global::Com.Taobao.Accs.IACCSManager GetAccsInstance (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getAccsInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccsInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAccsInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/IACCSManager;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Taobao.Accs.IACCSManager __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IACCSManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccsInstance_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getAppkey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppkey", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetAppkey (global::Android.Content.Context p0)
		{
			if (id_getAppkey_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppkey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppkey", "(Landroid/content/Context;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppkey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getChannelState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getChannelState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChannelState", "(Landroid/content/Context;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> GetChannelState (global::Android.Content.Context p0)
		{
			if (id_getChannelState_Landroid_content_Context_ == IntPtr.Zero)
				id_getChannelState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getChannelState", "(Landroid/content/Context;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannelState_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDefaultAppkey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getDefaultAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDefaultAppkey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDefaultAppkey (global::Android.Content.Context p0)
		{
			if (id_getDefaultAppkey_Landroid_content_Context_ == IntPtr.Zero)
				id_getDefaultAppkey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDefaultAppkey", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultAppkey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDefaultConfig_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getDefaultConfig' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDefaultConfig", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDefaultConfig (global::Android.Content.Context p0)
		{
			if (id_getDefaultConfig_Landroid_content_Context_ == IntPtr.Zero)
				id_getDefaultConfig_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDefaultConfig", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultConfig_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserUnit_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='getUserUnit' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUserUnit", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUserUnit (global::Android.Content.Context p0)
		{
			if (id_getUserUnit_Landroid_content_Context_ == IntPtr.Zero)
				id_getUserUnit_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUserUnit", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserUnit_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isChannelError_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='isChannelError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("isChannelError", "(Landroid/content/Context;I)Z", "")]
		public static unsafe bool IsChannelError (global::Android.Content.Context p0, int p1)
		{
			if (id_isChannelError_Landroid_content_Context_I == IntPtr.Zero)
				id_isChannelError_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "isChannelError", "(Landroid/content/Context;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isChannelError_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkReachable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='isNetworkReachable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkReachable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkReachable (global::Android.Content.Context p0)
		{
			if (id_isNetworkReachable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkReachable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkReachable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkReachable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='registerDataListener' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.base.AccsAbstractDataListener']]"
		[Register ("registerDataListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V", "")]
		public static unsafe void RegisterDataListener (global::Android.Content.Context p0, string p1, global::Com.Taobao.Accs.Base.AccsAbstractDataListener p2)
		{
			if (id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == IntPtr.Zero)
				id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNIEnv.GetStaticMethodID (class_ref, "registerDataListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerDataListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='registerSerivce' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerSerivce", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void RegisterSerivce (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "registerSerivce", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerSerivce_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendData", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "")]
		public static unsafe string SendData (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1)
		{
			if (id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "sendData", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendData_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendData' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendData' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendData' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.net.URL']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;", "")]
		public static unsafe string SendData (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5, global::Java.Net.URL p6)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendData_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendPushResponse' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("sendPushResponse", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;", "")]
		public static unsafe string SendPushResponse (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetStaticMethodID (class_ref, "sendPushResponse", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;Lcom/taobao/accs/base/TaoBaseService$ExtraInfo;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendPushResponse_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_Lcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ACCSManager.AccsRequest']]"
		[Register ("sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;", "")]
		public static unsafe string SendRequest (global::Android.Content.Context p0, global::Com.Taobao.Accs.ACCSManager.AccsRequest p1)
		{
			if (id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Lcom/taobao/accs/ACCSManager$AccsRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendRequest_Landroid_content_Context_Lcom_taobao_accs_ACCSManager_AccsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendRequest' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SendRequest (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4)
		{
			if (id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendRequest' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SendRequest (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5)
		{
			if (id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='sendRequest' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.net.URL']]"
		[Register ("sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;", "")]
		public static unsafe string SendRequest (global::Android.Content.Context p0, string p1, string p2, byte[] p3, string p4, string p5, global::Java.Net.URL p6)
		{
			if (id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ == IntPtr.Zero)
				id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "sendRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sendRequest_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_setAppkey_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setAppkey' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setAppkey", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void SetAppkey (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_setAppkey_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_setAppkey_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setAppkey", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppkey_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setDefaultConfig_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setDefaultConfig' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDefaultConfig", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetDefaultConfig (global::Android.Content.Context p0, string p1)
		{
			if (id_setDefaultConfig_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultConfig_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultConfig", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultConfig_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setLoginInfoImpl_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setLoginInfoImpl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.taobao.accs.ILoginInfo']]"
		[Register ("setLoginInfoImpl", "(Landroid/content/Context;Lcom/taobao/accs/ILoginInfo;)V", "")]
		public static unsafe void SetLoginInfoImpl (global::Android.Content.Context p0, global::Com.Taobao.Accs.ILoginInfo p1)
		{
			if (id_setLoginInfoImpl_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ == IntPtr.Zero)
				id_setLoginInfoImpl_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_ = JNIEnv.GetStaticMethodID (class_ref, "setLoginInfoImpl", "(Landroid/content/Context;Lcom/taobao/accs/ILoginInfo;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLoginInfoImpl_Landroid_content_Context_Lcom_taobao_accs_ILoginInfo_, __args);
			} finally {
			}
		}

		static IntPtr id_setMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setMode", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setMode_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setMode", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMode_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_setProxy_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setProxy' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setProxy", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void SetProxy (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_setProxy_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_setProxy_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setProxy", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setProxy_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setServiceListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_IServiceReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='setServiceListener' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.IServiceReceiver']]"
		[Register ("setServiceListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/IServiceReceiver;)V", "")]
		public static unsafe void SetServiceListener (global::Android.Content.Context p0, string p1, global::Com.Taobao.Accs.IServiceReceiver p2)
		{
			if (id_setServiceListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_IServiceReceiver_ == IntPtr.Zero)
				id_setServiceListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_IServiceReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "setServiceListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/taobao/accs/IServiceReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setServiceListener_Landroid_content_Context_Ljava_lang_String_Lcom_taobao_accs_IServiceReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='startInAppConnection' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "")]
		public static unsafe void StartInAppConnection (global::Android.Content.Context p0, string p1, string p2, global::Com.Taobao.Accs.IAppReceiver p3)
		{
			if (id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='startInAppConnection' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "")]
		public static unsafe void StartInAppConnection (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Taobao.Accs.IAppReceiver p4)
		{
			if (id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetStaticMethodID (class_ref, "startInAppConnection", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startInAppConnection_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='unRegisterDataListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unRegisterDataListener", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void UnRegisterDataListener (global::Android.Content.Context p0, string p1)
		{
			if (id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unRegisterDataListener", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unRegisterDataListener_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_unbindApp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='unbindApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unbindApp", "(Landroid/content/Context;)V", "")]
		public static unsafe void UnbindApp (global::Android.Content.Context p0)
		{
			if (id_unbindApp_Landroid_content_Context_ == IntPtr.Zero)
				id_unbindApp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "unbindApp", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unbindApp_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_unbindService_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='unbindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unbindService", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void UnbindService (global::Android.Content.Context p0, string p1)
		{
			if (id_unbindService_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unbindService_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unbindService", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unbindService_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_unbindUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='unbindUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unbindUser", "(Landroid/content/Context;)V", "")]
		public static unsafe void UnbindUser (global::Android.Content.Context p0)
		{
			if (id_unbindUser_Landroid_content_Context_ == IntPtr.Zero)
				id_unbindUser_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "unbindUser", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unbindUser_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterService_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ACCSManager']/method[@name='unregisterService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unregisterService", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterService (global::Android.Content.Context p0, string p1)
		{
			if (id_unregisterService_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterService_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterService", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterService_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

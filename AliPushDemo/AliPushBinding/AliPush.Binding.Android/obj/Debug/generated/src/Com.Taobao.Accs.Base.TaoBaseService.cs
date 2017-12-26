using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']"
	[global::Android.Runtime.Register ("com/taobao/accs/base/TaoBaseService", DoNotGenerateAcw=true)]
	public abstract partial class TaoBaseService : global::Android.App.Service, global::Com.Taobao.Accs.Base.IAccsDataListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']"
		[global::Android.Runtime.Register ("com/taobao/accs/base/TaoBaseService$ConnectInfo", DoNotGenerateAcw=true)]
		public partial class ConnectInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {


			static IntPtr connected_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='connected']"
			[Register ("connected")]
			public bool Connected {
				get {
					if (connected_jfieldId == IntPtr.Zero)
						connected_jfieldId = JNIEnv.GetFieldID (class_ref, "connected", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, connected_jfieldId);
				}
				set {
					if (connected_jfieldId == IntPtr.Zero)
						connected_jfieldId = JNIEnv.GetFieldID (class_ref, "connected", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connected_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr errorCode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='errorCode']"
			[Register ("errorCode")]
			public int ErrorCode {
				get {
					if (errorCode_jfieldId == IntPtr.Zero)
						errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, errorCode_jfieldId);
				}
				set {
					if (errorCode_jfieldId == IntPtr.Zero)
						errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, errorCode_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr errordetail_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='errordetail']"
			[Register ("errordetail")]
			public string Errordetail {
				get {
					if (errordetail_jfieldId == IntPtr.Zero)
						errordetail_jfieldId = JNIEnv.GetFieldID (class_ref, "errordetail", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, errordetail_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (errordetail_jfieldId == IntPtr.Zero)
						errordetail_jfieldId = JNIEnv.GetFieldID (class_ref, "errordetail", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, errordetail_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr host_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='host']"
			[Register ("host")]
			public string Host {
				get {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, host_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, host_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr isCenterHost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='isCenterHost']"
			[Register ("isCenterHost")]
			public bool IsCenterHost {
				get {
					if (isCenterHost_jfieldId == IntPtr.Zero)
						isCenterHost_jfieldId = JNIEnv.GetFieldID (class_ref, "isCenterHost", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isCenterHost_jfieldId);
				}
				set {
					if (isCenterHost_jfieldId == IntPtr.Zero)
						isCenterHost_jfieldId = JNIEnv.GetFieldID (class_ref, "isCenterHost", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isCenterHost_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isInapp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/field[@name='isInapp']"
			[Register ("isInapp")]
			public bool IsInapp {
				get {
					if (isInapp_jfieldId == IntPtr.Zero)
						isInapp_jfieldId = JNIEnv.GetFieldID (class_ref, "isInapp", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isInapp_jfieldId);
				}
				set {
					if (isInapp_jfieldId == IntPtr.Zero)
						isInapp_jfieldId = JNIEnv.GetFieldID (class_ref, "isInapp", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isInapp_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/base/TaoBaseService$ConnectInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectInfo); }
			}

			protected ConnectInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_ZZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/constructor[@name='TaoBaseService.ConnectInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;ZZ)V", "")]
			public unsafe ConnectInfo (string p0, bool p1, bool p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (ConnectInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ZZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ZZ)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ZZ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ZZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ZZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ZZ, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_ZZILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ConnectInfo']/constructor[@name='TaoBaseService.ConnectInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;ZZILjava/lang/String;)V", "")]
			public unsafe ConnectInfo (string p0, bool p1, bool p2, int p3, string p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p4 = JNIEnv.NewString (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (native_p4);
					if (((object) this).GetType () != typeof (ConnectInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ZZILjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ZZILjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ZZILjava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ZZILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ZZILjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ZZILjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ZZILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']"
		[global::Android.Runtime.Register ("com/taobao/accs/base/TaoBaseService$ExtHeaderType", DoNotGenerateAcw=true)]
		public sealed partial class ExtHeaderType : global::Java.Lang.Enum {


			static IntPtr TYPE_BUSINESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_BUSINESS']"
			[Register ("TYPE_BUSINESS")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeBusiness {
				get {
					if (TYPE_BUSINESS_jfieldId == IntPtr.Zero)
						TYPE_BUSINESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_BUSINESS", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_BUSINESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_COOKIE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_COOKIE']"
			[Register ("TYPE_COOKIE")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeCookie {
				get {
					if (TYPE_COOKIE_jfieldId == IntPtr.Zero)
						TYPE_COOKIE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_COOKIE", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_COOKIE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_DELAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_DELAY']"
			[Register ("TYPE_DELAY")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeDelay {
				get {
					if (TYPE_DELAY_jfieldId == IntPtr.Zero)
						TYPE_DELAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_DELAY", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_DELAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_EXPIRE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_EXPIRE']"
			[Register ("TYPE_EXPIRE")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeExpire {
				get {
					if (TYPE_EXPIRE_jfieldId == IntPtr.Zero)
						TYPE_EXPIRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_EXPIRE", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_EXPIRE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_LOCATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_LOCATION']"
			[Register ("TYPE_LOCATION")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeLocation {
				get {
					if (TYPE_LOCATION_jfieldId == IntPtr.Zero)
						TYPE_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_LOCATION", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_LOCATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_NEED_BUSINESS_ACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_NEED_BUSINESS_ACK']"
			[Register ("TYPE_NEED_BUSINESS_ACK")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeNeedBusinessAck {
				get {
					if (TYPE_NEED_BUSINESS_ACK_jfieldId == IntPtr.Zero)
						TYPE_NEED_BUSINESS_ACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_NEED_BUSINESS_ACK", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_NEED_BUSINESS_ACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_SID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_SID']"
			[Register ("TYPE_SID")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeSid {
				get {
					if (TYPE_SID_jfieldId == IntPtr.Zero)
						TYPE_SID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_SID", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_SID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_STATUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_STATUS']"
			[Register ("TYPE_STATUS")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeStatus {
				get {
					if (TYPE_STATUS_jfieldId == IntPtr.Zero)
						TYPE_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_STATUS", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_STATUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_TAG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_TAG']"
			[Register ("TYPE_TAG")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeTag {
				get {
					if (TYPE_TAG_jfieldId == IntPtr.Zero)
						TYPE_TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_TAG", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_TAG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_UNIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_UNIT']"
			[Register ("TYPE_UNIT")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeUnit {
				get {
					if (TYPE_UNIT_jfieldId == IntPtr.Zero)
						TYPE_UNIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_UNIT", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_UNIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_USERID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/field[@name='TYPE_USERID']"
			[Register ("TYPE_USERID")]
			public static global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType TypeUserid {
				get {
					if (TYPE_USERID_jfieldId == IntPtr.Zero)
						TYPE_USERID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_USERID", "Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_USERID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/base/TaoBaseService$ExtHeaderType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtHeaderType); }
			}

			internal ExtHeaderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;", "")]
			public static unsafe global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;", "")]
			public static unsafe global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtHeaderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;", "")]
			public static unsafe global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/taobao/accs/base/TaoBaseService$ExtHeaderType;");
				try {
					return (global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']"
		[global::Android.Runtime.Register ("com/taobao/accs/base/TaoBaseService$ExtraInfo", DoNotGenerateAcw=true)]
		public partial class ExtraInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {


			static IntPtr connType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']/field[@name='connType']"
			[Register ("connType")]
			public int ConnType {
				get {
					if (connType_jfieldId == IntPtr.Zero)
						connType_jfieldId = JNIEnv.GetFieldID (class_ref, "connType", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, connType_jfieldId);
				}
				set {
					if (connType_jfieldId == IntPtr.Zero)
						connType_jfieldId = JNIEnv.GetFieldID (class_ref, "connType", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connType_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr extHeader_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']/field[@name='extHeader']"
			[Register ("extHeader")]
			public global::System.Collections.IDictionary ExtHeader {
				get {
					if (extHeader_jfieldId == IntPtr.Zero)
						extHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "extHeader", "Ljava/util/Map;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, extHeader_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (extHeader_jfieldId == IntPtr.Zero)
						extHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "extHeader", "Ljava/util/Map;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, extHeader_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr fromHost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']/field[@name='fromHost']"
			[Register ("fromHost")]
			public string FromHost {
				get {
					if (fromHost_jfieldId == IntPtr.Zero)
						fromHost_jfieldId = JNIEnv.GetFieldID (class_ref, "fromHost", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fromHost_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (fromHost_jfieldId == IntPtr.Zero)
						fromHost_jfieldId = JNIEnv.GetFieldID (class_ref, "fromHost", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fromHost_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr fromPackage_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']/field[@name='fromPackage']"
			[Register ("fromPackage")]
			public string FromPackage {
				get {
					if (fromPackage_jfieldId == IntPtr.Zero)
						fromPackage_jfieldId = JNIEnv.GetFieldID (class_ref, "fromPackage", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fromPackage_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (fromPackage_jfieldId == IntPtr.Zero)
						fromPackage_jfieldId = JNIEnv.GetFieldID (class_ref, "fromPackage", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fromPackage_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/base/TaoBaseService$ExtraInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtraInfo); }
			}

			protected ExtraInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService.ExtraInfo']/constructor[@name='TaoBaseService.ExtraInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ExtraInfo ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (ExtraInfo)) {
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/base/TaoBaseService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaoBaseService); }
		}

		protected TaoBaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']/constructor[@name='TaoBaseService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaoBaseService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TaoBaseService)) {
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

		static Delegate cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAntiBrush (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']/method[@name='onAntiBrush' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public virtual unsafe void OnAntiBrush (bool p0, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p1)
		{
			if (id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAntiBrush_ZLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAntiBrush", "(ZLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler ()
		{
			if (cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == null)
				cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_);
			return cb_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		}

		static void n_OnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler")]
		public virtual unsafe void OnConnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler ()
		{
			if (cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == null)
				cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_);
			return cb_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		}

		static void n_OnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/class[@name='TaoBaseService']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='com.taobao.accs.base.TaoBaseService.ConnectInfo']]"
		[Register ("onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V", "GetOnDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_Handler")]
		public virtual unsafe void OnDisconnected (global::Com.Taobao.Accs.Base.TaoBaseService.ConnectInfo p0)
		{
			if (id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ == IntPtr.Zero)
				id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_ = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Lcom_taobao_accs_base_TaoBaseService_ConnectInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnected", "(Lcom/taobao/accs/base/TaoBaseService$ConnectInfo;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

		static Delegate cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

		static Delegate cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4);

		static Delegate cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnSendData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3);

		static Delegate cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
#pragma warning disable 0169
		static Delegate GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler ()
		{
			if (cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == null)
				cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_);
			return cb_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		}

		static void n_OnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Base.TaoBaseService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public abstract void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/base/TaoBaseService", DoNotGenerateAcw=true)]
	internal partial class TaoBaseServiceInvoker : TaoBaseService {

		public TaoBaseServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaoBaseServiceInvoker); }
		}

		static IntPtr id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onBind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnBind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnData (string p0, string p1, string p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnResponse (string p0, string p1, int p2, byte[] p3, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p4)
		{
			if (id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/String;Ljava/lang/String;I[BLcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_lang_String_Ljava_lang_String_IarrayBLcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnSendData (string p0, string p1, int p2, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p3)
		{
			if (id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onSendData", "(Ljava/lang/String;Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendData_Ljava_lang_String_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.base']/interface[@name='AccsDataListener']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.taobao.accs.base.TaoBaseService.ExtraInfo']]"
		[Register ("onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V", "GetOnUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_Handler")]
		public override unsafe void OnUnbind (string p0, int p1, global::Com.Taobao.Accs.Base.TaoBaseService.ExtraInfo p2)
		{
			if (id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ == IntPtr.Zero)
				id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Ljava/lang/String;ILcom/taobao/accs/base/TaoBaseService$ExtraInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Ljava_lang_String_ILcom_taobao_accs_base_TaoBaseService_ExtraInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/common/util/sendrequest/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object {


		static IntPtr rsBody_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']/field[@name='rsBody']"
		[Register ("rsBody")]
		public string RsBody {
			get {
				if (rsBody_jfieldId == IntPtr.Zero)
					rsBody_jfieldId = JNIEnv.GetFieldID (class_ref, "rsBody", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rsBody_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rsBody_jfieldId == IntPtr.Zero)
					rsBody_jfieldId = JNIEnv.GetFieldID (class_ref, "rsBody", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rsBody_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rsCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']/field[@name='rsCode']"
		[Register ("rsCode")]
		public int RsCode {
			get {
				if (rsCode_jfieldId == IntPtr.Zero)
					rsCode_jfieldId = JNIEnv.GetFieldID (class_ref, "rsCode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, rsCode_jfieldId);
			}
			set {
				if (rsCode_jfieldId == IntPtr.Zero)
					rsCode_jfieldId = JNIEnv.GetFieldID (class_ref, "rsCode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rsCode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr rsType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']/field[@name='rsType']"
		[Register ("rsType")]
		public global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType RsType {
			get {
				if (rsType_jfieldId == IntPtr.Zero)
					rsType_jfieldId = JNIEnv.GetFieldID (class_ref, "rsType", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rsType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.VipRequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rsType_jfieldId == IntPtr.Zero)
					rsType_jfieldId = JNIEnv.GetFieldID (class_ref, "rsType", "Lcom/alibaba/sdk/android/push/common/util/sendrequest/VipRequestType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rsType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/common/util/sendrequest/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']/constructor[@name='Response' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Response ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Response)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='Response']/constructor[@name='Response' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Response (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Response)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

	}
}

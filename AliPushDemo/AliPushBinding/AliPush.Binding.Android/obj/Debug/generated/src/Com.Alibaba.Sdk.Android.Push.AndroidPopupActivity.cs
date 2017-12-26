using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AndroidPopupActivity']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/AndroidPopupActivity", DoNotGenerateAcw=true)]
	public abstract partial class AndroidPopupActivity : global::Com.Taobao.Agoo.BaseNotifyClickActivity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/AndroidPopupActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidPopupActivity); }
		}

		protected AndroidPopupActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AndroidPopupActivity']/constructor[@name='AndroidPopupActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidPopupActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AndroidPopupActivity)) {
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

		static Delegate cb_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_OnSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Sdk.Android.Push.AndroidPopupActivity __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.AndroidPopupActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnSysNoticeOpened (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AndroidPopupActivity']/method[@name='onSysNoticeOpened' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSysNoticeOpened", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetOnSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected abstract void OnSysNoticeOpened (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/AndroidPopupActivity", DoNotGenerateAcw=true)]
	internal partial class AndroidPopupActivityInvoker : AndroidPopupActivity {

		public AndroidPopupActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidPopupActivityInvoker); }
		}

		static IntPtr id_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='AndroidPopupActivity']/method[@name='onSysNoticeOpened' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSysNoticeOpened", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetOnSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected override unsafe void OnSysNoticeOpened (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSysNoticeOpened", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSysNoticeOpened_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}

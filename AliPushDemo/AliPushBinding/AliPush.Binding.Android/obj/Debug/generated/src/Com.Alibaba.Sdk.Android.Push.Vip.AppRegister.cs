using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Vip {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/vip/AppRegister", DoNotGenerateAcw=true)]
	public partial class AppRegister : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister.NetworkChangeBroadcastReceiver']"
		[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/vip/AppRegister$NetworkChangeBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class NetworkChangeBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/sdk/android/push/vip/AppRegister$NetworkChangeBroadcastReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkChangeBroadcastReceiver); }
			}

			protected NetworkChangeBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Alibaba.Sdk.Android.Push.Vip.AppRegister.NetworkChangeBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Vip.AppRegister.NetworkChangeBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister.NetworkChangeBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/vip/AppRegister", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppRegister); }
		}

		protected AppRegister (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/alibaba/sdk/android/push/vip/AppRegister;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Push.Vip.AppRegister A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lcom/alibaba/sdk/android/push/vip/AppRegister;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Vip.AppRegister> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Lcom_alibaba_sdk_android_push_CommonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.push.CommonCallback']]"
		[Register ("a", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V", "")]
		public unsafe void A (global::Com.Alibaba.Sdk.Android.Push.ICommonCallback p0)
		{
			if (id_a_Lcom_alibaba_sdk_android_push_CommonCallback_ == IntPtr.Zero)
				id_a_Lcom_alibaba_sdk_android_push_CommonCallback_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/alibaba/sdk/android/push/CommonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_alibaba_sdk_android_push_CommonCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public unsafe bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.vip']/class[@name='AppRegister']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public static unsafe bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_c);
			} finally {
			}
		}

	}
}

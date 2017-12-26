using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='HuaWeiReceiver']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/HuaWeiReceiver", DoNotGenerateAcw=true)]
	public partial class HuaWeiReceiver : global::Com.Huawei.Android.Pushagent.PushReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='HuaWeiReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPS:HuaWeiRegister";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/HuaWeiReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HuaWeiReceiver); }
		}

		protected HuaWeiReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='HuaWeiReceiver']/constructor[@name='HuaWeiReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaWeiReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HuaWeiReceiver)) {
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

		static Delegate cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_Handler ()
		{
			if (cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ == null)
				cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_);
			return cb_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
		}

		static void n_OnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_msg, IntPtr native_arg2)
		{
			global::Com.Alibaba.Sdk.Android.Push.HuaWeiReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.HuaWeiReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			byte[] msg = (byte[]) JNIEnv.GetArray (native_msg, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string arg2 = JNIEnv.GetString (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.OnPushMsg (context, msg, arg2);
			if (msg != null)
				JNIEnv.CopyArray (msg, native_msg);
		}
#pragma warning restore 0169

		static IntPtr id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='HuaWeiReceiver']/method[@name='onPushMsg' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V", "GetOnPushMsg_Landroid_content_Context_arrayBLjava_lang_String_Handler")]
		public override unsafe void OnPushMsg (global::Android.Content.Context context, byte[] msg, string arg2)
		{
			if (id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V");
			IntPtr native_msg = JNIEnv.NewArray (msg);
			IntPtr native_arg2 = JNIEnv.NewString (arg2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (native_arg2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPushMsg_Landroid_content_Context_arrayBLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPushMsg", "(Landroid/content/Context;[BLjava/lang/String;)V"), __args);
			} finally {
				if (msg != null) {
					JNIEnv.CopyArray (native_msg, msg);
					JNIEnv.DeleteLocalRef (native_msg);
				}
				JNIEnv.DeleteLocalRef (native_arg2);
			}
		}

		static Delegate cb_onToken_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnToken_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_onToken_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_onToken_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnToken_Landroid_content_Context_Ljava_lang_String_);
			return cb_onToken_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_OnToken_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_token)
		{
			global::Com.Alibaba.Sdk.Android.Push.HuaWeiReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.HuaWeiReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.OnToken (context, token);
		}
#pragma warning restore 0169

		static IntPtr id_onToken_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/class[@name='HuaWeiReceiver']/method[@name='onToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onToken", "(Landroid/content/Context;Ljava/lang/String;)V", "GetOnToken_Landroid_content_Context_Ljava_lang_String_Handler")]
		public override unsafe void OnToken (global::Android.Content.Context context, string token)
		{
			if (id_onToken_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onToken_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onToken", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onToken_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onToken", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

	}
}

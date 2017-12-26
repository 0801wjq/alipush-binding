using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.impl']/class[@name='HuaweiMsgParseImpl']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/impl/HuaweiMsgParseImpl", DoNotGenerateAcw=true)]
	public partial class HuaweiMsgParseImpl : global::Java.Lang.Object, global::Com.Taobao.Agoo.BaseNotifyClickActivity.INotifyListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/impl/HuaweiMsgParseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HuaweiMsgParseImpl); }
		}

		protected HuaweiMsgParseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.impl']/class[@name='HuaweiMsgParseImpl']/constructor[@name='HuaweiMsgParseImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiMsgParseImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HuaweiMsgParseImpl)) {
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

		static Delegate cb_getMsgSource;
#pragma warning disable 0169
		static Delegate GetGetMsgSourceHandler ()
		{
			if (cb_getMsgSource == null)
				cb_getMsgSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsgSource);
			return cb_getMsgSource;
		}

		static IntPtr n_GetMsgSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Impl.HuaweiMsgParseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Impl.HuaweiMsgParseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsgSource);
		}
#pragma warning restore 0169

		static IntPtr id_getMsgSource;
		public virtual unsafe string MsgSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.impl']/class[@name='HuaweiMsgParseImpl']/method[@name='getMsgSource' and count(parameter)=0]"
			[Register ("getMsgSource", "()Ljava/lang/String;", "GetGetMsgSourceHandler")]
			get {
				if (id_getMsgSource == IntPtr.Zero)
					id_getMsgSource = JNIEnv.GetMethodID (class_ref, "getMsgSource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsgSource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgSource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parseMsgFromIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetParseMsgFromIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_parseMsgFromIntent_Landroid_content_Intent_ == null)
				cb_parseMsgFromIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseMsgFromIntent_Landroid_content_Intent_);
			return cb_parseMsgFromIntent_Landroid_content_Intent_;
		}

		static IntPtr n_ParseMsgFromIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Com.Alibaba.Sdk.Android.Push.Impl.HuaweiMsgParseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Impl.HuaweiMsgParseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ParseMsgFromIntent (intent));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseMsgFromIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.impl']/class[@name='HuaweiMsgParseImpl']/method[@name='parseMsgFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("parseMsgFromIntent", "(Landroid/content/Intent;)Ljava/lang/String;", "GetParseMsgFromIntent_Landroid_content_Intent_Handler")]
		public virtual unsafe string ParseMsgFromIntent (global::Android.Content.Intent intent)
		{
			if (id_parseMsgFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_parseMsgFromIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "parseMsgFromIntent", "(Landroid/content/Intent;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intent);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseMsgFromIntent_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseMsgFromIntent", "(Landroid/content/Intent;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

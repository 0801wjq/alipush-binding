using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CommonCallback']"
	[Register ("com/alibaba/sdk/android/push/CommonCallback", "", "Com.Alibaba.Sdk.Android.Push.ICommonCallbackInvoker")]
	public partial interface ICommonCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CommonCallback']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnFailed_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Push.ICommonCallbackInvoker, AliPush.Binding.Android")]
		void OnFailed (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push']/interface[@name='CommonCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Alibaba.Sdk.Android.Push.ICommonCallbackInvoker, AliPush.Binding.Android")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/CommonCallback", DoNotGenerateAcw=true)]
	internal class ICommonCallbackInvoker : global::Java.Lang.Object, ICommonCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/push/CommonCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICommonCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ICommonCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommonCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.push.CommonCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommonCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFailed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailed_Ljava_lang_String_Ljava_lang_String_);
			return cb_onFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFailed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnFailed (string p0, string p1)
		{
			if (id_onFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.ICommonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.ICommonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

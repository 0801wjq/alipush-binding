using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='CallBack']"
	[Register ("org/android/agoo/common/CallBack", "", "Org.Android.Agoo.Common.ICallBackInvoker")]
	public partial interface ICallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='CallBack']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler:Org.Android.Agoo.Common.ICallBackInvoker, AliPush.Binding.Android")]
		void OnFailure (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.common']/interface[@name='CallBack']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Org.Android.Agoo.Common.ICallBackInvoker, AliPush.Binding.Android")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("org/android/agoo/common/CallBack", DoNotGenerateAcw=true)]
	internal class ICallBackInvoker : global::Java.Lang.Object, ICallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/common/CallBack");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallBackInvoker); }
		}

		IntPtr class_ref;

		public static ICallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.common.CallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Common.ICallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Common.ICallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnFailure (string p0, string p1)
		{
			if (id_onFailure_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Common.ICallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Common.ICallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Log.Sign {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/interface[@name='IRequestAuth']"
	[Register ("com/alibaba/mtl/log/sign/IRequestAuth", "", "Com.Alibaba.Mtl.Log.Sign.IRequestAuthInvoker")]
	public partial interface IRequestAuth : IJavaObject {

		string Appkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/interface[@name='IRequestAuth']/method[@name='getAppkey' and count(parameter)=0]"
			[Register ("getAppkey", "()Ljava/lang/String;", "GetGetAppkeyHandler:Com.Alibaba.Mtl.Log.Sign.IRequestAuthInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.log.sign']/interface[@name='IRequestAuth']/method[@name='getSign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSign", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSign_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Log.Sign.IRequestAuthInvoker, AliPush.Binding.Android")]
		string GetSign (string p0);

	}

	[global::Android.Runtime.Register ("com/alibaba/mtl/log/sign/IRequestAuth", DoNotGenerateAcw=true)]
	internal class IRequestAuthInvoker : global::Java.Lang.Object, IRequestAuth {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/mtl/log/sign/IRequestAuth");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestAuthInvoker); }
		}

		IntPtr class_ref;

		public static IRequestAuth GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestAuth> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.mtl.log.sign.IRequestAuth"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestAuthInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppkey;
#pragma warning disable 0169
		static Delegate GetGetAppkeyHandler ()
		{
			if (cb_getAppkey == null)
				cb_getAppkey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppkey);
			return cb_getAppkey;
		}

		static IntPtr n_GetAppkey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Log.Sign.IRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.IRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Appkey);
		}
#pragma warning restore 0169

		IntPtr id_getAppkey;
		public unsafe string Appkey {
			get {
				if (id_getAppkey == IntPtr.Zero)
					id_getAppkey = JNIEnv.GetMethodID (class_ref, "getAppkey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppkey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSign_Ljava_lang_String_Handler ()
		{
			if (cb_getSign_Ljava_lang_String_ == null)
				cb_getSign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSign_Ljava_lang_String_);
			return cb_getSign_Ljava_lang_String_;
		}

		static IntPtr n_GetSign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Mtl.Log.Sign.IRequestAuth __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Log.Sign.IRequestAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSign_Ljava_lang_String_;
		public unsafe string GetSign (string p0)
		{
			if (id_getSign_Ljava_lang_String_ == IntPtr.Zero)
				id_getSign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSign_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='Param']"
	[Register ("anetwork/channel/Param", "", "Anetwork.Channel.IParamInvoker")]
	public partial interface IParam : IJavaObject {

		string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Param']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler:Anetwork.Channel.IParamInvoker, AliPush.Binding.Android")] get;
		}

		string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Param']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Anetwork.Channel.IParamInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("anetwork/channel/Param", DoNotGenerateAcw=true)]
	internal class IParamInvoker : global::Java.Lang.Object, IParam {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/Param");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IParamInvoker); }
		}

		IntPtr class_ref;

		public static IParam GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParam> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.Param"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IParam __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		IntPtr id_getKey;
		public unsafe string Key {
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IParam __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		public unsafe string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

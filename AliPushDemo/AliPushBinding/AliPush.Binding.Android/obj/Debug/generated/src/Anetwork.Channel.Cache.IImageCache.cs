using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='ImageCache']"
	[Register ("anetwork/channel/cache/ImageCache", "", "Anetwork.Channel.Cache.IImageCacheInvoker")]
	public partial interface IImageCache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='ImageCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)[B", "GetGet_Ljava_lang_String_Handler:Anetwork.Channel.Cache.IImageCacheInvoker, AliPush.Binding.Android")]
		byte[] Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='ImageCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)V", "GetPut_Ljava_lang_String_arrayBHandler:Anetwork.Channel.Cache.IImageCacheInvoker, AliPush.Binding.Android")]
		void Put (string p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("anetwork/channel/cache/ImageCache", DoNotGenerateAcw=true)]
	internal class IImageCacheInvoker : global::Java.Lang.Object, IImageCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/cache/ImageCache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageCacheInvoker); }
		}

		IntPtr class_ref;

		public static IImageCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.cache.ImageCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.Cache.IImageCache __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.IImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe byte[] Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_arrayB;
		}

		static void n_Put_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.Cache.IImageCache __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.IImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Put (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_arrayB;
		public unsafe void Put (string p0, byte[] p1)
		{
			if (id_put_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_put_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

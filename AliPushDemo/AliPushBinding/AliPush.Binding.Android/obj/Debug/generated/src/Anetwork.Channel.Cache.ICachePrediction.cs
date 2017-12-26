using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='CachePrediction']"
	[Register ("anetwork/channel/cache/CachePrediction", "", "Anetwork.Channel.Cache.ICachePredictionInvoker")]
	public partial interface ICachePrediction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='CachePrediction']/method[@name='handleCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("handleCache", "(Ljava/lang/String;Ljava/util/Map;)Z", "GetHandleCache_Ljava_lang_String_Ljava_util_Map_Handler:Anetwork.Channel.Cache.ICachePredictionInvoker, AliPush.Binding.Android")]
		bool HandleCache (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("anetwork/channel/cache/CachePrediction", DoNotGenerateAcw=true)]
	internal class ICachePredictionInvoker : global::Java.Lang.Object, ICachePrediction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/cache/CachePrediction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICachePredictionInvoker); }
		}

		IntPtr class_ref;

		public static ICachePrediction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICachePrediction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.cache.CachePrediction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICachePredictionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleCache_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetHandleCache_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_handleCache_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_handleCache_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleCache_Ljava_lang_String_Ljava_util_Map_);
			return cb_handleCache_Ljava_lang_String_Ljava_util_Map_;
		}

		static bool n_HandleCache_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.Cache.ICachePrediction __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.ICachePrediction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleCache (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleCache_Ljava_lang_String_Ljava_util_Map_;
		public unsafe bool HandleCache (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_handleCache_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_handleCache_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "handleCache", "(Ljava/lang/String;Ljava/util/Map;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleCache_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}

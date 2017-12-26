using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']"
	[global::Android.Runtime.Register ("anetwork/channel/cache/Cache$Entry", DoNotGenerateAcw=true)]
	public partial class CacheEntry : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='a']"
		[Register ("a")]
		public IList<byte> A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='b']"
		[Register ("b")]
		public string B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='c']"
		[Register ("c")]
		public long C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='d']"
		[Register ("d")]
		public long D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, d_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='e']"
		[Register ("e")]
		public long E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/field[@name='f']"
		[Register ("f")]
		public global::System.Collections.IDictionary F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, f_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, f_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/cache/Cache$Entry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheEntry); }
		}

		protected CacheEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.cache']/class[@name='Cache.Entry']/constructor[@name='Cache.Entry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CacheEntry)) {
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

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='Cache']"
	[Register ("anetwork/channel/cache/Cache", "", "Anetwork.Channel.Cache.ICacheInvoker")]
	public partial interface ICache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='Cache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Anetwork.Channel.Cache.ICacheInvoker, AliPush.Binding.Android")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='Cache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lanetwork/channel/cache/Cache$Entry;", "GetGet_Ljava_lang_String_Handler:Anetwork.Channel.Cache.ICacheInvoker, AliPush.Binding.Android")]
		global::Anetwork.Channel.Cache.CacheEntry Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.cache']/interface[@name='Cache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='anetwork.channel.cache.Cache.Entry']]"
		[Register ("put", "(Ljava/lang/String;Lanetwork/channel/cache/Cache$Entry;)V", "GetPut_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_Handler:Anetwork.Channel.Cache.ICacheInvoker, AliPush.Binding.Android")]
		void Put (string p0, global::Anetwork.Channel.Cache.CacheEntry p1);

	}

	[global::Android.Runtime.Register ("anetwork/channel/cache/Cache", DoNotGenerateAcw=true)]
	internal class ICacheInvoker : global::Java.Lang.Object, ICache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/cache/Cache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICacheInvoker); }
		}

		IntPtr class_ref;

		public static ICache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.cache.Cache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
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
			global::Anetwork.Channel.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Anetwork.Channel.Cache.CacheEntry Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lanetwork/channel/cache/Cache$Entry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Anetwork.Channel.Cache.CacheEntry __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.CacheEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_ == null)
				cb_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_);
			return cb_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_;
		}

		static void n_Put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.Cache.CacheEntry p1 = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Cache.CacheEntry> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_;
		public unsafe void Put (string p0, global::Anetwork.Channel.Cache.CacheEntry p1)
		{
			if (id_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lanetwork/channel/cache/Cache$Entry;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lanetwork_channel_cache_Cache_Entry_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

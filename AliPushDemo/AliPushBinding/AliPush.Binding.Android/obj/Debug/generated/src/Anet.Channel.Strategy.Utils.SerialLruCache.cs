using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Strategy.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.strategy.utils']/class[@name='SerialLruCache']"
	[global::Android.Runtime.Register ("anet/channel/strategy/utils/SerialLruCache", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class SerialLruCache : global::Java.Util.LinkedHashMap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/strategy/utils/SerialLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerialLruCache); }
		}

		protected SerialLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anet.channel.strategy.utils']/class[@name='SerialLruCache']/constructor[@name='SerialLruCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SerialLruCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SerialLruCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_a_Ljava_util_Map_Entry_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Map_Entry_Handler ()
		{
			if (cb_a_Ljava_util_Map_Entry_ == null)
				cb_a_Ljava_util_Map_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_A_Ljava_util_Map_Entry_);
			return cb_a_Ljava_util_Map_Entry_;
		}

		static bool n_A_Ljava_util_Map_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Strategy.Utils.SerialLruCache __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Utils.SerialLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IMapEntry p0 = (global::Java.Util.IMapEntry)global::Java.Lang.Object.GetObject<global::Java.Util.IMapEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_Map_Entry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.utils']/class[@name='SerialLruCache']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map.Entry&lt;K, V&gt;']]"
		[Register ("a", "(Ljava/util/Map$Entry;)Z", "GetA_Ljava_util_Map_Entry_Handler")]
		protected virtual unsafe bool A (global::Java.Util.IMapEntry p0)
		{
			if (id_a_Ljava_util_Map_Entry_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Entry_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map$Entry;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_util_Map_Entry_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/Map$Entry;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeEldestEntry_Ljava_util_Map_Entry_;
#pragma warning disable 0169
		static Delegate GetRemoveEldestEntry_Ljava_util_Map_Entry_Handler ()
		{
			if (cb_removeEldestEntry_Ljava_util_Map_Entry_ == null)
				cb_removeEldestEntry_Ljava_util_Map_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveEldestEntry_Ljava_util_Map_Entry_);
			return cb_removeEldestEntry_Ljava_util_Map_Entry_;
		}

		static bool n_RemoveEldestEntry_Ljava_util_Map_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anet.Channel.Strategy.Utils.SerialLruCache __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Utils.SerialLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IMapEntry p0 = (global::Java.Util.IMapEntry)global::Java.Lang.Object.GetObject<global::Java.Util.IMapEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveEldestEntry (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeEldestEntry_Ljava_util_Map_Entry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.utils']/class[@name='SerialLruCache']/method[@name='removeEldestEntry' and count(parameter)=1 and parameter[1][@type='java.util.Map.Entry&lt;K, V&gt;']]"
		[Register ("removeEldestEntry", "(Ljava/util/Map$Entry;)Z", "GetRemoveEldestEntry_Ljava_util_Map_Entry_Handler")]
		protected override unsafe bool RemoveEldestEntry (global::Java.Util.IMapEntry p0)
		{
			if (id_removeEldestEntry_Ljava_util_Map_Entry_ == IntPtr.Zero)
				id_removeEldestEntry_Ljava_util_Map_Entry_ = JNIEnv.GetMethodID (class_ref, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeEldestEntry_Ljava_util_Map_Entry_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

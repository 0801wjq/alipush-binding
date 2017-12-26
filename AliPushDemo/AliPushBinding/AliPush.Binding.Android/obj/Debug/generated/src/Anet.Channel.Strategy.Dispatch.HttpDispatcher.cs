using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Strategy.Dispatch {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']"
	[global::Android.Runtime.Register ("anet/channel/strategy/dispatch/HttpDispatcher", DoNotGenerateAcw=true)]
	public sealed partial class HttpDispatcher : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/strategy/dispatch/HttpDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpDispatcher); }
		}

		internal HttpDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lanet/channel/strategy/dispatch/HttpDispatcher;", "")]
		public static unsafe global::Anet.Channel.Strategy.Dispatch.HttpDispatcher A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lanet/channel/strategy/dispatch/HttpDispatcher;");
			try {
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Strategy.Dispatch.HttpDispatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "")]
		public unsafe bool A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_util_Set_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("a", "(Ljava/util/Set;Ljava/lang/String;I)V", "")]
		public unsafe void A (global::System.Collections.Generic.ICollection<string> p0, string p1, int p2)
		{
			if (id_a_Ljava_util_Set_Ljava_lang_String_I == IntPtr.Zero)
				id_a_Ljava_util_Set_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Set;Ljava/lang/String;I)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_util_Set_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.strategy.dispatch']/class[@name='HttpDispatcher']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c);
			} finally {
			}
		}

	}
}

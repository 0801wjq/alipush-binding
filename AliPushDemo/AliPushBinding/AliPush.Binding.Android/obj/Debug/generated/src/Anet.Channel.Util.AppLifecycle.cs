using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anet.Channel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']"
	[global::Android.Runtime.Register ("anet/channel/util/AppLifecycle", DoNotGenerateAcw=true)]
	public sealed partial class AppLifecycle : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anet.channel.util']/interface[@name='AppLifecycle.AppLifecycleListener']"
		[Register ("anet/channel/util/AppLifecycle$AppLifecycleListener", "", "Anet.Channel.Util.AppLifecycle/IAppLifecycleListenerInvoker")]
		public partial interface IAppLifecycleListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/interface[@name='AppLifecycle.AppLifecycleListener']/method[@name='background' and count(parameter)=0]"
			[Register ("background", "()V", "GetBackgroundHandler:Anet.Channel.Util.AppLifecycle/IAppLifecycleListenerInvoker, AliPush.Binding.Android")]
			void Background ();

			// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/interface[@name='AppLifecycle.AppLifecycleListener']/method[@name='forground' and count(parameter)=0]"
			[Register ("forground", "()V", "GetForgroundHandler:Anet.Channel.Util.AppLifecycle/IAppLifecycleListenerInvoker, AliPush.Binding.Android")]
			void Forground ();

		}

		[global::Android.Runtime.Register ("anet/channel/util/AppLifecycle$AppLifecycleListener", DoNotGenerateAcw=true)]
		internal class IAppLifecycleListenerInvoker : global::Java.Lang.Object, IAppLifecycleListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anet/channel/util/AppLifecycle$AppLifecycleListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAppLifecycleListenerInvoker); }
			}

			IntPtr class_ref;

			public static IAppLifecycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAppLifecycleListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anet.channel.util.AppLifecycle.AppLifecycleListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAppLifecycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_background;
#pragma warning disable 0169
			static Delegate GetBackgroundHandler ()
			{
				if (cb_background == null)
					cb_background = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Background);
				return cb_background;
			}

			static void n_Background (IntPtr jnienv, IntPtr native__this)
			{
				global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Background ();
			}
#pragma warning restore 0169

			IntPtr id_background;
			public unsafe void Background ()
			{
				if (id_background == IntPtr.Zero)
					id_background = JNIEnv.GetMethodID (class_ref, "background", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_background);
			}

			static Delegate cb_forground;
#pragma warning disable 0169
			static Delegate GetForgroundHandler ()
			{
				if (cb_forground == null)
					cb_forground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Forground);
				return cb_forground;
			}

			static void n_Forground (IntPtr jnienv, IntPtr native__this)
			{
				global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Forground ();
			}
#pragma warning restore 0169

			IntPtr id_forground;
			public unsafe void Forground ()
			{
				if (id_forground == IntPtr.Zero)
					id_forground = JNIEnv.GetMethodID (class_ref, "forground", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forground);
			}

		}

		[global::Android.Runtime.Register ("mono/anet/channel/util/AppLifecycle_AppLifecycleListenerImplementor")]
		internal sealed partial class IAppLifecycleListenerImplementor : global::Java.Lang.Object, IAppLifecycleListener {

			object sender;

			public IAppLifecycleListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anet/channel/util/AppLifecycle_AppLifecycleListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler BackgroundHandler;
#pragma warning restore 0649

			public void Background ()
			{
				var __h = BackgroundHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler ForgroundHandler;
#pragma warning restore 0649

			public void Forground ()
			{
				var __h = ForgroundHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IAppLifecycleListenerImplementor value)
			{
				return value.BackgroundHandler == null && value.ForgroundHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anet/channel/util/AppLifecycle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppLifecycle); }
		}

		internal AppLifecycle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public static unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a);
			} finally {
			}
		}

		static IntPtr id_a_Lanet_channel_util_AppLifecycle_AppLifecycleListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']/method[@name='a' and count(parameter)=1 and parameter[1][@type='anet.channel.util.AppLifecycle.AppLifecycleListener']]"
		[Register ("a", "(Lanet/channel/util/AppLifecycle$AppLifecycleListener;)V", "")]
		public static unsafe void A (global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener p0)
		{
			if (id_a_Lanet_channel_util_AppLifecycle_AppLifecycleListener_ == IntPtr.Zero)
				id_a_Lanet_channel_util_AppLifecycle_AppLifecycleListener_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lanet/channel/util/AppLifecycle$AppLifecycleListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lanet_channel_util_AppLifecycle_AppLifecycleListener_, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public static unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetStaticMethodID (class_ref, "b", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b);
			} finally {
			}
		}

		static IntPtr id_b_Lanet_channel_util_AppLifecycle_AppLifecycleListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']/method[@name='b' and count(parameter)=1 and parameter[1][@type='anet.channel.util.AppLifecycle.AppLifecycleListener']]"
		[Register ("b", "(Lanet/channel/util/AppLifecycle$AppLifecycleListener;)V", "")]
		public static unsafe void B (global::Anet.Channel.Util.AppLifecycle.IAppLifecycleListener p0)
		{
			if (id_b_Lanet_channel_util_AppLifecycle_AppLifecycleListener_ == IntPtr.Zero)
				id_b_Lanet_channel_util_AppLifecycle_AppLifecycleListener_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lanet/channel/util/AppLifecycle$AppLifecycleListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Lanet_channel_util_AppLifecycle_AppLifecycleListener_, __args);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='anet.channel.util']/class[@name='AppLifecycle']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public static unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c);
			} finally {
			}
		}

	}
}

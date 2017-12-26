using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.download']/class[@name='DownloadManager']"
	[global::Android.Runtime.Register ("anetwork/channel/download/DownloadManager", DoNotGenerateAcw=true)]
	public sealed partial class DownloadManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.download']/interface[@name='DownloadManager.DownloadListener']"
		[Register ("anetwork/channel/download/DownloadManager$DownloadListener", "", "Anetwork.Channel.Download.DownloadManager/IDownloadListenerInvoker")]
		public partial interface IDownloadListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.download']/interface[@name='DownloadManager.DownloadListener']/method[@name='onFail' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("onFail", "(IILjava/lang/String;)V", "GetOnFail_IILjava_lang_String_Handler:Anetwork.Channel.Download.DownloadManager/IDownloadListenerInvoker, AliPush.Binding.Android")]
			void OnFail (int p0, int p1, string p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.download']/interface[@name='DownloadManager.DownloadListener']/method[@name='onProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register ("onProgress", "(IJJ)V", "GetOnProgress_IJJHandler:Anetwork.Channel.Download.DownloadManager/IDownloadListenerInvoker, AliPush.Binding.Android")]
			void OnProgress (int p0, long p1, long p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.download']/interface[@name='DownloadManager.DownloadListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onSuccess", "(ILjava/lang/String;)V", "GetOnSuccess_ILjava_lang_String_Handler:Anetwork.Channel.Download.DownloadManager/IDownloadListenerInvoker, AliPush.Binding.Android")]
			void OnSuccess (int p0, string p1);

		}

		[global::Android.Runtime.Register ("anetwork/channel/download/DownloadManager$DownloadListener", DoNotGenerateAcw=true)]
		internal class IDownloadListenerInvoker : global::Java.Lang.Object, IDownloadListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/download/DownloadManager$DownloadListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDownloadListenerInvoker); }
			}

			IntPtr class_ref;

			public static IDownloadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.download.DownloadManager.DownloadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFail_IILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFail_IILjava_lang_String_Handler ()
			{
				if (cb_onFail_IILjava_lang_String_ == null)
					cb_onFail_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnFail_IILjava_lang_String_);
				return cb_onFail_IILjava_lang_String_;
			}

			static void n_OnFail_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Anetwork.Channel.Download.DownloadManager.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Download.DownloadManager.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnFail (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onFail_IILjava_lang_String_;
			public unsafe void OnFail (int p0, int p1, string p2)
			{
				if (id_onFail_IILjava_lang_String_ == IntPtr.Zero)
					id_onFail_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFail", "(IILjava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_IILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_onProgress_IJJ;
#pragma warning disable 0169
			static Delegate GetOnProgress_IJJHandler ()
			{
				if (cb_onProgress_IJJ == null)
					cb_onProgress_IJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, long>) n_OnProgress_IJJ);
				return cb_onProgress_IJJ;
			}

			static void n_OnProgress_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
			{
				global::Anetwork.Channel.Download.DownloadManager.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Download.DownloadManager.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgress (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onProgress_IJJ;
			public unsafe void OnProgress (int p0, long p1, long p2)
			{
				if (id_onProgress_IJJ == IntPtr.Zero)
					id_onProgress_IJJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(IJJ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_IJJ, __args);
			}

			static Delegate cb_onSuccess_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_ILjava_lang_String_Handler ()
			{
				if (cb_onSuccess_ILjava_lang_String_ == null)
					cb_onSuccess_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnSuccess_ILjava_lang_String_);
				return cb_onSuccess_ILjava_lang_String_;
			}

			static void n_OnSuccess_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Anetwork.Channel.Download.DownloadManager.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Download.DownloadManager.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_ILjava_lang_String_;
			public unsafe void OnSuccess (int p0, string p1)
			{
				if (id_onSuccess_ILjava_lang_String_ == IntPtr.Zero)
					id_onSuccess_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(ILjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_ILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		public partial class FailEventArgs : global::System.EventArgs {

			public FailEventArgs (int p0, int p1, string p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}
		}

		public partial class ProgressEventArgs : global::System.EventArgs {

			public ProgressEventArgs (int p0, long p1, long p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}

			long p2;
			public long P2 {
				get { return p2; }
			}
		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (int p0, string p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/anetwork/channel/download/DownloadManager_DownloadListenerImplementor")]
		internal sealed partial class IDownloadListenerImplementor : global::Java.Lang.Object, IDownloadListener {

			object sender;

			public IDownloadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/anetwork/channel/download/DownloadManager_DownloadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailEventArgs> OnFailHandler;
#pragma warning restore 0649

			public void OnFail (int p0, int p1, string p2)
			{
				var __h = OnFailHandler;
				if (__h != null)
					__h (sender, new FailEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<ProgressEventArgs> OnProgressHandler;
#pragma warning restore 0649

			public void OnProgress (int p0, long p1, long p2)
			{
				var __h = OnProgressHandler;
				if (__h != null)
					__h (sender, new ProgressEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess (int p0, string p1)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDownloadListenerImplementor value)
			{
				return value.OnFailHandler == null && value.OnProgressHandler == null && value.OnSuccessHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/download/DownloadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadManager); }
		}

		internal DownloadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

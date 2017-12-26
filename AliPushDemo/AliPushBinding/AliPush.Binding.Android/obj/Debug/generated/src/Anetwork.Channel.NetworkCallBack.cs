using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel']/class[@name='NetworkCallBack']"
	[global::Android.Runtime.Register ("anetwork/channel/NetworkCallBack", DoNotGenerateAcw=true)]
	public sealed partial class NetworkCallBack : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.FinishListener']"
		[Register ("anetwork/channel/NetworkCallBack$FinishListener", "", "Anetwork.Channel.NetworkCallBack/IFinishListenerInvoker")]
		public partial interface IFinishListener : global::Anetwork.Channel.INetworkListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.FinishListener']/method[@name='onFinished' and count(parameter)=2 and parameter[1][@type='anetwork.channel.NetworkEvent.FinishEvent'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onFinished", "(Lanetwork/channel/NetworkEvent$FinishEvent;Ljava/lang/Object;)V", "GetOnFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_Handler:Anetwork.Channel.NetworkCallBack/IFinishListenerInvoker, AliPush.Binding.Android")]
			void OnFinished (global::Anetwork.Channel.NetworkEvent.IFinishEvent p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkCallBack$FinishListener", DoNotGenerateAcw=true)]
		internal class IFinishListenerInvoker : global::Java.Lang.Object, IFinishListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkCallBack$FinishListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFinishListenerInvoker); }
			}

			IntPtr class_ref;

			public static IFinishListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFinishListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkCallBack.FinishListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFinishListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_Handler ()
			{
				if (cb_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_ == null)
					cb_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_);
				return cb_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_;
			}

			static void n_OnFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Anetwork.Channel.NetworkCallBack.IFinishListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkCallBack.IFinishListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Anetwork.Channel.NetworkEvent.IFinishEvent p0 = (global::Anetwork.Channel.NetworkEvent.IFinishEvent)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IFinishEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFinished (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_;
			public unsafe void OnFinished (global::Anetwork.Channel.NetworkEvent.IFinishEvent p0, global::Java.Lang.Object p1)
			{
				if (id_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_ == IntPtr.Zero)
					id_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onFinished", "(Lanetwork/channel/NetworkEvent$FinishEvent;Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinished_Lanetwork_channel_NetworkEvent_FinishEvent_Ljava_lang_Object_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.InputStreamListener']"
		[Register ("anetwork/channel/NetworkCallBack$InputStreamListener", "", "Anetwork.Channel.NetworkCallBack/IInputStreamListenerInvoker")]
		public partial interface IInputStreamListener : global::Anetwork.Channel.INetworkListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.InputStreamListener']/method[@name='onInputStreamGet' and count(parameter)=2 and parameter[1][@type='anetwork.channel.aidl.ParcelableInputStream'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onInputStreamGet", "(Lanetwork/channel/aidl/ParcelableInputStream;Ljava/lang/Object;)V", "GetOnInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_Handler:Anetwork.Channel.NetworkCallBack/IInputStreamListenerInvoker, AliPush.Binding.Android")]
			void OnInputStreamGet (global::Anetwork.Channel.Aidl.IParcelableInputStream p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkCallBack$InputStreamListener", DoNotGenerateAcw=true)]
		internal class IInputStreamListenerInvoker : global::Java.Lang.Object, IInputStreamListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkCallBack$InputStreamListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInputStreamListenerInvoker); }
			}

			IntPtr class_ref;

			public static IInputStreamListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInputStreamListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkCallBack.InputStreamListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInputStreamListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_Handler ()
			{
				if (cb_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_ == null)
					cb_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_);
				return cb_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_;
			}

			static void n_OnInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Anetwork.Channel.NetworkCallBack.IInputStreamListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkCallBack.IInputStreamListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Anetwork.Channel.Aidl.IParcelableInputStream p0 = (global::Anetwork.Channel.Aidl.IParcelableInputStream)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInputStreamGet (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_;
			public unsafe void OnInputStreamGet (global::Anetwork.Channel.Aidl.IParcelableInputStream p0, global::Java.Lang.Object p1)
			{
				if (id_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_ == IntPtr.Zero)
					id_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onInputStreamGet", "(Lanetwork/channel/aidl/ParcelableInputStream;Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInputStreamGet_Lanetwork_channel_aidl_ParcelableInputStream_Ljava_lang_Object_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.ProgressListener']"
		[Register ("anetwork/channel/NetworkCallBack$ProgressListener", "", "Anetwork.Channel.NetworkCallBack/IProgressListenerInvoker")]
		public partial interface IProgressListener : global::Anetwork.Channel.INetworkListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.ProgressListener']/method[@name='onDataReceived' and count(parameter)=2 and parameter[1][@type='anetwork.channel.NetworkEvent.ProgressEvent'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onDataReceived", "(Lanetwork/channel/NetworkEvent$ProgressEvent;Ljava/lang/Object;)V", "GetOnDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_Handler:Anetwork.Channel.NetworkCallBack/IProgressListenerInvoker, AliPush.Binding.Android")]
			void OnDataReceived (global::Anetwork.Channel.NetworkEvent.IProgressEvent p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkCallBack$ProgressListener", DoNotGenerateAcw=true)]
		internal class IProgressListenerInvoker : global::Java.Lang.Object, IProgressListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkCallBack$ProgressListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProgressListenerInvoker); }
			}

			IntPtr class_ref;

			public static IProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkCallBack.ProgressListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_Handler ()
			{
				if (cb_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_ == null)
					cb_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_);
				return cb_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_;
			}

			static void n_OnDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Anetwork.Channel.NetworkCallBack.IProgressListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkCallBack.IProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Anetwork.Channel.NetworkEvent.IProgressEvent p0 = (global::Anetwork.Channel.NetworkEvent.IProgressEvent)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDataReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_;
			public unsafe void OnDataReceived (global::Anetwork.Channel.NetworkEvent.IProgressEvent p0, global::Java.Lang.Object p1)
			{
				if (id_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_ == IntPtr.Zero)
					id_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onDataReceived", "(Lanetwork/channel/NetworkEvent$ProgressEvent;Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataReceived_Lanetwork_channel_NetworkEvent_ProgressEvent_Ljava_lang_Object_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.ResponseCodeListener']"
		[Register ("anetwork/channel/NetworkCallBack$ResponseCodeListener", "", "Anetwork.Channel.NetworkCallBack/IResponseCodeListenerInvoker")]
		public partial interface IResponseCodeListener : global::Anetwork.Channel.INetworkListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkCallBack.ResponseCodeListener']/method[@name='onResponseCode' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.lang.Object']]"
			[Register ("onResponseCode", "(ILjava/util/Map;Ljava/lang/Object;)Z", "GetOnResponseCode_ILjava_util_Map_Ljava_lang_Object_Handler:Anetwork.Channel.NetworkCallBack/IResponseCodeListenerInvoker, AliPush.Binding.Android")]
			bool OnResponseCode (int p0, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p1, global::Java.Lang.Object p2);

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkCallBack$ResponseCodeListener", DoNotGenerateAcw=true)]
		internal class IResponseCodeListenerInvoker : global::Java.Lang.Object, IResponseCodeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkCallBack$ResponseCodeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IResponseCodeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IResponseCodeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResponseCodeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkCallBack.ResponseCodeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResponseCodeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResponseCode_ILjava_util_Map_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnResponseCode_ILjava_util_Map_Ljava_lang_Object_Handler ()
			{
				if (cb_onResponseCode_ILjava_util_Map_Ljava_lang_Object_ == null)
					cb_onResponseCode_ILjava_util_Map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnResponseCode_ILjava_util_Map_Ljava_lang_Object_);
				return cb_onResponseCode_ILjava_util_Map_Ljava_lang_Object_;
			}

			static bool n_OnResponseCode_ILjava_util_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Anetwork.Channel.NetworkCallBack.IResponseCodeListener __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkCallBack.IResponseCodeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnResponseCode (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onResponseCode_ILjava_util_Map_Ljava_lang_Object_;
			public unsafe bool OnResponseCode (int p0, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p1, global::Java.Lang.Object p2)
			{
				if (id_onResponseCode_ILjava_util_Map_Ljava_lang_Object_ == IntPtr.Zero)
					id_onResponseCode_ILjava_util_Map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResponseCode", "(ILjava/util/Map;Ljava/lang/Object;)Z");
				IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onResponseCode_ILjava_util_Map_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/NetworkCallBack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkCallBack); }
		}

		internal NetworkCallBack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

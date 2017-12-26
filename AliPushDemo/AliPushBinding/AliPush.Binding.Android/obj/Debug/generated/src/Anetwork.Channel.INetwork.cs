using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='Network']"
	[Register ("anetwork/channel/Network", "", "Anetwork.Channel.INetworkInvoker")]
	public partial interface INetwork : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Network']/method[@name='asyncSend' and count(parameter)=4 and parameter[1][@type='anetwork.channel.Request'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='android.os.Handler'] and parameter[4][@type='anetwork.channel.NetworkListener']]"
		[Register ("asyncSend", "(Lanetwork/channel/Request;Ljava/lang/Object;Landroid/os/Handler;Lanetwork/channel/NetworkListener;)Ljava/util/concurrent/Future;", "GetAsyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_Handler:Anetwork.Channel.INetworkInvoker, AliPush.Binding.Android")]
		global::Java.Util.Concurrent.IFuture AsyncSend (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1, global::Android.OS.Handler p2, global::Anetwork.Channel.INetworkListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Network']/method[@name='getConnection' and count(parameter)=2 and parameter[1][@type='anetwork.channel.Request'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getConnection", "(Lanetwork/channel/Request;Ljava/lang/Object;)Lanetwork/channel/aidl/Connection;", "GetGetConnection_Lanetwork_channel_Request_Ljava_lang_Object_Handler:Anetwork.Channel.INetworkInvoker, AliPush.Binding.Android")]
		global::Anetwork.Channel.Aidl.IConnection GetConnection (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Network']/method[@name='syncSend' and count(parameter)=2 and parameter[1][@type='anetwork.channel.Request'] and parameter[2][@type='java.lang.Object']]"
		[Register ("syncSend", "(Lanetwork/channel/Request;Ljava/lang/Object;)Lanetwork/channel/Response;", "GetSyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Handler:Anetwork.Channel.INetworkInvoker, AliPush.Binding.Android")]
		global::Anetwork.Channel.IResponse SyncSend (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("anetwork/channel/Network", DoNotGenerateAcw=true)]
	internal class INetworkInvoker : global::Java.Lang.Object, INetwork {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/Network");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkInvoker); }
		}

		IntPtr class_ref;

		public static INetwork GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetwork> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.Network"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_Handler ()
		{
			if (cb_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_ == null)
				cb_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_);
			return cb_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_;
		}

		static IntPtr n_AsyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Anetwork.Channel.INetwork __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.INetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IRequest p0 = (global::Anetwork.Channel.IRequest)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.INetworkListener p3 = (global::Anetwork.Channel.INetworkListener)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.INetworkListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSend (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_;
		public unsafe global::Java.Util.Concurrent.IFuture AsyncSend (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1, global::Android.OS.Handler p2, global::Anetwork.Channel.INetworkListener p3)
		{
			if (id_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_ == IntPtr.Zero)
				id_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_ = JNIEnv.GetMethodID (class_ref, "asyncSend", "(Lanetwork/channel/Request;Ljava/lang/Object;Landroid/os/Handler;Lanetwork/channel/NetworkListener;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Landroid_os_Handler_Lanetwork_channel_NetworkListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetConnection_Lanetwork_channel_Request_Ljava_lang_Object_Handler ()
		{
			if (cb_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_ == null)
				cb_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnection_Lanetwork_channel_Request_Ljava_lang_Object_);
			return cb_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_;
		}

		static IntPtr n_GetConnection_Lanetwork_channel_Request_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.INetwork __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.INetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IRequest p0 = (global::Anetwork.Channel.IRequest)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnection (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_;
		public unsafe global::Anetwork.Channel.Aidl.IConnection GetConnection (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1)
		{
			if (id_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_ == IntPtr.Zero)
				id_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getConnection", "(Lanetwork/channel/Request;Ljava/lang/Object;)Lanetwork/channel/aidl/Connection;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Anetwork.Channel.Aidl.IConnection __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnection_Lanetwork_channel_Request_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSyncSend_Lanetwork_channel_Request_Ljava_lang_Object_Handler ()
		{
			if (cb_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_ == null)
				cb_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncSend_Lanetwork_channel_Request_Ljava_lang_Object_);
			return cb_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_;
		}

		static IntPtr n_SyncSend_Lanetwork_channel_Request_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.INetwork __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.INetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IRequest p0 = (global::Anetwork.Channel.IRequest)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SyncSend (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_;
		public unsafe global::Anetwork.Channel.IResponse SyncSend (global::Anetwork.Channel.IRequest p0, global::Java.Lang.Object p1)
		{
			if (id_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_ == IntPtr.Zero)
				id_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "syncSend", "(Lanetwork/channel/Request;Ljava/lang/Object;)Lanetwork/channel/Response;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Anetwork.Channel.IResponse __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_syncSend_Lanetwork_channel_Request_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']"
	[Register ("anetwork/channel/Request", "", "Anetwork.Channel.IRequestInvoker")]
	public partial interface IRequest : IJavaObject {

		string BizId {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getBizId' and count(parameter)=0]"
			[Register ("getBizId", "()Ljava/lang/String;", "GetGetBizIdHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setBizId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBizId", "(Ljava/lang/String;)V", "GetSetBizId_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::Anet.Channel.Request.IBodyEntry BodyEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getBodyEntry' and count(parameter)=0]"
			[Register ("getBodyEntry", "()Lanet/channel/request/BodyEntry;", "GetGetBodyEntryHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setBodyEntry' and count(parameter)=1 and parameter[1][@type='anet.channel.request.BodyEntry']]"
			[Register ("setBodyEntry", "(Lanet/channel/request/BodyEntry;)V", "GetSetBodyEntry_Lanet_channel_request_BodyEntry_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::Anetwork.Channel.IBodyHandler BodyHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getBodyHandler' and count(parameter)=0]"
			[Register ("getBodyHandler", "()Lanetwork/channel/IBodyHandler;", "GetGetBodyHandlerHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setBodyHandler' and count(parameter)=1 and parameter[1][@type='anetwork.channel.IBodyHandler']]"
			[Register ("setBodyHandler", "(Lanetwork/channel/IBodyHandler;)V", "GetSetBodyHandler_Lanetwork_channel_IBodyHandler_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setCharset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCharset", "(Ljava/lang/String;)V", "GetSetCharset_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		int ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()I", "GetGetConnectTimeoutHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		bool CookieEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='isCookieEnabled' and count(parameter)=0]"
			[Register ("isCookieEnabled", "()Z", "GetIsCookieEnabledHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setCookieEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCookieEnabled", "(Z)V", "GetSetCookieEnabled_ZHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::System.Collections.Generic.IDictionary<string, string> ExtProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getExtProperties' and count(parameter)=0]"
			[Register ("getExtProperties", "()Ljava/util/Map;", "GetGetExtPropertiesHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
		}

		bool FollowRedirects {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getFollowRedirects' and count(parameter)=0]"
			[Register ("getFollowRedirects", "()Z", "GetGetFollowRedirectsHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFollowRedirects", "(Z)V", "GetSetFollowRedirects_ZHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::System.Collections.Generic.IList<global::Anetwork.Channel.IHeader> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;anetwork.channel.Header&gt;']]"
			[Register ("setHeaders", "(Ljava/util/List;)V", "GetSetHeaders_Ljava_util_List_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMethod", "(Ljava/lang/String;)V", "GetSetMethod_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::System.Collections.Generic.IList<global::Anetwork.Channel.IParam> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/List;", "GetGetParamsHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setParams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;anetwork.channel.Param&gt;']]"
			[Register ("setParams", "(Ljava/util/List;)V", "GetSetParams_Ljava_util_List_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		bool ProtocolModifiable {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='isProtocolModifiable' and count(parameter)=0]"
			[Register ("isProtocolModifiable", "()Z", "GetIsProtocolModifiableHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setProtocolModifiable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setProtocolModifiable", "(Z)V", "GetSetProtocolModifiable_ZHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "GetGetReadTimeoutHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		int RetryTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getRetryTime' and count(parameter)=0]"
			[Register ("getRetryTime", "()I", "GetGetRetryTimeHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setRetryTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetryTime", "(I)V", "GetSetRetryTime_IHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		string SeqNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getSeqNo' and count(parameter)=0]"
			[Register ("getSeqNo", "()Ljava/lang/String;", "GetGetSeqNoHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setSeqNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSeqNo", "(Ljava/lang/String;)V", "GetSetSeqNo_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] set;
		}

		global::Java.Net.URI URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/net/URI;", "GetGetURIHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
		}

		global::Java.Net.URL URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/net/URL;", "GetGetURLHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void AddHeader (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getExtProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetExtProperty_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		string GetExtProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='getHeaders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeaders", "(Ljava/lang/String;)[Lanetwork/channel/Header;", "GetGetHeaders_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		global::Anetwork.Channel.IHeader[] GetHeaders (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='anetwork.channel.Header']]"
		[Register ("removeHeader", "(Lanetwork/channel/Header;)V", "GetRemoveHeader_Lanetwork_channel_Header_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void RemoveHeader (global::Anetwork.Channel.IHeader p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setBizId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBizId", "(I)V", "GetSetBizId_IHandler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void SetBizId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setExtProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setExtProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetExtProperty_Ljava_lang_String_Ljava_lang_String_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void SetExtProperty (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setHeader' and count(parameter)=1 and parameter[1][@type='anetwork.channel.Header']]"
		[Register ("setHeader", "(Lanetwork/channel/Header;)V", "GetSetHeader_Lanetwork_channel_Header_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void SetHeader (global::Anetwork.Channel.IHeader p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Request']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("setUri", "(Ljava/net/URI;)V", "GetSetUri_Ljava_net_URI_Handler:Anetwork.Channel.IRequestInvoker, AliPush.Binding.Android")]
		void SetUri (global::Java.Net.URI p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/Request", DoNotGenerateAcw=true)]
	internal class IRequestInvoker : global::Java.Lang.Object, IRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/Request");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestInvoker); }
		}

		IntPtr class_ref;

		public static IRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.Request"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBizId;
#pragma warning disable 0169
		static Delegate GetGetBizIdHandler ()
		{
			if (cb_getBizId == null)
				cb_getBizId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBizId);
			return cb_getBizId;
		}

		static IntPtr n_GetBizId (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BizId);
		}
#pragma warning restore 0169

		static Delegate cb_setBizId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBizId_Ljava_lang_String_Handler ()
		{
			if (cb_setBizId_Ljava_lang_String_ == null)
				cb_setBizId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBizId_Ljava_lang_String_);
			return cb_setBizId_Ljava_lang_String_;
		}

		static void n_SetBizId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BizId = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBizId;
		IntPtr id_setBizId_Ljava_lang_String_;
		public unsafe string BizId {
			get {
				if (id_getBizId == IntPtr.Zero)
					id_getBizId = JNIEnv.GetMethodID (class_ref, "getBizId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBizId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBizId_Ljava_lang_String_ == IntPtr.Zero)
					id_setBizId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBizId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBizId_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getBodyEntry;
#pragma warning disable 0169
		static Delegate GetGetBodyEntryHandler ()
		{
			if (cb_getBodyEntry == null)
				cb_getBodyEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyEntry);
			return cb_getBodyEntry;
		}

		static IntPtr n_GetBodyEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyEntry);
		}
#pragma warning restore 0169

		static Delegate cb_setBodyEntry_Lanet_channel_request_BodyEntry_;
#pragma warning disable 0169
		static Delegate GetSetBodyEntry_Lanet_channel_request_BodyEntry_Handler ()
		{
			if (cb_setBodyEntry_Lanet_channel_request_BodyEntry_ == null)
				cb_setBodyEntry_Lanet_channel_request_BodyEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBodyEntry_Lanet_channel_request_BodyEntry_);
			return cb_setBodyEntry_Lanet_channel_request_BodyEntry_;
		}

		static void n_SetBodyEntry_Lanet_channel_request_BodyEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anet.Channel.Request.IBodyEntry p0 = (global::Anet.Channel.Request.IBodyEntry)global::Java.Lang.Object.GetObject<global::Anet.Channel.Request.IBodyEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BodyEntry = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBodyEntry;
		IntPtr id_setBodyEntry_Lanet_channel_request_BodyEntry_;
		public unsafe global::Anet.Channel.Request.IBodyEntry BodyEntry {
			get {
				if (id_getBodyEntry == IntPtr.Zero)
					id_getBodyEntry = JNIEnv.GetMethodID (class_ref, "getBodyEntry", "()Lanet/channel/request/BodyEntry;");
				return global::Java.Lang.Object.GetObject<global::Anet.Channel.Request.IBodyEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBodyEntry), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBodyEntry_Lanet_channel_request_BodyEntry_ == IntPtr.Zero)
					id_setBodyEntry_Lanet_channel_request_BodyEntry_ = JNIEnv.GetMethodID (class_ref, "setBodyEntry", "(Lanet/channel/request/BodyEntry;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBodyEntry_Lanet_channel_request_BodyEntry_, __args);
			}
		}

		static Delegate cb_getBodyHandler;
#pragma warning disable 0169
		static Delegate GetGetBodyHandlerHandler ()
		{
			if (cb_getBodyHandler == null)
				cb_getBodyHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyHandler);
			return cb_getBodyHandler;
		}

		static IntPtr n_GetBodyHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyHandler);
		}
#pragma warning restore 0169

		static Delegate cb_setBodyHandler_Lanetwork_channel_IBodyHandler_;
#pragma warning disable 0169
		static Delegate GetSetBodyHandler_Lanetwork_channel_IBodyHandler_Handler ()
		{
			if (cb_setBodyHandler_Lanetwork_channel_IBodyHandler_ == null)
				cb_setBodyHandler_Lanetwork_channel_IBodyHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBodyHandler_Lanetwork_channel_IBodyHandler_);
			return cb_setBodyHandler_Lanetwork_channel_IBodyHandler_;
		}

		static void n_SetBodyHandler_Lanetwork_channel_IBodyHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IBodyHandler p0 = (global::Anetwork.Channel.IBodyHandler)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IBodyHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BodyHandler = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBodyHandler;
		IntPtr id_setBodyHandler_Lanetwork_channel_IBodyHandler_;
		public unsafe global::Anetwork.Channel.IBodyHandler BodyHandler {
			get {
				if (id_getBodyHandler == IntPtr.Zero)
					id_getBodyHandler = JNIEnv.GetMethodID (class_ref, "getBodyHandler", "()Lanetwork/channel/IBodyHandler;");
				return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IBodyHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBodyHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBodyHandler_Lanetwork_channel_IBodyHandler_ == IntPtr.Zero)
					id_setBodyHandler_Lanetwork_channel_IBodyHandler_ = JNIEnv.GetMethodID (class_ref, "setBodyHandler", "(Lanetwork/channel/IBodyHandler;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBodyHandler_Lanetwork_channel_IBodyHandler_, __args);
			}
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset);
		}
#pragma warning restore 0169

		static Delegate cb_setCharset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCharset_Ljava_lang_String_Handler ()
		{
			if (cb_setCharset_Ljava_lang_String_ == null)
				cb_setCharset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCharset_Ljava_lang_String_);
			return cb_setCharset_Ljava_lang_String_;
		}

		static void n_SetCharset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Charset = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCharset;
		IntPtr id_setCharset_Ljava_lang_String_;
		public unsafe string Charset {
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCharset_Ljava_lang_String_ == IntPtr.Zero)
					id_setCharset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCharset", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharset_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getConnectTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectTimeoutHandler ()
		{
			if (cb_getConnectTimeout == null)
				cb_getConnectTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectTimeout);
			return cb_getConnectTimeout;
		}

		static int n_GetConnectTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectTimeout = p0;
		}
#pragma warning restore 0169

		IntPtr id_getConnectTimeout;
		IntPtr id_setConnectTimeout_I;
		public unsafe int ConnectTimeout {
			get {
				if (id_getConnectTimeout == IntPtr.Zero)
					id_getConnectTimeout = JNIEnv.GetMethodID (class_ref, "getConnectTimeout", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectTimeout);
			}
			set {
				if (id_setConnectTimeout_I == IntPtr.Zero)
					id_setConnectTimeout_I = JNIEnv.GetMethodID (class_ref, "setConnectTimeout", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectTimeout_I, __args);
			}
		}

		static Delegate cb_isCookieEnabled;
#pragma warning disable 0169
		static Delegate GetIsCookieEnabledHandler ()
		{
			if (cb_isCookieEnabled == null)
				cb_isCookieEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCookieEnabled);
			return cb_isCookieEnabled;
		}

		static bool n_IsCookieEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CookieEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setCookieEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetCookieEnabled_ZHandler ()
		{
			if (cb_setCookieEnabled_Z == null)
				cb_setCookieEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCookieEnabled_Z);
			return cb_setCookieEnabled_Z;
		}

		static void n_SetCookieEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CookieEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCookieEnabled;
		IntPtr id_setCookieEnabled_Z;
		public unsafe bool CookieEnabled {
			get {
				if (id_isCookieEnabled == IntPtr.Zero)
					id_isCookieEnabled = JNIEnv.GetMethodID (class_ref, "isCookieEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCookieEnabled);
			}
			set {
				if (id_setCookieEnabled_Z == IntPtr.Zero)
					id_setCookieEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCookieEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCookieEnabled_Z, __args);
			}
		}

		static Delegate cb_getExtProperties;
#pragma warning disable 0169
		static Delegate GetGetExtPropertiesHandler ()
		{
			if (cb_getExtProperties == null)
				cb_getExtProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtProperties);
			return cb_getExtProperties;
		}

		static IntPtr n_GetExtProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ExtProperties);
		}
#pragma warning restore 0169

		IntPtr id_getExtProperties;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ExtProperties {
			get {
				if (id_getExtProperties == IntPtr.Zero)
					id_getExtProperties = JNIEnv.GetMethodID (class_ref, "getExtProperties", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtProperties), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFollowRedirects;
#pragma warning disable 0169
		static Delegate GetGetFollowRedirectsHandler ()
		{
			if (cb_getFollowRedirects == null)
				cb_getFollowRedirects = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetFollowRedirects);
			return cb_getFollowRedirects;
		}

		static bool n_GetFollowRedirects (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FollowRedirects;
		}
#pragma warning restore 0169

		static Delegate cb_setFollowRedirects_Z;
#pragma warning disable 0169
		static Delegate GetSetFollowRedirects_ZHandler ()
		{
			if (cb_setFollowRedirects_Z == null)
				cb_setFollowRedirects_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFollowRedirects_Z);
			return cb_setFollowRedirects_Z;
		}

		static void n_SetFollowRedirects_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FollowRedirects = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFollowRedirects;
		IntPtr id_setFollowRedirects_Z;
		public unsafe bool FollowRedirects {
			get {
				if (id_getFollowRedirects == IntPtr.Zero)
					id_getFollowRedirects = JNIEnv.GetMethodID (class_ref, "getFollowRedirects", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFollowRedirects);
			}
			set {
				if (id_setFollowRedirects_Z == IntPtr.Zero)
					id_setFollowRedirects_Z = JNIEnv.GetMethodID (class_ref, "setFollowRedirects", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFollowRedirects_Z, __args);
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Anetwork.Channel.IHeader>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_List_Handler ()
		{
			if (cb_setHeaders_Ljava_util_List_ == null)
				cb_setHeaders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_List_);
			return cb_setHeaders_Ljava_util_List_;
		}

		static void n_SetHeaders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Anetwork.Channel.IHeader>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		IntPtr id_setHeaders_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Anetwork.Channel.IHeader> Headers {
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Anetwork.Channel.IHeader>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setHeaders_Ljava_util_List_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Anetwork.Channel.IHeader>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static Delegate cb_setMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setMethod_Ljava_lang_String_ == null)
				cb_setMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMethod_Ljava_lang_String_);
			return cb_setMethod_Ljava_lang_String_;
		}

		static void n_SetMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Method = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMethod;
		IntPtr id_setMethod_Ljava_lang_String_;
		public unsafe string Method {
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMethod_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Anetwork.Channel.IParam>.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		static Delegate cb_setParams_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParams_Ljava_util_List_Handler ()
		{
			if (cb_setParams_Ljava_util_List_ == null)
				cb_setParams_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParams_Ljava_util_List_);
			return cb_setParams_Ljava_util_List_;
		}

		static void n_SetParams_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Anetwork.Channel.IParam>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Params = p0;
		}
#pragma warning restore 0169

		IntPtr id_getParams;
		IntPtr id_setParams_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Anetwork.Channel.IParam> Params {
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Anetwork.Channel.IParam>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setParams_Ljava_util_List_ == IntPtr.Zero)
					id_setParams_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setParams", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Anetwork.Channel.IParam>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParams_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isProtocolModifiable;
#pragma warning disable 0169
		static Delegate GetIsProtocolModifiableHandler ()
		{
			if (cb_isProtocolModifiable == null)
				cb_isProtocolModifiable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProtocolModifiable);
			return cb_isProtocolModifiable;
		}

		static bool n_IsProtocolModifiable (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProtocolModifiable;
		}
#pragma warning restore 0169

		static Delegate cb_setProtocolModifiable_Z;
#pragma warning disable 0169
		static Delegate GetSetProtocolModifiable_ZHandler ()
		{
			if (cb_setProtocolModifiable_Z == null)
				cb_setProtocolModifiable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProtocolModifiable_Z);
			return cb_setProtocolModifiable_Z;
		}

		static void n_SetProtocolModifiable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProtocolModifiable = p0;
		}
#pragma warning restore 0169

		IntPtr id_isProtocolModifiable;
		IntPtr id_setProtocolModifiable_Z;
		public unsafe bool ProtocolModifiable {
			get {
				if (id_isProtocolModifiable == IntPtr.Zero)
					id_isProtocolModifiable = JNIEnv.GetMethodID (class_ref, "isProtocolModifiable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProtocolModifiable);
			}
			set {
				if (id_setProtocolModifiable_Z == IntPtr.Zero)
					id_setProtocolModifiable_Z = JNIEnv.GetMethodID (class_ref, "setProtocolModifiable", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProtocolModifiable_Z, __args);
			}
		}

		static Delegate cb_getReadTimeout;
#pragma warning disable 0169
		static Delegate GetGetReadTimeoutHandler ()
		{
			if (cb_getReadTimeout == null)
				cb_getReadTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadTimeout);
			return cb_getReadTimeout;
		}

		static int n_GetReadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setReadTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeout_IHandler ()
		{
			if (cb_setReadTimeout_I == null)
				cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeout_I);
			return cb_setReadTimeout_I;
		}

		static void n_SetReadTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadTimeout = p0;
		}
#pragma warning restore 0169

		IntPtr id_getReadTimeout;
		IntPtr id_setReadTimeout_I;
		public unsafe int ReadTimeout {
			get {
				if (id_getReadTimeout == IntPtr.Zero)
					id_getReadTimeout = JNIEnv.GetMethodID (class_ref, "getReadTimeout", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReadTimeout);
			}
			set {
				if (id_setReadTimeout_I == IntPtr.Zero)
					id_setReadTimeout_I = JNIEnv.GetMethodID (class_ref, "setReadTimeout", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadTimeout_I, __args);
			}
		}

		static Delegate cb_getRetryTime;
#pragma warning disable 0169
		static Delegate GetGetRetryTimeHandler ()
		{
			if (cb_getRetryTime == null)
				cb_getRetryTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryTime);
			return cb_getRetryTime;
		}

		static int n_GetRetryTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryTime;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryTime_I;
#pragma warning disable 0169
		static Delegate GetSetRetryTime_IHandler ()
		{
			if (cb_setRetryTime_I == null)
				cb_setRetryTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRetryTime_I);
			return cb_setRetryTime_I;
		}

		static void n_SetRetryTime_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRetryTime;
		IntPtr id_setRetryTime_I;
		public unsafe int RetryTime {
			get {
				if (id_getRetryTime == IntPtr.Zero)
					id_getRetryTime = JNIEnv.GetMethodID (class_ref, "getRetryTime", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryTime);
			}
			set {
				if (id_setRetryTime_I == IntPtr.Zero)
					id_setRetryTime_I = JNIEnv.GetMethodID (class_ref, "setRetryTime", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetryTime_I, __args);
			}
		}

		static Delegate cb_getSeqNo;
#pragma warning disable 0169
		static Delegate GetGetSeqNoHandler ()
		{
			if (cb_getSeqNo == null)
				cb_getSeqNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeqNo);
			return cb_getSeqNo;
		}

		static IntPtr n_GetSeqNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SeqNo);
		}
#pragma warning restore 0169

		static Delegate cb_setSeqNo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSeqNo_Ljava_lang_String_Handler ()
		{
			if (cb_setSeqNo_Ljava_lang_String_ == null)
				cb_setSeqNo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSeqNo_Ljava_lang_String_);
			return cb_setSeqNo_Ljava_lang_String_;
		}

		static void n_SetSeqNo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SeqNo = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSeqNo;
		IntPtr id_setSeqNo_Ljava_lang_String_;
		public unsafe string SeqNo {
			get {
				if (id_getSeqNo == IntPtr.Zero)
					id_getSeqNo = JNIEnv.GetMethodID (class_ref, "getSeqNo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeqNo), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSeqNo_Ljava_lang_String_ == IntPtr.Zero)
					id_setSeqNo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSeqNo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSeqNo_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URI);
		}
#pragma warning restore 0169

		IntPtr id_getURI;
		public unsafe global::Java.Net.URI URI {
			get {
				if (id_getURI == IntPtr.Zero)
					id_getURI = JNIEnv.GetMethodID (class_ref, "getURI", "()Ljava/net/URI;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURI), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getURL;
#pragma warning disable 0169
		static Delegate GetGetURLHandler ()
		{
			if (cb_getURL == null)
				cb_getURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURL);
			return cb_getURL;
		}

		static IntPtr n_GetURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URL);
		}
#pragma warning restore 0169

		IntPtr id_getURL;
		public unsafe global::Java.Net.URL URL {
			get {
				if (id_getURL == IntPtr.Zero)
					id_getURL = JNIEnv.GetMethodID (class_ref, "getURL", "()Ljava/net/URL;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURL), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getExtProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExtProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getExtProperty_Ljava_lang_String_ == null)
				cb_getExtProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExtProperty_Ljava_lang_String_);
			return cb_getExtProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetExtProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetExtProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getExtProperty_Ljava_lang_String_;
		public unsafe string GetExtProperty (string p0)
		{
			if (id_getExtProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExtProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getHeaders_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHeaders_Ljava_lang_String_Handler ()
		{
			if (cb_getHeaders_Ljava_lang_String_ == null)
				cb_getHeaders_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeaders_Ljava_lang_String_);
			return cb_getHeaders_Ljava_lang_String_;
		}

		static IntPtr n_GetHeaders_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetHeaders (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeaders_Ljava_lang_String_;
		public unsafe global::Anetwork.Channel.IHeader[] GetHeaders (string p0)
		{
			if (id_getHeaders_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeaders_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeaders", "(Ljava/lang/String;)[Lanetwork/channel/Header;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Anetwork.Channel.IHeader[] __ret = (global::Anetwork.Channel.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Anetwork.Channel.IHeader));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeHeader_Lanetwork_channel_Header_;
#pragma warning disable 0169
		static Delegate GetRemoveHeader_Lanetwork_channel_Header_Handler ()
		{
			if (cb_removeHeader_Lanetwork_channel_Header_ == null)
				cb_removeHeader_Lanetwork_channel_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveHeader_Lanetwork_channel_Header_);
			return cb_removeHeader_Lanetwork_channel_Header_;
		}

		static void n_RemoveHeader_Lanetwork_channel_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IHeader p0 = (global::Anetwork.Channel.IHeader)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHeader (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeHeader_Lanetwork_channel_Header_;
		public unsafe void RemoveHeader (global::Anetwork.Channel.IHeader p0)
		{
			if (id_removeHeader_Lanetwork_channel_Header_ == IntPtr.Zero)
				id_removeHeader_Lanetwork_channel_Header_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Lanetwork/channel/Header;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeHeader_Lanetwork_channel_Header_, __args);
		}

		static Delegate cb_setBizId_I;
#pragma warning disable 0169
		static Delegate GetSetBizId_IHandler ()
		{
			if (cb_setBizId_I == null)
				cb_setBizId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBizId_I);
			return cb_setBizId_I;
		}

		static void n_SetBizId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBizId (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBizId_I;
		public unsafe void SetBizId (int p0)
		{
			if (id_setBizId_I == IntPtr.Zero)
				id_setBizId_I = JNIEnv.GetMethodID (class_ref, "setBizId", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBizId_I, __args);
		}

		static Delegate cb_setExtProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setExtProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setExtProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setExtProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetExtProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetExtProperty (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setExtProperty_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetExtProperty (string p0, string p1)
		{
			if (id_setExtProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setExtProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExtProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtProperty_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setHeader_Lanetwork_channel_Header_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Lanetwork_channel_Header_Handler ()
		{
			if (cb_setHeader_Lanetwork_channel_Header_ == null)
				cb_setHeader_Lanetwork_channel_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeader_Lanetwork_channel_Header_);
			return cb_setHeader_Lanetwork_channel_Header_;
		}

		static void n_SetHeader_Lanetwork_channel_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.IHeader p0 = (global::Anetwork.Channel.IHeader)global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0);
		}
#pragma warning restore 0169

		IntPtr id_setHeader_Lanetwork_channel_Header_;
		public unsafe void SetHeader (global::Anetwork.Channel.IHeader p0)
		{
			if (id_setHeader_Lanetwork_channel_Header_ == IntPtr.Zero)
				id_setHeader_Lanetwork_channel_Header_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Lanetwork/channel/Header;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Lanetwork_channel_Header_, __args);
		}

		static Delegate cb_setUri_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetUri_Ljava_net_URI_Handler ()
		{
			if (cb_setUri_Ljava_net_URI_ == null)
				cb_setUri_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUri_Ljava_net_URI_);
			return cb_setUri_Ljava_net_URI_;
		}

		static void n_SetUri_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.IRequest __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUri (p0);
		}
#pragma warning restore 0169

		IntPtr id_setUri_Ljava_net_URI_;
		public unsafe void SetUri (global::Java.Net.URI p0)
		{
			if (id_setUri_Ljava_net_URI_ == IntPtr.Zero)
				id_setUri_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "setUri", "(Ljava/net/URI;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUri_Ljava_net_URI_, __args);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']"
	[Register ("com/taobao/accs/ILoginInfo", "", "Com.Taobao.Accs.ILoginInfoInvoker")]
	public partial interface ILoginInfo : IJavaObject {

		bool CommentUsed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getCommentUsed' and count(parameter)=0]"
			[Register ("getCommentUsed", "()Z", "GetGetCommentUsedHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string Ecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getEcode' and count(parameter)=0]"
			[Register ("getEcode", "()Ljava/lang/String;", "GetGetEcodeHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string HeadPicLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getHeadPicLink' and count(parameter)=0]"
			[Register ("getHeadPicLink", "()Ljava/lang/String;", "GetGetHeadPicLinkHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string Nick {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getNick' and count(parameter)=0]"
			[Register ("getNick", "()Ljava/lang/String;", "GetGetNickHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()Ljava/lang/String;", "GetGetSidHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string SsoToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getSsoToken' and count(parameter)=0]"
			[Register ("getSsoToken", "()Ljava/lang/String;", "GetGetSsoTokenHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

		string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='ILoginInfo']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler:Com.Taobao.Accs.ILoginInfoInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/taobao/accs/ILoginInfo", DoNotGenerateAcw=true)]
	internal class ILoginInfoInvoker : global::Java.Lang.Object, ILoginInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/ILoginInfo");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoginInfoInvoker); }
		}

		IntPtr class_ref;

		public static ILoginInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoginInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.ILoginInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoginInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCommentUsed;
#pragma warning disable 0169
		static Delegate GetGetCommentUsedHandler ()
		{
			if (cb_getCommentUsed == null)
				cb_getCommentUsed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCommentUsed);
			return cb_getCommentUsed;
		}

		static bool n_GetCommentUsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommentUsed;
		}
#pragma warning restore 0169

		IntPtr id_getCommentUsed;
		public unsafe bool CommentUsed {
			get {
				if (id_getCommentUsed == IntPtr.Zero)
					id_getCommentUsed = JNIEnv.GetMethodID (class_ref, "getCommentUsed", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getCommentUsed);
			}
		}

		static Delegate cb_getEcode;
#pragma warning disable 0169
		static Delegate GetGetEcodeHandler ()
		{
			if (cb_getEcode == null)
				cb_getEcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEcode);
			return cb_getEcode;
		}

		static IntPtr n_GetEcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ecode);
		}
#pragma warning restore 0169

		IntPtr id_getEcode;
		public unsafe string Ecode {
			get {
				if (id_getEcode == IntPtr.Zero)
					id_getEcode = JNIEnv.GetMethodID (class_ref, "getEcode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEcode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeadPicLink;
#pragma warning disable 0169
		static Delegate GetGetHeadPicLinkHandler ()
		{
			if (cb_getHeadPicLink == null)
				cb_getHeadPicLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeadPicLink);
			return cb_getHeadPicLink;
		}

		static IntPtr n_GetHeadPicLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeadPicLink);
		}
#pragma warning restore 0169

		IntPtr id_getHeadPicLink;
		public unsafe string HeadPicLink {
			get {
				if (id_getHeadPicLink == IntPtr.Zero)
					id_getHeadPicLink = JNIEnv.GetMethodID (class_ref, "getHeadPicLink", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeadPicLink), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNick;
#pragma warning disable 0169
		static Delegate GetGetNickHandler ()
		{
			if (cb_getNick == null)
				cb_getNick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNick);
			return cb_getNick;
		}

		static IntPtr n_GetNick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nick);
		}
#pragma warning restore 0169

		IntPtr id_getNick;
		public unsafe string Nick {
			get {
				if (id_getNick == IntPtr.Zero)
					id_getNick = JNIEnv.GetMethodID (class_ref, "getNick", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNick), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSid;
#pragma warning disable 0169
		static Delegate GetGetSidHandler ()
		{
			if (cb_getSid == null)
				cb_getSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSid);
			return cb_getSid;
		}

		static IntPtr n_GetSid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sid);
		}
#pragma warning restore 0169

		IntPtr id_getSid;
		public unsafe string Sid {
			get {
				if (id_getSid == IntPtr.Zero)
					id_getSid = JNIEnv.GetMethodID (class_ref, "getSid", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSid), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSsoToken;
#pragma warning disable 0169
		static Delegate GetGetSsoTokenHandler ()
		{
			if (cb_getSsoToken == null)
				cb_getSsoToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSsoToken);
			return cb_getSsoToken;
		}

		static IntPtr n_GetSsoToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SsoToken);
		}
#pragma warning restore 0169

		IntPtr id_getSsoToken;
		public unsafe string SsoToken {
			get {
				if (id_getSsoToken == IntPtr.Zero)
					id_getSsoToken = JNIEnv.GetMethodID (class_ref, "getSsoToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSsoToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.ILoginInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		IntPtr id_getUserId;
		public unsafe string UserId {
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

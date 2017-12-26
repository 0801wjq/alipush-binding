using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']"
	[Register ("anetwork/channel/Response", "", "Anetwork.Channel.IResponseInvoker")]
	public partial interface IResponse : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ConnHeadFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getConnHeadFields' and count(parameter)=0]"
			[Register ("getConnHeadFields", "()Ljava/util/Map;", "GetGetConnHeadFieldsHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")] get;
		}

		string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")] get;
		}

		global::Java.Lang.Throwable Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/Throwable;", "GetGetErrorHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")] get;
		}

		global::Anetwork.Channel.Statist.StatisticData StatisticData {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getStatisticData' and count(parameter)=0]"
			[Register ("getStatisticData", "()Lanetwork/channel/statist/StatisticData;", "GetGetStatisticDataHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")] get;
		}

		int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='Response']/method[@name='getBytedata' and count(parameter)=0]"
		[Register ("getBytedata", "()[B", "GetGetBytedataHandler:Anetwork.Channel.IResponseInvoker, AliPush.Binding.Android")]
		byte[] GetBytedata ();

	}

	[global::Android.Runtime.Register ("anetwork/channel/Response", DoNotGenerateAcw=true)]
	internal class IResponseInvoker : global::Java.Lang.Object, IResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/Response");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResponseInvoker); }
		}

		IntPtr class_ref;

		public static IResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.Response"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getConnHeadFields;
#pragma warning disable 0169
		static Delegate GetGetConnHeadFieldsHandler ()
		{
			if (cb_getConnHeadFields == null)
				cb_getConnHeadFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnHeadFields);
			return cb_getConnHeadFields;
		}

		static IntPtr n_GetConnHeadFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.ConnHeadFields);
		}
#pragma warning restore 0169

		IntPtr id_getConnHeadFields;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ConnHeadFields {
			get {
				if (id_getConnHeadFields == IntPtr.Zero)
					id_getConnHeadFields = JNIEnv.GetMethodID (class_ref, "getConnHeadFields", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnHeadFields), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDesc;
#pragma warning disable 0169
		static Delegate GetGetDescHandler ()
		{
			if (cb_getDesc == null)
				cb_getDesc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDesc);
			return cb_getDesc;
		}

		static IntPtr n_GetDesc (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Desc);
		}
#pragma warning restore 0169

		IntPtr id_getDesc;
		public unsafe string Desc {
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		IntPtr id_getError;
		public unsafe global::Java.Lang.Throwable Error {
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/Throwable;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatisticData;
#pragma warning disable 0169
		static Delegate GetGetStatisticDataHandler ()
		{
			if (cb_getStatisticData == null)
				cb_getStatisticData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatisticData);
			return cb_getStatisticData;
		}

		static IntPtr n_GetStatisticData (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatisticData);
		}
#pragma warning restore 0169

		IntPtr id_getStatisticData;
		public unsafe global::Anetwork.Channel.Statist.StatisticData StatisticData {
			get {
				if (id_getStatisticData == IntPtr.Zero)
					id_getStatisticData = JNIEnv.GetMethodID (class_ref, "getStatisticData", "()Lanetwork/channel/statist/StatisticData;");
				return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Statist.StatisticData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatisticData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		IntPtr id_getStatusCode;
		public unsafe int StatusCode {
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode);
			}
		}

		static Delegate cb_getBytedata;
#pragma warning disable 0169
		static Delegate GetGetBytedataHandler ()
		{
			if (cb_getBytedata == null)
				cb_getBytedata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBytedata);
			return cb_getBytedata;
		}

		static IntPtr n_GetBytedata (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.IResponse __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytedata ());
		}
#pragma warning restore 0169

		IntPtr id_getBytedata;
		public unsafe byte[] GetBytedata ()
		{
			if (id_getBytedata == IntPtr.Zero)
				id_getBytedata = JNIEnv.GetMethodID (class_ref, "getBytedata", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytedata), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Stat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.stat']/interface[@name='INetworkStat']"
	[Register ("anetwork/channel/stat/INetworkStat", "", "Anetwork.Channel.Stat.INetworkStatInvoker")]
	public partial interface INetworkStat : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.stat']/interface[@name='INetworkStat']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler:Anetwork.Channel.Stat.INetworkStatInvoker, AliPush.Binding.Android")]
		string Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.stat']/interface[@name='INetworkStat']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='anetwork.channel.statist.StatisticData']]"
		[Register ("put", "(Ljava/lang/String;Lanetwork/channel/statist/StatisticData;)V", "GetPut_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_Handler:Anetwork.Channel.Stat.INetworkStatInvoker, AliPush.Binding.Android")]
		void Put (string p0, global::Anetwork.Channel.Statist.StatisticData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.stat']/interface[@name='INetworkStat']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reset", "(Ljava/lang/String;)V", "GetReset_Ljava_lang_String_Handler:Anetwork.Channel.Stat.INetworkStatInvoker, AliPush.Binding.Android")]
		void Reset (string p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/stat/INetworkStat", DoNotGenerateAcw=true)]
	internal class INetworkStatInvoker : global::Java.Lang.Object, INetworkStat {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/stat/INetworkStat");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkStatInvoker); }
		}

		IntPtr class_ref;

		public static INetworkStat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkStat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.stat.INetworkStat"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkStatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Anetwork.Channel.Stat.INetworkStat __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Stat.INetworkStat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_ == null)
				cb_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_);
			return cb_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_;
		}

		static void n_Put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Anetwork.Channel.Stat.INetworkStat __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Stat.INetworkStat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Anetwork.Channel.Statist.StatisticData p1 = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Statist.StatisticData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_;
		public unsafe void Put (string p0, global::Anetwork.Channel.Statist.StatisticData p1)
		{
			if (id_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lanetwork/channel/statist/StatisticData;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lanetwork_channel_statist_StatisticData_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_reset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReset_Ljava_lang_String_Handler ()
		{
			if (cb_reset_Ljava_lang_String_ == null)
				cb_reset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Reset_Ljava_lang_String_);
			return cb_reset_Ljava_lang_String_;
		}

		static void n_Reset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.Stat.INetworkStat __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Stat.INetworkStat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reset (p0);
		}
#pragma warning restore 0169

		IntPtr id_reset_Ljava_lang_String_;
		public unsafe void Reset (string p0)
		{
			if (id_reset_Ljava_lang_String_ == IntPtr.Zero)
				id_reset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reset", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

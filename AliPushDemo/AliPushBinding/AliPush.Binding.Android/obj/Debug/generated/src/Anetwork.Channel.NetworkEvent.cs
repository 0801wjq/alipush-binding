using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel']/class[@name='NetworkEvent']"
	[global::Android.Runtime.Register ("anetwork/channel/NetworkEvent", DoNotGenerateAcw=true)]
	public sealed partial class NetworkEvent : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.FinishEvent']"
		[Register ("anetwork/channel/NetworkEvent$FinishEvent", "", "Anetwork.Channel.NetworkEvent/IFinishEventInvoker")]
		public partial interface IFinishEvent : IJavaObject {

			string Desc {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.FinishEvent']/method[@name='getDesc' and count(parameter)=0]"
				[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler:Anetwork.Channel.NetworkEvent/IFinishEventInvoker, AliPush.Binding.Android")] get;
			}

			int HttpCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.FinishEvent']/method[@name='getHttpCode' and count(parameter)=0]"
				[Register ("getHttpCode", "()I", "GetGetHttpCodeHandler:Anetwork.Channel.NetworkEvent/IFinishEventInvoker, AliPush.Binding.Android")] get;
			}

			global::Anetwork.Channel.Statist.StatisticData StatisticData {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.FinishEvent']/method[@name='getStatisticData' and count(parameter)=0]"
				[Register ("getStatisticData", "()Lanetwork/channel/statist/StatisticData;", "GetGetStatisticDataHandler:Anetwork.Channel.NetworkEvent/IFinishEventInvoker, AliPush.Binding.Android")] get;
			}

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkEvent$FinishEvent", DoNotGenerateAcw=true)]
		internal class IFinishEventInvoker : global::Java.Lang.Object, IFinishEvent {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkEvent$FinishEvent");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFinishEventInvoker); }
			}

			IntPtr class_ref;

			public static IFinishEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFinishEvent> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkEvent.FinishEvent"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFinishEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Anetwork.Channel.NetworkEvent.IFinishEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IFinishEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_getHttpCode;
#pragma warning disable 0169
			static Delegate GetGetHttpCodeHandler ()
			{
				if (cb_getHttpCode == null)
					cb_getHttpCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHttpCode);
				return cb_getHttpCode;
			}

			static int n_GetHttpCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Anetwork.Channel.NetworkEvent.IFinishEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IFinishEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HttpCode;
			}
#pragma warning restore 0169

			IntPtr id_getHttpCode;
			public unsafe int HttpCode {
				get {
					if (id_getHttpCode == IntPtr.Zero)
						id_getHttpCode = JNIEnv.GetMethodID (class_ref, "getHttpCode", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHttpCode);
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
				global::Anetwork.Channel.NetworkEvent.IFinishEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IFinishEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']"
		[Register ("anetwork/channel/NetworkEvent$ProgressEvent", "", "Anetwork.Channel.NetworkEvent/IProgressEventInvoker")]
		public partial interface IProgressEvent : IJavaObject {

			string Desc {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']/method[@name='getDesc' and count(parameter)=0]"
				[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler:Anetwork.Channel.NetworkEvent/IProgressEventInvoker, AliPush.Binding.Android")] get;
			}

			int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler:Anetwork.Channel.NetworkEvent/IProgressEventInvoker, AliPush.Binding.Android")] get;
			}

			int Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()I", "GetGetSizeHandler:Anetwork.Channel.NetworkEvent/IProgressEventInvoker, AliPush.Binding.Android")] get;
			}

			int Total {
				// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']/method[@name='getTotal' and count(parameter)=0]"
				[Register ("getTotal", "()I", "GetGetTotalHandler:Anetwork.Channel.NetworkEvent/IProgressEventInvoker, AliPush.Binding.Android")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='NetworkEvent.ProgressEvent']/method[@name='getBytedata' and count(parameter)=0]"
			[Register ("getBytedata", "()[B", "GetGetBytedataHandler:Anetwork.Channel.NetworkEvent/IProgressEventInvoker, AliPush.Binding.Android")]
			byte[] GetBytedata ();

		}

		[global::Android.Runtime.Register ("anetwork/channel/NetworkEvent$ProgressEvent", DoNotGenerateAcw=true)]
		internal class IProgressEventInvoker : global::Java.Lang.Object, IProgressEvent {

			static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/NetworkEvent$ProgressEvent");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProgressEventInvoker); }
			}

			IntPtr class_ref;

			public static IProgressEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressEvent> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.NetworkEvent.ProgressEvent"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Anetwork.Channel.NetworkEvent.IProgressEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Anetwork.Channel.NetworkEvent.IProgressEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			IntPtr id_getIndex;
			public unsafe int Index {
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndex);
				}
			}

			static Delegate cb_getSize;
#pragma warning disable 0169
			static Delegate GetGetSizeHandler ()
			{
				if (cb_getSize == null)
					cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
				return cb_getSize;
			}

			static int n_GetSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Anetwork.Channel.NetworkEvent.IProgressEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size;
			}
#pragma warning restore 0169

			IntPtr id_getSize;
			public unsafe int Size {
				get {
					if (id_getSize == IntPtr.Zero)
						id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
				}
			}

			static Delegate cb_getTotal;
#pragma warning disable 0169
			static Delegate GetGetTotalHandler ()
			{
				if (cb_getTotal == null)
					cb_getTotal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotal);
				return cb_getTotal;
			}

			static int n_GetTotal (IntPtr jnienv, IntPtr native__this)
			{
				global::Anetwork.Channel.NetworkEvent.IProgressEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Total;
			}
#pragma warning restore 0169

			IntPtr id_getTotal;
			public unsafe int Total {
				get {
					if (id_getTotal == IntPtr.Zero)
						id_getTotal = JNIEnv.GetMethodID (class_ref, "getTotal", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotal);
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
				global::Anetwork.Channel.NetworkEvent.IProgressEvent __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.NetworkEvent.IProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/NetworkEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkEvent); }
		}

		internal NetworkEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Aidl.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableBodyHandlerWrapper']"
	[global::Android.Runtime.Register ("anetwork/channel/aidl/adapter/ParcelableBodyHandlerWrapper", DoNotGenerateAcw=true)]
	public partial class ParcelableBodyHandlerWrapper : global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/aidl/adapter/ParcelableBodyHandlerWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableBodyHandlerWrapper); }
		}

		protected ParcelableBodyHandlerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lanetwork_channel_IBodyHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableBodyHandlerWrapper']/constructor[@name='ParcelableBodyHandlerWrapper' and count(parameter)=1 and parameter[1][@type='anetwork.channel.IBodyHandler']]"
		[Register (".ctor", "(Lanetwork/channel/IBodyHandler;)V", "")]
		public unsafe ParcelableBodyHandlerWrapper (global::Anetwork.Channel.IBodyHandler p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ParcelableBodyHandlerWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lanetwork/channel/IBodyHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lanetwork/channel/IBodyHandler;)V", __args);
					return;
				}

				if (id_ctor_Lanetwork_channel_IBodyHandler_ == IntPtr.Zero)
					id_ctor_Lanetwork_channel_IBodyHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lanetwork/channel/IBodyHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lanetwork_channel_IBodyHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lanetwork_channel_IBodyHandler_, __args);
			} finally {
			}
		}

		static Delegate cb_isCompleted;
#pragma warning disable 0169
		static Delegate GetIsCompletedHandler ()
		{
			if (cb_isCompleted == null)
				cb_isCompleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompleted);
			return cb_isCompleted;
		}

		static bool n_IsCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableBodyHandlerWrapper __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableBodyHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompleted;
		}
#pragma warning restore 0169

		static IntPtr id_isCompleted;
		public override unsafe bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableBodyHandlerWrapper']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "GetIsCompletedHandler")]
			get {
				if (id_isCompleted == IntPtr.Zero)
					id_isCompleted = JNIEnv.GetMethodID (class_ref, "isCompleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCompleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_read_arrayB;
#pragma warning disable 0169
		static Delegate GetRead_arrayBHandler ()
		{
			if (cb_read_arrayB == null)
				cb_read_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayB);
			return cb_read_arrayB;
		}

		static int n_Read_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableBodyHandlerWrapper __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableBodyHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableBodyHandlerWrapper']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public override unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([B)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}

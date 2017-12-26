using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Aidl.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']"
	[global::Android.Runtime.Register ("anetwork/channel/aidl/adapter/ParcelableInputStreamImpl", DoNotGenerateAcw=true)]
	public partial class ParcelableInputStreamImpl : global::Anetwork.Channel.Aidl.ParcelableInputStreamStub {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/aidl/adapter/ParcelableInputStreamImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableInputStreamImpl); }
		}

		protected ParcelableInputStreamImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/constructor[@name='ParcelableInputStreamImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParcelableInputStreamImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ParcelableInputStreamImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_available;
#pragma warning disable 0169
		static Delegate GetAvailableHandler ()
		{
			if (cb_available == null)
				cb_available = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Available);
			return cb_available;
		}

		static int n_Available (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Available ();
		}
#pragma warning restore 0169

		static IntPtr id_available;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "GetAvailableHandler")]
		public override unsafe int Available ()
		{
			if (id_available == IntPtr.Zero)
				id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "available", "()I"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public override unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
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
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static Delegate cb_readByte;
#pragma warning disable 0169
		static Delegate GetReadByteHandler ()
		{
			if (cb_readByte == null)
				cb_readByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadByte);
			return cb_readByte;
		}

		static int n_ReadByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadByte ();
		}
#pragma warning restore 0169

		static IntPtr id_readByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()I", "GetReadByteHandler")]
		public override unsafe int ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readByte);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByte", "()I"));
			} finally {
			}
		}

		static Delegate cb_readBytes_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadBytes_arrayBIIHandler ()
		{
			if (cb_readBytes_arrayBII == null)
				cb_readBytes_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_ReadBytes_arrayBII);
			return cb_readBytes_arrayBII;
		}

		static int n_ReadBytes_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadBytes (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readBytes", "([BII)I", "GetReadBytes_arrayBIIHandler")]
		public override unsafe int ReadBytes (byte[] p0, int p1, int p2)
		{
			if (id_readBytes_arrayBII == IntPtr.Zero)
				id_readBytes_arrayBII = JNIEnv.GetMethodID (class_ref, "readBytes", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_arrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readBytes", "([BII)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_Skip_I);
			return cb_skip_I;
		}

		static long n_Skip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)J", "GetSkip_IHandler")]
		public override unsafe long Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_writeEnd;
#pragma warning disable 0169
		static Delegate GetWriteEndHandler ()
		{
			if (cb_writeEnd == null)
				cb_writeEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteEnd);
			return cb_writeEnd;
		}

		static void n_WriteEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.Adapter.ParcelableInputStreamImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_writeEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ParcelableInputStreamImpl']/method[@name='writeEnd' and count(parameter)=0]"
		[Register ("writeEnd", "()V", "GetWriteEndHandler")]
		public virtual unsafe void WriteEnd ()
		{
			if (id_writeEnd == IntPtr.Zero)
				id_writeEnd = JNIEnv.GetMethodID (class_ref, "writeEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeEnd", "()V"));
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableInputStream.Stub']"
	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableInputStream$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ParcelableInputStreamStub : global::Android.OS.Binder, global::Anetwork.Channel.Aidl.IParcelableInputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/aidl/ParcelableInputStream$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableInputStreamStub); }
		}

		protected ParcelableInputStreamStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableInputStream.Stub']/constructor[@name='ParcelableInputStream.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParcelableInputStreamStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ParcelableInputStreamStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableInputStream.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableInputStream.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/ParcelableInputStream;", "")]
		public static unsafe global::Anetwork.Channel.Aidl.IParcelableInputStream AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/ParcelableInputStream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Anetwork.Channel.Aidl.IParcelableInputStream __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableInputStream.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Available ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "GetAvailableHandler")]
		public abstract int Available ();

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public abstract int Length ();

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public abstract int Read (byte[] p0);

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadByte ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()I", "GetReadByteHandler")]
		public abstract int ReadByte ();

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadBytes (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readBytes", "([BII)I", "GetReadBytes_arrayBIIHandler")]
		public abstract int ReadBytes (byte[] p0, int p1, int p2);

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
			global::Anetwork.Channel.Aidl.ParcelableInputStreamStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableInputStreamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)J", "GetSkip_IHandler")]
		public abstract long Skip (int p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableInputStream$Stub", DoNotGenerateAcw=true)]
	internal partial class ParcelableInputStreamStubInvoker : ParcelableInputStreamStub {

		public ParcelableInputStreamStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableInputStreamStubInvoker); }
		}

		static IntPtr id_available;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "GetAvailableHandler")]
		public override unsafe int Available ()
		{
			if (id_available == IntPtr.Zero)
				id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public override unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
			} finally {
			}
		}

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public override unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()I", "GetReadByteHandler")]
		public override unsafe int ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readByte);
			} finally {
			}
		}

		static IntPtr id_readBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)J", "GetSkip_IHandler")]
		public override unsafe long Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']"
	[Register ("anetwork/channel/aidl/ParcelableInputStream", "", "Anetwork.Channel.Aidl.IParcelableInputStreamInvoker")]
	public partial interface IParcelableInputStream : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "GetAvailableHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		int Available ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		int Length ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		int Read (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()I", "GetReadByteHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		int ReadByte ();

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readBytes", "([BII)I", "GetReadBytes_arrayBIIHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		int ReadBytes (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableInputStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)J", "GetSkip_IHandler:Anetwork.Channel.Aidl.IParcelableInputStreamInvoker, AliPush.Binding.Android")]
		long Skip (int p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableInputStream", DoNotGenerateAcw=true)]
	internal class IParcelableInputStreamInvoker : global::Java.Lang.Object, IParcelableInputStream {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/aidl/ParcelableInputStream");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IParcelableInputStreamInvoker); }
		}

		IntPtr class_ref;

		public static IParcelableInputStream GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParcelableInputStream> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.aidl.ParcelableInputStream"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParcelableInputStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Available ();
		}
#pragma warning restore 0169

		IntPtr id_available;
		public unsafe int Available ()
		{
			if (id_available == IntPtr.Zero)
				id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available);
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		IntPtr id_length;
		public unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayB;
		public unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadByte ();
		}
#pragma warning restore 0169

		IntPtr id_readByte;
		public unsafe int ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readByte);
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadBytes (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readBytes_arrayBII;
		public unsafe int ReadBytes (byte[] p0, int p1, int p2)
		{
			if (id_readBytes_arrayBII == IntPtr.Zero)
				id_readBytes_arrayBII = JNIEnv.GetMethodID (class_ref, "readBytes", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		IntPtr id_skip_I;
		public unsafe long Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.IParcelableInputStream __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}

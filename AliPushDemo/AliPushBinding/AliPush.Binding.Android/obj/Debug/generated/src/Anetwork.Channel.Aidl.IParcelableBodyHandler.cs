using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']"
	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableBodyHandler$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ParcelableBodyHandlerStub : global::Android.OS.Binder, global::Anetwork.Channel.Aidl.IParcelableBodyHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/aidl/ParcelableBodyHandler$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableBodyHandlerStub); }
		}

		protected ParcelableBodyHandlerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/constructor[@name='ParcelableBodyHandler.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParcelableBodyHandlerStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ParcelableBodyHandlerStub)) {
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
			global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/ParcelableBodyHandler;", "")]
		public static unsafe global::Anetwork.Channel.Aidl.IParcelableBodyHandler AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/ParcelableBodyHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Anetwork.Channel.Aidl.IParcelableBodyHandler __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableBodyHandler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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
			global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableBodyHandler']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public abstract int Read (byte[] p0);

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
			global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ParcelableBodyHandlerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompleted;
		}
#pragma warning restore 0169

		public abstract bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "GetIsCompletedHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableBodyHandler$Stub", DoNotGenerateAcw=true)]
	internal partial class ParcelableBodyHandlerStubInvoker : ParcelableBodyHandlerStub {

		public ParcelableBodyHandlerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelableBodyHandlerStubInvoker); }
		}

		static IntPtr id_isCompleted;
		public override unsafe bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='ParcelableBodyHandler.Stub']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "GetIsCompletedHandler")]
			get {
				if (id_isCompleted == IntPtr.Zero)
					id_isCompleted = JNIEnv.GetMethodID (class_ref, "isCompleted", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompleted);
				} finally {
				}
			}
		}

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableBodyHandler']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableBodyHandler']"
	[Register ("anetwork/channel/aidl/ParcelableBodyHandler", "", "Anetwork.Channel.Aidl.IParcelableBodyHandlerInvoker")]
	public partial interface IParcelableBodyHandler : global::Android.OS.IInterface {

		bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableBodyHandler']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "GetIsCompletedHandler:Anetwork.Channel.Aidl.IParcelableBodyHandlerInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='ParcelableBodyHandler']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler:Anetwork.Channel.Aidl.IParcelableBodyHandlerInvoker, AliPush.Binding.Android")]
		int Read (byte[] p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/ParcelableBodyHandler", DoNotGenerateAcw=true)]
	internal class IParcelableBodyHandlerInvoker : global::Java.Lang.Object, IParcelableBodyHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/aidl/ParcelableBodyHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IParcelableBodyHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IParcelableBodyHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParcelableBodyHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.aidl.ParcelableBodyHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParcelableBodyHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Anetwork.Channel.Aidl.IParcelableBodyHandler __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableBodyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompleted;
		}
#pragma warning restore 0169

		IntPtr id_isCompleted;
		public unsafe bool IsCompleted {
			get {
				if (id_isCompleted == IntPtr.Zero)
					id_isCompleted = JNIEnv.GetMethodID (class_ref, "isCompleted", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompleted);
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
			global::Anetwork.Channel.Aidl.IParcelableBodyHandler __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableBodyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Anetwork.Channel.Aidl.IParcelableBodyHandler __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableBodyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

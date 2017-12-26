using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.service']/class[@name='IMessageService.Stub']"
	[global::Android.Runtime.Register ("org/android/agoo/service/IMessageService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class MessageServiceStub : global::Android.OS.Binder, global::Org.Android.Agoo.Service.IMessageService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/service/IMessageService$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageServiceStub); }
		}

		protected MessageServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.service']/class[@name='IMessageService.Stub']/constructor[@name='IMessageService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageServiceStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageServiceStub)) {
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
			global::Org.Android.Agoo.Service.MessageServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.MessageServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='IMessageService.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='IMessageService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lorg/android/agoo/service/IMessageService;", "")]
		public static unsafe global::Org.Android.Agoo.Service.IMessageService AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lorg/android/agoo/service/IMessageService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Android.Agoo.Service.IMessageService __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IMessageService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Android.Agoo.Service.MessageServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.MessageServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='IMessageService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_ping;
#pragma warning disable 0169
		static Delegate GetPingHandler ()
		{
			if (cb_ping == null)
				cb_ping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Ping);
			return cb_ping;
		}

		static bool n_Ping (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.MessageServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.MessageServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ping ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()Z", "GetPingHandler")]
		public abstract bool Ping ();

		static Delegate cb_probe;
#pragma warning disable 0169
		static Delegate GetProbeHandler ()
		{
			if (cb_probe == null)
				cb_probe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Probe);
			return cb_probe;
		}

		static void n_Probe (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.MessageServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.MessageServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Probe ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='probe' and count(parameter)=0]"
		[Register ("probe", "()V", "GetProbeHandler")]
		public abstract void Probe ();

	}

	[global::Android.Runtime.Register ("org/android/agoo/service/IMessageService$Stub", DoNotGenerateAcw=true)]
	internal partial class MessageServiceStubInvoker : MessageServiceStub {

		public MessageServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageServiceStubInvoker); }
		}

		static IntPtr id_ping;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()Z", "GetPingHandler")]
		public override unsafe bool Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ping);
			} finally {
			}
		}

		static IntPtr id_probe;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='probe' and count(parameter)=0]"
		[Register ("probe", "()V", "GetProbeHandler")]
		public override unsafe void Probe ()
		{
			if (id_probe == IntPtr.Zero)
				id_probe = JNIEnv.GetMethodID (class_ref, "probe", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_probe);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']"
	[Register ("org/android/agoo/service/IMessageService", "", "Org.Android.Agoo.Service.IMessageServiceInvoker")]
	public partial interface IMessageService : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()Z", "GetPingHandler:Org.Android.Agoo.Service.IMessageServiceInvoker, AliPush.Binding.Android")]
		bool Ping ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='IMessageService']/method[@name='probe' and count(parameter)=0]"
		[Register ("probe", "()V", "GetProbeHandler:Org.Android.Agoo.Service.IMessageServiceInvoker, AliPush.Binding.Android")]
		void Probe ();

	}

	[global::Android.Runtime.Register ("org/android/agoo/service/IMessageService", DoNotGenerateAcw=true)]
	internal class IMessageServiceInvoker : global::Java.Lang.Object, IMessageService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/service/IMessageService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessageServiceInvoker); }
		}

		IntPtr class_ref;

		public static IMessageService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.service.IMessageService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_ping;
#pragma warning disable 0169
		static Delegate GetPingHandler ()
		{
			if (cb_ping == null)
				cb_ping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Ping);
			return cb_ping;
		}

		static bool n_Ping (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.IMessageService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ping ();
		}
#pragma warning restore 0169

		IntPtr id_ping;
		public unsafe bool Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ping);
		}

		static Delegate cb_probe;
#pragma warning disable 0169
		static Delegate GetProbeHandler ()
		{
			if (cb_probe == null)
				cb_probe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Probe);
			return cb_probe;
		}

		static void n_Probe (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.IMessageService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Probe ();
		}
#pragma warning restore 0169

		IntPtr id_probe;
		public unsafe void Probe ()
		{
			if (id_probe == IntPtr.Zero)
				id_probe = JNIEnv.GetMethodID (class_ref, "probe", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_probe);
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
			global::Org.Android.Agoo.Service.IMessageService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

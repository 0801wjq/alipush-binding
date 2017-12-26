using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']"
	[global::Android.Runtime.Register ("anetwork/channel/aidl/Connection$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ConnectionStub : global::Android.OS.Binder, global::Anetwork.Channel.Aidl.IConnection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("anetwork/channel/aidl/Connection$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStub); }
		}

		protected ConnectionStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/constructor[@name='Connection.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectionStub)) {
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
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/Connection;", "")]
		public static unsafe global::Anetwork.Channel.Aidl.IConnection AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lanetwork/channel/aidl/Connection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Anetwork.Channel.Aidl.IConnection __ret = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

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
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.ConnHeadFields);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.IDictionary ConnHeadFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getConnHeadFields' and count(parameter)=0]"
			[Register ("getConnHeadFields", "()Ljava/util/Map;", "GetGetConnHeadFieldsHandler")] get;
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
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Desc);
		}
#pragma warning restore 0169

		public abstract string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")] get;
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		public abstract global::Anetwork.Channel.Aidl.IParcelableInputStream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Lanetwork/channel/aidl/ParcelableInputStream;", "GetGetInputStreamHandler")] get;
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
			global::Anetwork.Channel.Aidl.ConnectionStub __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.ConnectionStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		public abstract int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/Connection$Stub", DoNotGenerateAcw=true)]
	internal partial class ConnectionStubInvoker : ConnectionStub {

		public ConnectionStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStubInvoker); }
		}

		static IntPtr id_getConnHeadFields;
		public override unsafe global::System.Collections.IDictionary ConnHeadFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getConnHeadFields' and count(parameter)=0]"
			[Register ("getConnHeadFields", "()Ljava/util/Map;", "GetGetConnHeadFieldsHandler")]
			get {
				if (id_getConnHeadFields == IntPtr.Zero)
					id_getConnHeadFields = JNIEnv.GetMethodID (class_ref, "getConnHeadFields", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnHeadFields), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDesc;
		public override unsafe string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInputStream;
		public override unsafe global::Anetwork.Channel.Aidl.IParcelableInputStream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Lanetwork/channel/aidl/ParcelableInputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Lanetwork/channel/aidl/ParcelableInputStream;");
				try {
					return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStatusCode;
		public override unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/class[@name='Connection.Stub']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode);
				} finally {
				}
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']"
	[Register ("anetwork/channel/aidl/Connection", "", "Anetwork.Channel.Aidl.IConnectionInvoker")]
	public partial interface IConnection : global::Android.OS.IInterface {

		global::System.Collections.IDictionary ConnHeadFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='getConnHeadFields' and count(parameter)=0]"
			[Register ("getConnHeadFields", "()Ljava/util/Map;", "GetGetConnHeadFieldsHandler:Anetwork.Channel.Aidl.IConnectionInvoker, AliPush.Binding.Android")] get;
		}

		string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler:Anetwork.Channel.Aidl.IConnectionInvoker, AliPush.Binding.Android")] get;
		}

		global::Anetwork.Channel.Aidl.IParcelableInputStream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Lanetwork/channel/aidl/ParcelableInputStream;", "GetGetInputStreamHandler:Anetwork.Channel.Aidl.IConnectionInvoker, AliPush.Binding.Android")] get;
		}

		int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler:Anetwork.Channel.Aidl.IConnectionInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl']/interface[@name='Connection']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Anetwork.Channel.Aidl.IConnectionInvoker, AliPush.Binding.Android")]
		void Cancel ();

	}

	[global::Android.Runtime.Register ("anetwork/channel/aidl/Connection", DoNotGenerateAcw=true)]
	internal class IConnectionInvoker : global::Java.Lang.Object, IConnection {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/aidl/Connection");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectionInvoker); }
		}

		IntPtr class_ref;

		public static IConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.aidl.Connection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.ConnHeadFields);
		}
#pragma warning restore 0169

		IntPtr id_getConnHeadFields;
		public unsafe global::System.Collections.IDictionary ConnHeadFields {
			get {
				if (id_getConnHeadFields == IntPtr.Zero)
					id_getConnHeadFields = JNIEnv.GetMethodID (class_ref, "getConnHeadFields", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnHeadFields), JniHandleOwnership.TransferLocalRef);
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
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public unsafe global::Anetwork.Channel.Aidl.IParcelableInputStream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Lanetwork/channel/aidl/ParcelableInputStream;");
				return global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IParcelableInputStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
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
			global::Anetwork.Channel.Aidl.IConnection __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.Aidl.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

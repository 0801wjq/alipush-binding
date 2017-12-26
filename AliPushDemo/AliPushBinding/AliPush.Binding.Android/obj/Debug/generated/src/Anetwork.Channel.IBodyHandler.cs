using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Anetwork.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='anetwork.channel']/interface[@name='IBodyHandler']"
	[Register ("anetwork/channel/IBodyHandler", "", "Anetwork.Channel.IBodyHandlerInvoker")]
	public partial interface IBodyHandler : IJavaObject {

		bool IsCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='IBodyHandler']/method[@name='isCompleted' and count(parameter)=0]"
			[Register ("isCompleted", "()Z", "GetIsCompletedHandler:Anetwork.Channel.IBodyHandlerInvoker, AliPush.Binding.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel']/interface[@name='IBodyHandler']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler:Anetwork.Channel.IBodyHandlerInvoker, AliPush.Binding.Android")]
		int Read (byte[] p0);

	}

	[global::Android.Runtime.Register ("anetwork/channel/IBodyHandler", DoNotGenerateAcw=true)]
	internal class IBodyHandlerInvoker : global::Java.Lang.Object, IBodyHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("anetwork/channel/IBodyHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBodyHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IBodyHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBodyHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "anetwork.channel.IBodyHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBodyHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Anetwork.Channel.IBodyHandler __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IBodyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Anetwork.Channel.IBodyHandler __this = global::Java.Lang.Object.GetObject<global::Anetwork.Channel.IBodyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}

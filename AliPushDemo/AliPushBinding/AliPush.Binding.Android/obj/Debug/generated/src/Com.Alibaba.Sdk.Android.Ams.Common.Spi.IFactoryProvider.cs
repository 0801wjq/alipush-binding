using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Ams.Common.Spi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/interface[@name='FactoryProvider']"
	[Register ("com/alibaba/sdk/android/ams/common/spi/FactoryProvider", "", "Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I"})]
	public partial interface IFactoryProvider : IJavaObject {

		global::Java.Lang.Class BaseInterface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/interface[@name='FactoryProvider']/method[@name='getBaseInterface' and count(parameter)=0]"
			[Register ("getBaseInterface", "()Ljava/lang/Class;", "GetGetBaseInterfaceHandler:Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProviderInvoker, AliPush.Binding.Android")] get;
		}

		global::Java.Lang.Object FactoryInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/interface[@name='FactoryProvider']/method[@name='getFactoryInstance' and count(parameter)=0]"
			[Register ("getFactoryInstance", "()Ljava/lang/Object;", "GetGetFactoryInstanceHandler:Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProviderInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/ams/common/spi/FactoryProvider", DoNotGenerateAcw=true)]
	internal class IFactoryProviderInvoker : global::Java.Lang.Object, IFactoryProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/sdk/android/ams/common/spi/FactoryProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFactoryProviderInvoker); }
		}

		IntPtr class_ref;

		public static IFactoryProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFactoryProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.ams.common.spi.FactoryProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFactoryProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBaseInterface;
#pragma warning disable 0169
		static Delegate GetGetBaseInterfaceHandler ()
		{
			if (cb_getBaseInterface == null)
				cb_getBaseInterface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseInterface);
			return cb_getBaseInterface;
		}

		static IntPtr n_GetBaseInterface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseInterface);
		}
#pragma warning restore 0169

		IntPtr id_getBaseInterface;
		public unsafe global::Java.Lang.Class BaseInterface {
			get {
				if (id_getBaseInterface == IntPtr.Zero)
					id_getBaseInterface = JNIEnv.GetMethodID (class_ref, "getBaseInterface", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseInterface), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFactoryInstance;
#pragma warning disable 0169
		static Delegate GetGetFactoryInstanceHandler ()
		{
			if (cb_getFactoryInstance == null)
				cb_getFactoryInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFactoryInstance);
			return cb_getFactoryInstance;
		}

		static IntPtr n_GetFactoryInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FactoryInstance);
		}
#pragma warning restore 0169

		IntPtr id_getFactoryInstance;
		public unsafe global::Java.Lang.Object FactoryInstance {
			get {
				if (id_getFactoryInstance == IntPtr.Zero)
					id_getFactoryInstance = JNIEnv.GetMethodID (class_ref, "getFactoryInstance", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFactoryInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

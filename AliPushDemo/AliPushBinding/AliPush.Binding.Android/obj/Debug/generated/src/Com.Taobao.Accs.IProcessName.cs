using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IProcessName']"
	[Register ("com/taobao/accs/IProcessName", "", "Com.Taobao.Accs.IProcessNameInvoker")]
	public partial interface IProcessName : IJavaObject {

		string CurrProcessName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/interface[@name='IProcessName']/method[@name='getCurrProcessName' and count(parameter)=0]"
			[Register ("getCurrProcessName", "()Ljava/lang/String;", "GetGetCurrProcessNameHandler:Com.Taobao.Accs.IProcessNameInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/taobao/accs/IProcessName", DoNotGenerateAcw=true)]
	internal class IProcessNameInvoker : global::Java.Lang.Object, IProcessName {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/IProcessName");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProcessNameInvoker); }
		}

		IntPtr class_ref;

		public static IProcessName GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProcessName> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.IProcessName"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProcessNameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrProcessName;
#pragma warning disable 0169
		static Delegate GetGetCurrProcessNameHandler ()
		{
			if (cb_getCurrProcessName == null)
				cb_getCurrProcessName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrProcessName);
			return cb_getCurrProcessName;
		}

		static IntPtr n_GetCurrProcessName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.IProcessName __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IProcessName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrProcessName);
		}
#pragma warning restore 0169

		IntPtr id_getCurrProcessName;
		public unsafe string CurrProcessName {
			get {
				if (id_getCurrProcessName == IntPtr.Zero)
					id_getCurrProcessName = JNIEnv.GetMethodID (class_ref, "getCurrProcessName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrProcessName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

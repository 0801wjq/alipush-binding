using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.UT.Statistics {

	[Register ("com/taobao/accs/ut/statistics/UTInterface", DoNotGenerateAcw=true)]
	public abstract class UTInterface : Java.Lang.Object {

		internal UTInterface ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.statistics']/interface[@name='UTInterface']/field[@name='EVENT_ID']"
		[Register ("EVENT_ID")]
		public const int EventId = (int) 66001;
	}

	[Register ("com/taobao/accs/ut/statistics/UTInterface", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UTInterface' type. This type will be removed in a future release.")]
	public abstract class UTInterfaceConsts : UTInterface {

		private UTInterfaceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs.ut.statistics']/interface[@name='UTInterface']"
	[Register ("com/taobao/accs/ut/statistics/UTInterface", "", "Com.Taobao.Accs.UT.Statistics.IUTInterfaceInvoker")]
	public partial interface IUTInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.ut.statistics']/interface[@name='UTInterface']/method[@name='commitUT' and count(parameter)=0]"
		[Register ("commitUT", "()V", "GetCommitUTHandler:Com.Taobao.Accs.UT.Statistics.IUTInterfaceInvoker, AliPush.Binding.Android")]
		void CommitUT ();

	}

	[global::Android.Runtime.Register ("com/taobao/accs/ut/statistics/UTInterface", DoNotGenerateAcw=true)]
	internal class IUTInterfaceInvoker : global::Java.Lang.Object, IUTInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/ut/statistics/UTInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IUTInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.ut.statistics.UTInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_commitUT;
#pragma warning disable 0169
		static Delegate GetCommitUTHandler ()
		{
			if (cb_commitUT == null)
				cb_commitUT = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CommitUT);
			return cb_commitUT;
		}

		static void n_CommitUT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.UT.Statistics.IUTInterface __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.UT.Statistics.IUTInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitUT ();
		}
#pragma warning restore 0169

		IntPtr id_commitUT;
		public unsafe void CommitUT ()
		{
			if (id_commitUT == IntPtr.Zero)
				id_commitUT = JNIEnv.GetMethodID (class_ref, "commitUT", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitUT);
		}

	}

}

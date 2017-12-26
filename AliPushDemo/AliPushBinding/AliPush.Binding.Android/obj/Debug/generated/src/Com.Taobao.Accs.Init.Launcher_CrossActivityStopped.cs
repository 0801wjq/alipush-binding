using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.init']/class[@name='Launcher_CrossActivityStopped']"
	[global::Android.Runtime.Register ("com/taobao/accs/init/Launcher_CrossActivityStopped", DoNotGenerateAcw=true)]
	public partial class Launcher_CrossActivityStopped : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/init/Launcher_CrossActivityStopped", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Launcher_CrossActivityStopped); }
		}

		protected Launcher_CrossActivityStopped (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.init']/class[@name='Launcher_CrossActivityStopped']/constructor[@name='Launcher_CrossActivityStopped' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Launcher_CrossActivityStopped ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Launcher_CrossActivityStopped)) {
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

	}
}
using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.UT.Monitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor']"
	[global::Android.Runtime.Register ("com/taobao/accs/ut/monitor/TrafficsMonitor", DoNotGenerateAcw=true)]
	public partial class TrafficsMonitor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']"
		[global::Android.Runtime.Register ("com/taobao/accs/ut/monitor/TrafficsMonitor$StatTrafficMonitor", DoNotGenerateAcw=true)]
		public partial class StatTrafficMonitor : global::Com.Taobao.Accs.Utl.BaseMonitor {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/field[@name='a']"
			[Register ("a")]
			public string A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/field[@name='b']"
			[Register ("b")]
			public string B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/field[@name='c']"
			[Register ("c")]
			public bool C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/field[@name='d']"
			[Register ("d")]
			public string D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, d_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, d_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/field[@name='e']"
			[Register ("e")]
			public long E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/ut/monitor/TrafficsMonitor$StatTrafficMonitor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StatTrafficMonitor); }
			}

			protected StatTrafficMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor.StatTrafficMonitor']/constructor[@name='TrafficsMonitor.StatTrafficMonitor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe StatTrafficMonitor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (StatTrafficMonitor)) {
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/ut/monitor/TrafficsMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrafficsMonitor); }
		}

		protected TrafficsMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor']/constructor[@name='TrafficsMonitor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TrafficsMonitor (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TrafficsMonitor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.ut.monitor']/class[@name='TrafficsMonitor']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a);
			} finally {
			}
		}

	}
}

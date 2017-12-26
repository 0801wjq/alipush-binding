using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitor", DoNotGenerateAcw=true)]
	public sealed partial class AppMonitor : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AppMonitor";

		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/field[@name='a']"
		[Register ("a")]
		protected static global::Com.Alibaba.Mtl.Appmonitor.IMonitor A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/alibaba/mtl/appmonitor/IMonitor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/alibaba/mtl/appmonitor/IMonitor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']"
		[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitor$Alarm", DoNotGenerateAcw=true)]
		public partial class Alarm : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitor$Alarm", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Alarm); }
			}

			protected Alarm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/constructor[@name='AppMonitor.Alarm' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Alarm ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Alarm)) {
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

			static IntPtr id_checkSampled_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckSampled (string module, string monitorPoint)
			{
				if (id_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='commitFail' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register ("commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void CommitFail (string module, string monitorPoint, string errorCode, string errorMsg)
			{
				if (id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_errorCode = JNIEnv.NewString (errorCode);
				IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_errorCode);
					__args [3] = new JValue (native_errorMsg);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_errorCode);
					JNIEnv.DeleteLocalRef (native_errorMsg);
				}
			}

			static IntPtr id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='commitFail' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
			[Register ("commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void CommitFail (string module, string monitorPoint, string arg, string errorCode, string errorMsg)
			{
				if (id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitFail", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_arg = JNIEnv.NewString (arg);
				IntPtr native_errorCode = JNIEnv.NewString (errorCode);
				IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_arg);
					__args [3] = new JValue (native_errorCode);
					__args [4] = new JValue (native_errorMsg);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commitFail_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_arg);
					JNIEnv.DeleteLocalRef (native_errorCode);
					JNIEnv.DeleteLocalRef (native_errorMsg);
				}
			}

			static IntPtr id_commitSuccess_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='commitSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("commitSuccess", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void CommitSuccess (string module, string monitorPoint)
			{
				if (id_commitSuccess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_commitSuccess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commitSuccess_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='commitSuccess' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("commitSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void CommitSuccess (string module, string monitorPoint, string arg)
			{
				if (id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_arg = JNIEnv.NewString (arg);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_arg);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commitSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_arg);
				}
			}

			static IntPtr id_setSampling_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampling", "(I)V", "")]
			public static unsafe void SetSampling (int sampling)
			{
				if (id_setSampling_I == IntPtr.Zero)
					id_setSampling_I = JNIEnv.GetStaticMethodID (class_ref, "setSampling", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sampling);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSampling_I, __args);
				} finally {
				}
			}

			static IntPtr id_setStatisticsInterval_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Alarm']/method[@name='setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatisticsInterval", "(I)V", "")]
			public static unsafe void SetStatisticsInterval (int statisticsInterval)
			{
				if (id_setStatisticsInterval_I == IntPtr.Zero)
					id_setStatisticsInterval_I = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (statisticsInterval);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsInterval_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']"
		[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitor$Counter", DoNotGenerateAcw=true)]
		public partial class Counter : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitor$Counter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Counter); }
			}

			protected Counter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/constructor[@name='AppMonitor.Counter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Counter ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Counter)) {
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

			static IntPtr id_checkSampled_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/method[@name='checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckSampled (string module, string monitorPoint)
			{
				if (id_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/method[@name='commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, double value)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, string arg, double value)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_arg = JNIEnv.NewString (arg);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_arg);
					__args [3] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_D, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_arg);
				}
			}

			static IntPtr id_setSampling_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampling", "(I)V", "")]
			public static unsafe void SetSampling (int sampling)
			{
				if (id_setSampling_I == IntPtr.Zero)
					id_setSampling_I = JNIEnv.GetStaticMethodID (class_ref, "setSampling", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sampling);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSampling_I, __args);
				} finally {
				}
			}

			static IntPtr id_setStatisticsInterval_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Counter']/method[@name='setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatisticsInterval", "(I)V", "")]
			public static unsafe void SetStatisticsInterval (int statisticsInterval)
			{
				if (id_setStatisticsInterval_I == IntPtr.Zero)
					id_setStatisticsInterval_I = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (statisticsInterval);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsInterval_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']"
		[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitor$OffLineCounter", DoNotGenerateAcw=true)]
		public partial class OffLineCounter : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitor$OffLineCounter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OffLineCounter); }
			}

			protected OffLineCounter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']/constructor[@name='AppMonitor.OffLineCounter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OffLineCounter ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (OffLineCounter)) {
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

			static IntPtr id_checkSampled_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']/method[@name='checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckSampled (string module, string monitorPoint)
			{
				if (id_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']/method[@name='commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, double value)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_setSampling_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampling", "(I)V", "")]
			public static unsafe void SetSampling (int sampling)
			{
				if (id_setSampling_I == IntPtr.Zero)
					id_setSampling_I = JNIEnv.GetStaticMethodID (class_ref, "setSampling", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sampling);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSampling_I, __args);
				} finally {
				}
			}

			static IntPtr id_setStatisticsInterval_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.OffLineCounter']/method[@name='setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatisticsInterval", "(I)V", "")]
			public static unsafe void SetStatisticsInterval (int statisticsInterval)
			{
				if (id_setStatisticsInterval_I == IntPtr.Zero)
					id_setStatisticsInterval_I = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (statisticsInterval);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsInterval_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']"
		[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/AppMonitor$Stat", DoNotGenerateAcw=true)]
		public partial class Stat : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitor$Stat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Stat); }
			}

			protected Stat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/constructor[@name='AppMonitor.Stat' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Stat ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Stat)) {
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

			static IntPtr id_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='begin' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void Begin (string module, string monitorPoint, string measureName)
			{
				if (id_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_measureName = JNIEnv.NewString (measureName);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_measureName);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_measureName);
				}
			}

			static IntPtr id_checkSampled_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckSampled (string module, string monitorPoint)
			{
				if (id_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_ = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (dimensionValues);
					__args [3] = new JValue (measureValues);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='commit' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;D)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, double value)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;D)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (dimensionValues);
					__args [3] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_D, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, double value)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_commit_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='commit' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String[]']]"
			[Register ("commit", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
			public static unsafe void Commit (string module, string monitorPoint, string[] dimensionNames, string[] dimensionValues, string[] measureNames, string[] measureValues)
			{
				if (id_commit_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_commit_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commit", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_dimensionNames = JNIEnv.NewArray (dimensionNames);
				IntPtr native_dimensionValues = JNIEnv.NewArray (dimensionValues);
				IntPtr native_measureNames = JNIEnv.NewArray (measureNames);
				IntPtr native_measureValues = JNIEnv.NewArray (measureValues);
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_dimensionNames);
					__args [3] = new JValue (native_dimensionValues);
					__args [4] = new JValue (native_measureNames);
					__args [5] = new JValue (native_measureValues);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_commit_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					if (dimensionNames != null) {
						JNIEnv.CopyArray (native_dimensionNames, dimensionNames);
						JNIEnv.DeleteLocalRef (native_dimensionNames);
					}
					if (dimensionValues != null) {
						JNIEnv.CopyArray (native_dimensionValues, dimensionValues);
						JNIEnv.DeleteLocalRef (native_dimensionValues);
					}
					if (measureNames != null) {
						JNIEnv.CopyArray (native_measureNames, measureNames);
						JNIEnv.DeleteLocalRef (native_measureNames);
					}
					if (measureValues != null) {
						JNIEnv.CopyArray (native_measureValues, measureValues);
						JNIEnv.DeleteLocalRef (native_measureValues);
					}
				}
			}

			static IntPtr id_createTransaction_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='createTransaction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("createTransaction", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/Transaction;", "")]
			public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Transaction CreateTransaction (string module, string monitorPoint)
			{
				if (id_createTransaction_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_createTransaction_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createTransaction", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/Transaction;");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					global::Com.Alibaba.Mtl.Appmonitor.Transaction __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTransaction_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='createTransaction' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet']]"
			[Register ("createTransaction", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Lcom/alibaba/mtl/appmonitor/Transaction;", "")]
			public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Transaction CreateTransaction (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues)
			{
				if (id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ == IntPtr.Zero)
					id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_ = JNIEnv.GetStaticMethodID (class_ref, "createTransaction", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;)Lcom/alibaba/mtl/appmonitor/Transaction;");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (dimensionValues);
					global::Com.Alibaba.Mtl.Appmonitor.Transaction __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
				}
			}

			static IntPtr id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='createTransaction' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='java.lang.String']]"
			[Register ("createTransaction", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/Transaction;", "")]
			public static unsafe global::Com.Alibaba.Mtl.Appmonitor.Transaction CreateTransaction (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, string appkey)
			{
				if (id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Ljava_lang_String_ == IntPtr.Zero)
					id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createTransaction", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/Transaction;");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_appkey = JNIEnv.NewString (appkey);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (dimensionValues);
					__args [3] = new JValue (native_appkey);
					global::Com.Alibaba.Mtl.Appmonitor.Transaction __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTransaction_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_appkey);
				}
			}

			static IntPtr id_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='end' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public static unsafe void End (string module, string monitorPoint, string measureName)
			{
				if (id_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_module = JNIEnv.NewString (module);
				IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
				IntPtr native_measureName = JNIEnv.NewString (measureName);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_module);
					__args [1] = new JValue (native_monitorPoint);
					__args [2] = new JValue (native_measureName);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_module);
					JNIEnv.DeleteLocalRef (native_monitorPoint);
					JNIEnv.DeleteLocalRef (native_measureName);
				}
			}

			static IntPtr id_setSampling_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampling", "(I)V", "")]
			public static unsafe void SetSampling (int sampling)
			{
				if (id_setSampling_I == IntPtr.Zero)
					id_setSampling_I = JNIEnv.GetStaticMethodID (class_ref, "setSampling", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sampling);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSampling_I, __args);
				} finally {
				}
			}

			static IntPtr id_setStatisticsInterval_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor.Stat']/method[@name='setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatisticsInterval", "(I)V", "")]
			public static unsafe void SetStatisticsInterval (int statisticsInterval)
			{
				if (id_setStatisticsInterval_I == IntPtr.Zero)
					id_setStatisticsInterval_I = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (statisticsInterval);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsInterval_I, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/AppMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppMonitor); }
		}

		internal AppMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/constructor[@name='AppMonitor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppMonitor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppMonitor)) {
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

		static IntPtr id_checkInit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='checkInit' and count(parameter)=0]"
		[Register ("checkInit", "()Z", "")]
		public static unsafe bool CheckInit ()
		{
			if (id_checkInit == IntPtr.Zero)
				id_checkInit = JNIEnv.GetStaticMethodID (class_ref, "checkInit", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkInit);
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='destroy' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("destroy", "()V", "")]
		public static unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetStaticMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroy);
			} finally {
			}
		}

		static IntPtr id_enableLog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "")]
		public static unsafe void EnableLog (bool open)
		{
			if (id_enableLog_Z == IntPtr.Zero)
				id_enableLog_Z = JNIEnv.GetStaticMethodID (class_ref, "enableLog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (open);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableLog_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getTrackByAppkey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='getTrackByAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrackByAppkey", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/APTrack;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.APTrack GetTrackByAppkey (string appkey)
		{
			if (id_getTrackByAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrackByAppkey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTrackByAppkey", "(Ljava/lang/String;)Lcom/alibaba/mtl/appmonitor/APTrack;");
			IntPtr native_appkey = JNIEnv.NewString (appkey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appkey);
				global::Com.Alibaba.Mtl.Appmonitor.APTrack __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.APTrack> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTrackByAppkey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_appkey);
			}
		}

		static IntPtr id_init_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "")]
		public static unsafe void Init (global::Android.App.Application application)
		{
			if (id_init_Landroid_app_Application_ == IntPtr.Zero)
				id_init_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (application);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_app_Application_, __args);
			} finally {
			}
		}

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='register' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "")]
		public static unsafe void Register (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='register' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='boolean']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V", "")]
		public static unsafe void Register (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, bool isCommitDetail)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (isCommitDetail);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='register' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V", "")]
		public static unsafe void Register (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (dimensions);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='register' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "")]
		public static unsafe void Register (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions, bool isCommitDetail)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (dimensions);
				__args [4] = new JValue (isCommitDetail);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='register' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='boolean']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Z)V", "")]
		public static unsafe void Register (string module, string monitorPoint, string[] measures, string[] dimensions, bool isCommitDetail)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Z == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Z)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_measures = JNIEnv.NewArray (measures);
			IntPtr native_dimensions = JNIEnv.NewArray (dimensions);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_measures);
				__args [3] = new JValue (native_dimensions);
				__args [4] = new JValue (isCommitDetail);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				if (measures != null) {
					JNIEnv.CopyArray (native_measures, measures);
					JNIEnv.DeleteLocalRef (native_measures);
				}
				if (dimensions != null) {
					JNIEnv.CopyArray (native_dimensions, dimensions);
					JNIEnv.DeleteLocalRef (native_dimensions);
				}
			}
		}

		static IntPtr id_registerInternal_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='registerInternal' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("registerInternal", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;ZZ)V", "")]
		public static unsafe void RegisterInternal (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions, bool isCommitDetail, bool isInternal)
		{
			if (id_registerInternal_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZZ == IntPtr.Zero)
				id_registerInternal_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZZ = JNIEnv.GetStaticMethodID (class_ref, "registerInternal", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;ZZ)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (dimensions);
				__args [4] = new JValue (isCommitDetail);
				__args [5] = new JValue (isInternal);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerInternal_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetChannel (string channel)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_channel = JNIEnv.NewString (channel);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_channel);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChannel_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channel);
			}
		}

		static IntPtr id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='setRequestAuthInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetRequestAuthInfo (bool isSecurity, string appkey, string secret, string authcode)
		{
			if (id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_appkey = JNIEnv.NewString (appkey);
			IntPtr native_secret = JNIEnv.NewString (secret);
			IntPtr native_authcode = JNIEnv.NewString (authcode);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (isSecurity);
				__args [1] = new JValue (native_appkey);
				__args [2] = new JValue (native_secret);
				__args [3] = new JValue (native_authcode);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appkey);
				JNIEnv.DeleteLocalRef (native_secret);
				JNIEnv.DeleteLocalRef (native_authcode);
			}
		}

		static IntPtr id_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSampling", "(I)V", "")]
		public static unsafe void SetSampling (int sampling)
		{
			if (id_setSampling_I == IntPtr.Zero)
				id_setSampling_I = JNIEnv.GetStaticMethodID (class_ref, "setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatisticsInterval", "(I)V", "")]
		public static unsafe void SetStatisticsInterval (int statisticsInterval)
		{
			if (id_setStatisticsInterval_I == IntPtr.Zero)
				id_setStatisticsInterval_I = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_triggerUpload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='triggerUpload' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("triggerUpload", "()V", "")]
		public static unsafe void TriggerUpload ()
		{
			if (id_triggerUpload == IntPtr.Zero)
				id_triggerUpload = JNIEnv.GetStaticMethodID (class_ref, "triggerUpload", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_triggerUpload);
			} finally {
			}
		}

		static IntPtr id_turnOffRealTimeDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "")]
		public static unsafe void TurnOffRealTimeDebug ()
		{
			if (id_turnOffRealTimeDebug == IntPtr.Zero)
				id_turnOffRealTimeDebug = JNIEnv.GetStaticMethodID (class_ref, "turnOffRealTimeDebug", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_turnOffRealTimeDebug);
			} finally {
			}
		}

		static IntPtr id_turnOnRealTimeDebug_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "")]
		public static unsafe void TurnOnRealTimeDebug (global::System.Collections.Generic.IDictionary<string, string> @params)
		{
			if (id_turnOnRealTimeDebug_Ljava_util_Map_ == IntPtr.Zero)
				id_turnOnRealTimeDebug_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "turnOnRealTimeDebug", "(Ljava/util/Map;)V");
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_turnOnRealTimeDebug_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		static IntPtr id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='AppMonitor']/method[@name='updateMeasure' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V", "")]
		public static unsafe void UpdateMeasure (string module, string monitorPoint, string name, double min, double max, double defaultValue)
		{
			if (id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == IntPtr.Zero)
				id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNIEnv.GetStaticMethodID (class_ref, "updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_name);
				__args [3] = new JValue (min);
				__args [4] = new JValue (max);
				__args [5] = new JValue (defaultValue);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}

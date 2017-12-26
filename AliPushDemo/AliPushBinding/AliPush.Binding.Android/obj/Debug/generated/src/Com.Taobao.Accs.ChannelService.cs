using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']"
	[global::Android.Runtime.Register ("com/taobao/accs/ChannelService", DoNotGenerateAcw=true)]
	public partial class ChannelService : global::Com.Taobao.Accs.Base.BaseService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']/field[@name='DEFAULT_FORGROUND_V']"
		[Register ("DEFAULT_FORGROUND_V")]
		public const int DefaultForgroundV = (int) 24;

		static IntPtr SDK_VERSION_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']/field[@name='SDK_VERSION_CODE']"
		[Register ("SDK_VERSION_CODE")]
		public static int SdkVersionCode {
			get {
				if (SDK_VERSION_CODE_jfieldId == IntPtr.Zero)
					SDK_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDK_VERSION_CODE", "I");
				return JNIEnv.GetStaticIntField (class_ref, SDK_VERSION_CODE_jfieldId);
			}
			set {
				if (SDK_VERSION_CODE_jfieldId == IntPtr.Zero)
					SDK_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDK_VERSION_CODE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, SDK_VERSION_CODE_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']/field[@name='SUPPORT_FOREGROUND_VERSION_KEY']"
		[Register ("SUPPORT_FOREGROUND_VERSION_KEY")]
		public const string SupportForegroundVersionKey = (string) "support_foreground_v";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService.KernelService']"
		[global::Android.Runtime.Register ("com/taobao/accs/ChannelService$KernelService", DoNotGenerateAcw=true)]
		public partial class KernelService : global::Android.App.Service {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/ChannelService$KernelService", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KernelService); }
			}

			protected KernelService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService.KernelService']/constructor[@name='ChannelService.KernelService' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe KernelService ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (KernelService)) {
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

			static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnBind_Landroid_content_Intent_Handler ()
			{
				if (cb_onBind_Landroid_content_Intent_ == null)
					cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
				return cb_onBind_Landroid_content_Intent_;
			}

			static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Taobao.Accs.ChannelService.KernelService __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ChannelService.KernelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onBind_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService.KernelService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
			public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
			{
				if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
					id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.OS.IBinder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/ChannelService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelService); }
		}

		protected ChannelService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']/constructor[@name='ChannelService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelService)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Taobao.Accs.ChannelService Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs']/class[@name='ChannelService']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/taobao/accs/ChannelService;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/taobao/accs/ChannelService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ChannelService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

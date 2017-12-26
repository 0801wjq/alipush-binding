using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Antibrush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush']"
	[global::Android.Runtime.Register ("com/taobao/accs/antibrush/AntiBrush", DoNotGenerateAcw=true)]
	public partial class AntiBrush : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush']/field[@name='STATUS_BRUSH']"
		[Register ("STATUS_BRUSH")]
		public const int StatusBrush = (int) 419;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush.AntiReceiver']"
		[global::Android.Runtime.Register ("com/taobao/accs/antibrush/AntiBrush$AntiReceiver", DoNotGenerateAcw=true)]
		public partial class AntiReceiver : global::Android.Content.BroadcastReceiver {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/antibrush/AntiBrush$AntiReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AntiReceiver); }
			}

			protected AntiReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush.AntiReceiver']/constructor[@name='AntiBrush.AntiReceiver' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AntiReceiver ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (AntiReceiver)) {
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

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Taobao.Accs.Antibrush.AntiBrush.AntiReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Antibrush.AntiBrush.AntiReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush.AntiReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/antibrush/AntiBrush", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AntiBrush); }
		}

		protected AntiBrush (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush']/constructor[@name='AntiBrush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AntiBrush (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AntiBrush)) {
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

		static Delegate cb_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCheckAntiBrush_Ljava_net_URL_Ljava_util_Map_Handler ()
		{
			if (cb_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_ == null)
				cb_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckAntiBrush_Ljava_net_URL_Ljava_util_Map_);
			return cb_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_;
		}

		static bool n_CheckAntiBrush_Ljava_net_URL_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Antibrush.AntiBrush __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Antibrush.AntiBrush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAntiBrush (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush']/method[@name='checkAntiBrush' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map&lt;com.taobao.accs.base.TaoBaseService.ExtHeaderType, java.lang.String&gt;']]"
		[Register ("checkAntiBrush", "(Ljava/net/URL;Ljava/util/Map;)Z", "GetCheckAntiBrush_Ljava_net_URL_Ljava_util_Map_Handler")]
		public virtual unsafe bool CheckAntiBrush (global::Java.Net.URL p0, global::System.Collections.Generic.IDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string> p1)
		{
			if (id_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_ == IntPtr.Zero)
				id_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "checkAntiBrush", "(Ljava/net/URL;Ljava/util/Map;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkAntiBrush_Ljava_net_URL_Ljava_util_Map_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAntiBrush", "(Ljava/net/URL;Ljava/util/Map;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onResult_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.antibrush']/class[@name='AntiBrush']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void OnResult (global::Android.Content.Context p0, bool p1)
		{
			if (id_onResult_Landroid_content_Context_Z == IntPtr.Zero)
				id_onResult_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "onResult", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResult_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

	}
}

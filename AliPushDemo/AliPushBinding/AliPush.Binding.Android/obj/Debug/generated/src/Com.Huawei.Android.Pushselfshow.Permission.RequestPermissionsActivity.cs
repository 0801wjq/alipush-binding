using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Huawei.Android.Pushselfshow.Permission {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']"
	[global::Android.Runtime.Register ("com/huawei/android/pushselfshow/permission/RequestPermissionsActivity", DoNotGenerateAcw=true)]
	public partial class RequestPermissionsActivity : global::Android.App.Activity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/huawei/android/pushselfshow/permission/RequestPermissionsActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestPermissionsActivity); }
		}

		protected RequestPermissionsActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/constructor[@name='RequestPermissionsActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestPermissionsActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RequestPermissionsActivity)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Permission.RequestPermissionsActivity __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Permission.RequestPermissionsActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()[Ljava/lang/String;", "GetAHandler")]
		protected virtual unsafe string[] A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_a_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("a", "(Landroid/content/Context;[Ljava/lang/String;)Z", "")]
		protected static unsafe bool A (global::Android.Content.Context p0, string[] p1)
		{
			if (id_a_Landroid_content_Context_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;[Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Huawei.Android.Pushselfshow.Permission.RequestPermissionsActivity __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Android.Pushselfshow.Permission.RequestPermissionsActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.B ());
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.android.pushselfshow.permission']/class[@name='RequestPermissionsActivity']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()[Ljava/lang/String;", "GetBHandler")]
		protected virtual unsafe string[] B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Intent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']"
	[global::Android.Runtime.Register ("org/android/agoo/intent/IntentUtil", DoNotGenerateAcw=true)]
	public sealed partial class IntentUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND']"
		[Register ("AGOO_COMMAND")]
		public const string AgooCommand = (string) "command";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/intent/IntentUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntentUtil); }
		}

		internal IntentUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/constructor[@name='IntentUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IntentUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IntentUtil)) {
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

		static IntPtr id_createActivityIntent_Landroid_content_Context_Ljava_lang_String_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='createActivityIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Intent']]"
		[Register ("createActivityIntent", "(Landroid/content/Context;Ljava/lang/String;Landroid/content/Intent;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateActivityIntent (global::Android.Content.Context p0, string p1, global::Android.Content.Intent p2)
		{
			if (id_createActivityIntent_Landroid_content_Context_Ljava_lang_String_Landroid_content_Intent_ == IntPtr.Zero)
				id_createActivityIntent_Landroid_content_Context_Ljava_lang_String_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "createActivityIntent", "(Landroid/content/Context;Ljava/lang/String;Landroid/content/Intent;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createActivityIntent_Landroid_content_Context_Ljava_lang_String_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createComandIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='createComandIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateComandIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createComandIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createComandIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createComandIntent_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createThirdpushComandIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='createThirdpushComandIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createThirdpushComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateThirdpushComandIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createThirdpushComandIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createThirdpushComandIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createThirdpushComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createThirdpushComandIntent_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAgooCommand_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getAgooCommand' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAgooCommand", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAgooCommand (global::Android.Content.Context p0)
		{
			if (id_getAgooCommand_Landroid_content_Context_ == IntPtr.Zero)
				id_getAgooCommand_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAgooCommand", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgooCommand_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThirdPushCommand_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getThirdPushCommand' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getThirdPushCommand", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetThirdPushCommand (global::Android.Content.Context p0)
		{
			if (id_getThirdPushCommand_Landroid_content_Context_ == IntPtr.Zero)
				id_getThirdPushCommand_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getThirdPushCommand", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThirdPushCommand_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

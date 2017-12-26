using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Utl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']"
	[global::Android.Runtime.Register ("com/taobao/accs/utl/UTMini", DoNotGenerateAcw=true)]
	public sealed partial class UTMini : global::Java.Lang.Object, global::Com.Taobao.Accs.Utl.IUT {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/field[@name='EVENTID_AGOO']"
		[Register ("EVENTID_AGOO")]
		public const int EventidAgoo = (int) 19999;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/field[@name='EVENTID_EXCPTION']"
		[Register ("EVENTID_EXCPTION")]
		public const int EventidExcption = (int) 66003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/field[@name='PAGE_AGOO']"
		[Register ("PAGE_AGOO")]
		public const string PageAgoo = (string) "Page_Push";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/field[@name='PAGE_REQUEST_ERROR']"
		[Register ("PAGE_REQUEST_ERROR")]
		public const string PageRequestError = (string) "REQ_ERROR";

		public static class InterfaceConsts {

			// The following are fields from: com.taobao.accs.utl.UT

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/field[@name='EVENT_ID']"
			[Register ("EVENT_ID")]
			public const int EventId = (int) 66001;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/utl/UTMini", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTMini); }
		}

		internal UTMini (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/constructor[@name='UTMini' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTMini ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTMini)) {
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
		public static unsafe global::Com.Taobao.Accs.Utl.UTMini Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/taobao/accs/utl/UTMini;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/taobao/accs/utl/UTMini;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.UTMini> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='commitEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='commitEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='commitEvent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='commitEvent' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.lang.String...']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V", "")]
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4, params  string[] p5)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='commitEvent' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Map;)V", "")]
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4, global::System.Collections.Generic.IDictionary<string, string> p5)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Map_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Map;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_convertObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='convertObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ConvertObjectToString (global::Java.Lang.Object p0)
		{
			if (id_convertObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertObjectToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertObjectToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='getCommitInfo' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getCommitInfo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCommitInfo (int p0, string p1, string p2, string p3, string p4)
		{
			if (id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCommitInfo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='getCommitInfo' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getCommitInfo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetCommitInfo (int p0, string p1, string p2, string p3, global::System.Collections.Generic.IDictionary<string, string> p4)
		{
			if (id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getCommitInfo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommitInfo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getUtdId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='getUtdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe string GetUtdId (global::Android.Content.Context p0)
		{
			if (id_getUtdId_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdId_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getUtdId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUtdId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onCaughException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='onCaughException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onCaughException", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnCaughException (global::Java.Lang.Throwable p0)
		{
			if (id_onCaughException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onCaughException_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCaughException", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCaughException_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Start (global::Android.App.Application p0, string p1, string p2, string p3)
		{
			if (id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_stop_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/class[@name='UTMini']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stop", "(Landroid/content/Context;)V", "")]
		public unsafe void Stop (global::Android.Content.Context p0)
		{
			if (id_stop_Landroid_content_Context_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stop", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}

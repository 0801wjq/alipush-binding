using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Utl {

	[Register ("com/taobao/accs/utl/UT", DoNotGenerateAcw=true)]
	public abstract class UT : Java.Lang.Object {

		internal UT ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/field[@name='EVENT_ID']"
		[Register ("EVENT_ID")]
		public const int EventId = (int) 66001;
	}

	[Register ("com/taobao/accs/utl/UT", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UT' type. This type will be removed in a future release.")]
	public abstract class UTConsts : UT {

		private UTConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']"
	[Register ("com/taobao/accs/utl/UT", "", "Com.Taobao.Accs.Utl.IUTInvoker")]
	public partial interface IUT : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='commitEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;)V", "GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void CommitEvent (int p0, string p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='commitEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='commitEvent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='commitEvent' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.lang.String...']]"
		[Register ("commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V", "GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4, params  string[] p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='getUtdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdId", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetUtdId_Landroid_content_Context_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		string GetUtdId (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='onCaughException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onCaughException", "(Ljava/lang/Throwable;)V", "GetOnCaughException_Ljava_lang_Throwable_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void OnCaughException (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStart_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void Start (global::Android.App.Application p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.utl']/interface[@name='UT']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stop", "(Landroid/content/Context;)V", "GetStop_Landroid_content_Context_Handler:Com.Taobao.Accs.Utl.IUTInvoker, AliPush.Binding.Android")]
		void Stop (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/taobao/accs/utl/UT", DoNotGenerateAcw=true)]
	internal class IUTInvoker : global::Java.Lang.Object, IUT {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/taobao/accs/utl/UT");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTInvoker); }
		}

		IntPtr class_ref;

		public static IUT GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUT> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.taobao.accs.utl.UT"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_);
			return cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_;
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == null)
				cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_);
			return cb_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		}

		static void n_CommitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			string[] p5 = (string[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.CommitEvent (p0, p1, p2, p3, p4, p5);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
		}
#pragma warning restore 0169

		IntPtr id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		public unsafe void CommitEvent (int p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4, params  string[] p5)
		{
			if (id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitEvent_ILjava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_getUtdId_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetUtdId_Landroid_content_Context_Handler ()
		{
			if (cb_getUtdId_Landroid_content_Context_ == null)
				cb_getUtdId_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUtdId_Landroid_content_Context_);
			return cb_getUtdId_Landroid_content_Context_;
		}

		static IntPtr n_GetUtdId_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUtdId (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUtdId_Landroid_content_Context_;
		public unsafe string GetUtdId (global::Android.Content.Context p0)
		{
			if (id_getUtdId_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdId_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getUtdId", "(Landroid/content/Context;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUtdId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onCaughException_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnCaughException_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onCaughException_Ljava_lang_Throwable_ == null)
				cb_onCaughException_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCaughException_Ljava_lang_Throwable_);
			return cb_onCaughException_Ljava_lang_Throwable_;
		}

		static void n_OnCaughException_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCaughException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCaughException_Ljava_lang_Throwable_;
		public unsafe void OnCaughException (global::Java.Lang.Throwable p0)
		{
			if (id_onCaughException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onCaughException_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCaughException", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCaughException_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application p0 = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Start (global::Android.App.Application p0, string p1, string p2, string p3)
		{
			if (id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_Landroid_app_Application_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_stop_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStop_Landroid_content_Context_Handler ()
		{
			if (cb_stop_Landroid_content_Context_ == null)
				cb_stop_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Stop_Landroid_content_Context_);
			return cb_stop_Landroid_content_Context_;
		}

		static void n_Stop_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Utl.IUT __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Utl.IUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Stop (p0);
		}
#pragma warning restore 0169

		IntPtr id_stop_Landroid_content_Context_;
		public unsafe void Stop (global::Android.Content.Context p0)
		{
			if (id_stop_Landroid_content_Context_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stop", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop_Landroid_content_Context_, __args);
		}

	}

}

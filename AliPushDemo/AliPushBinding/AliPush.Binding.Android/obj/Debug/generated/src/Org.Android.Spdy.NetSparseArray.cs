using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']"
	[global::Android.Runtime.Register ("org/android/spdy/NetSparseArray", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public partial class NetSparseArray : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/NetSparseArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetSparseArray); }
		}

		protected NetSparseArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/constructor[@name='NetSparseArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetSparseArray ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NetSparseArray)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/constructor[@name='NetSparseArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NetSparseArray (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NetSparseArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_append_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_ILjava_lang_Object_Handler ()
		{
			if (cb_append_ILjava_lang_Object_ == null)
				cb_append_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Append_ILjava_lang_Object_);
			return cb_append_ILjava_lang_Object_;
		}

		static void n_Append_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Append (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_append_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='append' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("append", "(ILjava/lang/Object;)V", "GetAppend_ILjava_lang_Object_Handler")]
		public virtual unsafe void Append (int p0, global::Java.Lang.Object p1)
		{
			if (id_append_ILjava_lang_Object_ == IntPtr.Zero)
				id_append_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(ILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_delete_I;
#pragma warning disable 0169
		static Delegate GetDelete_IHandler ()
		{
			if (cb_delete_I == null)
				cb_delete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Delete_I);
			return cb_delete_I;
		}

		static void n_Delete_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delete_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delete", "(I)V", "GetDelete_IHandler")]
		public virtual unsafe void Delete (int p0)
		{
			if (id_delete_I == IntPtr.Zero)
				id_delete_I = JNIEnv.GetMethodID (class_ref, "delete", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual unsafe global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_ILjava_lang_Object_Handler ()
		{
			if (cb_get_ILjava_lang_Object_ == null)
				cb_get_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Get_ILjava_lang_Object_);
			return cb_get_ILjava_lang_Object_;
		}

		static IntPtr n_Get_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='get' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("get", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetGet_ILjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (int p0, global::Java.Lang.Object p1)
		{
			if (id_get_ILjava_lang_Object_ == IntPtr.Zero)
				id_get_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(ILjava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_indexOfKey_I;
#pragma warning disable 0169
		static Delegate GetIndexOfKey_IHandler ()
		{
			if (cb_indexOfKey_I == null)
				cb_indexOfKey_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_IndexOfKey_I);
			return cb_indexOfKey_I;
		}

		static int n_IndexOfKey_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOfKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_indexOfKey_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='indexOfKey' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("indexOfKey", "(I)I", "GetIndexOfKey_IHandler")]
		public virtual unsafe int IndexOfKey (int p0)
		{
			if (id_indexOfKey_I == IntPtr.Zero)
				id_indexOfKey_I = JNIEnv.GetMethodID (class_ref, "indexOfKey", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOfKey_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOfKey", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_indexOfValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIndexOfValue_Ljava_lang_Object_Handler ()
		{
			if (cb_indexOfValue_Ljava_lang_Object_ == null)
				cb_indexOfValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IndexOfValue_Ljava_lang_Object_);
			return cb_indexOfValue_Ljava_lang_Object_;
		}

		static int n_IndexOfValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOfValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOfValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='indexOfValue' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("indexOfValue", "(Ljava/lang/Object;)I", "GetIndexOfValue_Ljava_lang_Object_Handler")]
		public virtual unsafe int IndexOfValue (global::Java.Lang.Object p0)
		{
			if (id_indexOfValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_indexOfValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "indexOfValue", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOfValue_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOfValue", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_keyAt_I;
#pragma warning disable 0169
		static Delegate GetKeyAt_IHandler ()
		{
			if (cb_keyAt_I == null)
				cb_keyAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_KeyAt_I);
			return cb_keyAt_I;
		}

		static int n_KeyAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeyAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_keyAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='keyAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("keyAt", "(I)I", "GetKeyAt_IHandler")]
		public virtual unsafe int KeyAt (int p0)
		{
			if (id_keyAt_I == IntPtr.Zero)
				id_keyAt_I = JNIEnv.GetMethodID (class_ref, "keyAt", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_keyAt_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keyAt", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_put_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_ILjava_lang_Object_Handler ()
		{
			if (cb_put_ILjava_lang_Object_ == null)
				cb_put_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Put_ILjava_lang_Object_);
			return cb_put_ILjava_lang_Object_;
		}

		static void n_Put_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='put' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("put", "(ILjava/lang/Object;)V", "GetPut_ILjava_lang_Object_Handler")]
		public virtual unsafe void Put (int p0, global::Java.Lang.Object p1)
		{
			if (id_put_ILjava_lang_Object_ == IntPtr.Zero)
				id_put_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(ILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual unsafe void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveAt_IHandler ()
		{
			if (cb_removeAt_I == null)
				cb_removeAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveAt_I);
			return cb_removeAt_I;
		}

		static void n_RemoveAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='removeAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAt", "(I)V", "GetRemoveAt_IHandler")]
		public virtual unsafe void RemoveAt (int p0)
		{
			if (id_removeAt_I == IntPtr.Zero)
				id_removeAt_I = JNIEnv.GetMethodID (class_ref, "removeAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAt", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setValueAt_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetValueAt_ILjava_lang_Object_Handler ()
		{
			if (cb_setValueAt_ILjava_lang_Object_ == null)
				cb_setValueAt_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetValueAt_ILjava_lang_Object_);
			return cb_setValueAt_ILjava_lang_Object_;
		}

		static void n_SetValueAt_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetValueAt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setValueAt_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='setValueAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("setValueAt", "(ILjava/lang/Object;)V", "GetSetValueAt_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetValueAt (int p0, global::Java.Lang.Object p1)
		{
			if (id_setValueAt_ILjava_lang_Object_ == IntPtr.Zero)
				id_setValueAt_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValueAt", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueAt_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValueAt", "(ILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static void n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.ToArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_toArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='E[]']]"
		[Register ("toArray", "([Ljava/lang/Object;)V", "GetToArray_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void ToArray (global::Java.Lang.Object[] p0)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toArray_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_valueAt_I;
#pragma warning disable 0169
		static Delegate GetValueAt_IHandler ()
		{
			if (cb_valueAt_I == null)
				cb_valueAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ValueAt_I);
			return cb_valueAt_I;
		}

		static IntPtr n_ValueAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Android.Spdy.NetSparseArray __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.NetSparseArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_valueAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='NetSparseArray']/method[@name='valueAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueAt", "(I)Ljava/lang/Object;", "GetValueAt_IHandler")]
		public virtual unsafe global::Java.Lang.Object ValueAt (int p0)
		{
			if (id_valueAt_I == IntPtr.Zero)
				id_valueAt_I = JNIEnv.GetMethodID (class_ref, "valueAt", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_valueAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "valueAt", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

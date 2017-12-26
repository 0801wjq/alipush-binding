using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']"
	[global::Android.Runtime.Register ("com/taobao/accs/client/GlobalClientInfo", DoNotGenerateAcw=true)]
	public partial class GlobalClientInfo : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/field[@name='a']"
		[Register ("a")]
		public static global::Android.Content.Context A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/field[@name='b']"
		[Register ("b")]
		public static global::Com.Taobao.Accs.IAgooAppReceiver B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/taobao/accs/IAgooAppReceiver;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAgooAppReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/taobao/accs/IAgooAppReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/field[@name='c']"
		[Register ("c")]
		public static string C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/field[@name='d']"
		[Register ("d")]
		public static bool D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, d_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/client/GlobalClientInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlobalClientInfo); }
		}

		protected GlobalClientInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActivityManager;
#pragma warning disable 0169
		static Delegate GetGetActivityManagerHandler ()
		{
			if (cb_getActivityManager == null)
				cb_getActivityManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivityManager);
			return cb_getActivityManager;
		}

		static IntPtr n_GetActivityManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActivityManager);
		}
#pragma warning restore 0169

		static IntPtr id_getActivityManager;
		public virtual unsafe global::Android.App.ActivityManager ActivityManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getActivityManager' and count(parameter)=0]"
			[Register ("getActivityManager", "()Landroid/app/ActivityManager;", "GetGetActivityManagerHandler")]
			get {
				if (id_getActivityManager == IntPtr.Zero)
					id_getActivityManager = JNIEnv.GetMethodID (class_ref, "getActivityManager", "()Landroid/app/ActivityManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.ActivityManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivityManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.ActivityManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivityManager", "()Landroid/app/ActivityManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppReceiver;
#pragma warning disable 0169
		static Delegate GetGetAppReceiverHandler ()
		{
			if (cb_getAppReceiver == null)
				cb_getAppReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppReceiver);
			return cb_getAppReceiver;
		}

		static IntPtr n_GetAppReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Taobao.Accs.IAppReceiver>.ToLocalJniHandle (__this.AppReceiver);
		}
#pragma warning restore 0169

		static IntPtr id_getAppReceiver;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Taobao.Accs.IAppReceiver> AppReceiver {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getAppReceiver' and count(parameter)=0]"
			[Register ("getAppReceiver", "()Ljava/util/Map;", "GetGetAppReceiverHandler")]
			get {
				if (id_getAppReceiver == IntPtr.Zero)
					id_getAppReceiver = JNIEnv.GetMethodID (class_ref, "getAppReceiver", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Com.Taobao.Accs.IAppReceiver>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppReceiver), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Com.Taobao.Accs.IAppReceiver>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppReceiver", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectivityManager;
#pragma warning disable 0169
		static Delegate GetGetConnectivityManagerHandler ()
		{
			if (cb_getConnectivityManager == null)
				cb_getConnectivityManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectivityManager);
			return cb_getConnectivityManager;
		}

		static IntPtr n_GetConnectivityManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectivityManager);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectivityManager;
		public virtual unsafe global::Android.Net.ConnectivityManager ConnectivityManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getConnectivityManager' and count(parameter)=0]"
			[Register ("getConnectivityManager", "()Landroid/net/ConnectivityManager;", "GetGetConnectivityManagerHandler")]
			get {
				if (id_getConnectivityManager == IntPtr.Zero)
					id_getConnectivityManager = JNIEnv.GetMethodID (class_ref, "getConnectivityManager", "()Landroid/net/ConnectivityManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.ConnectivityManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectivityManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.ConnectivityManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectivityManager", "()Landroid/net/ConnectivityManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getContext;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getElectionBlackList;
#pragma warning disable 0169
		static Delegate GetGetElectionBlackListHandler ()
		{
			if (cb_getElectionBlackList == null)
				cb_getElectionBlackList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElectionBlackList);
			return cb_getElectionBlackList;
		}

		static IntPtr n_GetElectionBlackList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.ToLocalJniHandle (__this.ElectionBlackList);
		}
#pragma warning restore 0169

		static Delegate cb_setElectionBlackList_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetElectionBlackList_Ljava_util_Map_Handler ()
		{
			if (cb_setElectionBlackList_Ljava_util_Map_ == null)
				cb_setElectionBlackList_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetElectionBlackList_Ljava_util_Map_);
			return cb_setElectionBlackList_Ljava_util_Map_;
		}

		static void n_SetElectionBlackList_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ElectionBlackList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getElectionBlackList;
		static IntPtr id_setElectionBlackList_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>> ElectionBlackList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getElectionBlackList' and count(parameter)=0]"
			[Register ("getElectionBlackList", "()Ljava/util/Map;", "GetGetElectionBlackListHandler")]
			get {
				if (id_getElectionBlackList == IntPtr.Zero)
					id_getElectionBlackList = JNIEnv.GetMethodID (class_ref, "getElectionBlackList", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElectionBlackList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElectionBlackList", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='setElectionBlackList' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.Set&lt;java.lang.Integer&gt;&gt;']]"
			[Register ("setElectionBlackList", "(Ljava/util/Map;)V", "GetSetElectionBlackList_Ljava_util_Map_Handler")]
			set {
				if (id_setElectionBlackList_Ljava_util_Map_ == IntPtr.Zero)
					id_setElectionBlackList_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setElectionBlackList", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setElectionBlackList_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setElectionBlackList", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPackageInfo;
#pragma warning disable 0169
		static Delegate GetGetPackageInfoHandler ()
		{
			if (cb_getPackageInfo == null)
				cb_getPackageInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageInfo);
			return cb_getPackageInfo;
		}

		static IntPtr n_GetPackageInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackageInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getPackageInfo;
		public virtual unsafe global::Android.Content.PM.PackageInfo PackageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getPackageInfo' and count(parameter)=0]"
			[Register ("getPackageInfo", "()Landroid/content/pm/PackageInfo;", "GetGetPackageInfoHandler")]
			get {
				if (id_getPackageInfo == IntPtr.Zero)
					id_getPackageInfo = JNIEnv.GetMethodID (class_ref, "getPackageInfo", "()Landroid/content/pm/PackageInfo;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.PM.PackageInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.PM.PackageInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackageInfo", "()Landroid/content/pm/PackageInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearLoginInfoImpl;
#pragma warning disable 0169
		static Delegate GetClearLoginInfoImplHandler ()
		{
			if (cb_clearLoginInfoImpl == null)
				cb_clearLoginInfoImpl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearLoginInfoImpl);
			return cb_clearLoginInfoImpl;
		}

		static void n_ClearLoginInfoImpl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearLoginInfoImpl ();
		}
#pragma warning restore 0169

		static IntPtr id_clearLoginInfoImpl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='clearLoginInfoImpl' and count(parameter)=0]"
		[Register ("clearLoginInfoImpl", "()V", "GetClearLoginInfoImplHandler")]
		public virtual unsafe void ClearLoginInfoImpl ()
		{
			if (id_clearLoginInfoImpl == IntPtr.Zero)
				id_clearLoginInfoImpl = JNIEnv.GetMethodID (class_ref, "clearLoginInfoImpl", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearLoginInfoImpl);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearLoginInfoImpl", "()V"));
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/taobao/accs/client/GlobalClientInfo;", "")]
		public static unsafe global::Com.Taobao.Accs.Client.GlobalClientInfo GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/taobao/accs/client/GlobalClientInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Taobao.Accs.Client.GlobalClientInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetListener_Ljava_lang_String_Handler ()
		{
			if (cb_getListener_Ljava_lang_String_ == null)
				cb_getListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListener_Ljava_lang_String_);
			return cb_getListener_Ljava_lang_String_;
		}

		static IntPtr n_GetListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getListener", "(Ljava/lang/String;)Lcom/taobao/accs/base/AccsAbstractDataListener;", "GetGetListener_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Taobao.Accs.Base.AccsAbstractDataListener GetListener (string p0)
		{
			if (id_getListener_Ljava_lang_String_ == IntPtr.Zero)
				id_getListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getListener", "(Ljava/lang/String;)Lcom/taobao/accs/base/AccsAbstractDataListener;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Taobao.Accs.Base.AccsAbstractDataListener __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListener_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "(Ljava/lang/String;)Lcom/taobao/accs/base/AccsAbstractDataListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getNick_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNick_Ljava_lang_String_Handler ()
		{
			if (cb_getNick_Ljava_lang_String_ == null)
				cb_getNick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNick_Ljava_lang_String_);
			return cb_getNick_Ljava_lang_String_;
		}

		static IntPtr n_GetNick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNick (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNick_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getNick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNick", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetNick_Ljava_lang_String_Handler")]
		public virtual unsafe string GetNick (string p0)
		{
			if (id_getNick_Ljava_lang_String_ == IntPtr.Zero)
				id_getNick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNick", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNick_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNick", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetService_Ljava_lang_String_Handler ()
		{
			if (cb_getService_Ljava_lang_String_ == null)
				cb_getService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetService_Ljava_lang_String_);
			return cb_getService_Ljava_lang_String_;
		}

		static IntPtr n_GetService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetService (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetService_Ljava_lang_String_Handler")]
		public virtual unsafe string GetService (string p0)
		{
			if (id_getService_Ljava_lang_String_ == IntPtr.Zero)
				id_getService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getService", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSid_Ljava_lang_String_Handler ()
		{
			if (cb_getSid_Ljava_lang_String_ == null)
				cb_getSid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSid_Ljava_lang_String_);
			return cb_getSid_Ljava_lang_String_;
		}

		static IntPtr n_GetSid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSid (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getSid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSid", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSid_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSid (string p0)
		{
			if (id_getSid_Ljava_lang_String_ == IntPtr.Zero)
				id_getSid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSid", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSid_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSid", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_getUserId_Ljava_lang_String_ == null)
				cb_getUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserId_Ljava_lang_String_);
			return cb_getUserId_Ljava_lang_String_;
		}

		static IntPtr n_GetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='getUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetUserId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetUserId (string p0)
		{
			if (id_getUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUserId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
#pragma warning disable 0169
		static Delegate GetRegisterListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler ()
		{
			if (cb_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == null)
				cb_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_);
			return cb_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		}

		static void n_RegisterListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.Base.AccsAbstractDataListener p1 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Base.AccsAbstractDataListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='registerListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.base.AccsAbstractDataListener']]"
		[Register ("registerListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V", "GetRegisterListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_Handler")]
		public virtual unsafe void RegisterListener (string p0, global::Com.Taobao.Accs.Base.AccsAbstractDataListener p1)
		{
			if (id_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ == IntPtr.Zero)
				id_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerListener_Ljava_lang_String_Lcom_taobao_accs_base_AccsAbstractDataListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerListener", "(Ljava/lang/String;Lcom/taobao/accs/base/AccsAbstractDataListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerService_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterService_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerService_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerService_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterService_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerService_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterService_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerService_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='registerService' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerService", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterService_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterService (string p0, string p1)
		{
			if (id_registerService_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerService_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerService", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerService_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerService", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
#pragma warning disable 0169
		static Delegate GetSetAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler ()
		{
			if (cb_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == null)
				cb_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_);
			return cb_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		}

		static void n_SetAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.IAppReceiver p1 = (global::Com.Taobao.Accs.IAppReceiver)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.IAppReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAppReceiver (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='setAppReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.IAppReceiver']]"
		[Register ("setAppReceiver", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V", "GetSetAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_Handler")]
		public virtual unsafe void SetAppReceiver (string p0, global::Com.Taobao.Accs.IAppReceiver p1)
		{
			if (id_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ == IntPtr.Zero)
				id_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_ = JNIEnv.GetMethodID (class_ref, "setAppReceiver", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppReceiver_Ljava_lang_String_Lcom_taobao_accs_IAppReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppReceiver", "(Ljava/lang/String;Lcom/taobao/accs/IAppReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_;
#pragma warning disable 0169
		static Delegate GetSetLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_Handler ()
		{
			if (cb_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_ == null)
				cb_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_);
			return cb_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_;
		}

		static void n_SetLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Taobao.Accs.ILoginInfo p1 = (global::Com.Taobao.Accs.ILoginInfo)global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.ILoginInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLoginInfoImpl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='setLoginInfoImpl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.taobao.accs.ILoginInfo']]"
		[Register ("setLoginInfoImpl", "(Ljava/lang/String;Lcom/taobao/accs/ILoginInfo;)V", "GetSetLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_Handler")]
		public virtual unsafe void SetLoginInfoImpl (string p0, global::Com.Taobao.Accs.ILoginInfo p1)
		{
			if (id_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_ == IntPtr.Zero)
				id_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_ = JNIEnv.GetMethodID (class_ref, "setLoginInfoImpl", "(Ljava/lang/String;Lcom/taobao/accs/ILoginInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoginInfoImpl_Ljava_lang_String_Lcom_taobao_accs_ILoginInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoginInfoImpl", "(Ljava/lang/String;Lcom/taobao/accs/ILoginInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unRegisterService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterService_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterService_Ljava_lang_String_ == null)
				cb_unRegisterService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterService_Ljava_lang_String_);
			return cb_unRegisterService_Ljava_lang_String_;
		}

		static void n_UnRegisterService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unRegisterService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='unRegisterService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterService", "(Ljava/lang/String;)V", "GetUnRegisterService_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterService (string p0)
		{
			if (id_unRegisterService_Ljava_lang_String_ == IntPtr.Zero)
				id_unRegisterService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unRegisterService", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterService_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisterService", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unregisterListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnregisterListener_Ljava_lang_String_Handler ()
		{
			if (cb_unregisterListener_Ljava_lang_String_ == null)
				cb_unregisterListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterListener_Ljava_lang_String_);
			return cb_unregisterListener_Ljava_lang_String_;
		}

		static void n_UnregisterListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Taobao.Accs.Client.GlobalClientInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Client.GlobalClientInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.client']/class[@name='GlobalClientInfo']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterListener", "(Ljava/lang/String;)V", "GetUnregisterListener_Ljava_lang_String_Handler")]
		public virtual unsafe void UnregisterListener (string p0)
		{
			if (id_unregisterListener_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterListener", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterListener_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterListener", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='IMonitor.Stub']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/IMonitor$Stub", DoNotGenerateAcw=true)]
	public abstract partial class MonitorStub : global::Android.OS.Binder, global::Com.Alibaba.Mtl.Appmonitor.IMonitor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/IMonitor$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitorStub); }
		}

		protected MonitorStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='IMonitor.Stub']/constructor[@name='IMonitor.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MonitorStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MonitorStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='IMonitor.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='IMonitor.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/alibaba/mtl/appmonitor/IMonitor;", "")]
		public static unsafe global::Com.Alibaba.Mtl.Appmonitor.IMonitor AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/alibaba/mtl/appmonitor/IMonitor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Com.Alibaba.Mtl.Appmonitor.IMonitor __ret = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='IMonitor.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (code);
				__args [1] = new JValue (data);
				__args [2] = new JValue (reply);
				__args [3] = new JValue (flags);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Alarm_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool Alarm_checkSampled (string p0, string p1);

		static Delegate cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail1 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void Alarm_commitFail1 (string p0, string p1, string p2, string p3, global::System.Collections.IDictionary p4);

		static Delegate cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail2 (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail2' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map']]"
		[Register ("alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void Alarm_commitFail2 (string p0, string p1, string p2, string p3, string p4, global::System.Collections.IDictionary p5);

		static Delegate cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess1 (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void Alarm_commitSuccess1 (string p0, string p1, global::System.Collections.IDictionary p2);

		static Delegate cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess2 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void Alarm_commitSuccess2 (string p0, string p1, string p2, global::System.Collections.IDictionary p3);

		static Delegate cb_alarm_setSampling_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setSampling_IHandler ()
		{
			if (cb_alarm_setSampling_I == null)
				cb_alarm_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setSampling_I);
			return cb_alarm_setSampling_I;
		}

		static void n_Alarm_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setSampling", "(I)V", "GetAlarm_setSampling_IHandler")]
		public abstract void Alarm_setSampling (int p0);

		static Delegate cb_alarm_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setStatisticsInterval_IHandler ()
		{
			if (cb_alarm_setStatisticsInterval_I == null)
				cb_alarm_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setStatisticsInterval_I);
			return cb_alarm_setStatisticsInterval_I;
		}

		static void n_Alarm_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setStatisticsInterval", "(I)V", "GetAlarm_setStatisticsInterval_IHandler")]
		public abstract void Alarm_setStatisticsInterval (int p0);

		static Delegate cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Counter_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool Counter_checkSampled (string p0, string p1);

		static Delegate cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit1 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public abstract void Counter_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3);

		static Delegate cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit2 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public abstract void Counter_commit2 (string p0, string p1, string p2, double p3, global::System.Collections.IDictionary p4);

		static Delegate cb_counter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetCounter_setSampling_IHandler ()
		{
			if (cb_counter_setSampling_I == null)
				cb_counter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setSampling_I);
			return cb_counter_setSampling_I;
		}

		static void n_Counter_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setSampling", "(I)V", "GetCounter_setSampling_IHandler")]
		public abstract void Counter_setSampling (int p0);

		static Delegate cb_counter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetCounter_setStatisticsInterval_IHandler ()
		{
			if (cb_counter_setStatisticsInterval_I == null)
				cb_counter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setStatisticsInterval_I);
			return cb_counter_setStatisticsInterval_I;
		}

		static void n_Counter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setStatisticsInterval", "(I)V", "GetCounter_setStatisticsInterval_IHandler")]
		public abstract void Counter_setStatisticsInterval (int p0);

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public abstract void Destroy ();

		static Delegate cb_enableLog_Z;
#pragma warning disable 0169
		static Delegate GetEnableLog_ZHandler ()
		{
			if (cb_enableLog_Z == null)
				cb_enableLog_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableLog_Z);
			return cb_enableLog_Z;
		}

		static void n_EnableLog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "GetEnableLog_ZHandler")]
		public abstract void EnableLog (bool p0);

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public abstract void Init ();

		static Delegate cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offlinecounter_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool Offlinecounter_checkSampled (string p0, string p1);

		static Delegate cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler ()
		{
			if (cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == null)
				cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D);
			return cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		}

		static void n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_commit (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler")]
		public abstract void Offlinecounter_commit (string p0, string p1, double p2);

		static Delegate cb_offlinecounter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setSampling_IHandler ()
		{
			if (cb_offlinecounter_setSampling_I == null)
				cb_offlinecounter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setSampling_I);
			return cb_offlinecounter_setSampling_I;
		}

		static void n_Offlinecounter_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setSampling", "(I)V", "GetOfflinecounter_setSampling_IHandler")]
		public abstract void Offlinecounter_setSampling (int p0);

		static Delegate cb_offlinecounter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setStatisticsInterval_IHandler ()
		{
			if (cb_offlinecounter_setStatisticsInterval_I == null)
				cb_offlinecounter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setStatisticsInterval_I);
			return cb_offlinecounter_setStatisticsInterval_I;
		}

		static void n_Offlinecounter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setStatisticsInterval", "(I)V", "GetOfflinecounter_setStatisticsInterval_IHandler")]
		public abstract void Offlinecounter_setStatisticsInterval (int p0);

		static Delegate cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
#pragma warning disable 0169
		static Delegate GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler ()
		{
			if (cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == null)
				cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_);
			return cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		}

		static void n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register1 (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register ("register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler")]
		public abstract void Register1 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2);

		static Delegate cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler ()
		{
			if (cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == null)
				cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z);
			return cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		}

		static void n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register2 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='boolean']]"
		[Register ("register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V", "GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler")]
		public abstract void Register2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, bool p3);

		static Delegate cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
#pragma warning disable 0169
		static Delegate GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler ()
		{
			if (cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == null)
				cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_);
			return cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		}

		static void n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Register3 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register3' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet']]"
		[Register ("register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V", "GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler")]
		public abstract void Register3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3);

		static Delegate cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler ()
		{
			if (cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == null)
				cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z);
			return cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		}

		static void n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Register4 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register4' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register ("register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler")]
		public abstract void Register4 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3, bool p4);

		static Delegate cb_setChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setChannel_Ljava_lang_String_ == null)
				cb_setChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_lang_String_);
			return cb_setChannel_Ljava_lang_String_;
		}

		static void n_SetChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler")]
		public abstract void SetChannel (string p0);

		static Delegate cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestAuthInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setRequestAuthInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void SetRequestAuthInfo (bool p0, string p1, string p2, string p3);

		static Delegate cb_setSampling_I;
#pragma warning disable 0169
		static Delegate GetSetSampling_IHandler ()
		{
			if (cb_setSampling_I == null)
				cb_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSampling_I);
			return cb_setSampling_I;
		}

		static void n_SetSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSampling", "(I)V", "GetSetSampling_IHandler")]
		public abstract void SetSampling (int p0);

		static Delegate cb_setStatisticsInterval1_I;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval1_IHandler ()
		{
			if (cb_setStatisticsInterval1_I == null)
				cb_setStatisticsInterval1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatisticsInterval1_I);
			return cb_setStatisticsInterval1_I;
		}

		static void n_SetStatisticsInterval1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval1 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatisticsInterval1", "(I)V", "GetSetStatisticsInterval1_IHandler")]
		public abstract void SetStatisticsInterval1 (int p0);

		static Delegate cb_setStatisticsInterval2_II;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval2_IIHandler ()
		{
			if (cb_setStatisticsInterval2_II == null)
				cb_setStatisticsInterval2_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetStatisticsInterval2_II);
			return cb_setStatisticsInterval2_II;
		}

		static void n_SetStatisticsInterval2_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval2 (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setStatisticsInterval2", "(II)V", "GetSetStatisticsInterval2_IIHandler")]
		public abstract void SetStatisticsInterval2 (int p0, int p1);

		static Delegate cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Stat_begin (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_begin' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void Stat_begin (string p0, string p1, string p2);

		static Delegate cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Stat_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool Stat_checkSampled (string p0, string p1);

		static Delegate cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit1 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public abstract void Stat_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3);

		static Delegate cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == null)
				cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_);
			return cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		}

		static void n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit2 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V", "GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler")]
		public abstract void Stat_commit2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, double p3, global::System.Collections.IDictionary p4);

		static Delegate cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler ()
		{
			if (cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == null)
				cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_);
			return cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		}

		static void n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit3 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit3' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V", "GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler")]
		public abstract void Stat_commit3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3, global::System.Collections.IDictionary p4);

		static Delegate cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Stat_end (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_end' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void Stat_end (string p0, string p1, string p2);

		static Delegate cb_stat_setSampling_I;
#pragma warning disable 0169
		static Delegate GetStat_setSampling_IHandler ()
		{
			if (cb_stat_setSampling_I == null)
				cb_stat_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setSampling_I);
			return cb_stat_setSampling_I;
		}

		static void n_Stat_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setSampling (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setSampling", "(I)V", "GetStat_setSampling_IHandler")]
		public abstract void Stat_setSampling (int p0);

		static Delegate cb_stat_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetStat_setStatisticsInterval_IHandler ()
		{
			if (cb_stat_setStatisticsInterval_I == null)
				cb_stat_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setStatisticsInterval_I);
			return cb_stat_setStatisticsInterval_I;
		}

		static void n_Stat_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setStatisticsInterval", "(I)V", "GetStat_setStatisticsInterval_IHandler")]
		public abstract void Stat_setStatisticsInterval (int p0);

		static Delegate cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_begin (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_begin' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public abstract void Transaction_begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1);

		static Delegate cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_end (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_end' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public abstract void Transaction_end (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1);

		static Delegate cb_triggerUpload;
#pragma warning disable 0169
		static Delegate GetTriggerUploadHandler ()
		{
			if (cb_triggerUpload == null)
				cb_triggerUpload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TriggerUpload);
			return cb_triggerUpload;
		}

		static void n_TriggerUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TriggerUpload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='triggerUpload' and count(parameter)=0]"
		[Register ("triggerUpload", "()V", "GetTriggerUploadHandler")]
		public abstract void TriggerUpload ();

		static Delegate cb_turnOffRealTimeDebug;
#pragma warning disable 0169
		static Delegate GetTurnOffRealTimeDebugHandler ()
		{
			if (cb_turnOffRealTimeDebug == null)
				cb_turnOffRealTimeDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOffRealTimeDebug);
			return cb_turnOffRealTimeDebug;
		}

		static void n_TurnOffRealTimeDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffRealTimeDebug ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "GetTurnOffRealTimeDebugHandler")]
		public abstract void TurnOffRealTimeDebug ();

		static Delegate cb_turnOnRealTimeDebug_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTurnOnRealTimeDebug_Ljava_util_Map_Handler ()
		{
			if (cb_turnOnRealTimeDebug_Ljava_util_Map_ == null)
				cb_turnOnRealTimeDebug_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOnRealTimeDebug_Ljava_util_Map_);
			return cb_turnOnRealTimeDebug_Ljava_util_Map_;
		}

		static void n_TurnOnRealTimeDebug_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnRealTimeDebug (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "GetTurnOnRealTimeDebug_Ljava_util_Map_Handler")]
		public abstract void TurnOnRealTimeDebug (global::System.Collections.IDictionary p0);

		static Delegate cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
#pragma warning disable 0169
		static Delegate GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler ()
		{
			if (cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == null)
				cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, double>) n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD);
			return cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		}

		static void n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, double p4, double p5)
		{
			global::Com.Alibaba.Mtl.Appmonitor.MonitorStub __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.MonitorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMeasure (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='updateMeasure' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V", "GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler")]
		public abstract void UpdateMeasure (string p0, string p1, string p2, double p3, double p4, double p5);

	}

	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/IMonitor$Stub", DoNotGenerateAcw=true)]
	internal partial class MonitorStubInvoker : MonitorStub {

		public MonitorStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitorStubInvoker); }
		}

		static IntPtr id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Alarm_checkSampled (string p0, string p1)
		{
			if (id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitFail1 (string p0, string p1, string p2, string p3, global::System.Collections.IDictionary p4)
		{
			if (id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail2' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map']]"
		[Register ("alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitFail2 (string p0, string p1, string p2, string p3, string p4, global::System.Collections.IDictionary p5)
		{
			if (id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitSuccess1 (string p0, string p1, global::System.Collections.IDictionary p2)
		{
			if (id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitSuccess2 (string p0, string p1, string p2, global::System.Collections.IDictionary p3)
		{
			if (id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_alarm_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setSampling", "(I)V", "GetAlarm_setSampling_IHandler")]
		public override unsafe void Alarm_setSampling (int p0)
		{
			if (id_alarm_setSampling_I == IntPtr.Zero)
				id_alarm_setSampling_I = JNIEnv.GetMethodID (class_ref, "alarm_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_alarm_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setStatisticsInterval", "(I)V", "GetAlarm_setStatisticsInterval_IHandler")]
		public override unsafe void Alarm_setStatisticsInterval (int p0)
		{
			if (id_alarm_setStatisticsInterval_I == IntPtr.Zero)
				id_alarm_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "alarm_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setStatisticsInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Counter_checkSampled (string p0, string p1)
		{
			if (id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Counter_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3)
		{
			if (id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Counter_commit2 (string p0, string p1, string p2, double p3, global::System.Collections.IDictionary p4)
		{
			if (id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_counter_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setSampling", "(I)V", "GetCounter_setSampling_IHandler")]
		public override unsafe void Counter_setSampling (int p0)
		{
			if (id_counter_setSampling_I == IntPtr.Zero)
				id_counter_setSampling_I = JNIEnv.GetMethodID (class_ref, "counter_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_counter_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setStatisticsInterval", "(I)V", "GetCounter_setStatisticsInterval_IHandler")]
		public override unsafe void Counter_setStatisticsInterval (int p0)
		{
			if (id_counter_setStatisticsInterval_I == IntPtr.Zero)
				id_counter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "counter_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setStatisticsInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_enableLog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "GetEnableLog_ZHandler")]
		public override unsafe void EnableLog (bool p0)
		{
			if (id_enableLog_Z == IntPtr.Zero)
				id_enableLog_Z = JNIEnv.GetMethodID (class_ref, "enableLog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableLog_Z, __args);
			} finally {
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public override unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
			} finally {
			}
		}

		static IntPtr id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Offlinecounter_checkSampled (string p0, string p1)
		{
			if (id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler")]
		public override unsafe void Offlinecounter_commit (string p0, string p1, double p2)
		{
			if (id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
				id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_offlinecounter_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setSampling", "(I)V", "GetOfflinecounter_setSampling_IHandler")]
		public override unsafe void Offlinecounter_setSampling (int p0)
		{
			if (id_offlinecounter_setSampling_I == IntPtr.Zero)
				id_offlinecounter_setSampling_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_offlinecounter_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setStatisticsInterval", "(I)V", "GetOfflinecounter_setStatisticsInterval_IHandler")]
		public override unsafe void Offlinecounter_setStatisticsInterval (int p0)
		{
			if (id_offlinecounter_setStatisticsInterval_I == IntPtr.Zero)
				id_offlinecounter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setStatisticsInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register ("register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler")]
		public override unsafe void Register1 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2)
		{
			if (id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == IntPtr.Zero)
				id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNIEnv.GetMethodID (class_ref, "register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='boolean']]"
		[Register ("register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V", "GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler")]
		public override unsafe void Register2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, bool p3)
		{
			if (id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == IntPtr.Zero)
				id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNIEnv.GetMethodID (class_ref, "register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register3' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet']]"
		[Register ("register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V", "GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler")]
		public override unsafe void Register3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3)
		{
			if (id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == IntPtr.Zero)
				id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNIEnv.GetMethodID (class_ref, "register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register4' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register ("register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler")]
		public override unsafe void Register4 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3, bool p4)
		{
			if (id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == IntPtr.Zero)
				id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNIEnv.GetMethodID (class_ref, "register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler")]
		public override unsafe void SetChannel (string p0)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannel_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setRequestAuthInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void SetRequestAuthInfo (bool p0, string p1, string p2, string p3)
		{
			if (id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSampling", "(I)V", "GetSetSampling_IHandler")]
		public override unsafe void SetSampling (int p0)
		{
			if (id_setSampling_I == IntPtr.Zero)
				id_setSampling_I = JNIEnv.GetMethodID (class_ref, "setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_setStatisticsInterval1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatisticsInterval1", "(I)V", "GetSetStatisticsInterval1_IHandler")]
		public override unsafe void SetStatisticsInterval1 (int p0)
		{
			if (id_setStatisticsInterval1_I == IntPtr.Zero)
				id_setStatisticsInterval1_I = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval1", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval1_I, __args);
			} finally {
			}
		}

		static IntPtr id_setStatisticsInterval2_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setStatisticsInterval2", "(II)V", "GetSetStatisticsInterval2_IIHandler")]
		public override unsafe void SetStatisticsInterval2 (int p0, int p1)
		{
			if (id_setStatisticsInterval2_II == IntPtr.Zero)
				id_setStatisticsInterval2_II = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval2", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval2_II, __args);
			} finally {
			}
		}

		static IntPtr id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_begin' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void Stat_begin (string p0, string p1, string p2)
		{
			if (id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Stat_checkSampled (string p0, string p1)
		{
			if (id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Stat_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3)
		{
			if (id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V", "GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler")]
		public override unsafe void Stat_commit2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, double p3, global::System.Collections.IDictionary p4)
		{
			if (id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit3' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V", "GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler")]
		public override unsafe void Stat_commit3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3, global::System.Collections.IDictionary p4)
		{
			if (id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == IntPtr.Zero)
				id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_end' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void Stat_end (string p0, string p1, string p2)
		{
			if (id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stat_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setSampling", "(I)V", "GetStat_setSampling_IHandler")]
		public override unsafe void Stat_setSampling (int p0)
		{
			if (id_stat_setSampling_I == IntPtr.Zero)
				id_stat_setSampling_I = JNIEnv.GetMethodID (class_ref, "stat_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setSampling_I, __args);
			} finally {
			}
		}

		static IntPtr id_stat_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setStatisticsInterval", "(I)V", "GetStat_setStatisticsInterval_IHandler")]
		public override unsafe void Stat_setStatisticsInterval (int p0)
		{
			if (id_stat_setStatisticsInterval_I == IntPtr.Zero)
				id_stat_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "stat_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setStatisticsInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_begin' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public override unsafe void Transaction_begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1)
		{
			if (id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_end' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public override unsafe void Transaction_end (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1)
		{
			if (id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_triggerUpload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='triggerUpload' and count(parameter)=0]"
		[Register ("triggerUpload", "()V", "GetTriggerUploadHandler")]
		public override unsafe void TriggerUpload ()
		{
			if (id_triggerUpload == IntPtr.Zero)
				id_triggerUpload = JNIEnv.GetMethodID (class_ref, "triggerUpload", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_triggerUpload);
			} finally {
			}
		}

		static IntPtr id_turnOffRealTimeDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "GetTurnOffRealTimeDebugHandler")]
		public override unsafe void TurnOffRealTimeDebug ()
		{
			if (id_turnOffRealTimeDebug == IntPtr.Zero)
				id_turnOffRealTimeDebug = JNIEnv.GetMethodID (class_ref, "turnOffRealTimeDebug", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffRealTimeDebug);
			} finally {
			}
		}

		static IntPtr id_turnOnRealTimeDebug_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "GetTurnOnRealTimeDebug_Ljava_util_Map_Handler")]
		public override unsafe void TurnOnRealTimeDebug (global::System.Collections.IDictionary p0)
		{
			if (id_turnOnRealTimeDebug_Ljava_util_Map_ == IntPtr.Zero)
				id_turnOnRealTimeDebug_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "turnOnRealTimeDebug", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnRealTimeDebug_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='updateMeasure' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V", "GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler")]
		public override unsafe void UpdateMeasure (string p0, string p1, string p2, double p3, double p4, double p5)
		{
			if (id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == IntPtr.Zero)
				id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNIEnv.GetMethodID (class_ref, "updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']"
	[Register ("com/alibaba/mtl/appmonitor/IMonitor", "", "Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker")]
	public partial interface IMonitor : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		bool Alarm_checkSampled (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_commitFail1 (string p0, string p1, string p2, string p3, global::System.Collections.IDictionary p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitFail2' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map']]"
		[Register ("alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_commitFail2 (string p0, string p1, string p2, string p3, string p4, global::System.Collections.IDictionary p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_commitSuccess1 (string p0, string p1, global::System.Collections.IDictionary p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_commitSuccess2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_commitSuccess2 (string p0, string p1, string p2, global::System.Collections.IDictionary p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setSampling", "(I)V", "GetAlarm_setSampling_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_setSampling (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='alarm_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setStatisticsInterval", "(I)V", "GetAlarm_setStatisticsInterval_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Alarm_setStatisticsInterval (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		bool Counter_checkSampled (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Counter_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Counter_commit2 (string p0, string p1, string p2, double p3, global::System.Collections.IDictionary p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setSampling", "(I)V", "GetCounter_setSampling_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Counter_setSampling (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='counter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setStatisticsInterval", "(I)V", "GetCounter_setStatisticsInterval_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Counter_setStatisticsInterval (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "GetEnableLog_ZHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void EnableLog (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Init ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		bool Offlinecounter_checkSampled (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Offlinecounter_commit (string p0, string p1, double p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setSampling", "(I)V", "GetOfflinecounter_setSampling_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Offlinecounter_setSampling (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='offlinecounter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setStatisticsInterval", "(I)V", "GetOfflinecounter_setStatisticsInterval_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Offlinecounter_setStatisticsInterval (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register ("register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Register1 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='boolean']]"
		[Register ("register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V", "GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Register2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register3' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet']]"
		[Register ("register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V", "GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Register3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='register4' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register ("register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Register4 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void SetChannel (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setRequestAuthInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void SetRequestAuthInfo (bool p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSampling", "(I)V", "GetSetSampling_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void SetSampling (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatisticsInterval1", "(I)V", "GetSetStatisticsInterval1_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void SetStatisticsInterval1 (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='setStatisticsInterval2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setStatisticsInterval2", "(II)V", "GetSetStatisticsInterval2_IIHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void SetStatisticsInterval2 (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_begin' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_begin (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		bool Stat_checkSampled (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V", "GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_commit2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, double p3, global::System.Collections.IDictionary p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_commit3' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V", "GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_commit3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3, global::System.Collections.IDictionary p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_end' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_end (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setSampling", "(I)V", "GetStat_setSampling_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_setSampling (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='stat_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setStatisticsInterval", "(I)V", "GetStat_setStatisticsInterval_IHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Stat_setStatisticsInterval (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_begin' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Transaction_begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='transaction_end' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void Transaction_end (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='triggerUpload' and count(parameter)=0]"
		[Register ("triggerUpload", "()V", "GetTriggerUploadHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void TriggerUpload ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "GetTurnOffRealTimeDebugHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void TurnOffRealTimeDebug ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "GetTurnOnRealTimeDebug_Ljava_util_Map_Handler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void TurnOnRealTimeDebug (global::System.Collections.IDictionary p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/interface[@name='IMonitor']/method[@name='updateMeasure' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V", "GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler:Com.Alibaba.Mtl.Appmonitor.IMonitorInvoker, AliPush.Binding.Android")]
		void UpdateMeasure (string p0, string p1, string p2, double p3, double p4, double p5);

	}

	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/IMonitor", DoNotGenerateAcw=true)]
	internal class IMonitorInvoker : global::Java.Lang.Object, IMonitor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/IMonitor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMonitorInvoker); }
		}

		IntPtr class_ref;

		public static IMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMonitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.mtl.appmonitor.IMonitor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Alarm_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool Alarm_checkSampled (string p0, string p1)
		{
			if (id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail1 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void Alarm_commitFail1 (string p0, string p1, string p2, string p3, global::System.Collections.IDictionary p4)
		{
			if (id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail2 (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void Alarm_commitFail2 (string p0, string p1, string p2, string p3, string p4, global::System.Collections.IDictionary p5)
		{
			if (id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess1 (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void Alarm_commitSuccess1 (string p0, string p1, global::System.Collections.IDictionary p2)
		{
			if (id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess2 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void Alarm_commitSuccess2 (string p0, string p1, string p2, global::System.Collections.IDictionary p3)
		{
			if (id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_alarm_setSampling_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setSampling_IHandler ()
		{
			if (cb_alarm_setSampling_I == null)
				cb_alarm_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setSampling_I);
			return cb_alarm_setSampling_I;
		}

		static void n_Alarm_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setSampling (p0);
		}
#pragma warning restore 0169

		IntPtr id_alarm_setSampling_I;
		public unsafe void Alarm_setSampling (int p0)
		{
			if (id_alarm_setSampling_I == IntPtr.Zero)
				id_alarm_setSampling_I = JNIEnv.GetMethodID (class_ref, "alarm_setSampling", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setSampling_I, __args);
		}

		static Delegate cb_alarm_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setStatisticsInterval_IHandler ()
		{
			if (cb_alarm_setStatisticsInterval_I == null)
				cb_alarm_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setStatisticsInterval_I);
			return cb_alarm_setStatisticsInterval_I;
		}

		static void n_Alarm_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_alarm_setStatisticsInterval_I;
		public unsafe void Alarm_setStatisticsInterval (int p0)
		{
			if (id_alarm_setStatisticsInterval_I == IntPtr.Zero)
				id_alarm_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "alarm_setStatisticsInterval", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setStatisticsInterval_I, __args);
		}

		static Delegate cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Counter_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool Counter_checkSampled (string p0, string p1)
		{
			if (id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit1 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		public unsafe void Counter_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3)
		{
			if (id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit2 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		public unsafe void Counter_commit2 (string p0, string p1, string p2, double p3, global::System.Collections.IDictionary p4)
		{
			if (id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_counter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetCounter_setSampling_IHandler ()
		{
			if (cb_counter_setSampling_I == null)
				cb_counter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setSampling_I);
			return cb_counter_setSampling_I;
		}

		static void n_Counter_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setSampling (p0);
		}
#pragma warning restore 0169

		IntPtr id_counter_setSampling_I;
		public unsafe void Counter_setSampling (int p0)
		{
			if (id_counter_setSampling_I == IntPtr.Zero)
				id_counter_setSampling_I = JNIEnv.GetMethodID (class_ref, "counter_setSampling", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setSampling_I, __args);
		}

		static Delegate cb_counter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetCounter_setStatisticsInterval_IHandler ()
		{
			if (cb_counter_setStatisticsInterval_I == null)
				cb_counter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setStatisticsInterval_I);
			return cb_counter_setStatisticsInterval_I;
		}

		static void n_Counter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_counter_setStatisticsInterval_I;
		public unsafe void Counter_setStatisticsInterval (int p0)
		{
			if (id_counter_setStatisticsInterval_I == IntPtr.Zero)
				id_counter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "counter_setStatisticsInterval", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setStatisticsInterval_I, __args);
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_enableLog_Z;
#pragma warning disable 0169
		static Delegate GetEnableLog_ZHandler ()
		{
			if (cb_enableLog_Z == null)
				cb_enableLog_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableLog_Z);
			return cb_enableLog_Z;
		}

		static void n_EnableLog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog (p0);
		}
#pragma warning restore 0169

		IntPtr id_enableLog_Z;
		public unsafe void EnableLog (bool p0)
		{
			if (id_enableLog_Z == IntPtr.Zero)
				id_enableLog_Z = JNIEnv.GetMethodID (class_ref, "enableLog", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableLog_Z, __args);
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		IntPtr id_init;
		public unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
		}

		static Delegate cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offlinecounter_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool Offlinecounter_checkSampled (string p0, string p1)
		{
			if (id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler ()
		{
			if (cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == null)
				cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D);
			return cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		}

		static void n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_commit (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		public unsafe void Offlinecounter_commit (string p0, string p1, double p2)
		{
			if (id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
				id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_offlinecounter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setSampling_IHandler ()
		{
			if (cb_offlinecounter_setSampling_I == null)
				cb_offlinecounter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setSampling_I);
			return cb_offlinecounter_setSampling_I;
		}

		static void n_Offlinecounter_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setSampling (p0);
		}
#pragma warning restore 0169

		IntPtr id_offlinecounter_setSampling_I;
		public unsafe void Offlinecounter_setSampling (int p0)
		{
			if (id_offlinecounter_setSampling_I == IntPtr.Zero)
				id_offlinecounter_setSampling_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setSampling", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setSampling_I, __args);
		}

		static Delegate cb_offlinecounter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setStatisticsInterval_IHandler ()
		{
			if (cb_offlinecounter_setStatisticsInterval_I == null)
				cb_offlinecounter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setStatisticsInterval_I);
			return cb_offlinecounter_setStatisticsInterval_I;
		}

		static void n_Offlinecounter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_offlinecounter_setStatisticsInterval_I;
		public unsafe void Offlinecounter_setStatisticsInterval (int p0)
		{
			if (id_offlinecounter_setStatisticsInterval_I == IntPtr.Zero)
				id_offlinecounter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setStatisticsInterval", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setStatisticsInterval_I, __args);
		}

		static Delegate cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
#pragma warning disable 0169
		static Delegate GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler ()
		{
			if (cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == null)
				cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_);
			return cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		}

		static void n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register1 (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		public unsafe void Register1 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2)
		{
			if (id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == IntPtr.Zero)
				id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNIEnv.GetMethodID (class_ref, "register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler ()
		{
			if (cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == null)
				cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z);
			return cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		}

		static void n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Register2 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		public unsafe void Register2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, bool p3)
		{
			if (id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == IntPtr.Zero)
				id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNIEnv.GetMethodID (class_ref, "register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
#pragma warning disable 0169
		static Delegate GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler ()
		{
			if (cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == null)
				cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_);
			return cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		}

		static void n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Register3 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		public unsafe void Register3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3)
		{
			if (id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == IntPtr.Zero)
				id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNIEnv.GetMethodID (class_ref, "register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler ()
		{
			if (cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == null)
				cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z);
			return cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		}

		static void n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Register4 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		public unsafe void Register4 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet p3, bool p4)
		{
			if (id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == IntPtr.Zero)
				id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNIEnv.GetMethodID (class_ref, "register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setChannel_Ljava_lang_String_ == null)
				cb_setChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_lang_String_);
			return cb_setChannel_Ljava_lang_String_;
		}

		static void n_SetChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_setChannel_Ljava_lang_String_;
		public unsafe void SetChannel (string p0)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannel_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestAuthInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetRequestAuthInfo (bool p0, string p1, string p2, string p3)
		{
			if (id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_setSampling_I;
#pragma warning disable 0169
		static Delegate GetSetSampling_IHandler ()
		{
			if (cb_setSampling_I == null)
				cb_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSampling_I);
			return cb_setSampling_I;
		}

		static void n_SetSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSampling (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSampling_I;
		public unsafe void SetSampling (int p0)
		{
			if (id_setSampling_I == IntPtr.Zero)
				id_setSampling_I = JNIEnv.GetMethodID (class_ref, "setSampling", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSampling_I, __args);
		}

		static Delegate cb_setStatisticsInterval1_I;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval1_IHandler ()
		{
			if (cb_setStatisticsInterval1_I == null)
				cb_setStatisticsInterval1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatisticsInterval1_I);
			return cb_setStatisticsInterval1_I;
		}

		static void n_SetStatisticsInterval1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval1 (p0);
		}
#pragma warning restore 0169

		IntPtr id_setStatisticsInterval1_I;
		public unsafe void SetStatisticsInterval1 (int p0)
		{
			if (id_setStatisticsInterval1_I == IntPtr.Zero)
				id_setStatisticsInterval1_I = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval1", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval1_I, __args);
		}

		static Delegate cb_setStatisticsInterval2_II;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval2_IIHandler ()
		{
			if (cb_setStatisticsInterval2_II == null)
				cb_setStatisticsInterval2_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetStatisticsInterval2_II);
			return cb_setStatisticsInterval2_II;
		}

		static void n_SetStatisticsInterval2_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval2 (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setStatisticsInterval2_II;
		public unsafe void SetStatisticsInterval2 (int p0, int p1)
		{
			if (id_setStatisticsInterval2_II == IntPtr.Zero)
				id_setStatisticsInterval2_II = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval2", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval2_II, __args);
		}

		static Delegate cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Stat_begin (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Stat_begin (string p0, string p1, string p2)
		{
			if (id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Stat_checkSampled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool Stat_checkSampled (string p0, string p1)
		{
			if (id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2, IntPtr native_p3)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit1 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		public unsafe void Stat_commit1 (string p0, string p1, double p2, global::System.Collections.IDictionary p3)
		{
			if (id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == null)
				cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_);
			return cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		}

		static void n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit2 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		public unsafe void Stat_commit2 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, double p3, global::System.Collections.IDictionary p4)
		{
			if (id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler ()
		{
			if (cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == null)
				cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_);
			return cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		}

		static void n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit3 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		public unsafe void Stat_commit3 (string p0, string p1, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet p2, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet p3, global::System.Collections.IDictionary p4)
		{
			if (id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == IntPtr.Zero)
				id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Stat_end (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Stat_end (string p0, string p1, string p2)
		{
			if (id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_stat_setSampling_I;
#pragma warning disable 0169
		static Delegate GetStat_setSampling_IHandler ()
		{
			if (cb_stat_setSampling_I == null)
				cb_stat_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setSampling_I);
			return cb_stat_setSampling_I;
		}

		static void n_Stat_setSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setSampling (p0);
		}
#pragma warning restore 0169

		IntPtr id_stat_setSampling_I;
		public unsafe void Stat_setSampling (int p0)
		{
			if (id_stat_setSampling_I == IntPtr.Zero)
				id_stat_setSampling_I = JNIEnv.GetMethodID (class_ref, "stat_setSampling", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setSampling_I, __args);
		}

		static Delegate cb_stat_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetStat_setStatisticsInterval_IHandler ()
		{
			if (cb_stat_setStatisticsInterval_I == null)
				cb_stat_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setStatisticsInterval_I);
			return cb_stat_setStatisticsInterval_I;
		}

		static void n_Stat_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setStatisticsInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_stat_setStatisticsInterval_I;
		public unsafe void Stat_setStatisticsInterval (int p0)
		{
			if (id_stat_setStatisticsInterval_I == IntPtr.Zero)
				id_stat_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "stat_setStatisticsInterval", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setStatisticsInterval_I, __args);
		}

		static Delegate cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_begin (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		public unsafe void Transaction_begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1)
		{
			if (id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_end (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		public unsafe void Transaction_end (global::Com.Alibaba.Mtl.Appmonitor.Transaction p0, string p1)
		{
			if (id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_triggerUpload;
#pragma warning disable 0169
		static Delegate GetTriggerUploadHandler ()
		{
			if (cb_triggerUpload == null)
				cb_triggerUpload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TriggerUpload);
			return cb_triggerUpload;
		}

		static void n_TriggerUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TriggerUpload ();
		}
#pragma warning restore 0169

		IntPtr id_triggerUpload;
		public unsafe void TriggerUpload ()
		{
			if (id_triggerUpload == IntPtr.Zero)
				id_triggerUpload = JNIEnv.GetMethodID (class_ref, "triggerUpload", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_triggerUpload);
		}

		static Delegate cb_turnOffRealTimeDebug;
#pragma warning disable 0169
		static Delegate GetTurnOffRealTimeDebugHandler ()
		{
			if (cb_turnOffRealTimeDebug == null)
				cb_turnOffRealTimeDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TurnOffRealTimeDebug);
			return cb_turnOffRealTimeDebug;
		}

		static void n_TurnOffRealTimeDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffRealTimeDebug ();
		}
#pragma warning restore 0169

		IntPtr id_turnOffRealTimeDebug;
		public unsafe void TurnOffRealTimeDebug ()
		{
			if (id_turnOffRealTimeDebug == IntPtr.Zero)
				id_turnOffRealTimeDebug = JNIEnv.GetMethodID (class_ref, "turnOffRealTimeDebug", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffRealTimeDebug);
		}

		static Delegate cb_turnOnRealTimeDebug_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTurnOnRealTimeDebug_Ljava_util_Map_Handler ()
		{
			if (cb_turnOnRealTimeDebug_Ljava_util_Map_ == null)
				cb_turnOnRealTimeDebug_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOnRealTimeDebug_Ljava_util_Map_);
			return cb_turnOnRealTimeDebug_Ljava_util_Map_;
		}

		static void n_TurnOnRealTimeDebug_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnRealTimeDebug (p0);
		}
#pragma warning restore 0169

		IntPtr id_turnOnRealTimeDebug_Ljava_util_Map_;
		public unsafe void TurnOnRealTimeDebug (global::System.Collections.IDictionary p0)
		{
			if (id_turnOnRealTimeDebug_Ljava_util_Map_ == IntPtr.Zero)
				id_turnOnRealTimeDebug_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "turnOnRealTimeDebug", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnRealTimeDebug_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
#pragma warning disable 0169
		static Delegate GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler ()
		{
			if (cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == null)
				cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, double>) n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD);
			return cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		}

		static void n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, double p4, double p5)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMeasure (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		public unsafe void UpdateMeasure (string p0, string p1, string p2, double p3, double p4, double p5)
		{
			if (id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == IntPtr.Zero)
				id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNIEnv.GetMethodID (class_ref, "updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Mtl.Appmonitor.IMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.IMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}

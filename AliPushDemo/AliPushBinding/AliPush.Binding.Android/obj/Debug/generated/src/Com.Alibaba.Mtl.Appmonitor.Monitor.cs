using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Mtl.Appmonitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']"
	[global::Android.Runtime.Register ("com/alibaba/mtl/appmonitor/Monitor", DoNotGenerateAcw=true)]
	public partial class Monitor : global::Com.Alibaba.Mtl.Appmonitor.MonitorStub {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/mtl/appmonitor/Monitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Monitor); }
		}

		protected Monitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Alarm_checkSampled (module, monitorPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAlarm_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Alarm_checkSampled (string module, string monitorPoint)
		{
			if (id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_alarm_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_errorCode, IntPtr native_errorMsg, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			string errorMsg = JNIEnv.GetString (native_errorMsg, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail1 (module, monitorPoint, errorCode, errorMsg, exta);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_commitFail1' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitFail1 (string module, string monitorPoint, string errorCode, string errorMsg, global::System.Collections.IDictionary exta)
		{
			if (id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_errorCode);
				__args [3] = new JValue (native_errorMsg);
				__args [4] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail1_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_commitFail1", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMsg);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg, IntPtr native_errorCode, IntPtr native_errorMsg, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			string errorCode = JNIEnv.GetString (native_errorCode, JniHandleOwnership.DoNotTransfer);
			string errorMsg = JNIEnv.GetString (native_errorMsg, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitFail2 (module, monitorPoint, arg, errorCode, errorMsg, exta);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_commitFail2' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.Map']]"
		[Register ("alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitFail2 (string module, string monitorPoint, string arg, string errorCode, string errorMsg, global::System.Collections.IDictionary exta)
		{
			if (id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			IntPtr native_errorMsg = JNIEnv.NewString (errorMsg);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);
				__args [3] = new JValue (native_errorCode);
				__args [4] = new JValue (native_errorMsg);
				__args [5] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitFail2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_commitFail2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
				JNIEnv.DeleteLocalRef (native_errorCode);
				JNIEnv.DeleteLocalRef (native_errorMsg);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess1 (module, monitorPoint, exta);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_commitSuccess1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitSuccess1 (string module, string monitorPoint, global::System.Collections.IDictionary exta)
		{
			if (id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess1_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_commitSuccess1", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_commitSuccess2 (module, monitorPoint, arg, exta);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_commitSuccess2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map']]"
		[Register ("alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetAlarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void Alarm_commitSuccess2 (string module, string monitorPoint, string arg, global::System.Collections.IDictionary exta)
		{
			if (id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);
				__args [3] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_commitSuccess2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_commitSuccess2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_alarm_setSampling_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setSampling_IHandler ()
		{
			if (cb_alarm_setSampling_I == null)
				cb_alarm_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setSampling_I);
			return cb_alarm_setSampling_I;
		}

		static void n_Alarm_setSampling_I (IntPtr jnienv, IntPtr native__this, int sampling)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setSampling (sampling);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setSampling", "(I)V", "GetAlarm_setSampling_IHandler")]
		public override unsafe void Alarm_setSampling (int sampling)
		{
			if (id_alarm_setSampling_I == IntPtr.Zero)
				id_alarm_setSampling_I = JNIEnv.GetMethodID (class_ref, "alarm_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setSampling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_setSampling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_alarm_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetAlarm_setStatisticsInterval_IHandler ()
		{
			if (cb_alarm_setStatisticsInterval_I == null)
				cb_alarm_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alarm_setStatisticsInterval_I);
			return cb_alarm_setStatisticsInterval_I;
		}

		static void n_Alarm_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alarm_setStatisticsInterval (statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_alarm_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='alarm_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alarm_setStatisticsInterval", "(I)V", "GetAlarm_setStatisticsInterval_IHandler")]
		public override unsafe void Alarm_setStatisticsInterval (int statisticsInterval)
		{
			if (id_alarm_setStatisticsInterval_I == IntPtr.Zero)
				id_alarm_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "alarm_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alarm_setStatisticsInterval_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alarm_setStatisticsInterval", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Counter_checkSampled (module, monitorPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='counter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetCounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Counter_checkSampled (string module, string monitorPoint)
		{
			if (id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_counter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, double value, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit1 (module, monitorPoint, value, exta);
		}
#pragma warning restore 0169

		static IntPtr id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='counter_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Counter_commit1 (string module, string monitorPoint, double value, global::System.Collections.IDictionary exta)
		{
			if (id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counter_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_arg, double value, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string arg = JNIEnv.GetString (native_arg, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Counter_commit2 (module, monitorPoint, arg, value, exta);
		}
#pragma warning restore 0169

		static IntPtr id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='counter_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetCounter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Counter_commit2 (string module, string monitorPoint, string arg, double value, global::System.Collections.IDictionary exta)
		{
			if (id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_arg = JNIEnv.NewString (arg);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_arg);
				__args [3] = new JValue (value);
				__args [4] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_commit2_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counter_commit2", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_arg);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_counter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetCounter_setSampling_IHandler ()
		{
			if (cb_counter_setSampling_I == null)
				cb_counter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setSampling_I);
			return cb_counter_setSampling_I;
		}

		static void n_Counter_setSampling_I (IntPtr jnienv, IntPtr native__this, int sampling)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setSampling (sampling);
		}
#pragma warning restore 0169

		static IntPtr id_counter_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='counter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setSampling", "(I)V", "GetCounter_setSampling_IHandler")]
		public override unsafe void Counter_setSampling (int sampling)
		{
			if (id_counter_setSampling_I == IntPtr.Zero)
				id_counter_setSampling_I = JNIEnv.GetMethodID (class_ref, "counter_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setSampling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counter_setSampling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_counter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetCounter_setStatisticsInterval_IHandler ()
		{
			if (cb_counter_setStatisticsInterval_I == null)
				cb_counter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Counter_setStatisticsInterval_I);
			return cb_counter_setStatisticsInterval_I;
		}

		static void n_Counter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Counter_setStatisticsInterval (statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_counter_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='counter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("counter_setStatisticsInterval", "(I)V", "GetCounter_setStatisticsInterval_IHandler")]
		public override unsafe void Counter_setStatisticsInterval (int statisticsInterval)
		{
			if (id_counter_setStatisticsInterval_I == IntPtr.Zero)
				id_counter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "counter_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_counter_setStatisticsInterval_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counter_setStatisticsInterval", "(I)V"), __args);
			} finally {
			}
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
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableLog_Z;
#pragma warning disable 0169
		static Delegate GetEnableLog_ZHandler ()
		{
			if (cb_enableLog_Z == null)
				cb_enableLog_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableLog_Z);
			return cb_enableLog_Z;
		}

		static void n_EnableLog_Z (IntPtr jnienv, IntPtr native__this, bool open)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog (open);
		}
#pragma warning restore 0169

		static IntPtr id_enableLog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "GetEnableLog_ZHandler")]
		public override unsafe void EnableLog (bool open)
		{
			if (id_enableLog_Z == IntPtr.Zero)
				id_enableLog_Z = JNIEnv.GetMethodID (class_ref, "enableLog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (open);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableLog_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableLog", "(Z)V"), __args);
			} finally {
			}
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
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public override unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offlinecounter_checkSampled (module, monitorPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='offlinecounter_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOfflinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Offlinecounter_checkSampled (string module, string monitorPoint)
		{
			if (id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offlinecounter_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler ()
		{
			if (cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == null)
				cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D);
			return cb_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		}

		static void n_Offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, double value)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_commit (module, monitorPoint, value);
		}
#pragma warning restore 0169

		static IntPtr id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='offlinecounter_commit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V", "GetOfflinecounter_commit_Ljava_lang_String_Ljava_lang_String_DHandler")]
		public override unsafe void Offlinecounter_commit (string module, string monitorPoint, double value)
		{
			if (id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D == IntPtr.Zero)
				id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_commit_Ljava_lang_String_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offlinecounter_commit", "(Ljava/lang/String;Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_offlinecounter_setSampling_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setSampling_IHandler ()
		{
			if (cb_offlinecounter_setSampling_I == null)
				cb_offlinecounter_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setSampling_I);
			return cb_offlinecounter_setSampling_I;
		}

		static void n_Offlinecounter_setSampling_I (IntPtr jnienv, IntPtr native__this, int sampling)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setSampling (sampling);
		}
#pragma warning restore 0169

		static IntPtr id_offlinecounter_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='offlinecounter_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setSampling", "(I)V", "GetOfflinecounter_setSampling_IHandler")]
		public override unsafe void Offlinecounter_setSampling (int sampling)
		{
			if (id_offlinecounter_setSampling_I == IntPtr.Zero)
				id_offlinecounter_setSampling_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setSampling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offlinecounter_setSampling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_offlinecounter_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetOfflinecounter_setStatisticsInterval_IHandler ()
		{
			if (cb_offlinecounter_setStatisticsInterval_I == null)
				cb_offlinecounter_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Offlinecounter_setStatisticsInterval_I);
			return cb_offlinecounter_setStatisticsInterval_I;
		}

		static void n_Offlinecounter_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offlinecounter_setStatisticsInterval (statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_offlinecounter_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='offlinecounter_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offlinecounter_setStatisticsInterval", "(I)V", "GetOfflinecounter_setStatisticsInterval_IHandler")]
		public override unsafe void Offlinecounter_setStatisticsInterval (int statisticsInterval)
		{
			if (id_offlinecounter_setStatisticsInterval_I == IntPtr.Zero)
				id_offlinecounter_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "offlinecounter_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offlinecounter_setStatisticsInterval_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offlinecounter_setStatisticsInterval", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
#pragma warning disable 0169
		static Delegate GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler ()
		{
			if (cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == null)
				cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_);
			return cb_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		}

		static void n_Register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measures)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_measures, JniHandleOwnership.DoNotTransfer);
			__this.Register1 (module, monitorPoint, measures);
		}
#pragma warning restore 0169

		static IntPtr id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='register1' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet']]"
		[Register ("register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V", "GetRegister1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Handler")]
		public override unsafe void Register1 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures)
		{
			if (id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ == IntPtr.Zero)
				id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ = JNIEnv.GetMethodID (class_ref, "register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register1_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register1", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler ()
		{
			if (cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == null)
				cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z);
			return cb_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		}

		static void n_Register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measures, bool isCommitDetail)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_measures, JniHandleOwnership.DoNotTransfer);
			__this.Register2 (module, monitorPoint, measures, isCommitDetail);
		}
#pragma warning restore 0169

		static IntPtr id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='register2' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='boolean']]"
		[Register ("register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V", "GetRegister2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_ZHandler")]
		public override unsafe void Register2 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, bool isCommitDetail)
		{
			if (id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z == IntPtr.Zero)
				id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z = JNIEnv.GetMethodID (class_ref, "register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (isCommitDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
#pragma warning disable 0169
		static Delegate GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler ()
		{
			if (cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == null)
				cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_);
			return cb_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		}

		static void n_Register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measures, IntPtr native_dimensions)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_measures, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_dimensions, JniHandleOwnership.DoNotTransfer);
			__this.Register3 (module, monitorPoint, measures, dimensions);
		}
#pragma warning restore 0169

		static IntPtr id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='register3' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet']]"
		[Register ("register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V", "GetRegister3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Handler")]
		public override unsafe void Register3 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions)
		{
			if (id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ == IntPtr.Zero)
				id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ = JNIEnv.GetMethodID (class_ref, "register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (dimensions);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
#pragma warning disable 0169
		static Delegate GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler ()
		{
			if (cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == null)
				cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z);
			return cb_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		}

		static void n_Register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measures, IntPtr native_dimensions, bool isCommitDetail)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet> (native_measures, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet> (native_dimensions, JniHandleOwnership.DoNotTransfer);
			__this.Register4 (module, monitorPoint, measures, dimensions, isCommitDetail);
		}
#pragma warning restore 0169

		static IntPtr id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='register4' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.MeasureSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.DimensionSet'] and parameter[5][@type='boolean']]"
		[Register ("register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V", "GetRegister4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_ZHandler")]
		public override unsafe void Register4 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureSet measures, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionSet dimensions, bool isCommitDetail)
		{
			if (id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z == IntPtr.Zero)
				id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z = JNIEnv.GetMethodID (class_ref, "register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (measures);
				__args [3] = new JValue (dimensions);
				__args [4] = new JValue (isCommitDetail);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register4_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_MeasureSet_Lcom_alibaba_mtl_appmonitor_model_DimensionSet_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register4", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/MeasureSet;Lcom/alibaba/mtl/appmonitor/model/DimensionSet;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_setChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setChannel_Ljava_lang_String_ == null)
				cb_setChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_lang_String_);
			return cb_setChannel_Ljava_lang_String_;
		}

		static void n_SetChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string channel = JNIEnv.GetString (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (channel);
		}
#pragma warning restore 0169

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler")]
		public override unsafe void SetChannel (string channel)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_channel = JNIEnv.NewString (channel);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_channel);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannel_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannel", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channel);
			}
		}

		static Delegate cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool isSecurity, IntPtr native_appkey, IntPtr native_secret, IntPtr native_authcode)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string appkey = JNIEnv.GetString (native_appkey, JniHandleOwnership.DoNotTransfer);
			string secret = JNIEnv.GetString (native_secret, JniHandleOwnership.DoNotTransfer);
			string authcode = JNIEnv.GetString (native_authcode, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestAuthInfo (isSecurity, appkey, secret, authcode);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='setRequestAuthInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void SetRequestAuthInfo (bool isSecurity, string appkey, string secret, string authcode)
		{
			if (id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_appkey = JNIEnv.NewString (appkey);
			IntPtr native_secret = JNIEnv.NewString (secret);
			IntPtr native_authcode = JNIEnv.NewString (authcode);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (isSecurity);
				__args [1] = new JValue (native_appkey);
				__args [2] = new JValue (native_secret);
				__args [3] = new JValue (native_authcode);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestAuthInfo_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestAuthInfo", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appkey);
				JNIEnv.DeleteLocalRef (native_secret);
				JNIEnv.DeleteLocalRef (native_authcode);
			}
		}

		static Delegate cb_setSampling_I;
#pragma warning disable 0169
		static Delegate GetSetSampling_IHandler ()
		{
			if (cb_setSampling_I == null)
				cb_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSampling_I);
			return cb_setSampling_I;
		}

		static void n_SetSampling_I (IntPtr jnienv, IntPtr native__this, int sampling)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSampling (sampling);
		}
#pragma warning restore 0169

		static IntPtr id_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSampling", "(I)V", "GetSetSampling_IHandler")]
		public override unsafe void SetSampling (int sampling)
		{
			if (id_setSampling_I == IntPtr.Zero)
				id_setSampling_I = JNIEnv.GetMethodID (class_ref, "setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSampling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSampling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatisticsInterval1_I;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval1_IHandler ()
		{
			if (cb_setStatisticsInterval1_I == null)
				cb_setStatisticsInterval1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatisticsInterval1_I);
			return cb_setStatisticsInterval1_I;
		}

		static void n_SetStatisticsInterval1_I (IntPtr jnienv, IntPtr native__this, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval1 (statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_setStatisticsInterval1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='setStatisticsInterval1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatisticsInterval1", "(I)V", "GetSetStatisticsInterval1_IHandler")]
		public override unsafe void SetStatisticsInterval1 (int statisticsInterval)
		{
			if (id_setStatisticsInterval1_I == IntPtr.Zero)
				id_setStatisticsInterval1_I = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval1", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval1_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatisticsInterval1", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatisticsInterval2_II;
#pragma warning disable 0169
		static Delegate GetSetStatisticsInterval2_IIHandler ()
		{
			if (cb_setStatisticsInterval2_II == null)
				cb_setStatisticsInterval2_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetStatisticsInterval2_II);
			return cb_setStatisticsInterval2_II;
		}

		static void n_SetStatisticsInterval2_II (IntPtr jnienv, IntPtr native__this, int e, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatisticsInterval2 (e, statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_setStatisticsInterval2_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='setStatisticsInterval2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setStatisticsInterval2", "(II)V", "GetSetStatisticsInterval2_IIHandler")]
		public override unsafe void SetStatisticsInterval2 (int e, int statisticsInterval)
		{
			if (id_setStatisticsInterval2_II == IntPtr.Zero)
				id_setStatisticsInterval2_II = JNIEnv.GetMethodID (class_ref, "setStatisticsInterval2", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatisticsInterval2_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatisticsInterval2", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.Stat_begin (module, monitorPoint, measureName);
		}
#pragma warning restore 0169

		static IntPtr id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_begin' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void Stat_begin (string module, string monitorPoint, string measureName)
		{
			if (id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_begin_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_begin", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_measureName);
			}
		}

		static Delegate cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Stat_checkSampled (module, monitorPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_checkSampled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetStat_checkSampled_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Stat_checkSampled (string module, string monitorPoint)
		{
			if (id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stat_checkSampled_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_checkSampled", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
			}
		}

		static Delegate cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == null)
				cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_);
			return cb_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		}

		static void n_Stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, double value, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit1 (module, monitorPoint, value, exta);
		}
#pragma warning restore 0169

		static IntPtr id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_commit1' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.util.Map']]"
		[Register ("stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V", "GetStat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_Handler")]
		public override unsafe void Stat_commit1 (string module, string monitorPoint, double value, global::System.Collections.IDictionary exta)
		{
			if (id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (value);
				__args [3] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit1_Ljava_lang_String_Ljava_lang_String_DLjava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_commit1", "(Ljava/lang/String;Ljava/lang/String;DLjava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler ()
		{
			if (cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == null)
				cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_);
			return cb_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		}

		static void n_Stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_dimensionValues, double value, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit2 (module, monitorPoint, dimensionValues, value, exta);
		}
#pragma warning restore 0169

		static IntPtr id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_commit2' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='double'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V", "GetStat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_Handler")]
		public override unsafe void Stat_commit2 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, double value, global::System.Collections.IDictionary exta)
		{
			if (id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ == IntPtr.Zero)
				id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (dimensionValues);
				__args [3] = new JValue (value);
				__args [4] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit2_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_DLjava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_commit2", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;DLjava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler ()
		{
			if (cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == null)
				cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_);
			return cb_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		}

		static void n_Stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_dimensionValues, IntPtr native_measureValues, IntPtr native_exta)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet> (native_dimensionValues, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet> (native_measureValues, JniHandleOwnership.DoNotTransfer);
			var exta = global::Android.Runtime.JavaDictionary.FromJniHandle (native_exta, JniHandleOwnership.DoNotTransfer);
			__this.Stat_commit3 (module, monitorPoint, dimensionValues, measureValues, exta);
		}
#pragma warning restore 0169

		static IntPtr id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_commit3' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.alibaba.mtl.appmonitor.model.DimensionValueSet'] and parameter[4][@type='com.alibaba.mtl.appmonitor.model.MeasureValueSet'] and parameter[5][@type='java.util.Map']]"
		[Register ("stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V", "GetStat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_Handler")]
		public override unsafe void Stat_commit3 (string module, string monitorPoint, global::Com.Alibaba.Mtl.Appmonitor.Model.DimensionValueSet dimensionValues, global::Com.Alibaba.Mtl.Appmonitor.Model.MeasureValueSet measureValues, global::System.Collections.IDictionary exta)
		{
			if (id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ == IntPtr.Zero)
				id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_exta = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (exta);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (dimensionValues);
				__args [3] = new JValue (measureValues);
				__args [4] = new JValue (native_exta);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_commit3_Ljava_lang_String_Ljava_lang_String_Lcom_alibaba_mtl_appmonitor_model_DimensionValueSet_Lcom_alibaba_mtl_appmonitor_model_MeasureValueSet_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_commit3", "(Ljava/lang/String;Ljava/lang/String;Lcom/alibaba/mtl/appmonitor/model/DimensionValueSet;Lcom/alibaba/mtl/appmonitor/model/MeasureValueSet;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_exta);
			}
		}

		static Delegate cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.Stat_end (module, monitorPoint, measureName);
		}
#pragma warning restore 0169

		static IntPtr id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_end' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void Stat_end (string module, string monitorPoint, string measureName)
		{
			if (id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_module = JNIEnv.NewString (module);
			IntPtr native_monitorPoint = JNIEnv.NewString (monitorPoint);
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_module);
				__args [1] = new JValue (native_monitorPoint);
				__args [2] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_end_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_end", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_measureName);
			}
		}

		static Delegate cb_stat_setSampling_I;
#pragma warning disable 0169
		static Delegate GetStat_setSampling_IHandler ()
		{
			if (cb_stat_setSampling_I == null)
				cb_stat_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setSampling_I);
			return cb_stat_setSampling_I;
		}

		static void n_Stat_setSampling_I (IntPtr jnienv, IntPtr native__this, int sampling)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setSampling (sampling);
		}
#pragma warning restore 0169

		static IntPtr id_stat_setSampling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setSampling", "(I)V", "GetStat_setSampling_IHandler")]
		public override unsafe void Stat_setSampling (int sampling)
		{
			if (id_stat_setSampling_I == IntPtr.Zero)
				id_stat_setSampling_I = JNIEnv.GetMethodID (class_ref, "stat_setSampling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sampling);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setSampling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_setSampling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stat_setStatisticsInterval_I;
#pragma warning disable 0169
		static Delegate GetStat_setStatisticsInterval_IHandler ()
		{
			if (cb_stat_setStatisticsInterval_I == null)
				cb_stat_setStatisticsInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stat_setStatisticsInterval_I);
			return cb_stat_setStatisticsInterval_I;
		}

		static void n_Stat_setStatisticsInterval_I (IntPtr jnienv, IntPtr native__this, int statisticsInterval)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_setStatisticsInterval (statisticsInterval);
		}
#pragma warning restore 0169

		static IntPtr id_stat_setStatisticsInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='stat_setStatisticsInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stat_setStatisticsInterval", "(I)V", "GetStat_setStatisticsInterval_IHandler")]
		public override unsafe void Stat_setStatisticsInterval (int statisticsInterval)
		{
			if (id_stat_setStatisticsInterval_I == IntPtr.Zero)
				id_stat_setStatisticsInterval_I = JNIEnv.GetMethodID (class_ref, "stat_setStatisticsInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statisticsInterval);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stat_setStatisticsInterval_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat_setStatisticsInterval", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transaction, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_transaction, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_begin (transaction, measureName);
		}
#pragma warning restore 0169

		static IntPtr id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='transaction_begin' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public override unsafe void Transaction_begin (global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction, string measureName)
		{
			if (id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (transaction);
				__args [1] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_begin_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transaction_begin", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
			}
		}

		static Delegate cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler ()
		{
			if (cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == null)
				cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_);
			return cb_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		}

		static void n_Transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transaction, IntPtr native_measureName)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Transaction> (native_transaction, JniHandleOwnership.DoNotTransfer);
			string measureName = JNIEnv.GetString (native_measureName, JniHandleOwnership.DoNotTransfer);
			__this.Transaction_end (transaction, measureName);
		}
#pragma warning restore 0169

		static IntPtr id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='transaction_end' and count(parameter)=2 and parameter[1][@type='com.alibaba.mtl.appmonitor.Transaction'] and parameter[2][@type='java.lang.String']]"
		[Register ("transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V", "GetTransaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_Handler")]
		public override unsafe void Transaction_end (global::Com.Alibaba.Mtl.Appmonitor.Transaction transaction, string measureName)
		{
			if (id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ == IntPtr.Zero)
				id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V");
			IntPtr native_measureName = JNIEnv.NewString (measureName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (transaction);
				__args [1] = new JValue (native_measureName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transaction_end_Lcom_alibaba_mtl_appmonitor_Transaction_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transaction_end", "(Lcom/alibaba/mtl/appmonitor/Transaction;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_measureName);
			}
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
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TriggerUpload ();
		}
#pragma warning restore 0169

		static IntPtr id_triggerUpload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='triggerUpload' and count(parameter)=0]"
		[Register ("triggerUpload", "()V", "GetTriggerUploadHandler")]
		public override unsafe void TriggerUpload ()
		{
			if (id_triggerUpload == IntPtr.Zero)
				id_triggerUpload = JNIEnv.GetMethodID (class_ref, "triggerUpload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_triggerUpload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "triggerUpload", "()V"));
			} finally {
			}
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
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TurnOffRealTimeDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_turnOffRealTimeDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='turnOffRealTimeDebug' and count(parameter)=0]"
		[Register ("turnOffRealTimeDebug", "()V", "GetTurnOffRealTimeDebugHandler")]
		public override unsafe void TurnOffRealTimeDebug ()
		{
			if (id_turnOffRealTimeDebug == IntPtr.Zero)
				id_turnOffRealTimeDebug = JNIEnv.GetMethodID (class_ref, "turnOffRealTimeDebug", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOffRealTimeDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOffRealTimeDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_turnOnRealTimeDebug_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTurnOnRealTimeDebug_Ljava_util_Map_Handler ()
		{
			if (cb_turnOnRealTimeDebug_Ljava_util_Map_ == null)
				cb_turnOnRealTimeDebug_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TurnOnRealTimeDebug_Ljava_util_Map_);
			return cb_turnOnRealTimeDebug_Ljava_util_Map_;
		}

		static void n_TurnOnRealTimeDebug_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @params = global::Android.Runtime.JavaDictionary.FromJniHandle (native__params, JniHandleOwnership.DoNotTransfer);
			__this.TurnOnRealTimeDebug (@params);
		}
#pragma warning restore 0169

		static IntPtr id_turnOnRealTimeDebug_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='turnOnRealTimeDebug' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("turnOnRealTimeDebug", "(Ljava/util/Map;)V", "GetTurnOnRealTimeDebug_Ljava_util_Map_Handler")]
		public override unsafe void TurnOnRealTimeDebug (global::System.Collections.IDictionary @params)
		{
			if (id_turnOnRealTimeDebug_Ljava_util_Map_ == IntPtr.Zero)
				id_turnOnRealTimeDebug_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "turnOnRealTimeDebug", "(Ljava/util/Map;)V");
			IntPtr native__params = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_turnOnRealTimeDebug_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "turnOnRealTimeDebug", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		static Delegate cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
#pragma warning disable 0169
		static Delegate GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler ()
		{
			if (cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == null)
				cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, double>) n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD);
			return cb_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		}

		static void n_UpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD (IntPtr jnienv, IntPtr native__this, IntPtr native_module, IntPtr native_monitorPoint, IntPtr native_name, double min, double max, double defaultValue)
		{
			global::Com.Alibaba.Mtl.Appmonitor.Monitor __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Mtl.Appmonitor.Monitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string module = JNIEnv.GetString (native_module, JniHandleOwnership.DoNotTransfer);
			string monitorPoint = JNIEnv.GetString (native_monitorPoint, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMeasure (module, monitorPoint, name, min, max, defaultValue);
		}
#pragma warning restore 0169

		static IntPtr id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.mtl.appmonitor']/class[@name='Monitor']/method[@name='updateMeasure' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V", "GetUpdateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDDHandler")]
		public override unsafe void UpdateMeasure (string module, string monitorPoint, string name, double min, double max, double defaultValue)
		{
			if (id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD == IntPtr.Zero)
				id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD = JNIEnv.GetMethodID (class_ref, "updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V");
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMeasure_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_DDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMeasure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;DDD)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_module);
				JNIEnv.DeleteLocalRef (native_monitorPoint);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.channel']/class[@name='KeepChannelService']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/channel/KeepChannelService", DoNotGenerateAcw=true)]
	public partial class KeepChannelService : global::Android.App.Job.JobService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/channel/KeepChannelService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeepChannelService); }
		}

		protected KeepChannelService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.channel']/class[@name='KeepChannelService']/constructor[@name='KeepChannelService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KeepChannelService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KeepChannelService)) {
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

		static Delegate cb_onStartJob_Landroid_app_job_JobParameters_;
#pragma warning disable 0169
		static Delegate GetOnStartJob_Landroid_app_job_JobParameters_Handler ()
		{
			if (cb_onStartJob_Landroid_app_job_JobParameters_ == null)
				cb_onStartJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnStartJob_Landroid_app_job_JobParameters_);
			return cb_onStartJob_Landroid_app_job_JobParameters_;
		}

		static bool n_OnStartJob_Landroid_app_job_JobParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Channel.KeepChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Channel.KeepChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Job.JobParameters p0 = global::Java.Lang.Object.GetObject<global::Android.App.Job.JobParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStartJob (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onStartJob_Landroid_app_job_JobParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.channel']/class[@name='KeepChannelService']/method[@name='onStartJob' and count(parameter)=1 and parameter[1][@type='android.app.job.JobParameters']]"
		[Register ("onStartJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStartJob_Landroid_app_job_JobParameters_Handler")]
		public override unsafe bool OnStartJob (global::Android.App.Job.JobParameters p0)
		{
			if (id_onStartJob_Landroid_app_job_JobParameters_ == IntPtr.Zero)
				id_onStartJob_Landroid_app_job_JobParameters_ = JNIEnv.GetMethodID (class_ref, "onStartJob", "(Landroid/app/job/JobParameters;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onStartJob_Landroid_app_job_JobParameters_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartJob", "(Landroid/app/job/JobParameters;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onStopJob_Landroid_app_job_JobParameters_;
#pragma warning disable 0169
		static Delegate GetOnStopJob_Landroid_app_job_JobParameters_Handler ()
		{
			if (cb_onStopJob_Landroid_app_job_JobParameters_ == null)
				cb_onStopJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnStopJob_Landroid_app_job_JobParameters_);
			return cb_onStopJob_Landroid_app_job_JobParameters_;
		}

		static bool n_OnStopJob_Landroid_app_job_JobParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Channel.KeepChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Channel.KeepChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Job.JobParameters p0 = global::Java.Lang.Object.GetObject<global::Android.App.Job.JobParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStopJob (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onStopJob_Landroid_app_job_JobParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.channel']/class[@name='KeepChannelService']/method[@name='onStopJob' and count(parameter)=1 and parameter[1][@type='android.app.job.JobParameters']]"
		[Register ("onStopJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStopJob_Landroid_app_job_JobParameters_Handler")]
		public override unsafe bool OnStopJob (global::Android.App.Job.JobParameters p0)
		{
			if (id_onStopJob_Landroid_app_job_JobParameters_ == IntPtr.Zero)
				id_onStopJob_Landroid_app_job_JobParameters_ = JNIEnv.GetMethodID (class_ref, "onStopJob", "(Landroid/app/job/JobParameters;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onStopJob_Landroid_app_job_JobParameters_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStopJob", "(Landroid/app/job/JobParameters;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}

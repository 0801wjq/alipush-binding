using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/notification/BasicCustomPushNotification", DoNotGenerateAcw=true)]
	public partial class BasicCustomPushNotification : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='CUSTOM_NOTIFICATION_TAG']"
		[Register ("CUSTOM_NOTIFICATION_TAG")]
		public const string CustomNotificationTag = (string) "custom_notification_";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='NOTIFICATION_TYPE_CUSTOM_ADVANCED']"
		[Register ("NOTIFICATION_TYPE_CUSTOM_ADVANCED")]
		public const int NotificationTypeCustomAdvanced = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='NOTIFICATION_TYPE_CUSTOM_BASIC']"
		[Register ("NOTIFICATION_TYPE_CUSTOM_BASIC")]
		public const int NotificationTypeCustomBasic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='NOTIFICATION_TYPE_DEFAULT']"
		[Register ("NOTIFICATION_TYPE_DEFAULT")]
		public const int NotificationTypeDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='REMIND_TYPE_SILENT']"
		[Register ("REMIND_TYPE_SILENT")]
		public const int RemindTypeSilent = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='REMIND_TYPE_SOUND']"
		[Register ("REMIND_TYPE_SOUND")]
		public const int RemindTypeSound = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='REMIND_TYPE_VIBRATE']"
		[Register ("REMIND_TYPE_VIBRATE")]
		public const int RemindTypeVibrate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/field[@name='REMIND_TYPE_VIBRATE_AND_SOUND']"
		[Register ("REMIND_TYPE_VIBRATE_AND_SOUND")]
		public const int RemindTypeVibrateAndSound = (int) 3;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/notification/BasicCustomPushNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicCustomPushNotification); }
		}

		protected BasicCustomPushNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/constructor[@name='BasicCustomPushNotification' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicCustomPushNotification ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BasicCustomPushNotification)) {
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

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/constructor[@name='BasicCustomPushNotification' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe BasicCustomPushNotification (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (BasicCustomPushNotification)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static Delegate cb_isBuildWhenAppInForeground;
#pragma warning disable 0169
		static Delegate GetIsBuildWhenAppInForegroundHandler ()
		{
			if (cb_isBuildWhenAppInForeground == null)
				cb_isBuildWhenAppInForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBuildWhenAppInForeground);
			return cb_isBuildWhenAppInForeground;
		}

		static bool n_IsBuildWhenAppInForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuildWhenAppInForeground;
		}
#pragma warning restore 0169

		static Delegate cb_setBuildWhenAppInForeground_Z;
#pragma warning disable 0169
		static Delegate GetSetBuildWhenAppInForeground_ZHandler ()
		{
			if (cb_setBuildWhenAppInForeground_Z == null)
				cb_setBuildWhenAppInForeground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBuildWhenAppInForeground_Z);
			return cb_setBuildWhenAppInForeground_Z;
		}

		static void n_SetBuildWhenAppInForeground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuildWhenAppInForeground = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBuildWhenAppInForeground;
		static IntPtr id_setBuildWhenAppInForeground_Z;
		public virtual unsafe bool BuildWhenAppInForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='isBuildWhenAppInForeground' and count(parameter)=0]"
			[Register ("isBuildWhenAppInForeground", "()Z", "GetIsBuildWhenAppInForegroundHandler")]
			get {
				if (id_isBuildWhenAppInForeground == IntPtr.Zero)
					id_isBuildWhenAppInForeground = JNIEnv.GetMethodID (class_ref, "isBuildWhenAppInForeground", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBuildWhenAppInForeground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBuildWhenAppInForeground", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='setBuildWhenAppInForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBuildWhenAppInForeground", "(Z)V", "GetSetBuildWhenAppInForeground_ZHandler")]
			set {
				if (id_setBuildWhenAppInForeground_Z == IntPtr.Zero)
					id_setBuildWhenAppInForeground_Z = JNIEnv.GetMethodID (class_ref, "setBuildWhenAppInForeground", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBuildWhenAppInForeground_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBuildWhenAppInForeground", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationFlags;
#pragma warning disable 0169
		static Delegate GetGetNotificationFlagsHandler ()
		{
			if (cb_getNotificationFlags == null)
				cb_getNotificationFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationFlags);
			return cb_getNotificationFlags;
		}

		static int n_GetNotificationFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationFlags;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationFlags_I;
#pragma warning disable 0169
		static Delegate GetSetNotificationFlags_IHandler ()
		{
			if (cb_setNotificationFlags_I == null)
				cb_setNotificationFlags_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotificationFlags_I);
			return cb_setNotificationFlags_I;
		}

		static void n_SetNotificationFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationFlags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationFlags;
		static IntPtr id_setNotificationFlags_I;
		public virtual unsafe int NotificationFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='getNotificationFlags' and count(parameter)=0]"
			[Register ("getNotificationFlags", "()I", "GetGetNotificationFlagsHandler")]
			get {
				if (id_getNotificationFlags == IntPtr.Zero)
					id_getNotificationFlags = JNIEnv.GetMethodID (class_ref, "getNotificationFlags", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationFlags);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationFlags", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='setNotificationFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotificationFlags", "(I)V", "GetSetNotificationFlags_IHandler")]
			set {
				if (id_setNotificationFlags_I == IntPtr.Zero)
					id_setNotificationFlags_I = JNIEnv.GetMethodID (class_ref, "setNotificationFlags", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationFlags_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationFlags", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationType;
#pragma warning disable 0169
		static Delegate GetGetNotificationTypeHandler ()
		{
			if (cb_getNotificationType == null)
				cb_getNotificationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationType);
			return cb_getNotificationType;
		}

		static int n_GetNotificationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationType;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationType;
		public virtual unsafe int NotificationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='getNotificationType' and count(parameter)=0]"
			[Register ("getNotificationType", "()I", "GetGetNotificationTypeHandler")]
			get {
				if (id_getNotificationType == IntPtr.Zero)
					id_getNotificationType = JNIEnv.GetMethodID (class_ref, "getNotificationType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRemindType;
#pragma warning disable 0169
		static Delegate GetGetRemindTypeHandler ()
		{
			if (cb_getRemindType == null)
				cb_getRemindType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRemindType);
			return cb_getRemindType;
		}

		static int n_GetRemindType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemindType;
		}
#pragma warning restore 0169

		static Delegate cb_setRemindType_I;
#pragma warning disable 0169
		static Delegate GetSetRemindType_IHandler ()
		{
			if (cb_setRemindType_I == null)
				cb_setRemindType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRemindType_I);
			return cb_setRemindType_I;
		}

		static void n_SetRemindType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemindType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemindType;
		static IntPtr id_setRemindType_I;
		public virtual unsafe int RemindType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='getRemindType' and count(parameter)=0]"
			[Register ("getRemindType", "()I", "GetGetRemindTypeHandler")]
			get {
				if (id_getRemindType == IntPtr.Zero)
					id_getRemindType = JNIEnv.GetMethodID (class_ref, "getRemindType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRemindType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemindType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='setRemindType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRemindType", "(I)V", "GetSetRemindType_IHandler")]
			set {
				if (id_setRemindType_I == IntPtr.Zero)
					id_setRemindType_I = JNIEnv.GetMethodID (class_ref, "setRemindType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRemindType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemindType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isServerOptionFirst;
#pragma warning disable 0169
		static Delegate GetIsServerOptionFirstHandler ()
		{
			if (cb_isServerOptionFirst == null)
				cb_isServerOptionFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsServerOptionFirst);
			return cb_isServerOptionFirst;
		}

		static bool n_IsServerOptionFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServerOptionFirst;
		}
#pragma warning restore 0169

		static Delegate cb_setServerOptionFirst_Z;
#pragma warning disable 0169
		static Delegate GetSetServerOptionFirst_ZHandler ()
		{
			if (cb_setServerOptionFirst_Z == null)
				cb_setServerOptionFirst_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetServerOptionFirst_Z);
			return cb_setServerOptionFirst_Z;
		}

		static void n_SetServerOptionFirst_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServerOptionFirst = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isServerOptionFirst;
		static IntPtr id_setServerOptionFirst_Z;
		public virtual unsafe bool ServerOptionFirst {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='isServerOptionFirst' and count(parameter)=0]"
			[Register ("isServerOptionFirst", "()Z", "GetIsServerOptionFirstHandler")]
			get {
				if (id_isServerOptionFirst == IntPtr.Zero)
					id_isServerOptionFirst = JNIEnv.GetMethodID (class_ref, "isServerOptionFirst", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isServerOptionFirst);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isServerOptionFirst", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='setServerOptionFirst' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setServerOptionFirst", "(Z)V", "GetSetServerOptionFirst_ZHandler")]
			set {
				if (id_setServerOptionFirst_Z == IntPtr.Zero)
					id_setServerOptionFirst_Z = JNIEnv.GetMethodID (class_ref, "setServerOptionFirst", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServerOptionFirst_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerOptionFirst", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusBarDrawable;
#pragma warning disable 0169
		static Delegate GetGetStatusBarDrawableHandler ()
		{
			if (cb_getStatusBarDrawable == null)
				cb_getStatusBarDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusBarDrawable);
			return cb_getStatusBarDrawable;
		}

		static int n_GetStatusBarDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusBarDrawable;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusBarDrawable_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarDrawable_IHandler ()
		{
			if (cb_setStatusBarDrawable_I == null)
				cb_setStatusBarDrawable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusBarDrawable_I);
			return cb_setStatusBarDrawable_I;
		}

		static void n_SetStatusBarDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusBarDrawable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusBarDrawable;
		static IntPtr id_setStatusBarDrawable_I;
		public virtual unsafe int StatusBarDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='getStatusBarDrawable' and count(parameter)=0]"
			[Register ("getStatusBarDrawable", "()I", "GetGetStatusBarDrawableHandler")]
			get {
				if (id_getStatusBarDrawable == IntPtr.Zero)
					id_getStatusBarDrawable = JNIEnv.GetMethodID (class_ref, "getStatusBarDrawable", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusBarDrawable);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusBarDrawable", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='BasicCustomPushNotification']/method[@name='setStatusBarDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusBarDrawable", "(I)V", "GetSetStatusBarDrawable_IHandler")]
			set {
				if (id_setStatusBarDrawable_I == IntPtr.Zero)
					id_setStatusBarDrawable_I = JNIEnv.GetMethodID (class_ref, "setStatusBarDrawable", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusBarDrawable_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarDrawable", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}

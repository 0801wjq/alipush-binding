using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alibaba.Sdk.Android.Push.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/push/notification/AdvancedCustomPushNotification", DoNotGenerateAcw=true)]
	public partial class AdvancedCustomPushNotification : global::Com.Alibaba.Sdk.Android.Push.Notification.BasicCustomPushNotification {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alibaba/sdk/android/push/notification/AdvancedCustomPushNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdvancedCustomPushNotification); }
		}

		protected AdvancedCustomPushNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/constructor[@name='AdvancedCustomPushNotification' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe AdvancedCustomPushNotification (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (AdvancedCustomPushNotification)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_getContentView;
#pragma warning disable 0169
		static Delegate GetGetContentViewHandler ()
		{
			if (cb_getContentView == null)
				cb_getContentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetContentView);
			return cb_getContentView;
		}

		static int n_GetContentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentView;
		}
#pragma warning restore 0169

		static IntPtr id_getContentView;
		public virtual unsafe int ContentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='getContentView' and count(parameter)=0]"
			[Register ("getContentView", "()I", "GetGetContentViewHandler")]
			get {
				if (id_getContentView == IntPtr.Zero)
					id_getContentView = JNIEnv.GetMethodID (class_ref, "getContentView", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getContentView);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentView", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon);
			return cb_getIcon;
		}

		static int n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Icon;
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Icon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		static IntPtr id_setIcon_I;
		public virtual unsafe int Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()I", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIcon);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
			set {
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconView;
#pragma warning disable 0169
		static Delegate GetGetIconViewHandler ()
		{
			if (cb_getIconView == null)
				cb_getIconView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIconView);
			return cb_getIconView;
		}

		static int n_GetIconView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconView;
		}
#pragma warning restore 0169

		static IntPtr id_getIconView;
		public virtual unsafe int IconView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='getIconView' and count(parameter)=0]"
			[Register ("getIconView", "()I", "GetGetIconViewHandler")]
			get {
				if (id_getIconView == IntPtr.Zero)
					id_getIconView = JNIEnv.GetMethodID (class_ref, "getIconView", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIconView);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconView", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationView;
#pragma warning disable 0169
		static Delegate GetGetNotificationViewHandler ()
		{
			if (cb_getNotificationView == null)
				cb_getNotificationView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationView);
			return cb_getNotificationView;
		}

		static int n_GetNotificationView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationView;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationView;
		public virtual unsafe int NotificationView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='getNotificationView' and count(parameter)=0]"
			[Register ("getNotificationView", "()I", "GetGetNotificationViewHandler")]
			get {
				if (id_getNotificationView == IntPtr.Zero)
					id_getNotificationView = JNIEnv.GetMethodID (class_ref, "getNotificationView", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationView);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationView", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTitleView;
#pragma warning disable 0169
		static Delegate GetGetTitleViewHandler ()
		{
			if (cb_getTitleView == null)
				cb_getTitleView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTitleView);
			return cb_getTitleView;
		}

		static int n_GetTitleView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Notification.AdvancedCustomPushNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TitleView;
		}
#pragma warning restore 0169

		static IntPtr id_getTitleView;
		public virtual unsafe int TitleView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.notification']/class[@name='AdvancedCustomPushNotification']/method[@name='getTitleView' and count(parameter)=0]"
			[Register ("getTitleView", "()I", "GetGetTitleViewHandler")]
			get {
				if (id_getTitleView == IntPtr.Zero)
					id_getTitleView = JNIEnv.GetMethodID (class_ref, "getTitleView", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTitleView);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleView", "()I"));
				} finally {
				}
			}
		}

	}
}

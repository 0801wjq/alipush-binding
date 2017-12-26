using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taobao.Accs.Flowcontrol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl']"
	[global::Android.Runtime.Register ("com/taobao/accs/flowcontrol/FlowControl", DoNotGenerateAcw=true)]
	public sealed partial class FlowControl : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']"
		[global::Android.Runtime.Register ("com/taobao/accs/flowcontrol/FlowControl$FlowControlInfo", DoNotGenerateAcw=true)]
		public partial class FlowControlInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {


			static IntPtr bizId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='bizId']"
			[Register ("bizId")]
			public string BizId {
				get {
					if (bizId_jfieldId == IntPtr.Zero)
						bizId_jfieldId = JNIEnv.GetFieldID (class_ref, "bizId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bizId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (bizId_jfieldId == IntPtr.Zero)
						bizId_jfieldId = JNIEnv.GetFieldID (class_ref, "bizId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bizId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr delayTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='delayTime']"
			[Register ("delayTime")]
			public long DelayTime {
				get {
					if (delayTime_jfieldId == IntPtr.Zero)
						delayTime_jfieldId = JNIEnv.GetFieldID (class_ref, "delayTime", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, delayTime_jfieldId);
				}
				set {
					if (delayTime_jfieldId == IntPtr.Zero)
						delayTime_jfieldId = JNIEnv.GetFieldID (class_ref, "delayTime", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delayTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr expireTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='expireTime']"
			[Register ("expireTime")]
			public long ExpireTime {
				get {
					if (expireTime_jfieldId == IntPtr.Zero)
						expireTime_jfieldId = JNIEnv.GetFieldID (class_ref, "expireTime", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, expireTime_jfieldId);
				}
				set {
					if (expireTime_jfieldId == IntPtr.Zero)
						expireTime_jfieldId = JNIEnv.GetFieldID (class_ref, "expireTime", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, expireTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr serviceId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='serviceId']"
			[Register ("serviceId")]
			public string ServiceId {
				get {
					if (serviceId_jfieldId == IntPtr.Zero)
						serviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, serviceId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (serviceId_jfieldId == IntPtr.Zero)
						serviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serviceId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr startTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='startTime']"
			[Register ("startTime")]
			public long StartTime {
				get {
					if (startTime_jfieldId == IntPtr.Zero)
						startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId);
				}
				set {
					if (startTime_jfieldId == IntPtr.Zero)
						startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr status_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/field[@name='status']"
			[Register ("status")]
			public int Status {
				get {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
				}
				set {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/flowcontrol/FlowControl$FlowControlInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlowControlInfo); }
			}

			protected FlowControlInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IJJJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/constructor[@name='FlowControl.FlowControlInfo' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IJJJ)V", "")]
			public unsafe FlowControlInfo (string p0, string p1, int p2, long p3, long p4, long p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					if (((object) this).GetType () != typeof (FlowControlInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;IJJJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IJJJ)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_IJJJ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_IJJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IJJJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IJJJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IJJJ, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_isExpired;
#pragma warning disable 0169
			static Delegate GetIsExpiredHandler ()
			{
				if (cb_isExpired == null)
					cb_isExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpired);
				return cb_isExpired;
			}

			static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExpired;
			}
#pragma warning restore 0169

			static IntPtr id_isExpired;
			public virtual unsafe bool IsExpired {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowControlInfo']/method[@name='isExpired' and count(parameter)=0]"
				[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
				get {
					if (id_isExpired == IntPtr.Zero)
						id_isExpired = JNIEnv.GetMethodID (class_ref, "isExpired", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpired);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpired", "()Z"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowCtrlInfoHolder']"
		[global::Android.Runtime.Register ("com/taobao/accs/flowcontrol/FlowControl$FlowCtrlInfoHolder", DoNotGenerateAcw=true)]
		public partial class FlowCtrlInfoHolder : global::Java.Lang.Object, global::Java.IO.ISerializable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/taobao/accs/flowcontrol/FlowControl$FlowCtrlInfoHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlowCtrlInfoHolder); }
			}

			protected FlowCtrlInfoHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowCtrlInfoHolder']/constructor[@name='FlowControl.FlowCtrlInfoHolder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe FlowCtrlInfoHolder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (FlowCtrlInfoHolder)) {
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

			static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_get_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_get_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_String_);
				return cb_get_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Get_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowCtrlInfoHolder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowCtrlInfoHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_get_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowCtrlInfoHolder']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;", "GetGet_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo Get (string p0, string p1)
			{
				if (id_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/String;)Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_;
#pragma warning disable 0169
			static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_Handler ()
			{
				if (cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_ == null)
					cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_);
				return cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_;
			}

			static void n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowCtrlInfoHolder __this = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowCtrlInfoHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Put (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl.FlowCtrlInfoHolder']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.taobao.accs.flowcontrol.FlowControl.FlowControlInfo']]"
			[Register ("put", "(Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_Handler")]
			public virtual unsafe void Put (string p0, string p1, global::Com.Taobao.Accs.Flowcontrol.FlowControl.FlowControlInfo p2)
			{
				if (id_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_ == IntPtr.Zero)
					id_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_Lcom_taobao_accs_flowcontrol_FlowControl_FlowControlInfo_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/taobao/accs/flowcontrol/FlowControl$FlowControlInfo;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taobao/accs/flowcontrol/FlowControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlowControl); }
		}

		internal FlowControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl']/constructor[@name='FlowControl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FlowControl (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FlowControl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)J", "")]
		public unsafe long A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taobao.accs.flowcontrol']/class[@name='FlowControl']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;com.taobao.accs.base.TaoBaseService.ExtHeaderType, java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/util/Map;Ljava/lang/String;)I", "")]
		public unsafe int A (global::System.Collections.Generic.IDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string> p0, string p1)
		{
			if (id_a_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;Ljava/lang/String;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Taobao.Accs.Base.TaoBaseService.ExtHeaderType, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_util_Map_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

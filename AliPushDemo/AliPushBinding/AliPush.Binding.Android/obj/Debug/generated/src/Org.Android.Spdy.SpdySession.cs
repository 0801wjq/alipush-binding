using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdySession", DoNotGenerateAcw=true)]
	public sealed partial class SpdySession : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdySession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdySession); }
		}

		internal SpdySession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDomain;
		public unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRefCount;
		public unsafe int RefCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='getRefCount' and count(parameter)=0]"
			[Register ("getRefCount", "()I", "GetGetRefCountHandler")]
			get {
				if (id_getRefCount == IntPtr.Zero)
					id_getRefCount = JNIEnv.GetMethodID (class_ref, "getRefCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRefCount);
				} finally {
				}
			}
		}

		static IntPtr id_getUserData;
		public unsafe global::Java.Lang.Object UserData {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='getUserData' and count(parameter)=0]"
			[Register ("getUserData", "()Ljava/lang/Object;", "GetGetUserDataHandler")]
			get {
				if (id_getUserData == IntPtr.Zero)
					id_getUserData = JNIEnv.GetMethodID (class_ref, "getUserData", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_cleanUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='cleanUp' and count(parameter)=0]"
		[Register ("cleanUp", "()I", "")]
		public unsafe int CleanUp ()
		{
			if (id_cleanUp == IntPtr.Zero)
				id_cleanUp = JNIEnv.GetMethodID (class_ref, "cleanUp", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cleanUp);
			} finally {
			}
		}

		static IntPtr id_clearAllStreamCb;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='clearAllStreamCb' and count(parameter)=0]"
		[Register ("clearAllStreamCb", "()V", "")]
		public unsafe void ClearAllStreamCb ()
		{
			if (id_clearAllStreamCb == IntPtr.Zero)
				id_clearAllStreamCb = JNIEnv.GetMethodID (class_ref, "clearAllStreamCb", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllStreamCb);
			} finally {
			}
		}

		static IntPtr id_closeSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()I", "")]
		public unsafe int CloseSession ()
		{
			if (id_closeSession == IntPtr.Zero)
				id_closeSession = JNIEnv.GetMethodID (class_ref, "closeSession", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_closeSession);
			} finally {
			}
		}

		static IntPtr id_getAllStreamCb;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='getAllStreamCb' and count(parameter)=0]"
		[Register ("getAllStreamCb", "()[Lorg/android/spdy/SpdyStreamContext;", "")]
		public unsafe global::Org.Android.Spdy.SpdyStreamContext[] GetAllStreamCb ()
		{
			if (id_getAllStreamCb == IntPtr.Zero)
				id_getAllStreamCb = JNIEnv.GetMethodID (class_ref, "getAllStreamCb", "()[Lorg/android/spdy/SpdyStreamContext;");
			try {
				return (global::Org.Android.Spdy.SpdyStreamContext[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllStreamCb), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Spdy.SpdyStreamContext));
			} finally {
			}
		}

		static IntPtr id_sendCustomControlFrame_IIIIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='sendCustomControlFrame' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("sendCustomControlFrame", "(IIII[B)I", "")]
		public unsafe int SendCustomControlFrame (int p0, int p1, int p2, int p3, byte[] p4)
		{
			if (id_sendCustomControlFrame_IIIIarrayB == IntPtr.Zero)
				id_sendCustomControlFrame_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "sendCustomControlFrame", "(IIII[B)I");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sendCustomControlFrame_IIIIarrayB, __args);
				return __ret;
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_setOption_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='setOption' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setOption", "(II)I", "")]
		public unsafe int SetOption (int p0, int p1)
		{
			if (id_setOption_II == IntPtr.Zero)
				id_setOption_II = JNIEnv.GetMethodID (class_ref, "setOption", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setOption_II, __args);
			} finally {
			}
		}

		static IntPtr id_streamReset_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='streamReset' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("streamReset", "(JI)I", "")]
		public unsafe int StreamReset (long p0, int p1)
		{
			if (id_streamReset_JI == IntPtr.Zero)
				id_streamReset_JI = JNIEnv.GetMethodID (class_ref, "streamReset", "(JI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_streamReset_JI, __args);
			} finally {
			}
		}

		static IntPtr id_submitBioPing;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='submitBioPing' and count(parameter)=0]"
		[Register ("submitBioPing", "()I", "")]
		public unsafe int SubmitBioPing ()
		{
			if (id_submitBioPing == IntPtr.Zero)
				id_submitBioPing = JNIEnv.GetMethodID (class_ref, "submitBioPing", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_submitBioPing);
			} finally {
			}
		}

		static IntPtr id_submitPing;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdySession']/method[@name='submitPing' and count(parameter)=0]"
		[Register ("submitPing", "()I", "")]
		public unsafe int SubmitPing ()
		{
			if (id_submitPing == IntPtr.Zero)
				id_submitPing = JNIEnv.GetMethodID (class_ref, "submitPing", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_submitPing);
			} finally {
			}
		}

	}
}

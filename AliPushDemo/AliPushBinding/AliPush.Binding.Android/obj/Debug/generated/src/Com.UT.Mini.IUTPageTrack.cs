using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Mini {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTPageTrack']"
	[Register ("com/ut/mini/IUTPageTrack", "", "Com.UT.Mini.IUTPageTrackInvoker")]
	public partial interface IUTPageTrack : IJavaObject {

		string PageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTPageTrack']/method[@name='getPageName' and count(parameter)=0]"
			[Register ("getPageName", "()Ljava/lang/String;", "GetGetPageNameHandler:Com.UT.Mini.IUTPageTrackInvoker, AliPush.Binding.Android")] get;
		}

		global::System.Collections.Generic.IDictionary<string, string> PageProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTPageTrack']/method[@name='getPageProperties' and count(parameter)=0]"
			[Register ("getPageProperties", "()Ljava/util/Map;", "GetGetPagePropertiesHandler:Com.UT.Mini.IUTPageTrackInvoker, AliPush.Binding.Android")] get;
		}

		string ReferPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.mini']/interface[@name='IUTPageTrack']/method[@name='getReferPage' and count(parameter)=0]"
			[Register ("getReferPage", "()Ljava/lang/String;", "GetGetReferPageHandler:Com.UT.Mini.IUTPageTrackInvoker, AliPush.Binding.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ut/mini/IUTPageTrack", DoNotGenerateAcw=true)]
	internal class IUTPageTrackInvoker : global::Java.Lang.Object, IUTPageTrack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/mini/IUTPageTrack");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUTPageTrackInvoker); }
		}

		IntPtr class_ref;

		public static IUTPageTrack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUTPageTrack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.mini.IUTPageTrack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUTPageTrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPageName;
#pragma warning disable 0169
		static Delegate GetGetPageNameHandler ()
		{
			if (cb_getPageName == null)
				cb_getPageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageName);
			return cb_getPageName;
		}

		static IntPtr n_GetPageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTPageTrack __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTPageTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PageName);
		}
#pragma warning restore 0169

		IntPtr id_getPageName;
		public unsafe string PageName {
			get {
				if (id_getPageName == IntPtr.Zero)
					id_getPageName = JNIEnv.GetMethodID (class_ref, "getPageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPageProperties;
#pragma warning disable 0169
		static Delegate GetGetPagePropertiesHandler ()
		{
			if (cb_getPageProperties == null)
				cb_getPageProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageProperties);
			return cb_getPageProperties;
		}

		static IntPtr n_GetPageProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTPageTrack __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTPageTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PageProperties);
		}
#pragma warning restore 0169

		IntPtr id_getPageProperties;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> PageProperties {
			get {
				if (id_getPageProperties == IntPtr.Zero)
					id_getPageProperties = JNIEnv.GetMethodID (class_ref, "getPageProperties", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageProperties), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReferPage;
#pragma warning disable 0169
		static Delegate GetGetReferPageHandler ()
		{
			if (cb_getReferPage == null)
				cb_getReferPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferPage);
			return cb_getReferPage;
		}

		static IntPtr n_GetReferPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.UT.Mini.IUTPageTrack __this = global::Java.Lang.Object.GetObject<global::Com.UT.Mini.IUTPageTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReferPage);
		}
#pragma warning restore 0169

		IntPtr id_getReferPage;
		public unsafe string ReferPage {
			get {
				if (id_getReferPage == IntPtr.Zero)
					id_getReferPage = JNIEnv.GetMethodID (class_ref, "getReferPage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReferPage), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}

//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace AliPush.Binding.iOS {
	[Register("CloudPushSDK", true)]
	public unsafe partial class CloudPushSDK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CloudPushSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CloudPushSDK () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CloudPushSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CloudPushSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAlias:withCallback:")]
		[CompilerGenerated]
		public unsafe static void AddAlias (string alias, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (alias == null)
				throw new ArgumentNullException ("alias");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsalias = NSString.CreateNative (alias);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("addAlias:withCallback:"), nsalias, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsalias);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("asyncInit:appSecret:callback:")]
		[CompilerGenerated]
		public unsafe static void AsyncInit (string appKey, string appSecret, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (appKey == null)
				throw new ArgumentNullException ("appKey");
			if (appSecret == null)
				throw new ArgumentNullException ("appSecret");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsappKey = NSString.CreateNative (appKey);
			var nsappSecret = NSString.CreateNative (appSecret);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("asyncInit:appSecret:callback:"), nsappKey, nsappSecret, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsappKey);
			NSString.ReleaseNative (nsappSecret);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("bindAccount:withCallback:")]
		[CompilerGenerated]
		public unsafe static void BindAccount (string account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (account == null)
				throw new ArgumentNullException ("account");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsaccount = NSString.CreateNative (account);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("bindAccount:withCallback:"), nsaccount, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsaccount);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("bindTag:withTags:withAlias:withCallback:")]
		[CompilerGenerated]
		public unsafe static void BindTag (int target, NSObject[] tags, string alias, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (alias == null)
				throw new ArgumentNullException ("alias");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_tags = NSArray.FromNSObjects (tags);
			var nsalias = NSString.CreateNative (alias);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("bindTag:withTags:withAlias:withCallback:"), target, nsa_tags.Handle, nsalias, (IntPtr) block_ptr_callback);
			nsa_tags.Dispose ();
			NSString.ReleaseNative (nsalias);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("handleLaunching:")]
		[CompilerGenerated]
		public static void HandleLaunching (NSDictionary launchOptions)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleLaunching:"), launchOptions.Handle);
		}
		
		[Export ("handleReceiveRemoteNotification:")]
		[CompilerGenerated]
		public static void HandleReceiveRemoteNotification (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleReceiveRemoteNotification:"), userInfo.Handle);
		}
		
		[Export ("listAliases:")]
		[CompilerGenerated]
		public unsafe static void ListAliases ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("listAliases:"), (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("listTags:withCallback:")]
		[CompilerGenerated]
		public unsafe static void ListTags (int target, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (class_ptr, Selector.GetHandle ("listTags:withCallback:"), target, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("registerDevice:withCallback:")]
		[CompilerGenerated]
		public unsafe static void RegisterDevice (NSData deviceToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("registerDevice:withCallback:"), deviceToken.Handle, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("removeAlias:withCallback:")]
		[CompilerGenerated]
		public unsafe static void RemoveAlias (string alias, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (alias == null)
				throw new ArgumentNullException ("alias");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsalias = NSString.CreateNative (alias);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("removeAlias:withCallback:"), nsalias, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsalias);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("sendNotificationAck:")]
		[CompilerGenerated]
		public static void SendNotificationAck (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sendNotificationAck:"), userInfo.Handle);
		}
		
		[Export ("syncBadgeNum:withCallback:")]
		[CompilerGenerated]
		public unsafe static void SyncBadgeNum (nuint num, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint_IntPtr (class_ptr, Selector.GetHandle ("syncBadgeNum:withCallback:"), num, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("turnOnDebug")]
		[CompilerGenerated]
		public static void TurnOnDebug ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("turnOnDebug"));
		}
		
		[Export ("unbindAccount:")]
		[CompilerGenerated]
		public unsafe static void UnbindAccount ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("unbindAccount:"), (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("unbindTag:withTags:withAlias:withCallback:")]
		[CompilerGenerated]
		public unsafe static void UnbindTag (int target, NSObject[] tags, string alias, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackHandler))]CallbackHandler callback)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (alias == null)
				throw new ArgumentNullException ("alias");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsa_tags = NSArray.FromNSObjects (tags);
			var nsalias = NSString.CreateNative (alias);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDCallbackHandler.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("unbindTag:withTags:withAlias:withCallback:"), target, nsa_tags.Handle, nsalias, (IntPtr) block_ptr_callback);
			nsa_tags.Dispose ();
			NSString.ReleaseNative (nsalias);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static string ApnsDeviceToken {
			[Export ("getApnsDeviceToken")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getApnsDeviceToken")));
			}
			
		}
		
		[CompilerGenerated]
		public static string DeviceId {
			[Export ("getDeviceId")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getDeviceId")));
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsChannelOpened {
			[Export ("isChannelOpened")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isChannelOpened"));
			}
			
		}
		
		[CompilerGenerated]
		public static string Version {
			[Export ("getVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getVersion")));
			}
			
		}
		
	} /* class CloudPushSDK */
}

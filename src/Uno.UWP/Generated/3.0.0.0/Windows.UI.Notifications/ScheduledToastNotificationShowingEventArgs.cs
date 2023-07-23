#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ScheduledToastNotificationShowingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScheduledToastNotificationShowingEventArgs.Cancel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ScheduledToastNotificationShowingEventArgs.Cancel");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.ScheduledToastNotificationShowingEventArgs", "bool ScheduledToastNotificationShowingEventArgs.Cancel");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Notifications.ScheduledToastNotification ScheduledToastNotification
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScheduledToastNotification ScheduledToastNotificationShowingEventArgs.ScheduledToastNotification is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ScheduledToastNotification%20ScheduledToastNotificationShowingEventArgs.ScheduledToastNotification");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Notifications.ScheduledToastNotificationShowingEventArgs.Cancel.get
		// Forced skipping of method Windows.UI.Notifications.ScheduledToastNotificationShowingEventArgs.Cancel.set
		// Forced skipping of method Windows.UI.Notifications.ScheduledToastNotificationShowingEventArgs.ScheduledToastNotification.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral ScheduledToastNotificationShowingEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20ScheduledToastNotificationShowingEventArgs.GetDeferral%28%29");
		}
#endif
	}
}

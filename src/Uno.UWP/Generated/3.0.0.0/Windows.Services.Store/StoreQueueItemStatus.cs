#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StoreQueueItemStatus 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreQueueItemStatus.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreQueueItemStatus.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Services.Store.StoreQueueItemExtendedState PackageInstallExtendedState
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreQueueItemExtendedState StoreQueueItemStatus.PackageInstallExtendedState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreQueueItemExtendedState%20StoreQueueItemStatus.PackageInstallExtendedState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Services.Store.StoreQueueItemState PackageInstallState
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreQueueItemState StoreQueueItemStatus.PackageInstallState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreQueueItemState%20StoreQueueItemStatus.PackageInstallState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Services.Store.StorePackageUpdateStatus UpdateStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorePackageUpdateStatus StoreQueueItemStatus.UpdateStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorePackageUpdateStatus%20StoreQueueItemStatus.UpdateStatus");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreQueueItemStatus.PackageInstallState.get
		// Forced skipping of method Windows.Services.Store.StoreQueueItemStatus.PackageInstallExtendedState.get
		// Forced skipping of method Windows.Services.Store.StoreQueueItemStatus.UpdateStatus.get
		// Forced skipping of method Windows.Services.Store.StoreQueueItemStatus.ExtendedError.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PackageCatalogRemoveResourcePackagesResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception PackageCatalogRemoveResourcePackagesResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20PackageCatalogRemoveResourcePackagesResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Package> PackagesRemoved
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Package> PackageCatalogRemoveResourcePackagesResult.PackagesRemoved is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CPackage%3E%20PackageCatalogRemoveResourcePackagesResult.PackagesRemoved");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogRemoveResourcePackagesResult.PackagesRemoved.get
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogRemoveResourcePackagesResult.ExtendedError.get
	}
}

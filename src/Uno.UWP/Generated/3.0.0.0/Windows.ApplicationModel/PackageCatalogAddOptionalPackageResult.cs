#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PackageCatalogAddOptionalPackageResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception PackageCatalogAddOptionalPackageResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20PackageCatalogAddOptionalPackageResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Package Package
		{
			get
			{
				throw new global::System.NotImplementedException("The member Package PackageCatalogAddOptionalPackageResult.Package is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Package%20PackageCatalogAddOptionalPackageResult.Package");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogAddOptionalPackageResult.Package.get
		// Forced skipping of method Windows.ApplicationModel.PackageCatalogAddOptionalPackageResult.ExtendedError.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PackageUpdateAvailabilityResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.PackageUpdateAvailability Availability
		{
			get
			{
				throw new global::System.NotImplementedException("The member PackageUpdateAvailability PackageUpdateAvailabilityResult.Availability is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PackageUpdateAvailability%20PackageUpdateAvailabilityResult.Availability");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception PackageUpdateAvailabilityResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20PackageUpdateAvailabilityResult.ExtendedError");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.PackageUpdateAvailabilityResult.Availability.get
		// Forced skipping of method Windows.ApplicationModel.PackageUpdateAvailabilityResult.ExtendedError.get
	}
}

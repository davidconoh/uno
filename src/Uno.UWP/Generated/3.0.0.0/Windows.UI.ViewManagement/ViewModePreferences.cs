#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class ViewModePreferences 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.ViewManagement.ViewSizePreference ViewSizePreference
		{
			get
			{
				throw new global::System.NotImplementedException("The member ViewSizePreference ViewModePreferences.ViewSizePreference is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ViewSizePreference%20ViewModePreferences.ViewSizePreference");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ViewModePreferences", "ViewSizePreference ViewModePreferences.ViewSizePreference");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Size CustomSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size ViewModePreferences.CustomSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Size%20ViewModePreferences.CustomSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ViewModePreferences", "Size ViewModePreferences.CustomSize");
			}
		}
#endif
		// Forced skipping of method Windows.UI.ViewManagement.ViewModePreferences.ViewSizePreference.get
		// Forced skipping of method Windows.UI.ViewManagement.ViewModePreferences.ViewSizePreference.set
		// Forced skipping of method Windows.UI.ViewManagement.ViewModePreferences.CustomSize.get
		// Forced skipping of method Windows.UI.ViewManagement.ViewModePreferences.CustomSize.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.ViewManagement.ViewModePreferences CreateDefault( global::Windows.UI.ViewManagement.ApplicationViewMode mode)
		{
			throw new global::System.NotImplementedException("The member ViewModePreferences ViewModePreferences.CreateDefault(ApplicationViewMode mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ViewModePreferences%20ViewModePreferences.CreateDefault%28ApplicationViewMode%20mode%29");
		}
#endif
	}
}

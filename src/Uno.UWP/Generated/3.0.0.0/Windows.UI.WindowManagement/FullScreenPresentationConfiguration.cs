#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WindowManagement
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class FullScreenPresentationConfiguration : global::Windows.UI.WindowManagement.AppWindowPresentationConfiguration
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsExclusive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FullScreenPresentationConfiguration.IsExclusive is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FullScreenPresentationConfiguration.IsExclusive");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.WindowManagement.FullScreenPresentationConfiguration", "bool FullScreenPresentationConfiguration.IsExclusive");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public FullScreenPresentationConfiguration() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.WindowManagement.FullScreenPresentationConfiguration", "FullScreenPresentationConfiguration.FullScreenPresentationConfiguration()");
		}
#endif
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.FullScreenPresentationConfiguration()
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.IsExclusive.get
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.IsExclusive.set
	}
}

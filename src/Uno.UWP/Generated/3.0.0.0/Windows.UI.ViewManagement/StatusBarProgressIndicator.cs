#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StatusBarProgressIndicator 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StatusBarProgressIndicator.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StatusBarProgressIndicator.Text");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.StatusBarProgressIndicator", "string StatusBarProgressIndicator.Text");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public double? ProgressValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member double? StatusBarProgressIndicator.ProgressValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%3F%20StatusBarProgressIndicator.ProgressValue");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.StatusBarProgressIndicator", "double? StatusBarProgressIndicator.ProgressValue");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ShowAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StatusBarProgressIndicator.ShowAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20StatusBarProgressIndicator.ShowAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction HideAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction StatusBarProgressIndicator.HideAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20StatusBarProgressIndicator.HideAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.UI.ViewManagement.StatusBarProgressIndicator.Text.get
		// Forced skipping of method Windows.UI.ViewManagement.StatusBarProgressIndicator.Text.set
		// Forced skipping of method Windows.UI.ViewManagement.StatusBarProgressIndicator.ProgressValue.get
		// Forced skipping of method Windows.UI.ViewManagement.StatusBarProgressIndicator.ProgressValue.set
	}
}

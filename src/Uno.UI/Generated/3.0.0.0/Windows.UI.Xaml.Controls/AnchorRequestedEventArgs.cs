#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AnchorRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.UIElement Anchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement AnchorRequestedEventArgs.Anchor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UIElement%20AnchorRequestedEventArgs.Anchor");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.AnchorRequestedEventArgs", "UIElement AnchorRequestedEventArgs.Anchor");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.UI.Xaml.UIElement> AnchorCandidates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<UIElement> AnchorRequestedEventArgs.AnchorCandidates is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CUIElement%3E%20AnchorRequestedEventArgs.AnchorCandidates");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.Anchor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.AnchorRequestedEventArgs.AnchorCandidates.get
	}
}

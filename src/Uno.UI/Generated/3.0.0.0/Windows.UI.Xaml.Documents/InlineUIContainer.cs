#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Documents
{
	[global::Windows.UI.Xaml.Markup.ContentPropertyAttribute(Name = "Child")]
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class InlineUIContainer : global::Windows.UI.Xaml.Documents.Inline
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.UIElement Child
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement InlineUIContainer.Child is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UIElement%20InlineUIContainer.Child");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.InlineUIContainer", "UIElement InlineUIContainer.Child");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InlineUIContainer() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Documents.InlineUIContainer", "InlineUIContainer.InlineUIContainer()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Documents.InlineUIContainer.InlineUIContainer()
		// Forced skipping of method Windows.UI.Xaml.Documents.InlineUIContainer.Child.get
		// Forced skipping of method Windows.UI.Xaml.Documents.InlineUIContainer.Child.set
	}
}

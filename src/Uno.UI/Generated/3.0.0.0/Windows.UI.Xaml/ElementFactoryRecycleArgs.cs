#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ElementFactoryRecycleArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.UIElement Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ElementFactoryRecycleArgs.Parent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UIElement%20ElementFactoryRecycleArgs.Parent");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.ElementFactoryRecycleArgs", "UIElement ElementFactoryRecycleArgs.Parent");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.UIElement Element
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ElementFactoryRecycleArgs.Element is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UIElement%20ElementFactoryRecycleArgs.Element");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.ElementFactoryRecycleArgs", "UIElement ElementFactoryRecycleArgs.Element");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ElementFactoryRecycleArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.ElementFactoryRecycleArgs", "ElementFactoryRecycleArgs.ElementFactoryRecycleArgs()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.ElementFactoryRecycleArgs.ElementFactoryRecycleArgs()
		// Forced skipping of method Windows.UI.Xaml.ElementFactoryRecycleArgs.Element.get
		// Forced skipping of method Windows.UI.Xaml.ElementFactoryRecycleArgs.Element.set
		// Forced skipping of method Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent.get
		// Forced skipping of method Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent.set
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial interface IAnimatedVisualSource3 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.IAnimatedVisual2 TryCreateAnimatedVisual( global::Windows.UI.Composition.Compositor compositor, out object diagnostics,  bool createAnimations);
#endif
	}
}

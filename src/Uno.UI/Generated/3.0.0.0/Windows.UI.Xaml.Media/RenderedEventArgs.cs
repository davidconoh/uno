#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RenderedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.TimeSpan FrameDuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan RenderedEventArgs.FrameDuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20RenderedEventArgs.FrameDuration");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Media.RenderedEventArgs.FrameDuration.get
	}
}

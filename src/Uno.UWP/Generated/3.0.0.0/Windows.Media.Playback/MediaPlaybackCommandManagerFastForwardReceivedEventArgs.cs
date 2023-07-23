#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MediaPlaybackCommandManagerFastForwardReceivedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlaybackCommandManagerFastForwardReceivedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlaybackCommandManagerFastForwardReceivedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs", "bool MediaPlaybackCommandManagerFastForwardReceivedEventArgs.Handled");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs.Handled.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs.Handled.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral MediaPlaybackCommandManagerFastForwardReceivedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20MediaPlaybackCommandManagerFastForwardReceivedEventArgs.GetDeferral%28%29");
		}
#endif
	}
}

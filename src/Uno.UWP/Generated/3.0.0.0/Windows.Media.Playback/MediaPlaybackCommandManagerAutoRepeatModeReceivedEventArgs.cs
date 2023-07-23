#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs", "bool MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Handled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.MediaPlaybackAutoRepeatMode AutoRepeatMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackAutoRepeatMode MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.AutoRepeatMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlaybackAutoRepeatMode%20MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.AutoRepeatMode");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Handled.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Handled.set
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.AutoRepeatMode.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.GetDeferral%28%29");
		}
#endif
	}
}

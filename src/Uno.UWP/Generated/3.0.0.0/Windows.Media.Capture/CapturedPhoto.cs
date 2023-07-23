#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CapturedPhoto 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.CapturedFrame Frame
		{
			get
			{
				throw new global::System.NotImplementedException("The member CapturedFrame CapturedPhoto.Frame is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CapturedFrame%20CapturedPhoto.Frame");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.CapturedFrame Thumbnail
		{
			get
			{
				throw new global::System.NotImplementedException("The member CapturedFrame CapturedPhoto.Thumbnail is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CapturedFrame%20CapturedPhoto.Thumbnail");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Capture.CapturedPhoto.Frame.get
		// Forced skipping of method Windows.Media.Capture.CapturedPhoto.Thumbnail.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Frames
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MediaFrameSourceGetPropertyResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaFrameSourceGetPropertyStatus MediaFrameSourceGetPropertyResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaFrameSourceGetPropertyStatus%20MediaFrameSourceGetPropertyResult.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public object Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member object MediaFrameSourceGetPropertyResult.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20MediaFrameSourceGetPropertyResult.Value");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyResult.Status.get
		// Forced skipping of method Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyResult.Value.get
	}
}

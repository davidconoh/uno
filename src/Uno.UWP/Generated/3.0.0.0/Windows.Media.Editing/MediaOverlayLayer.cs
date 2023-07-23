#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Editing
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MediaOverlayLayer 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Effects.IVideoCompositorDefinition CustomCompositorDefinition
		{
			get
			{
				throw new global::System.NotImplementedException("The member IVideoCompositorDefinition MediaOverlayLayer.CustomCompositorDefinition is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IVideoCompositorDefinition%20MediaOverlayLayer.CustomCompositorDefinition");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.Media.Editing.MediaOverlay> Overlays
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<MediaOverlay> MediaOverlayLayer.Overlays is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CMediaOverlay%3E%20MediaOverlayLayer.Overlays");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MediaOverlayLayer( global::Windows.Media.Effects.IVideoCompositorDefinition compositorDefinition) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Editing.MediaOverlayLayer", "MediaOverlayLayer.MediaOverlayLayer(IVideoCompositorDefinition compositorDefinition)");
		}
#endif
		// Forced skipping of method Windows.Media.Editing.MediaOverlayLayer.MediaOverlayLayer(Windows.Media.Effects.IVideoCompositorDefinition)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MediaOverlayLayer() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Editing.MediaOverlayLayer", "MediaOverlayLayer.MediaOverlayLayer()");
		}
#endif
		// Forced skipping of method Windows.Media.Editing.MediaOverlayLayer.MediaOverlayLayer()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Editing.MediaOverlayLayer Clone()
		{
			throw new global::System.NotImplementedException("The member MediaOverlayLayer MediaOverlayLayer.Clone() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaOverlayLayer%20MediaOverlayLayer.Clone%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.Editing.MediaOverlayLayer.Overlays.get
		// Forced skipping of method Windows.Media.Editing.MediaOverlayLayer.CustomCompositorDefinition.get
	}
}

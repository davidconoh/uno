#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreWetStrokeUpdateEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.Inking.Core.CoreWetStrokeDisposition Disposition
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWetStrokeDisposition CoreWetStrokeUpdateEventArgs.Disposition is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreWetStrokeDisposition%20CoreWetStrokeUpdateEventArgs.Disposition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs", "CoreWetStrokeDisposition CoreWetStrokeUpdateEventArgs.Disposition");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.UI.Input.Inking.InkPoint> NewInkPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<InkPoint> CoreWetStrokeUpdateEventArgs.NewInkPoints is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CInkPoint%3E%20CoreWetStrokeUpdateEventArgs.NewInkPoints");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint PointerId
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CoreWetStrokeUpdateEventArgs.PointerId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20CoreWetStrokeUpdateEventArgs.PointerId");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.NewInkPoints.get
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.PointerId.get
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.Disposition.get
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.Disposition.set
	}
}

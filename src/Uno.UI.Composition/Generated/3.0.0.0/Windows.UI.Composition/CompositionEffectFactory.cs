#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CompositionEffectFactory : global::Windows.UI.Composition.CompositionObject
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception CompositionEffectFactory.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20CompositionEffectFactory.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Composition.CompositionEffectFactoryLoadStatus LoadStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEffectFactoryLoadStatus CompositionEffectFactory.LoadStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CompositionEffectFactoryLoadStatus%20CompositionEffectFactory.LoadStatus");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Composition.CompositionEffectBrush CreateBrush()
		{
			throw new global::System.NotImplementedException("The member CompositionEffectBrush CompositionEffectFactory.CreateBrush() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CompositionEffectBrush%20CompositionEffectFactory.CreateBrush%28%29");
		}
#endif
		// Forced skipping of method Windows.UI.Composition.CompositionEffectFactory.ExtendedError.get
		// Forced skipping of method Windows.UI.Composition.CompositionEffectFactory.LoadStatus.get
	}
}

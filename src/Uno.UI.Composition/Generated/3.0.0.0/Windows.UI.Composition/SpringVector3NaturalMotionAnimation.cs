#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SpringVector3NaturalMotionAnimation : global::Windows.UI.Composition.Vector3NaturalMotionAnimation
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.TimeSpan Period
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan SpringVector3NaturalMotionAnimation.Period is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20SpringVector3NaturalMotionAnimation.Period");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.SpringVector3NaturalMotionAnimation", "TimeSpan SpringVector3NaturalMotionAnimation.Period");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public float DampingRatio
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SpringVector3NaturalMotionAnimation.DampingRatio is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=float%20SpringVector3NaturalMotionAnimation.DampingRatio");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.SpringVector3NaturalMotionAnimation", "float SpringVector3NaturalMotionAnimation.DampingRatio");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Composition.SpringVector3NaturalMotionAnimation.DampingRatio.get
		// Forced skipping of method Windows.UI.Composition.SpringVector3NaturalMotionAnimation.DampingRatio.set
		// Forced skipping of method Windows.UI.Composition.SpringVector3NaturalMotionAnimation.Period.get
		// Forced skipping of method Windows.UI.Composition.SpringVector3NaturalMotionAnimation.Period.set
	}
}

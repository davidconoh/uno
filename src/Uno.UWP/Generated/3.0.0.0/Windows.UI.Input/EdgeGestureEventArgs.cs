#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class EdgeGestureEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.EdgeGestureKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member EdgeGestureKind EdgeGestureEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EdgeGestureKind%20EdgeGestureEventArgs.Kind");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.EdgeGestureEventArgs.Kind.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreTextSelectionRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Text.Core.CoreTextSelectionRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextSelectionRequest CoreTextSelectionRequestedEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreTextSelectionRequest%20CoreTextSelectionRequestedEventArgs.Request");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextSelectionRequestedEventArgs.Request.get
	}
}

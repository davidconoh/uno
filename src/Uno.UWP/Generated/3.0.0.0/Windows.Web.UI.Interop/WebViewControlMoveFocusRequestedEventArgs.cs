#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI.Interop
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WebViewControlMoveFocusRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Web.UI.Interop.WebViewControlMoveFocusReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewControlMoveFocusReason WebViewControlMoveFocusRequestedEventArgs.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewControlMoveFocusReason%20WebViewControlMoveFocusRequestedEventArgs.Reason");
			}
		}
#endif
		// Forced skipping of method Windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs.Reason.get
	}
}

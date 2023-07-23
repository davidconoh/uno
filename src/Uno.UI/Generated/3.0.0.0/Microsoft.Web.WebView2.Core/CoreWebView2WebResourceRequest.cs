#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreWebView2WebResourceRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2WebResourceRequest.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CoreWebView2WebResourceRequest.Uri");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest", "string CoreWebView2WebResourceRequest.Uri");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Method
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2WebResourceRequest.Method is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CoreWebView2WebResourceRequest.Method");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest", "string CoreWebView2WebResourceRequest.Method");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IRandomAccessStream Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStream CoreWebView2WebResourceRequest.Content is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRandomAccessStream%20CoreWebView2WebResourceRequest.Content");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest", "IRandomAccessStream CoreWebView2WebResourceRequest.Content");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders Headers
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2HttpRequestHeaders CoreWebView2WebResourceRequest.Headers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CoreWebView2HttpRequestHeaders%20CoreWebView2WebResourceRequest.Headers");
			}
		}
#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Uri.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Uri.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Method.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Method.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Content.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Content.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest.Headers.get
	}
}

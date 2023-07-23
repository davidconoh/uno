#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreWebView2Frame 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2Frame.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CoreWebView2Frame.Name");
			}
		}
#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.ContentLoading.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.ContentLoading.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationCompleted.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationCompleted.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.DOMContentLoaded.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.DOMContentLoaded.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> ExecuteScriptAsync( string javaScript)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CoreWebView2Frame.ExecuteScriptAsync(string javaScript) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20CoreWebView2Frame.ExecuteScriptAsync%28string%20javaScript%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void PostWebMessageAsJson( string webMessageAsJson)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "void CoreWebView2Frame.PostWebMessageAsJson(string webMessageAsJson)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void PostWebMessageAsString( string webMessageAsString)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "void CoreWebView2Frame.PostWebMessageAsString(string webMessageAsString)");
		}
#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.PermissionRequested.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.PermissionRequested.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.Name.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NameChanged.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.NameChanged.remove
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void RemoveHostObjectFromScript( string name)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "void CoreWebView2Frame.RemoveHostObjectFromScript(string name)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int IsDestroyed()
		{
			throw new global::System.NotImplementedException("The member int CoreWebView2Frame.IsDestroyed() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20CoreWebView2Frame.IsDestroyed%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> ContentLoading
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2ContentLoadingEventArgs> CoreWebView2Frame.ContentLoading");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2ContentLoadingEventArgs> CoreWebView2Frame.ContentLoading");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2DOMContentLoadedEventArgs> CoreWebView2Frame.DOMContentLoaded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2DOMContentLoadedEventArgs> CoreWebView2Frame.DOMContentLoaded");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2NavigationCompletedEventArgs> CoreWebView2Frame.NavigationCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2NavigationCompletedEventArgs> CoreWebView2Frame.NavigationCompleted");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> NavigationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2NavigationStartingEventArgs> CoreWebView2Frame.NavigationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2NavigationStartingEventArgs> CoreWebView2Frame.NavigationStarting");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2WebMessageReceivedEventArgs> CoreWebView2Frame.WebMessageReceived");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2WebMessageReceivedEventArgs> CoreWebView2Frame.WebMessageReceived");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs> PermissionRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2PermissionRequestedEventArgs> CoreWebView2Frame.PermissionRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, CoreWebView2PermissionRequestedEventArgs> CoreWebView2Frame.PermissionRequested");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, object> Destroyed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, object> CoreWebView2Frame.Destroyed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, object> CoreWebView2Frame.Destroyed");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2Frame, object> NameChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, object> CoreWebView2Frame.NameChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Frame", "event TypedEventHandler<CoreWebView2Frame, object> CoreWebView2Frame.NameChanged");
			}
		}
#endif
	}
}

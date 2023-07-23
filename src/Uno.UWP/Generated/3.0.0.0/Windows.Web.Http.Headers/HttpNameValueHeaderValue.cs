#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HttpNameValueHeaderValue : global::Windows.Foundation.IStringable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpNameValueHeaderValue.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpNameValueHeaderValue.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpNameValueHeaderValue", "string HttpNameValueHeaderValue.Value");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpNameValueHeaderValue.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpNameValueHeaderValue.Name");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpNameValueHeaderValue( string name) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpNameValueHeaderValue", "HttpNameValueHeaderValue.HttpNameValueHeaderValue(string name)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpNameValueHeaderValue.HttpNameValueHeaderValue(string)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpNameValueHeaderValue( string name,  string value) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpNameValueHeaderValue", "HttpNameValueHeaderValue.HttpNameValueHeaderValue(string name, string value)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpNameValueHeaderValue.HttpNameValueHeaderValue(string, string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpNameValueHeaderValue.Name.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpNameValueHeaderValue.Value.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpNameValueHeaderValue.Value.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpNameValueHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpNameValueHeaderValue.ToString%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpNameValueHeaderValue Parse( string input)
		{
			throw new global::System.NotImplementedException("The member HttpNameValueHeaderValue HttpNameValueHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpNameValueHeaderValue%20HttpNameValueHeaderValue.Parse%28string%20input%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( string input, out global::Windows.Web.Http.Headers.HttpNameValueHeaderValue nameValueHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpNameValueHeaderValue.TryParse(string input, out HttpNameValueHeaderValue nameValueHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpNameValueHeaderValue.TryParse%28string%20input%2C%20out%20HttpNameValueHeaderValue%20nameValueHeaderValue%29");
		}
#endif
	}
}

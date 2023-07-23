#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class FindAllAccountsResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Credentials.WebAccount> Accounts
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<WebAccount> FindAllAccountsResult.Accounts is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CWebAccount%3E%20FindAllAccountsResult.Accounts");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Security.Authentication.Web.Core.WebProviderError ProviderError
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebProviderError FindAllAccountsResult.ProviderError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebProviderError%20FindAllAccountsResult.ProviderError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Security.Authentication.Web.Core.FindAllWebAccountsStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member FindAllWebAccountsStatus FindAllAccountsResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=FindAllWebAccountsStatus%20FindAllAccountsResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Security.Authentication.Web.Core.FindAllAccountsResult.Accounts.get
		// Forced skipping of method Windows.Security.Authentication.Web.Core.FindAllAccountsResult.Status.get
		// Forced skipping of method Windows.Security.Authentication.Web.Core.FindAllAccountsResult.ProviderError.get
	}
}

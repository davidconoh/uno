#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WebAccountEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Security.Credentials.WebAccount Account
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebAccount WebAccountEventArgs.Account is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebAccount%20WebAccountEventArgs.Account");
			}
		}
#endif
		// Forced skipping of method Windows.Security.Authentication.Web.Core.WebAccountEventArgs.Account.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.AppService
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StatelessAppServiceResponse 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Collections.ValueSet Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet StatelessAppServiceResponse.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20StatelessAppServiceResponse.Message");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.AppService.StatelessAppServiceResponseStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StatelessAppServiceResponseStatus StatelessAppServiceResponse.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StatelessAppServiceResponseStatus%20StatelessAppServiceResponse.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.AppService.StatelessAppServiceResponse.Message.get
		// Forced skipping of method Windows.ApplicationModel.AppService.StatelessAppServiceResponse.Status.get
	}
}

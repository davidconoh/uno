#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.AppService
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AppServiceResponse 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Collections.ValueSet Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet AppServiceResponse.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20AppServiceResponse.Message");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.AppService.AppServiceResponseStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppServiceResponseStatus AppServiceResponse.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppServiceResponseStatus%20AppServiceResponse.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.AppService.AppServiceResponse.Message.get
		// Forced skipping of method Windows.ApplicationModel.AppService.AppServiceResponse.Status.get
	}
}

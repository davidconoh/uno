#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.AppService
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AppServiceClosedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.AppService.AppServiceClosedStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppServiceClosedStatus AppServiceClosedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppServiceClosedStatus%20AppServiceClosedEventArgs.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.AppService.AppServiceClosedEventArgs.Status.get
	}
}

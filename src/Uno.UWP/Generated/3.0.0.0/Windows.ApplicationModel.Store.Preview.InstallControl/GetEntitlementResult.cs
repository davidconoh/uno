#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class GetEntitlementResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member GetEntitlementStatus GetEntitlementResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GetEntitlementStatus%20GetEntitlementResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementResult.Status.get
	}
}

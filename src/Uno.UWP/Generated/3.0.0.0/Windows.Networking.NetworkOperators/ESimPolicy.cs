#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ESimPolicy 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool ShouldEnableManagingUi
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimPolicy.ShouldEnableManagingUi is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ESimPolicy.ShouldEnableManagingUi");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimPolicy.ShouldEnableManagingUi.get
	}
}

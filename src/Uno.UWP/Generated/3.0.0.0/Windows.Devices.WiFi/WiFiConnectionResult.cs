#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFi
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WiFiConnectionResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.WiFi.WiFiConnectionStatus ConnectionStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member WiFiConnectionStatus WiFiConnectionResult.ConnectionStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WiFiConnectionStatus%20WiFiConnectionResult.ConnectionStatus");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.WiFi.WiFiConnectionResult.ConnectionStatus.get
	}
}

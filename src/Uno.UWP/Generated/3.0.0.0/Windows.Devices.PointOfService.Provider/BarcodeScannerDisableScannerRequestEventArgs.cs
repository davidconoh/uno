#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService.Provider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class BarcodeScannerDisableScannerRequestEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.PointOfService.Provider.BarcodeScannerDisableScannerRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerDisableScannerRequest BarcodeScannerDisableScannerRequestEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BarcodeScannerDisableScannerRequest%20BarcodeScannerDisableScannerRequestEventArgs.Request");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.PointOfService.Provider.BarcodeScannerDisableScannerRequestEventArgs.Request.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral BarcodeScannerDisableScannerRequestEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20BarcodeScannerDisableScannerRequestEventArgs.GetDeferral%28%29");
		}
#endif
	}
}

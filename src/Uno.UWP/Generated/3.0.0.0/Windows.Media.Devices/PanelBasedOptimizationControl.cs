#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PanelBasedOptimizationControl 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Enumeration.Panel Panel
		{
			get
			{
				throw new global::System.NotImplementedException("The member Panel PanelBasedOptimizationControl.Panel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Panel%20PanelBasedOptimizationControl.Panel");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.PanelBasedOptimizationControl", "Panel PanelBasedOptimizationControl.Panel");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PanelBasedOptimizationControl.IsSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PanelBasedOptimizationControl.IsSupported");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.PanelBasedOptimizationControl.IsSupported.get
		// Forced skipping of method Windows.Media.Devices.PanelBasedOptimizationControl.Panel.get
		// Forced skipping of method Windows.Media.Devices.PanelBasedOptimizationControl.Panel.set
	}
}

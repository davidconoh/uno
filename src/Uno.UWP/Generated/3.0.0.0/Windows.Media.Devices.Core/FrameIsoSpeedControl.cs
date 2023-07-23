#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class FrameIsoSpeedControl 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint? Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? FrameIsoSpeedControl.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20FrameIsoSpeedControl.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.FrameIsoSpeedControl", "uint? FrameIsoSpeedControl.Value");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Auto
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FrameIsoSpeedControl.Auto is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FrameIsoSpeedControl.Auto");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.FrameIsoSpeedControl", "bool FrameIsoSpeedControl.Auto");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.Core.FrameIsoSpeedControl.Auto.get
		// Forced skipping of method Windows.Media.Devices.Core.FrameIsoSpeedControl.Auto.set
		// Forced skipping of method Windows.Media.Devices.Core.FrameIsoSpeedControl.Value.get
		// Forced skipping of method Windows.Media.Devices.Core.FrameIsoSpeedControl.Value.set
	}
}

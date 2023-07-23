#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input.Custom
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class GipFirmwareUpdateResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint ExtendedErrorCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint GipFirmwareUpdateResult.ExtendedErrorCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20GipFirmwareUpdateResult.ExtendedErrorCode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint FinalComponentId
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint GipFirmwareUpdateResult.FinalComponentId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20GipFirmwareUpdateResult.FinalComponentId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Gaming.Input.Custom.GipFirmwareUpdateStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member GipFirmwareUpdateStatus GipFirmwareUpdateResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GipFirmwareUpdateStatus%20GipFirmwareUpdateResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Gaming.Input.Custom.GipFirmwareUpdateResult.ExtendedErrorCode.get
		// Forced skipping of method Windows.Gaming.Input.Custom.GipFirmwareUpdateResult.FinalComponentId.get
		// Forced skipping of method Windows.Gaming.Input.Custom.GipFirmwareUpdateResult.Status.get
	}
}

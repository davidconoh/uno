#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RadialControllerButtonHoldingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.RadialControllerScreenContact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member RadialControllerScreenContact RadialControllerButtonHoldingEventArgs.Contact is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RadialControllerScreenContact%20RadialControllerButtonHoldingEventArgs.Contact");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Haptics.SimpleHapticsController SimpleHapticsController
		{
			get
			{
				throw new global::System.NotImplementedException("The member SimpleHapticsController RadialControllerButtonHoldingEventArgs.SimpleHapticsController is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SimpleHapticsController%20RadialControllerButtonHoldingEventArgs.SimpleHapticsController");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.RadialControllerButtonHoldingEventArgs.Contact.get
		// Forced skipping of method Windows.UI.Input.RadialControllerButtonHoldingEventArgs.SimpleHapticsController.get
	}
}

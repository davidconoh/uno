#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class GattWriteRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession Session
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattSession GattWriteRequestedEventArgs.Session is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GattSession%20GattWriteRequestedEventArgs.Session");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteRequestedEventArgs.Session.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral GattWriteRequestedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20GattWriteRequestedEventArgs.GetDeferral%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteRequest> GetRequestAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<GattWriteRequest> GattWriteRequestedEventArgs.GetRequestAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CGattWriteRequest%3E%20GattWriteRequestedEventArgs.GetRequestAsync%28%29");
		}
#endif
	}
}

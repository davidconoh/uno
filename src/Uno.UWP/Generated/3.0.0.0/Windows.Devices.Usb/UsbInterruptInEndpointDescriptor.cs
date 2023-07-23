#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UsbInterruptInEndpointDescriptor 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public byte EndpointNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbInterruptInEndpointDescriptor.EndpointNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%20UsbInterruptInEndpointDescriptor.EndpointNumber");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.TimeSpan Interval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan UsbInterruptInEndpointDescriptor.Interval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20UsbInterruptInEndpointDescriptor.Interval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MaxPacketSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbInterruptInEndpointDescriptor.MaxPacketSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20UsbInterruptInEndpointDescriptor.MaxPacketSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Usb.UsbInterruptInPipe Pipe
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbInterruptInPipe UsbInterruptInEndpointDescriptor.Pipe is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbInterruptInPipe%20UsbInterruptInEndpointDescriptor.Pipe");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.MaxPacketSize.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.EndpointNumber.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.Interval.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.Pipe.get
	}
}

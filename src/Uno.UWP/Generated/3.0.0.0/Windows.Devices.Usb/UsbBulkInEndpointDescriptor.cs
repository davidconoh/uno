#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UsbBulkInEndpointDescriptor 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public byte EndpointNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbBulkInEndpointDescriptor.EndpointNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%20UsbBulkInEndpointDescriptor.EndpointNumber");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MaxPacketSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbBulkInEndpointDescriptor.MaxPacketSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20UsbBulkInEndpointDescriptor.MaxPacketSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Usb.UsbBulkInPipe Pipe
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbBulkInPipe UsbBulkInEndpointDescriptor.Pipe is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbBulkInPipe%20UsbBulkInEndpointDescriptor.Pipe");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.MaxPacketSize.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.EndpointNumber.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkInEndpointDescriptor.Pipe.get
	}
}
